//Filename WordsOfWisdom
//Written by Zach Scroggins
//Written on December 1, 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Label1.MouseEnter += OnMouseEnterLabel1;
            Label1.MouseLeave += OnMouseLeaveLabel1;
            Label2.MouseEnter += OnMouseEnterLabel2;
            Label2.MouseLeave += OnMouseLeaveLabel2;
            Label3.MouseEnter += OnMouseEnterLabel3;
            Label3.MouseLeave += OnMouseLeaveLabel3;
            Label4.MouseEnter += OnMouseEnterLabel4;
            Label4.MouseLeave += OnMouseLeaveLabel4;
        }

        private void OnMouseEnterLabel1(object sender, EventArgs e)
        {
            this.Label1.BackColor = Color.White;
        }
        private void OnMouseLeaveLabel1(object sender, EventArgs e)
        {
            this.Label1.BackColor = Color.Black;
        }
        private void OnMouseEnterLabel2(object sender, EventArgs e)
        {
            this.Label2.BackColor = Color.White;
        }
        private void OnMouseLeaveLabel2(object sender, EventArgs e)
        {
            this.Label2.BackColor = Color.Black;
        }
        private void OnMouseEnterLabel3(object sender, EventArgs e)
        {
            this.Label3.BackColor = Color.White;
        }
        private void OnMouseLeaveLabel3(object sender, EventArgs e)
        {
            this.Label3.BackColor = Color.Black;
        }
        private void OnMouseEnterLabel4(object sender, EventArgs e)
        {
            this.Label4.BackColor = Color.White;
        }
        private void OnMouseLeaveLabel4(object sender, EventArgs e)
        {
            this.Label4.BackColor = Color.Black;
        }
    }
}
