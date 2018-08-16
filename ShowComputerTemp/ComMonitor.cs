using System;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;

namespace ShowComputerTemp
{
    class ComMonitor
    {

        /// <summary>
        /// Add CPU and GPU and as hardware
        /// Note that, CPU temperature data requires 'highestAvailable' permission.
        /// </summary>
        private Computer computer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled = true };
        /// <summary>
        /// These objects are used to access performance Monitor of the operating system.
        /// </summary>
        private PerformanceCounter perfCpuCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        private PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");

        /// <summary>
        /// Variables for the RAM.
        /// Total ram is in MB and is the total thats in your system
        /// </summary>
        private double tRam;

        public ComMonitor()
        {
            computer.Open();
        }

        /// <summary>
        /// This method is used to get cpu temperature
        /// and gpu temperature using OpenHardwareMonitor library
        /// </summary>
        public String[] getTemperature()
        {
            int i = 0;
            String[] temperature = new string[10];

            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        temperature[i] = sensor.Value.ToString();
                        i++;
                    }
                }
            }
            return temperature;
        }

        public String getCounter()
        {
           return perfCpuCounter.NextValue().ToString("0");
        }
        /// <summary>
        /// This method is used to get cpu and memory load
        /// from the Performance Monitor
        /// </summary>
        public String getRamInfo()
        {
            tRam = (int)perfMemCounter.NextValue();

            return tRam.ToString();
        }

        public void close()
        {
            computer.Close();
        }
    }
}
