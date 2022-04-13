using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Status
    {
        private int _id;

        public Status(string title, string content)
        {
            Title = title;
            Content = content;
            _id++;
            Id = _id;
            SharedDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime SharedDate { get; set; }

        public string GetStatusInfo()
        {
            return $"Title: {Title} - Content: {Content} - shared {(DateTime.Now-SharedDate).Seconds} seconds ago";
        }
        
    }
}
