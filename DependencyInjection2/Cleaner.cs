using System;

namespace DependencyInjection2
{
    public class Cleaner : ICleaner
    {
        public void Clean()
        {
            Console.WriteLine("Cleanup Done");
        }
        
    }
}