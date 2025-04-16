namespace MA_Portfolio.DTOs.Concrete.CertificateDTOs
{
    public class CertificateCreateDTO
    {
        public int Id { get; set; } // Id'yi DTO'da tutmak mantıklı değil ama Entity'den gelen bir DTO olduğu için burada tutuyoruz.
        public string Name { get; set; }
        public string Description { get; set; }
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; } // sertifika linki null olabilir
    }
}
