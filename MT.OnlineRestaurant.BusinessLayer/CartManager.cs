using MT.OnlineRestaurant.BusinessLayer.Proxy;
using MT.OnlineRestaurant.DataLayer;
using MT.OnlineRestaurant.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MT.OnlineRestaurant.BusinessLayer
{
    public class CartManager : ICartManager
    {
        private readonly ICartRepository _cartRepository;
        private readonly ISearchManagementService _searchManagementService;
        private readonly ITblFoodOrderMappingManager _tblFoodOrderMappingManager;


        public CartManager(ICartRepository cartRepository, ISearchManagementService searchManagementService, ITblFoodOrderMappingManager tblFoodOrderMappingManager)
        {
            this._cartRepository = cartRepository;
            this._searchManagementService = searchManagementService;
            this._tblFoodOrderMappingManager = tblFoodOrderMappingManager;
        }

        public Task ApplyOffer(Cart cart)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAsync(Cart cart)
        {
            if (cart != null)
            {
                cart.Items.ForEach(Items =>
                {
                    Items.RecordTimeStampCreated = DateTime.Now;
                    Items.UserCreated = cart.CreatedBy;
                });

                return await _cartRepository.CreateAsync(cart);
            }
            return false;
        }

       

        public async Task<int> DeleteAsync(int cartId)
        {
            return await _cartRepository.DeleteAsync(cartId);
        }
        public async Task<Cart> GetAsync(int userId, int restaurantId)
        {
            return await _cartRepository.GetAsync(userId, restaurantId);
        }

        public async Task<bool> UpdateAsync(Cart cart)
        {
            if (null != cart)
            {
                cart.Items.ForEach(IRaiseItemChangedEvents =>
                {
                    IRaiseItemChangedEvents.RecordTimeStamp = DateTime.Now;
                    IRaiseItemChangedEvents.UserModified = cart.UpdatedBy ?? 0;
                });
            }
            return await _cartRepository.UpdateAsync(cart);
        }
    }
}
