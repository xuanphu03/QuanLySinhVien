using QuanLySinhVien.src.app_code;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLySinhVien
{
    public partial class HomePage : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        String SQL;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU();

            String studentId = txtStudentId.Text.Trim();
            String password = txtPassword.Text.Trim();
            String name = txtName.Text.Trim();
            DateTime dob = DateTime.Parse(txtDob.Text);
            String gender = rbtnMale.Checked ? "Nam" : rbtnFemale.Checked ? "Nữ" : "Khác";

            if (studentId == null || password == "" || name == null)
            {
                Response.Write("<script>alert('Vui lòng nhập đầy đủ thông tin!')</script>");
                return;
            }


            SQL = "INSERT INTO SINHVIEN VALUES('" + studentId + "', '" + name + "', '" + password + "', '" + dob + "', '" + gender + "')";

            xuly.setStudents(SQL);
        }
    }
}