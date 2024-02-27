

namespace BeeckerWebLurker.Logic;

internal class TempTask
{
    public RequestModel[]? People;

    

    public static async Task CrackTask(WebLogic Session)
    {
        Console.WriteLine("Await Methode fürs Füllen wird gestartet");
        RequestModel[] People = await Session.client.GetFromJsonAsync<RequestModel[]>(Session.client.BaseAddress);

        
    }

    public static void printPeople(RequestModel[] People)
    {
        if (People != null)
        {
            int i = 1;
            foreach (RequestModel p in People)
            {
                Console.WriteLine(p.title);
                Console.WriteLine(p.body);
                i++;
            }
        }


    }

    public static void test(WebLogic Session)
    {
        


    }
}
