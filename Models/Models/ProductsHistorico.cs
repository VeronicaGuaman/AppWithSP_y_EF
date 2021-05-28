using System;

#nullable disable

namespace Models
{
    public partial class ProductsHistorico
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Measure { get; set; }
        public int IdBrand { get; set; }
        public int IdCategory { get; set; }
        public int IdSupplier { get; set; }
        public DateTime DateModify { get; set; }
        public string Accion { get; set; }
    }
}
