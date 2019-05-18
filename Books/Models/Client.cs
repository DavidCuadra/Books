using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Client
    {
        public enum Noise { NeedsSilence, Normal, Noisy }

        [Required]
        public int ClientID { get; set; }

        [Required]
        [Display(Name = "Client Name")]
        [MinLength(2)]
        [MaxLength(50)]
        public string ClientName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [MinLength(2)]
        [MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Do you have Insurance")]
        public bool Insurance { get; set; }

        [Required]
        [Display(Name = "Do you have Garda Vetting")]
        public bool GardaVetting { get; set; }

        [Required]
        [Display(Name = "What noise levels does your activity have")]
        public Noise NoiseLevel { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        [Display(Name = "Number of people in your activity")]
        public string NumberPeople { get; set; }
    }
}
