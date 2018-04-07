using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_app_ders1
{
    public partial class WelcomeScreen : Form
    {
        public int LeftPos = 0;
        public int TopPos = 50;
        public int btnNumber = 1;
        public int btnCount = 15;
        public TextBox result = new TextBox();
        public Button Reservebtn = new Button();
        public static List<Button> ReservedSeat = new List<Button>();
        public static List<int> Seatsnum = new List<int>();
        public WelcomeScreen()
        {
            InitializeComponent();
            var zal = new Button();
            zal.Width = 450;
            zal.Height = 100;
            zal.Text = ("Zal");
            zal.BackColor = Color.Yellow;
            zal.Left = 100;
            zal.Top = 350;
            Controls.Add(zal);
            for (int setir = 0; setir < btnCount; setir++)
            {
                btnCount -= 2;
                LeftPos = 50 * setir;
                for (int sutun = 0; sutun < btnCount; sutun++)
                {
                    var btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = btnNumber.ToString();
                    btn.Top = TopPos;
                    btn.Left = LeftPos;
                    btn.BackColor = Color.Red;
                    LeftPos += 50;
                    btnNumber++;
                    Controls.Add(btn);
                    btn.Click += new EventHandler(Rezervebtn);
                }
                LeftPos = 0;
                TopPos += 50;
            }
            Reservebtn.Text = "Rezerve";
            Reservebtn.AutoSize = true;
            Controls.Add(Reservebtn);
            Reservebtn.BackColor = Color.AliceBlue;
            Reservebtn.Left = 290;
            Reservebtn.Top = 14;
            Reservebtn.Click += new EventHandler(Rezerveseats);

            var exit1 = new Button();
            exit1.Height = 70;
            exit1.Width = 20;
            exit1.Left = 0;
            exit1.Top = 280;
            exit1.Text = "Ex i t";
            exit1.BackColor = Color.Green;
            Controls.Add(exit1);

            var exit = new Button();
            exit.Height = 70;
            exit.Width = 20;
            exit.Left = 630;
            exit.Top = 280;
            exit.Text = "Ex i t";
            exit.BackColor = Color.Green;
            Controls.Add(exit);
        }
        public void Rezervebtn(object obj, EventArgs e)
        {
            var seat = obj as Button;
            if (seat.BackColor == Color.Green)
            {
                seat.BackColor = Color.Red;
                Seatsnum.Remove(Convert.ToInt32(seat.Text));
                ReservedSeat.Remove(seat);

            }
            else
            {
                seat.BackColor = Color.Green;
                Seatsnum.Add(Convert.ToInt32(seat.Text));
                ReservedSeat.Add(seat);

            }

        }
         public void Rezerveseats(object obj,EventArgs e)
         {
            Qeydiyyat sec = new Qeydiyyat();
            sec.ShowDialog();
            foreach (Button item in ReservedSeat)
            {
                item.Enabled = false;
            } 
        }
        
    }
}
