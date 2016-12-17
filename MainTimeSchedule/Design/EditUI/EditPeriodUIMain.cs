using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSProject.Design.EditEvent
{
    public partial class ListEventForm : Form
    {
        public ListEventForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            //DialogResult answer;
            //answer = MessageBox.Show("Bạn muốn đóng bảng sửa?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //if (answer == DialogResult.OK)
                Close();
        }
    }
}
