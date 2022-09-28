using System;
using System.Collections.Generic;
using System.Text;
using BookTheShowDAL;
using BookTheShowEntity;

namespace BookTheShowBLL
{
    public class TheatrevBLL
    {
        TheatreOperationv theatreOperationv = new TheatreOperationv();
        public string AddTheatrevBLL(Theatrev theatrev)
        {
            string msg = "";
            msg=theatreOperationv.AddTheatrev(theatrev);
            return msg;
        }

        public string DeleteTheatrevBLL(int theatrevId)
        {
            string msg = "";
            msg = theatreOperationv.DeleteTheatrev(theatrevId);
            return msg;

        }

        public string UpdateTheatreBLL(Theatrev theatrev)
        {
            string msg = "";
            msg = theatreOperationv.UpdateTheatrev(theatrev);
            return msg;

        }
        public List<Theatrev> showallBLL()
        {

            List <Theatrev> theatrevs = theatreOperationv.ShowAll();
            return theatrevs;

        }
    }
}
