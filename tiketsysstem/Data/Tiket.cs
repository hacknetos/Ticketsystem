using System;
using System.ComponentModel.DataAnnotations;

namespace tiketsysstem.Data
{
    public class Tiket
    {
        [Key]
        public int ticketid { get; set; }
        [Required]
        public string ticketname { get; set; }
        [Required]
        public string Discription { get; set; }
        public bool finish { get; set; }
        public string Note { get; set; }
        [Required]
        public int userid { get; set; }
        public DateTime Creadtedata { get; set; }
    }
}
