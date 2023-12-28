using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConversion
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

        private void btn_farhenheight_Click(object sender, EventArgs e)
        {
            convertFromFarhenheight();
        }

        private void btn_celsius_Click(object sender, EventArgs e)
        {
            convertFromCelsius();
        }

        private void btn_kelvin_Click(object sender, EventArgs e)
        {
            convertFromKelvin();
        }

        private void convertFromFarhenheight()
        {
            float f = 0;

            try
            {
                f = float.Parse(txt_farhenheight.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float c = 5f / 9 * (f - 32);
            float k = c - 273;


            txt_celsius.Text = c.ToString();
            txt_kelvin.Text = k.ToString();
        }
        private void convertFromCelsius()
        {
            float c = 0;

            try
            {
                c = float.Parse(txt_celsius.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float f = c * 9f / 5 + 32;
            float k = c - 273;

            txt_farhenheight.Text = f.ToString();
            txt_kelvin.Text = k.ToString();
        }
        private void convertFromKelvin()
        {
            float k = 0;

            try
            {
                k = float.Parse(txt_kelvin.Text);
            }
            catch
            {
                MessageBox.Show("Try only numbers");
            }

            float f = 1.8f * (k - 273.15F) + 32f;
            float c = k - 273.15f;

            txt_farhenheight.Text = f.ToString();
            txt_celsius.Text = c.ToString();
        }

        private void onTextChange(object sender, EventArgs e)
        {
            
        }

        
    }
}