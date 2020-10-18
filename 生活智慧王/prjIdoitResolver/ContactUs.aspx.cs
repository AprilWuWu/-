using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjIdoitResolver
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                cn.Open();

                try
                {
                    string sqlstr = "INSERT INTO [Quiz] VALUES (N'" + Name.Text + "','" + Email.Text + "',N'" + QuestionTitle.Text + "',N'"+ QuestionBody.Text+ "')";

                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    cmd.ExecuteNonQuery();
                    Message.Text = "成功提問";

                }
                catch (Exception err)
                {

                    Message.Text = "未成功提問，請再次提問";
                }









               


            }
        }
    }
}