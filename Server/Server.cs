using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private TcpClient client;


        public Server()
        {
            InitializeComponent();
        }

        private async void Server_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();
            toolStripStatusLabel1.Text = "Waiting for connections...";
            client = await listener.AcceptTcpClientAsync();
            toolStripStatusLabel1.Text = "Client connected.";
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int input;
                    try
                    {
                        input = await stream.ReadAsync(buffer, 0, buffer.Length);
                    }
                    catch
                    {
                        break;
                    }

                    if (input == 0)
                        break;

                    string message = Encoding.UTF8.GetString(buffer, 0, input);
                    textBox1.Text = message;
                }
                toolStripStatusLabel1.Text = "Client disconnected.";
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener?.Dispose();
            client?.Dispose();
        }
    }
}
