using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaoAPI.Models
{
    public class Trip
    {
        public int IdTrip { get; set; }
        public int IdUser { get; set; }
        public int IdBorne { get; set; }
        public DateTime DatePassage { get; set; }

        public Trip(int idTrip, int idUser, int idBorne, DateTime datePassage)
        {
            IdTrip = idTrip;
            IdUser = idUser;
            IdBorne = idBorne;
            DatePassage = datePassage;
        }
    }

    public class Trips
    {
        public IList<Trip> trips { get; set; }
    }
}
