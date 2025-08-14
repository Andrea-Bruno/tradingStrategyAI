namespace Bitcoin_Strategy
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.D1 = new System.Windows.Forms.TextBox();
            this.M1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.D2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.M2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.D3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.S3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.D4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.S4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ShowRobot = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(786, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "----";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "D1";
            // 
            // D1
            // 
            this.D1.Location = new System.Drawing.Point(40, 52);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(50, 20);
            this.D1.TabIndex = 4;
            this.D1.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // M1
            // 
            this.M1.Location = new System.Drawing.Point(40, 78);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(50, 20);
            this.M1.TabIndex = 6;
            this.M1.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "M1";
            // 
            // D2
            // 
            this.D2.Location = new System.Drawing.Point(40, 104);
            this.D2.Name = "D2";
            this.D2.Size = new System.Drawing.Size(50, 20);
            this.D2.TabIndex = 8;
            this.D2.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "D2";
            // 
            // M2
            // 
            this.M2.Location = new System.Drawing.Point(40, 130);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(50, 20);
            this.M2.TabIndex = 10;
            this.M2.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "M2";
            // 
            // D3
            // 
            this.D3.Location = new System.Drawing.Point(40, 156);
            this.D3.Name = "D3";
            this.D3.Size = new System.Drawing.Size(50, 20);
            this.D3.TabIndex = 12;
            this.D3.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "D3";
            // 
            // S3
            // 
            this.S3.Location = new System.Drawing.Point(40, 182);
            this.S3.Name = "S3";
            this.S3.Size = new System.Drawing.Size(50, 20);
            this.S3.TabIndex = 14;
            this.S3.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "S3";
            // 
            // D4
            // 
            this.D4.Location = new System.Drawing.Point(40, 208);
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(50, 20);
            this.D4.TabIndex = 16;
            this.D4.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "D4";
            // 
            // S4
            // 
            this.S4.Location = new System.Drawing.Point(40, 234);
            this.S4.Name = "S4";
            this.S4.Size = new System.Drawing.Size(50, 20);
            this.S4.TabIndex = 18;
            this.S4.Click += new System.EventHandler(this.ClickTextBox);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "S4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Speed n/h";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(190, 10);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(13, 13);
            this.Speed.TabIndex = 20;
            this.Speed.Text = "0";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(105, 33);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(669, 277);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // ShowRobot
            // 
            this.ShowRobot.Location = new System.Drawing.Point(699, 4);
            this.ShowRobot.Name = "ShowRobot";
            this.ShowRobot.Size = new System.Drawing.Size(75, 23);
            this.ShowRobot.TabIndex = 22;
            this.ShowRobot.Text = "Robot";
            this.ShowRobot.UseVisualStyleBackColor = true;
            this.ShowRobot.Click += new System.EventHandler(this.ShowRobot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 335);
            this.Controls.Add(this.ShowRobot);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.S4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.S3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.D3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.M2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.D2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.M1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.D1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox D1;
        public System.Windows.Forms.TextBox M1;
        public System.Windows.Forms.TextBox D2;
        public System.Windows.Forms.TextBox M2;
        public System.Windows.Forms.TextBox D3;
        public System.Windows.Forms.TextBox S3;
        public System.Windows.Forms.TextBox D4;
        public System.Windows.Forms.TextBox S4;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label Speed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ShowRobot;
    }
}

