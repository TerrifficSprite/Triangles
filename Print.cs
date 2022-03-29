using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangles.Model;

namespace Triangles
{
    public partial class Print : Form
    {
        private List<TTriangle> triangles = new List<TTriangle>();
        public void initDataGridView(List<TTriangle> list)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                TTriangle t = list[i];
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = t.TType;
                dataGridView1.Rows[i].Cells[1].Value = t.SideA;
                dataGridView1.Rows[i].Cells[2].Value = t.SideB;
                dataGridView1.Rows[i].Cells[3].Value = t.SideC;
                dataGridView1.Rows[i].Cells[4].Value = t.CornerA;
                dataGridView1.Rows[i].Cells[5].Value = t.CornerB;
                dataGridView1.Rows[i].Cells[6].Value = t.CornerC;
                dataGridView1.Rows[i].Cells[7].Value = t.Perimeter();
                dataGridView1.Rows[i].Cells[8].Value = t.Square();
            }
        }

        public Print(int trianglesNum, int maxWidth)
        {
            InitializeComponent();
            TGenerate(trianglesNum, maxWidth);
            initDataGridView(triangles);
        }

        private void TGenerate(int trianglesNum, int maxWidth)
        {
            for(int i = 0; i < trianglesNum; i++)
                {
                Random rand = new Random();
                switch (rand.Next(4))
                {
                    case 0:
                        triangles.Add(new TTriangle(maxWidth));
                        break;
                    case 1:
                        triangles.Add(new ITriangle(maxWidth));
                        break;
                    case 2:
                        triangles.Add(new ETriangle(maxWidth));
                        break;
                    case 3:
                        triangles.Add(new STriangle(maxWidth));
                        break;
                    default:
                        throw new Exception("Ойой");
                }
            }
        }

        private void change(object sender, EventArgs e)
        {
            List<TTriangle> localTriangles = new List<TTriangle>();
            if (checkBox1.Checked)
                localTriangles = addT(localTriangles, checkBox1.Text);
            if (checkBox2.Checked)
                localTriangles = addT(localTriangles, checkBox2.Text);
            if (checkBox3.Checked)
                localTriangles = addT(localTriangles, checkBox3.Text);
            if (checkBox4.Checked)
                localTriangles = addT(localTriangles, checkBox4.Text);
            initDataGridView(localTriangles);
        }

        private List<TTriangle> addT(List<TTriangle> localTriangles, string text) {
            foreach(TTriangle t in triangles)
            {
                if (t.TType.Equals(text))
                    localTriangles.Add(t);
            }
            return localTriangles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainTask mainTask = new MainTask(triangles);
            mainTask.Show();
        }
    }
}
