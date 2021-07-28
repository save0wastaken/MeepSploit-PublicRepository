using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeePloit
{
    public partial class KeySystem : Form
    {
        private int amount;

        public KeySystem()
        {
            InitializeComponent();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC5McxnkKYtXgAMeDTs1C23Q?sub_confirmation=1");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cdn.discordapp.com/attachments/862794550736191492/869945982761201734/Open_File.txt");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            string gettext = siticoneTextBox1.Text;
            int gettext_amount = gettext.Length;

            if (gettext_amount > 0)
            {
                WebClient wc = new WebClient();
                string ks = wc.DownloadString("https://raw.githubusercontent.com/save0wastaken/MeePloit/main/Open%20File.txt");

                if (ks.Contains(siticoneTextBox1.Text))
                {
                    //true side
                    this.Hide();
                    LoaderUI loaderUI = new LoaderUI();
                    loaderUI.Show();
                }
                else
                {
                   //false side
                    MessageBox.Show("Nice Try :BRUH:", "Wrong Key!");
                }
            }
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QtBDL8EiNZo&ab_channel=Rickrollingnoads");
        }
    }
}
