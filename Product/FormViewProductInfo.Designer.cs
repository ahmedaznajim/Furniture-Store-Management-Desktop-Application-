namespace furnitureStoreV2.Product
{
    partial class FormViewProductInfo
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
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelPriceInJod = new System.Windows.Forms.Label();
            this.labelAvailabilty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(23, 413);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(97, 24);
            this.labelQuantity.TabIndex = 32;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(23, 328);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(147, 24);
            this.labelProductName.TabIndex = 31;
            this.labelProductName.Text = "ProductName";
            // 
            // labelPriceInJod
            // 
            this.labelPriceInJod.AutoSize = true;
            this.labelPriceInJod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceInJod.ForeColor = System.Drawing.Color.Red;
            this.labelPriceInJod.Location = new System.Drawing.Point(23, 354);
            this.labelPriceInJod.Name = "labelPriceInJod";
            this.labelPriceInJod.Size = new System.Drawing.Size(119, 24);
            this.labelPriceInJod.TabIndex = 28;
            this.labelPriceInJod.Text = "PriceInJod";
            // 
            // labelAvailabilty
            // 
            this.labelAvailabilty.AutoSize = true;
            this.labelAvailabilty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailabilty.Location = new System.Drawing.Point(23, 384);
            this.labelAvailabilty.Name = "labelAvailabilty";
            this.labelAvailabilty.Size = new System.Drawing.Size(117, 24);
            this.labelAvailabilty.TabIndex = 27;
            this.labelAvailabilty.Text = "Availabilty";
            this.labelAvailabilty.Click += new System.EventHandler(this.labelAvailabilty_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "ProductID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // FormViewProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 485);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelPriceInJod);
            this.Controls.Add(this.labelAvailabilty);
            this.Controls.Add(this.label1);
            this.Name = "FormViewProductInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelPriceInJod;
        private System.Windows.Forms.Label labelAvailabilty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}