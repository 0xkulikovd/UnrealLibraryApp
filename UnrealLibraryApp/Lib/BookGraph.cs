using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrealLibraryApp.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace UnrealLibraryApp.Lib
{
    static class BookGraph
    {
        public static void UpdateChartReadBooks(Library lib, Chart chart)
        { 
            chart.Titles.Clear();
            chart.Series.Clear();
            string[] seriesArray = { "Прочитанные книги", "Непрочитанные книги" };
            int[] pointsArray = { lib.GetBookCountByRead(true), lib.GetBookCountByRead(false) };

            for (int i = 0; i < seriesArray.Length; i++)
            {
                chart.Series.Add(seriesArray[i]);
                chart.Series[seriesArray[i]].Points.Add(pointsArray[i]);
            }
        }

        public static void UpdateChartMarkBooks(Library lib, Chart chart)
        {
            chart.Titles.Clear();
            chart.Series.Clear();
            string[] seriesArray = { "5", "4", "3", "2", "1", "Не оценено / 0" };
            int[] pointsArray = { lib.GetBookCountByMark(5), lib.GetBookCountByMark(4), 
                lib.GetBookCountByMark(3), lib.GetBookCountByMark(2), 
                lib.GetBookCountByMark(1), lib.GetBookCountByMark(0)};

            for (int i = 0; i < seriesArray.Length; i++)
            {
                chart.Series.Add(seriesArray[i]);
                chart.Series[seriesArray[i]].Points.Add(pointsArray[i]);
            }

        }

        public static void UpdateChartGenreBooks(Library lib, Chart chart)
        {
            chart.Titles.Clear();
            chart.Series.Clear();
            chart.Series.Add("0");
            chart.Series[0].IsValueShownAsLabel = true;

            var GenreList = lib.Books.GroupBy(b => b.Genre).ToList();
            chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (IGrouping<string, Book> b in GenreList)
            {
                chart.Series[0].Points.AddXY(b.Key, b.Count());
            }
            chart.Series[0].Sort(PointSortOrder.Descending);
        }

        public static void UpdateChartReadBooksByMonth(Library lib, Chart chart)
        {
            chart.Titles.Clear();
            chart.Series.Clear();

            var MonthList = lib.Books
                        .Where(g => g.Readen == true)
                        .GroupBy(x => new { x.DayRead.Month, x.DayRead.Year })
                        .OrderByDescending(g => g.Key.Year).ThenBy(g => g.Key.Month);

            foreach (var m in MonthList)
            {
                DateTime d = new DateTime(m.Key.Year, m.Key.Month, DateTime.Now.Day);
                chart.Series.Add(d.ToString("Y"));
                chart.Series[d.ToString("Y")].Points.Add(m.Count());
            }
        }
    }
}
