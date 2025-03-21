namespace delegate_events
{
    public class Checker
    {
        public Func<int[], int[]> OddList = x =>
        {
            var result = new List<int>();

            foreach(var num in x)
            {
                if(num % 2 != 0)
                {
                    result.Add(num);
                }
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {

        }
    }
}
