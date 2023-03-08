using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder_design_pattern.Builders;
using Builder_design_pattern.Products;

namespace Builder_design_pattern.ConcreteBuilders
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }
        public override void BuildChassis()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }
        public override void BuildEngine()
        {
            vehicle["engine"] = "600 cc";
        }
        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            vehicle["doors"] = "(NULL)";
        }
    }
}
