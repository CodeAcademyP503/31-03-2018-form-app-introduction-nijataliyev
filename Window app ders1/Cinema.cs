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
    public partial class Cinema : Form
    {
        public Cinema()
        {
            InitializeComponent();
            Cinema1.Click += new EventHandler(Cinemadata);
            Cinema2.Click += new EventHandler(Cinemadata);
            Cinema3.Click += new EventHandler(Cinemadata);
            Cinema4.Click += new EventHandler(Cinemadata);
        }
        public void Cinemadata(object obj, EventArgs e)
        {
            WelcomeScreen seats = new WelcomeScreen();
            seats.Show();
        }

    }
}
