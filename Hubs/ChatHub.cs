using Microsoft.AspNetCore.SignalR; 

namespace chatAPI.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessasge1(string user , string message)
        {
            return Clients.All.SendAsync("ReceiveOne" ,user,message);
            
        }
    }
}