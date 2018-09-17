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
    public partial class Summary : Form
    {

        Form1 form1;

        int acount = 0;
        int bcount = 0;
        int ccount = 0;
        int dcount = 0;
        int fcount = 0;

        public Summary(Form1 form_1)
        {
            InitializeComponent();
            form1 = form_1;
        }

        

        public void Summary_Load(object sender, EventArgs e)
        {
            List<String> listgrade = new List<String>();
             listgrade.AddRange(form1.lsgrade);

            List<Double> listcredit = new List<Double>();
            listcredit.AddRange(form1.lscredit);

            List<String> listgpa = new List<String>();
            listgpa.AddRange(form1.lsgpa);

            // Calculate the occurence of grades in the report
            foreach(string ch in listgrade)
            {
                if(ch == "A")
                {
                    acount++;
                }
                else if(ch == "B")
                {
                    bcount++;
                }
                else if (ch == "C")
                {
                    ccount++;
                }
                else if (ch == "C")
                {
                    dcount++;
                }
                else
                {
                    fcount++;
                }
            }
            lblA.Text = (acount.ToString());
            lblB.Text = (bcount.ToString());
            lblC.Text = (ccount.ToString());
            lblD.Text = (dcount.ToString());
            lblF.Text = (fcount.ToString());

           for(int i = 0; i < listgrade.Count(); i++)
            {
                
                listBoxGpa.Items.Add(listgrade[i]+"("+((listcredit[i].ToString()))+")->GPA:"+listgpa[i]);
            }

        }

        
    }
}
