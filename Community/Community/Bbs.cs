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
    
    public partial class Bbs : Form
    {
        private string user_id;
        public string Passvalue
        {
            get { return this.user_id; }
            set { this.user_id = value; }  
        }
    


        private static string mySqlConnStr
            = "Server=61.84.24.210;Database=myprog;Uid=winprog;Pwd=winprog2020!";
        DataSet ds;
        public Bbs()
        {
            InitializeComponent();
            btnWrite.Click += BtnWrite_Click;
            btnLogout.Click += BtnLogout_Click;
            this.Load += Bbs_Load1;
            DataInit();


        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가
            SignIn showForm = new SignIn();
            MessageBox.Show("성공적으로 로그아웃 되었습니다.");
            showForm.ShowDialog();
        }

        private void Bbs_Load1(object sender, EventArgs e)
        {
            string userid = Passvalue; // 전달 받은 userid
            lbUser.Text = userid;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            this.Visible = false;             // 추가
            Update showForm = new Update();
            showForm.Passvalue = lbUser.Text;
            showForm.ShowDialog();
           
        }

        private void DataInit()
        {
            try
            {
                ds = new DataSet();
                MySqlConnection conn = new MySqlConnection(mySqlConnStr);
                // 오픈
                conn.Open();
                // 데이터 가져오기 쿼리
                string sql = "select * from bbs order by no desc";
                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "bbs");
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    ListViewItem lv = new ListViewItem(r["no"].ToString());
                    lv.SubItems.Add(r["title"].ToString());
                    lv.SubItems.Add(r["content"].ToString());
                    lv.SubItems.Add(r["id"].ToString());
                    
                    listView1.Items.Add(lv);
                }
                conn.Close();
            }
            catch (Exception)
            {
                
            }

        
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            string sTemp = lv.FocusedItem.SubItems[0].Text;
            sTemp.Trim();
            this.Visible = false;             // 추가
            Detail showForm = new Detail();
            showForm.Passvalue = (sTemp+" "+lbUser.Text).Trim();
            showForm.ShowDialog();

            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click_1(object sender, EventArgs e)
        {

        }
    }
}
