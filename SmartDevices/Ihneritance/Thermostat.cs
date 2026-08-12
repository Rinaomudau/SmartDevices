using System;
using System.Collections.Generic;
using System.Text;

/*
Thermostat inherits directly from Device because it is a smart device
that needs to report its current state.

It does not inherit from SwitchableDevice because the thermostat does
not need the on/off and electricity-consumption functionality used by
devices such as the Light, Kettle and SecurityCamera.

The Thermostat has its own TargetTemperature and CurrentTemperature
properties and a method for changing the target temperature.
*/
namespace SmartDevices.Inheritance
{
    internal class Thermostat : Device
    {
        public double TargetTemperature { get; private set; }

        public double CurrentTemperature { get; private set; }

        public Thermostat(string name, double targetTemperature, double currentTemperature) : base(name)
        {
            TargetTemperature = targetTemperature;
            CurrentTemperature = currentTemperature;

            UpdateStatus();
        }

        public void ChangeTarget(double newTarget)
        {
            TargetTemperature = newTarget;

            UpdateStatus();
        }

        private void UpdateStatus()
        {
            if (CurrentTemperature < TargetTemperature)
            {
                Status = "Heating";
            }
            else if (CurrentTemperature > TargetTemperature)
            {
                Status = "Cooling";
            }
            else
            {
                Status = "Inactive";
            }
        }

        public override string Report()
        {
            return $"{Name} | {Status} | target {TargetTemperature:0.0}C, now {CurrentTemperature:0.0}C";
        }
    }
}