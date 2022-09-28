using BookTheShow;
using BookTheShowBLL;
using BookTheShowEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookTheShow
{
    public class ShowTimePL
    {
     
        bool flag = false;
        public bool menuShow()
        {
            ShowTimePL showtimePL = new ShowTimePL();
            ShowTimeBLL ShowTimeBLL = new ShowTimeBLL();
            Console.WriteLine("Welcome to show section");
            Console.WriteLine("To choose the function");

            Console.WriteLine("Enter 1 to add show\n" +
                "Enter 2 to deletet show\n" +
                "Enter 3 to Show show by its id\n" +
                "Enter 4 to show all show\n" +
                "Enter 5 to Update show\n" 
              );
            int codeentered;
            codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {

                case 1:
                    showtimePL.Addshow();
                    flag = true;

                    break;
                case 2:
                    showtimePL.Deleteshow();
                    flag = true;
                    break;
                case 3:
                   
                    flag = true;
                    break;
                case 4:
                    showtimePL.ShowAllshow();
                    flag = true;
                    break;
                case 5:
                    showtimePL.Updateshow();
                    flag = true;
                    break;
                
                case 7:
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Invalid code");

                    break;





            }
            return flag;



        }
public void Updateshow()
{
    ShowTimePL showtimePL = new ShowTimePL();
    ShowTimeBLL ShowTimeBLL = new ShowTimeBLL();
    ShowTimev ShowTimev = new ShowTimev();


    Console.WriteLine("Enter the show Id");
    ShowTimev.ShowvId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Entershow Movie ID : ");
    ShowTimev.MovievId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter  Theatre Id: ");
    ShowTimev.TheatrevId = Convert.ToInt32(Console.ReadLine()); ;

    Console.WriteLine("Enter show time ");
    ShowTimev.ShowTimevv =Convert.ToDateTime(Console.ReadLine());

    string msg =ShowTimeBLL.AddshowtimevBLL(ShowTimev);
    Console.WriteLine(msg);

}
public void Addshow()
{
            ShowTimePL showtimePL = new ShowTimePL();
            ShowTimeBLL ShowTimeBLL = new ShowTimeBLL();
            ShowTimev ShowTimev = new ShowTimev();


            Console.WriteLine("Entershow Movie ID : ");
            ShowTimev.MovievId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  Theatre Id: ");
            ShowTimev.TheatrevId = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine("Enter show time ");
            ShowTimev.ShowTimevv = Convert.ToDateTime(Console.ReadLine());

            string msg = ShowTimeBLL.AddshowtimevBLL(ShowTimev);
            Console.WriteLine(msg);

        }
public void Deleteshow()
{
    ShowTimePL ShowTimePL = new ShowTimePL();
    ShowTimeBLL ShowTimeBLL =new ShowTimeBLL();
    ShowTimev ShowTimev = new ShowTimev();

    Console.WriteLine("Enter show Id : ");
    ShowTimev.ShowvId = Convert.ToInt32(Console.ReadLine());
    string msg =ShowTimeBLL.DeleteshowtimevBLL(ShowTimev.ShowvId);
    Console.WriteLine(msg);
}

public void ShowAllshow()
{
    ShowTimePL ShowTimePL = new ShowTimePL();
    ShowTimeBLL ShowTimeBLL = new ShowTimeBLL();
    ShowTimev ShowTimev = new ShowTimev();

    List<ShowTimev> shows =ShowTimeBLL.showallBLL();
    foreach (var item in shows)
    {
        Console.WriteLine("Show Id : " + item.ShowvId);
        Console.WriteLine("Movie ID : " + item.MovievId);
        Console.WriteLine("Theatre ID: " + item.TheatrevId);
        Console.WriteLine("Show Date: " + item.ShowTimevv);

    }

}
    }
}
