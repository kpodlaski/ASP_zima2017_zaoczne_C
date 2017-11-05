using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteka.Models {
    public class Author {
        public int Id { get; set; }
        [Display(Name="Imie")]
        public String Name { get; set; }
        [Display(Name = "Nazwisko")]
        public String Surname { get; set; }

        public Author() {
            Id = -1;
            Name = "";
            Surname = "";
        }

        public Author(int id, String name, String surname) {
            Id = id;
            Name = name;
            Surname = surname;
        }
    }
}