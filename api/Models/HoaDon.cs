namespace api.Models
{
    public class HoaDon
    {
        public int Id { get; set; }
        public DateTime NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } // co the them enum cho trang thai (tuong lai neu muon)
        public ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = new List<HoaDonChiTiet>(); // tuong tu gio hang
        public int? VoucherId { get; set; }
        public Voucher Voucher { get; set; }
    }
}
