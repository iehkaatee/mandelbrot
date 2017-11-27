using System;
using System.Windows.Forms;
using System.Drawing;

// kleine aanpassing


namespace mandelbrot
{
    public class Scherm : Form
    {
        TextBox xcoordveld;
        TextBox ycoordveld;
        Panel output = new Panel();
        Bitmap bit = new Bitmap(600,600);
        Button start = new Button();

        public Scherm()
        {
            this.Text = "Mandelbrot";
            this.Size = new Size(800, 800);

            //labels
            Label xcoord;
                xcoord = new Label();
                xcoord.Location = new Point(30, 50);
                xcoord.Text = "x-coordinaat:";
                this.Controls.Add(xcoord);

            Label ycoord;
                ycoord = new Label();
                ycoord.Location = new Point(30, 100);
                ycoord.Text = "y-coordinaat:";
                this.Controls.Add(ycoord);

            //input textbox

                xcoordveld = new TextBox();
                xcoordveld.Size = new Size(40, 80);
                xcoordveld.Location = new Point(200, 30);
                this.Controls.Add(xcoordveld);


                ycoordveld = new TextBox();
                ycoordveld.Size = new Size(40, 80);
                ycoordveld.Location = new Point(200, 100);
                this.Controls.Add(ycoordveld);

            //Buttons

            start.Text = "Start";
            start.Location = new Point(300, 50);
            start.Click += this.Teken;
            this.Controls.Add(start);


            //Panel
            output.Size = new Size(600, 600);
            output.Location = new Point(100, 150);
            output.BackColor = Color.White;
            this.Controls.Add(output);

            //bitmap

        }

        void Teken(object o, EventArgs ea)
        {
            output.BackgroundImage = (Image)bit;
            output.BackgroundImageLayout = ImageLayout.None;
            int x = 200;

            while (x < 350)
            {
                int p = x - 250;
                double a = p*(2*Math.PI/100);
                double b = 100*Math.Sin(a) + 250;
                int y = Convert.ToInt32(b);
                Console.WriteLine($"{x} {p} {a} {b} {y}");
                bit.SetPixel(x, y, Color.Black);
                x = x + 1;
            }
        }
    }


}
