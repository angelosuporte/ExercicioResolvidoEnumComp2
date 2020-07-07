using System;
using ExercicioResolvidoEnumComp2.Entidades;

namespace ExercicioResolvidoEnumComp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentario c1 = new Comentario("Tenha uma boa viagem!");
            Comentario c2 = new Comentario("Legal");

            Post p1 = new Post(DateTime.Parse("01/01/2020 16:01:44"), "Viajando", "Indo passear um pouco", 10);
            p1.AddComentario(c1);
            p1.AddComentario(c2);

            Comentario c3 = new Comentario("Boa noite");
            Comentario c4 = new Comentario("Quando retornar conte como foi a viagem");

            Post p2 = new Post(DateTime.Parse("02/01/2020 20:01:44"), "Boa noite", "Depois falamos", 8);
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
