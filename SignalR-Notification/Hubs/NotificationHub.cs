using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Notification.Hubs
{

    public class NotificationHub : Hub
    {
        

        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("receiveNotificationMessage", $"{Context.User.Identity.Name} user is connected");
        }

        public async Task SendNotification(string notificationMessage)
        {

            await Clients.All.SendAsync("receiveNotificationMessage", $"user -{notificationMessage}");
        }
    }
}
