using System;

namespace BehaviorialPatterns.ChainOfResponsibility
{
    public class VacationRequestHandler: IHandler
    {
        private IHandler _nextRequestHandler;

        public void Invoke(Request request)
        {
            _nextRequestHandler.Invoke(request);
        }

        public void SetNextHandler(IHandler nextHandler) {
            _nextRequestHandler = nextHandler;
        }
    }
}
