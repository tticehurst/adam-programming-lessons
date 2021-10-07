using System;

namespace VarsAndArrays {
    class Program {
        static void Main(string[] args) {
            string[] insults = new string[] { "Your mum is fat", "You smell", "You're as small as a hobbit", "My god, are you related to Deadpool?" };
            string[] names = new string[] { "Pob", "Tom", "Jake", "Will", "Ben", "Lewis" };

            Random random = new();

            string randomInsult = insults[random.Next(0, insults.Length)];
            string randomName = names[random.Next(0, names.Length)];

            Console.WriteLine($"{randomName}, {randomInsult}");
        }
    }
}
