using Microsoft.AspNetCore.SignalR;

namespace Bloghost
{
    public class NotificationHub : Hub
    { 
        public async System.Threading.Tasks.Task Send(string userFromName, string postname)
        {
            await Clients.All.SendAsync("Notify", userFromName, postname);
        }
    }
}