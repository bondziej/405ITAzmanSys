using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class FlightAvailabilityFormDbConn : DbConn
    {

        public void searchFlights (string F_Depar_DateTime, string F_Arrival_DateTime, string F_Departure_City, string F_Arrival_City)
        {
            MySqlCommand comm = conn.CreateCommand();
            //MySqlDataReader rd = comm.ExecuteReader();
            //comm.CommandText = "SELECT FROM `tblflight` WHERE `F_Depar_DateTime` = @F_Depar_DateTime, `F_Arrival_DateTime` = @F_Arrival_DateTime, `F_Depature_City` = @F_Depature_City, `F_Arrival_City` = @F_Arrival_City";
            comm.CommandText = "SELECT `F_Depar_DateTime`, `F_Arrival_DateTime`, `F_Departure_City` `F_Arrival_City` FROM `tblflight`";
            comm.Parameters.AddWithValue("@F_Depar_DateTime", F_Depar_DateTime);
            comm.Parameters.AddWithValue("@F_Arrival_DateTime", F_Arrival_DateTime);
            comm.Parameters.AddWithValue("@F_Departure_City", F_Departure_City);
            comm.Parameters.AddWithValue("@F_Arrival_City", F_Arrival_City);

            comm.ExecuteNonQuery();
            connClose();

        }


    }
}
