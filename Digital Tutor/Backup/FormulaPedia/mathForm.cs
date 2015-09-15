using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.Common;

namespace FormulaPedia
{
    public partial class mathForm : Form
    {
        public string postExp;
        bool t = true;
        public Stack<string> unknownValu = new Stack<string>();
        public int lenExp=0;
        public Stack<double> s = new Stack<double>();
         public string temp;
        public string output;
        public string outputTemp;
        //public Stack<char> s2;
        int funcVal=1;
        public mathForm()
       
        {
            InitializeComponent();
            
        }

        private void mathForm_Load(object sender, EventArgs e)
        {

        }

        private void mathForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form mainForms = new MainForm();
            mainForms.Show();
        }

        public void addTxtBox_Click(object sender, EventArgs e)
        {
            signLbl.Text = "+";
            funcVal = 1;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Addition";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = true;
            label8.Text = "Value of X";
            label9.Text = "Value of Y";
            
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            try
            {

                switch (funcVal)
                {
                    case 1:
                        resulltTxtBox.Text = (Double.Parse(firstValTxtBox.Text) + Double.Parse(secondValTxtBox.Text)).ToString();
                        break;

                    case 2:
                        resulltTxtBox.Text = (Double.Parse(firstValTxtBox.Text) - Double.Parse(secondValTxtBox.Text)).ToString();
                        break;
                    case 3:
                        resulltTxtBox.Text = (Double.Parse(firstValTxtBox.Text) * Double.Parse(secondValTxtBox.Text)).ToString();
                        break;
                    case 4:
                        resulltTxtBox.Text = (Double.Parse(firstValTxtBox.Text) / Double.Parse(secondValTxtBox.Text)).ToString();
                        break;
                    case 5:
                        resulltTxtBox.Text = (Math.Pow(Double.Parse(firstValTxtBox.Text), Double.Parse(secondValTxtBox.Text))).ToString();
                        break;
                    case 6:
                        resulltTxtBox.Text = (Math.Log(Double.Parse(firstValTxtBox.Text))).ToString();
                        break;
                    case 7:
                        resulltTxtBox.Text = (Math.Log10(Double.Parse(firstValTxtBox.Text))).ToString();
                        break;
                    case 8:
                        double fact = 1;
                        for (double i = 2; i <= (Double.Parse(firstValTxtBox.Text)); i++)
                            fact = fact * i;
                        resulltTxtBox.Text = fact.ToString();
                        break;
                    case 9:
                        resulltTxtBox.Text = (Math.Sqrt(Double.Parse(firstValTxtBox.Text))).ToString();
                        break;
                    case 10:
                        resulltTxtBox.Text = (Math.Abs(Double.Parse(firstValTxtBox.Text))).ToString();
                        break;
                }
            }
            catch 
            {
                resulltTxtBox.Text = "One or more fields are empty! check your command.";
            }
        }

        private void Add()
        {

        }

        private void minusLbl_Click(object sender, EventArgs e)
        {
            signLbl.Text = "-";
            funcVal = 2;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Subtraction";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = true;
            label8.Text = "Value of X";
            label9.Text = "Value of Y";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            signLbl.Text = "X";
            funcVal = 3;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Multiplication";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = true;
            label8.Text = "Value of X";
            label9.Text = "Value of Y";

        }

        private void label2_Click(object sender, EventArgs e)
        {
            signLbl.Text = "/";
            funcVal = 4;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Divition";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = true;
            label8.Text = "Value of X";
            label9.Text = "Value of Y";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            signLbl.Text = "^";
            funcVal = 5;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Power";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = true;
            label8.Text = "Value of X";
            label9.Text = "Value of Y";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            signLbl.Text = "";
            funcVal = 6;
            resulltTxtBox.Text = "";
            detectLbl.Text = "ln of X";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = false;
            label8.Text = "Value of X";
            label9.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            signLbl.Text = "";
            funcVal = 7;
            resulltTxtBox.Text = "";
            detectLbl.Text = "log of X";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = false;
            label8.Text = "Value of X";
            label9.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {
            signLbl.Text = "";
            funcVal = 8;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Factorial";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = false;
            label8.Text = "Value of X";
            label9.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {
            signLbl.Text = "";
            funcVal = 9;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Square Root";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = false;
            label8.Text = "Value of X";
            label9.Text = "";

        }

        private void label11_Click(object sender, EventArgs e)
        {
            signLbl.Text = "";
            funcVal = 10;
            resulltTxtBox.Text = "";
            detectLbl.Text = "Absolute Value";
            firstValTxtBox.Visible = true;
            secondValTxtBox.Visible = false;
            label8.Text = "Value of X";
            label9.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void algebraCalculateBtn_Click(object sender, EventArgs e)
        {
            if (t == true)
            {
                output = expTextBox.Text;
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
          
            
        }


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
                    if (s2.First() != '(' && s2.Count()>0)
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
                                if (s2.Count()==0)
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
                        if (s2.Count()>0)
                            s2.Pop();
                    }

                }
            }
        }


        // main part of evaluation of infx.................................................................

       private void mainPart()
        {
            convertPostfix();
            MessageBox.Show("post " + postExp+" len = " +postExp.Length.ToString());
            calculationPart();
         

        }
        public void unknownValueFind()
        {           
            
            
            char[] str = new char[100];           
            int j=0,aw=0,lopCoun;
            lenExp = output.Length;//Cuse lenExp er man degun hosschilo tai
/**********************Unknown Variable Found Part****************/
            temp = "";
            while (j < lenExp)
            {
                lopCoun = 0;
                for (j = aw; op_arg_count( output[j])!= 2 && (output[j]!=' ' && output[j]!='('||output[j]!=')'); )
                {
                    temp += output[j];
                    lopCoun++; j++;
                    if (j >= lenExp) break;
                }
                aw += lopCoun + 1;
                if(temp!="")
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
           lenExp = postExp.Length ;//Cuse lenExp er man degun hosschilo tai
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
                           resultListBox.Items.Add(" = " + output);
                       }
                   }
               // printf("| %d\t           |\n", s.top());

               temp = null;

           }

           //printf("|---------------------|--------------------|\n");
           // printf("\nThe Postfix Expression result is : %d\n\n\n",s.top());
           //expTextBox.Text = s.First().ToString();
           resultListBox.Items.Add(" ");
           resultListBox.Items.Add("The Expression result is :  " + s.First().ToString());
           t = true;
       }


       private void outputFormat(double n,double m)
       {
 
          int outputStartLen;
          outputTemp += m.ToString();
          outputTemp += temp[0];
          outputTemp += n.ToString();
          outputStartLen= output.IndexOf(outputTemp, 0, output.Length);
            //MessageBox.Show(o
          if (outputStartLen > -1)
          {
              output = output.Remove(outputStartLen, outputTemp.Length);
              
            int ut=output.IndexOf("()", 0, output.Length);
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

       private void okButton_Click(object sender, EventArgs e)
       {
           if (unknownValueInputTextBox.Text !=null && unknownValu.Count()!=0)
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
               unknownValueInputTextBox.Text =null;
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

               if(unknownValu.Count()==0)
                   algebraCalculateBtn.Enabled = true;
           
           }   
               
       }
    }

}
