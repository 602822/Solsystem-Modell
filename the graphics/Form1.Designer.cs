namespace the_graphics
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
            planetComboBox = new ComboBox();
            sunLabel = new Label();
            earthLabel = new Label();
            marsLabel = new Label();
            mercuryLabel = new Label();
            venusLabel = new Label();
            jupiterLabel = new Label();
            saturnLabel = new Label();
            uranusLabel = new Label();
            neptuneLabel = new Label();
            planetlabelCheckBox = new CheckBox();
            orbitCheckBox = new CheckBox();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            currentSpeedLabel = new Label();
            SuspendLayout();
            // 
            // planetComboBox
            // 
            planetComboBox.FormattingEnabled = true;
            planetComboBox.Items.AddRange(new object[] { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" });
            planetComboBox.Location = new Point(12, 40);
            planetComboBox.Name = "planetComboBox";
            planetComboBox.Size = new Size(196, 33);
            planetComboBox.TabIndex = 0;
            planetComboBox.SelectedIndexChanged += planetComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            sunLabel.AutoSize = true;
            sunLabel.Location = new Point(70, 416);
            sunLabel.Name = "label1";
            sunLabel.Size = new Size(75, 25);
            sunLabel.TabIndex = 1;
            sunLabel.Text = "The Sun";
            // 
            // label2
            // 
            earthLabel.AutoSize = true;
            earthLabel.Location = new Point(12, 416);
            earthLabel.Name = "label2";
            earthLabel.Size = new Size(52, 25);
            earthLabel.TabIndex = 2;
            earthLabel.Text = "Earth";
            // 
            // label3
            // 
            marsLabel.AutoSize = true;
            marsLabel.Location = new Point(356, 416);
            marsLabel.Name = "label3";
            marsLabel.Size = new Size(51, 25);
            marsLabel.TabIndex = 3;
            marsLabel.Text = "Mars";
            // 
            // label4
            // 
            mercuryLabel.AutoSize = true;
            mercuryLabel.Location = new Point(483, 416);
            mercuryLabel.Name = "label4";
            mercuryLabel.Size = new Size(76, 25);
            mercuryLabel.TabIndex = 4;
            mercuryLabel.Text = "Mercury";
            // 
            // label5
            // 
            venusLabel.AutoSize = true;
            venusLabel.Location = new Point(149, 416);
            venusLabel.Name = "label5";
            venusLabel.Size = new Size(59, 25);
            venusLabel.TabIndex = 5;
            venusLabel.Text = "Venus";
            // 
            // label6
            // 
            jupiterLabel.AutoSize = true;
            jupiterLabel.Location = new Point(413, 416);
            jupiterLabel.Name = "label6";
            jupiterLabel.Size = new Size(64, 25);
            jupiterLabel.TabIndex = 6;
            jupiterLabel.Text = "Jupiter";
            // 
            // label7
            // 
            saturnLabel.AutoSize = true;
            saturnLabel.Location = new Point(287, 416);
            saturnLabel.Name = "label7";
            saturnLabel.Size = new Size(63, 25);
            saturnLabel.TabIndex = 7;
            saturnLabel.Text = "Saturn";
            // 
            // label8
            // 
            uranusLabel.AutoSize = true;
            uranusLabel.Location = new Point(214, 416);
            uranusLabel.Name = "label8";
            uranusLabel.Size = new Size(67, 25);
            uranusLabel.TabIndex = 8;
            uranusLabel.Text = "Uranus";
           
            // 
            // label9
            // 
            neptuneLabel.AutoSize = true;
            neptuneLabel.Location = new Point(565, 416);
            neptuneLabel.Name = "label9";
            neptuneLabel.Size = new Size(80, 25);
            neptuneLabel.TabIndex = 9;
            neptuneLabel.Text = "Neptune";
            // 
            // planetlabelCheckBox
            // 
            planetlabelCheckBox.AutoSize = true;
            planetlabelCheckBox.Location = new Point(227, 44);
            planetlabelCheckBox.Name = "planetlabelCheckBox";
            planetlabelCheckBox.Size = new Size(122, 29);
            planetlabelCheckBox.TabIndex = 10;
            planetlabelCheckBox.Text = "Text Labels";
            planetlabelCheckBox.UseVisualStyleBackColor = true;
            planetlabelCheckBox.CheckedChanged += planetlabelCheckBox_CheckedChanged;
            // 
            // orbitCheckBox
            // 
            orbitCheckBox.AutoSize = true;
            orbitCheckBox.Location = new Point(355, 44);
            orbitCheckBox.Name = "orbitCheckBox";
            orbitCheckBox.Size = new Size(164, 29);
            orbitCheckBox.TabIndex = 11;
            orbitCheckBox.Text = "Planetary Orbits";
            orbitCheckBox.UseVisualStyleBackColor = true;
            orbitCheckBox.CheckedChanged += orbitCheckBox_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 9);
            label10.Name = "label10";
            label10.Size = new Size(301, 25);
            label10.TabIndex = 12;
            label10.Text = "Zoom in 10% for the Selected Planet";
            // 
            // button1
            // 
            button1.Location = new Point(12, 79);
            button1.Name = "button1";
            button1.Size = new Size(196, 34);
            button1.TabIndex = 13;
            button1.Text = "Reset Zoom";
            button1.UseVisualStyleBackColor = true;
            button1.Click += resetZoomButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(227, 79);
            button2.Name = "button2";
            button2.Size = new Size(153, 34);
            button2.TabIndex = 14;
            button2.Text = "Decrease Speed";
            button2.UseVisualStyleBackColor = true;
            button2.Click += decreaseSpeedButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(386, 79);
            button3.Name = "button3";
            button3.Size = new Size(175, 34);
            button3.TabIndex = 15;
            button3.Text = "Increase Speed";
            button3.UseVisualStyleBackColor = true;
            button3.Click += increaseSpeedButton_Click;
            // 
            // currentSpeedLabel
            // 
            currentSpeedLabel.AutoSize = true;
            currentSpeedLabel.Location = new Point(17, 128);
            currentSpeedLabel.Name = "currentSpeedLabel";
            currentSpeedLabel.Size = new Size(0, 25);
            currentSpeedLabel.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentSpeedLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(orbitCheckBox);
            Controls.Add(planetlabelCheckBox);
            Controls.Add(neptuneLabel);
            Controls.Add(uranusLabel);
            Controls.Add(saturnLabel);
            Controls.Add(jupiterLabel);
            Controls.Add(venusLabel);
            Controls.Add(mercuryLabel);
            Controls.Add(marsLabel);
            Controls.Add(earthLabel);
            Controls.Add(sunLabel);
            Controls.Add(planetComboBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox planetComboBox;
        private Label sunLabel;
        private Label earthLabel;
        private Label marsLabel;
        private Label mercuryLabel;
        private Label venusLabel;
        private Label jupiterLabel;
        private Label saturnLabel;
        private Label uranusLabel;
        private Label neptuneLabel;
        private CheckBox planetlabelCheckBox;
        private CheckBox orbitCheckBox;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label currentSpeedLabel;
    }
}