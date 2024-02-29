Console.WriteLine("Engine wird gestartet");
WebLogic user = new WebLogic();

Console.WriteLine("Timer startet");
Stopwatch stopwatch = Stopwatch.StartNew();

await Jason.StartLogic(user);
stopwatch.Stop();

Console.WriteLine("Ende");
Console.WriteLine($"{stopwatch.ElapsedMilliseconds}");

Console.ReadLine();
