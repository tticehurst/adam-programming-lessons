using System;

namespace TryCatchProcedual {
    class Program {

        static int IntInputWithBounds(string message, int lower, int higher) {
            int number;

            try {
                Console.WriteLine($"{message}. Bounds: Lower: {lower}, Higher: {higher}");
                number = Convert.ToInt32(Console.ReadLine());

                if (number < lower || number > higher) {
                    Console.WriteLine($"Your number does not fit within the given bounds");

                    number = IntInputWithBounds(message, lower, higher);
                }

                return number;
            } catch {
                Console.WriteLine("Your input was not a number");

                number = IntInputWithBounds(message, lower, higher);
                return number;
            }
        }

        static void Main(string[] args) {
            int number = IntInputWithBounds("Please input a number", 1, 20);

            Console.WriteLine($"Your number: {number}");
        }
    }
}
