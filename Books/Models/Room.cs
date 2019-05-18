using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Room
    {
        public enum RoomNum { One, Two, Three, Foyer }

        [Required]
        public int RoomID { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public RoomNum RoomNumber { get; set; }

        [Required]
        [Display(Name = "Date of booking")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Will you require teas and coffees?")]
        public bool Teas { get; set; }
    }
}
