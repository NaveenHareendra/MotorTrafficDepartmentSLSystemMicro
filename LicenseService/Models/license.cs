namespace LicenseService.Models
{
    public class license
    {
        public int id { get; set; }
        public string? name { get; set; }

        public string? address { get; set; }

        public int Age { get; set; }

        public bool licenseIssued { get; set; }
    }
}
