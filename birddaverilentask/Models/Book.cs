using birddaverilentask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace birddaverilentask.Models
{
     public class Book : IEntity
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public bool IsDeleted = false;
        public int PageCount { get; set; }

        public Book(string Name,string AuthorName, int PageCount)
        {
            this.Name = Name;
            this.AuthorName = AuthorName;
            this.PageCount = PageCount;
            _id++;
            Id = _id;
        }
    }
}
