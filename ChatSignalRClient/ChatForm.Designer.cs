namespace ChatSignalRClient {
    partial class ChatClient {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.enterChatButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.chatNumberBox = new System.Windows.Forms.TextBox();
            this.exitChatButton = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.serverInfoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(27, 72);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(155, 75);
            this.messageBox.TabIndex = 0;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessageButton.Enabled = false;
            this.sendMessageButton.Location = new System.Drawing.Point(95, 153);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(87, 23);
            this.sendMessageButton.TabIndex = 1;
            this.sendMessageButton.Text = "Send message";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // chatBox
            // 
            this.chatBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(27, 194);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(314, 188);
            this.chatBox.TabIndex = 2;
            // 
            // enterChatButton
            // 
            this.enterChatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterChatButton.Enabled = false;
            this.enterChatButton.Location = new System.Drawing.Point(107, 18);
            this.enterChatButton.Name = "enterChatButton";
            this.enterChatButton.Size = new System.Drawing.Size(75, 25);
            this.enterChatButton.TabIndex = 3;
            this.enterChatButton.Text = "Enter Chat";
            this.enterChatButton.UseVisualStyleBackColor = true;
            this.enterChatButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectButton
            // 
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.Location = new System.Drawing.Point(266, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 36);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect To Server";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // chatNumberBox
            // 
            this.chatNumberBox.Enabled = false;
            this.chatNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatNumberBox.Location = new System.Drawing.Point(27, 18);
            this.chatNumberBox.Multiline = true;
            this.chatNumberBox.Name = "chatNumberBox";
            this.chatNumberBox.Size = new System.Drawing.Size(57, 25);
            this.chatNumberBox.TabIndex = 5;
            this.chatNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitChatButton
            // 
            this.exitChatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitChatButton.Enabled = false;
            this.exitChatButton.Location = new System.Drawing.Point(266, 112);
            this.exitChatButton.Name = "exitChatButton";
            this.exitChatButton.Size = new System.Drawing.Size(75, 35);
            this.exitChatButton.TabIndex = 6;
            this.exitChatButton.Text = "Exit Chat";
            this.exitChatButton.UseVisualStyleBackColor = true;
            this.exitChatButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Location = new System.Drawing.Point(27, 54);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(0, 13);
            this.infoText.TabIndex = 7;
            this.infoText.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverInfoText
            // 
            this.serverInfoText.AutoSize = true;
            this.serverInfoText.ForeColor = System.Drawing.Color.Red;
            this.serverInfoText.Location = new System.Drawing.Point(263, 54);
            this.serverInfoText.Name = "serverInfoText";
            this.serverInfoText.Size = new System.Drawing.Size(76, 13);
            this.serverInfoText.TabIndex = 8;
            this.serverInfoText.Text = "Disconnected!";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 394);
            this.Controls.Add(this.serverInfoText);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.exitChatButton);
            this.Controls.Add(this.chatNumberBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.enterChatButton);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.messageBox);
            this.Name = "ChatClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button enterChatButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox chatNumberBox;
        private System.Windows.Forms.Button exitChatButton;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Label serverInfoText;
    }
}

