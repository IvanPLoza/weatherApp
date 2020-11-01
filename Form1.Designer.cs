namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LocationTitle = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.temp = new System.Windows.Forms.Label();
            this.weatherDescription = new System.Windows.Forms.Label();
            this.weatherTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperatureMinMaxDisplay = new System.Windows.Forms.Label();
            this.humidityValueDisplay = new System.Windows.Forms.Label();
            this.visibilityValueDisplay = new System.Windows.Forms.Label();
            this.windValueDisplay = new System.Windows.Forms.Label();
            this.temperatureValueDisplay = new System.Windows.Forms.Label();
            this.futureWeatherDayDisplay = new System.Windows.Forms.ListBox();
            this.futureWeatherTempDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.futureWeatherHumidtyDisplay = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.futureWeatherWindDisplay = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.futureWeatherVisibilityDisplay = new System.Windows.Forms.ListBox();
            this.futureHourlyWeatherDisplay = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationTitle
            // 
            this.LocationTitle.AccessibleName = "";
            this.LocationTitle.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationTitle.Location = new System.Drawing.Point(32, 37);
            this.LocationTitle.Name = "LocationTitle";
            this.LocationTitle.Size = new System.Drawing.Size(109, 35);
            this.LocationTitle.TabIndex = 1;
            this.LocationTitle.Text = "Lokacija";
            this.LocationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LocationTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // weatherIcon
            // 
            this.weatherIcon.Image = ((System.Drawing.Image)(resources.GetObject("weatherIcon.Image")));
            this.weatherIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("weatherIcon.InitialImage")));
            this.weatherIcon.Location = new System.Drawing.Point(147, 33);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(80, 80);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherIcon.TabIndex = 4;
            this.weatherIcon.TabStop = false;
            this.weatherIcon.Click += new System.EventHandler(this.weatherIcon_Click);
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(233, 23);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(143, 17);
            this.temp.TabIndex = 5;
            this.temp.Text = "Temperatura(min/max):";
            this.temp.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // weatherDescription
            // 
            this.weatherDescription.AutoSize = true;
            this.weatherDescription.Location = new System.Drawing.Point(165, 13);
            this.weatherDescription.Name = "weatherDescription";
            this.weatherDescription.Size = new System.Drawing.Size(43, 17);
            this.weatherDescription.TabIndex = 3;
            this.weatherDescription.Text = "label1";
            this.weatherDescription.Click += new System.EventHandler(this.weatherDescription_Click);
            // 
            // weatherTitle
            // 
            this.weatherTitle.AutoSize = true;
            this.weatherTitle.Location = new System.Drawing.Point(165, 116);
            this.weatherTitle.Name = "weatherTitle";
            this.weatherTitle.Size = new System.Drawing.Size(43, 17);
            this.weatherTitle.TabIndex = 6;
            this.weatherTitle.Text = "label1";
            this.weatherTitle.Click += new System.EventHandler(this.weatherTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vlažnost zraka:";
            this.label1.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vjetar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vidljivost:";
            // 
            // temperatureMinMaxDisplay
            // 
            this.temperatureMinMaxDisplay.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureMinMaxDisplay.Location = new System.Drawing.Point(382, 21);
            this.temperatureMinMaxDisplay.Name = "temperatureMinMaxDisplay";
            this.temperatureMinMaxDisplay.Size = new System.Drawing.Size(85, 19);
            this.temperatureMinMaxDisplay.TabIndex = 5;
            this.temperatureMinMaxDisplay.Text = "10";
            this.temperatureMinMaxDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.temperatureMinMaxDisplay.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // humidityValueDisplay
            // 
            this.humidityValueDisplay.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.humidityValueDisplay.Location = new System.Drawing.Point(382, 44);
            this.humidityValueDisplay.Name = "humidityValueDisplay";
            this.humidityValueDisplay.Size = new System.Drawing.Size(85, 19);
            this.humidityValueDisplay.TabIndex = 5;
            this.humidityValueDisplay.Text = "10";
            this.humidityValueDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.humidityValueDisplay.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // visibilityValueDisplay
            // 
            this.visibilityValueDisplay.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.visibilityValueDisplay.Location = new System.Drawing.Point(382, 69);
            this.visibilityValueDisplay.Name = "visibilityValueDisplay";
            this.visibilityValueDisplay.Size = new System.Drawing.Size(85, 19);
            this.visibilityValueDisplay.TabIndex = 5;
            this.visibilityValueDisplay.Text = "10";
            this.visibilityValueDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.visibilityValueDisplay.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // windValueDisplay
            // 
            this.windValueDisplay.Font = new System.Drawing.Font("Segoe UI", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.windValueDisplay.Location = new System.Drawing.Point(382, 94);
            this.windValueDisplay.Name = "windValueDisplay";
            this.windValueDisplay.Size = new System.Drawing.Size(85, 19);
            this.windValueDisplay.TabIndex = 5;
            this.windValueDisplay.Text = "10";
            this.windValueDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.windValueDisplay.Click += new System.EventHandler(this.temperatureDisplay_Click);
            // 
            // temperatureValueDisplay
            // 
            this.temperatureValueDisplay.AccessibleName = "";
            this.temperatureValueDisplay.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperatureValueDisplay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.temperatureValueDisplay.Location = new System.Drawing.Point(32, 72);
            this.temperatureValueDisplay.Name = "temperatureValueDisplay";
            this.temperatureValueDisplay.Size = new System.Drawing.Size(109, 35);
            this.temperatureValueDisplay.TabIndex = 1;
            this.temperatureValueDisplay.Text = "Lokacija";
            this.temperatureValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temperatureValueDisplay.Click += new System.EventHandler(this.label1_Click);
            // 
            // futureWeatherDayDisplay
            // 
            this.futureWeatherDayDisplay.FormattingEnabled = true;
            this.futureWeatherDayDisplay.ItemHeight = 17;
            this.futureWeatherDayDisplay.Location = new System.Drawing.Point(267, 236);
            this.futureWeatherDayDisplay.Name = "futureWeatherDayDisplay";
            this.futureWeatherDayDisplay.Size = new System.Drawing.Size(109, 106);
            this.futureWeatherDayDisplay.TabIndex = 10;
            // 
            // futureWeatherTempDisplay
            // 
            this.futureWeatherTempDisplay.FormattingEnabled = true;
            this.futureWeatherTempDisplay.ItemHeight = 17;
            this.futureWeatherTempDisplay.Location = new System.Drawing.Point(382, 236);
            this.futureWeatherTempDisplay.Name = "futureWeatherTempDisplay";
            this.futureWeatherTempDisplay.Size = new System.Drawing.Size(109, 106);
            this.futureWeatherTempDisplay.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dan/Prognoza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperatura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vlaga";
            // 
            // futureWeatherHumidtyDisplay
            // 
            this.futureWeatherHumidtyDisplay.FormattingEnabled = true;
            this.futureWeatherHumidtyDisplay.ItemHeight = 17;
            this.futureWeatherHumidtyDisplay.Location = new System.Drawing.Point(497, 236);
            this.futureWeatherHumidtyDisplay.Name = "futureWeatherHumidtyDisplay";
            this.futureWeatherHumidtyDisplay.Size = new System.Drawing.Size(109, 106);
            this.futureWeatherHumidtyDisplay.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vjetar";
            // 
            // futureWeatherWindDisplay
            // 
            this.futureWeatherWindDisplay.FormattingEnabled = true;
            this.futureWeatherWindDisplay.ItemHeight = 17;
            this.futureWeatherWindDisplay.Location = new System.Drawing.Point(612, 236);
            this.futureWeatherWindDisplay.Name = "futureWeatherWindDisplay";
            this.futureWeatherWindDisplay.Size = new System.Drawing.Size(109, 106);
            this.futureWeatherWindDisplay.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(727, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vidljivost";
            // 
            // futureWeatherVisibilityDisplay
            // 
            this.futureWeatherVisibilityDisplay.FormattingEnabled = true;
            this.futureWeatherVisibilityDisplay.ItemHeight = 17;
            this.futureWeatherVisibilityDisplay.Location = new System.Drawing.Point(727, 236);
            this.futureWeatherVisibilityDisplay.Name = "futureWeatherVisibilityDisplay";
            this.futureWeatherVisibilityDisplay.Size = new System.Drawing.Size(109, 106);
            this.futureWeatherVisibilityDisplay.TabIndex = 10;
            // 
            // futureHourlyWeatherDisplay
            // 
            this.futureHourlyWeatherDisplay.FormattingEnabled = true;
            this.futureHourlyWeatherDisplay.ItemHeight = 17;
            this.futureHourlyWeatherDisplay.Location = new System.Drawing.Point(36, 164);
            this.futureHourlyWeatherDisplay.Name = "futureHourlyWeatherDisplay";
            this.futureHourlyWeatherDisplay.Size = new System.Drawing.Size(191, 242);
            this.futureHourlyWeatherDisplay.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Prognoza po satu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(866, 434);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.futureHourlyWeatherDisplay);
            this.Controls.Add(this.futureWeatherVisibilityDisplay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.futureWeatherWindDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.futureWeatherHumidtyDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.futureWeatherTempDisplay);
            this.Controls.Add(this.futureWeatherDayDisplay);
            this.Controls.Add(this.temperatureValueDisplay);
            this.Controls.Add(this.windValueDisplay);
            this.Controls.Add(this.visibilityValueDisplay);
            this.Controls.Add(this.humidityValueDisplay);
            this.Controls.Add(this.temperatureMinMaxDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherTitle);
            this.Controls.Add(this.weatherDescription);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LocationTitle);
            this.Name = "Form1";
            this.Text = "WeatherApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LocationTitle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label weatherDescription;
        private System.Windows.Forms.Label weatherTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label temperatureMinMaxDisplay;
        private System.Windows.Forms.Label humidityValueDisplay;
        private System.Windows.Forms.Label visibilityValueDisplay;
        private System.Windows.Forms.Label windValueDisplay;
        private System.Windows.Forms.Label temperatureValueDisplay;
        private System.Windows.Forms.ListBox futureWeatherDayDisplay;
        private System.Windows.Forms.ListBox futureWeatherTempDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox futureWeatherHumidtyDisplay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox futureWeatherWindDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox futureWeatherVisibilityDisplay;
        private System.Windows.Forms.ListBox futureHourlyWeatherDisplay;
        private System.Windows.Forms.Label label9;
    }
}

