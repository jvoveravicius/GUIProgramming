using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class MainForm : Form
    {

        static Random rnd = new Random();

        public MainForm()
        {
            InitializeComponent();
            initForm('d');
            MainLabel.Visible = false; Task6Label.Visible = false;

            ResultTask7.Visible = false; ResultEqual.Visible = false; Task7Two.Visible = false; Sandaug.Visible = false; ResulFirst.Visible = false;

            TxtBoxSize.Visible = false;

        }


        private void initForm(char Case)
        {

            // 12. sudarykite programą, kuri įkrovimo metu:
            // a.nustatytų teksto laukelio plotį į 100;
            // b.nustatytų teksto laukelio poziciją formos centre;
            // c.nustatytų etiketės plotį į 100;
            // d.nustatytų etiketės rėmo parametrus į “fixedsingle”;
            // e.nustatytų etiketės poziciją taip, kad ji būtų atitraukta nuo dešiniojo ir apatinio
            //formos kraštų po 10.

            int TextBoxWidth = this.txtBox.Size.Width;
            int TextBoxHeight = this.txtBox.Size.Height;

            int LabelWidth = this.TxtFieldMy.Size.Width;
            int LabelHeight = this.TxtFieldMy.Size.Height;

            int width = this.Width;
            int height = this.Height;


            switch (Case)
            {
                case 'a':

                    this.txtBox.Size = new System.Drawing.Size(100, TextBoxHeight);

                    break;
                case 'b':

                    txtBox.Location = new Point(width/2, height/2);
                    break;

                case 'c':
                    this.TxtFieldMy.Size = new System.Drawing.Size(100, TextBoxHeight);
                    break;

                case 'd':
                    TxtFieldMy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    break;
                case 'e':
                    TxtFieldMy.Location = new Point(width - LabelWidth - 25, height - LabelHeight - 48);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

        }



        private String RandT(int Type, int RandLenght = 0)
        {
            String Result = "";
            int i = 0;
            double e = 0;

            String[] Names = new String[5] { "Josh", "Edward", "Loui", "Peter", "Deborah" };
            String[] SecondName = new String[5] { "Pivn", "Madera", "Swetout", "Dolgin", "Catar" };


            if (Type == 0)
            {
                i = rnd.Next(0, Names.Length);
                Result = Names[i] + " " + SecondName[i];
            }
            else if (Type == 1)
            {
                i = rnd.Next(0, Names.Length);
                Result = SecondName[i];
            }
            else if (Type == 3)
            {
                i = rnd.Next(0, RandLenght);
                Result = i.ToString();
            }
            else if (Type == 4)
            {
                e = rnd.NextDouble() * (100.0 - 0) + 0;
                Result = Math.Round((Decimal)e, 3, MidpointRounding.AwayFromZero).ToString();
            }

            return Result;

        }




        private void button1_Click(object sender, EventArgs e)
        {


            this.txtBox.AutoSize = false;

            if (!Task2.Checked) { MainLabel.Visible = false; };
            if (!Task6.Checked) { Task6Label.Visible = false; };
            if (!Task9.Checked) { TxtBoxSize.Visible = false; };


            if (!Task7.Checked)
            {
                ResultTask7.Visible = false; ResultEqual.Visible = false; Task7Two.Visible = false; Sandaug.Visible = false;
                ResulFirst.Visible = false;

            }

            if (Task1.Checked)
            {
                //1. Sudarykite programą, kuri mygtuko paspaudimu teksto laukelyje(TextBox)
                //atspausdina Jūsų vardą

                txtBox.Text = RandT(0);
            }
            else if (Task2.Checked)
            {

                //2. Sudarykite programą, kuri mygtuko paspaudimu etiketėje(Label) atspausdina Jūsų
                //pavardę.

                txtBox.Text = RandT(1);
                MainLabel.Visible = true;
                MainLabel.Text = RandT(1);
            }

            else if (Task3.Checked)
            {
                //3. Sudarykite programą, kuri mygtuko paspaudimu etiketėje atspausdina Jūsų amžių
                //metais.Naudokite kintamąjį.

                short myyars = 30;
                txtBox.Text = myyars.ToString();

            }
            else if (Task4.Checked)
            {
                //4. Sudarykite programą, kuri mygtuko paspaudimu etiketėje atspausdina atsitiktinį
                //sveikąjį skaičių iš intervalo[0, 99]

                txtBox.Text = RandT(3, 100);

            }
            else if (Task5.Checked)
            {
                //5. sudarykite programą, kuri mygtuko paspaudimu etiketėje atspausdina atsitiktinį realųjį
                //skaičių iš intervalo[0, 99].
                txtBox.Text = RandT(4);

            }
            else if (Task6.Checked)
            {

                //6. Sudarykite programą, kuri mygtuko paspaudimu etiketėse atspausdina du atsitiktinius
                //skaičius ir jų sumą.

                String a = RandT(3, 100);
                String b = RandT(3, 100);
                int FinalResult = Convert.ToInt16(a) + Convert.ToInt16(b);

                Task6Label.Visible = true;
                Task6Label.Text = a + "+" + b + "=" + FinalResult.ToString();

            }
            else if (Task7.Checked)
            {

                //7Sudarykite programą, kuri mygtuko paspaudimu etiketėje atspausdina dviejų, teksto
                //laukeliuose vartotojo nurodytų skaičių sandaugą.



                Task7Two.Visible = true; Sandaug.Visible = true;
                ResulFirst.Visible = true;


                if (ResulFirst.Text != "" && Task7Two.Text != "")
                {
                    int ResultValue = Convert.ToInt32(ResulFirst.Text) + Convert.ToInt32(Task7Two.Text);
                    ResultTask7.Text = ResultValue.ToString();
                    ResultTask7.Visible = true; ResultEqual.Visible = true;
                }

            }
            else if (Task8.Checked)
            {

                //8.Sudarykite programą, kuri mygtuko paspaudimu padidina teksto laukelio plotį vienetu.
                // int lineHeightPixel = TextRenderer.MeasureText("X", txtBox.Font).Width;

                int TextBoxWidth = this.txtBox.Size.Width;
                int TextBoxHeight = this.txtBox.Size.Height;

                this.txtBox.Size = new System.Drawing.Size(TextBoxWidth + 1, TextBoxHeight);

            }
            else if (Task9.Checked)
            {
                //9. Sudarykite programą, kuri mygtuko paspaudimo metu padidina teksto laukelio plotį
                //kitame teksto laukelyje nurodytu dydžiu.

                TxtBoxSize.Visible = true;

                int TextBoxWidth = this.txtBox.Size.Width;
                int TextBoxHeight = this.txtBox.Size.Height;
                int WidthData = 0;

                if (TxtBoxSize.Text != "")
                {

                    WidthData = Convert.ToInt32(TxtBoxSize.Text);
                    this.txtBox.Size = new System.Drawing.Size(TextBoxWidth + WidthData, TextBoxHeight);

                }

            }
            else if (Task10.Checked)
            {

                //10. Sudarykite programą, kuri mygtuko paspaudimo metu jo poziciją nustatytų pagal
                //koordinates(10, 25)

                BUTTON.Location = new Point(10, 25);


            }
            else if (Task11.Checked)
            {

                //11. Sudarykite programą, kuri mygtuko paspaudimo metu jį perkeltų į atsitiktinę vietą
                //formoje


                int ButtonWidth = this.BUTTON.Size.Width;
                int width = this.Width;
                int rWidth = Convert.ToInt32(RandT(3, width));

                int height = this.Height;
                int rHeight = Convert.ToInt32(RandT(3, height));
                int ButtonHeight = this.BUTTON.Size.Height;


                if (rWidth >= width - ButtonWidth - 15)
                {
                    rWidth = width - ButtonWidth - 15;

                }

                if (rHeight >= height - ButtonHeight - 38)
                {
                    rHeight = height - ButtonHeight - 38;

                }

                BUTTON.Location = new Point(rWidth, rHeight);
            }
         
            else
            {

                txtBox.Text = "Choose radio button.";

            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
