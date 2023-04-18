﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMessenger.Infrastructure.Utils;
using TopMessenger.ViewModels.Commands;

namespace TopMessenger.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        #region Commands
        public ActionCommand RegistrationCommand => new ActionCommand(x => Registration());
        #endregion

        #region Properties

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { UpdateValue(ref firstName, value); }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { UpdateValue(ref email, value); }
        }

        private bool isFirstNameValid;

        public bool IsFirstNameValid
        {
            get { return isFirstNameValid; }
            set { UpdateValue(ref isFirstNameValid, value); }
        }

        private bool isEmailValid;

        public bool IsEmailValid
        {
            get { return isEmailValid; }
            set { UpdateValue(ref isEmailValid, value); }
        }

        #endregion

        public RegistrationViewModel()
        {
            IsFirstNameValid = false; 
            IsEmailValid = false;
        }

        private void Registration()
        {
            IsFirstNameValid = ValidationUtills.Validate(FirstName, ValidateType.DigitContains, ValidateType.EmptyStr);
            IsEmailValid = ValidationUtills.Validate(Email, ValidateType.EmptyStr, ValidateType.IsEmailValidate);
        }
    }
}
