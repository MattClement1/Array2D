/*
* Created by: Matthew Clement
* Created on: 19-Nov-2015
* Created for: Unit #5-05
* This program generates a 2D array and finds the average of the numbers inside
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array2D
{
    public partial class frmArray2D : Form
    {
        Random rndNum = new Random();

        public int FindAverage(int[,] numArray, ref ListBox list, int length, int width)
        {
            //Fill the array with random numbers and find the average

            int average = 0;

            for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
            {
                for (int widthCounter = 0; widthCounter < width; widthCounter++)
                {
                    int num = rndNum.Next(1, 99 + 1);
                    numArray[lengthCounter, widthCounter] = num;
                    average = average + num;
                    list.Items.Add(num);
                }
            }
            average = average / (length + width);

            return average;
        }

        public frmArray2D()
        {
            InitializeComponent();
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(this.txtLength.Text);
            int width = Convert.ToInt32(this.txtWidth.Text);
            int[,] array = new int[length, width];
            int average = 0;

            average = FindAverage(array,ref this.lstNumberList , length, width);

            this.lblAnswer.Text = Convert.ToString(average);
        }
    }
}
