using System;
using System.ComponentModel.DataAnnotations;
using Movie_Renta_Web_App.Models;

namespace Movie_Renta_Web_App.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }

        public DateTime? Birthdate { get; set; }
    }
}