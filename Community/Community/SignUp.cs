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
    public partial class SignUp : Form
    {
        // 아이디 확인
        bool idCheck = false;
        // 비밀번호 확인
        bool pwCheck = false;
        MySqlConnection conn = new MySqlConnection("Server=61.84.24.210; Database=myprog; Uid=winprog;Pwd=winprog2020!");

        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            // 아이디 중복 확인
            string sql = "select * from user where id = '" + textBox1.Text + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                // 읽어올 값이 있으면
                if (reader.Read()) MessageBox.Show("이미 존재하는 아이디 입니다.");
                else
                {
                    MessageBox.Show("사용 가능한 아이디 입니다.");
                    idCheck = true;
                }
                conn.Close();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 비밀번호 확인
            if (pw.Text == pw_check.Text)
            { 
                MessageBox.Show("확인 되었습니다.");
                pwCheck = true;
            }
            else MessageBox.Show("비밀번호가 불일치 합니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 회원등록
            if (idCheck) MessageBox.Show("아이디를 확인해주세요.");
            else if (pwCheck) MessageBox.Show("비밀번호를 확인해주세요.");
            else if (textBox4.Text.Equals("")) MessageBox.Show("이름을 입력해주세요.");
            else
            {
                LinkedList<string> list = new LinkedList<string>();
                list.AddLast("'"+textBox1.Text);
                list.AddLast(crypto.Encrypt(pw.Text)+"'");
                string cols = string.Join("','", list);
                string sql = "insert into mycompany2(id, pw) values(" + cols + ")";
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("성공적으로 회원가입 되었습니다!");
                    this.Close();
                }
                catch (Exception ep)
                {
                    Console.WriteLine(ep.ToString());
                }
            }
        }
    }
}
