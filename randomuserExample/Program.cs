using System;

namespace randomuserExample
{
    class Program
    {
        static void Main(string[] args)
        {
            randomuser.Query randomuserQuery = new randomuser.Query();

            Console.WriteLine(randomuserQuery.Info);

            foreach (var results in randomuserQuery.Results)
            {
                Console.WriteLine(results);
            }
        }
    }
}
