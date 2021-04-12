
namespace DiabetesRiskPrediction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTest = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.labelRiskInterpretation = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelRisk = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonTakeTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageAdvance = new System.Windows.Forms.TabPage();
            this.groupBoxAccuracy = new System.Windows.Forms.GroupBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelTrainAccuracy = new System.Windows.Forms.Label();
            this.labelTestAccuracy = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.labelInterpretation = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxTesting = new System.Windows.Forms.GroupBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxThrush = new System.Windows.Forms.ComboBox();
            this.comboBoxObesity = new System.Windows.Forms.ComboBox();
            this.comboBoxAlopesia = new System.Windows.Forms.ComboBox();
            this.comboBoxPolyphagia = new System.Windows.Forms.ComboBox();
            this.comboBoxMuscle = new System.Windows.Forms.ComboBox();
            this.comboBoxWeakness = new System.Windows.Forms.ComboBox();
            this.comboBoxParesis = new System.Windows.Forms.ComboBox();
            this.comboBoxWeightLoss = new System.Windows.Forms.ComboBox();
            this.comboBoxItching = new System.Windows.Forms.ComboBox();
            this.comboBoxHealing = new System.Windows.Forms.ComboBox();
            this.comboBoxPolydipsia = new System.Windows.Forms.ComboBox();
            this.comboBoxVisual = new System.Windows.Forms.ComboBox();
            this.comboBoxIrritability = new System.Windows.Forms.ComboBox();
            this.comboBoxPolyuria = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonLearn = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialogWeights = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogWeights = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageTest.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageAdvance.SuspendLayout();
            this.groupBoxAccuracy.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.groupBoxTesting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTest);
            this.tabControl1.Controls.Add(this.tabPageAdvance);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTest
            // 
            this.tabPageTest.Controls.Add(this.groupBox4);
            this.tabPageTest.Controls.Add(this.groupBox3);
            this.tabPageTest.Controls.Add(this.groupBox2);
            this.tabPageTest.Location = new System.Drawing.Point(4, 22);
            this.tabPageTest.Name = "tabPageTest";
            this.tabPageTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTest.Size = new System.Drawing.Size(532, 344);
            this.tabPageTest.TabIndex = 0;
            this.tabPageTest.Text = "Test";
            this.tabPageTest.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.labelRiskInterpretation);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.labelRisk);
            this.groupBox4.Location = new System.Drawing.Point(392, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 204);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Interpretation:";
            // 
            // labelRiskInterpretation
            // 
            this.labelRiskInterpretation.AutoSize = true;
            this.labelRiskInterpretation.Location = new System.Drawing.Point(6, 75);
            this.labelRiskInterpretation.Name = "labelRiskInterpretation";
            this.labelRiskInterpretation.Size = new System.Drawing.Size(27, 13);
            this.labelRiskInterpretation.TabIndex = 0;
            this.labelRiskInterpretation.Text = "N/A";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Risk Detection:";
            // 
            // labelRisk
            // 
            this.labelRisk.AutoSize = true;
            this.labelRisk.Location = new System.Drawing.Point(6, 38);
            this.labelRisk.Name = "labelRisk";
            this.labelRisk.Size = new System.Drawing.Size(27, 13);
            this.labelRisk.TabIndex = 0;
            this.labelRisk.Text = "N/A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.buttonTakeTest);
            this.groupBox3.Location = new System.Drawing.Point(392, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diabetes Risk Test";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 61);
            this.label18.TabIndex = 1;
            this.label18.Text = "Take the test and see\r\nif you\'re at risk\r\nof diabetes!\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTakeTest
            // 
            this.buttonTakeTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.buttonTakeTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.buttonTakeTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.buttonTakeTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTakeTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTakeTest.Location = new System.Drawing.Point(27, 83);
            this.buttonTakeTest.Name = "buttonTakeTest";
            this.buttonTakeTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeTest.TabIndex = 0;
            this.buttonTakeTest.Text = "Take Test";
            this.buttonTakeTest.UseVisualStyleBackColor = false;
            this.buttonTakeTest.Click += new System.EventHandler(this.buttonTakeTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diabetes Infographic";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiabetesRiskPrediction.Properties.Resources.diabetesWHO;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageAdvance
            // 
            this.tabPageAdvance.Controls.Add(this.groupBoxAccuracy);
            this.tabPageAdvance.Controls.Add(this.groupBoxResults);
            this.tabPageAdvance.Controls.Add(this.groupBoxTesting);
            this.tabPageAdvance.Controls.Add(this.groupBox1);
            this.tabPageAdvance.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvance.Name = "tabPageAdvance";
            this.tabPageAdvance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvance.Size = new System.Drawing.Size(532, 344);
            this.tabPageAdvance.TabIndex = 1;
            this.tabPageAdvance.Text = "Advance";
            this.tabPageAdvance.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccuracy
            // 
            this.groupBoxAccuracy.Controls.Add(this.buttonTest);
            this.groupBoxAccuracy.Controls.Add(this.labelTrainAccuracy);
            this.groupBoxAccuracy.Controls.Add(this.labelTestAccuracy);
            this.groupBoxAccuracy.Enabled = false;
            this.groupBoxAccuracy.Location = new System.Drawing.Point(6, 213);
            this.groupBoxAccuracy.Name = "groupBoxAccuracy";
            this.groupBoxAccuracy.Size = new System.Drawing.Size(90, 119);
            this.groupBoxAccuracy.TabIndex = 5;
            this.groupBoxAccuracy.TabStop = false;
            this.groupBoxAccuracy.Text = "Accuracy";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(6, 27);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 0;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelTrainAccuracy
            // 
            this.labelTrainAccuracy.Location = new System.Drawing.Point(6, 53);
            this.labelTrainAccuracy.Name = "labelTrainAccuracy";
            this.labelTrainAccuracy.Size = new System.Drawing.Size(75, 18);
            this.labelTrainAccuracy.TabIndex = 1;
            this.labelTrainAccuracy.Text = "0";
            this.labelTrainAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTestAccuracy
            // 
            this.labelTestAccuracy.Location = new System.Drawing.Point(6, 76);
            this.labelTestAccuracy.Name = "labelTestAccuracy";
            this.labelTestAccuracy.Size = new System.Drawing.Size(75, 18);
            this.labelTestAccuracy.TabIndex = 1;
            this.labelTestAccuracy.Text = "0";
            this.labelTestAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.labelInterpretation);
            this.groupBoxResults.Controls.Add(this.label19);
            this.groupBoxResults.Controls.Add(this.labelOutput);
            this.groupBoxResults.Controls.Add(this.label17);
            this.groupBoxResults.Enabled = false;
            this.groupBoxResults.Location = new System.Drawing.Point(102, 292);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(420, 40);
            this.groupBoxResults.TabIndex = 4;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // labelInterpretation
            // 
            this.labelInterpretation.AutoSize = true;
            this.labelInterpretation.Location = new System.Drawing.Point(275, 16);
            this.labelInterpretation.Name = "labelInterpretation";
            this.labelInterpretation.Size = new System.Drawing.Size(27, 13);
            this.labelInterpretation.TabIndex = 0;
            this.labelInterpretation.Text = "N/A";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(197, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Interpretation:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(54, 16);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(27, 13);
            this.labelOutput.TabIndex = 0;
            this.labelOutput.Text = "N/A";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Output:";
            // 
            // groupBoxTesting
            // 
            this.groupBoxTesting.Controls.Add(this.buttonSubmit);
            this.groupBoxTesting.Controls.Add(this.label16);
            this.groupBoxTesting.Controls.Add(this.label8);
            this.groupBoxTesting.Controls.Add(this.label15);
            this.groupBoxTesting.Controls.Add(this.label7);
            this.groupBoxTesting.Controls.Add(this.label14);
            this.groupBoxTesting.Controls.Add(this.label6);
            this.groupBoxTesting.Controls.Add(this.label13);
            this.groupBoxTesting.Controls.Add(this.label5);
            this.groupBoxTesting.Controls.Add(this.label12);
            this.groupBoxTesting.Controls.Add(this.label4);
            this.groupBoxTesting.Controls.Add(this.comboBoxThrush);
            this.groupBoxTesting.Controls.Add(this.comboBoxObesity);
            this.groupBoxTesting.Controls.Add(this.comboBoxAlopesia);
            this.groupBoxTesting.Controls.Add(this.comboBoxPolyphagia);
            this.groupBoxTesting.Controls.Add(this.comboBoxMuscle);
            this.groupBoxTesting.Controls.Add(this.comboBoxWeakness);
            this.groupBoxTesting.Controls.Add(this.comboBoxParesis);
            this.groupBoxTesting.Controls.Add(this.comboBoxWeightLoss);
            this.groupBoxTesting.Controls.Add(this.comboBoxItching);
            this.groupBoxTesting.Controls.Add(this.comboBoxHealing);
            this.groupBoxTesting.Controls.Add(this.comboBoxPolydipsia);
            this.groupBoxTesting.Controls.Add(this.comboBoxVisual);
            this.groupBoxTesting.Controls.Add(this.comboBoxIrritability);
            this.groupBoxTesting.Controls.Add(this.comboBoxPolyuria);
            this.groupBoxTesting.Controls.Add(this.label11);
            this.groupBoxTesting.Controls.Add(this.label3);
            this.groupBoxTesting.Controls.Add(this.label9);
            this.groupBoxTesting.Controls.Add(this.comboBoxGender);
            this.groupBoxTesting.Controls.Add(this.label10);
            this.groupBoxTesting.Controls.Add(this.label1);
            this.groupBoxTesting.Controls.Add(this.label2);
            this.groupBoxTesting.Controls.Add(this.numericUpDownAge);
            this.groupBoxTesting.Enabled = false;
            this.groupBoxTesting.Location = new System.Drawing.Point(102, 6);
            this.groupBoxTesting.Name = "groupBoxTesting";
            this.groupBoxTesting.Size = new System.Drawing.Size(420, 280);
            this.groupBoxTesting.TabIndex = 3;
            this.groupBoxTesting.TabStop = false;
            this.groupBoxTesting.Text = "Testing";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(334, 244);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 5;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(258, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Obesity:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Genital Thrush:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(253, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Alopecia:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Polyphagia:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(216, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Muscle Stiffness:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Weakness:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Partial Paresis:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 9);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sudden Weight Loss:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Delayed Healing:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Polydipsia:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxThrush
            // 
            this.comboBoxThrush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxThrush.FormattingEnabled = true;
            this.comboBoxThrush.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxThrush.Location = new System.Drawing.Point(92, 207);
            this.comboBoxThrush.Name = "comboBoxThrush";
            this.comboBoxThrush.Size = new System.Drawing.Size(100, 21);
            this.comboBoxThrush.TabIndex = 4;
            // 
            // comboBoxObesity
            // 
            this.comboBoxObesity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxObesity.FormattingEnabled = true;
            this.comboBoxObesity.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxObesity.Location = new System.Drawing.Point(309, 207);
            this.comboBoxObesity.Name = "comboBoxObesity";
            this.comboBoxObesity.Size = new System.Drawing.Size(100, 21);
            this.comboBoxObesity.TabIndex = 4;
            // 
            // comboBoxAlopesia
            // 
            this.comboBoxAlopesia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlopesia.FormattingEnabled = true;
            this.comboBoxAlopesia.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxAlopesia.Location = new System.Drawing.Point(309, 180);
            this.comboBoxAlopesia.Name = "comboBoxAlopesia";
            this.comboBoxAlopesia.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAlopesia.TabIndex = 4;
            // 
            // comboBoxPolyphagia
            // 
            this.comboBoxPolyphagia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolyphagia.FormattingEnabled = true;
            this.comboBoxPolyphagia.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxPolyphagia.Location = new System.Drawing.Point(92, 180);
            this.comboBoxPolyphagia.Name = "comboBoxPolyphagia";
            this.comboBoxPolyphagia.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPolyphagia.TabIndex = 4;
            // 
            // comboBoxMuscle
            // 
            this.comboBoxMuscle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuscle.FormattingEnabled = true;
            this.comboBoxMuscle.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxMuscle.Location = new System.Drawing.Point(309, 153);
            this.comboBoxMuscle.Name = "comboBoxMuscle";
            this.comboBoxMuscle.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMuscle.TabIndex = 4;
            // 
            // comboBoxWeakness
            // 
            this.comboBoxWeakness.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWeakness.FormattingEnabled = true;
            this.comboBoxWeakness.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxWeakness.Location = new System.Drawing.Point(92, 153);
            this.comboBoxWeakness.Name = "comboBoxWeakness";
            this.comboBoxWeakness.Size = new System.Drawing.Size(100, 21);
            this.comboBoxWeakness.TabIndex = 4;
            // 
            // comboBoxParesis
            // 
            this.comboBoxParesis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParesis.FormattingEnabled = true;
            this.comboBoxParesis.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxParesis.Location = new System.Drawing.Point(309, 126);
            this.comboBoxParesis.Name = "comboBoxParesis";
            this.comboBoxParesis.Size = new System.Drawing.Size(100, 21);
            this.comboBoxParesis.TabIndex = 4;
            // 
            // comboBoxWeightLoss
            // 
            this.comboBoxWeightLoss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWeightLoss.FormattingEnabled = true;
            this.comboBoxWeightLoss.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxWeightLoss.Location = new System.Drawing.Point(92, 126);
            this.comboBoxWeightLoss.Name = "comboBoxWeightLoss";
            this.comboBoxWeightLoss.Size = new System.Drawing.Size(100, 21);
            this.comboBoxWeightLoss.TabIndex = 4;
            // 
            // comboBoxItching
            // 
            this.comboBoxItching.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItching.FormattingEnabled = true;
            this.comboBoxItching.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxItching.Location = new System.Drawing.Point(309, 45);
            this.comboBoxItching.Name = "comboBoxItching";
            this.comboBoxItching.Size = new System.Drawing.Size(100, 21);
            this.comboBoxItching.TabIndex = 4;
            // 
            // comboBoxHealing
            // 
            this.comboBoxHealing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHealing.FormattingEnabled = true;
            this.comboBoxHealing.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxHealing.Location = new System.Drawing.Point(309, 99);
            this.comboBoxHealing.Name = "comboBoxHealing";
            this.comboBoxHealing.Size = new System.Drawing.Size(100, 21);
            this.comboBoxHealing.TabIndex = 4;
            // 
            // comboBoxPolydipsia
            // 
            this.comboBoxPolydipsia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolydipsia.FormattingEnabled = true;
            this.comboBoxPolydipsia.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxPolydipsia.Location = new System.Drawing.Point(92, 99);
            this.comboBoxPolydipsia.Name = "comboBoxPolydipsia";
            this.comboBoxPolydipsia.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPolydipsia.TabIndex = 4;
            // 
            // comboBoxVisual
            // 
            this.comboBoxVisual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisual.FormattingEnabled = true;
            this.comboBoxVisual.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxVisual.Location = new System.Drawing.Point(309, 18);
            this.comboBoxVisual.Name = "comboBoxVisual";
            this.comboBoxVisual.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVisual.TabIndex = 4;
            // 
            // comboBoxIrritability
            // 
            this.comboBoxIrritability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIrritability.FormattingEnabled = true;
            this.comboBoxIrritability.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxIrritability.Location = new System.Drawing.Point(309, 72);
            this.comboBoxIrritability.Name = "comboBoxIrritability";
            this.comboBoxIrritability.Size = new System.Drawing.Size(100, 21);
            this.comboBoxIrritability.TabIndex = 4;
            // 
            // comboBoxPolyuria
            // 
            this.comboBoxPolyuria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPolyuria.FormattingEnabled = true;
            this.comboBoxPolyuria.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxPolyuria.Location = new System.Drawing.Point(92, 72);
            this.comboBoxPolyuria.Name = "comboBoxPolyuria";
            this.comboBoxPolyuria.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPolyuria.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(253, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Irritability:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Polyuria:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Visual Blurring:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(92, 45);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGender.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Itching:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Age:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(92, 19);
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownAge.TabIndex = 1;
            this.numericUpDownAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreate);
            this.groupBox1.Controls.Add(this.labelProgress);
            this.groupBox1.Controls.Add(this.buttonLoad);
            this.groupBox1.Controls.Add(this.buttonLearn);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Neural Network";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(6, 33);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelProgress
            // 
            this.labelProgress.Location = new System.Drawing.Point(6, 146);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(75, 18);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "0";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Enabled = false;
            this.buttonLoad.Location = new System.Drawing.Point(6, 62);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 0;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonLearn
            // 
            this.buttonLearn.Enabled = false;
            this.buttonLearn.Location = new System.Drawing.Point(6, 120);
            this.buttonLearn.Name = "buttonLearn";
            this.buttonLearn.Size = new System.Drawing.Size(75, 23);
            this.buttonLearn.TabIndex = 0;
            this.buttonLearn.Text = "Learn";
            this.buttonLearn.UseVisualStyleBackColor = true;
            this.buttonLearn.Click += new System.EventHandler(this.buttonLearn_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(6, 91);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialogWeights
            // 
            this.saveFileDialogWeights.DefaultExt = "wts";
            this.saveFileDialogWeights.Filter = "Weigths Files (*.wts)|*wts";
            this.saveFileDialogWeights.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialogWeights_FileOk);
            // 
            // openFileDialogWeights
            // 
            this.openFileDialogWeights.Filter = "Weigths Files (*.wts)|*wts";
            this.openFileDialogWeights.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogWeights_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(564, 396);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diabetes Risk Prediction";
            this.tabControl1.ResumeLayout(false);
            this.tabPageTest.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageAdvance.ResumeLayout(false);
            this.groupBoxAccuracy.ResumeLayout(false);
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.groupBoxTesting.ResumeLayout(false);
            this.groupBoxTesting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTest;
        private System.Windows.Forms.TabPage tabPageAdvance;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLearn;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.SaveFileDialog saveFileDialogWeights;
        private System.Windows.Forms.OpenFileDialog openFileDialogWeights;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxTesting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxThrush;
        private System.Windows.Forms.ComboBox comboBoxObesity;
        private System.Windows.Forms.ComboBox comboBoxAlopesia;
        private System.Windows.Forms.ComboBox comboBoxPolyphagia;
        private System.Windows.Forms.ComboBox comboBoxMuscle;
        private System.Windows.Forms.ComboBox comboBoxWeakness;
        private System.Windows.Forms.ComboBox comboBoxParesis;
        private System.Windows.Forms.ComboBox comboBoxWeightLoss;
        private System.Windows.Forms.ComboBox comboBoxHealing;
        private System.Windows.Forms.ComboBox comboBoxPolydipsia;
        private System.Windows.Forms.ComboBox comboBoxIrritability;
        private System.Windows.Forms.ComboBox comboBoxPolyuria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxItching;
        private System.Windows.Forms.ComboBox comboBoxVisual;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelInterpretation;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelTestAccuracy;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.GroupBox groupBoxAccuracy;
        private System.Windows.Forms.Label labelTrainAccuracy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonTakeTest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelRisk;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelRiskInterpretation;
    }
}

