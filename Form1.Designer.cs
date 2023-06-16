
namespace zadanie1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.loadFileTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.exportButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addNameTextBox = new System.Windows.Forms.TextBox();
            this.findForNameButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.fillTableButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Укажите путь к файлу для заполнения таблицы";
            // 
            // loadFileTextBox
            // 
            this.loadFileTextBox.Location = new System.Drawing.Point(523, 55);
            this.loadFileTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loadFileTextBox.Name = "loadFileTextBox";
            this.loadFileTextBox.Size = new System.Drawing.Size(163, 20);
            this.loadFileTextBox.TabIndex = 29;
            this.loadFileTextBox.Text = "contacts.xlsx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(507, 390);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Введите название файла для экспорта";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(508, 421);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.fileNameTextBox.TabIndex = 27;
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.Color.LightGray;
            this.exportButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exportButton.Location = new System.Drawing.Point(747, 390);
            this.exportButton.Margin = new System.Windows.Forms.Padding(2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(185, 63);
            this.exportButton.TabIndex = 26;
            this.exportButton.Text = "Экспортировать таблицу";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteUserButton.Location = new System.Drawing.Point(22, 558);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(418, 42);
            this.deleteUserButton.TabIndex = 25;
            this.deleteUserButton.Text = "Удалить выбранную строку";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.BackColor = System.Drawing.Color.LightGray;
            this.addPersonButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addPersonButton.Location = new System.Drawing.Point(747, 127);
            this.addPersonButton.Margin = new System.Windows.Forms.Padding(2);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(185, 90);
            this.addPersonButton.TabIndex = 24;
            this.addPersonButton.Text = "Добавить человека";
            this.addPersonButton.UseVisualStyleBackColor = false;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите номер ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите ФИО ";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(508, 197);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(211, 20);
            this.numberTextBox.TabIndex = 21;
            // 
            // addNameTextBox
            // 
            this.addNameTextBox.Location = new System.Drawing.Point(508, 127);
            this.addNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addNameTextBox.Name = "addNameTextBox";
            this.addNameTextBox.Size = new System.Drawing.Size(211, 20);
            this.addNameTextBox.TabIndex = 20;
            // 
            // findForNameButton
            // 
            this.findForNameButton.BackColor = System.Drawing.Color.LightGray;
            this.findForNameButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findForNameButton.Location = new System.Drawing.Point(747, 276);
            this.findForNameButton.Margin = new System.Windows.Forms.Padding(2);
            this.findForNameButton.Name = "findForNameButton";
            this.findForNameButton.Size = new System.Drawing.Size(185, 56);
            this.findForNameButton.TabIndex = 19;
            this.findForNameButton.Text = "Поиск";
            this.findForNameButton.UseVisualStyleBackColor = false;
            this.findForNameButton.Click += new System.EventHandler(this.findForNameButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(508, 312);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(211, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // fillTableButton
            // 
            this.fillTableButton.BackColor = System.Drawing.Color.Red;
            this.fillTableButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fillTableButton.Location = new System.Drawing.Point(747, 25);
            this.fillTableButton.Margin = new System.Windows.Forms.Padding(2);
            this.fillTableButton.Name = "fillTableButton";
            this.fillTableButton.Size = new System.Drawing.Size(185, 50);
            this.fillTableButton.TabIndex = 17;
            this.fillTableButton.Text = "Заполнить таблицу";
            this.fillTableButton.UseVisualStyleBackColor = false;
            this.fillTableButton.Click += new System.EventHandler(this.fillTableButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.phoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(22, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 532);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userName
            // 
            this.userName.HeaderText = "ФИО";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Номер телефона";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(487, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Введите ФИО человека, которого нужно найти";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(523, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 54);
            this.button1.TabIndex = 32;
            this.button1.Text = "Выйти из программы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1242, 627);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loadFileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addNameTextBox);
            this.Controls.Add(this.findForNameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.fillTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loadFileTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox addNameTextBox;
        private System.Windows.Forms.Button findForNameButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button fillTableButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

