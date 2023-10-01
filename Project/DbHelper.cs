using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class DbHelper
    {
        private string connectionString; // สตริงเชื่อมต่อฐานข้อมูล ODBC

        public DbHelper(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // เมธอดสำหรับ Insert ข้อมูลในตาราง OilTank
        public void InsertOilTank(string tankID, string oilID, string oilCpt,string oilVolume)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO OilTank (TankID, OilID, MaxCapacity,CurrentVolume) VALUES (?, ?, ?,?)";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("TankID", tankID);
                    command.Parameters.AddWithValue("OilID", oilID);
                    command.Parameters.AddWithValue("MaxCapacity",oilCpt );
                    command.Parameters.AddWithValue("CurrentVolume", oilVolume);

                    command.ExecuteNonQuery();
                }
            }
        }

        // เมธอดสำหรับ Update ข้อมูลในตาราง OilTank
        public void UpdateOilTank(string tankID, string oilID, string oilCpt, string oilVolume)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE OilTank SET OilID=?, MaxCapacity=?,CurrentVolume=? WHERE TankID = ?";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("OilID", oilID);
                    command.Parameters.AddWithValue("MaxCapacity", oilCpt);
                    command.Parameters.AddWithValue("CurrentVolume", oilVolume);
                    command.Parameters.AddWithValue("TankID", tankID);

                    command.ExecuteNonQuery();
                }
            }
        }

        // เมธอดสำหรับ Delete ข้อมูลในตาราง OilTank
        public void DeleteOilTank(string tankID)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM OilTank WHERE TankID = ?";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("TankID", tankID);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertDispenser(string tankID, string dispenserID)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO Dispenser (DispenserID, OilTankID) VALUES (?, ?)";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("OilTankID", tankID);
                    command.Parameters.AddWithValue("DispenserID", dispenserID);


                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateDispenser(string tankID, string dispenserID)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Dispenser SET OilTankID=? WHERE DispenserID = ?";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("OilTankID", tankID);
                    command.Parameters.AddWithValue("DispenserID", dispenserID);


                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteDispenser(string dispenserID)
        {
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string sql = "DELETE FROM Dispenser WHERE DispenserID = ?";

                using (OdbcCommand command = new OdbcCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("DispenserID", dispenserID);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
