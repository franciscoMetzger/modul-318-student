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
            this.spContMain = new System.Windows.Forms.SplitContainer();
            this.btnAn = new System.Windows.Forms.Button();
            this.btnAb = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNach = new System.Windows.Forms.TextBox();
            this.tBVon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGridViewResult = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).BeginInit();
            this.spContMain.Panel1.SuspendLayout();
            this.spContMain.Panel2.SuspendLayout();
            this.spContMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewResult)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.spContMain.Size = new System.Drawing.Size(625, 348);
            this.spContMain.SplitterDistance = 300;
            this.spContMain.TabIndex = 0;
            // 
            // btnAn
            // 
            this.btnAn.Location = new System.Drawing.Point(60, 107);
            this.btnAn.Name = "btnAn";
            this.btnAn.Size = new System.Drawing.Size(41, 23);
            this.btnAn.TabIndex = 11;
            this.btnAn.Text = "An";
            this.btnAn.UseVisualStyleBackColor = true;
            // 
            // btnAb
            // 
            this.btnAb.Location = new System.Drawing.Point(8, 107);
            this.btnAb.Name = "btnAb";
            this.btnAb.Size = new System.Drawing.Size(40, 23);
            this.btnAb.TabIndex = 10;
            this.btnAb.Text = "Ab";
            this.btnAb.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zeit:";
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
            // tBNach
            // 
            this.tBNach.Location = new System.Drawing.Point(60, 34);
            this.tBNach.Name = "tBNach";
            this.tBNach.Size = new System.Drawing.Size(200, 20);
            this.tBNach.TabIndex = 3;
            this.tBNach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tB_KeyUp);
            // 
            // tBVon
            // 
            this.tBVon.Location = new System.Drawing.Point(60, 6);
            this.tBVon.Name = "tBVon";
            this.tBVon.Size = new System.Drawing.Size(200, 20);
            this.tBVon.TabIndex = 2;
            this.tBVon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tB_KeyUp);
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
            // dGridViewResult
            // 
            this.dGridViewResult.AllowUserToAddRows = false;
            this.dGridViewResult.AllowUserToDeleteRows = false;
            this.dGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGridViewResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGridViewResult.Location = new System.Drawing.Point(0, 0);
            this.dGridViewResult.Name = "dGridViewResult";
            this.dGridViewResult.ReadOnly = true;
            this.dGridViewResult.RowHeadersVisible = false;
            this.dGridViewResult.RowTemplate.ReadOnly = true;
            this.dGridViewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGridViewResult.Size = new System.Drawing.Size(321, 348);
            this.dGridViewResult.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(300, 348);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(292, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(292, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 348);
            this.Controls.Add(this.spContMain);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "MainView";
            this.Text = "ÖV Schweiz";
            this.spContMain.Panel1.ResumeLayout(false);
            this.spContMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContMain)).EndInit();
            this.spContMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewResult)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

