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
using System.Windows.Forms.DataVisualization.Charting;

namespace UnrealLibraryApp.Forms
{
    public partial class GraphsForm : Form
    {
        public GraphsForm()
        {
            InitializeComponent();
        }

        public void UpdateForm(Library lib)
        {
            BookGraph.UpdateChartReadBooks(lib, chartReadBooks);
            BookGraph.UpdateChartMarkBooks(lib, chartMarkBooks);
            BookGraph.UpdateChartGenreBooks(lib, chartGenreBooks);
            BookGraph.UpdateChartReadBooksByMonth(lib, chartReadBooksByMonth);
        }

    }
}
