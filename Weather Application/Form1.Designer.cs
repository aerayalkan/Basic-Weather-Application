namespace Weather_Application
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
            label1 = new Label();
            TBCity = new TextBox();
            btnSearch = new Button();
            labCondition = new Label();
            labDetails = new Label();
            label3 = new Label();
            labSunrise = new Label();
            labSunset = new Label();
            label5 = new Label();
            labPressure = new Label();
            label4 = new Label();
            labWindSpeed = new Label();
            label7 = new Label();
            picIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(78, 71);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 0;
            label1.Text = "City:";
            // 
            // TBCity
            // 
            TBCity.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TBCity.Location = new Point(130, 69);
            TBCity.Name = "TBCity";
            TBCity.Size = new Size(188, 31);
            TBCity.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.Location = new Point(324, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // labCondition
            // 
            labCondition.AutoSize = true;
            labCondition.BackColor = Color.Transparent;
            labCondition.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labCondition.ForeColor = SystemColors.ButtonHighlight;
            labCondition.Location = new Point(78, 228);
            labCondition.Name = "labCondition";
            labCondition.Size = new Size(86, 23);
            labCondition.TabIndex = 3;
            labCondition.Text = "Condition";
            // 
            // labDetails
            // 
            labDetails.AutoSize = true;
            labDetails.BackColor = Color.Transparent;
            labDetails.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labDetails.ForeColor = SystemColors.ButtonHighlight;
            labDetails.Location = new Point(78, 263);
            labDetails.Name = "labDetails";
            labDetails.Size = new Size(66, 23);
            labDetails.TabIndex = 4;
            labDetails.Text = "Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(78, 293);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 5;
            label3.Text = "Sunrise:";
            label3.Click += label3_Click;
            // 
            // labSunrise
            // 
            labSunrise.AutoSize = true;
            labSunrise.BackColor = Color.Transparent;
            labSunrise.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labSunrise.ForeColor = SystemColors.ButtonHighlight;
            labSunrise.Location = new Point(148, 293);
            labSunrise.Name = "labSunrise";
            labSunrise.Size = new Size(42, 23);
            labSunrise.TabIndex = 6;
            labSunrise.Text = "N/A";
            labSunrise.Click += label4_Click;
            // 
            // labSunset
            // 
            labSunset.AutoSize = true;
            labSunset.BackColor = Color.Transparent;
            labSunset.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labSunset.ForeColor = SystemColors.ButtonHighlight;
            labSunset.Location = new Point(148, 326);
            labSunset.Name = "labSunset";
            labSunset.Size = new Size(42, 23);
            labSunset.TabIndex = 8;
            labSunset.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(78, 326);
            label5.Name = "label5";
            label5.Size = new Size(69, 23);
            label5.TabIndex = 7;
            label5.Text = "Sunset:";
            // 
            // labPressure
            // 
            labPressure.AutoSize = true;
            labPressure.BackColor = Color.Transparent;
            labPressure.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labPressure.ForeColor = SystemColors.ButtonHighlight;
            labPressure.Location = new Point(535, 263);
            labPressure.Name = "labPressure";
            labPressure.Size = new Size(42, 23);
            labPressure.TabIndex = 12;
            labPressure.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(428, 263);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 11;
            label4.Text = "Pressure:";
            // 
            // labWindSpeed
            // 
            labWindSpeed.AutoSize = true;
            labWindSpeed.BackColor = Color.Transparent;
            labWindSpeed.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labWindSpeed.ForeColor = SystemColors.ButtonHighlight;
            labWindSpeed.Location = new Point(535, 228);
            labWindSpeed.Name = "labWindSpeed";
            labWindSpeed.Size = new Size(42, 23);
            labWindSpeed.TabIndex = 10;
            labWindSpeed.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(428, 228);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 9;
            label7.Text = "Wind Speed:";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.Transparent;
            picIcon.Location = new Point(78, 132);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(112, 81);
            picIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picIcon.TabIndex = 13;
            picIcon.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(839, 499);
            Controls.Add(picIcon);
            Controls.Add(labPressure);
            Controls.Add(label4);
            Controls.Add(labWindSpeed);
            Controls.Add(label7);
            Controls.Add(labSunset);
            Controls.Add(label5);
            Controls.Add(labSunrise);
            Controls.Add(label3);
            Controls.Add(labDetails);
            Controls.Add(labCondition);
            Controls.Add(btnSearch);
            Controls.Add(TBCity);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBCity;
        private Button btnSearch;
        private Label labCondition;
        private Label labDetails;
        private Label label3;
        private Label labSunrise;
        private Label labSunset;
        private Label label5;
        private Label labPressure;
        private Label label4;
        private Label labWindSpeed;
        private Label label7;
        private PictureBox picIcon;
    }
}
