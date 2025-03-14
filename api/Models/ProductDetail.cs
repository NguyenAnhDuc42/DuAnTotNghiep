using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int SoLuong { get; set; }
        public string KieuGiay { get; set; }
        public string MauSac {  get; set; }
        public int KichCo {  get; set; }
        public int Hang { get; set; }
        public string TrangThai { get; set; } // vi du het hang, khong ban
        public string HinhAnh { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int? GiamGiaId { get; set; }
        public GiamGia giamGia { get; set; }
    }
}
