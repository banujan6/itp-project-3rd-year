
namespace ITP_Project
{
    partial class add_working_hours_days_window
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
            this.label2 = new System.Windows.Forms.Label();
            this.number_of_working_days = new System.Windows.Forms.NumericUpDown();
            this.working_hours = new System.Windows.Forms.NumericUpDown();
            this.working_minutes = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.day_selector = new System.Windows.Forms.CheckedListBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.number_of_working_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.working_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.working_minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Working Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(385, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Working Hours Per Day";
            // 
            // number_of_working_days
            // 
            this.number_of_working_days.Location = new System.Drawing.Point(51, 73);
            this.number_of_working_days.Name = "number_of_working_days";
            this.number_of_working_days.Size = new System.Drawing.Size(254, 27);
            this.number_of_working_days.TabIndex = 2;
            // 
            // working_hours
            // 
            this.working_hours.Location = new System.Drawing.Point(385, 73);
            this.working_hours.Name = "working_hours";
            this.working_hours.Size = new System.Drawing.Size(55, 27);
            this.working_hours.TabIndex = 3;
            // 
            // working_minutes
            // 
            this.working_minutes.Location = new System.Drawing.Point(529, 73);
            this.working_minutes.Name = "working_minutes";
            this.working_minutes.Size = new System.Drawing.Size(55, 27);
            this.working_minutes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Working Days";
            // 
            // day_selector
            // 
            this.day_selector.FormattingEnabled = true;
            this.day_selector.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.day_selector.Location = new System.Drawing.Point(51, 198);
            this.day_selector.Name = "day_selector";
            this.day_selector.Size = new System.Drawing.Size(600, 158);
            this.day_selector.TabIndex = 8;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(557, 389);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 29);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(452, 389);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(94, 29);
            this.btn_reset.TabIndex = 10;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            // 
            // add_working_hours_days_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 453);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.day_selector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.working_minutes);
            this.Controls.Add(this.working_hours);
            this.Controls.Add(this.number_of_working_days);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "add_working_hours_days_window";
            this.Text = "Add Working Days & Hours";
            ((System.ComponentModel.ISupportInitialize)(this.number_of_working_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.working_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.working_minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown number_of_working_days;
        private System.Windows.Forms.NumericUpDown working_hours;
        private System.Windows.Forms.NumericUpDown working_minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox day_selector;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reset;
    }
}