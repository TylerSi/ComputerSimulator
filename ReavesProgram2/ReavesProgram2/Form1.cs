using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ReavesProgram2
{

    public partial class Form1 : Form
    {
        //Show console
        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        */

        //Declare string array of 100
        string[] memory = new string[100];
        int lineCount = 0;
        string cell;

        public Form1()
        {
            InitializeComponent();            

            
            textBox1.Enabled = false;

            //Set program counter to 0
            int programCounter = 0;
            textBox4.Text = programCounter.ToString();

            //Set accumulator to 0
            int accumulator = 0;
            textBox3.Text = accumulator.ToString();

            //Fill with numbers 0-99
            for (int i = 0; i < 100; i++)
            {
                syncTextBox2.Text += i + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        public string programContents
        {
            get { return textBox7.Text; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Clear memory items
            syncTextBox1.Clear();
            textBox6.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Text = "0";
            textBox5.Clear();
            lineCount = 0;
            button5.Enabled = true;
            int accumulator = 0;
            textBox3.Text = accumulator.ToString();

            //Load program contents into memory
            string[] tempArray = textBox7.Lines;
            for (int i = 0; i < tempArray.Length; i++)
            {
                memory[i] = tempArray[i];
                string temp = memory[i];
                syncTextBox1.Text += temp + Environment.NewLine;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (memory[lineCount] == null)
            {
                MessageBox.Show("End of execution.");
            }
            else
            {
                //Fetch and decode instructions for execution
                string temp = memory[lineCount];
                string[] split = memory[lineCount].Split();

                int tempInt = 0;
                if (memory[lineCount] == "" || int.TryParse(memory[lineCount], out tempInt) == true)
                {
                    MessageBox.Show("End of execution.");
                }
                else
                {                                        
                    if (split[0] != "HALT")
                    {
                        //Get memory position
                        cell = split[1];
                        //Write to register
                        textBox5.Text = split[1];
                    }
                    else
                    {
                        ;
                    }                    
                }
                int intCell = Int32.Parse(cell);

                //Clear text boxes
                textBox2.Clear();
                syncTextBox1.Clear();

                //Write to register
                textBox6.Text = split[0];

                //Handle programCounter
                int pc = Int32.Parse(textBox4.Text);
                pc++;
                programCounter = pc.ToString();
                textBox4.Text = programCounter;

                if (split[0] == "READ")
                {
                    textBox1.Enabled = true;
                    textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);
                    //Clear textBox1 and disable step button
                    textBox1.Clear();
                    button5.Enabled = false;
                }

                if (split[0] == "WRIT")
                {
                    textBox2.Text = memory[intCell];
                }

                if (split[0] == "LOAD")
                {
                    textBox3.Text = memory[intCell];
                }

                if (split[0] == "STOR")
                {
                    memory[intCell] = textBox3.Text;
                }

                if (split[0] == "ADD")
                {
                    int acc = Int32.Parse(textBox3.Text);
                    string temp2 = memory[intCell];
                    int var = Int32.Parse(temp2);
                    int sum = acc + var;
                    textBox3.Text = sum.ToString();
                }

                if (split[0] == "SUB")
                {
                    int acc = Int32.Parse(textBox3.Text);
                    string temp2 = memory[intCell];
                    int var = Int32.Parse(temp2);
                    int difference = acc - var;
                    textBox3.Text = difference.ToString();
                }

                if (split[0] == "DIV")
                {
                    int acc = Int32.Parse(textBox3.Text);
                    string temp2 = memory[intCell];
                    int var = Int32.Parse(temp2);
                    int quotient = acc / var;
                    textBox3.Text = quotient.ToString();
                }

                if (split[0] == "MULT")
                {
                    int acc = Int32.Parse(textBox3.Text);
                    string temp2 = memory[intCell];
                    int var = Int32.Parse(temp2);
                    int product = acc * var;
                    textBox3.Text = product.ToString();
                }

                if (split[0] == "JUMP")
                {
                    textBox4.Text = split[1];
                    int tempCount = Int32.Parse(split[1]);
                    string[] tempSplit = memory[lineCount].Split();
                    textBox6.Text = tempSplit[0];
                    textBox5.Text = tempSplit[1];
                    lineCount = tempCount - 1;
                }

                if (split[0] == "JMPN")
                {
                    int tempAcc = Int32.Parse(textBox3.Text);
                    if (tempAcc < 0)
                    {
                        textBox4.Text = split[1];
                        int tempCount = Int32.Parse(split[1]);
                        string[] tempSplit = memory[lineCount].Split();
                        textBox6.Text = tempSplit[0];
                        textBox5.Text = tempSplit[1];
                        lineCount = tempCount - 1;
                    }
                    else
                    {
                        ;
                    }
                }

                if (split[0] == "JMPZ")
                {
                    int tempAcc = Int32.Parse(textBox3.Text);
                    if (tempAcc == 0)
                    {
                        textBox4.Text = split[1];
                        int tempCount = Int32.Parse(split[1]);
                        string[] tempSplit = memory[lineCount].Split();
                        textBox6.Text = tempSplit[0];
                        textBox5.Text = tempSplit[1];
                        lineCount = tempCount - 1;
                    }
                    else
                    {
                        ;
                    }
                }

                if (split[0] == "MODA")
                {
                    int position = Int32.Parse(split[1]);
                    string newLine = memory[position];
                    string[] tempSplit = newLine.Split();
                    memory[position] = tempSplit[0] + " " + textBox3.Text;
                }

                if (split[0] == "HALT")
                    {
                        button5.Enabled = false;
                        MessageBox.Show("Execution complete!");
                    }

                //Refresh lines in memory
                for (int i = 0; i < 100; i++)
                {
                    syncTextBox1.Text += memory[i] + Environment.NewLine;
                }

            }//End blank line

            //Add to lineCount
            lineCount++;
            
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                if (syncTextBox1.Text == "")
                {
                    break;
                }
                if (memory[i] == null)
                {
                    //MessageBox.Show("Program contents empty.");
                    break;
                }
                else
                {
                    button5.PerformClick();                   
                }           
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBox myText = (TextBox)sender;

                syncTextBox1.Clear();
                button5.Enabled = true;
                textBox1.Enabled = false;

                string temp = memory[lineCount - 1];

                if (memory[lineCount - 1] != null || memory[lineCount - 1] != "")
                {
                    string[] split = memory[lineCount - 1].Split();

                    int tempInt = 0;
                    if (memory[lineCount - 1] == "" || int.TryParse(memory[lineCount - 1], out tempInt) == true)
                    {
                        MessageBox.Show("End of execution.");
                    }
                    else
                    {
                        if (split[0] != "HALT")
                        {
                            string cell = split[1];
                            int intCell = Int32.Parse(cell);
                            memory[intCell] = textBox1.Text;
                        }
                    }
                             
                    //Refresh lines in memory
                    for (int i = 0; i < 100; i++)
                    {
                        syncTextBox1.Text += memory[i] + Environment.NewLine;
                    }
                }
                else
                {
                    MessageBox.Show("End of execution");
                }
            }
        }

        public string programCounter { get; set; }

        private void button7_Click(object sender, EventArgs e)
        {
            if (syncTextBox1.Text != "")
            {
                button5.Enabled = true;
                syncTextBox1.Clear();
                textBox6.Clear();
                textBox3.Clear();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Text = "0";
                textBox5.Clear();
                textBox1.Enabled = false;
                lineCount = 0;
                int accumulator = 0;
                textBox3.Text = accumulator.ToString();
            }

            for (int i = 0; i < 100; i++)
            {
                memory[i] = "";
            }

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    textBox7.Text = File.ReadAllText(file);
                }
                catch (IOException)
                {
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter myStream = new StreamWriter(saveFileDialog1.FileName, false);
                myStream.WriteLine(textBox7.Text);
                myStream.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void syncTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void syncTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If user input is required when using the Run All function, press Run All again after entering a value in the input box.");
        }        

    }//End public class Form1

}//End namespace ReavesProgram2