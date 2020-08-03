using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MT.OnlineRestaurant.DataLayer.Context
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public virtual List<TblFoodOrderMapping> Items { get; set; }

    }

}
