using System;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad1
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }
       
        //New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            this.Text = "Untitled";
        }
       
        //Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            fileName = openFileDialog1.FileName;
            this.Text = fileName;
        }
        
        //Save
        private void savToolStripMenuItem_Click(object sender, EventArgs e)
        {
             File.WriteAllText(fileName, textBox1.Text);
        }
        
        //Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(textBox1.Text);
                file.Close();
            }
            fileName = saveFileDialog1.FileName;
            this.Text = fileName;
        }
        
        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }
       
        //Font
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        //Метод за принтиране
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 15, 15);
        }
       
        //Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
       
        //Print Preview
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintPreviewControl printPreviewControl1 = new PrintPreviewControl();

            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printPreviewControl1.Document = printDocument1;
        }

        //About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.Show();
        }

        //Брояч на думите в документа
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " " || textBox1.Text == "  ")
            {
                MessageBox.Show("Няма думи в документа!");
            }
            else
            {
                int broiDumi = 0;
                string[] words = textBox1.Text.Split(' ');
                broiDumi = words.Length;
                MessageBox.Show("Брой думи: " + broiDumi);
            }
            
        }

        //Клавиатурни shortcut-и
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "S")
                File.WriteAllText(fileName, textBox1.Text);
            if (e.Control && e.KeyCode.ToString() == "A")
                textBox1.SelectAll();
                textBox1.Focus();
            if (e.Control && e.KeyCode.ToString() == "C")
                textBox1.Copy();
            if (e.Control && e.KeyCode.ToString() == "V")
                textBox1.Paste();
            if (e.Control && e.KeyCode.ToString() == "X")
                textBox1.Cut();
        }
    }
}
