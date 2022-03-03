using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace explorer_dotnet
{
    public partial class TaskbarForm : Form
    {
        public TaskbarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartChildForm startChildForm = new StartChildForm();
        }
    }
}
