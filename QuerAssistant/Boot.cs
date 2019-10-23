using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QueryAssistant
{
    struct FileDing
    {
        public uint name_len;
        public uint name_off;
        public uint info1_len;
        public uint info1_off;
        public uint info2_len;
        public uint info2_off;
    };
    struct FileDingTwo
    {
        public uint str_offset;
        public uint str_lenght;
    };

    public partial class Boot : Form
    {
        public FromLz m_FromLz;
        public FromLh m_FromLh;
        static BinaryReader br;

        public Boot()
        {
            try
            {
                br = new BinaryReader(new FileStream("data.dat", FileMode.Open));
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
                throw ioe;
                //throw new Exception("Put more context here", ioe);
            }
            InitializeComponent();
        }

        private void Boot_Load(object sender, EventArgs e)
        {
            m_FromLh = new FromLh(br);
            m_FromLz = new FromLz(br);

            m_FromLh.TopLevel = false;
            m_FromLh.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(m_FromLh);
            m_FromLh.Show();
            btn_lh.BackColor = Color.White;
        }

        private void btn_lh_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            m_FromLh.TopLevel = false;
            m_FromLh.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(m_FromLh);
            m_FromLh.Show();
            btn_lh.BackColor = Color.White;
            btn_lz.BackColor = SystemColors.Control;
        }

        private void btn_lz_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            m_FromLz.TopLevel = false;
            m_FromLz.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(m_FromLz);
            m_FromLz.Show();
            btn_lh.BackColor = SystemColors.Control;
            btn_lz.BackColor = Color.White;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 移动窗体
        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84://鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x01)
                    {
                        m.Result = new IntPtr(0x02);
                    }
                    break;
                case 0xA3://禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion
    }
}
