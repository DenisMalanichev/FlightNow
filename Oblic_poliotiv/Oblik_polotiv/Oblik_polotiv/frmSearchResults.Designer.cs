namespace Oblik_polotiv
{
    partial class frmSearchResults
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxSearchResults = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveFlights = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblSearchResults = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.frmFlightDetails = new Oblik_polotiv.frmFlightDetails();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstBoxSearchResults);
            this.panel1.Location = new System.Drawing.Point(16, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 299);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Duble click to open flight";
            // 
            // lstBoxSearchResults
            // 
            this.lstBoxSearchResults.BackColor = System.Drawing.Color.White;
            this.lstBoxSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxSearchResults.FormattingEnabled = true;
            this.lstBoxSearchResults.ItemHeight = 16;
            this.lstBoxSearchResults.Location = new System.Drawing.Point(22, 28);
            this.lstBoxSearchResults.Name = "lstBoxSearchResults";
            this.lstBoxSearchResults.Size = new System.Drawing.Size(743, 244);
            this.lstBoxSearchResults.TabIndex = 0;
            this.lstBoxSearchResults.DoubleClick += new System.EventHandler(this.lstBoxSearchResults_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 36);
            this.panel2.TabIndex = 1;
            // 
            // btnSaveFlights
            // 
            this.btnSaveFlights.Location = new System.Drawing.Point(704, 103);
            this.btnSaveFlights.Name = "btnSaveFlights";
            this.btnSaveFlights.Size = new System.Drawing.Size(77, 23);
            this.btnSaveFlights.TabIndex = 2;
            this.btnSaveFlights.Text = "Save flights";
            this.btnSaveFlights.UseVisualStyleBackColor = true;
            this.btnSaveFlights.Click += new System.EventHandler(this.btnSaveFlights_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.txt)|*.txt";
            // 
            // lblSearchResults
            // 
            this.lblSearchResults.AutoSize = true;
            this.lblSearchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResults.Location = new System.Drawing.Point(35, 113);
            this.lblSearchResults.Name = "lblSearchResults";
            this.lblSearchResults.Size = new System.Drawing.Size(202, 17);
            this.lblSearchResults.TabIndex = 2;
            this.lblSearchResults.Text = "We have found this flights:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(130, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "FlightNow";
            // 
            // frmFlightDetails
            // 
            this.frmFlightDetails.BackColor = System.Drawing.Color.White;
            this.frmFlightDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmFlightDetails.flight = null;
            this.frmFlightDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmFlightDetails.Location = new System.Drawing.Point(0, 0);
            this.frmFlightDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.frmFlightDetails.Name = "frmFlightDetails";
            this.frmFlightDetails.Size = new System.Drawing.Size(819, 444);
            this.frmFlightDetails.TabIndex = 3;
            this.frmFlightDetails.Visible = false;
            // 
            // frmSearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmFlightDetails);
            this.Controls.Add(this.lblSearchResults);
            this.Controls.Add(this.btnSaveFlights);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmSearchResults";
            this.Size = new System.Drawing.Size(819, 444);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstBoxSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaveFlights;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public frmFlightDetails frmFlightDetails;
        private System.Windows.Forms.Label lblSearchResults;
        private System.Windows.Forms.Label lblTitle;
    }
}
