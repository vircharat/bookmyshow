using BookTheShowDAL;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShowBLL
{
    public class ShowTimeBLL
    {

        ShowTimeOperationv ShowTimeOperationv = new ShowTimeOperationv();
        public string AddshowtimevBLL(ShowTimev showtimev)
        {
            string msg = "";
            msg = ShowTimeOperationv.AddShow(showtimev);
            return msg;
        }

        public string DeleteshowtimevBLL(int showtimevId)
        {
            string msg = "";
            msg = ShowTimeOperationv.DeleteShow(showtimevId);
            return msg;

        }

        public string UpdateTheatreBLL(ShowTimev showtimev)
        {
            string msg = "";
            msg = ShowTimeOperationv.UpdateShow(showtimev);
            return msg;

        }
        public List<ShowTimev> showallBLL()
        {

            List<ShowTimev> showtimevs = ShowTimeOperationv.ShowAll();
            return showtimevs;

        }
    }
}
