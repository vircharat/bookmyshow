using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL
{
    public class MovievOperationv
    {
        MovieDBcontextv db = null;



        public string AddMovie(Moviev moviev)
        {
            db = new MovieDBcontextv();
            db.moviesv.Add(moviev);
            db.SaveChanges();
            return "saved";
        }

        public string UpdateMovie(Moviev moviev)
        {
            db = new MovieDBcontextv();
            db.Entry(moviev).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteMovie(int movievId)
        {
            db = new MovieDBcontextv();
            Moviev moviev = db.moviesv.Find(movievId);
            db.Entry(moviev).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Moviev> ShowAll()
        {
            db = new MovieDBcontextv();
            List<Moviev> list = db.moviesv.ToList();

            return list;
        }
        public List<Moviev> ShowAllByMovieType(string type)
        {
            db = new MovieDBcontextv();
            List<Moviev> movieList = db.moviesv.ToList();

            //LINQ query select * from movie where movietype='type'
            var result = from Movies in movieList
                         where Movies.MovievType == type
            orderby Movies.MovievName descending
                         select Movies;
            List<Moviev> movieResult = new List<Moviev>();
            foreach (var item in result)//linq query execution
            {
                movieResult.Add(item);
            }
            return movieResult;

        }
        public List<Moviev> ShowAllByMovieTypeDisplaynameonly(string type)
        {
            db = new MovieDBcontextv();
            List<Moviev> movieList = db.moviesv.ToList();

            //LINQ query select * from movie where movietype='type'
            var result = from Movies in movieList
                         where Movies.MovievType == type
                         orderby Movies.MovievName descending
                         select new Moviev
                         {
                             MovievId = Movies.MovievId,
                             MovievName = Movies.MovievName,
                         };

            List<Moviev> movieResult = new List<Moviev>();
            foreach (var item in result)//linq query execution
            {
                movieResult.Add(item);
            }
            return movieResult;

        }

        public Moviev ShowMovieByid(int movieId)
        {
            db = new MovieDBcontextv();
            Moviev moviev = db.moviesv.Find(movieId);
            return moviev;
        }

    }
}
