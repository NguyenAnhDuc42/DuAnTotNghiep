namespace api.Models
{
    public class GioHangChiTiet
    {
        public int Id { get; set; }

        public int ProductDetailId { get; set; }
        public ProductDetail ProductDetail { get; set; }

        public int SoLuong { get; set; }

        public int GioHangId { get; set; }
        public GioHang gioHang { get; set; }
    }
}
