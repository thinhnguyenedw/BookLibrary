
namespace BookLibrary
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Button();
            this.textMasach = new System.Windows.Forms.TextBox();
            this.textTensach = new System.Windows.Forms.TextBox();
            this.textSoluong = new System.Windows.Forms.TextBox();
            this.textDongia = new System.Windows.Forms.TextBox();
            this.textThanhtien = new System.Windows.Forms.TextBox();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.qLSDataSet = new BookLibrary.QLSDataSet();
            this.sACHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sACHTableAdapter = new BookLibrary.QLSDataSetTableAdapters.SACHTableAdapter();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.checkNameSearch = new System.Windows.Forms.CheckBox();
            this.checkMoney = new System.Windows.Forms.CheckBox();
            this.textBookSearch = new System.Windows.Forms.TextBox();
            this.textMoneyFrom = new System.Windows.Forms.TextBox();
            this.textMoneyTo = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonExitSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhà xuất bản";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(89, 401);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 56);
            this.add.TabIndex = 5;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thành tiền";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(655, 401);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(114, 56);
            this.total.TabIndex = 7;
            this.total.Text = "Tính tiền";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // textMasach
            // 
            this.textMasach.Location = new System.Drawing.Point(234, 75);
            this.textMasach.Name = "textMasach";
            this.textMasach.Size = new System.Drawing.Size(154, 22);
            this.textMasach.TabIndex = 8;
            // 
            // textTensach
            // 
            this.textTensach.Location = new System.Drawing.Point(234, 123);
            this.textTensach.Name = "textTensach";
            this.textTensach.Size = new System.Drawing.Size(154, 22);
            this.textTensach.TabIndex = 9;
            // 
            // textSoluong
            // 
            this.textSoluong.Location = new System.Drawing.Point(234, 179);
            this.textSoluong.Name = "textSoluong";
            this.textSoluong.Size = new System.Drawing.Size(154, 22);
            this.textSoluong.TabIndex = 10;
            this.textSoluong.TextChanged += new System.EventHandler(this.textSoluong_TextChanged);
            this.textSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSoluong_KeyPress);
            // 
            // textDongia
            // 
            this.textDongia.Location = new System.Drawing.Point(234, 235);
            this.textDongia.Name = "textDongia";
            this.textDongia.Size = new System.Drawing.Size(154, 22);
            this.textDongia.TabIndex = 11;
            this.textDongia.TextChanged += new System.EventHandler(this.textDongia_TextChanged);
            this.textDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDongia_KeyPress);
            // 
            // textThanhtien
            // 
            this.textThanhtien.Location = new System.Drawing.Point(234, 345);
            this.textThanhtien.Name = "textThanhtien";
            this.textThanhtien.Size = new System.Drawing.Size(154, 22);
            this.textThanhtien.TabIndex = 12;
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(234, 287);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(154, 24);
            this.comboBoxNXB.TabIndex = 13;
            this.comboBoxNXB.SelectedIndexChanged += new System.EventHandler(this.comboBoxNXB_SelectedIndexChanged);
            // 
            // qLSDataSet
            // 
            this.qLSDataSet.DataSetName = "QLSDataSet";
            this.qLSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sACHBindingSource
            // 
            this.sACHBindingSource.DataMember = "SACH";
            this.sACHBindingSource.DataSource = this.qLSDataSet;
            this.sACHBindingSource.CurrentChanged += new System.EventHandler(this.sACHBindingSource_CurrentChanged);
            // 
            // sACHTableAdapter
            // 
            this.sACHTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.AllowUserToAddRows = false;
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(89, 487);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.ReadOnly = true;
            this.dataGridViewSach.RowHeadersWidth = 51;
            this.dataGridViewSach.RowTemplate.Height = 24;
            this.dataGridViewSach.Size = new System.Drawing.Size(680, 268);
            this.dataGridViewSach.TabIndex = 15;
            this.dataGridViewSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_CellClick);
            this.dataGridViewSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(234, 401);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 56);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Xoá";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(382, 401);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(114, 56);
            this.buttonSua.TabIndex = 19;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // checkNameSearch
            // 
            this.checkNameSearch.AutoSize = true;
            this.checkNameSearch.Location = new System.Drawing.Point(440, 74);
            this.checkNameSearch.Name = "checkNameSearch";
            this.checkNameSearch.Size = new System.Drawing.Size(97, 21);
            this.checkNameSearch.TabIndex = 20;
            this.checkNameSearch.Text = "Tên sách: ";
            this.checkNameSearch.UseVisualStyleBackColor = true;
            this.checkNameSearch.CheckedChanged += new System.EventHandler(this.checkNameSearch_CheckedChanged);
            // 
            // checkMoney
            // 
            this.checkMoney.AutoSize = true;
            this.checkMoney.Location = new System.Drawing.Point(440, 125);
            this.checkMoney.Name = "checkMoney";
            this.checkMoney.Size = new System.Drawing.Size(88, 21);
            this.checkMoney.TabIndex = 21;
            this.checkMoney.Text = "Giá bán: ";
            this.checkMoney.UseVisualStyleBackColor = true;
            // 
            // textBookSearch
            // 
            this.textBookSearch.Location = new System.Drawing.Point(544, 74);
            this.textBookSearch.Name = "textBookSearch";
            this.textBookSearch.Size = new System.Drawing.Size(225, 22);
            this.textBookSearch.TabIndex = 22;
            this.textBookSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textMoneyFrom
            // 
            this.textMoneyFrom.Location = new System.Drawing.Point(544, 126);
            this.textMoneyFrom.Name = "textMoneyFrom";
            this.textMoneyFrom.Size = new System.Drawing.Size(99, 22);
            this.textMoneyFrom.TabIndex = 23;
            // 
            // textMoneyTo
            // 
            this.textMoneyTo.Location = new System.Drawing.Point(670, 126);
            this.textMoneyTo.Name = "textMoneyTo";
            this.textMoneyTo.Size = new System.Drawing.Size(99, 22);
            this.textMoneyTo.TabIndex = 24;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(655, 179);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 56);
            this.buttonSearch.TabIndex = 25;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonExitSearch
            // 
            this.buttonExitSearch.Location = new System.Drawing.Point(655, 255);
            this.buttonExitSearch.Name = "buttonExitSearch";
            this.buttonExitSearch.Size = new System.Drawing.Size(114, 56);
            this.buttonExitSearch.TabIndex = 26;
            this.buttonExitSearch.Text = "Thoát";
            this.buttonExitSearch.UseVisualStyleBackColor = true;
            this.buttonExitSearch.Click += new System.EventHandler(this.buttonExitSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(863, 794);
            this.Controls.Add(this.buttonExitSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textMoneyTo);
            this.Controls.Add(this.textMoneyFrom);
            this.Controls.Add(this.textBookSearch);
            this.Controls.Add(this.checkMoney);
            this.Controls.Add(this.checkNameSearch);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.comboBoxNXB);
            this.Controls.Add(this.textThanhtien);
            this.Controls.Add(this.textDongia);
            this.Controls.Add(this.textSoluong);
            this.Controls.Add(this.textTensach);
            this.Controls.Add(this.textMasach);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.TextBox textMasach;
        private System.Windows.Forms.TextBox textTensach;
        private System.Windows.Forms.TextBox textSoluong;
        private System.Windows.Forms.TextBox textDongia;
        private System.Windows.Forms.TextBox textThanhtien;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private QLSDataSet qLSDataSet;
        private System.Windows.Forms.BindingSource sACHBindingSource;
        private QLSDataSetTableAdapters.SACHTableAdapter sACHTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.CheckBox checkNameSearch;
        private System.Windows.Forms.CheckBox checkMoney;
        private System.Windows.Forms.TextBox textBookSearch;
        private System.Windows.Forms.TextBox textMoneyFrom;
        private System.Windows.Forms.TextBox textMoneyTo;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExitSearch;
    }
}

