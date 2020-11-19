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
    public partial class Update : Form
    {
        private string Form2_value;
        private static string mySqlConnStr
            = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        DataSet ds;
        public string Passvalue
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }
        public Update()
        {
            
            InitializeComponent();
            btnCancel.Click += BtnCancel_Click;
            btnOK.Click += BtnOK_Click;
            this.Load += Update_Load;
        }

        private void Update_Load(object sender, EventArgs e)
        {
            tbNo.ReadOnly = true;
            tbWriter.ReadOnly = true;
            try
            {
                ds = new DataSet();
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                StringBuilder sb = new StringBuilder();
                sb.Append(" select * from bbs where no = '" + Passvalue + "'");

                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), conn);

                adapter.Fill(ds, "bbs");
                tbNo.Text = ds.Tables[0].Rows[0][0].ToString();
                tbTitle.Text = ds.Tables[0].Rows[0][1].ToString();
                rtbContent.Text = ds.Tables[0].Rows[0][2].ToString();
                tbWriter.Text = ds.Tables[0].Rows[0][3].ToString();
                conn.Close();
                btnOK.Text = "수정 완료";

            }
            catch (Exception)
            {
                tbNo.Text = "";
                btnOK.Text = "작성 완료";

            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (tbNo.Text != "")
            {
                
                SuJung();
            }
            else
            {
                
                NewWrite();

            }
        }

        private void NewWrite()
        {
            
            try
            {
                string sTitle = tbTitle.Text.ToString();
                string sContent = rtbContent.Text.ToString();
                // 데이터 공간 생성
                ds = new DataSet();
                // 접속하기
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                StringBuilder sb = new StringBuilder();
                sb.Append(" insert into bbs ");
                sb.Append(" values ( ");
                sb.Append(" NULL, ");
                sb.Append(" '"); sb.Append(tbTitle.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append(rtbContent.Text); sb.Append("', ");
                sb.Append(" '"); sb.Append("admin"); sb.Append("'");
                sb.Append(" ) ");

                string sql = sb.ToString();
                // sql 실행
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("글 작성이 완료되었습니다.");
                this.Visible = false;             // 추가
                Bbs showForm = new Bbs();
                showForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("dd");
            }
        }

        private void SuJung()
        {
            try
            {
                string sTitle = tbTitle.Text.ToString();
                string sContent = rtbContent.Text.ToString();
                // 데이터 공간 생성
                ds = new DataSet();
                // 접속하기
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                StringBuilder sb = new StringBuilder();
                sb.Append(" update bbs set ");
                sb.Append(" title = '"); sb.Append(tbTitle.Text); sb.Append("', ");
                sb.Append(" content ='"); sb.Append(rtbContent.Text); sb.Append("' ");
                sb.Append(" where no ='"); sb.Append(tbNo.Text); sb.Append("'");


                string sql = sb.ToString();
                // sql 실행
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("글 수정이 되었습니다.");
                this.Visible = false;             // 추가
                Bbs showForm = new Bbs();
                showForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("dd");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("글 작성이 취소됩니다.");
            this.Visible = false;             // 추가
            Bbs showForm = new Bbs();
            showForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
