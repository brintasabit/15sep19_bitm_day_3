using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_bitm_day_3
{
    public partial class Form1 : Form
    {
        const int size = 3;
        int[] array = new int[size];
        int[] array2 = new int[size];
        int index = 0;
        int sum = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {

            /*string[] name = new string[5];
            name[0] = "Brinta";
            name[1] = "Brinta";
            name[2] = "Brinta";
            name[3] = "Brinta";
            name[4] = "Brinta";
            int[] age = new int[] {23,24,25,26,27};
            string showInfo=" ";
            for (int i = 0; i <= 4; i++)
            {
                showInfo +=("\nName: " + name[i] + "\nAge: " + age[i]);

            }
            MessageBox.Show(showInfo);*/


            // MessageBox.Show(Array.Reverse(number));




            string showNumber2 = " ";
            string showNumber = " ";
            for (int i = 0; i < size; i++)
            {

                showNumber += array[i];
                array[i] += array2[i];
                showNumber2 += array2[i];
                sum += array[i];
               
                
            }
            
            
            int q = Convert.ToInt32(sum);

            MessageBox.Show("array " + showNumber + "\n");
            MessageBox.Show("array2 " + showNumber2 + "\n");
            MessageBox.Show(""+q);
            inputArrayTextBox.Text = "";











        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (index < size)
            {
                array[index] = Convert.ToInt32(inputArrayTextBox.Text);
                index++;
                inputArrayTextBox.Text = "";
            }
            
            //int size= Convert.ToInt32(inputArrayTextBox.Text);
            //MessageBox.Show("Array Size " +size );

            
            //array = new int[size];
            //string[] inputArraySize = new string[size];
            // int[] inputArraySize = new int[] { Convert.ToInt32(inputArrayTextBox.Text) };
            // int inputArraySize[0] = Convert.ToInt32(inputArrayTextBox.Text) ;
            /* inputArrayTextBox.Text = "";
             inputArraySize[1] = Convert.ToInt32(inputArrayTextBox.Text);
             inputArrayTextBox.Text = "";
             inputArraySize[2] = Convert.ToInt32(inputArrayTextBox.Text);
             */
            
        }
    }
}
