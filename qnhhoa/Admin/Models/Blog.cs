using System;
namespace Admin.Models
{
    public class Blog
    {
        private string id;
        private string title;
        private string author;
        private string photo;
        private string content;
        private string link_post;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        public string Link_post
        {
            get { return link_post; }
            set { link_post = value; }
        }

        public Blog(string id, string title, string author, string photo, string content, string link_post)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.photo = photo;
            this.content = content;
            this.link_post = link_post;
        }

        public Blog()
        {
        }
    }
}
