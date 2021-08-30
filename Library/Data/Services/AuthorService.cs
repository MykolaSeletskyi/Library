﻿using Library.Data.Models;
using Library.Data.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;
        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM book)
        {
            var _author = new Author()
            {
                FullName = book.FullName
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }

        public Author GetAuthorById(int bookId)
        {
            var _author = _context.Authors.Where(n => n.Id == bookId).FirstOrDefault();
            return _author;
        }
        public Author UpdateAuthorById(int bookId, AuthorVM book)
        {
            var _author = _context.Authors.FirstOrDefault(n => n.Id == bookId);
            if (_author != null)
            {
                _author.FullName = book.FullName;
                _context.SaveChanges();
            }
            return _author;
        }
        public void DeleteAuthorById(int id)
        {
            var _author = _context.Authors.FirstOrDefault(n => n.Id == id);
            if (_author != null)
            {
                _context.Authors.Remove(_author);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception($"The author with id: {id} not found");
            }
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Authors.Where(n => n.Id == authorId).Select(n => new AuthorWithBooksVM()
            {
                FullName = n.FullName,
                BookTitles = n.Book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }
    }
}
