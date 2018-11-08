using System;
namespace BehaviorialPatterns.ChainOfResponsibility
{
    public class AccessRequestHandler : IHandler
    {
        private IHandler _nextRequestHandler;

        public void Invoke(Request request)
        {
            request.AllowAccess = true;
            Console.WriteLine($"{request.Id}: Inside AccessRequestHandler....Setting up Access Priviliges... For Login: {request.LoginId}");
            Console.WriteLine($"{request.Id}: Allowing Access....For Login: {request.LoginId} ");
        }

        public void SetNextHandler(IHandler nextHandler)
        {}
    }
}
