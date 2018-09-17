using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        // Declaration of Variables
        public double grade_cal = 0.000;
        public double credit_cal = 0.0000;
        public double final_gpa = 0.000;
        public double final_result = 0.000;
        String fin_gpa;
        public double single_gpa = 0.000;
        public double single_credit = 0.000;
        public List<String> lsgrade = new List<String>();
        public List<Double> lscredit = new List<Double>();
        public List<String> lsgpa = new List<String>();
        
        int grade_var = 1;
        public Form1()
        {
            InitializeComponent();

            this.lbGrade.Text = "Grade of Course"+' '+grade_var+':';

            this.lblCredit.Text = "Credit hours of Course" +' ' + grade_var + ':';
        }



        public void Form1_Load(object sender, EventArgs e)
        {
            // Focus on grade textbox
            txtGrade.Focus();
        }


        // Exit Button Starts
        public void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Exit Button ends

        public void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        // Enter Button Starts
        public void txtEnter_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {

                

           

            Remove_Last.Enabled = true;

            String gpa_cal = txtGrade.Text;

                gpa_cal = gpa_cal.ToUpper();
                lsgrade.Add(gpa_cal);

                var message = string.Join(Environment.NewLine, lsgrade);
                
                // Switch statement for gpa

                switch (gpa_cal)
            {
                case "A":
                case "a":
                    grade_cal = 4.000;
                   
                   
                    break;

                case "B":
                case "b":
                    grade_cal = 3.000;
                    
                   
                    break;

                case "C":
                case "c":
                    grade_cal = 2.000;
                    
                   
                    break;

                case "D":
                case "d":
                    grade_cal = 1.000;
                   
                    
                    break;

                case "F":
                case "f":
                    
                    grade_cal = 0.000;
                   
                    break;

               

            }

            single_gpa = grade_cal;

            double get_credit = Convert.ToDouble(txtCredit.Text);

                lscredit.Add(get_credit);

                var msgCredit = string.Join(Environment.NewLine, lscredit);
               


                single_credit = get_credit;

            

                
                    

                   

                    grade_var++;

                    this.lbGrade.Text = "Grade of Course" + ' ' + grade_var + ':';

                    this.lblCredit.Text = "Credit hours of Course" + ' ' + grade_var + ':';

                    credit_cal = credit_cal + get_credit;
                    

                    final_gpa = final_gpa + grade_cal * get_credit;

                    final_result = final_gpa / credit_cal;

               

                if (double.IsNaN(final_result))    
                {
                    final_result = 0.000;
                }

                fin_gpa = final_result.ToString("N3");

               

                lsgpa.Add(fin_gpa);

                  var gpamessage = string.Join(Environment.NewLine, lsgpa);
                 


                LabelGpa.Text = fin_gpa;

                txtGrade.Clear();

                txtCredit.Clear();

                txtGrade.Focus();

            }
            

          
            

           
            

        }

        // Enter button ends 


        public void txtGrade_TextChanged_1(object sender, EventArgs e)
        {

        }

        // Reset Button Starts
        public void txtReset_Click(object sender, EventArgs e)
        {

            Remove_Last.Enabled = true;

            grade_var = 1;

            this.lbGrade.Text = "Grade of Course" + ' ' + grade_var + ':';

            this.lblCredit.Text = "Credit hours of Course" + ' ' + grade_var + ':';

            txtGrade.Clear();

            txtCredit.Clear();

            LabelGpa.Text = "0.000";

            txtGrade.Focus();

            LabelGpa.Text = "0.000";

            lsgrade.Clear();
            lscredit.Clear();
            lsgpa.Clear();

            grade_cal = 0.000;

            credit_cal = 0.0000;

            final_gpa = 0.000;

           

    }
        

        public void Remove_Last_Click(object sender, EventArgs e)
        {
            if (grade_var == 1)
            {
                Remove_Last.Enabled = false;

            }
         else if (grade_var == 2)
            {
                
                Remove_Last.Enabled = true;

                grade_var = 1;

                this.lbGrade.Text = "Grade of Course" + ' ' + grade_var + ':';

                this.lblCredit.Text = "Credit hours of Course" + ' ' + grade_var + ':';

                txtGrade.Clear();

                txtCredit.Clear();

                LabelGpa.Text = "0.000";

                txtGrade.Focus();

                LabelGpa.Text = "0.000";

                lsgrade.RemoveAt(lsgrade.Count - 1);

                lscredit.RemoveAt(lscredit.Count - 1);

                lsgpa.RemoveAt(lsgpa.Count - 1);

                var remGpa = string.Join(Environment.NewLine, lsgrade);
                

                grade_cal = 0.000;

                credit_cal = 0.0000;

                final_gpa = 0.000;



                
            }
            else
            {
                grade_var--;

                this.lbGrade.Text = "Grade of Course" + ' ' + grade_var + ':';

                this.lblCredit.Text = "Credit hours of Course" + ' ' + grade_var + ':';

                credit_cal = credit_cal - single_credit;
               

                final_gpa = final_gpa - single_gpa * single_credit;

                final_result = final_gpa / credit_cal;

                fin_gpa = final_result.ToString("N3");

                lsgrade.RemoveAt(lsgrade.Count - 1);

                lscredit.RemoveAt(lscredit.Count - 1);

                lsgpa.RemoveAt(lsgpa.Count - 1);

                var lastGrade = string.Join(Environment.NewLine, lsgrade);
                

                var lastCredit = string.Join(Environment.NewLine, lscredit);
               

                var lastGpa = string.Join(Environment.NewLine, lsgpa);
                

                LabelGpa.Text = fin_gpa;

                Remove_Last.Enabled = false;
            }
        }

        // Remove Last Button Ends

        public void Btn_Show_Click(object sender, EventArgs e)
        {
            Summary sm = new Summary(this);
            sm.ShowDialog();
        }

        // Validation Code


        public bool IsValidData()
        {
            // Check Validation for grades
            return
                IsPresent(txtGrade, "Grade of Course") &&
                IsLetter(txtGrade,"Course Grade") &&
                IsWithinRange(txtGrade, "Course Grade",'A','F')&&

              // Check Validation for Credit Hours
            IsPresent(txtCredit, "Credit hours of Course")&&
            IsInt32(txtCredit, "Credit hours") &&
              IsWithinRange(txtCredit,"Credit hours",0,6);
        }

        // To Check if data is present in the textboxes
        public bool IsPresent(TextBox textBox, string name)
        {
            if(textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field. ", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // To Check if the integer value is entered in the credit hours textbox

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if(Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name +" must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        // To check if the grade entered is the character

        public bool IsLetter(TextBox textBox, string name)
        {

             char val = Char.Parse(textBox.Text);
            if(Char.IsLetter(val))
            {
              
                return true;
                
            }
            else
            {
                MessageBox.Show(name + " must be a letter. ", "Entry Error");
                textBox.Clear();
                textBox.Focus();
                return false;
            }


        }

        // To check if the value entered in credit hours is between 0 and 6

        public bool IsWithinRange(TextBox textBox, string name, double min, double max )
        {
            double number = Convert.ToDouble(textBox.Text);

            if(number < min || number > max)
            {
                MessageBox.Show(name +" must be between "+ min + " and "+ max + ".","Entry Error");
                textBox.Clear();
                textBox.Focus();
                return false;
            }
            return true;
        }

        // To check if the value entered in credit hours is between A, B, C, D, F

     /*   public bool checkGrade(TextBox textBox, string name)
        {

            for (int i = 0; i < gradeChars.Length; i++)
            
                if (textBox.Text.StartsWith(gradeChars[i] + ""))
                {
                    return true;
                }

            MessageBox.Show(name + " must be A, B, C, D, F .", "Entry Error");
            textBox.Clear();
            textBox.Focus();
            return false;
            
        }*/

        private bool IsWithinRange(TextBox textBox, string name, char min, char max)
        {

            String textboxstring = textBox.Text;
            Char character = Char.Parse(textboxstring.ToUpper());
            int value = Convert.ToInt32(character);
            //MessageBox.Show(value.ToString());
            if (value == 69)
            {
                MessageBox.Show(name + " must be in the Range A to D plus F. ", "Entry error");
                textBox.Clear();
                textBox.Focus();
                return false;
            }
            else if (value <= 70)
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be in the Range A to D plus F. ", "Entry error");
                textBox.Clear();
                textBox.Focus();
                return false;
            }

        }





    }
}
