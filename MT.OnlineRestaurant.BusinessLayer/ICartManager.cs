using MT.OnlineRestaurant.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.BusinessLayer
{
    public interface ICartManager
    {
        Task<bool> CreateAsync(Cart cart);
        Task ApplyOffer(Cart cart);
        Task<int> DeleteAsync(int cartId);
        Task<bool> UpdateAsync(Cart cart);
        Task<Cart> GetAsync(int userId, int restaurantId);
    }
}
