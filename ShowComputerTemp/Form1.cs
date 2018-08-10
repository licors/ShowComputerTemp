using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowComputerTemp
{
    public partial class Form1 : Form
    {
        ComMonitor comMonitor;
        int cpuTemp;
        int gpuTemp;

        public Form1()
        {
            InitializeComponent();
            comMonitor = new ComMonitor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String[] temperature = comMonitor.getTemperature();
            textBox_cpu1.Text = temperature[0];
            textBox_cpu2.Text = temperature[1];
            textBox_cpu3.Text = temperature[2];
            textBox_cpu4.Text = temperature[3];
            textBox_cpu5.Text = temperature[4];
            textBox_cpucnt.Text = comMonitor.getCounter();
            if(Int32.TryParse(temperature[4],out cpuTemp))
            {
                if(cpuTemp > 75)
                {
                    textBox_cpu5.BackColor = Color.Yellow;
                    label_maxCpu.Text = cpuTemp.ToString();
                }
                if(cpuTemp > 83)
                {
                    textBox_cpu5.BackColor = Color.Red;
                }
            }

            textBox_gpu.Text = temperature[5];
            if (Int32.TryParse(temperature[5], out gpuTemp))
            {
                if (gpuTemp > 75)
                {
                    textBox_gpu.BackColor = Color.Yellow;
                    label_maxGpu.Text = gpuTemp.ToString();
                }
                if (gpuTemp > 83)
                {
                    textBox_gpu.BackColor = Color.Red;
                }
            }
            
            textBox_ram.Text = comMonitor.getRamInfo();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comMonitor.close();
        }
    }
}
