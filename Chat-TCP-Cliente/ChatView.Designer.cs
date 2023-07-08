namespace Chat_TCP_Cliente
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
            btnConectar = new Button();
            txtMensagem = new TextBox();
            txtChat = new TextBox();
            label3 = new Label();
            txtPorta = new TextBox();
            txtIp = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(262, 415);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 23;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtMensagem
            // 
            txtMensagem.Location = new Point(11, 415);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(245, 23);
            txtMensagem.TabIndex = 22;
            txtMensagem.KeyDown += txtMensagem_KeyDown;
            // 
            // txtChat
            // 
            txtChat.Enabled = false;
            txtChat.Location = new Point(11, 58);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(326, 351);
            txtChat.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 11);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 20;
            label3.Text = "Porta:";
            // 
            // txtPorta
            // 
            txtPorta.Location = new Point(252, 29);
            txtPorta.Name = "txtPorta";
            txtPorta.PlaceholderText = "Porta";
            txtPorta.Size = new Size(85, 23);
            txtPorta.TabIndex = 17;
            txtPorta.Text = "9000";
            // 
            // txtIp
            // 
            txtIp.Location = new Point(11, 29);
            txtIp.Name = "txtIp";
            txtIp.PlaceholderText = "Digite o IP";
            txtIp.Size = new Size(235, 23);
            txtIp.TabIndex = 16;
            txtIp.Text = "127.0.0.1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 11);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 15;
            label1.Text = "Servidor:";
            // 
            // ChatView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(347, 450);
            Controls.Add(btnConectar);
            Controls.Add(txtMensagem);
            Controls.Add(txtChat);
            Controls.Add(label3);
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

        private Button btnConectar;
        private TextBox txtMensagem;
        private TextBox txtChat;
        private Label label3;
        private TextBox txtPorta;
        private TextBox txtIp;
        private Label label1;
    }
}