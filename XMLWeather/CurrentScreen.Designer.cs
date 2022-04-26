﻿namespace XMLWeather
{
    partial class CurrentScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contitionLabel = new System.Windows.Forms.Label();
            this.weatherIconBox = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(0, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(250, 49);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(204, 66);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(65, 21);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "Max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(205, 94);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(45, 21);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "Min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(11, 54);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(250, 82);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "1738";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(22, 354);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(92, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Forcast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 49);
            this.label1.TabIndex = 44;
            this.label1.Text = "--------------------------";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contitionLabel
            // 
            this.contitionLabel.BackColor = System.Drawing.Color.Transparent;
            this.contitionLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contitionLabel.ForeColor = System.Drawing.Color.White;
            this.contitionLabel.Location = new System.Drawing.Point(0, 136);
            this.contitionLabel.Name = "contitionLabel";
            this.contitionLabel.Size = new System.Drawing.Size(250, 49);
            this.contitionLabel.TabIndex = 45;
            this.contitionLabel.Text = "Condition";
            this.contitionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherIconBox
            // 
            this.weatherIconBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherIconBox.InitialImage = null;
            this.weatherIconBox.Location = new System.Drawing.Point(61, 220);
            this.weatherIconBox.Name = "weatherIconBox";
            this.weatherIconBox.Size = new System.Drawing.Size(132, 126);
            this.weatherIconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIconBox.TabIndex = 46;
            this.weatherIconBox.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(1, 38);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(250, 26);
            this.dateLabel.TabIndex = 47;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Berlin Sans FB Demi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(164, 354);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 28);
            this.searchLabel.TabIndex = 99;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.weatherIconBox);
            this.Controls.Add(this.contitionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label contitionLabel;
        private System.Windows.Forms.PictureBox weatherIconBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label searchLabel;
    }
}
