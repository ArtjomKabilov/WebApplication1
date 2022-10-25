using System.ComponentModel.DataAnnotations;

namespace appointment_with_the_hairdresser2
{
    public class Teenus
    {
        [Key]
        public int TeenusID { get; set; }
        public string Nimetus { get; set; }
        public int Hind { get; set; }
        public int Kestvus { get; set; }
    }
}
