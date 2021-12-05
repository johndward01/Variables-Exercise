using System;

namespace Variables_Exericse
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 31;
            char middleInitial = 'D';
            bool canVote = true;
            double score = .99;
            decimal balance = 10230.98M;

            Console.WriteLine($"Name: {name}\n" +
                              $"Age: {age}\n" +
                              $"Middle Initial: {middleInitial}\n" +
                              $"Can Vote: {canVote}\n" +
                              $"Score: {score}\n" +
                              $"Balance: {balance}\n");
        }
    }
}
