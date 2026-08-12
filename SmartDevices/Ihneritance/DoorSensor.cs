using System;
using System.Collections.Generic;
using System.Text;

/*
DoorSensor inherits directly from Device because it is a smart device
that reports whether the door is open or closed.

It does not need the on/off and electricity functionality provided by
SwitchableDevice.
*/

namespace SmartDevices.Inheritance
{
   internal class DoorSensor : Device
    {
        public bool IsOpen { get; private set; }

        public int OpenCount { get; private set; }

        public DoorSensor(string name)
            : base(name)
        {
            IsOpen = false;
            OpenCount = 0;
            Status = "Closed";
        }

        public void OpenDoor()
        {
            IsOpen = true;
            OpenCount++;
            Status = "Open";
        }

        public void CloseDoor()
        {
            IsOpen = false;
            Status = "Closed";
        }

        public override string Report()
        {
            return $"{Name} | {Status} | opened {OpenCount} times today";
        }
    }
}