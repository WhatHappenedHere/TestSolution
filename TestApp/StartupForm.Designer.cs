﻿namespace TestApp
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завантажитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оновитиТаблицюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogPOA = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateOfIssue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvComplited = new System.Windows.Forms.DataGridView();
            this.columnNumberComplited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProductsComplited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAmountComplited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComplitedDocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDateOfIssueComplited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExpirationDateComplited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplited)).BeginInit();
            this.SuspendLayout();
            // 
            // mnStrip
            // 
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оновитиТаблицюToolStripMenuItem});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(686, 24);
            this.mnStrip.TabIndex = 1;
            this.mnStrip.Text = "mnStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиToolStripMenuItem,
            this.завантажитиToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.створитиToolStripMenuItem.Text = "Створити";
            this.створитиToolStripMenuItem.Click += new System.EventHandler(this.створитиToolStripMenuItem_Click);
            // 
            // завантажитиToolStripMenuItem
            // 
            this.завантажитиToolStripMenuItem.Name = "завантажитиToolStripMenuItem";
            this.завантажитиToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.завантажитиToolStripMenuItem.Text = "Завантажити";
            this.завантажитиToolStripMenuItem.Click += new System.EventHandler(this.завантажитиToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // оновитиТаблицюToolStripMenuItem
            // 
            this.оновитиТаблицюToolStripMenuItem.Name = "оновитиТаблицюToolStripMenuItem";
            this.оновитиТаблицюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.оновитиТаблицюToolStripMenuItem.Text = "Оновити таблицю";
            this.оновитиТаблицюToolStripMenuItem.Click += new System.EventHandler(this.оновитиТаблицюToolStripMenuItem_Click);
            // 
            // openFileDialogPOA
            // 
            this.openFileDialogPOA.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 259);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTemp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Діючі";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTemp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTemp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnProducts,
            this.columnAmount,
            this.columnDocumentNumber,
            this.columnDateOfIssue,
            this.columnExpirationDate,
            this.dataGridViewTextBoxColumn1});
            this.dgvTemp.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTemp.Location = new System.Drawing.Point(3, 3);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.ReadOnly = true;
            this.dgvTemp.Size = new System.Drawing.Size(672, 227);
            this.dgvTemp.TabIndex = 0;
            this.dgvTemp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemp_CellDoubleClick);
            this.dgvTemp.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemp_CellFormatting);
            this.dgvTemp.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvTemp_CellPainting);
            // 
            // columnNumber
            // 
            this.columnNumber.HeaderText = "№ п/п";
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.ReadOnly = true;
            // 
            // columnProducts
            // 
            this.columnProducts.HeaderText = "ТМЦ";
            this.columnProducts.Name = "columnProducts";
            this.columnProducts.ReadOnly = true;
            // 
            // columnAmount
            // 
            this.columnAmount.HeaderText = "Кількість";
            this.columnAmount.Name = "columnAmount";
            this.columnAmount.ReadOnly = true;
            // 
            // columnDocumentNumber
            // 
            this.columnDocumentNumber.HeaderText = "№ довіреності";
            this.columnDocumentNumber.Name = "columnDocumentNumber";
            this.columnDocumentNumber.ReadOnly = true;
            // 
            // columnDateOfIssue
            // 
            this.columnDateOfIssue.HeaderText = "Дата видачі";
            this.columnDateOfIssue.Name = "columnDateOfIssue";
            this.columnDateOfIssue.ReadOnly = true;
            // 
            // columnExpirationDate
            // 
            this.columnExpirationDate.HeaderText = "Дійсна до";
            this.columnExpirationDate.Name = "columnExpirationDate";
            this.columnExpirationDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Місце знаходження";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видалитиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити виділений ряд";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvComplited);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 233);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Завершені";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvComplited
            // 
            this.dgvComplited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComplited.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumberComplited,
            this.columnProductsComplited,
            this.columnAmountComplited,
            this.columnComplitedDocumentNumber,
            this.columnDateOfIssueComplited,
            this.columnExpirationDateComplited,
            this.columnPath});
            this.dgvComplited.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvComplited.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplited.Location = new System.Drawing.Point(3, 3);
            this.dgvComplited.Name = "dgvComplited";
            this.dgvComplited.ReadOnly = true;
            this.dgvComplited.Size = new System.Drawing.Size(672, 227);
            this.dgvComplited.TabIndex = 1;
            this.dgvComplited.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvComplited_CellFormatting);
            this.dgvComplited.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvComplited_CellMouseDoubleClick);
            this.dgvComplited.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvComplited_CellPainting);
            // 
            // columnNumberComplited
            // 
            this.columnNumberComplited.HeaderText = "№ п/п";
            this.columnNumberComplited.Name = "columnNumberComplited";
            this.columnNumberComplited.ReadOnly = true;
            // 
            // columnProductsComplited
            // 
            this.columnProductsComplited.HeaderText = "ТМЦ";
            this.columnProductsComplited.Name = "columnProductsComplited";
            this.columnProductsComplited.ReadOnly = true;
            // 
            // columnAmountComplited
            // 
            this.columnAmountComplited.HeaderText = "Кількість";
            this.columnAmountComplited.Name = "columnAmountComplited";
            this.columnAmountComplited.ReadOnly = true;
            // 
            // columnComplitedDocumentNumber
            // 
            this.columnComplitedDocumentNumber.HeaderText = "№ довіреності";
            this.columnComplitedDocumentNumber.Name = "columnComplitedDocumentNumber";
            this.columnComplitedDocumentNumber.ReadOnly = true;
            // 
            // columnDateOfIssueComplited
            // 
            this.columnDateOfIssueComplited.HeaderText = "Дата видачі";
            this.columnDateOfIssueComplited.Name = "columnDateOfIssueComplited";
            this.columnDateOfIssueComplited.ReadOnly = true;
            // 
            // columnExpirationDateComplited
            // 
            this.columnExpirationDateComplited.HeaderText = "Дійсна до";
            this.columnExpirationDateComplited.Name = "columnExpirationDateComplited";
            this.columnExpirationDateComplited.ReadOnly = true;
            // 
            // columnPath
            // 
            this.columnPath.HeaderText = "Місце знаходження";
            this.columnPath.Name = "columnPath";
            this.columnPath.ReadOnly = true;
            this.columnPath.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 283);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnStrip);
            this.MainMenuStrip = this.mnStrip;
            this.Name = "mainForm";
            this.Text = "Довіреність";
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplited)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завантажитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogPOA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTemp;
        private System.Windows.Forms.DataGridView dgvComplited;
        private System.Windows.Forms.ToolStripMenuItem оновитиТаблицюToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateOfIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumberComplited;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProductsComplited;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAmountComplited;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnComplitedDocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDateOfIssueComplited;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExpirationDateComplited;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
    }
}

