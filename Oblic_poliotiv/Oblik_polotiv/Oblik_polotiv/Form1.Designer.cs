namespace Oblik_polotiv
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.MainLable = new System.Windows.Forms.Label();
            this.SearchFilter = new System.Windows.Forms.ComboBox();
            this.SortByLable = new System.Windows.Forms.Label();
            this.FromLable = new System.Windows.Forms.Label();
            this.ToLable = new System.Windows.Forms.Label();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.DepartLable = new System.Windows.Forms.Label();
            this.ClassLable = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.FlisghtSettingsPannel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ResentlyWatchedLst = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchFlightsBtn = new System.Windows.Forms.Button();
            this.DepartBox = new System.Windows.Forms.MaskedTextBox();
            this.FromBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DepartBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ReturnBoxErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnfSearchResBack = new System.Windows.Forms.Button();
            this.frmSearchResults = new Oblik_polotiv.frmSearchResults();
            this.FlisghtSettingsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromBoxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToBoxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartBoxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBoxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLable
            // 
            this.MainLable.AutoSize = true;
            this.MainLable.BackColor = System.Drawing.Color.White;
            this.MainLable.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainLable.Font = new System.Drawing.Font("Yu Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MainLable.Location = new System.Drawing.Point(13, 13);
            this.MainLable.Name = "MainLable";
            this.MainLable.Size = new System.Drawing.Size(106, 25);
            this.MainLable.TabIndex = 0;
            this.MainLable.Text = "FlightNow";
            // 
            // SearchFilter
            // 
            this.SearchFilter.AccessibleName = "Test";
            this.SearchFilter.FormatString = "d";
            this.SearchFilter.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SearchFilter.Location = new System.Drawing.Point(647, 16);
            this.SearchFilter.Name = "SearchFilter";
            this.SearchFilter.Size = new System.Drawing.Size(150, 21);
            this.SearchFilter.TabIndex = 1;
            this.SearchFilter.SelectedIndexChanged += new System.EventHandler(this.SearchFilter_SelectedIndexChanged);
            // 
            // SortByLable
            // 
            this.SortByLable.AutoSize = true;
            this.SortByLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByLable.Location = new System.Drawing.Point(573, 18);
            this.SortByLable.Name = "SortByLable";
            this.SortByLable.Size = new System.Drawing.Size(68, 20);
            this.SortByLable.TabIndex = 2;
            this.SortByLable.Text = "Sort by -";
            // 
            // FromLable
            // 
            this.FromLable.AutoSize = true;
            this.FromLable.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLable.Location = new System.Drawing.Point(29, 13);
            this.FromLable.Name = "FromLable";
            this.FromLable.Size = new System.Drawing.Size(80, 23);
            this.FromLable.TabIndex = 3;
            this.FromLable.Text = "From:";
            // 
            // ToLable
            // 
            this.ToLable.AutoSize = true;
            this.ToLable.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLable.Location = new System.Drawing.Point(170, 13);
            this.ToLable.Name = "ToLable";
            this.ToLable.Size = new System.Drawing.Size(52, 23);
            this.ToLable.TabIndex = 4;
            this.ToLable.Text = "To:";
            // 
            // FromBox
            // 
            this.FromBox.Location = new System.Drawing.Point(33, 59);
            this.FromBox.Name = "FromBox";
            this.FromBox.Size = new System.Drawing.Size(100, 20);
            this.FromBox.TabIndex = 5;
            // 
            // ToBox
            // 
            this.ToBox.Location = new System.Drawing.Point(174, 58);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(100, 20);
            this.ToBox.TabIndex = 6;
            // 
            // DepartLable
            // 
            this.DepartLable.AutoSize = true;
            this.DepartLable.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartLable.Location = new System.Drawing.Point(314, 13);
            this.DepartLable.Name = "DepartLable";
            this.DepartLable.Size = new System.Drawing.Size(108, 23);
            this.DepartLable.TabIndex = 7;
            this.DepartLable.Text = "Depart:";
            // 
            // ClassLable
            // 
            this.ClassLable.AutoSize = true;
            this.ClassLable.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassLable.Location = new System.Drawing.Point(617, 13);
            this.ClassLable.Name = "ClassLable";
            this.ClassLable.Size = new System.Drawing.Size(94, 23);
            this.ClassLable.TabIndex = 11;
            this.ClassLable.Text = "Class:";
            // 
            // ClassBox
            // 
            this.ClassBox.BackColor = System.Drawing.Color.White;
            this.ClassBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(621, 58);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(87, 21);
            this.ClassBox.TabIndex = 13;
            // 
            // FlisghtSettingsPannel
            // 
            this.FlisghtSettingsPannel.BackColor = System.Drawing.Color.SkyBlue;
            this.FlisghtSettingsPannel.Controls.Add(this.label2);
            this.FlisghtSettingsPannel.Controls.Add(this.ResentlyWatchedLst);
            this.FlisghtSettingsPannel.Controls.Add(this.label1);
            this.FlisghtSettingsPannel.Controls.Add(this.SearchFlightsBtn);
            this.FlisghtSettingsPannel.Controls.Add(this.DepartBox);
            this.FlisghtSettingsPannel.Controls.Add(this.ClassBox);
            this.FlisghtSettingsPannel.Controls.Add(this.ClassLable);
            this.FlisghtSettingsPannel.Controls.Add(this.DepartLable);
            this.FlisghtSettingsPannel.Controls.Add(this.ToBox);
            this.FlisghtSettingsPannel.Controls.Add(this.FromBox);
            this.FlisghtSettingsPannel.Controls.Add(this.ToLable);
            this.FlisghtSettingsPannel.Controls.Add(this.FromLable);
            this.FlisghtSettingsPannel.Location = new System.Drawing.Point(18, 95);
            this.FlisghtSettingsPannel.Name = "FlisghtSettingsPannel";
            this.FlisghtSettingsPannel.Size = new System.Drawing.Size(779, 331);
            this.FlisghtSettingsPannel.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "*Duble click to open flight";
            // 
            // ResentlyWatchedLst
            // 
            this.ResentlyWatchedLst.FormattingEnabled = true;
            this.ResentlyWatchedLst.Location = new System.Drawing.Point(33, 126);
            this.ResentlyWatchedLst.Name = "ResentlyWatchedLst";
            this.ResentlyWatchedLst.Size = new System.Drawing.Size(537, 173);
            this.ResentlyWatchedLst.TabIndex = 19;
            this.ResentlyWatchedLst.DoubleClick += new System.EventHandler(this.ResentlyWatchedLst_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Recently watched:";
            // 
            // SearchFlightsBtn
            // 
            this.SearchFlightsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchFlightsBtn.Location = new System.Drawing.Point(599, 188);
            this.SearchFlightsBtn.Name = "SearchFlightsBtn";
            this.SearchFlightsBtn.Size = new System.Drawing.Size(137, 30);
            this.SearchFlightsBtn.TabIndex = 16;
            this.SearchFlightsBtn.Text = "Search flights →";
            this.SearchFlightsBtn.UseVisualStyleBackColor = true;
            this.SearchFlightsBtn.Click += new System.EventHandler(this.SearchFlightsBtn_Click);
            // 
            // DepartBox
            // 
            this.DepartBox.Location = new System.Drawing.Point(318, 58);
            this.DepartBox.Mask = "00.00.0000";
            this.DepartBox.Name = "DepartBox";
            this.DepartBox.Size = new System.Drawing.Size(100, 20);
            this.DepartBox.TabIndex = 14;
            // 
            // FromBoxErrorProvider
            // 
            this.FromBoxErrorProvider.ContainerControl = this;
            // 
            // ToBoxErrorProvider
            // 
            this.ToBoxErrorProvider.ContainerControl = this;
            // 
            // DepartBoxErrorProvider
            // 
            this.DepartBoxErrorProvider.ContainerControl = this;
            // 
            // ReturnBoxErrorProvider
            // 
            this.ReturnBoxErrorProvider.ContainerControl = this;
            // 
            // btnfSearchResBack
            // 
            this.btnfSearchResBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfSearchResBack.Location = new System.Drawing.Point(0, 0);
            this.btnfSearchResBack.Name = "btnfSearchResBack";
            this.btnfSearchResBack.Size = new System.Drawing.Size(41, 37);
            this.btnfSearchResBack.TabIndex = 19;
            this.btnfSearchResBack.Text = "←";
            this.btnfSearchResBack.UseVisualStyleBackColor = true;
            this.btnfSearchResBack.Visible = false;
            this.btnfSearchResBack.Click += new System.EventHandler(this.btnfSearchResBack_Click);
            // 
            // frmSearchResults
            // 
            this.frmSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSearchResults.Location = new System.Drawing.Point(0, 0);
            this.frmSearchResults.Name = "frmSearchResults";
            this.frmSearchResults.Size = new System.Drawing.Size(819, 451);
            this.frmSearchResults.TabIndex = 15;
            this.frmSearchResults.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(819, 451);
            this.Controls.Add(this.frmSearchResults);
            this.Controls.Add(this.btnfSearchResBack);
            this.Controls.Add(this.FlisghtSettingsPannel);
            this.Controls.Add(this.SortByLable);
            this.Controls.Add(this.SearchFilter);
            this.Controls.Add(this.MainLable);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FlisghtSettingsPannel.ResumeLayout(false);
            this.FlisghtSettingsPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FromBoxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToBoxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartBoxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBoxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLable;
        private System.Windows.Forms.Label SortByLable;
        private System.Windows.Forms.Label FromLable;
        private System.Windows.Forms.Label ToLable;
        private System.Windows.Forms.Label DepartLable;
        private System.Windows.Forms.Label ClassLable;
        private System.Windows.Forms.Panel FlisghtSettingsPannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider FromBoxErrorProvider;
        private System.Windows.Forms.ErrorProvider ToBoxErrorProvider;
        private System.Windows.Forms.ErrorProvider DepartBoxErrorProvider;
        private System.Windows.Forms.ErrorProvider ReturnBoxErrorProvider;
        public System.Windows.Forms.ListBox ResentlyWatchedLst;
        private System.Windows.Forms.Button btnfSearchResBack;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox SearchFilter;
        public System.Windows.Forms.ComboBox ClassBox;
        public System.Windows.Forms.TextBox FromBox;
        public System.Windows.Forms.TextBox ToBox;
        public System.Windows.Forms.MaskedTextBox DepartBox;
        public System.Windows.Forms.Button SearchFlightsBtn;
        public frmSearchResults frmSearchResults;
    }
}

