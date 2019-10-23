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
using System.Runtime.InteropServices;


namespace QueryAssistant
{
    public partial class FromLz : Form
    {
        public BinaryReader br;
        FileDingTwo[] fileDingTwo;
        public FromLz()
        {
            InitializeComponent();
        }

        public FromLz(BinaryReader binStream)
        {
            br = binStream;
            InitializeComponent();
        }

        //2、Byte[]转换为struct
        public static Object BytesToStruct(Byte[] bytes, Type strcutType)
        {
            Int32 size = Marshal.SizeOf(strcutType);
            IntPtr buffer = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.Copy(bytes, 0, buffer, size);

                return Marshal.PtrToStructure(buffer, strcutType);
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }

        private string GetResult(int num)
        {
            string str = "";
            FileDingTwo fileInfo = fileDingTwo[num - 1];
            Byte[] buf = new byte[256];
            try
            {
                br.BaseStream.Seek(fileInfo.str_offset, SeekOrigin.Begin);
                buf = br.ReadBytes((int)fileInfo.str_lenght);
                str = System.Text.Encoding.GetEncoding("GB2312").GetString(buf);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message + "cannot open file faild");
            }
            return str;
        }

        private void FromLz_Load(object sender, EventArgs e)
        {
            try
            {
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                uint offset = br.ReadUInt32();
                br.BaseStream.Seek(offset+8, SeekOrigin.Begin);
                fileDingTwo = new FileDingTwo[100];
                for (int i=0; i<100; ++i)
                {
                    fileDingTwo[i].str_offset = br.ReadUInt32();
                    fileDingTwo[i].str_lenght = br.ReadUInt32();
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message + "\n Cannot Open File.");
                return;
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string str = "";
            int num = 0;
            if (TextOne.TextLength == 0 && TextTwo.TextLength == 0 && TextThree.TextLength == 0)
            {
                TextResult.Text = "请输入查询的签数";
                return;
            }

            if (TextOne.TextLength != 0)
            {
                num = int.Parse(TextOne.Text);
                str = GetResult(num)+ "\r\n";
            }

            if (TextTwo.TextLength != 0)
            {
                num = int.Parse(TextTwo.Text);
                str = str + GetResult(num) + "\r\n";
            }

            if (TextThree.TextLength != 0)
            {
                num = int.Parse(TextThree.Text);
                str = str + GetResult(num);
            }

            TextResult.Text = str;
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            string str;
            int rand = 0;
            Random rd = new Random();
            rand = rd.Next(1, 100);
            str = GetResult(rand) + "\r\n";
            TextOne.Text = rand.ToString();
            rand = rd.Next(1, 100);
            str = str + GetResult(rand) + "\r\n";
            TextTwo.Text = rand.ToString();
            rand = rd.Next(1, 100);
            str = str + GetResult(rand);
            TextThree.Text = rand.ToString();
            TextResult.Text = str;
        }

        private void TextOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ret = Char.IsNumber(e.KeyChar);
            if (ret == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ret = Char.IsNumber(e.KeyChar);
            if (ret == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextThree_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool ret = Char.IsNumber(e.KeyChar);
            if (ret == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TextOne_TextChanged(object sender, EventArgs e)
        {
            string strNum = TextOne.Text;
            if (strNum == "")
            {
                return;
            }

            int num = int.Parse(strNum);
            if (num > 100)
            {
                TextOne.Text = TextOne.Text.Remove(2);
                TextOne.SelectionStart = TextOne.Text.Length;
            }

            if (num == 0)
            {
                TextOne.Text = TextOne.Text.Remove(0);
                TextOne.SelectionStart = TextOne.Text.Length;
            }
        }

        private void TextTwo_TextChanged(object sender, EventArgs e)
        {
            string strNum = TextTwo.Text;
            if (strNum == "")
            {
                return;
            }

            int num = int.Parse(strNum);
            if (num > 100)
            {
                TextTwo.Text = TextTwo.Text.Remove(2);
                TextTwo.SelectionStart = TextTwo.Text.Length;
            }

            if (num == 0)
            {
                TextOne.Text = TextOne.Text.Remove(0);
                TextOne.SelectionStart = TextOne.Text.Length;
            }
        }

        private void TextThree_TextChanged(object sender, EventArgs e)
        {
            string strNum = TextThree.Text;
            if (strNum == "")
            {
                return;
            }

            int num = int.Parse(strNum);
            if (num > 100)
            {
                TextThree.Text = TextThree.Text.Remove(2);
                TextThree.SelectionStart = TextThree.Text.Length;
            }

            if (num == 0)
            {
                TextOne.Text = TextOne.Text.Remove(0);
                TextOne.SelectionStart = TextOne.Text.Length;
            }
        }
    }
}
