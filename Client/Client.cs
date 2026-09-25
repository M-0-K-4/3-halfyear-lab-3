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

            toolStripStatusLabel.Text = string.Empty;

            button_EXIT.FlatStyle = FlatStyle.Flat;
            button_EXIT.FlatAppearance.BorderSize = 0;
            button_EXIT.FlatAppearance.MouseDownBackColor = button_EXIT.BackColor;

            button_Send.FlatStyle = FlatStyle.Flat;
            button_Send.FlatAppearance.BorderSize = 0;
            button_Send.FlatAppearance.MouseDownBackColor = button_Send.BackColor;

            textBox_Input.BorderStyle = BorderStyle.None;
        }

        private async void Client_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            await client.ConnectAsync("127.0.0.1", 8080);
            stream = client.GetStream();
            toolStripStatusLabel.Text = "Connected to server";

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
                }
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            stream?.Dispose();
            client?.Dispose();
        }

        private void button_Send_MouseEnter(object sender, EventArgs e)
        {
            button_Send.ForeColor = Color.FromArgb(65, 105, 225);
        }

        private void button_Send_MouseLeave(object sender, EventArgs e)
        {
            button_Send.ForeColor = SystemColors.Window;
        }

        private async void button_Send_Click(object sender, EventArgs e)
        {
            button_Send.ForeColor = Color.FromArgb(182, 208, 226);
            await Task.Delay(100);
            button_Send.ForeColor = Color.FromArgb(65, 105, 225);

            if (client == null || !client.Connected)
            {
                toolStripStatusLabel.Text = "No connection to server";
                return;
            }

            string message = textBox_Output.Text;
            if (string.IsNullOrEmpty(message))
                return;

            byte[] output = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(output, 0, output.Length);

            textBox_Output.Text = null;
        }

        private void button_EXIT_MouseEnter(object sender, EventArgs e)
        {
            button_EXIT.ForeColor = Color.FromArgb(210, 4, 45);
        }

        private void button_EXIT_MouseLeave(object sender, EventArgs e)
        {
            button_EXIT.ForeColor = SystemColors.Window;
        }

        private async void button_EXIT_Click(object sender, EventArgs e)
        {
            stream?.Dispose();
            client?.Dispose();
            toolStripStatusLabel.Text = "No connection to server";

            button_EXIT.ForeColor = Color.FromArgb(238, 75, 43);
            await Task.Delay(100);
            button_EXIT.ForeColor = Color.FromArgb(210, 4, 45);
        }

        private void textBox_Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}
