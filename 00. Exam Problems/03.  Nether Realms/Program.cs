using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main()
        {
            var pattern = @"-?\d+\.?\d*";

            var regex = new Regex(pattern);

            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var demonHealts = new SortedDictionary<string, int>();
            var demonDamages = new SortedDictionary<string, double>();

            foreach (var demon in demons)
            {
                var health = demon
                    .Where(s => !char.IsDigit(s) && s != '+'
                    && s != '-' && s != '*' && s != '/' && s != '.')
                    .Sum(s => (int) s);

                demonHealts[demon] = health;

                var mathces = regex.Matches(demon);

                var damage = 0.0;

                foreach (Match match in mathces)
                {
                    var value = match.Value;
                    damage += double.Parse(value);
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }

                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                demonDamages[demon] = damage;
            }

            foreach (var demon in demonDamages)
            {
                var demonName = demon.Key;
                var demonHealth = demonHealts[demonName];
                var demonDamage = demon.Value;

                Console.WriteLine($"{demonName} - {demonHealth} health, {demonDamage:F2} damage");
            }
        }
    }
}