namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet16 = new WindowsFormsApp1.DataSet16();
            this.realtorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new WindowsFormsApp1.DataSet5();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet18 = new WindowsFormsApp1.DataSet18();
            this.sdelkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet6 = new WindowsFormsApp1.DataSet6();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet17 = new WindowsFormsApp1.DataSet17();
            this.nedvijimostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet7 = new WindowsFormsApp1.DataSet7();
            this.realtorTableAdapter = new WindowsFormsApp1.DataSet5TableAdapters.RealtorTableAdapter();
            this.sdelkaTableAdapter = new WindowsFormsApp1.DataSet6TableAdapters.SdelkaTableAdapter();
            this.nedvijimostTableAdapter = new WindowsFormsApp1.DataSet7TableAdapters.nedvijimostTableAdapter();
            this._111TableAdapter = new WindowsFormsApp1.DataSet16TableAdapters._111TableAdapter();
            this._112TableAdapter = new WindowsFormsApp1.DataSet17TableAdapters._112TableAdapter();
            this.tableeTableAdapter = new WindowsFormsApp1.DataSet18TableAdapters.tableeTableAdapter();
            this.dataSet22 = new WindowsFormsApp1.DataSet22();
            this.компанииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.компанииTableAdapter = new WindowsFormsApp1.DataSet22TableAdapters.КомпанииTableAdapter();
            this.номерпоездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet23 = new WindowsFormsApp1.DataSet23();
            this.поездаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поездаTableAdapter = new WindowsFormsApp1.DataSet23TableAdapters.ПоездаTableAdapter();
            this.номерпоездаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станцияприбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станцияотправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отправлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.прибытиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дниобращенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.компанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdelkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvijimostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.компанииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерпоездаDataGridViewTextBoxColumn1,
            this.станцияприбытияDataGridViewTextBoxColumn,
            this.станцияотправленияDataGridViewTextBoxColumn,
            this.отправлениеDataGridViewTextBoxColumn,
            this.прибытиеDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.дниобращенияDataGridViewTextBoxColumn,
            this.компанияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поездаBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "111";
            this.bindingSource1.DataSource = this.dataSet16;
            // 
            // dataSet16
            // 
            this.dataSet16.DataSetName = "DataSet16";
            this.dataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorBindingSource
            // 
            this.realtorBindingSource.DataMember = "Realtor";
            this.realtorBindingSource.DataSource = this.dataSet5;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(801, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 21;
            this.button4.Text = "поезда";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(801, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 22;
            this.button2.Text = "компании";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерпоездаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.информацияDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.компанииBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(650, 287);
            this.dataGridView2.TabIndex = 23;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tablee";
            this.bindingSource3.DataSource = this.dataSet18;
            // 
            // dataSet18
            // 
            this.dataSet18.DataSetName = "DataSet18";
            this.dataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sdelkaBindingSource
            // 
            this.sdelkaBindingSource.DataMember = "Sdelka";
            this.sdelkaBindingSource.DataSource = this.dataSet6;
            // 
            // dataSet6
            // 
            this.dataSet6.DataSetName = "DataSet6";
            this.dataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "112";
            this.bindingSource2.DataSource = this.dataSet17;
            // 
            // dataSet17
            // 
            this.dataSet17.DataSetName = "DataSet17";
            this.dataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nedvijimostBindingSource
            // 
            this.nedvijimostBindingSource.DataMember = "nedvijimost";
            this.nedvijimostBindingSource.DataSource = this.dataSet7;
            // 
            // dataSet7
            // 
            this.dataSet7.DataSetName = "DataSet7";
            this.dataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realtorTableAdapter
            // 
            this.realtorTableAdapter.ClearBeforeFill = true;
            // 
            // sdelkaTableAdapter
            // 
            this.sdelkaTableAdapter.ClearBeforeFill = true;
            // 
            // nedvijimostTableAdapter
            // 
            this.nedvijimostTableAdapter.ClearBeforeFill = true;
            // 
            // _111TableAdapter
            // 
            this._111TableAdapter.ClearBeforeFill = true;
            // 
            // _112TableAdapter
            // 
            this._112TableAdapter.ClearBeforeFill = true;
            // 
            // tableeTableAdapter
            // 
            this.tableeTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet22
            // 
            this.dataSet22.DataSetName = "DataSet22";
            this.dataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // компанииBindingSource
            // 
            this.компанииBindingSource.DataMember = "Компании";
            this.компанииBindingSource.DataSource = this.dataSet22;
            // 
            // компанииTableAdapter
            // 
            this.компанииTableAdapter.ClearBeforeFill = true;
            // 
            // номерпоездаDataGridViewTextBoxColumn
            // 
            this.номерпоездаDataGridViewTextBoxColumn.DataPropertyName = "Номер_поезда";
            this.номерпоездаDataGridViewTextBoxColumn.HeaderText = "Номер_поезда";
            this.номерпоездаDataGridViewTextBoxColumn.Name = "номерпоездаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // информацияDataGridViewTextBoxColumn
            // 
            this.информацияDataGridViewTextBoxColumn.DataPropertyName = "Информация";
            this.информацияDataGridViewTextBoxColumn.HeaderText = "Информация";
            this.информацияDataGridViewTextBoxColumn.Name = "информацияDataGridViewTextBoxColumn";
            // 
            // dataSet23
            // 
            this.dataSet23.DataSetName = "DataSet23";
            this.dataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поездаBindingSource
            // 
            this.поездаBindingSource.DataMember = "Поезда";
            this.поездаBindingSource.DataSource = this.dataSet23;
            // 
            // поездаTableAdapter
            // 
            this.поездаTableAdapter.ClearBeforeFill = true;
            // 
            // номерпоездаDataGridViewTextBoxColumn1
            // 
            this.номерпоездаDataGridViewTextBoxColumn1.DataPropertyName = "Номер_поезда";
            this.номерпоездаDataGridViewTextBoxColumn1.HeaderText = "Номер_поезда";
            this.номерпоездаDataGridViewTextBoxColumn1.Name = "номерпоездаDataGridViewTextBoxColumn1";
            // 
            // станцияприбытияDataGridViewTextBoxColumn
            // 
            this.станцияприбытияDataGridViewTextBoxColumn.DataPropertyName = "Станция_прибытия";
            this.станцияприбытияDataGridViewTextBoxColumn.HeaderText = "Станция_прибытия";
            this.станцияприбытияDataGridViewTextBoxColumn.Name = "станцияприбытияDataGridViewTextBoxColumn";
            // 
            // станцияотправленияDataGridViewTextBoxColumn
            // 
            this.станцияотправленияDataGridViewTextBoxColumn.DataPropertyName = "Станция_отправления";
            this.станцияотправленияDataGridViewTextBoxColumn.HeaderText = "Станция_отправления";
            this.станцияотправленияDataGridViewTextBoxColumn.Name = "станцияотправленияDataGridViewTextBoxColumn";
            // 
            // отправлениеDataGridViewTextBoxColumn
            // 
            this.отправлениеDataGridViewTextBoxColumn.DataPropertyName = "Отправление";
            this.отправлениеDataGridViewTextBoxColumn.HeaderText = "Отправление";
            this.отправлениеDataGridViewTextBoxColumn.Name = "отправлениеDataGridViewTextBoxColumn";
            // 
            // прибытиеDataGridViewTextBoxColumn
            // 
            this.прибытиеDataGridViewTextBoxColumn.DataPropertyName = "Прибытие";
            this.прибытиеDataGridViewTextBoxColumn.HeaderText = "Прибытие";
            this.прибытиеDataGridViewTextBoxColumn.Name = "прибытиеDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // дниобращенияDataGridViewTextBoxColumn
            // 
            this.дниобращенияDataGridViewTextBoxColumn.DataPropertyName = "Дни_обращения";
            this.дниобращенияDataGridViewTextBoxColumn.HeaderText = "Дни_обращения";
            this.дниобращенияDataGridViewTextBoxColumn.Name = "дниобращенияDataGridViewTextBoxColumn";
            // 
            // компанияDataGridViewTextBoxColumn
            // 
            this.компанияDataGridViewTextBoxColumn.DataPropertyName = "Компания";
            this.компанияDataGridViewTextBoxColumn.HeaderText = "Компания";
            this.компанияDataGridViewTextBoxColumn.Name = "компанияDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 724);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdelkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nedvijimostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.компанииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поездаBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource realtorBindingSource;
        private DataSet5TableAdapters.RealtorTableAdapter realtorTableAdapter;
        private DataSet6 dataSet6;
        private System.Windows.Forms.BindingSource sdelkaBindingSource;
        private DataSet6TableAdapters.SdelkaTableAdapter sdelkaTableAdapter;
        private DataSet7 dataSet7;
        private System.Windows.Forms.BindingSource nedvijimostBindingSource;
        private DataSet7TableAdapters.nedvijimostTableAdapter nedvijimostTableAdapter;
        private System.Windows.Forms.BindingSource tableeBindingSource;
        private DataSet16 dataSet16;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet16TableAdapters._111TableAdapter _111TableAdapter;
        private DataSet17 dataSet17;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DataSet17TableAdapters._112TableAdapter _112TableAdapter;
        private DataSet18 dataSet18;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DataSet18TableAdapters.tableeTableAdapter tableeTableAdapter;
        private DataSet22 dataSet22;
        private System.Windows.Forms.BindingSource компанииBindingSource;
        private DataSet22TableAdapters.КомпанииTableAdapter компанииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпоездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияDataGridViewTextBoxColumn;
        private DataSet23 dataSet23;
        private System.Windows.Forms.BindingSource поездаBindingSource;
        private DataSet23TableAdapters.ПоездаTableAdapter поездаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпоездаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn станцияприбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn станцияотправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отправлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn прибытиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дниобращенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn компанияDataGridViewTextBoxColumn;
    }
}