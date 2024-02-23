using System;

namespace DependencyInjection
{
    internal class UserService
    {
        private readonly ILogger _logger;

        public UserService(ILogger logger)
        {
            _logger = logger;
        }
        public void RegisterUser(string username)
        {
            // Perform user registration logic
            _logger.Log($"User '{username}' registered.");
        }
    }
}
