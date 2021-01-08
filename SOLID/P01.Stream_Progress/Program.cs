using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            Music music = new Music("Milena", "MyFirstSOLID", 20, 3000);
            File file = new File("SOLID", 20, 300);
            StreamProgressInfo musicStream= new StreamProgressInfo(music);
            StreamProgressInfo fileStream = new StreamProgressInfo(file);
            Console.WriteLine(musicStream.CalculateCurrentPercent());
            Console.WriteLine(fileStream.CalculateCurrentPercent());
        }
    }
}
