
namespace AnguYchet.Page
{
	partial class Заказы
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Заказы));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.angu_ushetDataSet = new AnguYchet.Angu_ushetDataSet();
			this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.заказыTableAdapter = new AnguYchet.Angu_ushetDataSetTableAdapters.ЗаказыTableAdapter();
			this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерзаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерзаказанногоизделияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номерсотрудникасобирающегозаказDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.номеробслуживающегоцехаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.количествоеденицDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.планируемоевремязавершениязаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.стоимостьзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.angu_ushetDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерзаказаDataGridViewTextBoxColumn,
            this.номерзаказчикаDataGridViewTextBoxColumn,
            this.номерзаказанногоизделияDataGridViewTextBoxColumn,
            this.номерсотрудникасобирающегозаказDataGridViewTextBoxColumn,
            this.номеробслуживающегоцехаDataGridViewTextBoxColumn,
            this.количествоеденицDataGridViewTextBoxColumn,
            this.планируемоевремязавершениязаказаDataGridViewTextBoxColumn,
            this.стоимостьзаказаDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.заказыBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 103);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(805, 457);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label1.Location = new System.Drawing.Point(353, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Заказы";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(802, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(182, 561);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 21);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(108, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 31;
			this.pictureBox1.TabStop = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(811, 162);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(165, 21);
			this.comboBox1.TabIndex = 32;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(802, 457);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(182, 53);
			this.button2.TabIndex = 34;
			this.button2.Text = "Назад";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(802, 507);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 53);
			this.button1.TabIndex = 33;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(811, 239);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(165, 21);
			this.comboBox2.TabIndex = 35;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(811, 312);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(165, 21);
			this.comboBox3.TabIndex = 36;
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(811, 388);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(165, 21);
			this.comboBox4.TabIndex = 37;
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(811, 88);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(165, 21);
			this.comboBox5.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(811, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 20);
			this.label2.TabIndex = 39;
			this.label2.Text = "Добавление Данных";
			// 
			// angu_ushetDataSet
			// 
			this.angu_ushetDataSet.DataSetName = "Angu_ushetDataSet";
			this.angu_ushetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// заказыBindingSource
			// 
			this.заказыBindingSource.DataMember = "Заказы";
			this.заказыBindingSource.DataSource = this.angu_ushetDataSet;
			// 
			// заказыTableAdapter
			// 
			this.заказыTableAdapter.ClearBeforeFill = true;
			// 
			// номерзаказаDataGridViewTextBoxColumn
			// 
			this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
			this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер_заказа";
			this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
			this.номерзаказаDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// номерзаказчикаDataGridViewTextBoxColumn
			// 
			this.номерзаказчикаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказчика";
			this.номерзаказчикаDataGridViewTextBoxColumn.HeaderText = "Номер_заказчика";
			this.номерзаказчикаDataGridViewTextBoxColumn.Name = "номерзаказчикаDataGridViewTextBoxColumn";
			// 
			// номерзаказанногоизделияDataGridViewTextBoxColumn
			// 
			this.номерзаказанногоизделияDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказанного_изделия";
			this.номерзаказанногоизделияDataGridViewTextBoxColumn.HeaderText = "Номер_заказанного_изделия";
			this.номерзаказанногоизделияDataGridViewTextBoxColumn.Name = "номерзаказанногоизделияDataGridViewTextBoxColumn";
			// 
			// номерсотрудникасобирающегозаказDataGridViewTextBoxColumn
			// 
			this.номерсотрудникасобирающегозаказDataGridViewTextBoxColumn.DataPropertyName = "Номер_сотрудника_собирающего_заказ";
			this.номерсотрудникасобирающегозаказDataGridViewTextBoxColumn.HeaderText = "Номер_сотрудника_собирающего_заказ";
			this.номерсотрудникасобирающегозаказDataGridViewTextBoxColumn.Name = "номерсотрудникасобирающегозаказDataGridViewTextBoxColumn";
			// 
			// номеробслуживающегоцехаDataGridViewTextBoxColumn
			// 
			this.номеробслуживающегоцехаDataGridViewTextBoxColumn.DataPropertyName = "Номер_обслуживающего_цеха";
			this.номеробслуживающегоцехаDataGridViewTextBoxColumn.HeaderText = "Номер_обслуживающего_цеха";
			this.номеробслуживающегоцехаDataGridViewTextBoxColumn.Name = "номеробслуживающегоцехаDataGridViewTextBoxColumn";
			// 
			// количествоеденицDataGridViewTextBoxColumn
			// 
			this.количествоеденицDataGridViewTextBoxColumn.DataPropertyName = "Количество_едениц";
			this.количествоеденицDataGridViewTextBoxColumn.HeaderText = "Количество_едениц";
			this.количествоеденицDataGridViewTextBoxColumn.Name = "количествоеденицDataGridViewTextBoxColumn";
			// 
			// планируемоевремязавершениязаказаDataGridViewTextBoxColumn
			// 
			this.планируемоевремязавершениязаказаDataGridViewTextBoxColumn.DataPropertyName = "Планируемое_время_завершения_заказа";
			this.планируемоевремязавершениязаказаDataGridViewTextBoxColumn.HeaderText = "Планируемое_время_завершения_заказа";
			this.планируемоевремязавершениязаказаDataGridViewTextBoxColumn.Name = "планируемоевремязавершениязаказаDataGridViewTextBoxColumn";
			// 
			// стоимостьзаказаDataGridViewTextBoxColumn
			// 
			this.стоимостьзаказаDataGridViewTextBoxColumn.DataPropertyName = "Стоимость_заказа";
			this.стоимостьзаказаDataGridViewTextBoxColumn.HeaderText = "Стоимость_заказа";
			this.стоимостьзаказаDataGridViewTextBoxColumn.Name = "стоимостьзаказаDataGridViewTextBoxColumn";
			// 
			// Заказы
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Заказы";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Заказы_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.angu_ushetDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox5;
		private System.Windows.Forms.Label label2;
		private Angu_ushetDataSet angu_ushetDataSet;
		private System.Windows.Forms.BindingSource заказыBindingSource;
		private Angu_ushetDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказчикаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерзаказанногоизделияDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номерсотрудникасобирающегозаказDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn номеробслуживающегоцехаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn количествоеденицDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn планируемоевремязавершениязаказаDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьзаказаDataGridViewTextBoxColumn;
	}
}