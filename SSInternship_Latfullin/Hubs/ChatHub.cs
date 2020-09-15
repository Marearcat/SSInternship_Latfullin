using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SSInternship_Latfullin.Hubs
{
    public class ChatHub : Hub
    {
        private readonly GeneralData data;
        public ChatHub(GeneralData data)
        {
            this.data = data;
        }

        public async Task Send(string name, string message)
        {
            data.History.Add(name + " : " + message);
            await Clients.All.SendAsync("Send", name, message);
        }

        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("GetHistory", data.History.ToArray(), data.History.Count);
        }
    }
}
