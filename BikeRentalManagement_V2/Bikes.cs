using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement_V2
{
    internal class Bikes
    {

        private string BikeId { get; set; }
        private string Brand { get; set; }
        private string Model { get; set; }
        private decimal RentalPrice { get; set; }

    public Bikes(string bikeId, string brand, string model, decimal rentalPrice)
    {
        BikeId = bikeId;
        Brand = brand;
        Model = model;
        RentalPrice = rentalPrice;
    }

    public virtual string DisplayBikeInfo()
    {
        return ($"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}");
    }

    public override string ToString()
    {
        return ($"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}");
    }
    }
}
