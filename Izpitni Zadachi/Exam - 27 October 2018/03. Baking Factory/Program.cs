using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Baking_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> qualityList = new List<int>();
            List<int> lengthList = new List<int>();
            List<double> averageList = new List<double>();
            List<string> inputList = new List<string>();


            while (true)
            {

                string input = Console.ReadLine();

                if (input == "Bake It!")
                {
                    break;
                }

                var array = input.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                inputList.Add(input.Replace('#', ' '));
                qualityList.Add(array.Sum());
                lengthList.Add(array.Length);
                averageList.Add(array.Average());
               
            }

            if (qualityList.Count > 0)
            {
                int maxQuality = qualityList[0];
                int index = 0;
                double maxAverage = averageList[0];
                int minLength = lengthList[0];

                for (int i = 1; i < qualityList.Count; i++)
                {
                    if (qualityList[i] > maxQuality)
                    {
                        index = i;
                        maxQuality = qualityList[i];
                        minLength = lengthList[i];
                        maxAverage = averageList[i];
                        continue;
                    }

                    if (qualityList[i] == maxQuality)
                    {
                        if (averageList[i] > maxAverage)
                        {
                            index = i;
                            maxQuality = qualityList[i];
                            minLength = lengthList[i];
                            maxAverage = averageList[i];
                            continue;
                        }
                    }

                    if (averageList[i] == maxAverage)
                    {
                        if (minLength > lengthList[i])
                        {
                            index = i;
                            maxQuality = qualityList[i];
                            minLength = lengthList[i];
                            maxAverage = averageList[i];
                        }
                    }

                }

                Console.WriteLine("Best Batch quality: {0}", qualityList[index]);
                string result = inputList[index];
                Console.WriteLine(result);
            }
        }
    }
}