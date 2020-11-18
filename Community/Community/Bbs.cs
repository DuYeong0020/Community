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
        public Bbs()
        {

            InitializeComponent();
            listView1.BeginUpdate();
            ListViewItem lvi1 = new ListViewItem("1");
            lvi1.SubItems.Add("user01");
            lvi1.SubItems.Add("사용자01");
            lvi1.SubItems.Add("서울시 은평구");
            
            listView1.Items.Add(lvi1);

            ListViewItem lvi2 = new ListViewItem("2");
            lvi2.SubItems.Add("Temp1");
            lvi2.SubItems.Add("임시1");
            lvi2.SubItems.Add("인천광역시 부평구");
            
            listView1.Items.Add(lvi2);

            ListViewItem lvi3 = new ListViewItem("3");
            lvi3.SubItems.Add("Tester1");
            lvi3.SubItems.Add("테스터1");
            lvi3.SubItems.Add("성남시 분당구");
            
            listView1.Items.Add(lvi3);

            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            
        }
    }
}
