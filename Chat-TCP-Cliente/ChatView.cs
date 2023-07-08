using SuperSimpleTcp;
using System.Text;

namespace Chat_TCP_Cliente
{
    public partial class ChatView : Form
    {
        SimpleTcpClient cliente;

        public ChatView()
        {
            InitializeComponent();
        }

        private void ChatView_Load(object sender, EventArgs e)
        {
            cliente = new(txtIp.Text, Convert.ToInt32(txtPorta.Text));
            cliente.Events.Connected += Events_Connected;
            cliente.Events.Disconnected += Events_Disconnected;
            cliente.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"Servidor: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"Servidor desconectado.{Environment.NewLine}";
            });

        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"Servidor conectado.{Environment.NewLine}";
            });
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao se conectar com o servidor!{Environment.NewLine}{ex.Message}",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMensagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && cliente.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMensagem.Text))
                {
                    cliente.Send(txtMensagem.Text);
                    txtChat.Text += $"Você: {txtMensagem.Text}{Environment.NewLine}";
                    txtMensagem.Text = "";
                }
            }
        }
    }
}