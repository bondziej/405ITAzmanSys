using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AzmanSys
{
    class customerDbConn: DbConn
    {
        public void insertCustomer(string CusFName, string CusLName, string CusTelNum, string CusNationality)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO `tblCustomer` (`CusID`, `CusFName`, `CusLName`, `CusTelNum`, `CusNationality`) VALUES (NULL,@CusFName, @CusLName, @CusTelNum, @CusNationality);";
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.ExecuteNonQuery();
            connClose();
        }


        public void updateCustomer(string CusID, string CusFName, string CusLName, string CusTelNum, string CusNationality)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "UPDATE `tblCustomer` SET `CusFName`=@CusFName, `CusLName`=@CusLName, `CusTelNum`=@CusTelNum, `CusNationality`=@CusNationality WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.Parameters.AddWithValue("@CusFName", CusFName);
            comm.Parameters.AddWithValue("@CusLName", CusLName);
            comm.Parameters.AddWithValue("@CusTelNum", CusTelNum);
            comm.Parameters.AddWithValue("@CusNationality", CusNationality);
            comm.ExecuteNonQuery();
            connClose();

        }

        public void deleteCustomer(string CusID)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM `tblCustomer` WHERE CusID = @CusID";
            comm.Parameters.AddWithValue("@CusID", CusID);
            comm.ExecuteNonQuery();
            connClose();
        }
    }
}
