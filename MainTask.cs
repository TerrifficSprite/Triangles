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
    public partial class MainTask : Form
    {
        public MainTask(List<TTriangle> triangles)
        {
            InitializeComponent();
            double IPerimeter = 0, SSquare = 0, ESquare = 0;
            foreach(TTriangle t in triangles)
            {
                switch (t.TType)
                {
                    case "Рівносторонній":
                        ESquare += t.Square();
                        break;
                    case "Рівнобедрений":
                        IPerimeter += t.Perimeter();
                        break;
                    case "Прямокутний":
                        SSquare += t.Square();
                        break;
                }
            }
            label3.Text = Math.Round(ESquare, 3).ToString();
            label4.Text = Math.Round(SSquare, 3).ToString();
            label5.Text = Math.Round(ESquare + SSquare, 3).ToString();
            label7.Text = Math.Round(IPerimeter, 3).ToString();
        }
    }
}
