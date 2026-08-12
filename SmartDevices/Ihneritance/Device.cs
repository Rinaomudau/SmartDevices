using System;
using System.Collections.Generic;
using System.Text;

/*
Device is the parent class for all smart devices because every device
in the house needs a Name, Status and Report() method.

Device is abstract because a generic Device should not be created on
its own. Each actual device must provide its own Report().
*/

namespace SmartDevices.Inheritance
    {
        internal abstract class Device
        {
            public string Name { get; }

            public string Status
            {
                get;
                protected set;
            }

            protected Device(string name)
            {
                Name = name;
                Status = "";
            }

            public abstract string Report();
        }
    }


