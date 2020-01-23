using ChinookDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChinookConsoleDesktop
{
    class Program
    {
        //// Daten anlegen
        static void Main(string[] args)
        {
            using (ChinookContext context = new ChinookContext())
            {
                context.Database.Log = Console.WriteLine;

                Artist artist = new Artist() { Name = "Hosen" };
                //Album album = new Album() { Artist = artist, Title = "Atmen" };

                artist.Albums.Add(new Album() { Title = "Gürtelrose" });

                Console.WriteLine(context.Entry(artist).State);

                // Neu erzeugtes Element dem Context hinzufügen
                context.Artists.Add(artist);
                //context.Albums.Add(album);

                context.SaveChanges();

                //Console.WriteLine(context.Entry(artist).State);
            }

            Console.ReadKey();
        }

        // Daten (mit Abh.) ändern
        //static void Main(string[] args)
        //{
        //    using (ChinookContext context = new ChinookContext())
        //    {
        //        //ChinookContext context2 = new ChinookContext();
        //        context.Database.Log = Console.WriteLine;

        //        Artist acdc = context.Artists.Include("Albums").AsNoTracking() //lädt ohne Tracking
        //            .Where(art => art.Name == "AC/DC").FirstOrDefault()
        //            ;
        //        //context.Database.Log = Console.WriteLine;

        //        //Artist acdc2 = context2.Artists.SingleOrDefault(art => art.Name == "AC/DC");
        //        //context.Database.Log = Console.WriteLine;

        //        if (acdc != null)
        //        {
        //            acdc.Name = @"AC\DC";
        //            acdc.Albums.First().Title = "Singing Banana";

        //            // Datenbank-Werte wiederherstellen, wenn Tracking aktiv.
        //            //context.Entry(acdc).Reload();
        //            //context.Entry(acdc).CurrentValues.SetValues(context.Entry(acdc).OriginalValues);
        //            //context.Entry(acdc).CurrentValues.SetValues(context.Entry(acdc).GetDatabaseValues());
        //        }



        //        Console.WriteLine(context.Entry(acdc).State);
        //        //Console.WriteLine(context2.Entry(acdc2).State);
        //        // Console.WriteLine(context.Entry(acdc2).State); -> Exception!


        //        //context.SaveChanges();
        //    }
        //    Console.ReadKey();
        //}

        // Daten lesen
        //static void Main(string[] args)
        //{
        //    ChinookContext context = new ChinookContext();

        //    var q = from track in context.Tracks
        //             where track.Genre.Name == "Blues"
        //             select track;

        //    var qArtists = from track in q
        //                   select track.Album.Artist.Name;

        //    context.Database.Log = Console.WriteLine;

        //    foreach (var artist in qArtists.Distinct())
        //    {
        //        Console.WriteLine($"{artist}");
        //    }

        //    Console.ReadKey();
        //}
    }
}
