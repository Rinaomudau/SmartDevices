using SmartDevices.Inheritance;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;


/*Light inherits from SwitchableDevice because a light can be switched
on and off and consumes power while it is on.
*/

namespace SmartDevices.Inheritance
    {
        internal class Light : SwitchableDevice
        {
            public override double RatedWatts => 9;

            public Light(string name) : base(name)
            {
            //The Light uses the parent class's constructor to set its name.
        }

        public override string Report()
            {
                return $"{Name} | {Status} | {RatedWatts:0}W | {TotalKilowattHours:0.000} kWh";
            }
        }
    }

