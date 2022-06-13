namespace Oblik_polotiv
{
    partial class frmFlightDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFlightDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightRoute = new System.Windows.Forms.Label();
            this.btnfSearchResBack = new System.Windows.Forms.Button();
            this.btnSaveFlight = new System.Windows.Forms.Button();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblRoute = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.picBoxPath = new System.Windows.Forms.PictureBox();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrive = new System.Windows.Forms.Label();
            this.lblFliTime = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPath)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.flightRoute);
            this.panel1.Controls.Add(this.btnfSearchResBack);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 36);
            this.panel1.TabIndex = 0;
            // 
            // flightRoute
            // 
            this.flightRoute.AutoSize = true;
            this.flightRoute.BackColor = System.Drawing.Color.White;
            this.flightRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightRoute.Location = new System.Drawing.Point(292, 8);
            this.flightRoute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.flightRoute.Name = "flightRoute";
            this.flightRoute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flightRoute.Size = new System.Drawing.Size(98, 20);
            this.flightRoute.TabIndex = 21;
            this.flightRoute.Text = "flightRoute";
            // 
            // btnfSearchResBack
            // 
            this.btnfSearchResBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfSearchResBack.Location = new System.Drawing.Point(0, 0);
            this.btnfSearchResBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnfSearchResBack.Name = "btnfSearchResBack";
            this.btnfSearchResBack.Size = new System.Drawing.Size(48, 37);
            this.btnfSearchResBack.TabIndex = 20;
            this.btnfSearchResBack.Text = "←";
            this.btnfSearchResBack.UseVisualStyleBackColor = true;
            this.btnfSearchResBack.Visible = false;
            // 
            // btnSaveFlight
            // 
            this.btnSaveFlight.Location = new System.Drawing.Point(703, 375);
            this.btnSaveFlight.Name = "btnSaveFlight";
            this.btnSaveFlight.Size = new System.Drawing.Size(75, 40);
            this.btnSaveFlight.TabIndex = 1;
            this.btnSaveFlight.Text = "Save flight info";
            this.btnSaveFlight.UseVisualStyleBackColor = true;
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(12, 73);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(58, 17);
            this.lblCarrier.TabIndex = 2;
            this.lblCarrier.Text = "Carrier";
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(12, 108);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(51, 17);
            this.lblRoute.TabIndex = 3;
            this.lblRoute.Text = "Route";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPrice.Location = new System.Drawing.Point(12, 375);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(71, 24);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "From: ";
            // 
            // picBoxPath
            // 
            this.picBoxPath.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPath.Image")));
            this.picBoxPath.Location = new System.Drawing.Point(461, 202);
            this.picBoxPath.Name = "picBoxPath";
            this.picBoxPath.Size = new System.Drawing.Size(317, 50);
            this.picBoxPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPath.TabIndex = 5;
            this.picBoxPath.TabStop = false;
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDepart.Location = new System.Drawing.Point(458, 255);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(57, 17);
            this.lblDepart.TabIndex = 6;
            this.lblDepart.Text = "Depart";
            // 
            // lblArrive
            // 
            this.lblArrive.AutoSize = true;
            this.lblArrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrive.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblArrive.Location = new System.Drawing.Point(727, 255);
            this.lblArrive.Name = "lblArrive";
            this.lblArrive.Size = new System.Drawing.Size(51, 17);
            this.lblArrive.TabIndex = 7;
            this.lblArrive.Text = "Arrive";
            // 
            // lblFliTime
            // 
            this.lblFliTime.AutoSize = true;
            this.lblFliTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFliTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFliTime.Location = new System.Drawing.Point(586, 182);
            this.lblFliTime.Name = "lblFliTime";
            this.lblFliTime.Size = new System.Drawing.Size(64, 17);
            this.lblFliTime.TabIndex = 8;
            this.lblFliTime.Text = "FlyTime";
            // 
            // frmFlightDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFliTime);
            this.Controls.Add(this.lblArrive);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.picBoxPath);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblRoute);
            this.Controls.Add(this.lblCarrier);
            this.Controls.Add(this.btnSaveFlight);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmFlightDetails";
            this.Size = new System.Drawing.Size(835, 490);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfSearchResBack;
        private System.Windows.Forms.Label flightRoute;
        private System.Windows.Forms.Button btnSaveFlight;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picBoxPath;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrive;
        private System.Windows.Forms.Label lblFliTime;
    }
}
