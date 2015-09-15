using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormulaPedia
{
    public partial class conversionForm : Form
    {
        public int f, t;
        public double result = 0.0, formT;
        public conversionForm()
        {
            result = 0.0;
            InitializeComponent();
        }




        private void conversionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form mainForms = new MainForm();
            mainForms.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Form mainForms = new MainForm();
            conversionForm.ActiveForm.Close();
            mainForms.Show();
        }

        private void resultConvertCextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fromTextBox_TextChanged(object sender, EventArgs e)
        {
            //double result=0.0,formT;
            //int f,t;
            //resultConvertCextBox.Text = fromTextBox.Text;
            if (fromTextBox.Text != "")
            {
                formT = Double.Parse(fromTextBox.Text);
                f = fromConvertComboBox.SelectedIndex;
                t = toConvertComboBox.SelectedIndex;
                //MessageBox.Show(f.ToString());
                if (f == t||(f==-1&&t==-1))
                    result = formT;
                else
                    switch (categoriComboBox.SelectedIndex)
                    {
                        case 0:
                                lengthConverter();
                                break;
                        case 1:
                                temperatureConverter();
                                break;
                     }//End form comboobox switch
                resultConvertCextBox.Text = result.ToString();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Form convFrm = new conversionForm();
            convFrm.Left += 100;
            convFrm.Top +=100;
            MessageBox.Show("Form not movable, lol :p");
        }

        private void categoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(categoriComboBox.SelectedIndex.ToString() );
            fromConvertComboBox.Items.Clear();
            toConvertComboBox.Items.Clear();
            fromConvertComboBox.Text = "";
            toConvertComboBox.Text = "";
            switch (categoriComboBox.SelectedIndex)
            {
                case 0:
                    fromConvertComboBox.SelectedText = "Kilometere";
                    fromConvertComboBox.Items.Add("Kilometere");
                    fromConvertComboBox.Items.Add("Meter");
                    fromConvertComboBox.Items.Add("Centimeter");
                    fromConvertComboBox.Items.Add("Millimeter");
                    fromConvertComboBox.Items.Add("Mile");
                    fromConvertComboBox.Items.Add("Yard");
                    fromConvertComboBox.Items.Add("Foot");
                    fromConvertComboBox.Items.Add("Inch");
                    fromConvertComboBox.Items.Add("Nautical Mile");

                    toConvertComboBox.SelectedText = "Kilometre";
                    toConvertComboBox.Items.Add("Kilometere");
                    toConvertComboBox.Items.Add("Meter");
                    toConvertComboBox.Items.Add("Centimeter");
                    toConvertComboBox.Items.Add("Millimeter");
                    toConvertComboBox.Items.Add("Mile");
                    toConvertComboBox.Items.Add("Yard");
                    toConvertComboBox.Items.Add("Foot");
                    toConvertComboBox.Items.Add("Inch");
                    toConvertComboBox.Items.Add("Nautical Mile");


                    break;

                case 1:
                    fromConvertComboBox.SelectedText = "Celsius";
                    fromConvertComboBox.Items.Add("Celsius");
                    fromConvertComboBox.Items.Add("Fahrenheit");
                    fromConvertComboBox.Items.Add("Kelvin");

                    toConvertComboBox.SelectedText = "Celsius";
                    toConvertComboBox.Items.Add("Celsius");
                    toConvertComboBox.Items.Add("Fahrenhei");
                    toConvertComboBox.Items.Add("Kelvin");

                    break;


            }
        }

        public void lengthConverter()
        {
            switch (f)
                                    {
                                        case -1:
                                        case 0:
                                                switch (t)
                                                {
                                                    case 1:
                                                        result = formT * 1000.0;
                                                        break;
                                                    case 2:
                                                        result = formT * (1000.0 * 100);
                                                        break;
                                                    case 3:
                                                        result = formT * (1000.0 * 100 * 10);
                                                        break;
                                                    case 4:
                                                        result = formT / (1.609344);
                                                        break;
                                                    case 5:
                                                        result = formT / (1.093613290);
                                                        break;
                                                }
                                                break;//case 0

                                        case 1:
                                                switch (t)
                                                {
                                                    case -1:
                                                    case 0:
                                                        result = formT / 1000.0;
                                                        break;
                                                    case 2:
                                                        result = formT * 100;
                                                        break;
                                                    case 3:
                                                        result = formT * 10*100;
                                                        break;
                                                    case 4:
                                                        result = formT / (1.609344 * 1000);
                                                        break;
                                                    case 5:
                                                        result = formT * 1000 / (1.093613290 * 1000);
                                                        break;
                                                }
                                                break;

                                        case 2:
                                                switch (t)
                                                {
                                                    case -1:
                                                    case 0:
                                                        result = formT / (1000.0*100);
                                                        break;
                                                    case 1:
                                                        result = formT / 100;
                                                        break;
                                                    case 3:
                                                        result = formT * 10;
                                                        break;
                                                    case 4:
                                                        result = formT / (1.609344 * 1000*100);
                                                        break;
                                                    case 5:
                                                        result = formT * 1000 / (1.093613290 * 1000*100);
                                                        break;
                                                }
                                                break;

                                    case 3:
                                                switch (t)
                                                {
                                                    case -1:
                                                    case 0:
                                                        result = formT / (1000.0*100*10);
                                                        break;
                                                    case 1:
                                                        result = formT / 100*10;
                                                        break;
                                                    case 2:
                                                        result = formT / 10;
                                                        break;
                                                    case 4:
                                                        result = formT / (1.609344 * 1000*100*10);
                                                        break;
                                                    case 5:
                                                        result = formT * 1000 / (1.093613290 * 1000*100*10);
                                                        break;
                                                }
                                                break;
                                        case 4:

                                                switch (t)
                                                {
                                                    case -1:
                                                    case 0:
                                                        result = formT *1.609344;
                                                        break;
                                                    case 1:
                                                        result = formT *1.609344*1000;
                                                        break;
                                                   case 2:
                                                        result = formT *1.609344 * 1000*100;
                                                        break;
                                                    case 3:
                                                        result = formT *1.609344*1000*100*10;
                                                        break;
                                                
                                                    case 5:
                                                        result = (formT *1.609344)/1.093613290;
                                                        break;
                                                }
                                                break;
                                    }//End form comboobox switch
        }


        public void temperatureConverter()
        {
            switch (f)
            {
                case -1:
                case 0:
                    switch (t)
                    {
                        case 1:
                            result = ((formT *9)/5.0)+32; ;
                            break;
                        case 2:
                            result = (formT *4.0)/5.0;
                            break;
                       
                    }
                    break;//case 0

                case 1:
                    switch (t)
                    {
                        case -1:
                        case 0:
                            result = (formT-32)*5.0/9.0;
                            break;
                        case 2:
                            result = (formT - 32) * 4.0 / 9.0;
                            break;
                        
                    }
                    break;

                case 2:
                    switch (t)
                    {
                        case -1:
                        case 0:
                            result = (formT *5.0)/4.0;
                            break;
                        case 1:
                            result = ((formT*9)/4.0)+32;
                            break;          
                    }
                    break;        
            }//End form comboobox switch
        }

        private void fromConvertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toConvertComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
