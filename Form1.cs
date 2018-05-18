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
          //  theDialog.InitialDirectory = @"/";


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
                            RTB_USWadPath.Text = path;
                            string[] lines = { path, fileName };
                            System.IO.File.WriteAllLines(("location.txt"), lines);
                            textBox1.Text = path;
                         
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
            // theDialog.InitialDirectory = @"C:\";


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
                            RTB_RomPath.Text = path + fileName;
                            textBox4.Text = path + fileName;

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
                MessageBox.Show("Please select a WAD file.");
            }
            else if (File.Exists(textBox1.Text) != true)
            {
                MessageBox.Show("Selcted WAD file not found.");
            }
            else if (File.Exists(textBox2.Text + textBox3.Text) != true)
            {
                DialogResult dialogResult = MessageBox.Show("GZInject.exe not found in directory. Would you like to browse for the exe? (You only need to do this once).", "GZInject Not Found", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Stream myStream = null;
                    OpenFileDialog theDialog = new OpenFileDialog();
                    theDialog.Title = "Select GZInject.exe";
                    theDialog.Filter = "Execute File|*.exe";

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

                                   File.Copy((path + fileName), (System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gzinject\\" + fileName));
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not read file from disk. Error: " + ex.Message);
                        }
                    }
                } 
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please select your GZInject.exe file.");
            }
            else if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please select your randomizer ROM file.");
            }
            else if (File.Exists(textBox4.Text) != true)
            {
                MessageBox.Show("Selected ROM file not found.");
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
            private void label3_Click(object sender, EventArgs e)
        {

        }

        private void channelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rom2WAD_Load(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("gzinject");

            textBox3.Text = "gzinject.exe";
            textBox2.Text = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\gzinject\\";

            string textFileLocation = "location.txt";

            if (File.Exists(textFileLocation))
            {
                string line1 = File.ReadLines(textFileLocation).First(); 
                RTB_USWadPath.Text = line1;
                textBox1.Text = line1;
            }

        }

        private void RTB_USWadPath_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = RTB_USWadPath.Text;
        }

        private void RTB_RomPath_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = RTB_RomPath.Text;
        }

        private void channelName_TextChanged_1(object sender, EventArgs e)
        {
            if (channelName.TextLength > 20)
            {
                string text = channelName.Text;
                text = text.Remove(text.Length - 1);
                channelName.Text = text;
                channelName.SelectionStart = (channelName.Text.Length - 1);
            }
        }
    }
}
