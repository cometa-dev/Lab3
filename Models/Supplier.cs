using System.Collections.Generic;

namespace ShopApplication.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }
    }
}