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

namespace UnrealLibraryApp
{
    public partial class ManifestForm : Form
    {
        public ManifestForm()
        {
            InitializeComponent();
            StreamReader fStream = new StreamReader(Environment.CurrentDirectory + @"\manifest.txt");
            textBoxManifest.Text = fStream.ReadToEnd();
            fStream.Close();
        }

        private void ManifestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
