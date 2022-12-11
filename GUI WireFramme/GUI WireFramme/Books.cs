using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Fair
 {
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }

        private void Book_Back_Click(object sender, EventArgs e)
        {
            Visitor newForm = new Visitor();
            newForm.Show();
            this.Hide();
        }
    }
}
