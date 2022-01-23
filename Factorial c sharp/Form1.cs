using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            long  num, factorial;
            long  i;
            num = Convert.ToInt64(txtnumber.Text);

            factorial = 1;

            for ( i = 1; i <= num; i++)

            {
                
                factorial = factorial * i;

            }

            lblresult.Text = Convert.ToString(factorial);

            
        }
    }
}
