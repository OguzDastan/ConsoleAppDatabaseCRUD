using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolApp_DB_
{
    class Program
    {
        static void Main(string[] args)
        {

            string queryInsert = "INSERT INTO DemoHotel (Hotel_No, Name, Address) VALUES (10, 'TestData', 'Testvej')";
            string queryDelete = "DELETE FROM DemoHotel WHERE Hotel_No = 10";
            string queryUpdate = "UPDATE DemoHotel SET Name = 'Det nye navn' WHERE Hotel_No = 1";
            DBClient data_1 = new DBClient();
            data_1.StartConnection(queryUpdate);
            

        }
    }
}
