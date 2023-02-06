namespace Lab1
{
    partial class HealthRecord
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
            this.groupBoxPatientInput = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelGenderAtBirth = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxGenderSelection = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttonSavePatient = new System.Windows.Forms.Button();
            this.groupBoxOutputCalcs = new System.Windows.Forms.GroupBox();
            this.labelBMILabel = new System.Windows.Forms.Label();
            this.labelAgeLabel = new System.Windows.Forms.Label();
            this.labelAgeValue = new System.Windows.Forms.Label();
            this.labelHRModerateLabel = new System.Windows.Forms.Label();
            this.labelHRMaxLabel = new System.Windows.Forms.Label();
            this.labelHRVigorousLabel = new System.Windows.Forms.Label();
            this.labelBMIValue = new System.Windows.Forms.Label();
            this.labelHRMaxValue = new System.Windows.Forms.Label();
            this.labelHRModerateValues = new System.Windows.Forms.Label();
            this.labelHRVigorousValues = new System.Windows.Forms.Label();
            this.groupBoxPatientInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBoxOutputCalcs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatientInput
            // 
            this.groupBoxPatientInput.Controls.Add(this.numericUpDown2);
            this.groupBoxPatientInput.Controls.Add(this.numericUpDown1);
            this.groupBoxPatientInput.Controls.Add(this.dateTimePickerDOB);
            this.groupBoxPatientInput.Controls.Add(this.comboBoxGenderSelection);
            this.groupBoxPatientInput.Controls.Add(this.textBox2);
            this.groupBoxPatientInput.Controls.Add(this.textBox1);
            this.groupBoxPatientInput.Controls.Add(this.labelWeight);
            this.groupBoxPatientInput.Controls.Add(this.labelHeight);
            this.groupBoxPatientInput.Controls.Add(this.labelDOB);
            this.groupBoxPatientInput.Controls.Add(this.labelGenderAtBirth);
            this.groupBoxPatientInput.Controls.Add(this.labelLastName);
            this.groupBoxPatientInput.Controls.Add(this.labelFirstName);
            this.groupBoxPatientInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPatientInput.Name = "groupBoxPatientInput";
            this.groupBoxPatientInput.Size = new System.Drawing.Size(340, 236);
            this.groupBoxPatientInput.TabIndex = 0;
            this.groupBoxPatientInput.TabStop = false;
            this.groupBoxPatientInput.Text = "Input - Enter Patient Information";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 37);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelGenderAtBirth
            // 
            this.labelGenderAtBirth.AutoSize = true;
            this.labelGenderAtBirth.Location = new System.Drawing.Point(6, 103);
            this.labelGenderAtBirth.Name = "labelGenderAtBirth";
            this.labelGenderAtBirth.Size = new System.Drawing.Size(81, 13);
            this.labelGenderAtBirth.TabIndex = 2;
            this.labelGenderAtBirth.Text = "Gender at Birth:";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(6, 136);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(69, 13);
            this.labelDOB.TabIndex = 3;
            this.labelDOB.Text = "Date of Birth:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 169);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(64, 13);
            this.labelHeight.TabIndex = 4;
            this.labelHeight.Text = "Height (cm):";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(6, 202);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight (kg):";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 7;
            // 
            // comboBoxGenderSelection
            // 
            this.comboBoxGenderSelection.FormattingEnabled = true;
            this.comboBoxGenderSelection.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGenderSelection.Location = new System.Drawing.Point(93, 100);
            this.comboBoxGenderSelection.Name = "comboBoxGenderSelection";
            this.comboBoxGenderSelection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenderSelection.TabIndex = 8;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Location = new System.Drawing.Point(93, 134);
            this.dateTimePickerDOB.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDOB.TabIndex = 9;
            this.dateTimePickerDOB.Value = new System.DateTime(2003, 1, 1, 10, 26, 0, 0);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 167);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(93, 200);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // buttonSavePatient
            // 
            this.buttonSavePatient.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSavePatient.Location = new System.Drawing.Point(12, 254);
            this.buttonSavePatient.Name = "buttonSavePatient";
            this.buttonSavePatient.Size = new System.Drawing.Size(340, 38);
            this.buttonSavePatient.TabIndex = 1;
            this.buttonSavePatient.Text = "Save Patient";
            this.buttonSavePatient.UseVisualStyleBackColor = false;
            // 
            // groupBoxOutputCalcs
            // 
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRVigorousValues);
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRModerateValues);
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRMaxValue);
            this.groupBoxOutputCalcs.Controls.Add(this.labelBMIValue);
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRVigorousLabel);
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRMaxLabel);
            this.groupBoxOutputCalcs.Controls.Add(this.labelHRModerateLabel);
            this.groupBoxOutputCalcs.Controls.Add(this.labelAgeValue);
            this.groupBoxOutputCalcs.Controls.Add(this.labelAgeLabel);
            this.groupBoxOutputCalcs.Controls.Add(this.labelBMILabel);
            this.groupBoxOutputCalcs.Location = new System.Drawing.Point(12, 298);
            this.groupBoxOutputCalcs.Name = "groupBoxOutputCalcs";
            this.groupBoxOutputCalcs.Size = new System.Drawing.Size(340, 156);
            this.groupBoxOutputCalcs.TabIndex = 12;
            this.groupBoxOutputCalcs.TabStop = false;
            this.groupBoxOutputCalcs.Text = "Output - Calculated Information";
            // 
            // labelBMILabel
            // 
            this.labelBMILabel.AutoSize = true;
            this.labelBMILabel.Location = new System.Drawing.Point(6, 39);
            this.labelBMILabel.Name = "labelBMILabel";
            this.labelBMILabel.Size = new System.Drawing.Size(29, 13);
            this.labelBMILabel.TabIndex = 0;
            this.labelBMILabel.Text = "BMI:";
            // 
            // labelAgeLabel
            // 
            this.labelAgeLabel.AutoSize = true;
            this.labelAgeLabel.Location = new System.Drawing.Point(6, 16);
            this.labelAgeLabel.Name = "labelAgeLabel";
            this.labelAgeLabel.Size = new System.Drawing.Size(70, 13);
            this.labelAgeLabel.TabIndex = 1;
            this.labelAgeLabel.Text = "Age in Years:";
            // 
            // labelAgeValue
            // 
            this.labelAgeValue.AutoSize = true;
            this.labelAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgeValue.Location = new System.Drawing.Point(239, 16);
            this.labelAgeValue.Name = "labelAgeValue";
            this.labelAgeValue.Size = new System.Drawing.Size(34, 13);
            this.labelAgeValue.TabIndex = 2;
            this.labelAgeValue.Text = " N/A";
            // 
            // labelHRModerateLabel
            // 
            this.labelHRModerateLabel.Location = new System.Drawing.Point(6, 85);
            this.labelHRModerateLabel.Name = "labelHRModerateLabel";
            this.labelHRModerateLabel.Size = new System.Drawing.Size(158, 35);
            this.labelHRModerateLabel.TabIndex = 4;
            this.labelHRModerateLabel.Text = "Heart Rate Zone for Moderate Intesity Activities (50 -70%):";
            // 
            // labelHRMaxLabel
            // 
            this.labelHRMaxLabel.AutoSize = true;
            this.labelHRMaxLabel.Location = new System.Drawing.Point(6, 62);
            this.labelHRMaxLabel.Name = "labelHRMaxLabel";
            this.labelHRMaxLabel.Size = new System.Drawing.Size(181, 13);
            this.labelHRMaxLabel.TabIndex = 5;
            this.labelHRMaxLabel.Text = "Average Maximum Heart Rate 100%:";
            // 
            // labelHRVigorousLabel
            // 
            this.labelHRVigorousLabel.Location = new System.Drawing.Point(6, 118);
            this.labelHRVigorousLabel.Name = "labelHRVigorousLabel";
            this.labelHRVigorousLabel.Size = new System.Drawing.Size(158, 35);
            this.labelHRVigorousLabel.TabIndex = 8;
            this.labelHRVigorousLabel.Text = "Heart Rate Zone for Vigorous Intesity Activities (70 -85%):";
            // 
            // labelBMIValue
            // 
            this.labelBMIValue.AutoSize = true;
            this.labelBMIValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBMIValue.Location = new System.Drawing.Point(239, 39);
            this.labelBMIValue.Name = "labelBMIValue";
            this.labelBMIValue.Size = new System.Drawing.Size(34, 13);
            this.labelBMIValue.TabIndex = 9;
            this.labelBMIValue.Text = " N/A";
            // 
            // labelHRMaxValue
            // 
            this.labelHRMaxValue.AutoSize = true;
            this.labelHRMaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHRMaxValue.Location = new System.Drawing.Point(239, 62);
            this.labelHRMaxValue.Name = "labelHRMaxValue";
            this.labelHRMaxValue.Size = new System.Drawing.Size(50, 13);
            this.labelHRMaxValue.TabIndex = 10;
            this.labelHRMaxValue.Text = " ... bpm";
            // 
            // labelHRModerateValues
            // 
            this.labelHRModerateValues.AutoSize = true;
            this.labelHRModerateValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHRModerateValues.Location = new System.Drawing.Point(239, 94);
            this.labelHRModerateValues.Name = "labelHRModerateValues";
            this.labelHRModerateValues.Size = new System.Drawing.Size(97, 13);
            this.labelHRModerateValues.TabIndex = 11;
            this.labelHRModerateValues.Text = "... bpm - ... bpm";
            // 
            // labelHRVigorousValues
            // 
            this.labelHRVigorousValues.AutoSize = true;
            this.labelHRVigorousValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHRVigorousValues.Location = new System.Drawing.Point(239, 127);
            this.labelHRVigorousValues.Name = "labelHRVigorousValues";
            this.labelHRVigorousValues.Size = new System.Drawing.Size(97, 13);
            this.labelHRVigorousValues.TabIndex = 12;
            this.labelHRVigorousValues.Text = "... bpm - ... bpm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 462);
            this.Controls.Add(this.groupBoxOutputCalcs);
            this.Controls.Add(this.buttonSavePatient);
            this.Controls.Add(this.groupBoxPatientInput);
            this.Name = "Form1";
            this.Text = "Testing for Health Record Class";
            this.groupBoxPatientInput.ResumeLayout(false);
            this.groupBoxPatientInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBoxOutputCalcs.ResumeLayout(false);
            this.groupBoxOutputCalcs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatientInput;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxGenderSelection;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGenderAtBirth;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonSavePatient;
        private System.Windows.Forms.GroupBox groupBoxOutputCalcs;
        private System.Windows.Forms.Label labelHRVigorousValues;
        private System.Windows.Forms.Label labelHRModerateValues;
        private System.Windows.Forms.Label labelHRMaxValue;
        private System.Windows.Forms.Label labelBMIValue;
        private System.Windows.Forms.Label labelHRVigorousLabel;
        private System.Windows.Forms.Label labelHRMaxLabel;
        private System.Windows.Forms.Label labelHRModerateLabel;
        private System.Windows.Forms.Label labelAgeValue;
        private System.Windows.Forms.Label labelAgeLabel;
        private System.Windows.Forms.Label labelBMILabel;
    }
}

