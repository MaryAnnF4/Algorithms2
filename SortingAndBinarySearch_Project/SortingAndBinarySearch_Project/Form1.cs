using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAndBinarySearch_Project
{
    public partial class Form1 : Form
    {
        Sorting Sort;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Button_Selection_Click(object sender, EventArgs e)
        {
            Sort = new Sorting();
            int[] CreatedArray = Sort.CreateRandomArray(5);
            label_DisplayOriginal.Text = Sort.PrintArray(CreatedArray);

            int[] SortedArray = Sort.SelectionSort(CreatedArray);
            label_DisplaySorted.Text = Sort.PrintArray(SortedArray);
        }

        private void Button_Insertion_Click(object sender, EventArgs e)
        {
            Sort = new Sorting();
            int[] CreatedArray = Sort.CreateRandomArray(5);
            label_DisplayOriginal.Text = Sort.PrintArray(CreatedArray);

            int[] SortedArray = Sort.InsertionSort(CreatedArray);
            label_DisplaySorted.Text += Sort.PrintArray(SortedArray);
        }

    
    }
}
