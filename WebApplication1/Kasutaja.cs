using System.ComponentModel.DataAnnotations;

namespace appointment_with_the_hairdresser2
{
    public class Kasutaja
    {
        [Key]
        public int KasutajaID { get; set; }
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Epost { get; set; }
        public string Telefoninumber { get; set; }
    }
}
