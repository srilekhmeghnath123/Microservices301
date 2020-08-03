//using MT.OnlineRestaurant.BusinessEntities;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Threading.Tasks;

//namespace MT.OnlineRestaurant.BusinessLayer.Message
//{
//    public class OrderMessageSender : IOrderMessageSender
//    {
//        private readonly IServiceBusManager _orderServiceBusManager;
//        public OrderMessageSender(ServiceBusConfigurationsProvider serviceBusConfigurationsProvider)
//        {
//            var _orderServiceBusManagerConfig = serviceBusConfigurationsProvider.GetConfig("order");
//            this._orderServiceBusManager = new IServiceBusManager(_orderServiceBusManagerConfig);

//        }
//        public async Task NotifyOrderPlaced(OrderEntity orderEntity)
//        {
//            try
//            {
//                OrderEntity order = new OrderEntity();
//                await _orderServiceBusManager.SendMessage<OrderEntity>(orderEntity);
//            }
//            catch (Exception ex)
//            {
//                throw;
//            }
//        }
//    }
//}
