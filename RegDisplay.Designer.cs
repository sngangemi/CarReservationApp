namespace CarReservation
{
    partial class RegDisplay
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
            this.CarList = new System.Windows.Forms.ListBox();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.plateBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LiscenseBox = new System.Windows.Forms.Label();
            this.newCarButton = new System.Windows.Forms.Button();
            this.registryDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.ItemHeight = 16;
            this.CarList.Location = new System.Drawing.Point(12, 3);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(159, 420);
            this.CarList.TabIndex = 0;
            this.CarList.SelectedIndexChanged += new System.EventHandler(this.CarList_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(465, 213);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(33, 22);
            this.typeBox.TabIndex = 1;
            // 
            // plateBox
            // 
            this.plateBox.Location = new System.Drawing.Point(577, 213);
            this.plateBox.Name = "plateBox";
            this.plateBox.Size = new System.Drawing.Size(100, 22);
            this.plateBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(451, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "0: Sedan      1: SUV      2: Van";

            // 
            // LiscenseBox
            // 
            this.LiscenseBox.Location = new System.Drawing.Point(574, 179);
            this.LiscenseBox.Name = "LiscenseBox";
            this.LiscenseBox.Size = new System.Drawing.Size(98, 16);
            this.LiscenseBox.TabIndex = 4;
            this.LiscenseBox.Text = "LicensePlate";
            // 
            // newCarButton
            // 
            this.newCarButton.Location = new System.Drawing.Point(474, 256);
            this.newCarButton.Name = "newCarButton";
            this.newCarButton.Size = new System.Drawing.Size(128, 67);
            this.newCarButton.TabIndex = 5;
            this.newCarButton.Text = "Create New Car";
            this.newCarButton.UseVisualStyleBackColor = true;
            this.newCarButton.Click += new System.EventHandler(this.newCarButton_Click);
            // 
            // registryDeleteButton
            // 
            this.registryDeleteButton.Location = new System.Drawing.Point(678, 376);
            this.registryDeleteButton.Name = "registryDeleteButton";
            this.registryDeleteButton.Size = new System.Drawing.Size(96, 54);
            this.registryDeleteButton.TabIndex = 6;
            this.registryDeleteButton.Text = "Delete Registry";
            this.registryDeleteButton.UseVisualStyleBackColor = true;
            this.registryDeleteButton.Click += new System.EventHandler(this.registryDeleteButton_Click);
            // 
            // RegDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 434);
            this.Controls.Add(this.registryDeleteButton);
            this.Controls.Add(this.newCarButton);
            this.Controls.Add(this.LiscenseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plateBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.CarList);
            this.Name = "RegDisplay";
            this.Text = "RegDisplay";
            this.Load += new System.EventHandler(this.RegDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox plateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LiscenseBox;
        private System.Windows.Forms.Button newCarButton;
        private System.Windows.Forms.Button registryDeleteButton;
    }
}