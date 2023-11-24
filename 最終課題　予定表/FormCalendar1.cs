using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 最終課題_予定表
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void delite(object sender, EventArgs e)
        {
            MessageBox.Show("削除しました");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // カラム数を指定
            dataGridView1.ColumnCount = 4;

            // カラム名を指定
            dataGridView1.Columns[0].HeaderText = "教科";
            dataGridView1.Columns[1].HeaderText = "点数";
            dataGridView1.Columns[2].HeaderText = "氏名";
            dataGridView1.Columns[3].HeaderText = "クラス名";

            // データを追加
            dataGridView1.Rows.Add("国語", 90, "田中　一郎", "A");
            dataGridView1.Rows.Add("数学", 50, "鈴木　二郎", "A");
            dataGridView1.Rows.Add("英語", 90, "佐藤　三郎", "B");
        }
    }
}
