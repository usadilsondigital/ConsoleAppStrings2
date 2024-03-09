﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStrings2
{
    //Returns a new string in which all leading and trailing occurrences of a
    //set of specified characters from the current string are removed.
    public class StringTrim
    {

        public  void Trim()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your middle name or initial: ");
            string middleName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You entered '{0}', '{1}', and '{2}'.",
                            firstName, middleName, lastName);

            string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " +
                        lastName.Trim()).Trim();
            Console.WriteLine("The result is " + name + ".");

            // The following is a possible output from this example:
            //       Enter your first name:    John
            //       Enter your middle name or initial:
            //       Enter your last name:    Doe
            //       
            //       You entered '   John  ', '', and '   Doe'.
            //       The result is John Doe.


        }
    }
 }
