namespace Brewery
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Сорт");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Название");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Объем");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Кол-во продаж в год");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Кол-во изделий в год");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Пиво", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Улица");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Дом");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Офис");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Индекс");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Кол-во сотрудников");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Адреса", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Имя");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Фамилия");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Отчество");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Дата рождения");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Должность");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Работники", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MainList = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainList)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(416, 938);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter2.Location = new System.Drawing.Point(416, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(22, 938);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(438, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(10, 938);
            this.splitter3.TabIndex = 2;
            this.splitter3.TabStop = false;
            // 
            // splitter4
            // 
            this.splitter4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitter4.Location = new System.Drawing.Point(448, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(20, 938);
            this.splitter4.TabIndex = 3;
            this.splitter4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Brewery.Properties.Resources.Хованский;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 314);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(500, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 902);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(8, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 847);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загрузить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.MainList);
            this.tabPage2.Location = new System.Drawing.Point(8, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 818);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Показать";
            // 
            // MainList
            // 
            this.MainList.AllowUserToAddRows = false;
            this.MainList.AllowUserToResizeColumns = false;
            this.MainList.AllowUserToResizeRows = false;
            this.MainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.Number,
            this.Status});
            this.MainList.Location = new System.Drawing.Point(9, 15);
            this.MainList.Margin = new System.Windows.Forms.Padding(6);
            this.MainList.MultiSelect = false;
            this.MainList.Name = "MainList";
            this.MainList.RowHeadersVisible = false;
            this.MainList.RowHeadersWidth = 82;
            this.MainList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainList.Size = new System.Drawing.Size(822, 788);
            this.MainList.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 200;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.MinimumWidth = 10;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 65;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 250;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(8, 47);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(864, 818);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Закрыть";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(291, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 422);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Сорт";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "Название";
            treeNode3.Name = "Узел21";
            treeNode3.Text = "Объем";
            treeNode4.Name = "Узел22";
            treeNode4.Text = "Кол-во продаж в год";
            treeNode5.Name = "Узел24";
            treeNode5.Text = "Кол-во изделий в год";
            treeNode6.Name = "Узел0";
            treeNode6.Text = "Пиво";
            treeNode7.Name = "Узел8";
            treeNode7.Text = "Улица";
            treeNode8.Name = "Узел9";
            treeNode8.Text = "Дом";
            treeNode9.Name = "Узел10";
            treeNode9.Text = "Офис";
            treeNode10.Name = "Узел11";
            treeNode10.Text = "Индекс";
            treeNode11.Name = "Узел12";
            treeNode11.Text = "Кол-во сотрудников";
            treeNode12.Name = "Узел1";
            treeNode12.Text = "Адреса";
            treeNode13.Name = "Узел13";
            treeNode13.Text = "Имя";
            treeNode14.Name = "Узел14";
            treeNode14.Text = "Фамилия";
            treeNode15.Name = "Узел15";
            treeNode15.Text = "Отчество";
            treeNode16.Name = "Узел16";
            treeNode16.Text = "Дата рождения";
            treeNode17.Name = "Узел17";
            treeNode17.Text = "Должность";
            treeNode18.Name = "Узел2";
            treeNode18.Text = "Работники";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(364, 504);
            this.treeView1.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(-59, 67);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 37);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 938);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "Пиво Хованского";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MainList;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

