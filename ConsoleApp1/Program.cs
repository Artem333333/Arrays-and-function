﻿using System;

namespace program
{

    class program{

        static void Main(){

            System.Console.Write("Enter name: ");
            string role = Console.ReadLine();

            if (role == "Admin")
            {
                Console.Write("Enter user name: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());

                if(age <= 0 || age > 99)
                {
                    Console.Write("Enter {0} age: ", user_name);
                    age = Convert.ToInt16(Console.ReadLine());
                }

                if (age <= 0 || age > 99)
                {
                    Console.WriteLine("Error");
                    age = 0;
                }
                else
                    System.Console.WriteLine("User's age is " + age);


            }
            else
            {
                Console.WriteLine("You are note admin!");
            }


        }
    }
}
