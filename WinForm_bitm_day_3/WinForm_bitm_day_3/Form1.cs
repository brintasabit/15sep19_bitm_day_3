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
        int index = 0;
        
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

            /* int[] number = new int[10];
             number[0] = 1;
             number[1] = 1;
             number[2] = 2;
             number[3] = 3;
             number[4] = 4;
             number[5] = 5;
             number[6] = 6;
             number[7] = 7;
             number[8] = 8;
             number[9] = 9;
             // number[0] = 1;
             string showNumber = "";
             for (int i=0;i<10;i++)
             {
                 showNumber += (+number[i]);
               // Array.Reverse(number);
             }

             MessageBox.Show(showNumber);
            // MessageBox.Show(Array.Reverse(number));

     */

            // int[] number = new int[100];
            /*number[0] = 2;
            number[1] = 5;
            number[2] = 7;*/
            /*string array = inputTextBox.Text;
            int[] number = Convert.ToInt32(inputTextBox.Text);
            for (int i = 0; i < n; i++)
            {
                showNumber += (+number[i]);
                // Array.Reverse(number);
            }
            MessageBox.Show(showNumber);*/

            string showNumber = " ";
            for (int i = 0; i < size; i++)
            {

                showNumber += array[i];

            }

            MessageBox.Show("\n"+showNumber+"\n");
            for (int j = size; j > size-1; j--)
            {
                showNumber += array[j];
            }
            MessageBox.Show("\n" + showNumber + "\n");











        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (index < size)
            {
                array[index] = Convert.ToInt32(inputArrayTextBox.Text);
                index++;
                inputArrayTextBox.Text = "";
            }
            else
            {
                array[index] = Convert.ToInt32(inputArrayTextBox.Text);
                index--;
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
