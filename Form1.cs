
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//DataSet 쓸때 필요
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql connection

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string field;
        int topCount=0;
        int totalCount;
    
        int divPage=30;
        int currentPage=1;

        public Form1()
        {
            InitializeComponent();
            SqlConnection conn = dbConnect();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TotalCount();
            selectStudent();
            string[] data = { "Name", "Age", "Grade" };
            comboBox1.Items.AddRange(data);
            comboBox1.SelectedIndex = 0;
        }
        //Data----------------------------------------------------------------------------------------------------------------------
        public SqlConnection dbConnect()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Server=localhost; database=TESTDB; uid=sa; pwd=sa";
            return conn;
        }

        private DataSet GetData(String szQuery)
        {
            SqlConnection conn = dbConnect();

            SqlDataAdapter adapter = new SqlDataAdapter(szQuery, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        private int GetTotalRow()
        {
            SqlConnection conn = dbConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from Student";
            object scalarValue = cmd.ExecuteScalar();
            int totalRow = (int)scalarValue;
            conn.Close();
            return totalRow;
        }
        private void TotalCount()
        {
            totalCount = GetTotalRow();
            if ((totalCount % divPage == 0))
                labelPage.Text = currentPage.ToString() + " / " + (totalCount / divPage).ToString();
            else
                labelPage.Text = currentPage.ToString() + " / " + (totalCount / divPage + 1).ToString();
        }
        private void currentPageCount()
        {
             if ((totalCount % divPage == 0))
                labelPage.Text = currentPage.ToString() + " / " + (totalCount / divPage).ToString();
            else
                labelPage.Text = currentPage.ToString() + " / " + (totalCount / divPage + 1).ToString();
        }
        public void selectStudent()
        {
            String szQuery = "SELECT top "+ divPage +" * FROM Student where id not in(select top " + (topCount) + "id from Student);";
          
            // DataSet을 가져온다
            DataSet ds = GetData(szQuery);
            
            // DataSource 속성을 설정
            dataGridView1.DataSource = ds.Tables[0];
           
        }

        //Event----------------------------------------------------------------------------------------------------------------------
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            int iRow = dataGridView1.CurrentRow.Index;
            int RowIndex = dataGridView1.CurrentCell.RowIndex + 1;
            if (iRow >= 0)
            {
                lineNum.Text = Convert.ToString(RowIndex);
                studentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                NameBOX.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                AgeBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                GradeBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.dataGridView1.Columns["id"].Visible = false; 
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            String szQuery = "SELECT * FROM Student ";

            if (serachBox.TextLength > 0 && field.Length > 0)
                szQuery += "where " + field + "='" + serachBox.Text + "'";

            // DataSet을 가져온다
            DataSet ds = GetData(szQuery);

            // DataSource 속성을 설정
            dataGridView1.DataSource = ds.Tables[0];
        }

        public void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection conn = dbConnect();
            DataSet ds;
            String szQuery = "insert into Student (Name, Age, Grade) values(";

            if (NameBOX.TextLength != 0 && AgeBox.TextLength != 0 && GradeBox.TextLength != 0)
            {
                szQuery += "'" + NameBOX.Text + "'" + "," + AgeBox.Text + "," + GradeBox.Text + ")";
                ds = GetData(szQuery);
                topCount = totalCount / divPage * divPage;
                if (totalCount % divPage == 0)
                    currentPage = totalCount / divPage;
                else
                    currentPage = totalCount / divPage + 1;
                selectStudent();
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount-1;
            }
            else
            {
                ds = null;
                MessageBox.Show("null");
            }
            TotalCount();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string currentRow = dataGridView1.CurrentCell.RowIndex.ToString();
            SqlConnection conn = dbConnect();
            DataSet ds;
            String szQuery = "UPDATE Student SET ";

            if (NameBOX.TextLength != 0 && AgeBox.TextLength != 0 && GradeBox.TextLength != 0)
            {
                szQuery += "Name='" + NameBOX.Text + "', Age =" + AgeBox.Text + ", Grade =" + GradeBox.Text + " where id=" + studentID.Text;
                ds = GetData(szQuery);
                selectStudent();
                dataGridView1.FirstDisplayedScrollingRowIndex = Convert.ToInt32(currentRow);
            }
            else
            {
                ds = null;
                MessageBox.Show("null");
            }
            TotalCount();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("삭제하시겠습니까?", "확인창", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlConnection conn = dbConnect();
                DataSet ds;
                String szQuery = "DELETE FROM Student ";
                if (studentID.Text.Length > 0)
                {
                    szQuery += "WHERE id=" + studentID.Text;
                    ds = GetData(szQuery);
                    selectStudent();
                }
            }
            TotalCount();
        }
        //Key Down----------------------------------------------------------------------------------------------------------------------
        private void serachBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search_Click(sender, e);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                delete_Click(sender, e);
            }
        }
        //Combo Box----------------------------------------------------------------------------------------------------------------------
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            field = comboBox1.SelectedItem.ToString();
        }

 
        private void NEXT_Click(object sender, EventArgs e)
        {
            topCount += divPage;
            currentPage += 1;

            if (totalCount % divPage == 0)
            {
                if(currentPage <= totalCount / divPage)
                {
                    selectStudent();
                    PRE.Visible = true;
                }
                else
                {
                    topCount -= divPage;
                    currentPage = totalCount / divPage;
                    NEXT.Visible = false;
                    MessageBox.Show("마지막페이지 입니다.");
                }
            }
            else
            {
                if (currentPage <= (totalCount / divPage + 1))
                {
                    selectStudent();
                    PRE.Visible = true;
                }
                else
                {
                    topCount -= divPage;
                    currentPage = totalCount / divPage + 1;
                    NEXT.Visible = false;
                    MessageBox.Show("마지막페이지 입니다.");
                }
            }
            currentPageCount();
        }

        private void PRE_Click(object sender, EventArgs e)
        {
            topCount -= 30;
            currentPage -= 1;

         

            if (topCount >= 0)
            {
                selectStudent();
                NEXT.Visible = true;
            }
                
            else
            {
                currentPage = 1;
                topCount += 30;
                PRE.Visible = false;
                MessageBox.Show("첫페이지 입니다.");
            }
            currentPageCount();
        }
    }
}
