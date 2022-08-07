using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSignalRClient {
    public partial class ChatClient : Form {
        private HubConnection _connection;
        private bool isConnectedToServer { get { return _connection != null; } }
        private int currentChatId;

        public ChatClient() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            _connection.InvokeAsync("SendMessage", currentChatId, messageBox.Text);
            messageBox.Text = String.Empty;
        }

        private async void button2_Click(object sender, EventArgs e) {
            try {
                if(currentChatId > 0) {
                    throw new Exception("Can't connect to more than one chat at once");
                }

                int chatId = 0;
                if(!int.TryParse(chatNumberBox.Text, out chatId)) {
                    throw new Exception("Invalid chat number");
                }

                await EnterChat(chatId);
                currentChatId = chatId;
                chatNumberBox.Text = String.Empty;
                infoText.ForeColor = Color.Green;
                infoText.Text = "Currently connected to chat " + chatId;
                messageBox.Enabled = true;
                exitChatButton.Enabled = true;
                enterChatButton.Enabled = false;
                chatNumberBox.Enabled = false;
                sendMessageButton.Enabled = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to enter chat: " + ex.Message);
            }
        }

        private async Task EnterChat(int chatId) {
            if (!isConnectedToServer) {
                throw new Exception("Not connected to server");
            }
            await _connection.InvokeAsync("EnterChat", chatId);
            _connection.On<object>("realtimeMessage", param => {
                if (chatBox.Text.Length == 0 || chatBox.Text.Length > 200) {
                    chatBox.AppendText(param.ToString() + Environment.NewLine);
                }
                else {
                    chatBox.AppendText(Environment.NewLine + param.ToString() + Environment.NewLine);
                }
            });
        }

        private async void button3_Click(object sender, EventArgs e) {
            try {
                await ConnectToServer();
                serverInfoText.ForeColor = Color.Green;
                serverInfoText.Text = "Connected!";
                connectButton.Enabled = false;
                enterChatButton.Enabled = true;
                chatNumberBox.Enabled = true;
            }
            catch (Exception) {
                MessageBox.Show("Failed to connect to server");
            }
        }

        private async Task ConnectToServer() {
            string hubUrl = "http://localhost:5000/chatHub";

            _connection = new HubConnectionBuilder()
                .WithUrl(hubUrl)
                .WithAutomaticReconnect()
                .Build();

            await _connection.StartAsync();
        }

        private async Task ExitChat() {
            await _connection.InvokeAsync("ExitChat", currentChatId);
            _connection.Remove("realtimeMessage");

            currentChatId = 0;
            infoText.ForeColor = Color.Red;
            infoText.Text = "Disconnected from chat";
        }

        private async void button4_Click(object sender, EventArgs e) {
            try {
                await ExitChat();
                messageBox.Enabled = false;
                enterChatButton.Enabled = true;
                chatNumberBox.Enabled = true;
                sendMessageButton.Enabled = false;
                exitChatButton.Enabled = false;
            }
            catch (Exception) {
                MessageBox.Show("Failed to exit chat");
            }
        }

        public void label1_Click(object sender, EventArgs e) {

        }
    }
}
