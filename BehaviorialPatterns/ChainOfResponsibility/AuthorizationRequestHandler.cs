using System;
namespace BehaviorialPatterns.ChainOfResponsibility
{
    public class AuthorizationRequestHandler : IHandler
    {
        private IHandler _nextRequestHandler;

        public void Invoke(Request request)
        {
            Console.WriteLine($"{request.Id}: Inside AuthorizationRequestHandler....Authorizing Request....For Login: {request.LoginId}");
            request.IsAuthorized = true;

            if (_nextRequestHandler != null)
            {
                Console.WriteLine($"{request.Id}: Inside AuthorizationRequestHandler....Invoking next Handler...");
                _nextRequestHandler.Invoke(request);
            }
        }

        public void SetNextHandler(IHandler nextHandler)
        {
            _nextRequestHandler = nextHandler;
        }
    }
}
