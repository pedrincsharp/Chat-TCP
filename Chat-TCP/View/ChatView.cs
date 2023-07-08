using SuperSimpleTcp;
using System.Text;

namespace Chat_TCP
{
    public partial class ChatView : Form
    {
        bool isConnected = false;
        SimpleTcpServer server;

        public ChatView()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            txtChat.Text = "";
            txtChat.Text += $"Conexão iniciada...{Environment.NewLine}";
            btnConectar.Enabled = false;
            isConnected = true;
            server.Start();
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                lstClientes.Items.Add(e.IpPort);
            });
        }

        private void ChatView_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(txtIp.Text, Convert.ToInt32(txtPorta.Text));
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                lstClientes.Items.Remove(e.IpPort);
            });
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && isConnected)
            {
                if (!string.IsNullOrEmpty(txtMensagem.Text) && lstClientes.SelectedItem != null)
                {
                    server.Send(lstClientes.SelectedItem.ToString(), Encoding.UTF8.GetBytes(txtMensagem.Text));
                    txtChat.Text += $"Servidor: {txtMensagem.Text}{Environment.NewLine}";
                    txtMensagem.Text = "";
                }
                else
                {
                    MessageBox.Show("Necessário selecionar um cliente!", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}