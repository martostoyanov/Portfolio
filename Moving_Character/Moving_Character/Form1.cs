using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moving_Character
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            KeyEventHandler KeyDown = new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = label1.Location.X;
            int y = label1.Location.Y;

            //if (e.KeyCode == Keys.Right) x = x + 1;
            //else if (e.KeyCode == Keys.Left) x = x - 1;
            //else if (e.KeyCode == Keys.Up) y = y - 1;
            //else if (e.KeyCode == Keys.Down) y = y + 1;

            if (e.KeyCode == Keys.Right) x += 5;
            else if (e.KeyCode == Keys.Left) x -= 5;
            else if (e.KeyCode == Keys.Up) y -= 5;
            else if (e.KeyCode == Keys.Down) y += 5;

            label1.Location = new Point(x, y);
            
        }
    }
}
