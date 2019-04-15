using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [Required]
        [RegularExpression(@"[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "Only letters are allowed.")]
        public string Name { get; set; }

        [StringLength(254, MinimumLength = 3)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        public string Country { get; set; }
    }
}
