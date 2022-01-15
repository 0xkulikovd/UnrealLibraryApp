using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrealLibraryApp.Lib;

namespace UnrealLibraryApp
{
    public partial class StatsForm : Form
    {
        public StatsForm()
        {
            InitializeComponent();
        }

        public void UpdateForm(Library lib)
        {
            labelBookCount.Text = lib.Count.ToString();
            labelReadBookCount.Text = lib.GetBookCountByRead(true).ToString();
            labelUnReadBookCount.Text = lib.GetBookCountByRead(false).ToString();
            // Можно сделать умнее
            label0Mark.Text = lib.GetBookCountByMark(0).ToString();
            label1Mark.Text = lib.GetBookCountByMark(1).ToString();
            label2Mark.Text = lib.GetBookCountByMark(2).ToString();
            label3Mark.Text = lib.GetBookCountByMark(3).ToString();
            label4Mark.Text = lib.GetBookCountByMark(4).ToString();
            label5Mark.Text = lib.GetBookCountByMark(5).ToString();
            labelCommentedBookCount.Text = lib.GetBookCountByComment(true).ToString();
        }

        private void StatsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
