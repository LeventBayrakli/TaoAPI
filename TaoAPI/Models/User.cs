using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaoAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public User(int Id, string Nom, string Prenom, DateTime DateNaissance, string Adresse, string Email, string Telephone)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.DateNaissance = DateNaissance;
            this.Adresse = Adresse;
            this.Email = Email;
            this.Telephone = Telephone;
        }       
    }

    public class Users
    {
        public List<User> users { get; set; }
    }
}
