using System;
using System.Collections.Generic;
using SmartDevices.Inheritance;

namespace SmartDevices.Sample
{
    internal class InheritanceSample
    {
        private List<Device> devices;

        public InheritanceSample()
        {
            devices = new List<Device>();
        }

        public void Run()
        {
   
            Light kitchenLight = new Light("Kitchen Light");

            devices.Add(kitchenLight);
            kitchenLight.TurnOn();

            Kettle kettle = new Kettle("Kettle");

            devices.Add(kettle);


            SecurityCamera frontCamera = new SecurityCamera("Front Camera");

            devices.Add(frontCamera);
            frontCamera.TurnOn();

            Thermostat thermostat = new Thermostat( "Thermostat", 21.0, 19.5);
            Device thermostatDevice = thermostat;
            devices.Add(thermostatDevice);

            DoorSensor frontDoor = new DoorSensor("Front Door");

            devices.Add(frontDoor);


          


            // I chose the assignment example 6  
            for (int i = 0; i < 6; i++)
            {
                frontDoor.OpenDoor();
                frontDoor.CloseDoor();
            }


            // This is my 24 hours loop
            for (int hour = 0; hour < 24; hour++)
            {
                foreach (Device device in devices)
                {
                    if (device is SwitchableDevice switchable)
                    {
                        switchable.RecordHour();
                    }
                }
            }


           // This is to show reports of all devices
            foreach (Device device in devices)
            {
                Console.WriteLine(device.Report());
            }


            // Total calculation method
            double total = 0;

            foreach (Device device in devices)
            {
                if (device is SwitchableDevice switchable)
                {
                    total += switchable.TotalKilowattHours;
                }
            }
            Console.WriteLine();

            Console.WriteLine($"House total: {total:0.000} kWh");
        }
    }
}