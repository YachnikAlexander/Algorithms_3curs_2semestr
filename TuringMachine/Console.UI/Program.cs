using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuringMachine;
using PowerOfTwoMT;
using AdditingWandMT;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstAlphabet = new List<char>() { '0', '1' };
            var firstHead = new Head(new[] { '0', '1', '0', '0', '0', '0' }, 0);
            var firstMachine = new Machine(0,
                                            firstHead,
                                            TableTransition.GetDefaultTable(),
                                            firstAlphabet);
            var firstResult = firstMachine.Run();

            Console.WriteLine("First result is     " + firstResult.Head.ToString());

            var secondAlphabet = new List<char>() { 'a', 'b', '|' };
            var secondHead = new Head(new[] { Head.Blank, 'a', 'a', 'a', 'a', 'a', 'a' }, 0);
            var secondMachine = new Machine(0,
                                            secondHead,
                                            TableTrasitionOfWand.GetDefaultTable(),
                                            secondAlphabet);
            var secondResult = secondMachine.Run();

            Console.WriteLine("Second result is     " + secondResult.Head.ToString());

            Console.ReadKey();
        }
    }
}
