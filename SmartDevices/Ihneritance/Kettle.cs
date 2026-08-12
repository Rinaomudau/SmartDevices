using System;
using System.Collections.Generic;
using System.Text;

/*
Kettle inherits from SwitchableDevice because a kettle can be switched
on and off and consumes power while it is on.
*/

namespace SmartDevices.Inheritance
{
    internal class Kettle : SwitchableDevice
    {
        public override double RatedWatts => 2200;   

        public Kettle(string name): base(name)
        {
            //The Kettle uses the parent class's constructor to set its name.
        }

        public override string Report()
        {
            return $"{Name} | {Status} | {RatedWatts:0}W | {TotalKilowattHours:0.000} kWh";
        }
    }
}