using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvidoEnumComp2.Entidades
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public Post()
        {
        }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }
        public void RemoveComentario(Comentario comentario)
        {
            Comentarios.Remove(comentario);
        
        }

    }
}
