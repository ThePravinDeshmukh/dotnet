using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Doo
    {

        public async Task A()
        {
            Console.WriteLine("Started A");
            await Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine("Finished A");
        }
        public async Task B()
        {
            Console.WriteLine("Started B");
            await Task.Run(() => Thread.Sleep(1000));
            Console.WriteLine("Finished B");
        }
    }
}
