using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace MeePloit
{
    public partial class MainUI : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormMoveable_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public MainUI()
        {
            InitializeComponent();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(fastColoredTextBox1.Text);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                fastColoredTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }
        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cdn.discordapp.com/attachments/822136683491360768/870035885004050472/rbxfpsunlocker.exe");
        }
    }
}