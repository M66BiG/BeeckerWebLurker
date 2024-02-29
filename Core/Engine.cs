using System.Diagnostics;
namespace BeeckerWebLurker.Core;


internal class Engine
{
    public static void StartEngine()
    {

        WebLogic user = WebLogic.StartSession();

        Console.WriteLine("Timer startet");
        Stopwatch stopwatch = Stopwatch.StartNew();

        Jason.StartLogic(user).Wait();
        stopwatch.Stop();
        Console.WriteLine("Ende");

        Console.WriteLine("Ende"); Console.WriteLine("Ende"); Console.WriteLine("Ende"); Console.WriteLine("Ende");

        Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");
    }
}
