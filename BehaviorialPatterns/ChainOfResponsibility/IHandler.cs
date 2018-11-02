namespace BehaviorialPatterns.ChainOfResponsibility
{
    //https://www.youtube.com/watch?v=jDX6x8qmjbA
    public interface IHandler
    {
        void Invoke(Request request);
        void SetNextHandler(IHandler nextHandler);
    }
}