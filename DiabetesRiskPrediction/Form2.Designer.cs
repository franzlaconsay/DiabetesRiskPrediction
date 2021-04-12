
namespace DiabetesRiskPrediction
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBoxQ = new System.Windows.Forms.GroupBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonPositive = new System.Windows.Forms.RadioButton();
            this.radioButtonNegative = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelKilograms = new System.Windows.Forms.Label();
            this.comboBoxFeet = new System.Windows.Forms.ComboBox();
            this.comboBoxInches = new System.Windows.Forms.ComboBox();
            this.labelFeet = new System.Windows.Forms.Label();
            this.labelInches = new System.Windows.Forms.Label();
            this.groupBoxQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxQ
            // 
            this.groupBoxQ.Controls.Add(this.labelInches);
            this.groupBoxQ.Controls.Add(this.labelFeet);
            this.groupBoxQ.Controls.Add(this.comboBoxInches);
            this.groupBoxQ.Controls.Add(this.comboBoxFeet);
            this.groupBoxQ.Controls.Add(this.labelKilograms);
            this.groupBoxQ.Controls.Add(this.numericUpDownWeight);
            this.groupBoxQ.Controls.Add(this.numericUpDownAge);
            this.groupBoxQ.Controls.Add(this.radioButtonNegative);
            this.groupBoxQ.Controls.Add(this.radioButtonPositive);
            this.groupBoxQ.Controls.Add(this.labelQuestion);
            this.groupBoxQ.Location = new System.Drawing.Point(12, 12);
            this.groupBoxQ.Name = "groupBoxQ";
            this.groupBoxQ.Size = new System.Drawing.Size(360, 110);
            this.groupBoxQ.TabIndex = 0;
            this.groupBoxQ.TabStop = false;
            this.groupBoxQ.Text = "1 of 17";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(6, 27);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(67, 13);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "Your Gender";
            // 
            // radioButtonPositive
            // 
            this.radioButtonPositive.AutoSize = true;
            this.radioButtonPositive.Location = new System.Drawing.Point(9, 52);
            this.radioButtonPositive.Name = "radioButtonPositive";
            this.radioButtonPositive.Size = new System.Drawing.Size(48, 17);
            this.radioButtonPositive.TabIndex = 1;
            this.radioButtonPositive.Text = "Male";
            this.radioButtonPositive.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegative
            // 
            this.radioButtonNegative.AutoSize = true;
            this.radioButtonNegative.Location = new System.Drawing.Point(9, 77);
            this.radioButtonNegative.Name = "radioButtonNegative";
            this.radioButtonNegative.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNegative.TabIndex = 2;
            this.radioButtonNegative.Text = "Female";
            this.radioButtonNegative.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(297, 128);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(9, 52);
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAge.TabIndex = 3;
            this.numericUpDownAge.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownAge.Visible = false;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 52);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWeight.Visible = false;
            // 
            // labelKilograms
            // 
            this.labelKilograms.AutoSize = true;
            this.labelKilograms.Location = new System.Drawing.Point(135, 54);
            this.labelKilograms.Name = "labelKilograms";
            this.labelKilograms.Size = new System.Drawing.Size(51, 13);
            this.labelKilograms.TabIndex = 5;
            this.labelKilograms.Text = "kilograms";
            this.labelKilograms.Visible = false;
            // 
            // comboBoxFeet
            // 
            this.comboBoxFeet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeet.FormattingEnabled = true;
            this.comboBoxFeet.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxFeet.Location = new System.Drawing.Point(9, 43);
            this.comboBoxFeet.Name = "comboBoxFeet";
            this.comboBoxFeet.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFeet.TabIndex = 6;
            this.comboBoxFeet.Visible = false;
            // 
            // comboBoxInches
            // 
            this.comboBoxInches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInches.FormattingEnabled = true;
            this.comboBoxInches.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBoxInches.Location = new System.Drawing.Point(9, 70);
            this.comboBoxInches.Name = "comboBoxInches";
            this.comboBoxInches.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInches.TabIndex = 6;
            this.comboBoxInches.Visible = false;
            // 
            // labelFeet
            // 
            this.labelFeet.AutoSize = true;
            this.labelFeet.Location = new System.Drawing.Point(136, 46);
            this.labelFeet.Name = "labelFeet";
            this.labelFeet.Size = new System.Drawing.Size(13, 13);
            this.labelFeet.TabIndex = 7;
            this.labelFeet.Text = "ft";
            this.labelFeet.Visible = false;
            // 
            // labelInches
            // 
            this.labelInches.AutoSize = true;
            this.labelInches.Location = new System.Drawing.Point(136, 73);
            this.labelInches.Name = "labelInches";
            this.labelInches.Size = new System.Drawing.Size(15, 13);
            this.labelInches.TabIndex = 7;
            this.labelInches.Text = "in";
            this.labelInches.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.groupBoxQ);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diabetes Risk Test";
            this.groupBoxQ.ResumeLayout(false);
            this.groupBoxQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxQ;
        private System.Windows.Forms.RadioButton radioButtonNegative;
        private System.Windows.Forms.RadioButton radioButtonPositive;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelKilograms;
        private System.Windows.Forms.Label labelInches;
        private System.Windows.Forms.Label labelFeet;
        private System.Windows.Forms.ComboBox comboBoxInches;
        private System.Windows.Forms.ComboBox comboBoxFeet;
    }
}