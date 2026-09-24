using System.Net.Sockets;
using System.Text;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Client()
        {
            InitializeComponent();
        }

        private async void Client_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            await client.ConnectAsync("127.0.0.1", 8080);
            stream = client.GetStream();
            toolStripStatusLabel1.Text = "Connected to server.";
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Dispose();
            client?.Dispose();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (client == null || !client.Connected)
            {
                toolStripStatusLabel1.Text = "Not connected to server.";
                return;
            }

            string message = textBox1.Text;
            if (string.IsNullOrEmpty(message))
                return;

            byte[] output = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(output, 0, output.Length);
        }
    }
}
