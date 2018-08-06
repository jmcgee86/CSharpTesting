using System;
using System.Collections.Generic;

namespace DependencyInjection2
{
    public class House
    {
        private readonly List <IWorker> _workerList;

        public House(List <IWorker> workers)
        {
            _workerList = workers;
        }

        public void Build()
        {

        foreach (var worker in _workerList)
        {
            worker.DoWork();
            worker.LeaveInvoice();
        }

        Console.WriteLine("House is Built");
        }
    }
}