using System.Text;

namespace BeeckerWebLurker.Core;


public class TcpServer
{
    private TcpListener _listener;

    public TcpServer()
    {
        StartTcpListener();
    }

    public async void StartTcpListener()
    {
        var port = 13000;
        var hostAdress = IPAddress.Parse("127.0.0.1");

        _listener = new TcpListener(hostAdress, port);
        _listener.Start();

        byte[] buffer = new byte[1024];

        using TcpClient client = _listener.AcceptTcpClient();

        var topStream = client.GetStream();

        int readTotal;
        string receivedMessage;

        while((readTotal = topStream.Read(buffer, 0, buffer.Length))!=0)
        {
            receivedMessage = Encoding.UTF8.GetString(buffer, 0, readTotal);
            var response = Encoding.UTF8.GetBytes($"Die Nachricht {receivedMessage} wurde empfangen\r\n");
            topStream.Write(response, 0, response.Length);

            readTotal = topStream.Read(buffer, 0, buffer.Length);
        }
        


    }
}
