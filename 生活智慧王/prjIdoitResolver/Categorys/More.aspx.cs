using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjIdoitResolver.categorys
{
    public partial class etc : System.Web.UI.Page
    {
        public string moreCategory;
        public string moreQuestion;
        private string categoryName, image;
        private string title, categoryID, content, from, img, id;

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                int searchTerm = 2;
                if (!string.IsNullOrEmpty(Request.QueryString["questionId"]))
                {
                    searchTerm = int.Parse(Request.QueryString["questionId"]);
                }
                using (SqlConnection cn = new SqlConnection())
                {
                    FileUpload1.SaveAs(Server.MapPath("~/assets/images/upload/" + FileUpload1.FileName));
                    lblMessage.Text = "檔案已上傳";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    // 連接字串指定連接Database1資料庫
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();  // 連接資料庫

                    string sqlstr = "UPDATE [Question] SET [img] ='/assets/images/upload/" + FileUpload1.FileName + "' WHERE [id]=" + searchTerm;
                    // 建立SqlCommand物件cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);

                    cmd.ExecuteNonQuery();
                    Response.Redirect(Request.Url.ToString());
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "執行錯誤" + ex.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int searchTerm = 2;
                if (!string.IsNullOrEmpty(Request.QueryString["questionId"]))
                {
                    searchTerm = int.Parse(Request.QueryString["questionId"]);
                }
                using (SqlConnection cn = new SqlConnection())
                {
                    // 連接字串指定連接資料庫
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();  // 連接資料庫

                    string sqlstr = "Select * from [Question] where [Id]=" + searchTerm;
                    // 建立SqlCommand物件cmd
                    SqlCommand cmd = new SqlCommand(sqlstr, cn);
                    SqlDataAdapter drMembers = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); //建立虛擬DatsSet
                    drMembers.Fill(dt); //將資料填入資料表

                    foreach (DataRow row in dt.Rows)
                    {
                        id = row["Id"].ToString();
                        title = row["title"].ToString();
                        categoryID = row["categoryID"].ToString();
                        content = row["content"].ToString();
                        //from = row["from"].ToString();
                        img = row["img"].ToString();
                        string result = title + "Ｓ" + categoryID + "Ｓ" + content + "Ｓ" + img+ "Ｓ" + id;
                        moreQuestion = result;
                    }
                    //moreQuestion = db.Questions.Find(searchTerm);
                    //moreCategory = db.Categories.Find(moreQuestion.categoryID);
                }
            }
        }
    }
}