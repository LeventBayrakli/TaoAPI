using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaoAPI.Models;

namespace TaoAPI.Controllers
{
    [Route("TaoApi/[controller]")]
    [ApiController]
    public class UserTripController : ControllerBase
    {
        List<Trip> trips = new List<Trip>();

        public UserTripController()
        {
            //Ajout des Trips bidons pour Levent
            Trip trip1 = new Trip(1, 1, 1, new DateTime(2019, 03, 03, 7, 45, 34));
            Trip trip2 = new Trip(2, 1, 2, new DateTime(2019, 03, 05, 16, 13, 1));
            Trip trip3 = new Trip(3, 1, 1, new DateTime(2019, 03, 05, 18, 27, 50));
            Trip trip4 = new Trip(4, 1, 3, new DateTime(2019, 03, 06, 8, 1, 5));
            Trip trip5 = new Trip(5, 1, 2, new DateTime(2019, 03, 06, 15, 45, 9));
            Trip trip6 = new Trip(6, 1, 2, new DateTime(2019, 03, 09, 21, 53, 46));
            Trip trip7 = new Trip(7, 1, 1, new DateTime(2019, 03, 12, 8, 4, 13));

            //Ajout des Trips bidons pour Arthur
            Trip trip8 = new Trip(8, 2, 3, new DateTime(2019, 03, 01, 7, 45, 34));
            Trip trip9 = new Trip(9, 2, 2, new DateTime(2019, 03, 02, 16, 13, 1));
            Trip trip10 = new Trip(10, 2, 1, new DateTime(2019, 03, 05, 18, 27, 50));
            Trip trip11 = new Trip(11, 2, 1, new DateTime(2019, 03, 06, 8, 1, 5));
            Trip trip12 = new Trip(12, 2, 2, new DateTime(2019, 03, 06, 15, 45, 9));

            //Ajout des Trips bidons pour Quentin
            Trip trip13 = new Trip(13, 3, 2, new DateTime(2019, 03, 09, 21, 53, 46));
            Trip trip14 = new Trip(14, 3, 1, new DateTime(2019, 03, 12, 8, 4, 13));

            //Ajout des Trips bidons pour Vincent
            Trip trip15 = new Trip(15, 4, 2, new DateTime(2019, 03, 09, 21, 53, 46));
            Trip trip16 = new Trip(16, 4, 1, new DateTime(2019, 03, 12, 8, 4, 13));

            //Ajout des Trips bidons pour Waifu
            Trip trip17 = new Trip(17, 5, 2, new DateTime(2019, 03, 09, 21, 53, 46));
            Trip trip18 = new Trip(18, 5, 1, new DateTime(2019, 03, 12, 8, 4, 13));

            trips.Add(trip1);
            trips.Add(trip2);
            trips.Add(trip3);
            trips.Add(trip4);
            trips.Add(trip5);
            trips.Add(trip6);
            trips.Add(trip7);
            trips.Add(trip8);
            trips.Add(trip9);
            trips.Add(trip10);
            trips.Add(trip11);
            trips.Add(trip12);
            trips.Add(trip13);
            trips.Add(trip14);
            trips.Add(trip15);
            trips.Add(trip16);
            trips.Add(trip17);
            trips.Add(trip18);
        }


        // GET: api/Trip/User/5
        [HttpGet("{idUser}", Name = "GetTripsByUser")]
        public IEnumerable<Trip> GetTripsByUser(int idUser)
        {
            return trips.Where(t => t.IdUser == idUser);
        }
    }
}