namespace api.Models
{
    public class HoaDonChiTiet
    {
        public int Id { get; set; }

        public int HoaDonId { get; set; }
        public HoaDon HoaDon { get; set; }

        public int ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; } // gia tai thoi diem mua
    }
}
