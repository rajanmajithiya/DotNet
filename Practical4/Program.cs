﻿/* Practical 4
 * 'Write C# code to convert infix notation to postfix notation. 
 */
using System;

namespace Practical4
{
    class Practical4
    {
        public static void Main(string[] args)
        {
            InfixClass myclass = new InfixClass();
            String infix = " a+b*c-d";
            String postfix;
            myclass.Infixtopostfix(ref infix, out postfix);
            Console.WriteLine("infix string : " + infix);
            Console.WriteLine("postfix string is : "+postfix);
            Console.Read();
        }
    }
}
