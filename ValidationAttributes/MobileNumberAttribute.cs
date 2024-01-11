﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace TaskProject.CustomValidations
{
	public class MobileNumberAttribute : ValidationAttribute
	{


        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                return true;
            }
            string mobileNumber = value.ToString();


            var regex = new Regex(@"^[6-9]\d{9}$");

            return regex.IsMatch(mobileNumber);
        }
    }
}
