namespace CarsDatabase
{
    partial class frmSearch
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
            groupBox1 = new GroupBox();
            txtValue = new TextBox();
            cboOperator = new ComboBox();
            cboField = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRun = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            VehicleRegNo = new DataGridViewTextBoxColumn();
            Make = new DataGridViewTextBoxColumn();
            EngineSize = new DataGridViewComboBoxColumn();
            DateRegistered = new DataGridViewTextBoxColumn();
            RentalPerDay = new DataGridViewTextBoxColumn();
            Available = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValue);
            groupBox1.Controls.Add(cboOperator);
            groupBox1.Controls.Add(cboField);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(28, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(373, 64);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(226, 27);
            txtValue.TabIndex = 5;
            // 
            // cboOperator
            // 
            cboOperator.FormattingEnabled = true;
            cboOperator.Location = new Point(186, 64);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(151, 28);
            cboOperator.TabIndex = 4;
            // 
            // cboField
            // 
            cboField.FormattingEnabled = true;
            cboField.Location = new Point(16, 64);
            cboField.Name = "cboField";
            cboField.Size = new Size(151, 28);
            cboField.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 23);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 23);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Operator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Field";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(673, 45);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 37);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(673, 94);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 37);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VehicleRegNo, Make, EngineSize, DateRegistered, RentalPerDay, Available });
            dataGridView1.Location = new Point(28, 161);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(760, 252);
            dataGridView1.TabIndex = 3;
            // 
            // VehicleRegNo
            // 
            VehicleRegNo.HeaderText = "VehicleRegNo";
            VehicleRegNo.MinimumWidth = 6;
            VehicleRegNo.Name = "VehicleRegNo";
            VehicleRegNo.Width = 125;
            // 
            // Make
            // 
            Make.HeaderText = "Make";
            Make.MinimumWidth = 6;
            Make.Name = "Make";
            Make.Width = 125;
            // 
            // EngineSize
            // 
            EngineSize.HeaderText = "EngineSize";
            EngineSize.MinimumWidth = 6;
            EngineSize.Name = "EngineSize";
            EngineSize.Resizable = DataGridViewTriState.True;
            EngineSize.SortMode = DataGridViewColumnSortMode.Automatic;
            EngineSize.Width = 125;
            // 
            // DateRegistered
            // 
            DateRegistered.HeaderText = "DateRegistered";
            DateRegistered.MinimumWidth = 6;
            DateRegistered.Name = "DateRegistered";
            DateRegistered.Width = 125;
            // 
            // RentalPerDay
            // 
            RentalPerDay.HeaderText = "RentalPerDay";
            RentalPerDay.MinimumWidth = 6;
            RentalPerDay.Name = "RentalPerDay";
            RentalPerDay.Width = 125;
            // 
            // Available
            // 
            Available.HeaderText = "Available";
            Available.MinimumWidth = 6;
            Available.Name = "Available";
            Available.Width = 125;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnRun);
            Controls.Add(groupBox1);
            Name = "frmSearch";
            Text = "Task A Search";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtValue;
        private ComboBox cboOperator;
        private ComboBox cboField;
        private Button btnRun;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn VehicleRegNo;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewComboBoxColumn EngineSize;
        private DataGridViewTextBoxColumn DateRegistered;
        private DataGridViewTextBoxColumn RentalPerDay;
        private DataGridViewCheckBoxColumn Available;
    }
}