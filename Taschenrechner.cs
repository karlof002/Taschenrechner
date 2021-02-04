/*******************************
 * Übungsbeispiel: Taschenrechner
 *  
 * Autor: Michael Bucek
 * ******************************/

using System;

namespace Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;
            double result = 0;
            string op;
            bool error = false;

            string input;

            //Eingabe Zahl1
            Console.Write("Zahl1:");
            input = Console.ReadLine();
            number1 = Convert.ToDouble(input);

            //Eingabe Zahl2
            Console.Write("Zahl2:");
            input = Console.ReadLine();
            number2 = Convert.ToDouble(input);

            //Eingabe Operator
            Console.Write("Operator:");
            op = Console.ReadLine();

            //Ergebnis berechnen
            if (op == "+")
            {
                result = number1 + number2;             
            }
            else if (op == "/")
            {
                result = number1 / number2;

            }
            else if (op == "*")
            {
                result = number1 * number2;
            }
            else
            {
                Console.WriteLine("Ungültiger Operator!");
                result = 0;
                error = true;
            }

            if (!error)
            {
                //Ergebnis ausgeben (nur wenn kein ungültiger Operator)
                Console.WriteLine("{0} {1} {2} = {3}", number1, op, number2, result);
            }
        }
    }
}
