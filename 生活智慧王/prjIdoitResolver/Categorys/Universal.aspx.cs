using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;/*組合想要使用的字串*/
using System.IO;/*加入*/
using System.Data;/*加入*/
using System.Configuration;/*加入*/

namespace prjIdoitResolver.categorys
{
    public partial class eat : System.Web.UI.Page
    {
        public List<string> categoryData;
        public List<string> data;
        public string sqlstr, dataSql;
        
        public int searchTerm;
        private string categoryName, image;
        private string title, categoryID, content, datetime, img, id,hits;

   
        protected void btntitle_Click(object sender, EventArgs e)
        {
            int totalRecords = 0;
            int totalRecordsPerPage = 9;
            int totalSlots = 0;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                cn.Open();
                string sql = "SELECT DISTINCT [title], [content], [datetime],[img],[hits] FROM [Question] where [categoryID]=" + Request.QueryString["category"] + "order by [title] desc ";
                SqlCommand cmd = new SqlCommand(sql, cn);
                /*SqlDataReader drMembers= cmd.ExecuteReader();*/
                SqlDataAdapter drMembers = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); //建立虛擬DatsSet

                drMembers.Fill(dt); //將資料填入資料表       
                data = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    totalRecords++;
                    title = row["title"].ToString();
                    //Label1.Text = name.ToString();
                    content = row["content"].ToString();
                    datetime = row["datetime"].ToString();
                    img = row["img"].ToString();
                    hits = row["hits"].ToString();
                    string result = title + "," + content + "," + datetime + "," + img + "," + hits;
                    data.Add(result);
                }
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
                cn.Close();
                totalSlots = totalRecords / totalRecordsPerPage;

                int curPage = 1;
                int.TryParse(Request.QueryString["page"] + "", out curPage);
                if (curPage == 0)
                    curPage = 1;

                FlexyPager fp = new FlexyPager();
                fp.PageUrlFormat = "Universal.aspx?category=" + Request.QueryString["category"] + "&page={p}";
                fp.TotalRecords = totalRecords;
                fp.TotalRecordsPerPage = totalRecordsPerPage;
                fp.TotalSlots = totalSlots;
                fp.CurrentPage = curPage;
                fp.CssClassCurrentPage = "active";
                fp.CssClassFirstPage = "";
                fp.CssClassLastPage = "";
                fp.FirstPageDisplayText = "第1頁";
                fp.LastPageDisplayText = "最後頁";
                string pagerHtml = fp.GetHtml();
                fp.CssClass = "pager_gray_green";
                fp.CssClassCurrentPage = "active";
                PlaceHolder1.Controls.Add(new LiteralControl(fp.GetHtml()));
                PlaceHolder1.Controls.Add(new LiteralControl("<br /><br /><br />"));
            }
        }

        protected void btndatetime_Click(object sender, EventArgs e)
        {
            int totalRecords = 0;
            int totalRecordsPerPage = 9;
            int totalSlots = 0;

            using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();
                    string sql = "SELECT DISTINCT [title], [content], [datetime],[img],[hits] FROM [Question] where [categoryID]="+ Request.QueryString["category"]+ " order by [datetime] desc ";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    /*SqlDataReader drMembers= cmd.ExecuteReader();*/
                    SqlDataAdapter drMembers = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable(); //建立虛擬DatsSet
                    drMembers.Fill(dt); //將資料填入資料表       
                    data = new List<string>();
                    foreach (DataRow row in dt.Rows)
                    {
                        totalRecords++;
                        title = row["title"].ToString();
                        //Label1.Text = name.ToString();
                        content = row["content"].ToString();
                        datetime = row["datetime"].ToString();
                        img = row["img"].ToString();
                        hits = row["hits"].ToString();
                        string result = title + "," + content + "," + datetime + "," + img + "," + hits;
                        data.Add(result);
                    }
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    reader.Close();
                    cn.Close();
                totalSlots = totalRecords / totalRecordsPerPage;

                int curPage = 1;
                int.TryParse(Request.QueryString["page"] + "", out curPage);
                if (curPage == 0)
                    curPage = 1;

                FlexyPager fp = new FlexyPager();
                fp.PageUrlFormat = "Universal.aspx?category=" + Request.QueryString["category"] + "&page={p}";
                fp.TotalRecords = totalRecords;
                fp.TotalRecordsPerPage = totalRecordsPerPage;
                fp.TotalSlots = totalSlots;
                fp.CurrentPage = curPage;
                fp.CssClassFirstPage = "";
                fp.CssClassLastPage = "";
                fp.FirstPageDisplayText = "第1頁";
                fp.LastPageDisplayText = "最後頁";
                string pagerHtml = fp.GetHtml();
                fp.CssClass = "pager_gray_green";
                fp.CssClassCurrentPage = "active";
                PlaceHolder1.Controls.Add(new LiteralControl(fp.GetHtml()));
                PlaceHolder1.Controls.Add(new LiteralControl("<br /><br /><br />"));
            }
            }      

        //        }
        //    }
        //    catch (Exception)
        //    {
        //        lblMessage.Text = "執行錯誤：" + sqlstr;
        //    }
        //}
        

        //            cmd.ExecuteNonQuery();
        //            Response.Redirect(Request.Url.ToString());
    

        

        //protected void btnUpload_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SqlConnection cn = new SqlConnection())
        //        {
        //            FileUpload1.SaveAs(Server.MapPath("~/assets/images/" + FileUpload1.FileName));
        //            lblMessage.Text = "檔案已上傳";
        //            lblMessage.ForeColor = System.Drawing.Color.Green;
        //            // 連接字串指定連接LeeLabDB資料庫
        //            cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
        //            cn.Open();  // 連接資料庫

        //            sqlstr = "UPDATE [Category] SET [img] ='assets/images/" + FileUpload1.FileName + "' WHERE [id]='" + Session["Category"].ToString() + "'";
        //            // 建立SqlCommand物件cmd
        //            SqlCommand cmd = new SqlCommand(sqlstr, cn);
        protected void Page_Load(object sender, EventArgs e)
        {
            int totalRecords = 0;
            int totalRecordsPerPage = 9;
            int totalSlots = 0;

            if (!Page.IsPostBack)
            {
               
                using (SqlConnection cn = new SqlConnection())
                {
                    // 連接字串指定連接Database1資料庫
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();  // 連接資料庫
                    
                    if (string.IsNullOrEmpty(Request.QueryString["searchKeyWords"])) { 
                       searchTerm = 1;
                    }
                    if (!string.IsNullOrEmpty(Request.QueryString["category"]))
                    {
                        searchTerm = int.Parse(Request.QueryString["category"]);
                        string categorySql = "SELECT * FROM [Category] where [id]=" + searchTerm;

                        SqlCommand cmd = new SqlCommand(categorySql, cn);
                        SqlDataAdapter drMembers = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable(); //建立虛擬DatsSet
                        drMembers.Fill(dt); //將資料填入資料表
                        categoryData = new List<string>();
                        foreach (DataRow row in dt.Rows)
                        {
                            categoryName = row["categoryName"].ToString();
                            image = row["image"].ToString();
                            string result = categoryName + "," + image;
                            categoryData.Add(result);
                        }

                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        reader.Close();
                    }

                    if (string.IsNullOrEmpty(Request.QueryString["searchKeyWords"]) || string.IsNullOrEmpty(Request.QueryString["category"]))
                    {
                        searchTerm = 1;
                        dataSql = "SELECT * FROM [Question] where [categoryID]=" + searchTerm;
                    }
                    if (!string.IsNullOrEmpty(Request.QueryString["category"])){
                        searchTerm = int.Parse(Request.QueryString["category"]);
                        dataSql = "SELECT * FROM [Question] where [categoryID]=" + searchTerm;
                    }
                    if(!string.IsNullOrEmpty(Request.QueryString["searchKeyWords"])){
                        dataSql = "Select [id],[img],[categoryID],[title],[content],[datetime],[hits] from [Question] where [title] like '%" + Request.QueryString["searchKeyWords"] + "%' or [content] like '%" + Request.QueryString["searchKeyWords"] + "%'";
                    }
                    
                    SqlCommand cmd1 = new SqlCommand(dataSql, cn);
                    SqlDataAdapter drMembers1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable(); //建立虛擬DatsSet
                    drMembers1.Fill(dt1); //將資料填入資料表
                    data = new List<string>();
                    foreach (DataRow row in dt1.Rows)
                    {
                        totalRecords++;
                        title = row["title"].ToString();
                        categoryID = row["categoryID"].ToString();
                        content = row["content"].ToString();
                        datetime = row["datetime"].ToString();
                        hits = row["hits"].ToString();

                        if (content.Length > 20)
                        {
                            content = content.Substring(0, 20) + "...";
                        }
                        //from = row["from"].ToString();
                        img = row["img"].ToString();
                        id = row["id"].ToString();
                        string result = title + "," + categoryID + "," + content + "," + img + "," + id + "," + datetime + "," + hits;
                        data.Add(result);
                        
                    }

                    // categoryData = db.Categories.Find(searchTerm);
                    // data = db.Questions.Where(x => x.categoryID == searchTerm).ToList();

                    //data.ForEach(x =>
                    //{
                    //    if(x.content.Length > 20)
                    //    {
                    //        x.content = x.content.Substring(0, 20) + "...";
                    //    }
                    //});

                    //totalRecords = data.Count();

                     totalSlots = totalRecords / totalRecordsPerPage;

                     int curPage = 1;
                     int.TryParse(Request.QueryString["page"] + "", out curPage);
                     if (curPage == 0)
                         curPage = 1;

                     FlexyPager fp = new FlexyPager();
                     fp.PageUrlFormat = "Universal.aspx?category=" + Request.QueryString["category"] + "&page={p}";
                     fp.TotalRecords = totalRecords;
                     fp.TotalRecordsPerPage = totalRecordsPerPage;
                     fp.TotalSlots = totalSlots;
                     fp.CurrentPage = curPage;
                     fp.CssClassFirstPage = "";
                     fp.CssClassLastPage = "";
                     fp.FirstPageDisplayText = "第1頁";
                     fp.LastPageDisplayText = "最後頁";
                     string pagerHtml = fp.GetHtml();
                     fp.CssClass = "pager_gray_green";
                     fp.CssClassCurrentPage = "active";
                     PlaceHolder1.Controls.Add(new LiteralControl(fp.GetHtml()));
                     PlaceHolder1.Controls.Add(new LiteralControl("<br /><br /><br />"));
                }
            }
        }
    }

}