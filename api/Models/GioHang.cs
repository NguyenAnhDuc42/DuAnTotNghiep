using Microsoft.AspNetCore.Identity;

namespace api.Models
{
    public class GioHang
    {
        public int Id { get; set; }
        public DateTime NgayTao { get; set; }
        public ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>(); //1 gio hang co nhieu gio hang chi tiet
    }
}
