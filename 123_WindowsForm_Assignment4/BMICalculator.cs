using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// Name    : Tran Huy Hoang
/// ID      : 300 979 272
/// Date Modified: 2019-07-17
/// </summary>

namespace _123_WindowsForm_Assignment4
{


    /// <summary>
    /// 
    /// </summary>
    public enum Option
    {
        kMetric,
        kImperial
    }

    /// <summary>
    /// 
    /// </summary>
    public enum BMIStyle
    {
        kUndefine,
        kUnderWeight,
        kNormal,
        kOverWeight,
        kObese
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class BMICalculator : Form
    {

        private double maxFeet = 10.0;
        private double minFeet = 0.4;

        private double maxMetres = 3.0;
        private double minMetres = 0.1;


        private double maxKg = 300;
        private double minKg = 0.1;

        private double maxPound = 661.39;
        private double minPound = 1.0;

        private double minHeight;
        private double maxHeight;
        private double minWeight;
        private double maxWeight;

        private Option _currentOption;
        string errorMessage;

        private Color resultColor = new Color();
        private BMIStyle _style;
        string bmiMessageStyle = "";


        /// <summary>
        /// 
        /// </summary>
        public BMIStyle Style {
            get {
                return _style;
            }
            set {
                _style = value;
                switch (_style)
                {
                    case BMIStyle.kUndefine:
                        bmiMessageStyle = "";
                        resultColor = Color.FromArgb(255, 255, 255);
                        resultTextBox.BackColor = resultColor;                
                        break;
                    case BMIStyle.kUnderWeight:
                        bmiMessageStyle = "which is underweight";
                        resultColor = Color.FromArgb(128, 128, 128);
                        resultTextBox.BackColor = resultColor;
                        break;
                    case BMIStyle.kNormal:
                        bmiMessageStyle = "which is normal";
                        resultColor = Color.FromArgb(144, 238, 144);
                        resultTextBox.BackColor = resultColor;
                        break;
                    case BMIStyle.kOverWeight:
                        bmiMessageStyle = "which is overweight";
                        resultColor = Color.FromArgb(253, 106, 2);
                        resultTextBox.BackColor = resultColor;
                        break;
                    case BMIStyle.kObese:
                        bmiMessageStyle = "which is obese";
                        resultColor = Color.FromArgb(194, 24, 7);
                        resultTextBox.BackColor = resultColor;
                        break;
                    default:
                        bmiMessageStyle = "";
                        resultColor = Color.White;
                        resultTextBox.BackColor = resultColor;
                        break;
                }
            }
        }

        public static class Define {
            public static string kErrorMessage = "Please input only number in field, only 1 '.' is allowed, weight should be less than 300 kg and height should be less than 3.0 metres";
        }

        /// <summary>
        /// 
        /// </summary>
        public Option currentOption {
            get {
                return _currentOption;
            }
            set {
                _currentOption = value;
                if (_currentOption == Option.kMetric)
                {
                    myHeightTextBox.WaterMarkText = "metres";
                    myWeightTextBox.WaterMarkText = "kilograms";
                    errorMessage = "Please input only number in field, only 1 '.' is allowed, weight should be less than 300 kg and height should be less than 3.0 metres";

                    myHeightTextBox.Text = "";
                    myWeightTextBox.Text = "";

                    minHeight = minMetres;
                    maxHeight = maxMetres;
                    minWeight = minKg;
                    maxWeight = maxKg;
                }
                else
                {
                    myHeightTextBox.WaterMarkText = "inches";
                    myWeightTextBox.WaterMarkText = "pounds";
                    errorMessage = "Please input only number in field, only 1 '.' is allowed, weight should be less than 661.39 pound and height should be less than 10 feet";

                    myHeightTextBox.Text = "";
                    myWeightTextBox.Text = "";

                    minHeight = minFeet;
                    maxHeight = maxFeet;
                    minWeight = minPound;
                    maxWeight = maxPound;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupLayout();
        }


        /// <summary>
        /// 
        /// </summary>
        private void SetupLayout()
        {
            currentOption = Option.kMetric;
            metricRadioButton.Checked = true;
            checkCalculateButtonStatus();

            dataTableLayout.BackColor   = Color.FromArgb(0, 255, 255, 255);
            myHeightLabel.ForeColor     = Color.White;
            myWeightLabel.ForeColor     = Color.White;
            optionLabel.ForeColor       = Color.White;
            metricRadioButton.ForeColor = Color.White;
            imperialRadioButton.ForeColor = Color.White;

        }


        #region Actions
        /// <summary>
        /// Check when user press any key for My Height Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myHeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validateKeyboardInput(sender, e)== false)
            {
                e.Handled = true;
                DialogResult dialog = MessageBox.Show(errorMessage);
            }
            checkCalculateButtonStatus();

        }


        /// <summary>
        /// Check when user press any key for My Weight Textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myWeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (validateKeyboardInput(sender, e) == false)
            {
                e.Handled = true;
                DialogResult dialog = MessageBox.Show(errorMessage);
            }
            checkCalculateButtonStatus();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentOption = Option.kMetric;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void imperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            currentOption = Option.kImperial;
        }

        #endregion



        #region Util methods
        /// <summary>
        /// 
        /// </summary>
        private void checkCalculateButtonStatus()
        {
            calculateButton.Enabled = false;

            if (myHeightTextBox.Text.Length > 0
                && myWeightTextBox.Text.Length > 0
                && double.Parse(myHeightTextBox.Text) > minHeight
                && double.Parse(myWeightTextBox.Text) > minWeight)
            {
                calculateButton.Enabled = true;
            }
            else
            {
                calculateButton.Enabled = false;
            }
        }


        /// <summary>
        /// Validate the user input for textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool validateKeyboardInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            string fullTextCheck = textBox.Text + e.KeyChar;
            if (e.KeyChar == '\b')
            {
                return true;
            }
            try
            {
                double parsedNumber = double.Parse(fullTextCheck);
                if (e.KeyChar == '.' && (textBox.Text.Contains('.')))
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

            bool validateValue = false;


            double value = double.Parse(textBox.Text + e.KeyChar);

            if (sender == myHeightTextBox && currentOption == Option.kImperial && value <= maxFeet)
            {
                validateValue = true;
            }
            else if (sender == myHeightTextBox && currentOption == Option.kMetric && value <= maxMetres)
            {
                validateValue = true;
            }

            if (sender == myWeightTextBox && currentOption == Option.kImperial && value <= maxPound)
            {
                validateValue = true;
            }
            else if (sender == myWeightTextBox && currentOption == Option.kMetric && value <= maxKg)
            {
                validateValue = true;
            }

            return validateValue;
        }
        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double calculatedHeight = double.Parse(myHeightTextBox.Text);
            double calculatedWeight = double.Parse(myWeightTextBox.Text);

            //Convert to metric value
            if (currentOption == Option.kImperial)
            {
                calculatedHeight *= .45;
                calculatedWeight *= .025;
            }

            //Calculate the BMI value
            double result = calculatedWeight / Math.Pow(calculatedHeight, 2);

            resultTextBox.Text = generateResult(result);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="BMI"></param>
        /// <returns></returns>
        private string generateResult(double BMI) {
            string result = "";
            result += $"Your BMI is {(int)BMI} ";          

            if (0 < BMI && BMI < 18.5)
            {
                Style = BMIStyle.kUnderWeight;
            }
            else if (18.5 <= BMI && BMI< 24.9)
            {
                Style = BMIStyle.kNormal;
            }
            else if (18.5 <= BMI && BMI < 24.9)
            {
                Style = BMIStyle.kOverWeight;
            }
            else
            {
                Style = BMIStyle.kObese;
            }
            result += bmiMessageStyle;

            return result;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCalculateButtonStatus();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void myWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            checkCalculateButtonStatus();
        }

    }
}
