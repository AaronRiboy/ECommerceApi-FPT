using System;
using System.ComponentModel.DataAnnotations;

namespace FPTFinalProject_API.Model
{
	public class ResetPasswordRequest
	{
        [Required]
        public string Token { get; set; } = String.Empty;

        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!")]
        public string Password { get; set; } = String.Empty;

        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = String.Empty;
    }
}

