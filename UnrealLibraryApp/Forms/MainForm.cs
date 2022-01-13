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
using UnrealLibraryApp.Forms;
using System.IO;

namespace UnrealLibraryApp
{
    public partial class MainForm : Form
    {
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private SaveFileDialog saveFileDialog1 = new SaveFileDialog();
        private Lib.File currentFile = new Lib.File();
        private Library currentLib = new Library();
        private int currentBookIndex;
        public MainForm()
        {
            InitializeComponent();
            NewLibrary();
        }

        #region Generic
        public void NewLibrary()
        {
            currentLib = new Library();
            currentLib.Books.Add(new Book("Новая книга"));
            UpdateLibrary();
            UpdateBook(0);
            Text = $"UNREAL LIBRARY - Новая библиотека";
        }
        public void UpdateLibrary()
        {
            listBoxBookList.Items.Clear();
            var booklist = currentLib.Books;
            foreach (Book b in booklist)
            {
                listBoxBookList.Items.Add($"{b.Name} - {b.Author}");
            }
        }

        public void UpdateBook(int ind)
        {
            if (ind == -1) { currentBookIndex = 0;}
            else { currentBookIndex = ind; }
            textBoxBookName.Text = currentLib.Books[currentBookIndex].Name;
            textBoxBookAuthor.Text = currentLib.Books[currentBookIndex].Author;
            textBoxBookGenre.Text = currentLib.Books[currentBookIndex].Genre;
            textBoxBookYear.Text = currentLib.Books[currentBookIndex].Year;
            textBoxBookComment.Text = currentLib.Books[currentBookIndex].Comment;
            numericUpDownBookMark.Value = currentLib.Books[currentBookIndex].Mark;
            if (currentLib.Books[currentBookIndex].Readen == true)
            {
                checkBoxBookRead.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxBookRead.CheckState = CheckState.Unchecked;
            }
        }

        public void SaveCheck()
        {
            if (currentFile.FileChanged == true)
            {
                DialogResult choice = MessageBox.Show("Сохранить текущий файл?", "Подтвердите действие", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (choice == DialogResult.Cancel) { return; }
                if (choice == DialogResult.Yes) 
                { 
                    currentFile.Save(currentLib);
                }
            }
        }
        #endregion

        #region ToolStrip
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCheck();
            openFileDialog1.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            openFileDialog1.Title = "Выберите файл...";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            currentFile.Path = openFileDialog1.FileName;
            currentLib = currentFile.Load();
            UpdateLibrary();
            UpdateBook(0);
            Text = $"UNREAL LIBRARY - {currentFile.Path}";
            MessageBox.Show("Файл открыт");
        }

        private void создатьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCheck();
            NewLibrary();
        }

        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            saveFileDialog1.Title = "Выберите файл...";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            currentFile.Path = saveFileDialog1.FileName;
            currentFile.Save(currentLib);
            Text = $"UNREAL LIBRARY - {currentFile.Path}";
            MessageBox.Show("Файл сохранён");
        }

        private void манифестКоммунистическойПартииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManifestForm manForm = new ManifestForm();
            manForm.Show();
        }

        private void оToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"UNREAL LIBRARY
(нереальная не потому что крутая, а потому что не существует)

Главный разработчик: Денис Куликов
Главный дизайнер: Денис Куликов
Главный инженер: Денис Куликов
Человек, который получит '5' на зачёте: Денис Куликов

2022");
        }

        #endregion

        #region ButtonLogic
        private void buttonAddBookToLib_Click(object sender, EventArgs e)
        {
            currentLib.Books.Add(new Book("Новая книга"));
            UpdateLibrary();
        }
        private void buttonDeleteBookFromLib_Click(object sender, EventArgs e)
        {
            if (currentLib.Books.Count <= 1)
            {
                MessageBox.Show("Нельзя удалить последнюю книгу!");
            }
            else
            {
                currentLib.Books.RemoveAt(currentBookIndex);
                UpdateLibrary();
                UpdateBook(0);
            }
        }
        private void buttonLibStats_Click(object sender, EventArgs e)
        {
            StatsForm statForm = new StatsForm();
            statForm.UpdateForm(currentLib);
            statForm.Show();
        }

        private void buttonGraphs_Click(object sender, EventArgs e)
        {
            GraphsForm graphForm = new GraphsForm();
            graphForm.UpdateForm(currentLib);
            graphForm.Show();
        }

        private void buttonTitleForm_Click(object sender, EventArgs e)
        {
            TitleForm titleForm = new TitleForm();
            titleForm.Show();
        }

        #endregion

        #region BookLogic
        private void textBoxBookComment_TextChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Comment = textBoxBookComment.Text;
            currentFile.FileChanged = true;
        }

        private void textBoxBookName_TextChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Name = textBoxBookName.Text;
            listBoxBookList.Items[currentBookIndex] = $"{currentLib.Books[currentBookIndex].Name} - {currentLib.Books[currentBookIndex].Author}";
            currentFile.FileChanged = true;
        }

        private void textBoxBookAuthor_TextChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Author = textBoxBookAuthor.Text;
            listBoxBookList.Items[currentBookIndex] = $"{currentLib.Books[currentBookIndex].Name} - {currentLib.Books[currentBookIndex].Author}";
            currentFile.FileChanged = true;
        }

        private void textBoxBookGenre_TextChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Genre = textBoxBookGenre.Text;
            currentFile.FileChanged = true;
        }

        private void checkBoxBookRead_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxBookRead.CheckState == CheckState.Checked)
            {
                currentLib.Books[currentBookIndex].Readen = true;
            }
            else
            {
                currentLib.Books[currentBookIndex].Readen = false;
            }
            currentFile.FileChanged = true;
        }

        private void textBoxBookYear_TextChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Year = textBoxBookYear.Text;
            currentFile.FileChanged = true;
        }

        private void numericUpDownBookMark_ValueChanged(object sender, EventArgs e)
        {
            currentLib.Books[currentBookIndex].Mark = (int) numericUpDownBookMark.Value;
            currentFile.FileChanged = true;
        }
        private void listBoxBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBook(listBoxBookList.SelectedIndex);
            UpdateLibrary();
        }


        #endregion

    }
}
