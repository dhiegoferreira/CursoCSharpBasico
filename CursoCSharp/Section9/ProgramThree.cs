using CursoCSharp.Section9.Entities;
using System;

namespace CursoCSharp.Section9
{
    class ProgramThree
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that´s awesome!");

            Post p1 = new Post(DateTime.Now, "Travelling to New Zealand","I´m going to visit this wonderful country!", 12);

            p1.Comments.Add(c1);
            p1.Comments.Add(c2);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Froce be with you.");
            Post p2 = new Post(DateTime.Now, "Goo nitght guys", "See your tomorrow", 5);

            p2.Comments.Add(c3);
            p2.Comments.Add(c4);

            //Imprimindo os posts e comentários
            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}
