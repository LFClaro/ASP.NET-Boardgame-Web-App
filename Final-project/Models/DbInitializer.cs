using Final_project.Data;
using System;
using System.Linq;

namespace Final_project.Models
{
    public class DbInitializer
    {
        public static void Initialize(BoardGamesContext context)

        {

            context.Database.EnsureCreated();


            if (context.BoardGames.Any())

            {

                return;

            }



            var boardGames = new BoardGame[]

            {

         new BoardGame{Name="The Settlers of Catan" , NumberOfPlayersMin=3 , NumberOfPlayersMax=4 , Playing_Time="60-120 Min" , MinAge=10, Quantity=20},
         new BoardGame{Name="Ticket to Ride" , NumberOfPlayersMin=2 ,  NumberOfPlayersMax=5 , Playing_Time="30-60 Min" , MinAge=8, Quantity=20},
         new BoardGame{Name="Carcassonne" , NumberOfPlayersMin=2 , NumberOfPlayersMax=5 , Playing_Time="30-45 Min" , MinAge=7, Quantity=30},
         new BoardGame{Name="7 Wonders" , NumberOfPlayersMin=2 , NumberOfPlayersMax=7 , Playing_Time="30 Min" , MinAge=10, Quantity=10},

            };

            foreach (BoardGame b in boardGames)

            {

                context.BoardGames.Add(b);

            }

            context.SaveChanges();
        }
    }
}
