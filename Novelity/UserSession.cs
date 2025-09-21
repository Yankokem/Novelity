using System;
using System.IO;
using System.Xml.Serialization;

namespace Novelity
{
    public static class UserSession
    {
        private static string SessionFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Novelity", "session.xml");

        public static int UserID { get; private set; }
        public static string Username { get; private set; }
        public static string Email { get; private set; }
        public static string FirstName { get; private set; }
        public static string LastName { get; private set; }
        public static string Role { get; private set; }
        public static string PlanName { get; private set; }
        public static bool IsLoggedIn { get; private set; }
        public static bool IsAdmin => Role == "Admin";
        public static bool IsCustomer => Role == "Customer";

        public static void CreateSession(int userID, string username, string email, string firstName,
                                       string lastName, string role, string planName = null)
        {
            UserID = userID;
            Username = username;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            PlanName = planName;
            IsLoggedIn = true;

            // Save session to file
            SaveSession();
        }

        public static void ClearSession()
        {
            UserID = 0;
            Username = null;
            Email = null;
            FirstName = null;
            LastName = null;
            Role = null;
            PlanName = null;
            IsLoggedIn = false;

            // Delete session file
            if (File.Exists(SessionFile))
                File.Delete(SessionFile);
        }

        public static bool LoadSession()
        {
            try
            {
                if (File.Exists(SessionFile))
                {
                    var serializer = new XmlSerializer(typeof(SessionData));
                    using (var reader = new StreamReader(SessionFile))
                    {
                        var sessionData = (SessionData)serializer.Deserialize(reader);

                        UserID = sessionData.UserID;
                        Username = sessionData.Username;
                        Email = sessionData.Email;
                        FirstName = sessionData.FirstName;
                        LastName = sessionData.LastName;
                        Role = sessionData.Role;
                        PlanName = sessionData.PlanName;
                        IsLoggedIn = sessionData.IsLoggedIn;

                        return true;
                    }
                }
            }
            catch
            {
                // If loading fails, clear the session
                ClearSession();
            }
            return false;
        }

        private static void SaveSession()
        {
            try
            {
                // Create directory if it doesn't exist
                Directory.CreateDirectory(Path.GetDirectoryName(SessionFile));

                var sessionData = new SessionData
                {
                    UserID = UserID,
                    Username = Username,
                    Email = Email,
                    FirstName = FirstName,
                    LastName = LastName,
                    Role = Role,
                    PlanName = PlanName,
                    IsLoggedIn = IsLoggedIn
                };

                var serializer = new XmlSerializer(typeof(SessionData));
                using (var writer = new StreamWriter(SessionFile))
                {
                    serializer.Serialize(writer, sessionData);
                }
            }
            catch
            {
                // Ignore errors during save
            }
        }

        public static string GetDisplayRole()
        {
            if (Role == "Admin")
                return "Administrator";
            else if (Role == "Customer" && !string.IsNullOrEmpty(PlanName))
                return $"{PlanName} Member";
            else
                return Role;
        }

        public static string GetFullName() => $"{FirstName} {LastName}";

        [Serializable]
        public class SessionData
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Role { get; set; }
            public string PlanName { get; set; }
            public bool IsLoggedIn { get; set; }
        }
    }
}