using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_BUOI04
{
    public partial class Form2 : Form
    {
        public string MSNV {  get; set; }
        public string Name { get; set; }
        public string Luong { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string msnv, string name, string luong)
        {
            InitializeComponent();

            MSNV = msnv;
            Name = name;
            Luong = luong;

            txt_msnv.Text = msnv;
            txt_name.Text = name;
            txt_luong.Text = luong;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MSNV = txt_msnv.Text;
            Name = txt_name.Text;
            Luong = txt_luong.Text;

            DialogResult = DialogResult.OK;
                Close();
            
              
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}
