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

                    string[] digit_message = input.Split(new char[] {' ', ',', '.', ';', ':'});

                    List<int> numbers = new();
                    bool AllInt = true;
                    foreach (string part in digit_message)
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
                    else
                    {
                        List<char> string_message = new();
                        foreach (char part in input)
                        {
                            string_message.Add(part);
                        }
                        Random random = new();
                        int replace_count = string_message.Count / 2;
                        char temp;
                        int position_old;
                        int position_new;
                        for (int i = 0; i < replace_count; i++)
                        {
                            position_old = random.Next(0, string_message.Count);
                            position_new = random.Next(0, string_message.Count);
                            temp = string_message[position_old];
                            string_message[position_old] = string_message[position_new];
                            string_message[position_new] = temp;
                        }
                        byte[] output = Encoding.UTF8.GetBytes(string.Join("", string_message));
                        await stream.WriteAsync(output, 0, output.Length);
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
