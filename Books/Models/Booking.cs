using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Models
{
    public class Booking: IEnumerable
    {
        [Required]
        public int BookingID { get; set; }

        [Required]
        [ForeignKey("Clients")]
        public int ClientID { get; set; }
        [Required]
        [ForeignKey("Rooms")]
        public int RoomID { get; set; }

        public bool Booked { get; set; }

        public virtual Client Clients { get; set; }
        public virtual Room Rooms { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
