using birddaverilentask.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Utils.Exeptions;

namespace birddaverilentask.Models
{
    public class Library:IEntity
    {
        private static int _id;
        public int Id { get; }
        public int BookLimit { get; set; }
        private List<Book> _books = new List<Book>();
        public Library(int BookLimit)
        {
            this.BookLimit = BookLimit;
            _id++;
            Id = _id;
        }

        public void AddBook(Book book)
        {
            if(_books.Count<=BookLimit)
            {
                throw new CapacityLimitException("var!");
            }
            if (_books.Exists(m =>  m.Name == book.Name && m.IsDeleted==true))
            {
                //throw new AlreadyExistsException("var!");
            return;
            }
            _books.Add(book);
            return;
        }
        public Book GetBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("doldur be meyhaneci");

            return _books.Find(m => !m.IsDeleted && m.Id == id);
        }
        public List<Book> GetAllBooks()
        {
            List<Book> bookCopy = new List<Book>();
            bookCopy.AddRange(_books.FindAll(m => !m.IsDeleted));

            return bookCopy;
        }
        public void EditBookName(int? id, string name)
        {
            if (id == null || string.IsNullOrWhiteSpace(name))
                throw new NullReferenceException("doldur be meyhaneci");

            Book book = _books.Find(m => !m.IsDeleted && m.Id == id);
            if (book == null)
                throw new NotFoundException("yoxdu");
            book.Name = name;
        }
        public void DeleteBookById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("doldur");

            Book book = _books.Find(m => !m.IsDeleted && m.Id == id);
            if (book == null)
            {
                  throw new NotFoundException("yoxdu");
            }
            book.IsDeleted = true;
        }
        public List<Book> FilterByPageCount(double minCount, double maxCount)
        {
            return _books.FindAll(m => !m.IsDeleted && m.PageCount >= minCount && m.PageCount <= maxCount);
        }
    }
}
