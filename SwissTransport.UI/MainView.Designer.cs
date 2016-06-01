namespace SwissTransport.UI
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.spContMain = new System.Windows.Forms.SplitContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBVon = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.tBNach = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchAbfahrtstafel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVonAbfahrtstafel = new System.Windows.Forms.TextBox();
            this.timePickerAbfahrtstafel = new System.Windows.Forms.DateTimePicker();
            this.datePickerAbfahrtstafel = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dGridViewResult = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).BeginInit();
            this.spContMain.Panel1.SuspendLayout();
            this.spContMain.Panel2.SuspendLayout();
            this.spContMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // spContMain
            // 
            this.spContMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContMain.Location = new System.Drawing.Point(0, 0);
            this.spContMain.Name = "spContMain";
            // 
            // spContMain.Panel1
            // 
            this.spContMain.Panel1.Controls.Add(this.tabControl);
            this.spContMain.Panel1MinSize = 300;
            // 
            // spContMain.Panel2
            // 
            this.spContMain.Panel2.Controls.Add(this.dGridViewResult);
            this.spContMain.Size = new System.Drawing.Size(625, 364);
            this.spContMain.SplitterDistance = 300;
            this.spContMain.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(300, 364);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.OntabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSwitch);
            this.tabPage1.Controls.Add(this.btnAn);
            this.tabPage1.Controls.Add(this.btnAb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tBVon);
            this.tabPage1.Controls.Add(this.timePicker);
            this.tabPage1.Controls.Add(this.tBNach);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(292, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSwitch
            // 
            this.btnSwitch.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitch.Image")));
            this.btnSwitch.Location = new System.Drawing.Point(263, 18);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(25, 25);
            this.btnSwitch.TabIndex = 12;
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.OnbtnSwitch_Click);
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(60, 107);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(41, 23);
            this.btnAn.TabIndex = 11;
            this.btnAn.Tag = "true";
            this.btnAn.Text = "An";
            this.btnAn.UseVisualStyleBackColor = true;
            this.btnAn.Click += new System.EventHandler(this.OnbtnArivalDeparture_Click);
            // 
            // btnAb
            // 
            this.btnAb.Location = new System.Drawing.Point(8, 107);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(40, 23);
            this.btnAb.TabIndex = 10;
            this.btnAb.Tag = "false";
            this.btnAb.Text = "Ab";
            this.btnAb.UseVisualStyleBackColor = true;
            this.btnAb.Click += new System.EventHandler(this.OnbtnArivalDeparture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Von:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(123, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(137, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Verbindung Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.OnbtnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nach:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zeit:";
            // 
            // tBVon
            // 
            this.tBVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tBVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tBVon.Location = new System.Drawing.Point(60, 6);
            this.tBVon.Name = "tBVon";
            this.tBVon.Size = new System.Drawing.Size(200, 20);
            this.tBVon.TabIndex = 2;
            this.tBVon.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tBVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntB_KeyDown);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(203, 60);
            this.timePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(57, 20);
            this.timePicker.TabIndex = 7;
            this.timePicker.Value = new System.DateTime(2016, 5, 24, 16, 43, 0, 0);
            // 
            // tBNach
            // 
            this.tBNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tBNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tBNach.Location = new System.Drawing.Point(60, 34);
            this.tBNach.Name = "tBNach";
            this.tBNach.Size = new System.Drawing.Size(200, 20);
            this.tBNach.TabIndex = 3;
            this.tBNach.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tBNach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntB_KeyDown);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(60, 60);
            this.datePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(84, 20);
            this.datePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnSearchAbfahrtstafel);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbVonAbfahrtstafel);
            this.tabPage2.Controls.Add(this.timePickerAbfahrtstafel);
            this.tabPage2.Controls.Add(this.datePickerAbfahrtstafel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Von:";
            // 
            // btnSearchAbfahrtstafel
            // 
            this.btnSearchAbfahrtstafel.Location = new System.Drawing.Point(129, 72);
            this.btnSearchAbfahrtstafel.Name = "btnSearchAbfahrtstafel";
            this.btnSearchAbfahrtstafel.Size = new System.Drawing.Size(137, 29);
            this.btnSearchAbfahrtstafel.TabIndex = 16;
            this.btnSearchAbfahrtstafel.Text = "Abfahrtstafel anzeigen";
            this.btnSearchAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnSearchAbfahrtstafel.Click += new System.EventHandler(this.OnbtnSearchAbfahrtstafel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zeit:";
            // 
            // tbVonAbfahrtstafel
            // 
            this.tbVonAbfahrtstafel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbVonAbfahrtstafel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbVonAbfahrtstafel.Location = new System.Drawing.Point(60, 6);
            this.tbVonAbfahrtstafel.Name = "tbVonAbfahrtstafel";
            this.tbVonAbfahrtstafel.Size = new System.Drawing.Size(200, 20);
            this.tbVonAbfahrtstafel.TabIndex = 11;
            this.tbVonAbfahrtstafel.Tag = "Abfahrtstafel";
            this.tbVonAbfahrtstafel.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.tbVonAbfahrtstafel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntB_KeyDown);
            // 
            // timePickerAbfahrtstafel
            // 
            this.timePickerAbfahrtstafel.CustomFormat = "HH:mm";
            this.timePickerAbfahrtstafel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerAbfahrtstafel.Location = new System.Drawing.Point(203, 35);
            this.timePickerAbfahrtstafel.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.timePickerAbfahrtstafel.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.timePickerAbfahrtstafel.Name = "timePickerAbfahrtstafel";
            this.timePickerAbfahrtstafel.ShowUpDown = true;
            this.timePickerAbfahrtstafel.Size = new System.Drawing.Size(57, 20);
            this.timePickerAbfahrtstafel.TabIndex = 14;
            this.timePickerAbfahrtstafel.Value = new System.DateTime(2016, 5, 24, 16, 43, 0, 0);
            // 
            // datePickerAbfahrtstafel
            // 
            this.datePickerAbfahrtstafel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerAbfahrtstafel.Location = new System.Drawing.Point(60, 35);
            this.datePickerAbfahrtstafel.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.datePickerAbfahrtstafel.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.datePickerAbfahrtstafel.Name = "datePickerAbfahrtstafel";
            this.datePickerAbfahrtstafel.Size = new System.Drawing.Size(84, 20);
            this.datePickerAbfahrtstafel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Datum:";
            // 
            // dGridViewResult
            // 
            this.dGridViewResult.AllowUserToAddRows = false;
            this.dGridViewResult.AllowUserToDeleteRows = false;
            this.dGridViewResult.AllowUserToResizeRows = false;
            this.dGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridViewResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dGridViewResult.MultiSelect = false;
            this.dGridViewResult.Name = "dGridViewResult";
            this.dGridViewResult.ReadOnly = true;
            this.dGridViewResult.RowHeadersVisible = false;
            this.dGridViewResult.RowTemplate.ReadOnly = true;
            this.dGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGridViewResult.Size = new System.Drawing.Size(321, 364);
            this.dGridViewResult.TabIndex = 0;
            this.dGridViewResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OndGridViewResult_CellDoubleClick);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 364);
            this.Controls.Add(this.spContMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "MainView";
            this.Text = "ÖV Schweiz";
            this.spContMain.Panel1.ResumeLayout(false);
            this.spContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).EndInit();
            this.spContMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBNach;
        private System.Windows.Forms.TextBox tBVon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dGridViewResult;
        private System.Windows.Forms.Button btnAn;
        private System.Windows.Forms.Button btnAb;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchAbfahrtstafel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVonAbfahrtstafel;
        private System.Windows.Forms.DateTimePicker timePickerAbfahrtstafel;
        private System.Windows.Forms.DateTimePicker datePickerAbfahrtstafel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSwitch;
    }
}

