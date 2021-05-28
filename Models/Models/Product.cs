#nullable disable

namespace Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Measure { get; set; }
        public int IdBrand { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }

        public virtual Brand IdBrandNavigation { get; set; }
        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Supplier IdSupplierNavigation { get; set; }
    }
}
