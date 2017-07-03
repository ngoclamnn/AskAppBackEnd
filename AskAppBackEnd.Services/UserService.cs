using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AskAppBackEnd.Data.Entities;
using AskAppBackEnd.Data;

namespace AskAppBackEnd.Services
{
    public interface IUserService
    {
        IQueryable<User> GetUsers();
        IQueryable<UserFriend> GetUserFriends();
        IQueryable<UserLocation> GetUserLocations();
        IQueryable<UserPreference> GetUserPreferences();
        IQueryable<UserNotification> GetUserNotifications();
        IQueryable<UserResponse> GetUserResponses();
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserFriendRepository _userFriendRepository;
        private readonly IUserLocationRepository _userLocationRepository;
        private readonly IUserPreferenceRepository _userPreferenceRepository;
        private readonly IUserResponsRepository _userReponseRepository;
        private readonly IUserNotificationRepository _userNotificationRepository;

        public UserService(IUserRepository userRepository, IUserFriendRepository userFriendRepository,
            IUserLocationRepository userLocationRepository, IUserPreferenceRepository userPreferenceRepository,
            IUserResponsRepository userReponseRepository, IUserNotificationRepository userNotificationRepository)
        {
            _userRepository = userRepository;
            _userFriendRepository = userFriendRepository;
            _userLocationRepository = userLocationRepository;
            _userPreferenceRepository = userPreferenceRepository;
            _userReponseRepository = userReponseRepository;
            _userNotificationRepository = userNotificationRepository;
        }
        public IQueryable<User> GetUsers()
        {
            return _userRepository.GetAll();
        }
        public IQueryable<UserFriend> GetUserFriends()
        {
            return _userFriendRepository.GetAll();
        }
        public IQueryable<UserLocation> GetUserLocations()
        {
            return _userLocationRepository.GetAll();
        }
        public IQueryable<UserPreference> GetUserPreferences()
        {
            return _userPreferenceRepository.GetAll();
        }
        public IQueryable<UserResponse> GetUserResponses()
        {
            return _userReponseRepository.GetAll();
        }
        public IQueryable<UserNotification> GetUserNotifications()
        {
            return _userNotificationRepository.GetAll();
        }
    }
}
