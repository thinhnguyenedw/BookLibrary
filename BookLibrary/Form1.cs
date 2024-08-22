using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace BookLibrary
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addSach()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "themSach";
                    cmd.Parameters.AddWithValue("@masach", textMasach.Text);
                    cmd.Parameters.AddWithValue("@tieude", textTensach.Text);
                    cmd.Parameters.AddWithValue("@dongia", textDongia.Text);
                    cmd.Parameters.AddWithValue("@soluong", textSoluong.Text);
                    cmd.Parameters.AddWithValue("@manxhb", comboBoxNXB.SelectedValue);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Nhập bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textMasach.Clear();
                    }
                    cnn.Close();
                }
            }
        }

        private void xoaSach(string value)
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "xoaSach";
                    cmd.Parameters.AddWithValue("@masach", value);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Xoá bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cnn.Close();
                }
            }
        }
        private void xoaSachtrongDatagridView()
        {
            string value = textMasach.Text;
            xoaSach(value);
            laySach();
        }
        private void laySach()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            //string constr = "Data Source=BIONEDW;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from v_Sach1", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new System.Data.DataTable();
                        ad.Fill(tb);
                        dataGridViewSach.DataSource = tb;
                    }
                }
            }
        }
        private DataTable searchName()
        {
            DataTable nameSearch = new System.Data.DataTable();
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "searchName";
                    cmd.Parameters.AddWithValue("@tieude", textBookSearch.Text);
                    cnn.Open();
                    try
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            ad.Fill(nameSearch);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Nhập bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textMasach.Clear();
                    }
                    cnn.Close();
                    return nameSearch;
                }
            }
        }
        private DataTable searchPrice()
        {
            DataTable priceSearch = new System.Data.DataTable();
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "searchbyMoney";
                    cmd.Parameters.AddWithValue("@from", textMoneyFrom.Text);
                    cmd.Parameters.AddWithValue("@to", textMoneyTo.Text);
                    cnn.Open();
                    try
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                        {
                            ad.Fill(priceSearch);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Nhập bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textMasach.Clear();
                    }
                    cnn.Close();
                    return priceSearch;
                }
            }
        }
        private void suaSach()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = "suaSach";
                    cmd.Parameters.AddWithValue("@masach", textMasach.Text);
                    cmd.Parameters.AddWithValue("@tieude", textTensach.Text);
                    cmd.Parameters.AddWithValue("@dongia", textDongia.Text);
                    cmd.Parameters.AddWithValue("@soluong", textSoluong.Text);
                    cmd.Parameters.AddWithValue("@manxhb", comboBoxNXB.SelectedValue);
                    cnn.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Sửa bị lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cnn.Close();
                }
            }
        }

        private DataTable layDS()
        {
            string constr = ConfigurationManager.ConnectionStrings["db_QLS"].ConnectionString;
            //string constr = "Data Source=BIONEDW;Initial Catalog=QLSV;Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from NHAXUATBAN", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new System.Data.DataTable("NHAXUATBAN");
                        ad.Fill(tb);
                        comboBoxNXB.DataSource = tb;
                        comboBoxNXB.DisplayMember = "TenNXB";
                        comboBoxNXB.ValueMember = "MaNXB";
                        return tb;
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLSDataSet.SACH' table. You can move, or remove it, as needed.
            /*textMasach.Text = dataGridViewSach.Rows[0].Cells[0].Value.ToString();
            textTensach.Text = dataGridViewSach.Rows[0].Cells[1].Value.ToString();
            textSoluong.Text = dataGridViewSach.Rows[0].Cells[2].Value.ToString();
            textDongia.Text = dataGridViewSach.Rows[0].Cells[3].Value.ToString();
            comboBoxNXB.SelectedValue = dataGridViewSach.CurrentRow.Cells[5].Value;*/
            biendungchung d = new biendungchung();
            d.ketnoi();
            d.loadDatagridView("v_Sach1", dataGridViewSach);
            SqlCommand cmd = new SqlCommand("Select * from NHAXUATBAN");
            d.loadComboBox(cmd, comboBoxNXB);
        }

        private void add_Click(object sender, EventArgs e)
        {
            addSach();
            laySach();
        }

        private void textSoluong_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textSoluong.Text, out int result);
            if (result < 0)
            {
                MessageBox.Show("Vui lòng chỉ nhập số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDongia.Clear();
                return;
            }
        }

        private void textSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số, dấu chấm và dấu trừ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Chỉ cho phép dấu trừ ở vị trí đầu tiên
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void textDongia_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textDongia.Text, out int result);
            if (result < 0)
            {
                MessageBox.Show("Vui lòng chỉ nhập số lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDongia.Clear();
                return;
            }
        }

        private void textDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số, dấu chấm và dấu trừ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Chỉ cho phép dấu trừ ở vị trí đầu tiên
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1 || (sender as TextBox).SelectionStart != 0))
            {
                e.Handled = true;
            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(textDongia.Text) * int.Parse(textSoluong.Text);
            textThanhtien.Text = tong.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textMasach.Text = dataGridViewSach.CurrentRow.Cells[0].Value.ToString();
            textTensach.Text = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
            textDongia.Text = dataGridViewSach.CurrentRow.Cells[2].Value.ToString();
            textSoluong.Text = dataGridViewSach.CurrentRow.Cells[3].Value.ToString();
            comboBoxNXB.SelectedValue = dataGridViewSach.CurrentRow.Cells[5].Value.ToString();
        }
        private void dataGridViewSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textMasach.Text = dataGridViewSach.CurrentRow.Cells[0].Value.ToString();
            textTensach.Text = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
            textDongia.Text = dataGridViewSach.CurrentRow.Cells[2].Value.ToString();
            textSoluong.Text = dataGridViewSach.CurrentRow.Cells[3].Value.ToString();
            comboBoxNXB.SelectedValue = dataGridViewSach.CurrentRow.Cells[5].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textMasach.Text == "")
                MessageBox.Show("Chưa chọn hàng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                xoaSachtrongDatagridView();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            suaSach();
            laySach();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            /*            //dataGridViewSach.DataSource = searchName();
                        if(checkNameSearch.Checked==true){
                            dataGridViewSach.DataSource = searchName();
                        }
                        if (checkMoney.Checked == true)
                        {
                            dataGridViewSach.DataSource = searchPrice();
                        }
                        if(checkNameSearch.Checked == true&& checkMoney.Checked == true)
                        {

                        }*/
            if (checkNameSearch.Checked && checkMoney.Checked)
            {
                // Lấy kết quả từ hàm searchName()
                DataTable nameSearchResult = searchName();

                // Lấy kết quả từ hàm searchPrice()
                DataTable moneySearchResult = searchPrice();

                // Tạo một DataTable mới để kết hợp kết quả từ hai DataTable trên
                DataTable combinedResult = new DataTable();

                // Copy cấu trúc của DataTable nameSearchResult vào combinedResult
                combinedResult = nameSearchResult.Clone();

                // Thêm dữ liệu từ nameSearchResult vào combinedResult
                foreach (DataRow row in nameSearchResult.Rows)
                {
                    combinedResult.ImportRow(row);
                }

                // Thêm dữ liệu từ moneySearchResult vào combinedResult
                foreach (DataRow row in moneySearchResult.Rows)
                {
                    combinedResult.ImportRow(row);
                }

                // Gán nguồn dữ liệu cho dataGridViewSach từ DataTable kết hợp
                dataGridViewSach.DataSource = combinedResult;
            }
            else if (checkNameSearch.Checked)
            {
                dataGridViewSach.DataSource = searchName();
            }
            else if (checkMoney.Checked)
            {
                dataGridViewSach.DataSource = searchPrice();
            }
            if ((checkNameSearch.Checked == true && textBookSearch.Text == "") ||(checkMoney.Checked == true && textMoneyFrom.Text == "" && textMoneyTo.Text == ""))
            {
                laySach();
                MessageBox.Show("Chưa đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExitSearch_Click(object sender, EventArgs e)
        {
            laySach();
        }

        private void checkNameSearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {

        }

        private void sACHBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

