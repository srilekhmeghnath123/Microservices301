using MT.OnlineRestaurant.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.DataLayer
{
    public interface ICartRepository
    {
        Task<bool> CreateAsync(Cart cart);
        Task<int> DeleteAsync(int CartId); 
        Task<Cart> GetAsync(int userId, int restaurantId);
        Task<bool> UpdateAsync(Cart cart);

    }
}
