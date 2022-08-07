using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.Hubs {
    public class ChatHub : Hub {

        public async void SendMessage(int chatId, string message) {
            try {
                Console.WriteLine("Sending message...");
                await Clients.Group("chat_" + chatId).SendAsync("realtimeMessage", message);
            }
            catch (Exception e) {
                Console.Error.WriteLine("Failed to send message: " + e.Message);
            }
        }

        public async void EnterChat(int chatId) {
            try {
                Console.WriteLine("Entering chat...");
                await Groups.AddToGroupAsync(Context.ConnectionId, "chat_" + chatId);
            }
            catch (Exception e) {
                Console.Error.WriteLine("Failed to enter chat: " + e.Message);
            }
        }

        public async void ExitChat(int chatId) {
            try {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, "chat_" + chatId);
            }
            catch (Exception e) {
                Console.Error.WriteLine("Failed to exit chat: " + e.Message);
            }
        }
    }
}
