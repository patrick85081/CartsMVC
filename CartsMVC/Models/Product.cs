using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CartsMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public System.DateTime PublishDate { get; set; }
        public bool Status { get; set; }
        public Nullable<long> DefaultImageId { get; set; }
        public int Quantity { get; set; }
        public string DefaultImageURL { get; set; }
    }
}