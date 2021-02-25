namespace TestsInteractiveGUI
{
    partial class TestScoreAverage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterScoreBelowLabel = new System.Windows.Forms.Label();
            this.test1Label = new System.Windows.Forms.Label();
            this.test2Label = new System.Windows.Forms.Label();
            this.test3Label = new System.Windows.Forms.Label();
            this.test4Label = new System.Windows.Forms.Label();
            this.test5Label = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test4TextBox = new System.Windows.Forms.TextBox();
            this.test5TextBox = new System.Windows.Forms.TextBox();
            this.averageButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterScoreBelowLabel
            // 
            this.enterScoreBelowLabel.AutoSize = true;
            this.enterScoreBelowLabel.Location = new System.Drawing.Point(36, 24);
            this.enterScoreBelowLabel.Name = "enterScoreBelowLabel";
            this.enterScoreBelowLabel.Size = new System.Drawing.Size(144, 20);
            this.enterScoreBelowLabel.TabIndex = 0;
            this.enterScoreBelowLabel.Text = "Enter scores below";
            // 
            // test1Label
            // 
            this.test1Label.AutoSize = true;
            this.test1Label.Location = new System.Drawing.Point(36, 76);
            this.test1Label.Name = "test1Label";
            this.test1Label.Size = new System.Drawing.Size(57, 20);
            this.test1Label.TabIndex = 1;
            this.test1Label.Text = "Test 1:";
            // 
            // test2Label
            // 
            this.test2Label.AutoSize = true;
            this.test2Label.Location = new System.Drawing.Point(36, 119);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(57, 20);
            this.test2Label.TabIndex = 2;
            this.test2Label.Text = "Test 2:";
            // 
            // test3Label
            // 
            this.test3Label.AutoSize = true;
            this.test3Label.Location = new System.Drawing.Point(36, 165);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(57, 20);
            this.test3Label.TabIndex = 3;
            this.test3Label.Text = "Test 3:";
            // 
            // test4Label
            // 
            this.test4Label.AutoSize = true;
            this.test4Label.Location = new System.Drawing.Point(36, 206);
            this.test4Label.Name = "test4Label";
            this.test4Label.Size = new System.Drawing.Size(57, 20);
            this.test4Label.TabIndex = 4;
            this.test4Label.Text = "Test 4:";
            // 
            // test5Label
            // 
            this.test5Label.AutoSize = true;
            this.test5Label.Location = new System.Drawing.Point(36, 250);
            this.test5Label.Name = "test5Label";
            this.test5Label.Size = new System.Drawing.Size(57, 20);
            this.test5Label.TabIndex = 5;
            this.test5Label.Text = "Test 5:";
            // 
            // test1TextBox
            // 
            this.test1TextBox.HideSelection = false;
            this.test1TextBox.Location = new System.Drawing.Point(100, 69);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(100, 26);
            this.test1TextBox.TabIndex = 6;
            // 
            // test2TextBox
            // 
            this.test2TextBox.HideSelection = false;
            this.test2TextBox.Location = new System.Drawing.Point(100, 113);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(100, 26);
            this.test2TextBox.TabIndex = 8;
            // 
            // test3TextBox
            // 
            this.test3TextBox.HideSelection = false;
            this.test3TextBox.Location = new System.Drawing.Point(100, 159);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(100, 26);
            this.test3TextBox.TabIndex = 9;
            // 
            // test4TextBox
            // 
            this.test4TextBox.HideSelection = false;
            this.test4TextBox.Location = new System.Drawing.Point(99, 200);
            this.test4TextBox.Name = "test4TextBox";
            this.test4TextBox.Size = new System.Drawing.Size(100, 26);
            this.test4TextBox.TabIndex = 10;
            // 
            // test5TextBox
            // 
            this.test5TextBox.HideSelection = false;
            this.test5TextBox.Location = new System.Drawing.Point(99, 244);
            this.test5TextBox.Name = "test5TextBox";
            this.test5TextBox.Size = new System.Drawing.Size(100, 26);
            this.test5TextBox.TabIndex = 11;
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(40, 309);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(160, 37);
            this.averageButton.TabIndex = 12;
            this.averageButton.Text = "Click to Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.AverageButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(230, 317);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(0, 20);
            this.averageLabel.TabIndex = 13;
            // 
            // TestScoreAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.test5TextBox);
            this.Controls.Add(this.test4TextBox);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.test5Label);
            this.Controls.Add(this.test4Label);
            this.Controls.Add(this.test3Label);
            this.Controls.Add(this.test2Label);
            this.Controls.Add(this.test1Label);
            this.Controls.Add(this.enterScoreBelowLabel);
            this.Name = "TestScoreAverage";
            this.Text = "Test Score Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterScoreBelowLabel;
        private System.Windows.Forms.Label test1Label;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.Label test4Label;
        private System.Windows.Forms.Label test5Label;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test4TextBox;
        private System.Windows.Forms.TextBox test5TextBox;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Label averageLabel;
    }
}

