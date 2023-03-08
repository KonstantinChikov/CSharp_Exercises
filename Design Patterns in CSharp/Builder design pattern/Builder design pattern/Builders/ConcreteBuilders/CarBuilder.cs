using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_design_pattern.Builders;
using Builder_design_pattern.Products;

namespace Builder_design_pattern.ConcreteBuilders
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            vehicle = new Vehicle("Car");
        }
        public override void BuildChassis()
        {
            vehicle["frame"] = "Car Shassis";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "5";
        }
    }
}
