
namespace UnrealLibraryApp.Forms
{
    partial class GraphsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphsForm));
            this.tabControlGraphs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chartReadBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartMarkBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartGenreBooks = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlGraphs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReadBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMarkBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlGraphs
            // 
            this.tabControlGraphs.Controls.Add(this.tabPage1);
            this.tabControlGraphs.Controls.Add(this.tabPage2);
            this.tabControlGraphs.Controls.Add(this.tabPage3);
            this.tabControlGraphs.Location = new System.Drawing.Point(12, 12);
            this.tabControlGraphs.Name = "tabControlGraphs";
            this.tabControlGraphs.SelectedIndex = 0;
            this.tabControlGraphs.Size = new System.Drawing.Size(345, 329);
            this.tabControlGraphs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chartReadBooks);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Прочитанные/Непрочитанные книги";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chartReadBooks
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReadBooks.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReadBooks.Legends.Add(legend1);
            this.chartReadBooks.Location = new System.Drawing.Point(7, 7);
            this.chartReadBooks.Name = "chartReadBooks";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReadBooks.Series.Add(series1);
            this.chartReadBooks.Size = new System.Drawing.Size(324, 290);
            this.chartReadBooks.TabIndex = 0;
            this.chartReadBooks.Text = "chartReadBooks";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartMarkBooks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartMarkBooks
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMarkBooks.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMarkBooks.Legends.Add(legend2);
            this.chartMarkBooks.Location = new System.Drawing.Point(7, 7);
            this.chartMarkBooks.Name = "chartMarkBooks";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMarkBooks.Series.Add(series2);
            this.chartMarkBooks.Size = new System.Drawing.Size(324, 290);
            this.chartMarkBooks.TabIndex = 0;
            this.chartMarkBooks.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartGenreBooks);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Жанры";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartGenreBooks
            // 
            chartArea3.Name = "ChartArea1";
            this.chartGenreBooks.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartGenreBooks.Legends.Add(legend3);
            this.chartGenreBooks.Location = new System.Drawing.Point(7, 7);
            this.chartGenreBooks.Name = "chartGenreBooks";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartGenreBooks.Series.Add(series3);
            this.chartGenreBooks.Size = new System.Drawing.Size(324, 290);
            this.chartGenreBooks.TabIndex = 0;
            this.chartGenreBooks.Text = "chart1";
            // 
            // GraphsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 353);
            this.Controls.Add(this.tabControlGraphs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphsForm";
            this.Text = "Графики";
            this.tabControlGraphs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartReadBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMarkBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGenreBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGraphs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReadBooks;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMarkBooks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenreBooks;
    }
}