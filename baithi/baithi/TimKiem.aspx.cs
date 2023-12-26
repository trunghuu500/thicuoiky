using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baithi
{
    public partial class TimKiem : System.Web.UI.Page
    {
        public static string chuoiKN = "Data Source=DESKTOP-FRM0QP5\\SQLEXPRESS;Initial Catalog=QL_SINHVIEN;Integrated Security=True;Trust Server Certificate=True;";
        public static SqlConnection cn = new SqlConnection(chuoiKN);
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        void HienThi()
        {
            try
            {
                string chuoiSQL = "SELECT * FROM tbl_truong";
                SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = "Lỗi kết nối!";
            }
        }

        protected void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTH.Text == "")
                {
                    HienThi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_truong where MaTruong = N'" + txtMaTH.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    txtMaTH.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }

        protected void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenTH.Text == "")
                {
                    HienThi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_truong where TenTruong = N'" + txtTenTH.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    txtTenTH.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }
    }
}