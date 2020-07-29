using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Silk.Data.Entity
{
    public class ProductOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductId { get; set; }  
        public int Quantity { get; set; }
        public float Price { get; set; }
    }
}
