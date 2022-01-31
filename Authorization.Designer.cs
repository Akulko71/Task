using System.Data.Entity;

namespace Task
{
    partial class Authorization
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
            this.EmplGrid = new System.Windows.Forms.DataGridView();
            this.taskDBDataSet = new Task.TaskDBDataSet();
            this.personsTableAdapter = new Task.TaskDBDataSetTableAdapters.personsTableAdapter();
            this.Filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.postsBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Infobtn = new System.Windows.Forms.Button();
            this.quanity = new System.Windows.Forms.Label();
            this.quantityDate = new System.Windows.Forms.Label();
            this.outlbl = new System.Windows.Forms.Label();
            this.inlbl = new System.Windows.Forms.Label();
            this.DateFirst = new System.Windows.Forms.DateTimePicker();
            this.DateLast = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmplGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // EmplGrid
            // 
            this.EmplGrid.AllowUserToAddRows = false;
            this.EmplGrid.AllowUserToDeleteRows = false;
            this.EmplGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmplGrid.Location = new System.Drawing.Point(12, 38);
            this.EmplGrid.Name = "EmplGrid";
            this.EmplGrid.ReadOnly = true;
            this.EmplGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EmplGrid.Size = new System.Drawing.Size(763, 496);
            this.EmplGrid.TabIndex = 2;
            // 
            // taskDBDataSet
            // 
            this.taskDBDataSet.DataSetName = "TaskDBDataSet";
            this.taskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(117, 12);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(189, 20);
            this.Filter.TabIndex = 3;
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск по таблице";
            // 
            // depsBox
            // 
            this.depsBox.FormattingEnabled = true;
            this.depsBox.Location = new System.Drawing.Point(403, 11);
            this.depsBox.Name = "depsBox";
            this.depsBox.Size = new System.Drawing.Size(121, 21);
            this.depsBox.TabIndex = 5;
            this.depsBox.SelectedIndexChanged += new System.EventHandler(this.depsBox_SelectedIndexChanged);
            this.depsBox.SelectedValueChanged += new System.EventHandler(this.depsBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "По отделам";
            // 
            // postsBox
            // 
            this.postsBox.FormattingEnabled = true;
            this.postsBox.Location = new System.Drawing.Point(654, 11);
            this.postsBox.Name = "postsBox";
            this.postsBox.Size = new System.Drawing.Size(121, 21);
            this.postsBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "По должности";
            // 
            // Infobtn
            // 
            this.Infobtn.Location = new System.Drawing.Point(904, 192);
            this.Infobtn.Name = "Infobtn";
            this.Infobtn.Size = new System.Drawing.Size(123, 23);
            this.Infobtn.TabIndex = 9;
            this.Infobtn.Text = "Вывод статистики";
            this.Infobtn.UseVisualStyleBackColor = true;
            this.Infobtn.Click += new System.EventHandler(this.Infobtn_Click);
            // 
            // quanity
            // 
            this.quanity.AutoSize = true;
            this.quanity.Location = new System.Drawing.Point(781, 54);
            this.quanity.Name = "quanity";
            this.quanity.Size = new System.Drawing.Size(314, 13);
            this.quanity.TabIndex = 0;
            this.quanity.Text = "Количество сотрудников в организации на данный момент: ";
            // 
            // quantityDate
            // 
            this.quantityDate.AutoSize = true;
            this.quantityDate.Location = new System.Drawing.Point(781, 85);
            this.quantityDate.Name = "quantityDate";
            this.quantityDate.Size = new System.Drawing.Size(264, 13);
            this.quantityDate.TabIndex = 1;
            this.quantityDate.Text = "Количество сотрудников за определенный период";
            // 
            // outlbl
            // 
            this.outlbl.AutoSize = true;
            this.outlbl.Location = new System.Drawing.Point(785, 156);
            this.outlbl.Name = "outlbl";
            this.outlbl.Size = new System.Drawing.Size(60, 13);
            this.outlbl.TabIndex = 2;
            this.outlbl.Text = "уволенно: ";
            // 
            // inlbl
            // 
            this.inlbl.AutoSize = true;
            this.inlbl.Location = new System.Drawing.Point(943, 156);
            this.inlbl.Name = "inlbl";
            this.inlbl.Size = new System.Drawing.Size(54, 13);
            this.inlbl.TabIndex = 3;
            this.inlbl.Text = "принято: ";
            // 
            // DateFirst
            // 
            this.DateFirst.Location = new System.Drawing.Point(804, 113);
            this.DateFirst.Name = "DateFirst";
            this.DateFirst.Size = new System.Drawing.Size(123, 20);
            this.DateFirst.TabIndex = 10;
            // 
            // DateLast
            // 
            this.DateLast.Location = new System.Drawing.Point(968, 112);
            this.DateLast.Name = "DateLast";
            this.DateLast.Size = new System.Drawing.Size(125, 20);
            this.DateLast.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(785, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(943, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "по";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateLast);
            this.Controls.Add(this.DateFirst);
            this.Controls.Add(this.inlbl);
            this.Controls.Add(this.Infobtn);
            this.Controls.Add(this.outlbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityDate);
            this.Controls.Add(this.postsBox);
            this.Controls.Add(this.quanity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.EmplGrid);
            this.Name = "Authorization";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Authorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmplGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EmplGrid;
        private TaskDBDataSet taskDBDataSet;
        private TaskDBDataSetTableAdapters.personsTableAdapter personsTableAdapter;
        private System.Windows.Forms.TextBox Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox depsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox postsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Infobtn;
        private System.Windows.Forms.Label quanity;
        private System.Windows.Forms.Label quantityDate;
        private System.Windows.Forms.Label outlbl;
        private System.Windows.Forms.Label inlbl;
        private System.Windows.Forms.DateTimePicker DateFirst;
        private System.Windows.Forms.DateTimePicker DateLast;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

