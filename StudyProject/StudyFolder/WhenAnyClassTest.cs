using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace StudyProject.StudyFolder
{
    class WhenAnyClassTest
    {
        static void Main(string[] args)
        {
            IEnumerable<int> ary = from n in Enumerable.Range(1, 1000) select n;
            List<Task> taskList = new List<Task>();
            int i = 0;
            foreach (int task in ary)
            {
                taskList.Add(ProcessTask(i++));
            }

            Func<Task> example = async () =>
            {
                while (taskList.Count > 0)
                {
                    Task execution = await Task.WhenAny(taskList);

                    taskList.Remove(execution);
                }

            };

            example();
            Thread.Sleep(10000);
        }

        async static Task ProcessTask(int i)
        {
            try
            {
                //Thread.Sleep(2000);
                await Task.Delay(2000);

                throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("Hello!" + i);
            }
        }
    }
}
