using System.Collections.Concurrent;
using EventEase.App.Components.Models;

namespace EventEase.App.Components.Services
{
    public class AttendanceService
    {
        private readonly ConcurrentDictionary<int, int> _attendance = new();
        private readonly ConcurrentDictionary<int, List<RegistrationModel>> _registrations = new();
        private readonly ConcurrentDictionary<string, List<int>> _userRegistrations = new();

        public void Register(RegistrationModel registration)
        {
            var eventId = registration.EventId;
            
            // Update attendance count
            _attendance.AddOrUpdate(eventId, 1, (_, old) => old + 1);
            
            // Store detailed registration
            _registrations.AddOrUpdate(eventId, 
                new List<RegistrationModel> { registration },
                (_, existing) => 
                {
                    existing.Add(registration);
                    return existing;
                });
            
            // Track user registrations
            var userKey = registration.Email.ToLowerInvariant();
            _userRegistrations.AddOrUpdate(userKey,
                new List<int> { eventId },
                (_, existing) =>
                {
                    if (!existing.Contains(eventId))
                        existing.Add(eventId);
                    return existing;
                });
        }

        public int GetAttendance(int eventId)
        {
            return _attendance.TryGetValue(eventId, out var count) ? count : 0;
        }

        public List<RegistrationModel> GetRegistrations(int eventId)
        {
            return _registrations.TryGetValue(eventId, out var registrations) ? registrations : new List<RegistrationModel>();
        }

        public List<int> GetUserRegistrations(string email)
        {
            var userKey = email.ToLowerInvariant();
            return _userRegistrations.TryGetValue(userKey, out var registrations) ? registrations : new List<int>();
        }

        public bool IsUserRegistered(string email, int eventId)
        {
            var userRegistrations = GetUserRegistrations(email);
            return userRegistrations.Contains(eventId);
        }

        public Dictionary<int, int> GetAllAttendanceStats()
        {
            return new Dictionary<int, int>(_attendance);
        }

        public int GetTotalRegistrations()
        {
            return _attendance.Values.Sum();
        }

        public void CancelRegistration(string email, int eventId)
        {
            var userKey = email.ToLowerInvariant();
            if (_userRegistrations.TryGetValue(userKey, out var userRegistrations))
            {
                userRegistrations.Remove(eventId);
            }

            if (_registrations.TryGetValue(eventId, out var eventRegistrations))
            {
                eventRegistrations.RemoveAll(r => r.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            }

            _attendance.AddOrUpdate(eventId, 0, (_, old) => Math.Max(0, old - 1));
        }
    }
}
