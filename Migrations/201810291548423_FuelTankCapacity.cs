namespace CarsDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FuelTankCapacity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "FuelTankCapacity", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "FuelTankCapacity");
        }
    }
}
