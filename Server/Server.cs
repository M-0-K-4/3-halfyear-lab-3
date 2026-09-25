using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public partial class Server : Form
    {
        private TcpListener listener;
        private TcpClient client;
        List<int> numbers = new();
        bool AllInt = true;

        public Server()
        {
            InitializeComponent();
            textBox_Input.BorderStyle = BorderStyle.None;
        }

        private async void Server_Load(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();
            toolStripStatusLabel.Text = "Waiting for connection...";
            client = await listener.AcceptTcpClientAsync();
            toolStripStatusLabel.Text = "Client connected ";
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[1024];
                while (true)
                {
                    int inputcount;
                    try
                    {
                        inputcount = await stream.ReadAsync(buffer, 0, buffer.Length);
                    }
                    catch
                    {
                        break;
                    }

                    if (inputcount == 0)
                        break;

                    string input = Encoding.UTF8.GetString(buffer, 0, inputcount);
                    textBox_Input.AppendText("> " + input + Environment.NewLine);

                    string[] message = input.Split(new char[] {' ', ',', '.', ';', ':'});

                    foreach (string part in message)
                    {
                        if (int.TryParse(part.Trim(), out int number))
                        {
                            numbers.Add(number); 
                            AllInt = true;
                        }                                                      
                        else
                            AllInt = false;
                    }
                    if (AllInt == true)
                    {
                        var sortednumbers = numbers.OrderBy(n => n).ToList();
                        byte[] output = Encoding.UTF8.GetBytes(string.Join(", ", sortednumbers));
                        await stream.WriteAsync(output, 0, output.Length);
                        numbers.Clear();
                    }
                }
                toolStripStatusLabel.Text = "Disconnected";
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            listener?.Dispose();
            client?.Dispose();
        }
    }
}
