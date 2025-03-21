namespace delegate_events
{
    public class Checker
    {
        static void Main(string[] args)
        {

        }
        public Func<int, int> Cube = delegate (int number)
        {
            return number * number * number;
        };

    }
}
