using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMessenger.Infrastructure.Utils
{
    public enum ValidateType
    {
        EmptyStr,
        /// <summary>
        /// Проверка на отсутствие чисел (нет чисел - валидно)
        /// </summary>
        DigitContains,
        SpecialSymb,
        IsEmailValidate
    }

    public class ValidationUtills
    {
        private static event Func<string, bool> _validateEvent;

        public static bool Validate(string value, params ValidateType[] validateTypes)
        {
            if (validateTypes.Contains(ValidateType.EmptyStr) == true)
            {
                _validateEvent += EmptyStrValidate;
            }
            if (validateTypes.Contains(ValidateType.IsEmailValidate) == true)
            {
                _validateEvent += EmailValidate;
            }
            if (validateTypes.Contains(ValidateType.DigitContains) == true)
            {
                _validateEvent += DigitContainsValidate;
            }
            if (validateTypes.Contains(ValidateType.SpecialSymb) == true)
            {
                _validateEvent += SymbContainsValidate;
            }

            if (_validateEvent != null)
            {
                return _validateEvent(value);
            }
            else
            {
                return false;
            }

            //return _validateEvent != null ? _validateEvent(value) : false;
        }


        public static bool EmptyStrValidate(string value) //
        {
            //if (string.IsNullOrWhiteSpace(value)) return false;
            //return true; 
            return !string.IsNullOrWhiteSpace(value);
        }
        /// <summary>
        /// Значение является валидным если нет чисел
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool DigitContainsValidate(string value)//
        {
            foreach (var item in value)
            {
                if (char.IsDigit(item) == true)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Значение является валидным если есть спец. символы
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SymbContainsValidate(string value)
        {
            foreach (var item in value)
            {
                if (item == '^')
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Email является валидным если есть символ '@'
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool EmailValidate(string value)
        {
            foreach (var item in value)
            {
                if (item == '@')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
