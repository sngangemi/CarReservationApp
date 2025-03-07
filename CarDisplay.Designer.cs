namespace CarReservation
{
    partial class CarDisplay
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
            this.dateList = new System.Windows.Forms.ListBox();
            this.startMonthBox = new System.Windows.Forms.TextBox();
            this.startDayBox = new System.Windows.Forms.TextBox();
            this.startYearBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.endMonthBox = new System.Windows.Forms.TextBox();
            this.endDayBox = new System.Windows.Forms.TextBox();
            this.endYearBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.carReserveButton = new System.Windows.Forms.Button();
            this.deleteCarButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateList
            // 
            this.dateList.FormattingEnabled = true;
            this.dateList.ItemHeight = 16;
            this.dateList.Location = new System.Drawing.Point(1, 66);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(354, 372);
            this.dateList.TabIndex = 0;
            this.dateList.SelectedIndexChanged += new System.EventHandler(this.dateList_SelectedIndexChanged);
            // 
            // startMonthBox
            // 
            this.startMonthBox.Location = new System.Drawing.Point(488, 192);
            this.startMonthBox.Name = "startMonthBox";
            this.startMonthBox.Size = new System.Drawing.Size(32, 22);
            this.startMonthBox.TabIndex = 1;
            // 
            // startDayBox
            // 
            this.startDayBox.Location = new System.Drawing.Point(557, 192);
            this.startDayBox.Name = "startDayBox";
            this.startDayBox.Size = new System.Drawing.Size(38, 22);
            this.startDayBox.TabIndex = 2;
            // 
            // startYearBox
            // 
            this.startYearBox.Location = new System.Drawing.Point(631, 192);
            this.startYearBox.Name = "startYearBox";
            this.startYearBox.Size = new System.Drawing.Size(60, 22);
            this.startYearBox.TabIndex = 3;

            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.label1.Location = new System.Drawing.Point(485, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(554, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(628, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start Date:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "End Date: ";
            // 
            // endMonthBox
            // 
            this.endMonthBox.Location = new System.Drawing.Point(488, 274);
            this.endMonthBox.Name = "endMonthBox";
            this.endMonthBox.Size = new System.Drawing.Size(32, 22);
            this.endMonthBox.TabIndex = 9;
            // 
            // endDayBox
            // 
            this.endDayBox.Location = new System.Drawing.Point(557, 273);
            this.endDayBox.Name = "endDayBox";
            this.endDayBox.Size = new System.Drawing.Size(38, 22);
            this.endDayBox.TabIndex = 10;
            // 
            // endYearBox
            // 
            this.endYearBox.Location = new System.Drawing.Point(631, 274);
            this.endYearBox.Name = "endYearBox";
            this.endYearBox.Size = new System.Drawing.Size(60, 22);
            this.endYearBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(485, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Month";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(557, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Day";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(628, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Year";
            // 
            // carReserveButton
            // 
            this.carReserveButton.Location = new System.Drawing.Point(471, 348);
            this.carReserveButton.Name = "carReserveButton";
            this.carReserveButton.Size = new System.Drawing.Size(143, 69);
            this.carReserveButton.TabIndex = 15;
            this.carReserveButton.Text = "Create Car Reservation";
            this.carReserveButton.UseVisualStyleBackColor = true;
            this.carReserveButton.Click += new System.EventHandler(this.carReserveButton_Click);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.Location = new System.Drawing.Point(687, 371);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(101, 55);
            this.deleteCarButton.TabIndex = 16;
            this.deleteCarButton.Text = "Delete Car";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            this.deleteCarButton.Click += new System.EventHandler(this.deleteCarButton_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Click To Delete";
            // 
            // CarDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.carReserveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endYearBox);
            this.Controls.Add(this.endDayBox);
            this.Controls.Add(this.endMonthBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startYearBox);
            this.Controls.Add(this.startDayBox);
            this.Controls.Add(this.startMonthBox);
            this.Controls.Add(this.dateList);
            this.Name = "CarDisplay";
            this.Text = "CarDisplay";
            this.Load += new System.EventHandler(this.CarDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dateList;
        private System.Windows.Forms.TextBox startMonthBox;
        private System.Windows.Forms.TextBox startDayBox;
        private System.Windows.Forms.TextBox startYearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endMonthBox;
        private System.Windows.Forms.TextBox endDayBox;
        private System.Windows.Forms.TextBox endYearBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button carReserveButton;
        private System.Windows.Forms.Button deleteCarButton;
        private System.Windows.Forms.Label label9;
    }
}