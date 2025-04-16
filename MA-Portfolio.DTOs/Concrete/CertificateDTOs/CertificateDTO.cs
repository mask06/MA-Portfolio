using MA_Portfolio.DTOs.Abstract;


namespace MA_Portfolio.DTOs.Concrete.CertificateDTOs
{
    public class CertificateDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string InstitutionName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; } // sertifika linki null olabilir
    }
}
