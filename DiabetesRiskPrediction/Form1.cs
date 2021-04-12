using Backprop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiabetesRiskPrediction
{
    public partial class Form1 : Form
    {
        NeuralNet neuralNet;        

        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label3, "Polyuria is a condition where the body urinates more than usual.");
            toolTip1.SetToolTip(label4, "Polydipsia is excessive thirst or excess drinking.");
            toolTip1.SetToolTip(label5, "Sudden weight loss is a noticeable drop in body weight.");
            toolTip1.SetToolTip(label6, "Weakness is a lack of muscle strength.");
            toolTip1.SetToolTip(label7, "Polyphagia is an abnormally strong sensation of hunger or desire to eat often.");
            toolTip1.SetToolTip(label8, "Genital thrush is a yeast infection causing itchiness around the genital.");
            toolTip1.SetToolTip(label9, "Visual blurring is a decreased visual clarity of gradual onset.");
            toolTip1.SetToolTip(label10, "Itching is an irritating sensation that makes you want to scratch your skin.");
            toolTip1.SetToolTip(label11, "Extreme irritability, or feeling irritable for an extended period.");
            toolTip1.SetToolTip(label12, "Delayed Healing is where the injuries heal slowly, or may not heal at all.");
            toolTip1.SetToolTip(label13, "Partial Paresis involves the weakening of a muscle or group of muscles.");
            toolTip1.SetToolTip(label14, "Muscle stiffness is when your muscles feel tight and you find it more difficult to move.");
            toolTip1.SetToolTip(label15, "Alopecia is a condition that causes hair to fall out in small patches.");
            toolTip1.SetToolTip(label16, "Obesity is a complex disease involving an excessive amount of body fat.");
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            neuralNet = new NeuralNet(16, 50, 1);
            buttonSave.Enabled = buttonLoad.Enabled = buttonLearn.Enabled = true;
            groupBoxAccuracy.Enabled = groupBoxTesting.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogWeights.ShowDialog();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialogWeights.ShowDialog();
        }

        private void saveFileDialogWeights_FileOk(object sender, CancelEventArgs e)
        {
            neuralNet.saveWeights(saveFileDialogWeights.FileName);
            MessageBox.Show("Weights saved.");
        }

        private void openFileDialogWeights_FileOk(object sender, CancelEventArgs e)
        {
            neuralNet.loadWeights(openFileDialogWeights.FileName);
            MessageBox.Show("Weights loaded.");
        }

        private void buttonLearn_Click(object sender, EventArgs e)
        {
            try
            {
                //string[] lines = Properties.Resources.Diabetes_Train.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                string[] lines = Properties.Resources.Diabetes_Data.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                const int epochs = 6000;
                for (int t = 0; t < epochs; t++)   //number of epochs
                {
                    for (int i = 0; i < lines.Length; i++)  //number of dataset entries
                    {
                        string[] fields = lines[i].Split(',');
                        for (int x = 0; x < 16; x++)    //number of input variables
                        {
                            double data = getEquivalentValue(fields[x]);
                            neuralNet.setInputs(x, data);
                        }
                        double outputVariable = getExpectedOutput(fields[fields.Length - 1]);    //output variable
                        neuralNet.setDesiredOutput(0, outputVariable);
                        neuralNet.learn();
                    }   //end of lines
                    labelProgress.Text = t+1 + " of " + epochs;
                    labelProgress.Refresh();
                }   //end of epochs
            }
            catch
            {
                MessageBox.Show("Error loading file.");
            }
        }

        private double getEquivalentValue(string input)
        {
            if (input == "Yes")
            {
                return 1.0;
            }
            else if(input == "No")
            {
                return -1.0;
            }
            else if (input == "Male")
            {
                return 1.0;
            }
            else if (input == "Female")
            {
                return -1.0;
            }
            else if (isAge(input))
            {
                return neuralNet.sigmoid(Convert.ToDouble(input));
            }
            else
            {
                MessageBox.Show("Invalid input encountered." + input);
                return -1;
            }
        }

        private double getExpectedOutput(string expected)
        {
            if (expected == "Positive")
                return 1.0;
            else
                return -1.0;
        }

        private bool isAge(string s)
        {
            return int.TryParse(s, out int i);
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            double age = (int)numericUpDownAge.Value;
            double gender = comboBoxGender.Text == "Male" ? 1.0 : -1.0;
            double polyuria = comboBoxPolyuria.Text == "Yes" ? 1.0 : -1.0;
            double polydipsia = comboBoxPolydipsia.Text == "Yes" ? 1.0 : -1.0;
            double weightLoss = comboBoxWeightLoss.Text == "Yes" ? 1.0 : -1.0;
            double weakness = comboBoxWeakness.Text == "Yes" ? 1.0 : -1.0;
            double polyphagia = comboBoxPolyphagia.Text == "Yes" ? 1.0 : -1.0;
            double thrush = comboBoxThrush.Text == "Yes" ? 1.0 : -1.0;
            double visual = comboBoxVisual.Text == "Yes" ? 1.0 : -1.0;
            double itching = comboBoxItching.Text == "Yes" ? 1.0 : -1.0;
            double irritability = comboBoxIrritability.Text == "Yes" ? 1.0 : -1.0;
            double healing = comboBoxHealing.Text == "Yes" ? 1.0 : -1.0;
            double paresis = comboBoxParesis.Text == "Yes" ? 1.0 : -1.0;
            double muscle = comboBoxMuscle.Text == "Yes" ? 1.0 : -1.0;
            double alopesia = comboBoxAlopesia.Text == "Yes" ? 1.0 : -1.0;
            double obesity = comboBoxObesity.Text == "Yes" ? 1.0 : -1.0;
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
            labelOutput.Text = "" + neuralNet.getOuputData(0);
            labelInterpretation.Text = neuralNet.getOuputData(0) * 10 > 5.0 ? "High Risk" : "Low Risk";
            groupBoxResults.Enabled = true;
        }

        private double testAccuracy(string filepath)
        {
            try
            {
                string[] lines = filepath.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
                int correct = 0;
                for (int i = 0; i < lines.Length; i++)  //number of dataset entries
                {
                    string[] fields = lines[i].Split(',');
                    for (int x = 0; x < 16; x++)    //number of input variables
                    {
                        double data = getEquivalentValue(fields[x]);
                        neuralNet.setInputs(x, data);
                    }
                    double expectedOutput = getExpectedOutput(fields[fields.Length - 1]);    //output variable
                    neuralNet.run();
                    double actualOutput = neuralNet.getOuputData(0) * 10;
                    actualOutput = actualOutput > 5.0 ? 1.0 : -1.0;
                    if (actualOutput == expectedOutput) correct++;
                }   //end of entries
                return (double)correct / lines.Length;
            }
            catch
            {
                MessageBox.Show("Error loading file.");
                return -1;
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            double accuracy = testAccuracy(Properties.Resources.Diabetes_Data);
            labelTrainAccuracy.Text = (int)(accuracy*100) + "%";
            //double accuracy = testAccuracy(Properties.Resources.Diabetes_Train);
            //labelTrainAccuracy.Text = (int)(accuracy * 100) + "%";
            //accuracy = testAccuracy(Properties.Resources.Diabetes_Test);
            //labelTestAccuracy.Text = (int)(accuracy * 100) + "%";
        }

        private void buttonTakeTest_Click(object sender, EventArgs e)
        {
            labelRisk.Text = "N/A";
            labelRiskInterpretation.Text = "N/A";
            Form2 form2 = new Form2();  //diabetes risk test
            form2.ShowDialog();
            if(form2.DialogResult == DialogResult.OK)
            {
                if (form2.isSuccessful())
                {
                    MessageBox.Show("Thank you for answering the test!" +
                                "\nYou can view the results in the Results Panel.");
                    labelRisk.Text = form2.getResult() + "";
                    labelRiskInterpretation.Text = form2.getResult() * 10 > 5.0 ? "High Risk" : "Low Risk"; 
                }
                else
                {
                    MessageBox.Show("Error encountered");
                }
            }
        }
    }
}