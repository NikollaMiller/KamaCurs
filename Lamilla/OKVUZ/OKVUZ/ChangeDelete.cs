using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKVUZ
{
    public partial class ChangeDelete : Form
    {
        public ChangeDelete()
        {
            InitializeComponent();
        }

        private void ChangeDelete_Load(object sender, EventArgs e)
        {
            if (MAIN.changerSelected == 1)
            {
                Change.BringToFront();
            }
            else if (MAIN.changerSelected == 2)
            {
                Delete.BringToFront();
            }
            else if (MAIN.changerSelected == 3)
            {
                Add.BringToFront();
            }
        }
    }
}
