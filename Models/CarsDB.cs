using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CarsDB.Models
{
    public class CarsDB : DbContext
    {
        public CarsDB() : base("name=CarsDB")
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}