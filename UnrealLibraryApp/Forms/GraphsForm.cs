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
            UpdateChartReadBooks(lib);
            UpdateChartMarkBooks(lib);
            UpdateChartGenreBooks(lib);
            UpdateChartReadBooksByMonth(lib);
        }
        // Логику по подготовке данных для графиков либо в отдельный класс либо в Library
        public void UpdateChartReadBooks(Library lib)
        {
            this.chartReadBooks.Titles.Clear();
            this.chartReadBooks.Series.Clear();
            // Ты уже спалился, что знаешь про нруппировку... 
            string[] seriesArray = { "Прочитанные книги", "Непрочитанные книги" };
            int[] pointsArray = { lib.Books.Where(t => t.Readen.Equals(true)).Count(), lib.Books.Where(t => t.Readen.Equals(false)).Count() };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                this.chartReadBooks.Series.Add(seriesArray[i]);
                this.chartReadBooks.Series[seriesArray[i]].Points.Add(pointsArray[i]);
            }
        }

        public void UpdateChartMarkBooks(Library lib)
        {
            this.chartMarkBooks.Titles.Clear();
            this.chartMarkBooks.Series.Clear();
            // Это что засрань....
            string[] seriesArray = { "5", "4", "3", "2", "1", "Не оценено / 0" };
            int[] pointsArray = { lib.Books.Where(t => t.Mark.Equals(5)).Count(),
                lib.Books.Where(t => t.Mark.Equals(4)).Count(), lib.Books.Where(t => t.Mark.Equals(3)).Count(),
                lib.Books.Where(t => t.Mark.Equals(2)).Count(), lib.Books.Where(t => t.Mark.Equals(1)).Count(),
                lib.Books.Where(t => t.Mark.Equals(0)).Count(),};

            for (int i = 0; i < seriesArray.Length; i++)
            {
                this.chartMarkBooks.Series.Add(seriesArray[i]);
                this.chartMarkBooks.Series[seriesArray[i]].Points.Add(pointsArray[i]);
            }

        }

        public void UpdateChartGenreBooks(Library lib)
           {
            this.chartGenreBooks.Titles.Clear();
            this.chartGenreBooks.Series.Clear();
            this.chartGenreBooks.Series.Add("0");
            this.chartGenreBooks.Series[0].IsValueShownAsLabel = true;

            var GenreList = lib.Books.GroupBy(b => b.Genre).ToList();
            this.chartGenreBooks.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (IGrouping<string, Book> b in GenreList)
            {
                this.chartGenreBooks.Series[0].Points.AddXY(b.Key, b.Count());
            }
            this.chartGenreBooks.Series[0].Sort(PointSortOrder.Descending);
        }

        public void UpdateChartReadBooksByMonth(Library lib)
        {
            this.chartReadBooksByMonth.Titles.Clear();
            this.chartReadBooksByMonth.Series.Clear();

            // А то есть про группировку ты знаешь, а почему не пользуешься в UpdateChartMarkBooks?
            var MonthList = lib.Books
                        .Where(g => g.Readen == true)
                        .GroupBy(x => new { x.DayRead.Month, x.DayRead.Year })
                        .OrderByDescending(g => g.Key.Year).ThenBy(g => g.Key.Month);

            foreach (var m in MonthList)
            {
                DateTime d = new DateTime(m.Key.Year, m.Key.Month, DateTime.Now.Day);
                this.chartReadBooksByMonth.Series.Add(d.ToString("Y"));
                this.chartReadBooksByMonth.Series[d.ToString("Y")].Points.Add(m.Count());
            }
        }
    }
}
