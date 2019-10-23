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
    public partial class FromLh : Form
    {
        public BinaryReader br;
        FileDing[] fileDing;
        public bool m_sequenceFlage;
        public FromLh()
        {
            InitializeComponent();
        }

        public FromLh(BinaryReader binStream)
        {
            m_sequenceFlage = false;
            br = binStream;
            InitializeComponent();
        }

        private void FromLh_Load(object sender, EventArgs e)
        {
            try
            {
                br.BaseStream.Seek(8, SeekOrigin.Begin);
                fileDing = new FileDing[500];
                for (int i = 0; i < 500; ++i)
                {
                    fileDing[i].name_len = br.ReadUInt32();
                    fileDing[i].name_off = br.ReadUInt32();
                    fileDing[i].info1_len = br.ReadUInt32();
                    fileDing[i].info1_off = br.ReadUInt32();
                    fileDing[i].info2_len = br.ReadUInt32();
                    fileDing[i].info2_off = br.ReadUInt32();
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message + "\n Cannot Open File.");
                return;
            }
        }

        private string GetResult(int num)
        {
            string str = "";
            FileDing fileInfo = fileDing[num - 1];
            Byte[] buf = new byte[256];
            try
            {
                br.BaseStream.Seek(fileInfo.name_off, SeekOrigin.Begin);
                buf = br.ReadBytes((int)fileInfo.name_len);
                string name = System.Text.Encoding.GetEncoding("GB2312").GetString(buf);

                br.BaseStream.Seek(fileInfo.info1_off, SeekOrigin.Begin);
                buf = br.ReadBytes((int)fileInfo.info1_len);
                string info1 = System.Text.Encoding.GetEncoding("GB2312").GetString(buf);

                br.BaseStream.Seek(fileInfo.info2_off, SeekOrigin.Begin);
                buf = br.ReadBytes((int)fileInfo.info2_len);
                string info2 = System.Text.Encoding.GetEncoding("GB2312").GetString(buf);

                str = name + "\r\n\r\n" + info1 + "\r\n\r\n" + info2;
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message + "cannot open file faild");
            }
            return str;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (TextSearch.TextLength == 0)
            {
                TextResult.Text = "请输入查询的签数";
                return;
            }
            int num = int.Parse(TextSearch.Text);
            TextResult.Text = GetResult(num);
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            int rand = 0;
            Random rd = new Random();
            rand = rd.Next(1, 500);
            if (m_sequenceFlage == false) //顺
            {
                TextSequence.Text = rand.ToString();
            }
            else
            {
                rand = System.Math.Abs(rand - 500);
                TextSequence.Text = rand.ToString();
            }
            
            TextResult.Text = GetResult(rand);
        }

        private void TextSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ret = Char.IsNumber(e.KeyChar);
            if (ret == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextSequence_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ret = Char.IsNumber(e.KeyChar);
            if (ret == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            if (sender.Equals(TextSearch))
            {
                LabelSearch.Visible = TextSearch.Text.Length < 1;
            }

            string strNum = TextSearch.Text;
            if (strNum == "")
            {
                return;
            }

            int num = int.Parse(strNum);
            if (num > 500)
            {
                TextSearch.Text = TextSearch.Text.Remove(2);
                TextSearch.SelectionStart = TextSearch.Text.Length;
            }
        }

        private void BtnSequence_Click(object sender, EventArgs e)
        {
            switch (m_sequenceFlage)
            {
                case false:
                    m_sequenceFlage = true;
                    BtnSequence.Text = "逆";
                    break;
                case true:
                    m_sequenceFlage = false;
                    BtnSequence.Text = "顺";
                    break;
                default:
                    break;
            }
        }

        private void contextMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void LabelSearch_Click(object sender, EventArgs e)
        {
            if (sender.Equals(LabelSearch))
            {
                TextSearch.Focus();
            }
        }
    }
}
