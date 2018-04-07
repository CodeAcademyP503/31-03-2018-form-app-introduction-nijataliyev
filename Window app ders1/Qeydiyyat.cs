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
    public partial class Qeydiyyat : Form
    { 
        public Qeydiyyat()
        {
            InitializeComponent();
            var Savebutton = new Button();
            Savebutton.Width = 80;
            Savebutton.Height = 20;
            Savebutton.Left = 100;
            Savebutton.Top = 100;
            Controls.Add(Savebutton);
            Savebutton.Text = "Save";
            Savebutton.Name = "Save";
            Savebutton.Click += new EventHandler(Show);
            foreach (var num in WelcomeScreen.Seatsnum)
            {
                Selectedlabel.Text += num + " ";
            }
        }
        public void Show (object button, EventArgs e)
        {
            MessageBox.Show(Adbox.Text+" "+ Soyadbox.Text+ "\r\n"+Selectedlabel.Text+"\r\n"+"Odenilecek Mebleg : " +WelcomeScreen.Seatsnum.Count * 7+" AZN");
            this.Close();
            
        }

    }
}
