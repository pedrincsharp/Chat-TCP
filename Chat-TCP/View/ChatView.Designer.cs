namespace Chat_TCP
{
    partial class ChatView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatView));
            label3 = new Label();
            label2 = new Label();
            lstClientes = new ListBox();
            txtPorta = new TextBox();
            txtIp = new TextBox();
            label1 = new Label();
            txtChat = new TextBox();
            txtMensagem = new TextBox();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 11);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 11;
            label3.Text = "Porta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 11);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 10;
            label2.Text = "Clientes conectados:";
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(340, 29);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(186, 409);
            lstClientes.TabIndex = 9;
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(249, 29);
            txtPorta.Name = "txtPorta";
            txtPorta.PlaceholderText = "Porta";
            txtPorta.Size = new Size(85, 23);
            txtPorta.TabIndex = 8;
            txtPorta.Text = "9000";
            // 
            // txtIp
            // 
            txtIp.Enabled = false;
            txtIp.Location = new Point(8, 29);
            txtIp.Name = "txtIp";
            txtIp.PlaceholderText = "Digite o IP";
            txtIp.Size = new Size(235, 23);
            txtIp.TabIndex = 7;
            txtIp.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 6;
            label1.Text = "Servidor:";
            // 
            // txtChat
            // 
            txtChat.Enabled = false;
            txtChat.Location = new Point(8, 58);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(326, 351);
            txtChat.TabIndex = 12;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(8, 415);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(245, 23);
            txtMensagem.TabIndex = 13;
            txtMensagem.KeyDown += txtMensagem_KeyDown;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(259, 415);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 14;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // ChatView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(540, 446);
            Controls.Add(btnConectar);
            Controls.Add(txtMensagem);
            Controls.Add(txtChat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstClientes);
            Controls.Add(txtPorta);
            Controls.Add(txtIp);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChatView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chat";
            Load += ChatView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private ListBox lstClientes;
        private TextBox txtPorta;
        private TextBox txtIp;
        private Label label1;
        private TextBox txtChat;
        private TextBox txtMensagem;
        private Button btnConectar;
    }
}