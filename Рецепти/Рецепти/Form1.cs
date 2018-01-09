using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Рецепти
{
    public partial class Form1 : Form
    {
        //масив със имената на рецептите
        string[] recepti = {"Картофи на фурна", "Мусака", "Зелеви Сарми", "Леща", "Баница", "Свинско със зеле", "Пиле с грах"};
        string path1 = @"C:\Users\rt20bg\Desktop\Maya's workplace\Programming training\Рецепти\Рецепти\Database";


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        //метод за принтиране
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label3.Text, label3.Font, Brushes.Black, 15, 15);
            e.Graphics.DrawString(textBox1.Text, textBox1.Font, Brushes.Black, 15, 40);

            float x = 15;
            float y = 425;
            float width = 800;
            float height = 500;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            e.Graphics.DrawString(label4.Text, label4.Font, Brushes.Black, 15, 390);
            e.Graphics.DrawString(textBox2.Text, textBox2.Font, Brushes.Black, drawRect);
        }
        //рецепти
        public void recepta_db()
        {
            Random rnd = new Random();
            int r = rnd.Next(recepti.Length);
            if (recepti[r] == "")
            {
                 r = rnd.Next(recepti.Length);
            }
            else if (recepti[r] == "Картофи на фурна")
            {
                label2.Text = "Картофи на фурна";
                textBox1.Text = " 1 килограм картофи \r\n олио или масло \r\n вода \r\n сол \r\n червен пипер \r\n черен пипер \r\n чубрица";
                textBox2.Text = "Обелваме картофите и ги нарязваме по дължина на филийки. Слагаме ги в намазана тава за печене с масло или в олио, слагате подправките и ги разбъркване. Доливате малко вода и слагате в предварително загрята фурна на 180 градуса за 40 до 60 минути, като ги разбърквате на всеки 20 минути.";
                pictureBox1.Image = new Bitmap(path1 + @"\kartofi-na-furna1.jpg"); pictureBox2.Image = new Bitmap(path1 + @"\kartofi-na-furna2.jpg"); pictureBox3.Image = new Bitmap(path1 + @"\kartofi-na-furna3.jpg"); pictureBox4.Image = new Bitmap(path1 + @"\kartofi-na-furna4.jpg"); pictureBox5.Image = new Bitmap(path1 + @"\kartofi-na-furna5.jpg"); pictureBox6.Image = new Bitmap(path1 + @"\kartofi-na-furna6.jpg");
            }
            else if (recepti[r] == "Мусака")
            {
                label2.Text = "Mусака";
                textBox1.Text = " • 500 г кайма \r\n • 1 кг картофи \r\n • 1 глава лук \r\n • 1 - 2 бр.домати или няколко с.л.доматено пюре \r\n • 1 ч.л.червен пипер \r\n • 1/2 ч.л.кимион \r\n • 1/2 ч.л.чубрица \r\n • сол \r\n • черен пипер \r\n • За заливката: \r\n • 2 бр.яйца \r\n • 200 г кисело мляко \r\n • 2 с.л.брашно \r\n • щипка сода за хляб \r\n • магданоз";
                textBox2.Text = "Лукът се нарязва на ситно и се запържва в 3-4 с.л. олио. Прибавя се каймата и се пържи, докато стане на зрънца. Овкусява се с подправките, добавят се настърганите домати и се оставя да поври 5-6 минути. Картофите се обелват, измиват се и се нарязват на кубчета. Слагат се в намазана с мазнина тава, отгоре се слага каймата, разбърква се добре и се налива топла вода, да покрие продуктите. Пече се в предварително загрята фурна на 200 С за 30 минути. Яйцата се разбиват с брашното, прибавя се киселото мляко, щипка сода за хляб и ситно нарязания магданоз.Залива се мусаката и се връща във фурната за 10 - 15 минути, докато порозовее. Поднася се с кисело мляко.";
                pictureBox1.Image = new Bitmap(path1 +@"\musaka1.jpg"); pictureBox2.Image = new Bitmap(path1 +@"\musaka2.jpg");pictureBox3.Image = new Bitmap(path1 + @"\musaka3.jpg"); pictureBox4.Image = new Bitmap(path1 + @"\musaka4.jpg"); pictureBox5.Image = new Bitmap(path1+@"\musaka5.jpg"); pictureBox6.Image = new Bitmap(path1+ @"\musaka6.jpg");
            }
            else if (recepti[r] == "Зелеви Сарми")
            {
                label2.Text = "Зелеви сарми с кайма, ориз и гъби";
                textBox1.Text = " 1 прясна или кисела зелка \r\n 1 чаена чаша ориз \r\n 1 килограм свинска кайма \r\n 2 супени лъжици олио \r\n 300 грама гъби \r\n 1 глава лук \r\n сол и смлян черен пипер на вкус";
                textBox2.Text = "Сварете ориза в продължение на 15 минути, след което отцедете с помощта на гевгир. Сгорещете олиото в тиган и в него изпържете нарязаните гъби и лук. Към каймата прибавете ориза, лука и гъбите, сложете сол и смлян черен пипер на вкус. Върху всеки зелев лист сложете по 2 супени лъжици от плънката и оформете сарми. Зелето може да бъде и прясно, и кисело. Ако използвате прясно, отрежете основата на кочана, а останалата част от зелката сварете, докато листата започнат да се отделят. Сармите подредете в огнеупорен съд, налейте половин чаша вода, сложете мъничко масло и затворете с капак. Поставете във фурната за около час (може да приготвите и на котлона). За да се получат още по-вкусни сарми, може да разтворите кубче бульон по избор в половин чаша топла вода, която налейте в съда, преди да оставите ястието  да се задушава.";
                pictureBox1.Image = new Bitmap(path1+@"\sarmi1.jpg");pictureBox2.Image = new Bitmap(path1+@"\sarmi2.jpg");pictureBox3.Image = new Bitmap(@"C:\Users\rt20bg\Desktop\Maya's workplace\Programming training\Рецепти\Рецепти\Database\sarmi3.jpg"); pictureBox4.Image = new Bitmap(@"C:\Users\rt20bg\Desktop\Maya's workplace\Programming training\Рецепти\Рецепти\Database\sarmi4.jpg");pictureBox5.Image = new Bitmap(@"C:\Users\rt20bg\Desktop\Maya's workplace\Programming training\Рецепти\Рецепти\Database\sarmi5.jpg");pictureBox6.Image = new Bitmap(@"C:\Users\rt20bg\Desktop\Maya's workplace\Programming training\Рецепти\Рецепти\Database\sarmi6.jpg");
            }
            else if (recepti[r] == "Леща")
            {
                label2.Text = "Леща яхния";
                textBox1.Text = " • 250-300 г леща \r\n • 1 глава лук \r\n • около 10 скилидки чесън \r\n • 1 бр. морков \r\n • 2 ч.л. червен пипер, сол, чубрица \r\n • 1-2 бр. домати \r\n • 1 бр. червена чушка \r\n • 3-4 с.л. мазнина \r\n • стрък целина \r\n • 2 с.л. брашно";
                textBox2.Text = "Лукът, чесънът и морковът се нарязват на ситно и се задушават с мазнината и малко вода. Добавя се измитата леща и червения пипер, доливат се 2-3 чаши вода или бульон и се задушава около 20 минути. Добавят се настърганите домати и нарязаните на ситно чушка и целина, останалите подправки и ако има нужда се налива още течност. Вари се още малко и се добавя размитото с вода брашно. След сваляне от котлона се поръсва с нарязан магданоз.";
                pictureBox1.Image = new Bitmap(path1 + @"\leshta1.jpg"); pictureBox2.Image = new Bitmap(path1 +@"\leshta2.jpg"); pictureBox3.Image = new Bitmap(path1+@"\leshta3.jpg"); pictureBox4.Image = new Bitmap(path1+@"\leshta4.jpg"); pictureBox5.Image = new Bitmap(path1+@"\leshta5.jpg"); pictureBox6.Image = new Bitmap(path1+@"\leshta6.jpg");
            }
            else if (recepti[r] == "Баница")
            {
                label2.Text = "Баница";
                textBox1.Text = " точени кори 400 грама \r\n яйца 4 броя \r\n кисело мляко 400 грама \r\n сирене 300 грама \r\n олио 3/4 чаени чаши \r\n хлебна сода 1 чаена лъжица";
                textBox2.Text = "Първата стъпка от рецептата за баница със сирене и готови кори е подготовката на плънката. Разбърквате яйцата (предварително извадени от хладилника), киселото мляко, изварата / сиренето, ½ чаена чаша олио и содата за хляб. Може да ползвате и извара. Ако сте ползва извара добавете и около една равна чаена лъжица сол. Разбъркайте продуктите добре до получаване на хомогенна смес. В намазнена тавичка сложeте 1-2 листа от корите, върху които сложете около един черпак (за супа) от сместа. След което поръсете с няколко капки от останалото олио. Отгоре отново сложете лист-два от корите и отново от сместа, а накрая олио. Повтаряйте процедурата в тази последователност докато корите и сместа свършат. Последният лист от корите намажете с олио и много внимателно нарежете с остър нож на парчета, за да можете след изпичане на по-лесно да разрежете баницата на парчета. Печете баницата в предварително загрята на 200 градуса фурна за около 30 минути, докато баницата придобие златист цвят.";
                pictureBox1.Image = new Bitmap(path1+@"\banica1.jpg"); pictureBox2.Image = new Bitmap(path1+@"\banica2.jpg"); pictureBox3.Image = new Bitmap(path1+@"\banica3.jpg"); pictureBox4.Image = new Bitmap(path1 +@"\banica4.jpg"); pictureBox5.Image = new Bitmap(path1+@"\banica5.jpg"); pictureBox6.Image = new Bitmap(path1+@"\banica6.jpg");
            }
            else if (recepti[r] == "Свинско със зеле")
            {
                label2.Text = "Свинско месо със зеле";
                textBox1.Text = " 600-700 гр. свинско месо \r\n 1/3 ч.ч. мазнина - олио или свинска мас \r\n 2 глави лук \r\n 1 ч.л. червен пипер \r\n 2-3 бр. домати \r\n чубрица \r\n черен пипер \r\n кимион \r\n 1 кубче бульон \r\n 1 бр. зелка (голяма) \r\n 1-2 с.л. брашно \r\n лимонена киселина";
                textBox2.Text = "Месото се нарязва на порции и се пържи в мазнината. Прибавя се лукът, ситно нарязан, червеният пипер, доматите нарязани на кубчета и всичко се задушава. Посолява се леко. Зелката се нарязва на ивици и се стрива с малко сол, лимонена киселина и се прибавя към месото. Натрошава се кубчето бульон, наръсват се 1-2 с.л. брашно, подправките и се налива малко вода. Ястието се разбърква и се прехвърля в тава. Пече се във фурна 2 часа.";
                pictureBox1.Image = new Bitmap(path1 + @"\svinskozele1.jpg"); pictureBox2.Image = new Bitmap(path1 + @"\svinskozele2.jpg"); pictureBox3.Image = new Bitmap(path1 + @"\svinskozele3.jpg"); pictureBox4.Image = new Bitmap(path1+@"\svinskozele4.jpg"); pictureBox5.Image = new Bitmap(path1 + @"\svinskozele5.jpg"); pictureBox6.Image = new Bitmap(path1 + @"\svinskozele6.jpg");
            }
            else if (recepti[r] == "Пиле с грах")
            {
                label2.Text = "Грах яхния с пилешко месо";
                textBox1.Text = " 1 кг пиле \r\n 800 г грах \r\n 1 морков \r\n 3 домата \r\n 1 глава лук \r\n 1 с.л. брашно \r\n 1 с.л. червен пипер \r\n 3 с.л. олио \r\n 1/2 връзка магданоз \r\n сол";
                textBox2.Text = "Пилешкото месо (1 кг) се нарязва на парченца и се запържва в тиган с малко олио (3 с.л.), докато се зачерви. Към него се добавят ситно нарязаните лук (1 глава) и морков (1 бр) и щом омекнат, се добавят обелените и нарязани на кубчета домати (3 бр). Щом течността от тях почти изври, продуктите се преместват в дълбока тенджерка и се заливат с гореща вода. Щом ястието започне да къкри на котлона, се добавя отцеденият от консервата грах (800 г), червеният пипер (1 с.л.) и солта. Оставя се да се готви около 15 минути. Накрая се смесва брашното (1 с.л.) с няколко супени лъжици вода в купичка и се разбърква добре. Течността се добавя в ястието и се разбърква. Готви се още някоко минути, докато се сгъсти. Преди сервиране се поръсва със ситно нарязан пресен магданоз (1/2 връзка).";
                pictureBox1.Image = new Bitmap(path1 + @"\pilegrah1.jpg"); pictureBox2.Image = new Bitmap(path1 + @"\pilegrah2.jpg"); pictureBox3.Image = new Bitmap(path1 + @"\pilegrah3.jpg"); pictureBox4.Image = new Bitmap(path1 + @"\pilegrah4.jpg"); pictureBox5.Image = new Bitmap(path1 + @"\pilegrah5.jpg"); pictureBox6.Image = new Bitmap(path1 + @"\pilegrah6.jpg");
            }
        }
        //бутон за генериране на рецепти
        private void button1_Click_1(object sender, EventArgs e)
        {
            recepta_db();
        }
        //бутон за показване на текущия брой рецепти 
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В момента има: " + recepti.Length.ToString() + " рецепти!");
        }
        //бутон за принтиране на текущата рецепта
        private void button3_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            PrintPreviewControl printPreviewControl1 = new PrintPreviewControl();

            printDocument1.PrintPage += new PrintPageEventHandler(PrintPage);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            printPreviewControl1.Document = printDocument1;
        }
    }
}
