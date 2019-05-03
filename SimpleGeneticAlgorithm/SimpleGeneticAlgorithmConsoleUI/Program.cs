using SimpleGeneticAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGeneticAlgorithmConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            int worldSize = 4;
            int geneCount = 6;
            int crossOverChance = 30;
            int mutationChance = 5;
            World world = new World(geneCount, worldSize, crossOverChance, mutationChance);
            world.InitializePopulation();

            // Act
            int generation = 0;
            Genome champion = null;
            while (champion == null)
            {
                world.Mutate();
                world.CrossOver();
                world.NextGeneration();
                Console.WriteLine(world);

                generation++;
                champion = world.GetChampion();
            }

            Console.WriteLine("A new leader is born! generation {0} - {1}", generation, champion);

            Console.ReadKey();
        }
    }

    public class RandomStub : Random
    {
        private int[] _randomNumbers;
        private int _currentPosition;

        public RandomStub(params int[] randomNumbers)
        {
            _randomNumbers = randomNumbers;
        }

        public override int Next(int minValue, int maxValue)
        {
            if (++_currentPosition > _randomNumbers.Length - 1)
                _currentPosition = 0;

            int result = _randomNumbers[_currentPosition];

            return result;
        }
    }
}
