using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.SignalR.API.Models;

namespace Udemy.SignalR.API.Hubs
{
    public class ProductHub:Hub<IProductHub>
    {
        public async Task SendProduct(Product p)
        {
            //string ifadeyi strongly type yaptık ve hata yaoma oranımızı azalttık
            await Clients.All.ReeceiveProduct(p);
        }
    }

}
