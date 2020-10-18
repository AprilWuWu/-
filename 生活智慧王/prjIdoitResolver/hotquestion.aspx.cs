using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;/*組合想要使用的字串*/
using System.IO;/*加入*/
using System.Data;/*加入*/
using System.Configuration;/*加入*/


namespace prjIdoitResolver
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        //string Sqlstr;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)/*如果是第一次連到這一頁*/
           /* {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Database1"].ConnectionString;
                    cn.Open();

                   // Sqlstr = "INSERT INTO [Quiz]([Id], [Name], [Email], [QuestionTitle],[QuestionBody]) VALUES(" + Label1.Text + " ',N' " + Label2.Text + " ',N' " + Label3.Text + " ',N' " + Label4.Text + ")";
                    SqlCommand cmd = new SqlCommand
                     ("SELECT DISTINCT [Id], [Name], [Email], [QuestionTitle],[QuestionBody] FROM [Quiz] order by [Id] desc", cn);

                    //("SELECT DISTINCT [name], [role], [pic],[id],[status],[job] FROM [members] where [status]=1 order by [id], [role]", cn);
                    SqlDataReader drMembers = cmd.ExecuteReader();
                    /*將前端的相關版面設計先加入sb*/

                  //  StringBuilder sb1 = new StringBuilder();//存放主要工作人力


                    /*GridView1.DataSource = drMembers;
                      GridView1.DataBind();*/
                    /*如果需要寫欄位名稱，使用以下程式*/
                    /*
                    for (int i=0;i<drMembers.FieldCount;i++)
                    { 
                     sb.Append("<li class='two columns'>");
                     sb.Append("<img alt='' src='img/members/");
                     sb.Append(drMembers.GetName(i));
                     sb.Append("'></li>");
                    }*/
                    /*如果要讀取欄位內容*/
               //     while (drMembers.Read())/*如果drMembers還有紀錄(意即「不是在檔案的結尾」)就會執行以下程式*/
                  /*  {
                        sb1.Append("<br>");
                        //sb1.Append("<li class='two columns'>");
                        sb1.Append("<img alt=''");
                        sb1.Append("<p style='margin-left: 450px;'>姓名 : " + drMembers["Name"] + "</p>" + "<p style='margin-left: 450px;'>Email : " + drMembers["Email"].ToString() + "</p>");
                        //sb1.Append("'>");
                        //sb1.Append("<p style='text-align:center;'>" + drMembers["Email"].ToString() + "</p>");
                        sb1.Append("<p style='margin-left: 450px;'>標題 : " + drMembers["QuestionTitle"] + "</p>");
                        sb1.Append("<p style='margin-left: 450px;'>內容 : " + drMembers["QuestionBody"] + "</p>");
                        //sb1.Append("</li>");
                        sb1.Append("<br>");
                    }

                    Label1.Text = sb1.ToString();
                   
                }
            }*/
    
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    }