using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_BUOI04
{
    public partial class Form1 : Form
    {
        public delegate void CapNhatNhanVien(string MSNV, string Name, int Luong);
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                dgv_nhanvien.Rows.Add(frm2.MSNV, frm2.Name, frm2.Luong);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_nhanvien.Columns.Add("MSNV", "Mã số nhân viên");
            dgv_nhanvien.Columns.Add("Name", "Tên nhân viên:");
            dgv_nhanvien.Columns.Add("Lương", "Lương nhân viên");

            dgv_nhanvien.SelectionMode.Equals(DataGridViewSelectionMode.FullRowSelect);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_nhanvien.SelectedRows[0];

                Form2 frm = new Form2(selectedRow.Cells[0].Value.ToString(), selectedRow.Cells[1].Value.ToString(), selectedRow.Cells[2].Value.ToString());
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedRow.Cells[0].Value = frm.MSNV;
                    selectedRow.Cells[1].Value = frm.Name;
                    selectedRow.Cells[2].Value = frm.Luong;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                DialogResult rs= MessageBox.Show("Bạn có chắc chắn muốn xóa!", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    dgv_nhanvien.Rows.RemoveAt(dgv_nhanvien.SelectedRows[0].Index);
                }
                
            }
            
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            DataGridViewRow row = dgv_nhanvien.Rows[e.RowIndex];
            row.Cells[0].Value.ToString();
            row.Cells[1].Value.ToString();
            row.Cells[2].Value.ToString();
        }
    }
}
    