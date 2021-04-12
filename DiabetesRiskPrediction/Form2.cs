using Backprop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabetesRiskPrediction
{
    public partial class Form2 : Form
    {
        NeuralNet neuralNet;
        double age;
        double gender;
        double polyuria;
        double polydipsia;
        double weightLoss;
        double weakness;
        double polyphagia;
        double thrush;
        double visual;
        double itching;
        double irritability;
        double healing;
        double paresis;
        double muscle;
        double alopesia;
        double obesity;
        double weight;
        double height;
        int formCounter;
        bool success;
        double bmi;
        double result;

        public Form2()
        {
            InitializeComponent();
            formCounter = 1;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (validateForm(formCounter))
            {
                recordResult(formCounter);
                formCounter++;
                radioButtonPositive.Checked = false;
                radioButtonNegative.Checked = false;
                switch (formCounter)
                {
                    case 2:
                        labelQuestion.Text = "Enter your age.";
                        radioButtonPositive.Visible = false;
                        radioButtonNegative.Visible = false;
                        numericUpDownAge.Visible = true;
                        numericUpDownAge.Text = "";
                        break;
                    case 3:
                        labelQuestion.Text = "Enter your weight.";
                        numericUpDownAge.Visible = false;
                        numericUpDownWeight.Visible = true;
                        labelKilograms.Visible = true;
                        numericUpDownWeight.Text = "";
                        break;
                    case 4:
                        labelQuestion.Text = " Enter your height.";
                        numericUpDownWeight.Visible = false;
                        labelKilograms.Visible = false;
                        comboBoxFeet.Visible = true;
                        comboBoxInches.Visible = true;
                        labelFeet.Visible = true;
                        labelInches.Visible = true;
                        break;
                    case 5:
                        labelQuestion.Text = "Is there a noticeable or unexplained drop in your body weight?";
                        comboBoxFeet.Visible = false;
                        comboBoxInches.Visible = false;
                        labelFeet.Visible = false;
                        labelInches.Visible = false;
                        radioButtonPositive.Visible = true;
                        radioButtonNegative.Visible = true;
                        radioButtonPositive.Text = "Yes";
                        radioButtonNegative.Text = "No";
                        break;
                    case 6:
                        labelQuestion.Text = "Have you experience blurredness of your vision?";
                        break;
                    case 7:
                        labelQuestion.Text = "Do you often feel hungry and tend to eat more food?";
                        break;
                    case 8:
                        labelQuestion.Text = "Do you often feel thirsty and tend to drink more water?";
                        break;
                    case 9:
                        labelQuestion.Text = "Does your body feel weak or tired?";
                        break;
                    case 10:
                        labelQuestion.Text = "Are there specific parts of your body that feels weak to move?";
                        break;
                    case 11:
                        labelQuestion.Text = "Are there certain parts of your body that feel itchy?";
                        break;
                    case 12:
                        labelQuestion.Text = "Does your hair fall out in small patches?";
                        break;
                    case 13:
                        labelQuestion.Text = "Is there tightness, difficulty, and discomfort when you move?";
                        break;
                    case 14:
                        labelQuestion.Text = "Is there itchiness or soreness around your genital?";
                        break;
                    case 15:
                        labelQuestion.Text = "Do you often urinate and with excessive amounts of urine each time?";
                        break;
                    case 16:
                        labelQuestion.Text = "Are your wounds take longer time to heal?";
                        break;
                    case 17:
                        labelQuestion.Text = "Do you easily get irritated?";
                        buttonNext.Text = "Submit";
                        formCounter = 17;
                        break;
                    case 18:
                        //submit
                        calculateResult();
                        this.DialogResult = DialogResult.OK;                        
                        break;
                }
                groupBoxQ.Text = formCounter + " of 17"; 
            }
        }

        private bool validateForm(int formCounter)
        {
            if (formCounter > 4)
            {
                if (radioButtonPositive.Checked == radioButtonNegative.Checked)
                {
                    MessageBox.Show("Please select your answer.");
                    return false;
                }
            }
            else if (formCounter == 1)
            {
                if (radioButtonPositive.Checked == radioButtonNegative.Checked)
                {
                    MessageBox.Show("Please select your answer.");
                    return false;
                }
            }
            else if (formCounter == 2)
            {
                if (numericUpDownAge.Text == "")
                {
                    MessageBox.Show("Please select your answer.");
                    return false;
                }
            }
            else if (formCounter == 3)
            {
                if (numericUpDownWeight.Text == "")
                {
                    MessageBox.Show("Please select your answer.");
                    return false;
                }
            }
            else if (formCounter == 4)
            {
                if (comboBoxFeet.Text == "" || comboBoxInches.Text == "")
                {
                    MessageBox.Show("Please select your answer.");
                    return false;
                }
            }
            return true;
        }

        private void recordResult(int formCounter)
        {
            switch (formCounter)
            {
                case 1:
                    gender = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 2:
                    age = Convert.ToDouble(numericUpDownAge.Value);
                    break;
                case 3:
                    weight = Convert.ToDouble(numericUpDownWeight.Value);   //kilograms
                    break;
                case 4:
                    int feet = Convert.ToInt32(comboBoxFeet.SelectedItem);
                    int inches = Convert.ToInt32(comboBoxInches.SelectedItem);
                    height = (feet * 12 + inches) * 0.0254; //meters
                    bmi = weight / (height * height);
                    obesity = bmi >= 30.0 ? 1.0 : -1.0;
                    break;
                case 5:
                    weightLoss = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 6:
                    visual = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 7:
                    polyphagia = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 8:
                    polydipsia = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 9:
                    weakness = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 10:
                    paresis = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 11:
                    itching = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 12:
                    alopesia = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 13:
                    muscle = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 14:
                    thrush = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 15:
                    polyuria = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 16:
                    healing = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
                case 17:
                    irritability = radioButtonPositive.Checked == true ? 1.0 : -1.0;
                    break;
            }
        }

        private void calculateResult()
        {
            neuralNet = new NeuralNet(16, 50, 1);
            try
            {
                string filepath = System.AppDomain.CurrentDomain.BaseDirectory + "weights100.wts";
                neuralNet.loadWeights(@filepath);
            }
            catch
            {
                MessageBox.Show("Weights file not found.");
                success = false;
                return;
            }
            neuralNet.setInputs(0, neuralNet.sigmoid(age));
            neuralNet.setInputs(1, gender);
            neuralNet.setInputs(2, polyuria);
            neuralNet.setInputs(3, polydipsia);
            neuralNet.setInputs(4, weightLoss);
            neuralNet.setInputs(5, weakness);
            neuralNet.setInputs(6, polyphagia);
            neuralNet.setInputs(7, thrush);
            neuralNet.setInputs(8, visual);
            neuralNet.setInputs(9, itching);
            neuralNet.setInputs(10, irritability);
            neuralNet.setInputs(11, healing);
            neuralNet.setInputs(12, paresis);
            neuralNet.setInputs(13, muscle);
            neuralNet.setInputs(14, alopesia);
            neuralNet.setInputs(15, obesity);
            neuralNet.run();
            result = neuralNet.getOuputData(0);
            success = true;
        }

        public bool isSuccessful()
        {
            return success;
        }

        public double getResult()
        {
            return result;
        }

        public double getBMI()
        {
            return bmi;
        }
    }
}