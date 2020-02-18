using System.Configuration;

namespace ContactBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        public int ContactID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string CellNumber { get; set; }

        [StringLength(254)]
        public string Email { get; set; }

        [EmailAddress]
        [StringLength(254)]
        public string Address { get; set; }

        public int? UserID { get; set; }
    }
}