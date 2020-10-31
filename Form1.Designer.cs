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
            this.timeFilterTitle = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.temperatureDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // LocationTitle
            // 
            this.LocationTitle.AccessibleName = "";
            this.LocationTitle.AutoSize = true;
            this.LocationTitle.Font = new System.Drawing.Font("Segoe UI", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationTitle.Location = new System.Drawing.Point(12, 19);
            this.LocationTitle.Name = "LocationTitle";
            this.LocationTitle.Size = new System.Drawing.Size(109, 35);
            this.LocationTitle.TabIndex = 1;
            this.LocationTitle.Text = "Lokacija";
            this.LocationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocationTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(368, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 25);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // timeFilterTitle
            // 
            this.timeFilterTitle.AutoSize = true;
            this.timeFilterTitle.Location = new System.Drawing.Point(17, 60);
            this.timeFilterTitle.Name = "timeFilterTitle";
            this.timeFilterTitle.Size = new System.Drawing.Size(43, 17);
            this.timeFilterTitle.TabIndex = 3;
            this.timeFilterTitle.Text = "label1";
            // 
            // weatherIcon
            // 
            this.weatherIcon.Image = ((System.Drawing.Image)(resources.GetObject("weatherIcon.Image")));
            this.weatherIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("weatherIcon.InitialImage")));
            this.weatherIcon.Location = new System.Drawing.Point(147, 19);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(80, 80);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherIcon.TabIndex = 4;
            this.weatherIcon.TabStop = false;
            // 
            // temperatureDisplay
            // 
            this.temperatureDisplay.AutoSize = true;
            this.temperatureDisplay.Location = new System.Drawing.Point(247, 47);
            this.temperatureDisplay.Name = "temperatureDisplay";
            this.temperatureDisplay.Size = new System.Drawing.Size(82, 17);
            this.temperatureDisplay.TabIndex = 5;
            this.temperatureDisplay.Text = "Temperatura";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.temperatureDisplay);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.timeFilterTitle);
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
        private System.Windows.Forms.Label timeFilterTitle;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label temperatureDisplay;
    }
}

