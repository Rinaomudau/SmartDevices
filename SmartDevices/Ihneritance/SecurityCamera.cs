using System;
using System.Collections.Generic;
using System.Text;

/*
SecurityCamera inherits from SwitchableDevice because a security
camera can be switched on and off and consumes power while it is on.
*/

namespace SmartDevices.Inheritance
{
    internal class SecurityCamera : SwitchableDevice
    {
        public override double RatedWatts => 12;

        public SecurityCamera(string name) : base(name)
        {
            //The SecurityCamera uses the parent class's constructor to set its name.
        }

        public override string Report()
        {
            return $"{Name} | {Status} | {RatedWatts:0}W | {TotalKilowattHours:0.000} kWh";
        }
    }
}