using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long countOfPictures = long.Parse(Console.ReadLine()); //Number of pictures
            long filterTime = long.Parse(Console.ReadLine()); //In seconds
            long filterFactor = long.Parse(Console.ReadLine()); //The percentage of “good” pictures
            long uploadTime = long.Parse(Console.ReadLine());

            long filteringTime = countOfPictures * filterTime;
            long goodPictures = (long)Math.Ceiling((countOfPictures * (filterFactor / 100.0)));

            long totalSeconds = filteringTime + goodPictures * uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine(time.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
