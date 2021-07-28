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
    public partial class LoaderUI : Form
    {
        public LoaderUI()
        {
            InitializeComponent();
        }

        private async void siticoneButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void LoaderUI_Load(object sender, EventArgs e)
        {
            
            WebClient updatecheck = new WebClient();
            await Task.Delay(1000);
            panel3.Width = 120;
            if (!updatecheck.DownloadString("https://raw.githubusercontent.com/save0wastaken/MeePloit/main/UpdateCheck?token=AU72ZVC2XA3F3YTDXJM3AULBABWT6").Contains("1.0"))
            {
                
                label2.Text = ("You dont have the correct version of MeepSploit");
                MessageBox.Show("You dont have the correct version of MeepSploit Please go to the github for the latest version!", "MeepSploit");
                System.Diagnostics.Process.Start("https://github.com/save0wastaken/MeepSploit-PublicRepository/releases/tag/1.0");
                await Task.Delay(1000);
                Application.Exit();

            }
            else
            {
                await Task.Delay(1000);
                panel3.Width = 399;
                label2.Text = ("Checking if patched...");
                WebClient patchcheck = new WebClient();
                if (!patchcheck.DownloadString("https://raw.githubusercontent.com/save0wastaken/MeePloit/main/PatchCheck").Contains("patched"))
                {
                    //false side
                    label2.Text = ("MeepSploit is patched!");
                    MessageBox.Show("MeepSploit is patched! Please wait a little bit until then check the github if you are on an older version!", "MeepSploit");
                    System.Diagnostics.Process.Start("https://github.com/save0wastaken/MeepSploit-PublicRepository/releases/tag/1.0");
                    await Task.Delay(1000);
                    Application.Exit();
                }
                else
                {
                    //true side
                    await Task.Delay(3000);
                    panel3.Width = 475;
                    label2.Text = ("Launching MeepSploit...");
                    panel3.Width = 475;
                    await Task.Delay(1000);
                    this.Hide();
                    MainUI mainui = new MainUI();
                    mainui.Show();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
