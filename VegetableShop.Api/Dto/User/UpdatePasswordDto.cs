﻿namespace VegetableShop.Api.Dto.User
{
    public class UpdatePasswordDto
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
