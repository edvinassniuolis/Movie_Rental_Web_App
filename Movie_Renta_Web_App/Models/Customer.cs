﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Movie_Renta_Web_App.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime? Birthdate { get; set; }

    }
}