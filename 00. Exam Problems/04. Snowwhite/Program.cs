using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physic { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var colorsToDwarfs = new Dictionary<string, List<Dwarf>>();
            var allDwarfs = new List<Dwarf>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Once upon a time")
                {
                    break;
                }

                string[] dwarfInfo = line
                    .Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physic = int.Parse(dwarfInfo[2]);

                if (!colorsToDwarfs.ContainsKey(color))
                {
                    colorsToDwarfs[color] = new List<Dwarf>();
                }

                var dwarsByCurrentColor = colorsToDwarfs[color];

                var foundDwarf = dwarsByCurrentColor
                    .FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physic = Math.Max(physic, foundDwarf.Physic);
                }
                else
                {
                    var dwarf = new Dwarf
                    {
                        Name = name,
                        Color = color,
                        Physic = physic
                    };

                    dwarsByCurrentColor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }
            }

            var result = allDwarfs
                .OrderByDescending(d => d.Physic)
                .ThenByDescending(d => colorsToDwarfs[d.Color].Count())
                .ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physic}");
            }
        }
    }
}