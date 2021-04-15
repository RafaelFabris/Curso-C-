using System;
using System.Text;
using System.Collections.Generic;


namespace StringBuilder1.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine(Title);
            s.Append(Likes);
            s.Append(" Likes - ");
            s.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            s.AppendLine(Content);
            s.AppendLine("Coments:");
            foreach(Comment c in Comments)
            {
                s.AppendLine(c.Text);
            }
            return s.ToString();
        }
    }
}
