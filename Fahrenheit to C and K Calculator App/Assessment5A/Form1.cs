using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment5A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            double TemperatureInFahrenheit;
            double TemperatureInCelsius;
            double TemperatureInKelvin;
            //declaring constant, according to the formula of conversion from F to C:(F - 32) * 5/9=C
            //the constant FIVE_BY_NINE_DEVISION = 5/9 = 0.5556
            const double FIVE_BY_NINE_DEVISION = 0.5556;

            try
            {
                if (txtBoxTempInFahrenheit.Text == "") {
                    MessageBox.Show("Please enter a Temperature! This field cannot be empty"); //show error message
                    txtBoxTempInFahrenheit.Focus();
                }
                //testing the entry of the user should be double
               else if (Double.TryParse(txtBoxTempInFahrenheit.Text, out TemperatureInFahrenheit))
                {
                    TemperatureInCelsius = (TemperatureInFahrenheit - 32) * FIVE_BY_NINE_DEVISION; // converting the T according to the formula of conversion from F to C
                    TemperatureInKelvin = TemperatureInCelsius + 273; // converting the T according to the formula of conversion from C to K
                    lblOutputCelsius.Text = TemperatureInCelsius.ToString() + " ° C"; //display the T in C
                    lblOutputKelvin.Text = TemperatureInKelvin.ToString() + " ° K"; //display the T in K
                }
                else
                {
                    //if the entry is not a numeric/double/non valid value
                    MessageBox.Show("Please enter a valid Temperature in Fahrenheit (Only numbers are accepted)"); //show error message
                    txtBoxTempInFahrenheit.Focus(); //focus on the T in F entry 
                }
            }
             catch(Exception ex){
                //Display the Default error Message
                MessageBox.Show(ex.Message);
            }
            }
        private void Form1_Load(object sender, EventArgs e)
        {
            //declare variables
            const int WATER_FREEZING_TEMPERATURE = 32;
            const int WATER_BOILING_TEMPERATURE = 212;
            double TemperatureOfWaterInFahrenheit;
            double TemperatureOfWaterInCelsius;
            double TemperatureOfWaterInKelvin;
            //declaring constant, according to the formula of conversion from F to C:(F - 32) * 5/9=C
            //the constant FIVE_BY_NINE_DEVISION = 5/9 = 0.5556
            const double FIVE_BY_NINE_DEVISION = 0.5556;
            int wft; //waterfreezingtemperature STARTING THE LOOP FROM HERE
          
            //Use the loop to calculate and show the chart of conversion of the Temperature T from F to C to K
            for(wft = WATER_FREEZING_TEMPERATURE; wft <= WATER_BOILING_TEMPERATURE; wft++)
            {
                TemperatureOfWaterInFahrenheit = wft;
                TemperatureOfWaterInCelsius = (wft - 32) * FIVE_BY_NINE_DEVISION;
                TemperatureOfWaterInKelvin = TemperatureOfWaterInCelsius + 273;
                TemperatureChartListBox.Items.Add(TemperatureOfWaterInFahrenheit + " is equal to "+ TemperatureOfWaterInCelsius+ " ° C, and equal to " + TemperatureOfWaterInKelvin + "  ° K");
               
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //if the form is already empty and the user hit the reset button
            if (txtBoxTempInFahrenheit.Text == "" && lblOutputCelsius.Text == "" && lblOutputKelvin.Text == "")
            {
                MessageBox.Show("The form is already reseted!");
            }
            else
            {
                txtBoxTempInFahrenheit.Text = ""; //clear the textBox
                lblOutputCelsius.Text = ""; //clear the label of the output for the Celsius T
                lblOutputKelvin.Text = ""; //clear the label of the output for the Kelvin T
                txtBoxTempInFahrenheit.Focus(); //focus on the text box inout for Fahrenheit T
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
