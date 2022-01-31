using System;
using System.Collections.Generic;
using System.Text;


namespace CursoCSharp.Section9.Entities
{
    class Post
    {
        public DateTime Moment{ get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        //Criando uma lista para os comentários
        public List<Comment> Comments { get; set; } = new List<Comment>();
        

        //Sobrecarga de construtores

        //Com esse construtor eu consigo setar e obter os atributos da class
        public Post()
        {

        }

        //Com esse construtor é necessário passar valores para os parâmetros
        //Se não tivesse o construtor vazio, não conseguiríamos utilizar um atributo específico
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }



        //Métodos para adicionar e remover comentários
        public void addComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void removeComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        //Defini como o post vai ser apresentado
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
