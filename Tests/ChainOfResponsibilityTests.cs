using System;
using Xunit;
using BehaviorialPatterns.ChainOfResponsibility;
using BehaviorialPatterns.DomainModels;

namespace Tests
{
    public class ChainOfResponsibilityTests
    {
        [Fact]
        public void ASimpleDryRun()
        {
            var request = new Request() {
                Id = Guid.NewGuid(),
                LoginId = "AdminUser1",
                Password = "xxxx123"
            };

            var authenticationHandler = new AuthenticationRequestHandler();
            var authorizationHandler = new AuthorizationRequestHandler();
            var accessHandler = new AccessRequestHandler();
            authenticationHandler.SetNextHandler(authorizationHandler);
            authorizationHandler.SetNextHandler(accessHandler);
            authenticationHandler.Invoke(request);
        }
    }
}
