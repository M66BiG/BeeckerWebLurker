namespace BeeckerWebLurker.Logic;

public class Jason
{
    public async Task<RequestModel[]> GetJsonTask(WebLogic Session)
    {
        Console.WriteLine("Await Methode fürs Füllen wird gestartet");
        RequestModel[]? People = await Session.Client.GetFromJsonAsync<RequestModel[]>(Session.Client.BaseAddress + "posts");
        Console.WriteLine("Await Methode fürs Füllen wird beendet");

        return People;
        
    }

    public void printPeople(RequestModel[] People)
    {
        if (People != null)
        {
            int i = 1;
            foreach (RequestModel p in People)
            {
                Console.Write($"{i}. ");
                Console.WriteLine(p.title);
                Console.WriteLine(p.body);
                i++;
            }
        }
    }
    public static async Task StartLogic(WebLogic Session)
    {
        Jason jason = new();

        jason.printPeople(await jason.GetJsonTask(Session));


    }
}
