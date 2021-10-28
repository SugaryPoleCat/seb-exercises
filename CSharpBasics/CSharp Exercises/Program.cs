using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region basics
            // Variables.
            string characterName = "";
            int characterAge;
            characterAge = 35;

            // concat the string
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            // if we want to change the name sudddenlly
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            // HJow to read user input:
            Console.Write("Input your name: ");
            string myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);


            // waits for iunput = pauses the console.
            Console.WriteLine("\npress enter key to continue to woring with strings\n");
            Console.ReadLine();
            #endregion

            #region dataTypes
            //Data types
            // String has "" while char has '' and ONLY handles 1 character.;
            string phrase = "Boku no goku";
            char poopster = 'P';
            Console.WriteLine("String: " + phrase + " | Char: " + poopster);
            // unsigned ints are ALWAYS positive.
            // just saying int, you ake it possile to be + or -
            // Ints are always 32 bit. Unsigned: 0 - 4294967295
            // signed : -2147483648 - 2147483647
            // BASICALLY, the way this works, is, signed min and max, if you plus them together ignoring the - in the min
            // you get teh max for unsigned.
            int degrees = -30;
            uint age = 20;
            Console.WriteLine("Int: " + degrees + " | Uint: " + age);
            // Long are 64 bits. They work the same like int
            // you can define these using etiher int64 or long.
            // signed: -9223372036854775808 - 9223372036854775807
            // unsigned: 0 - 18446744073709551615
            long bigNegNumber = -989;
            ulong bigPosNumber = 989;
            Console.WriteLine("Long: " + bigNegNumber + " | Ulong: " + bigPosNumber);
            // short = int16
            // signed: -32768 - 32767 | unsigned: 0-65535
            short length = -23;
            ushort width = 23;
            Console.WriteLine("Short: " + length + " | Ushort: " + width);
            // byte = int8
            // signed: -128 - 127 | unsigned: 0 - 255
            // almost never used in sbyte.
            byte idNumber = 230;
            sbyte negId = -100;
            Console.WriteLine("Byte: " + idNumber + " | Sbyte: " + negId);

            // this is a hex;
            int hexLiteral = 0x2A;
            Console.WriteLine("Hex: " + hexLiteral);

            // floating point numeric types. Are retarded. No im joking!
            // theyre fine, but the problem with them is that they are NOT accurate 100%.
            // They are floating point afterall.
            // float: +- 1.5*10^-45 - +- 3.4*10^38, precision: ~6-9 digits, 4 bytes. using System.Single, must add 'f' at end.
            // double: +- 5.0*10^-324 - +- 1.7*10^308, precision: ~15-17 digits, 8 bytes, using System.Double
            // decimal: +- 1.0*10^-28 - +- 7.9228*10^28, precision: 28-29 digits, 16 bytes, using System.Decimal, must add 'm' at end.
            double gpa = 3.3;
            float myPoint = 3.2f;
            decimal someStuff = 9.9m;
            Console.WriteLine("Double: " + gpa + " | Float: " + myPoint + " | Decimal" + someStuff);

            // true/false
            bool thisIsStupid = false;
            Console.WriteLine("Bool: " + thisIsStupid);

            // constant values are not stored anywhere. So for example:
            // console.writeline(30);,  the 30 is a constant value. its just there.
            Console.WriteLine("\npress enter key to continue to woring with strings\n");
            Console.ReadLine();
            #endregion

            #region working With String
            string anotherPhrase = "This is fantastic";
            Console.WriteLine(anotherPhrase);
            // prints an empty line
            Console.WriteLine();
            anotherPhrase = "This is a\nNew Line\n";
            Console.WriteLine(anotherPhrase);
            anotherPhrase += "\nAnd this is concacted line\n";
            Console.WriteLine(anotherPhrase);
            anotherPhrase = "This is fantastic";
            Console.WriteLine("String length: " + anotherPhrase.Length);
            Console.WriteLine("String uppercase: " + anotherPhrase.ToUpper());
            Console.WriteLine("String lowercase: " + anotherPhrase.ToLower());
            Console.WriteLine("Phrase contains: " + anotherPhrase.Contains("This"));
            Console.WriteLine("Get a char from string: " + anotherPhrase[2]);
            // if this returns -1, the character is not found
            Console.WriteLine("Get the index value of the item you look for: " + anotherPhrase.IndexOf("fantastic"));
            // grabs the characters from the INDEX NUMBER.
            // can also do: .Substring(8, 3) to tell the start and how many character to grab.
            Console.WriteLine("SUbstring grabs a part of the string and makes it into a new string: " + anotherPhrase.Substring(8, 3));

            Console.WriteLine("\npress enter key to continue to woring with numbers\n");
            Console.ReadLine();
            #endregion

            #region working wih numbers
            // you can totally like in JS perform math executions in console.
            int numberA = 10;
            int numberB = 5;
            int numberC = 8;
            double numberD = 6.3;
            double numberE = 5.7;
            Console.WriteLine(numberA + " * " + numberB + ": " + (numberA * numberB));
            Console.WriteLine(numberA + " / " + numberB + ": " + (numberA / numberB));
            Console.WriteLine(numberA + " + " + numberB + ": " + (numberA + numberB));
            Console.WriteLine(numberA + " - " + numberB + ": " + (numberA - numberB));
            // returns a remainder;
            Console.WriteLine(numberA + " mod " + numberB + ": " + (numberA % numberB));
            // follows the normal operation: does * and / first, then + and -, but can by bypassed with () like in normal math.
            Console.WriteLine(numberA + " + " + numberB + " * " + numberC + ": " + (numberA + numberB * numberC));
            Console.WriteLine("(" + numberA + " + " + numberB + ") * " + numberC + ": " + ((numberA + numberB) * numberC));
            // opertaions using floating points.
            Console.WriteLine(numberA + " + " + numberD + ": " + (numberA + numberD));
            Console.WriteLine(numberD + " + " + numberE + ": " + (numberD + numberE));
            // if you unclude a floating number, the c# will convert output to floating point.
            Console.WriteLine(numberA + " / " + numberD + ": " + (numberA / numberD));
            // if you DONT however, the output will be whole number.
            Console.WriteLine(numberA + " / " + numberC + ": " + (numberA / numberC));
            Console.WriteLine("\nNumber A now: " + numberA);
            // ++ means + 1;
            numberA++;
            Console.WriteLine("++: " + numberA);
            numberA = 10;
            numberA--;
            Console.WriteLine("--: " + numberA);
            numberA = 10;
            // += is basically: numberA = numberA + numberB;
            Console.WriteLine("+= " + numberB + ": " + (numberA += numberB));
            Console.WriteLine("-= " + numberB + ": " + (numberA -= numberB));
            Console.WriteLine("*= " + numberB + ": " + (numberA *= numberB));
            Console.WriteLine("/= " + numberB + ": " + (numberA /= numberB));

            // math things.
            // JUST LIKE JS
            // absolute
            Console.WriteLine("Absolute of " + numberA + ": " + Math.Abs(numberA));
            // power
            Console.WriteLine("Power of " + numberA + " and " + numberB + ": " + Math.Pow(numberA, numberB));
            // power with decimals
            Console.WriteLine("Power of " + numberD + " and " + numberB + ": " + Math.Pow(numberD, numberB));
            // root
            Console.WriteLine("Square root of " + numberA + ": " + Math.Sqrt(numberA));
            // max - which number is bigger
            Console.WriteLine("Max of " + numberA + " and " + numberB + ": " + Math.Max(numberA, numberB));
            // min - which number is smaller
            Console.WriteLine("Min of " + numberA + " and " + numberB + ": " + Math.Min(numberA, numberB));
            // round
            Console.WriteLine("Round of " + numberD + ": " + Math.Round(numberD));
            // round
            Console.WriteLine("Round of " + numberE + ": " + Math.Round(numberE));

            Console.WriteLine("\npress enter key to continue to woring with user input\n");
            Console.ReadLine();
            #endregion

            #region working with user input
            // console.write doesnt print new line

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("Hello " + userName + " you are " + userAge);

            Console.WriteLine("\npress enter key to continue to wroking with arrays\n");
            Console.ReadLine();
            #endregion

            #region working with arrays
            int[] luckyNumbers = { 1, 2, 3, 5, 8, 13, 27 };

            // prints the number at index [];
            Console.WriteLine(luckyNumbers[1]);

            luckyNumbers[1] = 666;

            Console.WriteLine(luckyNumbers[1]);

            // sometimes you dont know the names/numbers.
            // the problem is you need to tell the array how big its gonna be.
            string[] friends = new string[5];

            friends[0] = "Frank";
            friends[1] = "Kate";
            friends[2] = "Pooper";
            friends[3] = "Peter";
            friends[4] = "jorge";
            friends[5] = "aAsd";

            Console.WriteLine("\npress enter key to continue to wroking with if statements\n");
            Console.ReadLine();
            #endregion

            #region if statements
            bool isMale = true;
            bool isTall = false;

            if (isMale)
            {
                Console.WriteLine("You are Male");
            }
            else
            {
                Console.WriteLine("You are female");
            }

            // and
            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short Male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not a male, but you are tall");
            }
            else
            {
                Console.WriteLine("You are not male and not tall");
            }

            // or
            if (isMale || isTall)
            {
                Console.WriteLine("You are either a tall male, tall, or male.");
            }
            else
            {
                Console.WriteLine("You are either not tall, not male or both.");
            }

            int num1 = 10;
            int num2 = 20;
            string str1 = "baby";
            string str2 = "girl";

            if (num1 != num2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            if (str1 == str2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("\npress enter key to continue to wroking swtich statements\n");
            Console.ReadLine();
            #endregion

            #region switch statement
            // faster than If/else, if the if/else is a huge block of code.
            // otherwise the speedness is unnoticeable.

            int swtichChoice = 1;

            switch (swtichChoice)
            {
                case 0:
                    Console.WriteLine("This is gay");
                    break;
                case 1:
                    Console.WriteLine("this is not so gay");
                    break;
                default:
                    Console.WriteLine("no input in swtichchoice");
                    break;
            }

            Console.WriteLine("\npress enter key to continue to wroking with arrays\n");
            Console.ReadLine();
            #endregion
        }
    }
}
