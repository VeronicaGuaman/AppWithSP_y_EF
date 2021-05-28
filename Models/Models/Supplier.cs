using System.Collections.Generic;

#nullable disable

namespace Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string NameCompany { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
