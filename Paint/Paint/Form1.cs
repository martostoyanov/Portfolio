using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        //Bitmap bmp;
        string fileName;

        public Form1()
        {
            InitializeComponent();

           // bmp = new Bitmap(panel1.ClientSize.Width, panel1.ClientSize.Height);

            //Тука дефинирам графичното изчертаване да се извършва в/у panel1
            g = panel1.CreateGraphics(); 
        }

        //Дефиниране Graphics и на променливите X,Y със "занулено състояние" и shape-s с начално състояние false
        Graphics g;
        bool startRisuvane = false;
        int? X = null;
        int? Y = null;
        bool drawKvadrat = false;
        bool drawPravougulnik = false;
        bool drawKrug = false;

        //Бутон за оцветяване на задния фон
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = c.Color;
                button1.BackColor = c.Color;
            }
        }

        //При стартиране на програмата се изпълнява веднага и позволяване чертане при натискане на мишката и местене
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startRisuvane)
            {
                //Дефиниране на четката
                Pen p = new Pen(button2.BackColor, float.Parse(comboBox1.Text));
                //Изчертаване
                g.DrawLine(p, new Point(X ?? e.X, Y ?? e.Y), new Point(e.X, e.Y));
                X = e.X;
                Y = e.Y;
            }
        }

        //Цвят на четката
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = c.Color;
            }
        }

        //При пуснато копче да не се прави рисуване
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startRisuvane = false;
            X = null;
            Y = null;
        }

        //При натиснато копче дава флаг на рисуване на четката - true и правене на проверки за останалите фигури и тяхното чертане
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startRisuvane = true;
            if (drawKvadrat)
            {
                //Създаване на очертанието със SolidBrush и вземане на цвета от цвят на четката и изчертаване по X,Y + големината взета от textbox-a
                SolidBrush sb = new SolidBrush(button2.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                //След изчертаване да се занули
                startRisuvane = false;
                drawKvadrat = false;
            }
            if (drawPravougulnik)
            {
                //Създаване на очертанието със SolidBrush и вземане на цвета от цвят на четката и изчертаване по X,Y + големината взета от textbox-a
                SolidBrush sb = new SolidBrush(button2.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                //След изчертаване да се занули
                startRisuvane = false;
                drawPravougulnik = false;
            }
            if (drawKrug)
            {
                //Създаване на очертанието със SolidBrush и вземане на цвета от цвят на четката и изчертаване по X,Y + големината взета от textbox-a
                SolidBrush sb = new SolidBrush(button2.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                //След изчертаване да се занули
                startRisuvane = false;
                drawKrug = false;
            }
        }

        //Бутон за включване на флаг true за изчертаване на кръг
        private void button3_Click(object sender, EventArgs e)
        {
            drawKrug = true;
        }

        //Бутон за включване на флаг true за изчертаване на квадрат
        private void button4_Click(object sender, EventArgs e)
        {
            drawKvadrat = true;
        }

        //Бутон за включване на флаг true за изчертаване на правоъгълник
        private void button5_Click(object sender, EventArgs e)
        {
            drawPravougulnik = true;
        }

        //При натискане на опция New да се "изтрие" всичко и създаване на "нов" панел за чертане
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
            panel1.BackColor = Color.White;
            panel1.ForeColor = Color.White;
            //this.Text = "Untitled";
        }

        //Отваряне на изображение
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(openFileDialog1.FileName);
                panel1.BackgroundImage = bit;
            }
            fileName = openFileDialog1.FileName;
            this.Text = fileName;
        }

        //Запазване на текущото изображение
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fileName = openFileDialog1.FileName;
            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bmp, panel1.Bounds);
            bmp.Save(openFileDialog1.FileName);

        }

        //Запазване на изображението чрез Save as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAsDialog1 = new SaveFileDialog();
            saveAsDialog1.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";

            if (saveAsDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);
                panel1.DrawToBitmap(bmp, panel1.Bounds);
                bmp.Save(saveAsDialog1.FileName);
            }

        }

        //Изход от програмата
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }
        
        //About формата
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.Show();
        }
    }
}
