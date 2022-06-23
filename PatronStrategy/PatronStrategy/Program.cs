
using Entity;


namespace PatronStrategy // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Context context = new Context();

            context.Strategy = new ConcreteStrategySubtract();

            Console.WriteLine(context.ExecuteStrategy(2, 1));
        }
    }
}