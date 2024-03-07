namespace BeeckerWebLurker.Logic;

internal class Jason
{
    public async Task GetJsonTask(WebLogic Session)
    {
        Console.WriteLine("Await Methode fürs Füllen wird gestartet");

        var temp = await Session.client.GetAsync(Session.client.BaseAddress);
        var news = await temp.Content.ReadAsStringAsync();


        Console.WriteLine("Await Methode fürs Füllen wird beendet");
    }

    
    public static async Task StartLogic(WebLogic Session)
    {
        Jason jason = new();

        await jason.GetJsonTask(Session);


    }
}
