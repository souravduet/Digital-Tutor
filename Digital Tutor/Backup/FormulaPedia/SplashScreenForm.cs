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
    public partial class SplashScreenForm : Form
    {
        int a = 0;
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            
        }

        private void splashTimer_Tick(object sender, EventArgs e)
        {


            if (a == 1)
            {
                SplashScreenForm.ActiveForm.Hide();
                Form mForm = new MainForm();
                mForm.Show();
                splashTimer.Enabled=false ;
                
            }
            else
                a += 1;
        }

      
    }
}
