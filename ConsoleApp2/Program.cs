using System;
using OptionsProgram;

namespace program
{
    public static class Program
    {
        public static void Main()
        {
            const string MsgProgram = "Que vols fer";
            const string MsgOptionA = "A) Validar si un nombre és senar";
            const string MsgOptionB = "B) Calcular la potència d'un nombre";
            const string MsgOptionC = "C) Retornar un valor aleatori";
            const string MsgOptionD = "D) Comptar el nombre de vocals o consonants en un text";
            const string MsgOptionE = "E) Sortir";
            const string MsgErrorOption = "Opció incorrecte";
            const string MsgErrorNaturalNumber = "El nombre introduit ha de ser natural";
            const string MsgNumber = "Introdueix un nombre";
            const string MsgRangMin = "Introdueix el rang mínim";
            const string MsgRangMax = "Introdueix el rang màxim";
            const string MsgResultNumber = "El resultat es {0}";
            const string MsgBye = "Adéu";
            const string MsgText = "Introdueix un text";
            const string MsgChoise = "Que vols contar del text, vocals (V) o consonants (C)?";
            string userOption, usertext, userOptionText;
            int userNumber, power, rangmax;
            bool errorResponse = false;
            Console.WriteLine(MsgProgram);
            Console.WriteLine(MsgOptionA);
            Console.WriteLine(MsgOptionB);
            Console.WriteLine(MsgOptionC);
            Console.WriteLine(MsgOptionD);
            Console.WriteLine(MsgOptionE);
            userOption = Console.ReadLine() ?? " ";
            switch (userOption.ToUpper())
            {
                case "A":
                    Console.WriteLine(MsgNumber);
                    do
                    {
                        if (errorResponse)
                        {
                            Console.WriteLine(MsgErrorNaturalNumber);
                        }
                        errorResponse = true;
                        userNumber = Convert.ToInt32(Console.ReadLine());
                    } while (!Options.ValidateNumberNatural(userNumber));
                    Console.WriteLine(Options.IsOdd(userNumber) ? "Es Senar" : "No es senar");
                    break;
                case "B":
                    Console.WriteLine(MsgNumber);
                    do
                    {
                        if (errorResponse)
                        {
                            Console.WriteLine(MsgErrorNaturalNumber);
                        }
                        errorResponse = true;
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        power = Convert.ToInt32(Console.ReadLine());
                    } while (!Options.ValidateNumberNatural(userNumber) && !Options.ValidateNumberNatural(power));
                    Console.WriteLine(MsgResultNumber, Options.CalculatePower(userNumber, power));
                    break;
                case "C":
                    Console.WriteLine(MsgNumber);
                    do
                    {
                        if (errorResponse)
                        {
                            Console.WriteLine(MsgErrorNaturalNumber);
                        }
                        errorResponse = true;
                        Console.WriteLine(MsgRangMin);
                        userNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(MsgRangMax);
                        rangmax = Convert.ToInt32(Console.ReadLine());
                    } while (!Options.ValidateNumberNatural(userNumber) && !Options.ValidateNumberNatural(rangmax));
                    Console.WriteLine(MsgResultNumber, Options.RandomNumber(userNumber, rangmax));
                    break;
                case "D":
                    Console.WriteLine(MsgText);
                    usertext = Console.ReadLine() ?? " ";
                    Console.WriteLine(MsgChoise);
                    userOptionText = Console.ReadLine() ?? "C";

                    switch (userOptionText.ToUpper())
                    {
                        case "V":
                            Console.WriteLine(MsgResultNumber, Options.CountVowels(usertext));
                            break;
                        case "C":
                            Console.WriteLine(MsgResultNumber, Options.CountConsonants(usertext));
                            break;
                        default:
                            Console.WriteLine(MsgResultNumber, 0);
                            break;
                    }

                    break;
                case "E":
                    Console.WriteLine(MsgBye);
                    break;
                default:
                    Console.WriteLine(MsgErrorOption);
                    break;
            }
        }
    }
}
