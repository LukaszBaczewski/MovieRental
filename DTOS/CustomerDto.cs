using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.DTOS
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
    }
}