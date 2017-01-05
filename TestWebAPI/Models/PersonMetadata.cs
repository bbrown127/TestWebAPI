using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestWebAPI.Models
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
        
    }

    public class PersonMetadata
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        public DateTime? BirthDate { get; set; }
    }
}