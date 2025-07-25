﻿using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Telefon alanı zorunludur.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        [EmailAddress(ErrorMessage = "Hatalı email formatı")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Katılım durumunu belirtiniz.")]
        public bool? WillAttend { get; set; }
    }
}
