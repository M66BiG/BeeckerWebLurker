namespace BeeckerWebLurker.Core;

internal class Engine
{
    public static void StartEngine()
    {
        while (true)
        {
            WebLogic user = WebLogic.StartSession();

            Jason.StartLogic(user);



            Console.WriteLine("Timer startet");
            Task.Delay(10000);
            Console.WriteLine("Ende");
            break;
        }
        
    }
}
