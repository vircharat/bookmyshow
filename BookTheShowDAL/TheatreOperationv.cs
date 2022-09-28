using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookTheShowDAL
{
    public class TheatreOperationv
    {
        MovieDBcontextv db = null;



        public string AddTheatrev(Theatrev theatrev)
        {
            db = new MovieDBcontextv();
            db.theatresv.Add(theatrev);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateTheatrev(Theatrev theatrev)
        {
            db = new MovieDBcontextv();
            db.Entry(theatrev).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public string DeleteTheatrev(int theatrevId)
        {
            db = new MovieDBcontextv();
            Theatrev theatrev = db.theatresv.Find(theatrevId);
            db.Entry(theatrev).State = EntityState.Deleted;
            db.SaveChanges();
            return "deleted";
        }
        public List<Theatrev> ShowAll()
        {
            db = new MovieDBcontextv();
            List<Theatrev> list = db.theatresv.ToList();

            return list;
        }
    }
}
