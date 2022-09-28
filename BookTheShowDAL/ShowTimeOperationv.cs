using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL
{
    public class ShowTimeOperationv
    {
        MovieDBcontextv db = null;
        public string AddShow(ShowTimev showtime)
        {
            db = new MovieDBcontextv();
            db.showtimingsv.Add(showtime);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateShow(ShowTimev showtime)
        {
            db = new MovieDBcontextv();
            db.Entry(showtime).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteShow(int showId)
        {
            db = new MovieDBcontextv();
            ShowTimev showtime = db.showtimingsv.Find(showId);
            db.Entry(showtime).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<ShowTimev> ShowAll()
        {
            db = new MovieDBcontextv();
            List<ShowTimev> list = db.showtimingsv.ToList();

            return list;
        }
    }
}
