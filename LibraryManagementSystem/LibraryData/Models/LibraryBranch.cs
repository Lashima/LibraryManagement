using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Data.Models
{
    public class LibraryBranch
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Branch Name")]
        [StringLength(30, ErrorMessage = "Limit branch name to 20 characters.")]
        public string Name { get; set; }

        [Required] public string Address { get; set; }

        [Required] public string Telephone { get; set; }

        public string Description { get; set; }
        public DateTime OpenDate { get; set; }

        public virtual IEnumerable<Owner> Owners { get; set; }
        public virtual IEnumerable<LibraryAsset> LibraryAssets { get; set; }

        public string ImageUrl { get; set; }

        public string locmap { get; set; }
    }
}