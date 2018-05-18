using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Rom2WAD : Form
    {
        public Rom2WAD()
        {
            InitializeComponent();
        }

        static void GenerateID(string command)
        {
            try
            {
                ProcessStartInfo ProcessInfo;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
                Process.Start(ProcessInfo);
            }
            catch
            {
                MessageBox.Show("An error has occured.");
            } 
        }

        private void WADFILE_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Original WAD File";
            theDialog.Filter = "WAD files|*.wad";
            theDialog.InitialDirectory = @"C:\";


            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string fullPath = theDialog.FileName;
                            string fileName = theDialog.SafeFileName;
                            string path = fullPath.Replace(fileName, "") + fileName;
                            textBox1.Text = path;

                            WADFILE.Text = fileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Error: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select Z64 File";
            theDialog.Filter = "Z64 files|*.z64";
            theDialog.InitialDirectory = @"C:\";


            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string fullPath = theDialog.FileName;
                            string fileName = theDialog.SafeFileName;
                            string path = fullPath.Replace(fileName, "");
                            textBox4.Text = path + fileName;

                            button1.Text = fileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Error: " + ex.Message);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select GZInject.exe";
            theDialog.Filter = "Execute File|*.exe";
            theDialog.InitialDirectory = @"C:\";


            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string fullPath = theDialog.FileName;
                            string fileName = theDialog.SafeFileName;
                            string path = fullPath.Replace(fileName, "");
                            textBox2.Text = path;
                            textBox3.Text = fileName;

                            button2.Text = fileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Error: " + ex.Message);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            /*
            GENERATE CHANNELID
            */
            Random rnd = new Random();

            string chars1 = "BCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chars2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int num1 = rnd.Next(0, chars1.Length - 1);
            int num2 = rnd.Next(0, chars2.Length - 1);

            char ran1 = chars1[num1];
            char ran2 = chars2[num2];

            channelID.Text = "N" + ran1 + ran2 + "E";

            //Output
            string output = System.Environment.CurrentDirectory + "\\" + channelName.Text + ".wad";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please select the original WAD file.");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please select your GZInject.exe file.");
            }
            else
            {
                //DELETE common-key.bin
                if (File.Exists(textBox2.Text + "common-key.bin"))
                {
                    File.Delete(textBox2.Text + "common-key.bin");
                }

                string cmdrun = "cd " + textBox2.Text + "&&" + textBox3.Text + " -a genkey" + "&&" + "gzinject --cleanup -a inject -w \"" + textBox1.Text + "\" -i " + channelID.Text + " -t \"" + channelName.Text + "\" -o \"" + output + "\" --rom \"" + textBox4.Text + "\" --disable-controller-remappings";

                //MessageBox.Show(cmdrun);
                GenerateID(cmdrun);
            }
        }
    }
}
