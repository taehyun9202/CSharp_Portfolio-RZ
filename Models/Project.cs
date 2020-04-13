using System;
namespace Portfolio.Models
{
    public class Project 
    {
        public string Link;
        public string Title;
        public string Text;
        public Project(string link, string title, string text)
        {
            Link = link;
            Title = title;
            Text = text;
        }
    }
}

