using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCheckpoint1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Task 2 checked";
            Console.WriteLine("This is the Git checkpoint task 1.1");
            CheckTest.TestMessage(test);
            Calculate.Add(1,2);

        }


    }
}