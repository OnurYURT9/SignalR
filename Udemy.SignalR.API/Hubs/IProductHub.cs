using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy.SignalR.API.Models;

namespace Udemy.SignalR.API.Hubs
{
    public interface IProductHub
    {
        Task ReeceiveProduct(Product p);
    }
}
