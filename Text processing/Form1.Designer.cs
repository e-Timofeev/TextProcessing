namespace Text_processing
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ForListView = new System.Windows.Forms.Label();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Leght = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Status = new System.Windows.Forms.LinkLabel();
            this.Processing = new System.Windows.Forms.Label();
            this.SaveFiles = new System.Windows.Forms.Button();
            this.FileDownload = new System.Windows.Forms.Button();
            this.LogProcessing = new System.Windows.Forms.RichTextBox();
            this.Actions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Leght)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HotTracking = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 198);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // ForListView
            // 
            this.ForListView.AutoSize = true;
            this.ForListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForListView.Location = new System.Drawing.Point(3, 0);
            this.ForListView.Name = "ForListView";
            this.ForListView.Size = new System.Drawing.Size(374, 13);
            this.ForListView.TabIndex = 2;
            this.ForListView.Text = "Выбранные файлы для дальнейшей обработки";
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.checkBox2);
            this.Actions.Controls.Add(this.checkBox1);
            this.Actions.Controls.Add(this.Leght);
            this.Actions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Actions.Location = new System.Drawing.Point(3, 271);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(374, 96);
            this.Actions.TabIndex = 3;
            this.Actions.TabStop = false;
            this.Actions.Text = "Обработка";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(228, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "удалить знаки препинания [. , ? ! : ; - (  )]";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(268, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "удалить слова с длиной символов меньше чем:";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Leght
            // 
            this.Leght.Dock = System.Windows.Forms.DockStyle.Right;
            this.Leght.Location = new System.Drawing.Point(296, 16);
            this.Leght.Name = "Leght";
            this.Leght.Size = new System.Drawing.Size(75, 20);
            this.Leght.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.Status, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.Processing, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.ForListView, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.Actions, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.SaveFiles, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.FileDownload, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.LogProcessing, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(761, 421);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status.Image = global::Text_processing.Properties.Resources.download;
            this.Status.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Status.Location = new System.Drawing.Point(383, 370);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(375, 51);
            this.Status.TabIndex = 5;
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Status.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Status_LinkClicked);
            // 
            // Processing
            // 
            this.Processing.AutoSize = true;
            this.Processing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Processing.Location = new System.Drawing.Point(383, 0);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(375, 13);
            this.Processing.TabIndex = 5;
            this.Processing.Text = "Обработанные файлы";
            // 
            // SaveFiles
            // 
            this.SaveFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFiles.Image = global::Text_processing.Properties.Resources.save;
            this.SaveFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveFiles.Location = new System.Drawing.Point(3, 373);
            this.SaveFiles.Name = "SaveFiles";
            this.SaveFiles.Size = new System.Drawing.Size(374, 45);
            this.SaveFiles.TabIndex = 2;
            this.SaveFiles.Text = "Сохранить обработанные файлы";
            this.SaveFiles.UseVisualStyleBackColor = true;
            this.SaveFiles.Click += new System.EventHandler(this.SaveFiles_Click);
            // 
            // FileDownload
            // 
            this.FileDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDownload.Image = global::Text_processing.Properties.Resources.download_2;
            this.FileDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileDownload.Location = new System.Drawing.Point(3, 220);
            this.FileDownload.Name = "FileDownload";
            this.FileDownload.Size = new System.Drawing.Size(374, 45);
            this.FileDownload.TabIndex = 1;
            this.FileDownload.Text = "Загрузить файлы";
            this.FileDownload.UseVisualStyleBackColor = true;
            this.FileDownload.Click += new System.EventHandler(this.FileDownload_Click);
            // 
            // LogProcessing
            // 
            this.LogProcessing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogProcessing.Location = new System.Drawing.Point(383, 16);
            this.LogProcessing.Name = "LogProcessing";
            this.tableLayoutPanel.SetRowSpan(this.LogProcessing, 3);
            this.LogProcessing.Size = new System.Drawing.Size(375, 351);
            this.LogProcessing.TabIndex = 4;
            this.LogProcessing.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 421);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обработка текстовых файлов";
            this.Actions.ResumeLayout(false);
            this.Actions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Leght)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FileDownload;
        private System.Windows.Forms.Label ForListView;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.NumericUpDown Leght;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label Processing;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel Status;
        protected System.Windows.Forms.ListView listView1;
        protected System.Windows.Forms.Button SaveFiles;
        protected System.Windows.Forms.RichTextBox LogProcessing;
    }
}

