using MT.OnlineRestaurant.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.DataLayer
{
    public class CartRepository : ICartRepository
    {
        private readonly OrderManagementContext _orderManagementContext;
        public CartRepository(OrderManagementContext orderManagementContext)
        {
            this._orderManagementContext = orderManagementContext;
        }
        public async Task<bool> CreateAsync(Cart cart)
        {
            try
            {
                _orderManagementContext.Cart.Add(cart);
                if (await _orderManagementContext.SaveChangesAsync() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> DeleteAsync(int CartId)
        {
            _orderManagementContext.Cart.Remove(new Cart { Id = CartId });
            await _orderManagementContext.SaveChangesAsync();
            return CartId;
        }
        public async Task<Cart> GetAsync(int userId, int restaurantId)
        {
            var cart = _orderManagementContext.Cart.FirstOrDefault(c => c.UserId == userId && c.RestaurantId == restaurantId);
           
            return (Cart)cart;
        }

        public async Task<bool> UpdateAsync(Cart cart)
        {
            _orderManagementContext.Cart.Update(cart);
            if (await _orderManagementContext.SaveChangesAsync() > 0)
                return true;
            else
                return false;
        }
    }
}
