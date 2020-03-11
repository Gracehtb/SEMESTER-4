

namespace ProjectRpl.Models 
{
    public class Product {

        public string Id_Product  { get; set; }
        public string Nama_Product { get; set; }
        public string deskripsi  { get; set; }

        public int stok  { get; set; }

        public double harga  { get; set; }
        public string image  { get; set; }

        public string Id_Kategori  { get; set; }
    }
}