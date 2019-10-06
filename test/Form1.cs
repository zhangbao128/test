using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class Method
    {
        private int a=0;
        public Method()
        {
        }

        public Method(int a)
        {
            this.a = a;
        }

        public int Result (int ac,int bc)
        {
            return ac+bc;
        }
    }
}
