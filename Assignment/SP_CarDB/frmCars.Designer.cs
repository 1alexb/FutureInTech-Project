namespace CarsDatabase // 20/04/2023 Alex updated the namespace
{
    partial class FrmCars
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
            Label label3;
            btnLast = new Button();
            btnNext = new Button();
            btnPrevious = new Button();
            btnFirst = new Button();
            btnExit = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            chkAvailable = new CheckBox();
            label7 = new Label();
            txtRentalPerDay = new TextBox();
            label6 = new Label();
            txtDateRegistered = new TextBox();
            label5 = new Label();
            txtEngineSize = new TextBox();
            label4 = new Label();
            txtMake = new TextBox();
            txtRegistrationNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRecordCount = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 158);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 29;
            label3.Text = "Make";
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLast.Location = new Point(549, 372);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 23);
            btnLast.TabIndex = 48;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(460, 372);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 47;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrevious.Location = new Point(244, 372);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 46;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFirst.Location = new Point(155, 372);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 23);
            btnFirst.TabIndex = 45;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(570, 261);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 44;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(570, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(570, 202);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 42;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(570, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(570, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 40;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(570, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.BackColor = Color.FromArgb(210, 255, 255);
            chkAvailable.Location = new Point(361, 327);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(15, 14);
            chkAvailable.TabIndex = 38;
            chkAvailable.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(155, 325);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 37;
            label7.Text = "Available";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtRentalPerDay
            // 
            txtRentalPerDay.Location = new Point(361, 278);
            txtRentalPerDay.Name = "txtRentalPerDay";
            txtRentalPerDay.Size = new Size(100, 23);
            txtRentalPerDay.TabIndex = 36;
            txtRentalPerDay.Text = "99.99";
            txtRentalPerDay.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(155, 284);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 35;
            label6.Text = "Rental Per Day";
            // 
            // txtDateRegistered
            // 
            txtDateRegistered.Location = new Point(361, 236);
            txtDateRegistered.Name = "txtDateRegistered";
            txtDateRegistered.Size = new Size(100, 23);
            txtDateRegistered.TabIndex = 34;
            txtDateRegistered.Text = "dd/mm/yyyy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(155, 242);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 33;
            label5.Text = "Date Registered";
            // 
            // txtEngineSize
            // 
            txtEngineSize.Location = new Point(361, 193);
            txtEngineSize.Name = "txtEngineSize";
            txtEngineSize.Size = new Size(131, 23);
            txtEngineSize.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 198);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 31;
            label4.Text = "Engine Size";
            // 
            // txtMake
            // 
            txtMake.Location = new Point(361, 152);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(193, 23);
            txtMake.TabIndex = 30;
            // 
            // txtRegistrationNumber
            // 
            txtRegistrationNumber.Location = new Point(361, 115);
            txtRegistrationNumber.Name = "txtRegistrationNumber";
            txtRegistrationNumber.Size = new Size(193, 23);
            txtRegistrationNumber.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 120);
            label2.Name = "label2";
            label2.Size = new Size(157, 15);
            label2.TabIndex = 27;
            label2.Text = "Vehicle Registration Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(252, 40);
            label1.Name = "label1";
            label1.Size = new Size(266, 40);
            label1.TabIndex = 26;
            label1.Text = "Speedy Car Hire";
            // 
            // txtRecordCount
            // 
            txtRecordCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRecordCount.Location = new Point(335, 374);
            txtRecordCount.Margin = new Padding(3, 2, 3, 2);
            txtRecordCount.Name = "txtRecordCount";
            txtRecordCount.PlaceholderText = "1 of 15";
            txtRecordCount.Size = new Size(110, 23);
            txtRecordCount.TabIndex = 49;
            txtRecordCount.Text = "1 of 15";
            txtRecordCount.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(txtRecordCount);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(btnExit);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(chkAvailable);
            Controls.Add(label7);
            Controls.Add(txtRentalPerDay);
            Controls.Add(label6);
            Controls.Add(txtDateRegistered);
            Controls.Add(label5);
            Controls.Add(txtEngineSize);
            Controls.Add(label4);
            Controls.Add(txtMake);
            Controls.Add(label3);
            Controls.Add(txtRegistrationNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCars";
            Text = "Task A";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLast; // <--- 10/04/2023 @Alex Not sure if all the buttons follow naming rules, also, a button is missing from the form. Central "1 out of n" cars counter.
        private Button btnNext; // <--- 11/04/2023 @Alenka - corrected the names to follow naming conventions, added the missing button
        private Button btnPrevious;
        private Button btnFirst;
        private Button btnExit;
        private Button btnCancel;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private CheckBox chkAvailable;
        private Label label7;
        private TextBox txtRentalPerDay;
        private Label label6;
        private TextBox txtDateRegistered;
        private Label label5;
        private TextBox txtEngineSize;
        private Label label4;
        private TextBox txtMake;
        private TextBox txtRegistrationNumber;
        private Label label2;
        private Label label1;
        private TextBox txtRecordCount;
    }
}