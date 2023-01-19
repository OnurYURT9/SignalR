using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Udemy.SignalR.API.Hubs
{
    public class MyHub:Hub
    {
        public static List<string> Names { get; set; } = new List<string>();
        public async Task SendName(string name)
        {
            Names.Add(name);
            // kullanıcılara mesaj gönderme
           await Clients.All.SendAsync("ReceiveMessage", name);
        }
        public async Task GetNames()
        {
            await Clients.All.SendAsync("ReceiveNames", Names);
        }
    }
}
