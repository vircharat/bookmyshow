using System;
using System.Collections.Generic;
using System.Text;
using BookTheShowBLL;
using BookTheShowEntity;
using BookTheShowDAL;


namespace BookTheShow
{   
    public class TheatrevPL
    {
        
        public bool menuTheatre()
        {
            TheatrevPL theatrevPL = new TheatrevPL();
            TheatrevBLL theatrevBLL = new TheatrevBLL();
            bool flag = false;
            
            Console.WriteLine("Welcome to theatre section");
            Console.WriteLine("To choose the function");

            Console.WriteLine("Enter 1 to add theatre\n" +
                "Enter 2 to deletet theatre\n" +
                "Enter 3 to Show theatre by its id\n" +
                "Enter 4 to show all theatre\n" +
                "Enter 5 to Update theatre\n" 
              );
            int codeentered;
            codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {

                case 1:
                    theatrevPL.AddTheatre();
                    flag = true;

                    break;
                case 2:
                    theatrevPL.DeleteTheatre ();
                    flag = true;
                    break;
                case 3:
                   
                    flag = true;
                    break;
                case 4:
                    theatrevPL.ShowAllTheatre();
                    flag = true;
                    break;
                case 5:
                    theatrevPL.UpdateTheatre();
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
        public void UpdateTheatre()
        {
            TheatrevPL theatrevPL = new TheatrevPL();
            TheatrevBLL theatrevBLL = new TheatrevBLL();
            Theatrev Theatrev = new Theatrev();

            Console.WriteLine("Enter theTheatre Id");
            Theatrev.TheatrevId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("EnterTheatre Name : ");
            Theatrev.TheatrevName = Console.ReadLine();

            Console.WriteLine("Enter Theatre address : ");
            Theatrev.TheatrevAddress = Console.ReadLine();
            
            Console.WriteLine("Theatrev Comments Description  : ");
            Theatrev.TheatrevComments = Console.ReadLine();
            
            string msg =theatrevBLL.UpdateTheatreBLL(Theatrev); 
            Console.WriteLine(msg);

        }
        public void AddTheatre()
        {
            TheatrevPL theatrevPL = new TheatrevPL();
            TheatrevBLL theatrevBLL = new TheatrevBLL();
            Theatrev Theatrev = new Theatrev();

        

            Console.WriteLine("EnterTheatre Name : ");
            Theatrev.TheatrevName = Console.ReadLine();

            Console.WriteLine("Enter Theatre address : ");
            Theatrev.TheatrevAddress = Console.ReadLine();

            Console.WriteLine("Theatrev Comments Description  : ");
            Theatrev.TheatrevComments = Console.ReadLine();

            string msg = theatrevBLL.AddTheatrevBLL(Theatrev);
            Console.WriteLine(msg);

        }
        public void DeleteTheatre()
        {
            TheatrevPL theatrevPL = new TheatrevPL();
            TheatrevBLL theatrevBLL = new TheatrevBLL();
            Theatrev Theatrev = new Theatrev();
            int A = 0;
            Console.WriteLine("EnterTheatre Id : ");
            Theatrev.TheatrevId = Convert.ToInt32(Console.ReadLine());
            string msg = theatrevBLL.DeleteTheatrevBLL(Theatrev.TheatrevId);
            Console.WriteLine(msg);
        }

        public void ShowAllTheatre()
        {
            TheatrevPL theatrevPL = new TheatrevPL();
            TheatrevBLL theatrevBLL = new TheatrevBLL();
            Theatrev Theatrev = new Theatrev();

            List<Theatrev> Theatres = theatrevBLL.showallBLL();
            foreach (var item in Theatres)
            {
                Console.WriteLine("Id : " + item.TheatrevId);
                Console.WriteLine("Name : " + item.TheatrevName);
                Console.WriteLine("Description : " + item.TheatrevComments);
                Console.WriteLine("Movie Address : " + item.TheatrevAddress);

            }

        }

    }
}
