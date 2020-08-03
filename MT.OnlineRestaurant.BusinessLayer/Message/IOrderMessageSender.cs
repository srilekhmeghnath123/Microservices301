using MT.OnlineRestaurant.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.BusinessLayer.Message
{
    public interface IOrderMessageSender
    {
        Task NotifyOrderPlaced(OrderEntity orderEntity);
    }
}
