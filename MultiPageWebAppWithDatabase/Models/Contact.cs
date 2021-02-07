using System.ComponentModel.DataAnnotations;
using Ch04ContactList.Models;

namespace ContactList.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number (999-999-9999).")]
        [StringLength(12)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter address line 1.")]
        [StringLength(100)]
        public string AddressLine1 { get; set; }

        [StringLength(100)]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter city name.")]
        [StringLength(50)]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter state name.")]
        [StringLength(25)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter zip code (99999-9999).")]
        [StringLength(10)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter a note.")]
        public string NoteId { get; set; }
        public Note Note { get; set; }
    }
}
