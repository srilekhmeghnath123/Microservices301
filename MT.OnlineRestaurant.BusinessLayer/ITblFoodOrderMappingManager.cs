using MT.OnlineRestaurant.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.BusinessLayer
{
    public interface ITblFoodOrderMappingManager
    {
        Task<TblFoodOrderMapping> GetAsync(int id);
        Task<List<TblFoodOrderMapping>> GetMenuIdAsync(int menuId);
        Task<bool> UpdateAsync(TblFoodOrderMappingManager tblFoodOrderMapping);
        Task<bool> UpdatRangeAsync(List<TblFoodOrderMapping> tblFoodOrderMappings);
        Task<List<TblFoodOrderMapping>> GetFoodMenuForRestaurant(int restaurantId, int menuId);

    }
}
