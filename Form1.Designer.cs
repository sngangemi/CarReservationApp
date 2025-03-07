namespace CarReservation
{
    partial class Home
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
            this.RegistryList = new System.Windows.Forms.ListBox();
            this.registryNameInput = new System.Windows.Forms.TextBox();
            this.registryNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistryList
            // 
            this.RegistryList.FormattingEnabled = true;
            this.RegistryList.ItemHeight = 16;
            this.RegistryList.Location = new System.Drawing.Point(0, 0);
            this.RegistryList.Name = "RegistryList";
            this.RegistryList.Size = new System.Drawing.Size(168, 404);
            this.RegistryList.TabIndex = 0;
            this.RegistryList.SelectedIndexChanged += new System.EventHandler(this.RegistryList_SelectedIndexChanged);
            // 
            // registryNameInput
            // 
            this.registryNameInput.Location = new System.Drawing.Point(490, 128);
            this.registryNameInput.Name = "registryNameInput";
            this.registryNameInput.Size = new System.Drawing.Size(100, 22);
            this.registryNameInput.TabIndex = 1;
            // 
            // registryNameButton
            // 
            this.registryNameButton.Location = new System.Drawing.Point(596, 114);
            this.registryNameButton.Name = "registryNameButton";
            this.registryNameButton.Size = new System.Drawing.Size(96, 50);
            this.registryNameButton.TabIndex = 2;
            this.registryNameButton.Text = "Create New Registry";
            this.registryNameButton.UseVisualStyleBackColor = true;
            this.registryNameButton.Click += new System.EventHandler(this.registryNameButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registryNameButton);
            this.Controls.Add(this.registryNameInput);
            this.Controls.Add(this.RegistryList);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "Home";
            this.Text = "Registry Creator/Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RegistryList;
        private System.Windows.Forms.TextBox registryNameInput;
        private System.Windows.Forms.Button registryNameButton;
    }
}

