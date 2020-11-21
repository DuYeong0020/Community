using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Community
{

    public partial class Detail : Form
    {
                            
        private string Form2_value;
        private string Form2_value2;
        private static string mySqlConnStr
          = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        DataSet ds;
        public string Passvalue
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
            
        }
       
        public Detail()
        {
            InitializeComponent();
            this.Load += Detail_Load1;
            btnDelete.Click += BtnDelete_Click;
            btnRevise.Click += BtnRevise_Click;
            btnList.Click += BtnList_Click;
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가
            Bbs showForm = new Bbs();
            showForm.Passvalue = lbUser.Text;
            showForm.ShowDialog();
        }

        private void BtnRevise_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가
            Update showForm = new Update();
            showForm.Passvalue = lbNo.Text;
            showForm.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            // 오픈
            conn.Open();
            // 데이터 가져오기 쿼리
            StringBuilder sb = new StringBuilder();
            sb.Append(" delete from bbs where no = '" + lbNo.Text + "'");

            
            MySqlCommand cmd = new MySqlCommand(sb.ToString(), conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("성공적으로 삭제되었습니다.");
            this.Visible = false;             // 추가
            Bbs showForm = new Bbs();
            showForm.Passvalue = lbUser.Text;
            showForm.ShowDialog();
        }

        private void Detail_Load1(object sender, EventArgs e)
        {
            string[] str = Passvalue.Split(' ');
            lbNo.Text = str[0];
            lbUser.Text = str[1];
            richTextBox1.ReadOnly = true;
            ChangeData(str[1]);
        }

        private void ChangeData(string str)
        {
                
            
            ds = new DataSet();
            MySqlConnection conn = new MySqlConnection(mySqlConnStr);
            // 오픈
            conn.Open();
            // 데이터 가져오기 쿼리
            StringBuilder sb = new StringBuilder();
            sb.Append(" select * from bbs where no = '" + lbNo.Text + "'");

            MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), conn);
             
            adapter.Fill(ds, "bbs");
            lbNo.Text =ds.Tables[0].Rows[0][0].ToString();
            lbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            richTextBox1.Text = ds.Tables[0].Rows[0][2].ToString();
            lbWriter.Text = ds.Tables[0].Rows[0][3].ToString();       
            conn.Close();
            btnDelete.Visible = true;
            btnRevise.Visible = true;
            if (!lbWriter.Text.Equals(str))
            {
                btnDelete.Visible = false;
                btnRevise.Visible = false;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnRevise_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbNo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
