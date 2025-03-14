namespace api.Models
{
    public class Voucher
    {
        public int Id { get; set; }
        public string Ma { get; set; }
        public decimal GiaTriPhanTram { get; set; }
        public bool TrangThai { get; set; } //vi du trang thai = da su dung = false
        public ICollection<HoaDon> HoaDons { get; set; } // voucher ap dung cho hoa don
    }
}
