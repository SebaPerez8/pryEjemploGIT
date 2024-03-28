using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEjemploGIT
{
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            Pen lápiz = new Pen(Color.Black);
            papel = pictureBox1.CreateGraphics();
            papel.DrawRectangle(lápiz, 10, 10, 100, 50);
            papel.DrawRectangle(lápiz, 10, 75, 100, 100);
        }

        private void FormFirma_MouseMove(object sender, MouseEventArgs e)
        {
            FormFirma formFirma = (FormFirma)sender;
            Pen lápiz = new Pen(Color.Black);
            formFirma.Text = "x" + e.X.ToString() + "y" + e.Y.ToString();

            Graphics dibujo;
            dibujo.DrawLine()
        }

       
    }
}
