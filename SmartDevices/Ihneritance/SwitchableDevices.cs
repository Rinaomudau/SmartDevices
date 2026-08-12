/*
SwitchableDevice inherits from Device because a switchable device
is still a Device, but it also needs common functionality for
being turned on and off and recording electricity usage.

Light, Kettle and SecurityCamera inherit from SwitchableDevice
because they can be switched on and off and consume electricity.
*/

namespace SmartDevices.Inheritance
{
    internal abstract class SwitchableDevice : Device
    {
        public bool IsOn { get; private set; }

        public abstract double RatedWatts { get; }

        public double TotalKilowattHours { get; private set; }

        protected SwitchableDevice(string name): base(name)
        {
            IsOn = false;
            TotalKilowattHours = 0;
            Status = "Off";
        }

        public void TurnOn()
        {
            IsOn = true;
            Status = "On";
        }

        public void TurnOff()
        {
            IsOn = false;
            Status = "Off";
        }

        public void Toggle()
        {
            if (IsOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }

        public void RecordHour()
        {
            if (IsOn)
            {
                TotalKilowattHours += RatedWatts / 1000.0;
            }
        }
    }
}