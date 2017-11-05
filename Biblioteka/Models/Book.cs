using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteka.Models {
    public class Book {
        public int Id {get; set;}
        public String Title { get; set; }
        public Author Author { get; set; }

        public Book() {
            Id = -1; Title = ""; Author = new Author();
        }

        public Book(int id, Author author, String title) {
            Id = id;
            Author = author;
            Title = title;
        }
    }
}