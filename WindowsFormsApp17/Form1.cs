using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        List<int> ints_list;                                                         //A list of integers, ints_list.                                                                                                         
        Random r;                                                                    //A Random-type variable, r.                                                   

        public Form1()
        {
            InitializeComponent();                                                   //Initialize Components.                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.r = new Random();                                                   //Random-type variable, r loads.                     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = Stopwatch.StartNew();                                  //A Stopwatch-type variable, watch which, works as a counter in this case.                    
            int num_input;                                                           //An int-type variable, num_input, which keeps the input of the textBox1. 

            try
            {
                num_input = (int)Convert.ToInt32(this.textBox1.Text);                //Every input in textBox1 converts to 32-bit integer.                                                    
            }
            catch                                                                    //Exception.
            {
                return;
            }
            this.richTextBox1.Clear();                                               //At every button's click, clears the richTextBox1 content.  

            int[] ints_array = new int[num_input];                                   //An int-type array, ints_array which, contains the num_input variable.   

            this.ints_list = new List<int>(num_input);                               //At every button's click, ints_list contains the num_input.              

            for (int i = 0; i < num_input; i++)                                      //A for-loop.                                                   
            {
                this.ints_list.Add(i);                                               //Adds every number, smaller than num_input to ints_list.                                        
            }

            for (int j = 0; j < num_input; j++)                                      //A for-loop.                         
            {
                int index = this.r.Next(0, num_input - j);                           //An int-type variable, index which, randomly selects as many index as the value of num_input.                                                                             
                int num1 = this.ints_list[index];                                    //An int-type variable, num1 which, equals to the index of the ints_list.                                                   
                ints_array[j] = num1 + 1;                                            //Int-type array, ints_array equals to num1 + 1, at every loop.                                   
                this.ints_list.Remove(num1);                                         //Removes the selected number from ints_list, at every loop.                                                   
            }

            watch.Stop();                                                            //Stopwatch-type variable, watch stops.                                   
            this.label3.Text = watch.ElapsedMilliseconds.ToString();                 //Stopwatch-type variable, watch appears at label3 as a String.  
            
            for (int k = 0; k < ints_array.Length; k++)                              //A for-loop.                                                                   
            {                                                                       
                int num2 = ints_array[k];                                            //An int-type variable, num2 which, equals to ints_array.                                                          
                this.richTextBox1.AppendText(num2.ToString() + Environment.NewLine); //At every button's click, num2 (i.e. ints_array) appears as a String at richTextBox1.                                                             
            }
        }
    }
}
