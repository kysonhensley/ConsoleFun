//Kyson Hensley
//RCET2265
//Fall 2025
//ConsoleFun
//https://github.com/kysonhensley/ConsoleFun.git

namespace ConsoleFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Title = "C# is super edgy";
            
            Console.WriteLine("Write the first line!");
            Console.WriteLine("Write the Second line!");
            Console.WriteLine("Write the Third line!");
            Console.WriteLine("Write the Fourth line!");
            Console.WriteLine("Write the Fifth line!");
            Console.WriteLine("Whew!... I'm tired now");

            int[,] melody = {
                // Close Encounters motif (1:01–1:03)
                { 392, 400 }, // G4
                { 440, 400 }, // A4
                { 349, 400 }, // F4
                { 175, 400 }, // F3 (low)
                { 262, 400 }, // C4
                // Axel F riff, first loop (1:04–1:07)
                { 311, 80 },  // Eb4 (quick)
                { 349, 80 },  // F4 (quick)
                { 415, 150 }, // Ab4
                { 523, 200 }, // C5 (accented)
                { 466, 100 }, // Bb4
                { 415, 100 }, // Ab4
                { 392, 100 }, // G4
                { 349, 200 }, // F4 (accented)
                // Axel F riff, second loop (1:07–1:11)
                { 311, 80 },  // Eb4 (quick)
                { 349, 80 },  // F4 (quick)
                { 415, 150 }, // Ab4
                { 523, 200 }, // C5 (accented)
                { 466, 100 }, // Bb4
                { 415, 100 }, // Ab4
                { 392, 100 }, // G4
                { 349, 250 }  // F4 (longer for end)
            };

            Console.WriteLine("Playing Axel F melody...");

            // Play the melody without pauses
            for (int i = 0; i < melody.GetLength(0); i++)
            {
                Console.Beep(melody[i, 0], melody[i, 1]); // Frequency, Duration
            }

            Console.WriteLine("Done!");
            Console.Read(); // Pause to hear melody and see output
        }
    }
}