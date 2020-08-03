using System;
using System.Collections.Generic;
using System.Text;

namespace MT.OnlineRestaurant.BusinessEntities
{
    public class MenuOffer
    {
        public int RestaurantId { get; set; }
        public int intOfferId{get;set;}
        public int MenuId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
