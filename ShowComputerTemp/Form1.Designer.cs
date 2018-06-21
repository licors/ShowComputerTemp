namespace ShowComputerTemp
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.label_cpu = new System.Windows.Forms.Label();
            this.label_gpu = new System.Windows.Forms.Label();
            this.textBox_cpu1 = new System.Windows.Forms.TextBox();
            this.textBox_gpu = new System.Windows.Forms.TextBox();
            this.label_ram = new System.Windows.Forms.Label();
            this.textBox_ram = new System.Windows.Forms.TextBox();
            this.textBox_cpu2 = new System.Windows.Forms.TextBox();
            this.textBox_cpu3 = new System.Windows.Forms.TextBox();
            this.textBox_cpu4 = new System.Windows.Forms.TextBox();
            this.textBox_cpu5 = new System.Windows.Forms.TextBox();
            this.label_maxCpu = new System.Windows.Forms.Label();
            this.label_maxGpu = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_cpu
            // 
            this.label_cpu.AutoSize = true;
            this.label_cpu.Location = new System.Drawing.Point(15, 29);
            this.label_cpu.Name = "label_cpu";
            this.label_cpu.Size = new System.Drawing.Size(30, 12);
            this.label_cpu.TabIndex = 0;
            this.label_cpu.Text = "CPU";
            // 
            // label_gpu
            // 
            this.label_gpu.AutoSize = true;
            this.label_gpu.Location = new System.Drawing.Point(194, 29);
            this.label_gpu.Name = "label_gpu";
            this.label_gpu.Size = new System.Drawing.Size(30, 12);
            this.label_gpu.TabIndex = 1;
            this.label_gpu.Text = "GPU";
            // 
            // textBox_cpu1
            // 
            this.textBox_cpu1.CausesValidation = false;
            this.textBox_cpu1.Location = new System.Drawing.Point(51, 26);
            this.textBox_cpu1.Name = "textBox_cpu1";
            this.textBox_cpu1.ReadOnly = true;
            this.textBox_cpu1.Size = new System.Drawing.Size(100, 21);
            this.textBox_cpu1.TabIndex = 2;
            // 
            // textBox_gpu
            // 
            this.textBox_gpu.Location = new System.Drawing.Point(230, 26);
            this.textBox_gpu.Name = "textBox_gpu";
            this.textBox_gpu.ReadOnly = true;
            this.textBox_gpu.Size = new System.Drawing.Size(100, 21);
            this.textBox_gpu.TabIndex = 3;
            // 
            // label_ram
            // 
            this.label_ram.AutoSize = true;
            this.label_ram.Location = new System.Drawing.Point(193, 56);
            this.label_ram.Name = "label_ram";
            this.label_ram.Size = new System.Drawing.Size(31, 12);
            this.label_ram.TabIndex = 4;
            this.label_ram.Text = "Ram";
            // 
            // textBox_ram
            // 
            this.textBox_ram.Location = new System.Drawing.Point(230, 53);
            this.textBox_ram.Name = "textBox_ram";
            this.textBox_ram.ReadOnly = true;
            this.textBox_ram.Size = new System.Drawing.Size(100, 21);
            this.textBox_ram.TabIndex = 5;
            // 
            // textBox_cpu2
            // 
            this.textBox_cpu2.Location = new System.Drawing.Point(51, 53);
            this.textBox_cpu2.Name = "textBox_cpu2";
            this.textBox_cpu2.ReadOnly = true;
            this.textBox_cpu2.Size = new System.Drawing.Size(100, 21);
            this.textBox_cpu2.TabIndex = 2;
            // 
            // textBox_cpu3
            // 
            this.textBox_cpu3.Location = new System.Drawing.Point(51, 80);
            this.textBox_cpu3.Name = "textBox_cpu3";
            this.textBox_cpu3.ReadOnly = true;
            this.textBox_cpu3.Size = new System.Drawing.Size(100, 21);
            this.textBox_cpu3.TabIndex = 2;
            // 
            // textBox_cpu4
            // 
            this.textBox_cpu4.Location = new System.Drawing.Point(51, 107);
            this.textBox_cpu4.Name = "textBox_cpu4";
            this.textBox_cpu4.ReadOnly = true;
            this.textBox_cpu4.Size = new System.Drawing.Size(100, 21);
            this.textBox_cpu4.TabIndex = 2;
            // 
            // textBox_cpu5
            // 
            this.textBox_cpu5.Location = new System.Drawing.Point(51, 134);
            this.textBox_cpu5.Name = "textBox_cpu5";
            this.textBox_cpu5.ReadOnly = true;
            this.textBox_cpu5.Size = new System.Drawing.Size(100, 21);
            this.textBox_cpu5.TabIndex = 2;
            // 
            // label_maxCpu
            // 
            this.label_maxCpu.AutoSize = true;
            this.label_maxCpu.Location = new System.Drawing.Point(230, 115);
            this.label_maxCpu.Name = "label_maxCpu";
            this.label_maxCpu.Size = new System.Drawing.Size(53, 12);
            this.label_maxCpu.TabIndex = 6;
            this.label_maxCpu.Text = "maxCpu";
            // 
            // label_maxGpu
            // 
            this.label_maxGpu.AutoSize = true;
            this.label_maxGpu.Location = new System.Drawing.Point(230, 142);
            this.label_maxGpu.Name = "label_maxGpu";
            this.label_maxGpu.Size = new System.Drawing.Size(53, 12);
            this.label_maxGpu.TabIndex = 7;
            this.label_maxGpu.Text = "maxGpu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 177);
            this.Controls.Add(this.label_maxGpu);
            this.Controls.Add(this.label_maxCpu);
            this.Controls.Add(this.textBox_ram);
            this.Controls.Add(this.label_ram);
            this.Controls.Add(this.textBox_gpu);
            this.Controls.Add(this.textBox_cpu5);
            this.Controls.Add(this.textBox_cpu4);
            this.Controls.Add(this.textBox_cpu3);
            this.Controls.Add(this.textBox_cpu2);
            this.Controls.Add(this.textBox_cpu1);
            this.Controls.Add(this.label_gpu);
            this.Controls.Add(this.label_cpu);
            this.Name = "Form1";
            this.Text = "Temperature_Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cpu;
        private System.Windows.Forms.Label label_gpu;
        private System.Windows.Forms.TextBox textBox_cpu1;
        private System.Windows.Forms.TextBox textBox_gpu;
        private System.Windows.Forms.Label label_ram;
        private System.Windows.Forms.TextBox textBox_ram;
        private System.Windows.Forms.TextBox textBox_cpu2;
        private System.Windows.Forms.TextBox textBox_cpu3;
        private System.Windows.Forms.TextBox textBox_cpu4;
        private System.Windows.Forms.TextBox textBox_cpu5;
        private System.Windows.Forms.Label label_maxCpu;
        private System.Windows.Forms.Label label_maxGpu;
    }
}

