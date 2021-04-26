using System;
using System.Collections.Generic;
using System.Text;

namespace Nulls
{
    class PlayerDisplayer
    {
        public static void display(PlayerCharacter player)
        {
            /*                                             // If we try to access without assigning its value then  string is reference type so its return null value and int, date are the value type so they return their magic values.
             Console.WriteLine(player.name);                        
            Console.WriteLine(player.days_since_lastLogin);
            Console.WriteLine(player.dob);
            */

            if(string.IsNullOrWhiteSpace(player.name))
            {
                Console.WriteLine("Name is contain null value or white spaces.");
            }
            else
            {
                Console.WriteLine(player.name);
            }

            //if (player.days_since_lastLogin == null)
            /*if(player.days_since_lastLogin.HasValue)
            {
                Console.WriteLine(player.days_since_lastLogin);
            }
            else
            {
               // Console.WriteLine(player.days_since_lastLogin.Value);  //Value is used for, if there is no value in given variable and we are trying to access it, then it throws an exception.
                Console.WriteLine("No value for days since lastlogin.");
            }*/
            //int playervalue = player.days_since_lastLogin.GetValueOrDefault(0);   // if there is no value in it then it will take 0 as a default value.
            //int playervalue = player.days_since_lastLogin.HasValue ? player.days_since_lastLogin.Value : -1;  //conditional operator.
            int playervalue = player.days_since_lastLogin ?? -1;  //Null coalescing operation
            Console.WriteLine($"{playervalue} days sinse last login.");


            if(player.dob==null)
            {
                Console.WriteLine("No value for Date of birth.");
            }
            else
            {
                Console.WriteLine(player.dob);
            }

            if(player.isNew==null)
            {
                Console.WriteLine("Status is unknown");
            }
            else if(player.isNew==true)
            {
                Console.WriteLine("Player is new");
            }
            else
            {
                Console.WriteLine("Player is experienced.");
            }
        }
    }
}
