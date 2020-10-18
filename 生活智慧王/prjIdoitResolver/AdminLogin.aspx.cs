using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjIdoitResolver
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        string name, id;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    // 連接字串指定連接資料庫
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();  // 連接資料庫

                    string sqlstr = "Select [account],[password],[name] from [User] where [account]='" + Email.Text + "' and [password]='" + Password.Text + "'";

                    // 建立SqlCommand物件cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    SqlDataAdapter drMembers = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); //建立虛擬DatsSet
                    drMembers.Fill(dt); //將資料填入資料表       

                    foreach (DataRow row in dt.Rows)
                    {
                        id = row["account"].ToString();
                        name = row["name"].ToString();

                        Session["UserID"] = id;
                        Session["UserName"] = name;

                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    Response.Redirect("/Index.aspx");
                    //cmd.ExecuteNonQuery();
                    //Label2.Text = "登入成功";


                    if (id != null)
                    {
                        Response.Redirect("index.aspx");
                        //cmd.ExecuteNonQuery();
                        //Label2.Text = "登入成功";
                    }
                    else
                    {
                        Email.Text = "";
                        Password.Text = "登入失敗：ID不存在或密碼錯誤!";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert('帳號密碼錯誤，請重新登入');</script>");
            }







            //if (Email.Text == "111" && Password.Text == "000")
            //    {
            //        Session["UserName"] = "管理者";
            //        Session["UserID"] = "000";
            //        Response.Redirect("/Index.aspx");
            //    }
            //    else
            //    {
            //        Response.Write("<script language=javascript>alert('帳號密碼錯誤，請重新登入');</script>");
            //    }
        }
    }
}