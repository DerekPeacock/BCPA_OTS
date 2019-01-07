namespace BCPA_OTS.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using BCPA_OTS.Models;
    using BCPA_OTS.DAL;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<BCPA_OTS.DAL.OTS_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BCPA_OTS.DAL.OTS_Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            SeedPeople(context);
            SeedEvents(context);
            SeedShows(context);
            SeedSeats(context);
        }

        private void SeedSeats(OTS_Context context)
        {
            // Show 1 for Event 1

            var seatList = new List<Seat>();
            int id = 1;

            for(int row = 1; row <= 20; row++)
            {
                for(int col = 1; col <= 20; col++)
                {
                    Seat seat = new Seat(row, col);
                    seat.SeatID = id; id++ ;

                    if (row <= 2)
                        seat.SeatType = SeatTypes.Orchestra;
                    else if (row <= 10)
                        seat.SeatType = SeatTypes.Stalls;
                    else
                        seat.SeatType = SeatTypes.Back;

                    seat.ShowID = 1;
                    seat.Status = SeatStatus.Available;

                    seatList.Add(seat);
                }
            }

            seatList.ForEach(s => context.Seats.AddOrUpdate(i => i.SeatID, s));
            context.SaveChanges();
        }

        private void SeedShows(OTS_Context context)
        {
            var showList = new List<Show>
            {
                // Event 1 Gaelforce (3 Shows/Performances)
                new Show
                {
                    ShowID = 1,
                    EventID = 1,
                    PerformanceDate = new DateTime(2019, 2, 18, 19, 30, 0),
                },
                new Show
                {
                    ShowID = 2,
                    EventID = 1,
                    PerformanceDate = new DateTime(2019, 2, 20, 19, 30, 0),
                },
                new Show
                {
                    ShowID = 3,
                    EventID = 1,
                    PerformanceDate = new DateTime(2019, 2, 22, 19, 30, 0),
                }
            };

            showList.ForEach(s => context.Shows.AddOrUpdate(i => i.PerformanceDate, s));
            context.SaveChanges();
        }

        private void SeedEvents(OTS_Context context)
        {
            var EventList = new List<Event>
            {
                new Event
                {
                    EventID = 1,
                    Name = "Gaelforce Dance",
                    Description = "Gaelforce Dance is the celebration of Irish dance, music and song, which has dynamically tapped its way into the beating hearts of millions of audience members worldwide since its inception in 1999.",
                    ImageURL = "Gaelforce.jpg",
                    StartDateTime = new DateTime(2019, 2, 18, 19, 30, 0),
                    EndTime = new DateTime(2019, 2, 18, 22, 0, 0),
                    VideoURL = "#"
                },
                new Event
                {
                    EventID = 2,
                    Name = "The ball Room Boys",
                    Description = "Strictly Come Dancing favourites Ian Waite and Vincent Simone are joining forces in 2019 with their brand new production – THE BALLROOM BOYS",
                    ImageURL = "BallRoomBoys.jpg",
                    StartDateTime = new DateTime(2019, 3, 21, 19, 30, 0),
                    EndTime = new DateTime(2019, 3, 21, 22, 0, 0),
                    VideoURL = "#"
                },
                new Event
                {
                    EventID = 3,
                    Name = "Rythm of the Dance",
                    Description = "Like a sheet of lightning, the pulsating rhythms, pure energy and melodic music, in the Rhythm of the Dance show, has hit 50 countries around the world with audience figures of over 7 million fans during the past 20 years",
                    ImageURL = "RythmDance.jpg",
                    StartDateTime = new DateTime(2019, 4, 21, 19, 30, 0),
                    EndTime = new DateTime(2019, 4, 21, 22, 0, 0),
                    VideoURL = "#"
                },
                new Event
                {
                    EventID = 4,
                    Name = "Remembering the Movies",
                    Description = "Strictly’s very own Aljaz and Janette are back on tour with their brand new show Remembering the Movies. If you loved Remembering Fred then get ready for a remarkable, unique and star-studded rollercoaster ride through some of the most successful, Oscar winning and most memorable films of all time.",
                    ImageURL = "RememberMovies.jpg",
                    StartDateTime = new DateTime(2019, 5, 8, 19, 30, 0),
                    EndTime = new DateTime(2019, 5, 8, 22, 0, 0),
                    VideoURL = "#"
                },

            };

            EventList.ForEach(e => context.Events.AddOrUpdate(i => i.Name, e));
            context.SaveChanges();
        }

        private void SeedPeople(OTS_Context context)
        {
            var PeopleList = new List<Person>
            {
                new Person
                {
                    PersonID = 1,
                    FirstName = "William",
                    LastName = "Foster",
                    PhoneNumber = "01296 123123",
                    Email = "william.foster@nomad.com"
                },
                new Person
                {
                    PersonID = 2,
                    FirstName = "Connor",
                    LastName = "Patey",
                    PhoneNumber = "01296 789456",
                    Email = "connor.patey@nomad.com"
                },
                new Person
                {
                    PersonID = 3,
                    FirstName = "Daniel",
                    LastName = "Schafer-Smith",
                    PhoneNumber = "01296 543219",
                    Email = "daniel.schafer_smith@nomad.com"
                },
                new Person
                {
                    PersonID = 4,
                    FirstName = "Zeeshan",
                    LastName = "Akhlaq",
                    PhoneNumber = "01494 212868",
                    Email = "zeeshan.akhlaq@nomad.com"
                },
                new Person
                {
                    PersonID = 5,
                    FirstName = "Tomas",
                    LastName = "Green",
                    PhoneNumber = "01485 361516",
                    Email = "TomasGreen94@gmail.com"
                },
                new Person
                {
                    PersonID = 6,
                    FirstName = "Ben",
                    LastName = "Miller",
                    PhoneNumber = "01964 201603",
                    Email = "Miller92@gmail.com"
                },
                new Person
                {
                    PersonID = 7,
                    FirstName = "Lilly",
                    LastName = "Erickson",
                    PhoneNumber = "01223 191608",
                    Email = "Lilly1985@gmail.com"
                },
                new Person
                {
                    PersonID = 8,
                    FirstName = "Joshua",
                    LastName = "Knight",
                    PhoneNumber = "01356 624619",
                    Email = "JoshKnight90@gmail.com"

                },
                new Person
                {
                    PersonID = 9,
                    FirstName = "Emily",
                    LastName = "White",
                    PhoneNumber = "01494 432674",
                    Email = "EWhite@gmail.com"
                },
                new Person
                {
                    PersonID = 10,
                    FirstName = "Eliot",
                    LastName = "Meyers",
                    PhoneNumber = "01296 431652",
                    Email = "EliotMey@gmail.com"
                }

            };

            PeopleList.ForEach(p => context.People.AddOrUpdate(i => i.LastName, p));
            context.SaveChanges();
        }

    }
}
