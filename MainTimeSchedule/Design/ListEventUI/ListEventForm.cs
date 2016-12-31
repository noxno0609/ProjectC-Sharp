using CommonTimeSchedule;
using MainTimeSchedule.Utils;
using SQLTS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSProject.Design.EditEvent;

namespace TSProject.Design.ListEvent
{
    public partial class ListEventForm : Form
    {
        public bool updateRequest = false;
        private int selectindex = -1;
        public ListEventForm()
        {
            InitializeComponent();
        }
        private void loadPeriodEvent()
        {
            List<PeriodEventDTO> listdto = PeriodEventDAO.GetAllDTO(DBUtils.GetDBConnection());
            foreach(PeriodEventDTO dto in listdto)
            {
                string content = dto.Name + " (" + FormatUtils.formatDate(dto.DateStart) + " --> " + FormatUtils.formatDate(dto.DateEnd) + ")";
                listBox1.Items.Add(content);
            }
        }
        private PeriodEventDTO getbyindex()
        {
            List<PeriodEventDTO> listdto = PeriodEventDAO.GetAllDTO(DBUtils.GetDBConnection());
            for (int i = 0; i < listdto.Count; i++)
            {
                if (selectindex == i)
                    return listdto[i];
            }
            return null;
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {
            if(selectindex == -1)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện để thực hiện thao tác.", "Lịch trình", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EditPeriodUIMain editbox = new EditPeriodUIMain(getbyindex());
            editbox.FormClosed += new FormClosedEventHandler(updateList);
            editbox.ShowDialog();
        }
        private void updateList(object sender, EventArgs e)
        {
            EditPeriodUIMain editbox = (EditPeriodUIMain)sender;
            listBox1.Items.Clear();
            loadPeriodEvent();
            
            updateRequest = editbox.updateRequest;
            editbox.updateRequest = false;
        }
        private void buttonclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox) sender;
            selectindex = lb.SelectedIndex;
        }

        private void ListEventForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            loadPeriodEvent();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (selectindex == -1)
            {
                MessageBox.Show("Vui lòng chọn một sự kiện để thực hiện thao tác.", "Lịch trình", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa lịch trình", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (PeriodEventDAO.Delete(getbyindex(), DBUtils.GetDBConnection()) == true)
                {
                    listBox1.Items.Clear();
                    MessageBox.Show("Đã xóa lịch trình này thành công!", "Xóa lịch trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadPeriodEvent();

                    updateRequest = true;
                }    
            }
        }
    }
}
