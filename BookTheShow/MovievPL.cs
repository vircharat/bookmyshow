using System;
using System.Collections.Generic;
using System.Text;
using BookTheShowEntity;
using BookTheShowDAL;
using BookTheShowBLL;

namespace BookTheShow
{
    public class MovievPL
    {
        public void menu()
        {
            MovievPL moviePLObj = new MovievPL();
            TheatrevPL theatrevPL = new TheatrevPL();
            ShowTimePL showTimePL = new ShowTimePL();   
            bool flag = true;
            Console.WriteLine("Welcome to movie app");
            Console.WriteLine("Enter 1 to movie section\n" +
                "Enter 2 to theatre section\n" +
                "Enter 3 to showtime section");
            int codeentered;
            codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {

                case 1:
                        Console.WriteLine("-----------------------------------------------------------------------------------------\n" +
                            "__________________________________________________________________________________________");
                        flag = moviePLObj.menuMovie();
                   
                    break;


                   
                 case 2:
                    
                    
                        Console.WriteLine("-----------------------------------------------------------------------------------------\n" +
                            "__________________________________________________________________________________________");
                        flag = theatrevPL.menuTheatre();
                   
                    break;

                case 3:
                    Console.WriteLine("-----------------------------------------------------------------------------------------\n" +
                         "__________________________________________________________________________________________");
                    flag = showTimePL.menuShow();

                    break;

                default:
                    flag = false;
                    break;





            }
          
        }
        public bool menuMovie()
        {
            bool flag = false;
            MovievPL moviePLObj = new MovievPL();
         
            Console.WriteLine("To choose the number for function");

            Console.WriteLine("Enter 1 to add\n" +
                "Enter 2 to deletet move\n" +
                "Enter 3 to Show Movie by its id\n" +
                "Enter 4 to show all movies\n" +
                "Enter 5 to Update movies\n" +
                "Enter 6 to show by type of movie\n" +
                "Enter 7 to show name and id by type of movie\n" +
                "Enter 8 to exit");
            int codeentered;
            codeentered = Convert.ToInt32(Console.ReadLine());
            switch (codeentered)
            {

                case 1:
                    moviePLObj.AddMovie();
                    flag = true;

                    break;
                case 2:
                    moviePLObj.DeleteMovie();
                    flag = true;
                    break;
                case 3:
                    moviePLObj.ShowMovieById();
                    flag = true;
                    break;
                case 4:
                    moviePLObj.ShowAllMovies();
                    flag = true;
                    break;
                case 5:
                    moviePLObj.UpdateMovie();
                    flag = true;
                    break;
                case 6:
                    moviePLObj.ShowAllByMovieType();
                    flag = true;
                    break;
                case 7:
                    moviePLObj.ShowAllByMovieTypeDisplaynameonly();
                    flag = true;
                    break;
                case 8:
                    flag = false;
                    break;

                default:
                    Console.WriteLine("Invalid code");

                    break;





            }
            return flag;



        }
        public void UpdateMovie()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter the Movie Id");
            moviev.MovievId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Movie Name : ");
            moviev.MovievName = Console.ReadLine();

            Console.WriteLine("Enter Movie Type : ");
            moviev.MovievName= Console.ReadLine();
            Console.WriteLine("Movie Description  : ");
            moviev.MovievDesc = Console.ReadLine();
            string msg = MovievOperationv.UpdateMovie(moviev);
            Console.WriteLine(msg);

        }
        public void AddMovie()
        {
            Moviev movie = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter Movie Name : ");
            movie.MovievName = Console.ReadLine();

            Console.WriteLine("Enter Movie Type : ");
            movie.MovievType = Console.ReadLine();
            Console.WriteLine("Movie Description  : ");
            movie.MovievDesc = Console.ReadLine();
            string msg = MovievOperationv.AddMovie(movie);
            Console.WriteLine(msg);

        }
        public void ShowAllByMovieType()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter Movie Type : ");
            moviev.MovievType = Console.ReadLine();
            List<Moviev> movies = MovievOperationv.ShowAllByMovieType(moviev.MovievType);
            foreach (var item in movies)
            {
                Console.WriteLine(item.MovievId);
                Console.WriteLine(item.MovievName);
                Console.WriteLine(item.MovievDesc);
                Console.WriteLine(item.MovievType);

            }


        }
        public void ShowAllByMovieTypeDisplaynameonly()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter Movie Type : ");
            moviev.MovievType = Console.ReadLine();
            List<Moviev> movies = MovievOperationv.ShowAllByMovieTypeDisplaynameonly(moviev.MovievType);
            foreach (var item in movies)
            {
                Console.WriteLine(item.MovievId);
                Console.WriteLine(item.MovievName);

            }


        }

        public void DeleteMovie()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter Movie Id : ");
            moviev.MovievId = Convert.ToInt32(Console.ReadLine());
            string msg = MovievOperationv.DeleteMovie(moviev.MovievId);
            Console.WriteLine(msg);
        }
        public void ShowMovieById()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            Console.WriteLine("Enter Movie Id : ");
            moviev.MovievId= Convert.ToInt32(Console.ReadLine());
            moviev = MovievOperationv.ShowMovieByid(moviev.MovievId);
            Console.WriteLine(moviev.MovievName);
        }


        public void ShowAllMovies()
        {
            Moviev moviev = new Moviev();
            MovievOperationv MovievOperationv = new MovievOperationv();
            List<Moviev> movies = MovievOperationv.ShowAll();
            foreach (var item in movies)
            {
                Console.WriteLine("Id : " + item.MovievId);
                Console.WriteLine("Name : " + item.MovievName);
                Console.WriteLine("Description : " + item.MovievDesc);
                Console.WriteLine("Movie Type : " + item.MovievType);

            }

        }

    }
}
