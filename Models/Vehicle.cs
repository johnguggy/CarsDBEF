using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsDB.Models
{
    public class Vehicle
    {
        public virtual int Id { get; set; }

        public virtual int Year { get; set; }

        public virtual string Make { get; set; }

        public virtual string Model { get; set; }

        public virtual int Qty { get; set; }

        public virtual int VehicleTypeId { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        public virtual int? FuelTankCapacity { get; set; }

        public virtual string Rating { get; set; }
    }
}