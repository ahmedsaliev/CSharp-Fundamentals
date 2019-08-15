using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamPrep
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = new Dictionary<string, Dictionary<double, string>>();
            var pattern = @"([A-Z]{2})(\d{2}.\d+)(\w+)(\|)";
            while (input != "end")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    var city = match.Groups[1].Value;
                    var temp = double.Parse(match.Groups[2].Value);
                    var typeOfWeather = match.Groups[3].Value;
                    if (!result.ContainsKey(city))
                    {
                        result[city] = new Dictionary<double, string>();
                        result[city].Add(temp, typeOfWeather);

                    }
                    else
                    {
                        result[city] = new Dictionary<double, string> (temp, typeOfWeather);
                    }
                }
                input = Console.ReadLine();
            }

            result = result.OrderBy(x => x.Value.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var d in result)
            {
                Console.WriteLine($"{d.Key} => {d.Value.Key:f2} => {d.Value.Value}");
            }
        }
    }
}

//@"([A-Z]{2})(\d{2}.\d+)(\w+)(\|)"