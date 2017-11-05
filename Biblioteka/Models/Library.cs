using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteka.Models {
    public class Library {
        public List<Author> Authors =new List<Author>();
        public List<Book> Books = new List<Book>();

        public Library() {
            Author a = new Author(0,"Stephen", "King");
            Book b = new Models.Book(0, a, "Zielona Mila");
            Authors.Add(a);
            Books.Add(b);
            b = new Models.Book(1, a, "Skazani na Shawshank");
            Books.Add(b);
            a = new Author(1, "Stanisław", "Lem");
            Authors.Add(a);
            b = new Models.Book(2, a, "Mgła");
            Books.Add(b);
            b = new Models.Book(3, a, "Golem");
            Books.Add(b);
        }
    }
}