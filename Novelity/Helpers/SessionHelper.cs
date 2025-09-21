using System;
using System.Collections.Generic;

namespace Novelity.Helpers
{
    public static class SessionHelper
    {
        private static Dictionary<string, object> _session = new Dictionary<string, object>();

        public static int CurrentUserID
        {
            get { return GetValue<int>("CurrentUserID"); }
            set { SetValue("CurrentUserID", value); }
        }

        public static string CurrentUserRole
        {
            get { return GetValue<string>("CurrentUserRole"); }
            set { SetValue("CurrentUserRole", value); }
        }

        public static string SignupName
        {
            get { return GetValue<string>("SignupName"); }
            set { SetValue("SignupName", value); }
        }

        public static string SignupUsername
        {
            get { return GetValue<string>("SignupUsername"); }
            set { SetValue("SignupUsername", value); }
        }

        public static string SignupEmail
        {
            get { return GetValue<string>("SignupEmail"); }
            set { SetValue("SignupEmail", value); }
        }

        public static string SignupPassword
        {
            get { return GetValue<string>("SignupPassword"); }
            set { SetValue("SignupPassword", value); }
        }

        public static int SelectedPlanID
        {
            get { return GetValue<int>("SelectedPlanID"); }
            set { SetValue("SelectedPlanID", value); }
        }

        private static T GetValue<T>(string key)
        {
            if (_session.ContainsKey(key) && _session[key] is T)
            {
                return (T)_session[key];
            }
            return default;
        }

        private static void SetValue(string key, object value)
        {
            _session[key] = value;
        }

        public static void ClearSession()
        {
            _session.Clear();
        }
    }
}