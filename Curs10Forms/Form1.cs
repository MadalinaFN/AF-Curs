using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs10Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            Engine.init(10);
            Engine.draw();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = Engine.rezx;
            progressBar1.Minimum = 0;
            for (int i = 0; i < Engine.rezx; i++)
            {
                progressBar1.Value++;
                for (int j = 0; j < Engine.rezy; j++)
                {
                    myPoint A = Engine.getNearestObj(new PointF(i, j));
                    Engine.grp.FillEllipse(new SolidBrush(A.fillColor), i, j, 2, 2);
                }
            }
            Engine.draw();
        }
    }
}
