using BehaviorialPatterns.DomainModels;
using System;

namespace BehaviorialPatterns.ChainOfResponsibility
{
    public class AuthenticationRequestHandler : IHandler
    {
        private IHandler _nextRequestHandler;

        public void Invoke(Request request)
        {
            Console.WriteLine($"{request.Id}: Inside AuthenticationRequestHandler....Authenticating Request.... For Login: {request.LoginId}");
            request.IsAuthenticated = true;

            if (_nextRequestHandler != null)
            {
                Console.WriteLine($"{request.Id}: Inside AuthenticationRequestHandler...Invoking Authorization Handler Next...");
                _nextRequestHandler.Invoke(request);
            }
        }

        public void SetNextHandler(IHandler nextHandler)  => _nextRequestHandler = nextHandler;
     
    }
}
