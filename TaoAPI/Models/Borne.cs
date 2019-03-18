using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaoAPI.Models
{
    public class Borne
    {
        public int IdBorne { get; set; }
        public string nom { get; set; }
        public string description { get; set; }

        public Borne(int idBorne, string nom, string description)
        {
            IdBorne = idBorne;
            this.nom = nom;
            this.description = description;
        }
    }

    public class Bornes
    {
        public IList<Borne> bornes { get; set; }
    }
}
