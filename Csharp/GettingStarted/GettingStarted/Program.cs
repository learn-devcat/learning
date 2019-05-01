using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
   class Program
   {
      static void Main( string[] args )
      {
         string tableNumber = "A100";
         int peopleCount = 4;

         DateTime reservationDateTime = new DateTime( 2019, 02, 14, 19, 0, 0 );
         CultureInfo cultureInfo = new CultureInfo( "en-US" );

         Console.WriteLine(
            "Table {0} has been booked for {1} people on {2} at {3}", 
               tableNumber,
               peopleCount,
               reservationDateTime.ToString("M/d/yyyy, cul"
         )
      }
   }
}
