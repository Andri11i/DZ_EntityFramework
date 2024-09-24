using DZ_EntityFramework.Models;

public class Program
{
 


    static void Main()
    {
        var context = new DzefwContext();


        bool IsRoomAvailable(int roomId, DateTime startDate, DateTime endDate)
        {
            return !context.Bookings.Any(b => b.RoomID == roomId && (startDate <= b.EndDate && endDate >= b.StartDate));
        }

        bool IsBookAvailable(int bookId, DateTime startDate)
        {
            return !context.Rentals.Any(r => r.BookID == bookId && startDate <= r.EndDate);
        }



    }





}



