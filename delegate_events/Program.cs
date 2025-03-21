namespace delegate_events
{
    public class Checker
    {
        static void Main(string[] args)
        {
           
        }
        public Predicate<int> isEven = delegate (int number)
        {
            return number % 2 == 0;
        };

    }
}
