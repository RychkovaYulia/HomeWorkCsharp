using Homework4;

public class program
{
    static void Main(string[] args)
    {
        Counter1 Counter = new Counter1();
        Handler_1 Handler1 = new Handler_1();
        Handler_2 handler2 = new Handler_2();

        Counter.OnCount += Handler1.Message;
        Counter.OnCount += handler2.Message;
        Counter.Count();
    }
}
