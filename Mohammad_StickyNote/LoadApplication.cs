using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammad_StickyNote
{
    public partial class LoadApplication : Form
    {
        public LoadApplication()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if (rectangleShape2.Width >= 471)
                {
                    timer1.Stop();
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception)
            {
                return;
            }
          
        }
    }
}
