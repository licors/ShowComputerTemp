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
        int cpuOverTempSecond;
        int gpuOverTempSecond;
        int cpuMax = 0;
        int gpuMax = 0;
        int cpuYellow = 73;
        int cpuRed = 84;
        int gpuYellow = 73;
        int gpuRed = 84;

        public Form1()
        {
            InitializeComponent();
            comMonitor = new ComMonitor();
            cpuOverTempSecond = 0;
            gpuOverTempSecond = 0;
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
                if(cpuTemp > cpuYellow)
                {
                    if(cpuTemp > cpuRed)
                    {
                        textBox_cpu5.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox_cpu5.BackColor = Color.Yellow;
                    }
                    
                    if(cpuMax < cpuTemp)
                    {
                        cpuMax = cpuTemp;
                    }
                    label_maxCpu.Text = cpuMax.ToString();
                    cpuOverTempSecond += 2;
                }
            }

            textBox_gpu.Text = temperature[5];
            if (Int32.TryParse(temperature[5], out gpuTemp))
            {
                if (gpuTemp > gpuYellow)
                {
                    if(gpuTemp > gpuRed)
                    {
                        textBox_gpu.BackColor = Color.Red;
                    }
                    else
                    {
                        textBox_gpu.BackColor = Color.Yellow;
                    }

                    if (gpuMax < gpuTemp)
                    {
                        gpuMax = gpuTemp;
                    }
                    label_maxGpu.Text = gpuMax.ToString();
                    gpuOverTempSecond += 2;
                }
            }
            
            textBox_ram.Text = comMonitor.getRamInfo();
            textBox_cpuOverTime.Text = (cpuOverTempSecond/60).ToString("0");
            textBox_gpuOverTime.Text = (gpuOverTempSecond/60).ToString("0"); ;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            comMonitor.close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_cpu5.BackColor = Color.LightGray;
            textBox_gpu.BackColor = Color.LightGray;
            cpuMax = 0;
            gpuMax = 0;
        }
    }
}
