using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzmanSys
{
    class BookingsDbConn : DbConn
    {
        public void insertBooking(string BookingID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)

        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblBooking` (`BookingID`, `CusID`, `FlightID`, `Booking_DateTime`, `Total_BookingCost`) VALUES (NULL,@CusId, @FlightID, @Booking_DateTime, @Total_BookingCost);";
            comm.Parameters.AddWithValue("@BookingID", BookingID);
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.ExecuteNonQuery();
            connClose();

        }

  


        public void updateBooking(String BookingID, string CusID, string FlightID, string Booking_DateTime, string Total_BookingCost)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblBooking` SET `CusID`=@CusID,`FlightID`=@FlightID,`Booking_DateTime`=@Booking_DateTime,`Total_BookingCost`=@Total_BookingCost WHERE BookingID=@BookingID";
            comm.Parameters.AddWithValue("@BookingID", BookingID);
            comm.Parameters.AddWithValue("@CusID", CusID );
            comm.Parameters.AddWithValue("@FlightID", FlightID);
            comm.Parameters.AddWithValue("@Booking_DateTime", Booking_DateTime);
            comm.Parameters.AddWithValue("@Total_BookingCost", Total_BookingCost);
            comm.ExecuteNonQuery();
            connClose();
        }
        public void deleteBooking(string BookingID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblBooking` WHERE `BookingID` = @BookingID";
            comm.Parameters.AddWithValue("@BookingID", BookingID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
