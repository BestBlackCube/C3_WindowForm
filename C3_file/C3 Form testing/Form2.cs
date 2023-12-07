using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_Form_testing
{
    public partial class Form2 : Form
    {// Form1 F1값을 만들어 Form1의 정보를 불러옴
        private Form1 F1;
        public int GameCount;
        private void button1_Click(object sender, MouseEventArgs e)
        {// 11 - 17 GameCount의 값을 설정하여 난이도 변경 함 F1.GameLV의 값을 대입시킴
            GameCount = 1;
            F1.GameLV = GameCount;
            F1.Show();
            Close();
        }
        private void button2_Click(object sender, MouseEventArgs e)
        {
            GameCount = 2;
            F1.GameLV = GameCount;
            F1.Show();
            Close();
        }
        private void button3_Click(object sender, MouseEventArgs e)
        {
            GameCount = 3;
            F1.GameLV = GameCount;
            F1.Show();
            Close();
        }
        public Form2(Form1 f1)
        {
            F1 = f1;
            InitializeComponent();
        }
    }
}
