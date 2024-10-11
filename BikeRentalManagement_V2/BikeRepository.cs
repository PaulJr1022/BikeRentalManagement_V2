using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement_V2
{
    internal class BikeRepository
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; database=BikeRentalManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public void CreateBike()
        {
            try
            {
                Console.Write("Enter Bike Id : ");
                string Id = Console.ReadLine();

                Console.Write("Enter Bike Brand : ");
                string brand = Console.ReadLine();

                Console.Write("Enter Bike Model :");
                string model = Console.ReadLine();

                Console.Write("Entwr Rental Bike Price");
                decimal price = decimal.Parse(Console.ReadLine());


                using (var connection = new SqlConnection(connectionString))
                {

                    var query = "Insert into Bikes (BikeId, Brand, Model, RentalPrice) values (@BikeId, @Brand, @Model, @RentalPrice";

                    using (var command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@BikeId", Id);
                        command.Parameters.AddWithValue("@Brand", brand);
                        command.Parameters.AddWithValue("@Model", model);
                        command.Parameters.AddWithValue("@RentalPrice", price);
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ViewBike()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {

                    var query = "select * from Bikes";

                    using (var command = new SqlCommand(query, connection))
                    {

                        command.
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateBike()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteBike()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

