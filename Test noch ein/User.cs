using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Test_noch_ein
{
   
        public class User
        {
            public string Names { get; set; }
            public string Location { get; set; }

            public string GetValidationError()
            {
                Regex lettersOnly = new Regex(@"^[\p{L}]+$");


                if (string.IsNullOrWhiteSpace(Names) || string.IsNullOrWhiteSpace(Location))
                {
                    return "du must ein (name ) und (ort) schreiben";
                }
                if (!lettersOnly.IsMatch(Names) || !lettersOnly.IsMatch(Location))
                {
                    return "warum kanst du nicht einfach  buchstaben schreiben";
                }

                return "";
            }
        }


    
}
