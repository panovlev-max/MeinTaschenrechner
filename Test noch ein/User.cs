using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_noch_ein
{
   
        public class User
        {
        public string _names = "";
        public string _location = "";

        private Regex lettersOnly = new Regex(@"^[\p{L}]+$");

        public string name
        {
            get  =>_names; 
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && lettersOnly.IsMatch(value))
                {
                    _names = value;
                }
                else
                {
                    _names = "Ungültig";
                }
            }
        }
        public string location
        {
            get =>  _location; 
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && lettersOnly.IsMatch(value))
                {
                    _location = value.ToUpper();
                }
                else
                {
                    _location = "Unbekant";
                }
            }
        }
            public string GetValidationError()
            {
                if (_names == "Ungültig"|| _location == "Unbekant" || _names == "" || _location == "")
                {
                return "Bitte nur Buchstaben für Name und Ort verwenden und nichts leer lassen!";
                }
              return "";
            }
        }


    
}
