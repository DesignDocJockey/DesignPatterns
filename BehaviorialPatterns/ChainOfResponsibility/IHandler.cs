namespace BehaviorialPatterns.ChainOfResponsibility
{
    public interface IHandler
    {
        void Invoke(Request request);
        void SetNextHandler(IHandler nextHandler);
    }
}