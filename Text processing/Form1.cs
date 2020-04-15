using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_processing
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Состояние опции удаления слов.
        /// </summary>
        public bool State1 { get; set; } = false;

        /// <summary>
        /// Состояние опции удаления знаков препинания.
        /// </summary>
        public bool State2 { get; set; } = false;

        /// <summary>
        /// Путь для обработанных файлов.
        /// </summary>
        public string savePath { get; set; } = string.Empty;

        private string name = "";

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string n) : base()
        {
            name = n;
        }

        /// <summary>
        /// Выбор файлов для обработки из ФС.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDownload_Click(object sender, EventArgs e)
        {
            Status.Text = "";
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "Выбор файлов",
                Filter = "Text Files|*.txt;*.text;*.log",
                Title = "Открыть текстовые файлы",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                string[] files = openFileDialog.FileNames;
                foreach (string file in files)
                {
                    listView1.Items.Add(file);
                }
            }
        }

        /// <summary>
        /// Обработка файлов с учетом опций. В асинхронном режиме,чтобы не вешать UI.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void SaveFiles_Click(object sender, EventArgs e)
        {
            Status.Text = "";
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Выберите файлы для обработки.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!(State1 || State2))
            {
                MessageBox.Show("Выберите действие(я) для выбранных файлов.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LogProcessing.Text = string.Empty;
            FolderBrowserDialog dialogSave = new FolderBrowserDialog()
            {
                Description = "Выберите папку для сохранения",
            };

            //Обработка файлов из ListView
            if (dialogSave.ShowDialog() == DialogResult.OK)
            {
                savePath = dialogSave.SelectedPath;      // путь для сохранения обработанных файлов
                string line, pattern;
                line = pattern = string.Empty;
                List<string> list = listView1.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
                foreach (var t in list)
                {
                    if (!Directory.Exists(savePath))
                    {
                        Directory.CreateDirectory(savePath);
                    }
                    else
                    {
                        SaveFiles.Enabled = false;
                        // считывает файлы выбранные для обработки
                        using (StreamReader sr = new StreamReader(t.ToString(), Encoding.UTF8))
                        {
                            LogProcessing.AppendText(string.Format("Идет обработка файла: {0}...\n", Path.GetFileNameWithoutExtension(t)));
                            line = await sr.ReadToEndAsync();
                            // обработка в зависимости от опций
                            using (StreamWriter sw = new StreamWriter(Path.Combine(savePath, Path.GetFileNameWithoutExtension(t) + ".txt")))
                            {
                                #region Обе опции
                                if (State1 & State2)
                                {

                                    string s = await Task<string>.Factory.StartNew(() =>
                                    {
                                        string leght = Leght.Value.ToString();
                                        string str1 = Regex.Replace(line, string.Format(@"\b\w{{0,{1}}}\b", 1, Convert.ToInt32(leght)), string.Empty);
                                        string str2 = Regex.Replace(str1, "[?!.,-;:()]", string.Empty);
                                        return str2;
                                    });
                                    await sw.WriteAsync(s);
                                    LogProcessing.AppendText(string.Format("Завершена обработка файла: {0}\n\n", t));

                                }
                                #endregion
                                #region Удаление слов
                                else if (State1)
                                {
                                    string leght = Leght.Value.ToString();
                                    pattern = string.Format(@"\b\w{{0,{1}}}\b", 1, Convert.ToInt32(leght));
                                    string s = await Task<string>.Factory.StartNew(() =>
                                    {
                                        string str = Regex.Replace(line, pattern, string.Empty);
                                        return str;
                                    });
                                    await sw.WriteAsync(s);
                                    LogProcessing.AppendText(string.Format("Завершена обработка файла: {0}\n\n", t));

                                }
                                #endregion
                                #region Удаление знаков препинания
                                else if (State2)
                                {
                                    pattern = "[?!.,-;:()]";
                                    string s = await Task<string>.Factory.StartNew(() =>
                                    {
                                        string str = Regex.Replace(line, pattern, string.Empty);
                                        return str;
                                    });
                                    await sw.WriteAsync(s);
                                    LogProcessing.AppendText(string.Format("Завершена обработка файла: {0}\n\n", t));
                                }
                                #endregion
                            }

                        }
                    }
                }
                SaveFiles.Enabled = true;
                Status.Text = "Обработка выбранных файлов завершена!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) State1 = true;
            else State1 = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) State2 = true;
            else State2 = false;
        }

        /// <summary>
        /// Открыть файл из списка загруженных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listView1.SelectedItems[0];
            System.Diagnostics.Process.Start(firstSelectedItem.Text);
        }

        /// <summary>
        /// Отрывает папку с обработанными файлами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Status_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(savePath);
        }
    }
}
