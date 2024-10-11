using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement_V2
{
    internal class Program
    {
        private string connectionString;

        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; database=BikeRentalManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            BikeRepository repository = new BikeRepository();
            int respones = 0;
            do
            {
                Console.WriteLine("\n Bike Rental Management System" +
                    "\n 1. Add Bike" +
                    "\n 2. View All Bikes" +
                    "\n 3. Update a bike" +
                    "\n 4. Delete a bike " +
                    "\n 5. exit ");

                Console.Write("Choose an option");

                switch (respones)
                {
                    case 1:
                        repository.CreateBike();
                        break;
                    case 2:
                        repository.ViewBike();
                        break;
                    case 3:
                        repository.UpdateBike();
                        break;
                    case 4:
                        repository.DeleteBike();
                        break;


                }
            } while (respones != 5);

        }
    }
}
