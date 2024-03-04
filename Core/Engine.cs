using System;

namespace BeeckerWebLurker.Core;


internal class Engine
{
    public static async Task StartEngine()
    {
        Process.Start(new ProcessStartInfo("cmd", $"/c start {"www.google.de"}") { CreateNoWindow = true });

        /*Console.WriteLine("Engine wird gestartet");
        WebLogic user = new WebLogic();

        Console.WriteLine("Timer startet");
        Stopwatch stopwatch = Stopwatch.StartNew();

        await Jason.StartLogic(user);
        stopwatch.Stop();

        Console.WriteLine("Ende");
        Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");

        Console.ReadLine();*/
    }
}
