namespace VCC_IO_Compare
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Compare = new System.Windows.Forms.Button();
            this.Load_VCC = new System.Windows.Forms.Button();
            this.Load_IO = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangerHighDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dangerLowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Compare, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Load_VCC, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Load_IO, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tagNameDataGridViewTextBoxColumn,
            this.rangeLowDataGridViewTextBoxColumn,
            this.rangeHighDataGridViewTextBoxColumn,
            this.alertHighDataGridViewTextBoxColumn,
            this.dangerHighDataGridViewTextBoxColumn,
            this.alertLowDataGridViewTextBoxColumn,
            this.dangerLowDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "Tags";
            this.dataGridView1.DataSource = this.dataSet1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 5);
            this.dataGridView1.Size = new System.Drawing.Size(560, 503);
            this.dataGridView1.TabIndex = 1;
            // 
            // Compare
            // 
            this.Compare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compare.Location = new System.Drawing.Point(569, 512);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(144, 20);
            this.Compare.TabIndex = 2;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            // 
            // Load_VCC
            // 
            this.Load_VCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Load_VCC.Location = new System.Drawing.Point(569, 486);
            this.Load_VCC.Name = "Load_VCC";
            this.Load_VCC.Size = new System.Drawing.Size(144, 20);
            this.Load_VCC.TabIndex = 3;
            this.Load_VCC.Text = "Load VCC files";
            this.Load_VCC.UseVisualStyleBackColor = true;
            this.Load_VCC.Click += new System.EventHandler(this.Load_VCC_Click);
            // 
            // Load_IO
            // 
            this.Load_IO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Load_IO.Location = new System.Drawing.Point(569, 460);
            this.Load_IO.Name = "Load_IO";
            this.Load_IO.Size = new System.Drawing.Size(144, 20);
            this.Load_IO.TabIndex = 4;
            this.Load_IO.Text = "Load Excel IO files";
            this.Load_IO.UseVisualStyleBackColor = true;
            this.Load_IO.Click += new System.EventHandler(this.Load_IO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 20);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(569, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 96);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "Tags";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AutoIncrement = true;
            this.dataColumn1.ColumnName = "ID";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Tag Name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "RangeLow";
            this.dataColumn3.DataType = typeof(double);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "RangeHigh";
            this.dataColumn4.DataType = typeof(double);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "AlertHigh";
            this.dataColumn5.DataType = typeof(double);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Danger High";
            this.dataColumn6.DataType = typeof(double);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "AlertLow";
            this.dataColumn7.DataType = typeof(double);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DangerLow";
            this.dataColumn8.DataType = typeof(double);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "Tag Name";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "Tag Name";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            this.tagNameDataGridViewTextBoxColumn.Width = 82;
            // 
            // rangeLowDataGridViewTextBoxColumn
            // 
            this.rangeLowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rangeLowDataGridViewTextBoxColumn.DataPropertyName = "RangeLow";
            this.rangeLowDataGridViewTextBoxColumn.HeaderText = "Range Low";
            this.rangeLowDataGridViewTextBoxColumn.Name = "rangeLowDataGridViewTextBoxColumn";
            // 
            // rangeHighDataGridViewTextBoxColumn
            // 
            this.rangeHighDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rangeHighDataGridViewTextBoxColumn.DataPropertyName = "RangeHigh";
            this.rangeHighDataGridViewTextBoxColumn.HeaderText = "Range High";
            this.rangeHighDataGridViewTextBoxColumn.Name = "rangeHighDataGridViewTextBoxColumn";
            // 
            // alertHighDataGridViewTextBoxColumn
            // 
            this.alertHighDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alertHighDataGridViewTextBoxColumn.DataPropertyName = "AlertHigh";
            this.alertHighDataGridViewTextBoxColumn.HeaderText = "Alert High";
            this.alertHighDataGridViewTextBoxColumn.Name = "alertHighDataGridViewTextBoxColumn";
            // 
            // dangerHighDataGridViewTextBoxColumn
            // 
            this.dangerHighDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dangerHighDataGridViewTextBoxColumn.DataPropertyName = "Danger High";
            this.dangerHighDataGridViewTextBoxColumn.HeaderText = "Danger High";
            this.dangerHighDataGridViewTextBoxColumn.Name = "dangerHighDataGridViewTextBoxColumn";
            // 
            // alertLowDataGridViewTextBoxColumn
            // 
            this.alertLowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alertLowDataGridViewTextBoxColumn.DataPropertyName = "AlertLow";
            this.alertLowDataGridViewTextBoxColumn.HeaderText = "Alert Low";
            this.alertLowDataGridViewTextBoxColumn.Name = "alertLowDataGridViewTextBoxColumn";
            // 
            // dangerLowDataGridViewTextBoxColumn
            // 
            this.dangerLowDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dangerLowDataGridViewTextBoxColumn.DataPropertyName = "DangerLow";
            this.dangerLowDataGridViewTextBoxColumn.HeaderText = "Danger Low";
            this.dangerLowDataGridViewTextBoxColumn.Name = "dangerLowDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Button Load_VCC;
        private System.Windows.Forms.Button Load_IO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dangerHighDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertLowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dangerLowDataGridViewTextBoxColumn;
    }
}

