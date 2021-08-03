using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 
namespace winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Label label = new Label()
            {
                Text = "&First Name",
                Location = new Point(10, 10),
                TabIndex = 10
            };
            Controls.Add(label);
            InitializeComponent();
        }
        
    }
}
