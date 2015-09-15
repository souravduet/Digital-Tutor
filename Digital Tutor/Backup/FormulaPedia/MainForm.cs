using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FormulaPedia
{
    public partial class MainForm : Form
    {

        //---------------------GLOBAL VARIABLES---------------------------------------


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public string postExp;
        bool t = true;
        public Stack<string> unknownValu = new Stack<string>();
        public int lenExp = 0;
        public Stack<double> s = new Stack<double>();
        public string temp;
        public string output;
        public string outputTemp;
        //public Stack<char> s2;
        //int funcVal = 1;



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mathTab.Width = 700;
            mathTab.Height = 484;
            mathTab.Visible = false;
            mathTab.Left = 181;
            mathTab.Top = 120;



            phyTab.Width = 700;
            phyTab.Height = 484;
            phyTab.Visible = false;
            phyTab.Left = 181;
            phyTab.Top = 120;

            chemTab.Height = 484;
            chemTab.Width = 700;
            chemTab.Visible = false;
            chemTab.Left = 181;
            chemTab.Top = 120;

            engTab.Height = 484;
            engTab.Width = 700;
            engTab.Visible = false;
            engTab.Left = 181;
            engTab.Top = 120;


        }

        private void mathBtn_Click(object sender, EventArgs e)
        {
            mathTab.Visible = true;
            phyTab.Visible = false;
            chemTab.Visible = false;
            engTab.Visible = false;
        }





        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            resultList.Items.Clear();
            resulltTxtBox.Clear();

            if (t == true)
            {
                output = exprTxtBox.Text;
                unknownValueFind();
                //convertPostfix();

            }

            if (unknownValu.Count() == 0)
            {
                mainPart();

                postExp = null;
                s.Clear();
                unknownValu.Clear();
            }
            resLbl.Text = "Result";
        }




        //---------------------------------------ALGEBRAIC SOLUTION OF FUNCTION------------------------------------------


        int op_preced(char c)
        {
            switch (c)
            {
                case '^':
                    return 4;
                case '*':
                case '/':
                case '%':
                    return 3;
                case '+':
                case '-':
                    return 2;
                case '=':
                    return 1;
            }
            return 0;
        }

        int op_arg_count(char c)
        {
            switch (c)
            {
                case '*':
                case '/':
                case '%':
                case '+':
                case '-':
                case '^':
                    return 2;
            }
            return 0;
        }

        void convertPostfix()
        {
            int i, len;
            Stack<char> s2 = new Stack<char>();
            char ch;
            string str;
            str = output;//input from text box
            len = str.Length;
            str += ")";
            s2.Push('(');
            for (i = 0; i <= len; i++)
            {
                ch = str[i];
                if (ch == '(')
                {
                    s2.Push(ch);
                }
                else if (op_arg_count(ch) == 2)
                {
                    postExp += " ";
                    if (s2.First() != '(' && s2.Count() > 0)
                    {
                        while (true)
                        {
                            if (op_preced(ch) > op_preced(s2.First()))
                            {
                                s2.Push(ch);
                                //postExp+=ch;
                                //postExp+=" ";
                                break;
                            }
                            else
                            {
                                postExp += s2.First();
                                postExp += " ";
                                s2.Pop();
                                if (s2.Count() == 0)
                                {
                                    s2.Push(ch);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        s2.Push(ch);
                    }
                }
                else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || (ch >= '0' && ch <= '9') || ch == '.')
                {
                    postExp += ch;
                }
                else if (ch == ')')
                {
                    if (s2.First() == '(')
                        s2.Pop();
                    else
                    {
                        while (s2.First() != '(')
                        {
                            postExp += " ";
                            postExp += s2.First();
                            s2.Pop();
                        }
                        if (s2.Count() > 0)
                            s2.Pop();
                    }

                }
            }
        }








        // main part of evaluation of infx.................................................................

        private void mainPart()
        {
            convertPostfix();
            //  MessageBox.Show("post " + postExp + " len = " + postExp.Length.ToString());
            calculationPart();


        }


        public void unknownValueFind()
        {


            char[] str = new char[100];
            int j = 0, aw = 0, lopCoun;
            lenExp = output.Length;//Cuse lenExp er man degun hosschilo tai
            /**********************Unknown Variable Found Part****************/
            temp = "";
            while (j < lenExp)
            {
                lopCoun = 0;
                for (j = aw; op_arg_count(output[j]) != 2 && (output[j] != ' ' && output[j] != '(' || output[j] != ')'); )
                {
                    temp += output[j];
                    lopCoun++; j++;
                    if (j >= lenExp) break;
                }
                aw += lopCoun + 1;
                if (temp != "")
                    if ((temp[0] >= 'a' && temp[0] <= 'z') || (temp[0] >= 'A' && temp[0] <= 'Z'))
                    {
                        unknownValu.Push(temp);
                    }
                temp = "";
            }
            /////Input value of unknown variable
            if (unknownValu.Count() > 0)
            {
                t = false;
                unknownValueShowLabel.Text = "Please Enter the Value of " + unknownValu.First();
                unknownValueShowLabel.Visible = true;
                unknownValueInputTextBox.Visible = true;
                okButton.Visible = true;
                algebraCalculateBtn.Enabled = false;


                return;
            }
        }

        public void calculationPart()
        {
            int c = 0;
            double sum = 0, n, m;

            int j = 0, aw = 0, lopCoun;
            lenExp = postExp.Length;//Cuse lenExp er man degun hosschilo tai
            /**********************Calculation Part*****************************/
            temp = "";
            lenExp = postExp.Length;
            c = 0; aw = 0; j = 0;
            while (j < lenExp)
            {

                c++;
                lopCoun = 0;

                for (j = aw; postExp[j] != ' '; )
                {

                    temp += postExp[j];
                    lopCoun++; j++;
                    if (j >= lenExp) break;
                }

                aw += lopCoun + 1;
                //MessageBox.Show(temp+ ", " +lenExp);

                //printf("| (%d)\t%s\t      ", c, temp);
                //resultListBox.Items.Add("| " + c + "\t" + temp + "\t|");
                if (temp != null)
                    if (temp[0] > 47 && temp[0] < 58)
                    {
                        sum = 0;
                        /* for ( int kj = 0; temp; kj++)
                         {
                             sum = 10 * sum + (temp[kj] - 48);
                         }*/
                        sum = double.Parse(temp);
                        s.Push(sum);

                    }
                    else
                    {
                        n = s.First();
                        s.Pop();
                        if (s.Count() == 0)
                        {
                            //printf("\n\nYour expression is incorrect\n\n");
                            MessageBox.Show("Expression Error !");
                        }
                        else
                        {
                            m = s.First();
                            s.Pop();
                            switch (temp[0])
                            {
                                case '+':
                                    s.Push(m + n);
                                    break;
                                case '-':
                                    s.Push(m - n);
                                    break;
                                case '*':
                                    s.Push(m * n);
                                    break;
                                case '/':
                                    s.Push(m / n);
                                    break;
                                case '^':
                                    s.Push((int)Math.Pow(m, n));
                                    break;
                            }
                            outputFormat(n, m);
                            resultList.Items.Add(" = " + output);
                        }
                    }
                // printf("| %d\t           |\n", s.top());

                temp = null;

            }

            //printf("|---------------------|--------------------|\n");
            // printf("\nThe Postfix Expression result is : %d\n\n\n",s.top());
            //expTextBox.Text = s.First().ToString();
            resultList.Items.Add(" ");
            resultList.Items.Add("The Expression result is :  " + s.First().ToString());
            t = true;
        }

        private void outputFormat(double n, double m)
        {

            int outputStartLen;
            outputTemp += m.ToString();
            outputTemp += temp[0];
            outputTemp += n.ToString();
            outputStartLen = output.IndexOf(outputTemp, 0, output.Length);
            //MessageBox.Show(o
            if (outputStartLen > -1)
            {
                output = output.Remove(outputStartLen, outputTemp.Length);

                int ut = output.IndexOf("()", 0, output.Length);
                if (ut > -1)
                {
                    output = output.Remove(ut, 2);

                    if (output == "")
                        output += s.First().ToString();
                    else
                        output = output.Insert(outputStartLen - 1, s.First().ToString());
                }
                else
                {
                    output = output.Insert(outputStartLen, s.First().ToString());
                }
                outputTemp = null;
            }
        }

        public void unknownReplace()
        {
            // int outputStartLen;
            int outputStartLen2;

            if (unknownValu.Count() > 0)
            {

                /* outputStartLen = postExp.IndexOf(unknownValu.First(), 0, postExp.Length);

                 if (outputStartLen > -1)
                 {
                     postExp = postExp.Remove(outputStartLen, unknownValu.First().Length);
                     postExp = postExp.Insert(outputStartLen, unknownValueInputTextBox.Text);
                 }*/

                outputStartLen2 = output.IndexOf(unknownValu.First(), 0, output.Length);
                if (outputStartLen2 > -1)
                {
                    output = output.Remove(outputStartLen2, unknownValu.First().Length);
                    output = output.Insert(outputStartLen2, unknownValueInputTextBox.Text);
                }
                unknownValu.Pop();

                if (unknownValu.Count() == 0)
                    algebraCalculateBtn.Enabled = true;

            }

        }


        private void categoriComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void phyBtn_Click(object sender, EventArgs e)
        {
            mathTab.Visible = false;
            phyTab.Visible = true;
            chemTab.Visible = false;
            engTab.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mathTab.Visible = false;
            phyTab.Visible = false;
            chemTab.Visible = true;
            engTab.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mathTab.Visible = false;
            phyTab.Visible = false;
            chemTab.Visible = false;
            engTab.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (unknownValueInputTextBox.Text != null && unknownValu.Count() != 0)
            {

                unknownReplace();
                if (unknownValu.Count() > 0)
                {
                    unknownValueShowLabel.Text = "Please Enter the Value of " + unknownValu.First();

                }
                else
                {
                    okButton.Enabled = false;
                }
                unknownValueInputTextBox.Text = null;
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //System.IO.StreamWriter mFile = new System.IO.StreamWriter( "savedFormula.txt");
            //mFile.a(exprTxtBox.Text + "\n");
            //mFile.Close();

            System.IO.File.AppendAllText(@"C:\Users\jahid\Desktop\Upgraded\FormulaPedia\FormulaPedia\bin\Debug\savedFormula.txt", exprTxtBox.Text + "\n");
            MessageBox.Show("Equation has been added to the list !", "Information");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            resultList.Items.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\jahid\Desktop\Upgraded\FormulaPedia\FormulaPedia\bin\Debug\savedFormula.txt");
            string fLine;
            

            while ((fLine=file.ReadLine())!=null )
          
                resultList.Items.Add(fLine);
         
        
           file.Close();
            
            resLbl.Text = "Saved Formula List";
        }


        //----------------------------------------END OF ALGEBRIC SOLUTION PART--------------------------------------


        private void resLbl_Click()
        {

        }

        private void resultList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultList_DoubleClick(object sender, EventArgs e)
        {
            exprTxtBox.Text = resultList.SelectedItem.ToString();
        }
    }
}
