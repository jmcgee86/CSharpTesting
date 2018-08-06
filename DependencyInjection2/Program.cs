using System;
using System.Collections.Generic;

namespace DependencyInjection2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>();
            workers.Add(new Carpenter(new Cleaner()));
            workers.Add(new Plumber());
            workers.Add(new Electrician());

            var house = new House(workers);

            house.Build();

        }
    }
}
