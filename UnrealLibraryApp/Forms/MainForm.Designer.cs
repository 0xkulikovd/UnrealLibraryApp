
namespace UnrealLibraryApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.оToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.манифестКоммунистическойПартииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookGenre = new System.Windows.Forms.Label();
            this.labelBookRead = new System.Windows.Forms.Label();
            this.listBoxBookList = new System.Windows.Forms.ListBox();
            this.checkBoxBookRead = new System.Windows.Forms.CheckBox();
            this.labelBookMark = new System.Windows.Forms.Label();
            this.labelBookComment = new System.Windows.Forms.Label();
            this.textBoxBookComment = new System.Windows.Forms.TextBox();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.textBoxBookGenre = new System.Windows.Forms.TextBox();
            this.numericUpDownBookMark = new System.Windows.Forms.NumericUpDown();
            this.buttonLibStats = new System.Windows.Forms.Button();
            this.buttonGraphs = new System.Windows.Forms.Button();
            this.buttonAddBookToLib = new System.Windows.Forms.Button();
            this.buttonDeleteBookFromLib = new System.Windows.Forms.Button();
            this.textBoxBookYear = new System.Windows.Forms.TextBox();
            this.labelBookYear = new System.Windows.Forms.Label();
            this.buttonTitleForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookMark)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьФайлToolStripMenuItem,
            this.открытьФайлToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // создатьФайлToolStripMenuItem
            // 
            this.создатьФайлToolStripMenuItem.Name = "создатьФайлToolStripMenuItem";
            this.создатьФайлToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.создатьФайлToolStripMenuItem.Text = "Создать файл...";
            this.создатьФайлToolStripMenuItem.Click += new System.EventHandler(this.создатьФайлToolStripMenuItem_Click);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть файл...";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл...";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оToolStripMenuItem,
            this.манифестКоммунистическойПартииToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem2.Text = "Справка";
            // 
            // оToolStripMenuItem
            // 
            this.оToolStripMenuItem.Name = "оToolStripMenuItem";
            this.оToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.оToolStripMenuItem.Text = "О программе...";
            this.оToolStripMenuItem.Click += new System.EventHandler(this.оToolStripMenuItem_Click);
            // 
            // манифестКоммунистическойПартииToolStripMenuItem
            // 
            this.манифестКоммунистическойПартииToolStripMenuItem.Name = "манифестКоммунистическойПартииToolStripMenuItem";
            this.манифестКоммунистическойПартииToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.манифестКоммунистическойПартииToolStripMenuItem.Text = "Манифест коммунистической партии...";
            this.манифестКоммунистическойПартииToolStripMenuItem.Click += new System.EventHandler(this.манифестКоммунистическойПартииToolStripMenuItem_Click);
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Location = new System.Drawing.Point(12, 35);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(92, 13);
            this.labelBookName.TabIndex = 1;
            this.labelBookName.Text = "Название книги:";
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Location = new System.Drawing.Point(50, 58);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(54, 13);
            this.labelBookAuthor.TabIndex = 2;
            this.labelBookAuthor.Text = "Автор(ы):";
            // 
            // labelBookGenre
            // 
            this.labelBookGenre.AutoSize = true;
            this.labelBookGenre.Location = new System.Drawing.Point(65, 80);
            this.labelBookGenre.Name = "labelBookGenre";
            this.labelBookGenre.Size = new System.Drawing.Size(39, 13);
            this.labelBookGenre.TabIndex = 3;
            this.labelBookGenre.Text = "Жанр:";
            // 
            // labelBookRead
            // 
            this.labelBookRead.AutoSize = true;
            this.labelBookRead.Location = new System.Drawing.Point(40, 108);
            this.labelBookRead.Name = "labelBookRead";
            this.labelBookRead.Size = new System.Drawing.Size(64, 13);
            this.labelBookRead.TabIndex = 4;
            this.labelBookRead.Text = "Прочитано:";
            // 
            // listBoxBookList
            // 
            this.listBoxBookList.FormattingEnabled = true;
            this.listBoxBookList.Location = new System.Drawing.Point(394, 32);
            this.listBoxBookList.Name = "listBoxBookList";
            this.listBoxBookList.Size = new System.Drawing.Size(155, 199);
            this.listBoxBookList.TabIndex = 5;
            this.listBoxBookList.SelectedIndexChanged += new System.EventHandler(this.listBoxBookList_SelectedIndexChanged);
            // 
            // checkBoxBookRead
            // 
            this.checkBoxBookRead.AutoSize = true;
            this.checkBoxBookRead.Location = new System.Drawing.Point(110, 108);
            this.checkBoxBookRead.Name = "checkBoxBookRead";
            this.checkBoxBookRead.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBookRead.TabIndex = 6;
            this.checkBoxBookRead.UseVisualStyleBackColor = true;
            this.checkBoxBookRead.CheckStateChanged += new System.EventHandler(this.checkBoxBookRead_CheckStateChanged);
            // 
            // labelBookMark
            // 
            this.labelBookMark.AutoSize = true;
            this.labelBookMark.Location = new System.Drawing.Point(131, 108);
            this.labelBookMark.Name = "labelBookMark";
            this.labelBookMark.Size = new System.Drawing.Size(48, 13);
            this.labelBookMark.TabIndex = 7;
            this.labelBookMark.Text = "Оценка:";
            // 
            // labelBookComment
            // 
            this.labelBookComment.AutoSize = true;
            this.labelBookComment.Location = new System.Drawing.Point(12, 137);
            this.labelBookComment.Name = "labelBookComment";
            this.labelBookComment.Size = new System.Drawing.Size(121, 13);
            this.labelBookComment.TabIndex = 9;
            this.labelBookComment.Text = "Комментарий о книге:";
            // 
            // textBoxBookComment
            // 
            this.textBoxBookComment.Location = new System.Drawing.Point(15, 153);
            this.textBoxBookComment.Multiline = true;
            this.textBoxBookComment.Name = "textBoxBookComment";
            this.textBoxBookComment.Size = new System.Drawing.Size(373, 78);
            this.textBoxBookComment.TabIndex = 10;
            this.textBoxBookComment.TextChanged += new System.EventHandler(this.textBoxBookComment_TextChanged);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(110, 32);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(278, 20);
            this.textBoxBookName.TabIndex = 11;
            this.textBoxBookName.TextChanged += new System.EventHandler(this.textBoxBookName_TextChanged);
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(110, 55);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(278, 20);
            this.textBoxBookAuthor.TabIndex = 12;
            this.textBoxBookAuthor.TextChanged += new System.EventHandler(this.textBoxBookAuthor_TextChanged);
            // 
            // textBoxBookGenre
            // 
            this.textBoxBookGenre.Location = new System.Drawing.Point(110, 77);
            this.textBoxBookGenre.Name = "textBoxBookGenre";
            this.textBoxBookGenre.Size = new System.Drawing.Size(278, 20);
            this.textBoxBookGenre.TabIndex = 13;
            this.textBoxBookGenre.TextChanged += new System.EventHandler(this.textBoxBookGenre_TextChanged);
            // 
            // numericUpDownBookMark
            // 
            this.numericUpDownBookMark.Location = new System.Drawing.Point(185, 106);
            this.numericUpDownBookMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBookMark.Name = "numericUpDownBookMark";
            this.numericUpDownBookMark.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownBookMark.TabIndex = 14;
            this.numericUpDownBookMark.ValueChanged += new System.EventHandler(this.numericUpDownBookMark_ValueChanged);
            // 
            // buttonLibStats
            // 
            this.buttonLibStats.Location = new System.Drawing.Point(15, 237);
            this.buttonLibStats.Name = "buttonLibStats";
            this.buttonLibStats.Size = new System.Drawing.Size(155, 23);
            this.buttonLibStats.TabIndex = 15;
            this.buttonLibStats.Text = "Статистика библиотеки";
            this.buttonLibStats.UseVisualStyleBackColor = true;
            this.buttonLibStats.Click += new System.EventHandler(this.buttonLibStats_Click);
            // 
            // buttonGraphs
            // 
            this.buttonGraphs.Location = new System.Drawing.Point(15, 266);
            this.buttonGraphs.Name = "buttonGraphs";
            this.buttonGraphs.Size = new System.Drawing.Size(155, 23);
            this.buttonGraphs.TabIndex = 16;
            this.buttonGraphs.Text = "Графики";
            this.buttonGraphs.UseVisualStyleBackColor = true;
            this.buttonGraphs.Click += new System.EventHandler(this.buttonGraphs_Click);
            // 
            // buttonAddBookToLib
            // 
            this.buttonAddBookToLib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddBookToLib.BackgroundImage")));
            this.buttonAddBookToLib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddBookToLib.Location = new System.Drawing.Point(479, 237);
            this.buttonAddBookToLib.Name = "buttonAddBookToLib";
            this.buttonAddBookToLib.Size = new System.Drawing.Size(32, 32);
            this.buttonAddBookToLib.TabIndex = 17;
            this.buttonAddBookToLib.UseVisualStyleBackColor = true;
            this.buttonAddBookToLib.Click += new System.EventHandler(this.buttonAddBookToLib_Click);
            // 
            // buttonDeleteBookFromLib
            // 
            this.buttonDeleteBookFromLib.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteBookFromLib.BackgroundImage")));
            this.buttonDeleteBookFromLib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDeleteBookFromLib.Location = new System.Drawing.Point(517, 237);
            this.buttonDeleteBookFromLib.Name = "buttonDeleteBookFromLib";
            this.buttonDeleteBookFromLib.Size = new System.Drawing.Size(32, 32);
            this.buttonDeleteBookFromLib.TabIndex = 18;
            this.buttonDeleteBookFromLib.UseVisualStyleBackColor = true;
            this.buttonDeleteBookFromLib.Click += new System.EventHandler(this.buttonDeleteBookFromLib_Click);
            // 
            // textBoxBookYear
            // 
            this.textBoxBookYear.Location = new System.Drawing.Point(343, 106);
            this.textBoxBookYear.Name = "textBoxBookYear";
            this.textBoxBookYear.Size = new System.Drawing.Size(45, 20);
            this.textBoxBookYear.TabIndex = 19;
            this.textBoxBookYear.TextChanged += new System.EventHandler(this.textBoxBookYear_TextChanged);
            // 
            // labelBookYear
            // 
            this.labelBookYear.AutoSize = true;
            this.labelBookYear.Location = new System.Drawing.Point(264, 109);
            this.labelBookYear.Name = "labelBookYear";
            this.labelBookYear.Size = new System.Drawing.Size(73, 13);
            this.labelBookYear.TabIndex = 20;
            this.labelBookYear.Text = "Год издания:";
            // 
            // buttonTitleForm
            // 
            this.buttonTitleForm.Location = new System.Drawing.Point(176, 266);
            this.buttonTitleForm.Name = "buttonTitleForm";
            this.buttonTitleForm.Size = new System.Drawing.Size(96, 23);
            this.buttonTitleForm.TabIndex = 21;
            this.buttonTitleForm.Text = "Титульный лист";
            this.buttonTitleForm.UseVisualStyleBackColor = true;
            this.buttonTitleForm.Click += new System.EventHandler(this.buttonTitleForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 294);
            this.Controls.Add(this.buttonTitleForm);
            this.Controls.Add(this.labelBookYear);
            this.Controls.Add(this.textBoxBookYear);
            this.Controls.Add(this.buttonDeleteBookFromLib);
            this.Controls.Add(this.buttonAddBookToLib);
            this.Controls.Add(this.buttonGraphs);
            this.Controls.Add(this.buttonLibStats);
            this.Controls.Add(this.numericUpDownBookMark);
            this.Controls.Add(this.textBoxBookGenre);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.textBoxBookComment);
            this.Controls.Add(this.labelBookComment);
            this.Controls.Add(this.labelBookMark);
            this.Controls.Add(this.checkBoxBookRead);
            this.Controls.Add(this.listBoxBookList);
            this.Controls.Add(this.labelBookRead);
            this.Controls.Add(this.labelBookGenre);
            this.Controls.Add(this.labelBookAuthor);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "UNREAL LIBRARY";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookGenre;
        private System.Windows.Forms.Label labelBookRead;
        private System.Windows.Forms.ListBox listBoxBookList;
        private System.Windows.Forms.CheckBox checkBoxBookRead;
        private System.Windows.Forms.Label labelBookMark;
        private System.Windows.Forms.Label labelBookComment;
        private System.Windows.Forms.TextBox textBoxBookComment;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.TextBox textBoxBookGenre;
        private System.Windows.Forms.NumericUpDown numericUpDownBookMark;
        private System.Windows.Forms.Button buttonLibStats;
        private System.Windows.Forms.Button buttonGraphs;
        private System.Windows.Forms.Button buttonAddBookToLib;
        private System.Windows.Forms.Button buttonDeleteBookFromLib;
        private System.Windows.Forms.TextBox textBoxBookYear;
        private System.Windows.Forms.Label labelBookYear;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem манифестКоммунистическойПартииToolStripMenuItem;
        private System.Windows.Forms.Button buttonTitleForm;
    }
}

