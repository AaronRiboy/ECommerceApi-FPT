using System;
using System.ComponentModel.DataAnnotations;

namespace FPTFinalProject_API.Model
{
	public class UserRegisterRequest
	{
        [Required, EmailAddress]
		public string Email { get; set; } = String.Empty;

        [Required,MinLength(6,ErrorMessage ="Please enter at least 6 characters!")]
        public string Password { get; set; } = String.Empty;

        [Required,Compare("Password")]
        public string ConfirmPassword { get; set; } = String.Empty;

    }
}

