using System;
using System.Collections.Generic;
using System.Text;

namespace NewtonStudentExercises
{
    class CreatingPassword
    {
        //This method is used for setting the password value to * so that no one can see it.
       public static string ReadPassword()
        {
            string password = "admin";
            //Check if the console value is given or not, if input value is given, argument is set to true.
            ConsoleKeyInfo info = Console.ReadKey(true);
            //checks for each char, replaces each char with a *.
            //As long as enter is not pressed, check for the chars.
            while(info.Key != ConsoleKey.Enter)
            {
                //if not backspace is pressed, replace char with *.
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.WriteLine($"*");
                    password += info.KeyChar;
                }
                //if backspace is used, take away the last char
                else if (info.Key == ConsoleKey.Backspace)
                {
                    //if the whole string is not empty
                    if (!string.IsNullOrEmpty(password))
                    {
                        //remove one character from the list of password characters.
                        password = password.Substring(0, password.Length - 1);
                        //get the location of the cursor
                        int pos = Console.CursorLeft;
                        //move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        //replace it with space
                        Console.Write(" ");
                        //move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }
            //add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }
    }
}
