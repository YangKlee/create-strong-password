using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace password_creator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char rawstring;
        string passraw;
        private void Form1_Load(object sender, EventArgs e)
        {
            coppy_bt.Enabled = false;
            pass_tb.Enabled = false;
            //hidepass.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value < 8) {
                MessageBox.Show("Độ dài mật khẩu phải từ 8 ký tự trở lên!");
                numericUpDown1.Value = 8;
            
            }
        }

        bool dont_allow(int n)
        {
            bool[] allow_passtype = { chuhoa_cb.Checked, chuthuongcb.Checked, socb.Checked, ktdacbiet_cb.Checked };
            return allow_passtype[n-1];
        }
        void reset()
        {
            passraw = null;
        }

        private void create_pass_bt_Click(object sender, EventArgs e)
        {
            reset();
            pass_tb.Enabled = true;
            //pass_tb.Text = "Đang khởi tạo ...";
            int x, dem = 0;
            string[] kytudb = {"@", "@", "&", "#","$", "@" };

            for(int i = 0; i < numericUpDown1.Value; i++)
            {
                Random rnd = new Random();
                do
                {
                    x = rnd.Next(1, 5);
                }
                while (dont_allow(x) == false);

                Random ascii_code = new Random();
                if(x == 1)
                {
                    //pass_raw = pass_raw.Insert(i,(Convert.ToChar(ascii_code.Next(65,91))).ToString());
                    rawstring = Convert.ToChar(ascii_code.Next(65, 91));
                }
                else if(x == 2)
                {
                    //pass_raw = pass_raw.Insert(i, (Convert.ToChar(ascii_code.Next(97, 123))).ToString());
                    rawstring = Convert.ToChar(ascii_code.Next(97, 123));
                }
                else if(x == 3)
                {
                    //pass_raw = pass_raw.Insert(i, (Convert.ToChar(ascii_code.Next(48, 58))).ToString());
                    rawstring = Convert.ToChar(ascii_code.Next(48, 58));
                }
                else if(x == 4)
                {
                    //pass_raw = pass_raw.Insert(i, kytudb[ascii_code.Next(1, kytudb.Length+1)]) ;
                    rawstring =Convert.ToChar(kytudb[ascii_code.Next(-1, kytudb.Length)]);
                   // dem+= 3;
                }
                //MessageBox.Show(rawstring.ToString());
                Thread.Sleep(10);
                passraw += rawstring.ToString();
            }

            coppy_bt.Enabled = true;
            pass_tb.Text = passraw;
            if(hidepass.Checked)
            {
                pass_tb.UseSystemPasswordChar = false ;
                pass_tb.PasswordChar = '*';
            }
           
        }

        private void coppy_bt_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pass_tb.Text);
            MessageBox.Show("Mật khẩu đã coppy vào clipboard");
        }

        private void chuhoa_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (chuhoa_cb.Checked == false && chuthuongcb.Checked == false && socb.Checked == false
                && ktdacbiet_cb.Checked == false)
            {
                MessageBox.Show("Phải chọn ít nhất một thành phần mật khẩu");
                chuhoa_cb.Checked = true;
            }

               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bản quyền phần mềm thuộc @YangKlee aka Nguyễn Khánh Dương" +
                "\nMật khẩu được tạo là toàn toàn ngẫu nhiên!");
        }

        private void hidepass_CheckedChanged(object sender, EventArgs e)
        {
            if(hidepass.Checked)
            {
                pass_tb.UseSystemPasswordChar = false;
                pass_tb.PasswordChar = '*';
            }
            else
            {
                pass_tb.UseSystemPasswordChar = true;
            }
        }
    }
}
