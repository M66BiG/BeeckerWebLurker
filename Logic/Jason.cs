namespace BeeckerWebLurker.Logic;

internal class Jason
{
    public static async Task<RequestModel[]> GetJsonTask(WebLogic Session)
    {
        Console.WriteLine("Await Methode fürs Füllen wird gestartet");
        RequestModel[] People = await Session.client.GetFromJsonAsync<RequestModel[]>(Session.client.BaseAddress + "posts"); //warum wird hiernach alles geskippt askfdnsaf
        Console.WriteLine("Await Methode fürs Füllen wird beendet");
        return People;
    }

    public static void printPeople(RequestModel[] People)
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
    public static async void StartLogic(WebLogic Session)
    {
        Console.WriteLine("Async Methode wird gestartet");
        RequestModel[]? People = await GetJsonTask(Session);
        Console.WriteLine("Async Methode wird zuende");

        Console.WriteLine("Print wird gestartet");
        printPeople(People);
        Console.WriteLine("Print wird zuende");
    }
}
