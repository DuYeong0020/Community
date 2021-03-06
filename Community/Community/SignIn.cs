﻿using MySql.Data.MySqlClient;
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
    public partial class SignIn : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=61.84.24.210; Database=myprog; Uid=winprog;Pwd=winprog2020!");

        public SignIn()
        {
            InitializeComponent();
            /*
             * 암호화 테스트
            string text = crypto.Encrypt("1234");
            Console.WriteLine("암호화된 문자열: " + text);
            Console.WriteLine("복호화된 문자열: " + crypto.Decrypt(text));
            */

        }
        // 회원가입
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.ShowDialog();
        }
        // 로그인
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from user where id = '" + tb_id.Text + "'";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                string[] user = new string[2] { "-1", "-1"};
                while (reader.Read())
                {
                    // 복호화
                    user[0] = reader["id"].ToString();
                    user[1] = crypto.Decrypt(reader["pw"].ToString());
                }
                if (!user[0].Equals(tb_id.Text))
                    MessageBox.Show("아이디가 존재하지 않습니다.");
                else if(user[0].Equals(tb_id.Text) && !user[1].Equals(tb_pw.Text))
                    MessageBox.Show("비밀번호가 일치하지 않습니다.");
                else if (user[0].Equals(tb_id.Text) && user[1].Equals(tb_pw.Text))
                {
                    this.Visible = false;
                    Bbs form = new Bbs();
                    form.Passvalue = tb_id.Text;
                    form.ShowDialog();

                }
                conn.Close();
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.ToString());
            }
        }
    }
}
