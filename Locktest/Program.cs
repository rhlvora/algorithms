using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Locktest
{
    class Program
    {
		static object _lockobj = new object();

        static async Task Main(string[] args)
        {

			List<Task> TaskList = new List<Task>();

			//build up enumerable of tasks
			for(int i = 0; i < 10; i++)
			{
				var x = Task.Run(() => Function());

				TaskList.Add(x);
			}

			//wait for all tasks to complete
			await Task.WhenAll(TaskList);

        }

		static async Task Function()
		{
			Console.WriteLine("Waiting on lock");

			lock(_lockobj)
			{
				Thread.Sleep(300);
				Console.WriteLine("Obtained lock");
			}

		}
    }
}
