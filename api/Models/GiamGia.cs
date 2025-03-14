namespace api.Models
{
    public class GiamGia
    {
        public int Id { get; set; }
        public string TenGiamGia { get; set; }
        public decimal SoGiam { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
