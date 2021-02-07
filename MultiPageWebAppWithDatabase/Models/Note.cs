using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactList.Models
{
    public class Note
    {
        public string NoteId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }
    }
}
