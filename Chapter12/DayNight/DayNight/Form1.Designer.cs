namespace DayNight
{
    partial class DayNightForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.DayButton = new System.Windows.Forms.Button();
            this.NightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click a button";
            // 
            // DayButton
            // 
            this.DayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayButton.Location = new System.Drawing.Point(180, 209);
            this.DayButton.Name = "DayButton";
            this.DayButton.Size = new System.Drawing.Size(135, 68);
            this.DayButton.TabIndex = 1;
            this.DayButton.Text = "Day";
            this.DayButton.UseVisualStyleBackColor = true;
            this.DayButton.Click += new System.EventHandler(this.DayButton_Click);
            // 
            // NightButton
            // 
            this.NightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NightButton.Location = new System.Drawing.Point(506, 209);
            this.NightButton.Name = "NightButton";
            this.NightButton.Size = new System.Drawing.Size(132, 68);
            this.NightButton.TabIndex = 2;
            this.NightButton.Text = "Night";
            this.NightButton.UseVisualStyleBackColor = true;
            this.NightButton.Click += new System.EventHandler(this.NightButton_Click);
            // 
            // DayNightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NightButton);
            this.Controls.Add(this.DayButton);
            this.Controls.Add(this.label1);
            this.Name = "DayNightForm";
            this.Text = "DayNightForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DayButton;
        private System.Windows.Forms.Button NightButton;
    }
}

