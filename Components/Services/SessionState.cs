using System.Collections.Concurrent;

namespace EventEase.App.Components.Services
{
    public class SessionState
    {
        public string? CurrentUserName { get; set; }
        public string? CurrentUserEmail { get; set; }
        public string? CurrentUserPhone { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public List<int> RegisteredEventIds { get; set; } = new();
        public Dictionary<string, object> UserPreferences { get; set; } = new();

        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUserEmail);

        public void Login(string name, string email, string? phone = null)
        {
            CurrentUserName = name;
            CurrentUserEmail = email;
            CurrentUserPhone = phone;
            LastLoginTime = DateTime.Now;
        }

        public void Logout()
        {
            CurrentUserName = null;
            CurrentUserEmail = null;
            CurrentUserPhone = null;
            LastLoginTime = null;
            RegisteredEventIds.Clear();
            UserPreferences.Clear();
        }

        public void RegisterForEvent(int eventId)
        {
            if (!RegisteredEventIds.Contains(eventId))
            {
                RegisteredEventIds.Add(eventId);
            }
        }

        public bool IsRegisteredForEvent(int eventId)
        {
            return RegisteredEventIds.Contains(eventId);
        }

        public void SetPreference(string key, object value)
        {
            UserPreferences[key] = value;
        }

        public T? GetPreference<T>(string key)
        {
            if (UserPreferences.TryGetValue(key, out var value) && value is T typedValue)
            {
                return typedValue;
            }
            return default;
        }
    }
}
