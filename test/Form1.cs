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
        private int a ;
        private int b ;
        public Method()
        {
        }

        public Method(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Result ()
        {
            return a+b;
        }
    }
}
