using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Text;/*組合想要使用的字串*/

namespace prjIdoitResolver
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)/*如果是第一次連到這一頁*/
            //{
            //    using (Database1Entities db = new Database1Entities())
            //    {
            //        var datas = db.Categories.ToList();
            //        var bb = db.Answers.ToList();
            //        /*將前端的相關版面設計先加入sb*/

            //        StringBuilder sb1 = new StringBuilder();//存放主要工作人力

            //        foreach (var data in datas)/*如果drMembers還有紀錄(意即「不是在檔案的結尾」)就會執行以下程式*/
            //        {

            //            sb1.Append("<li class='two columns'>");
            //            //sb1.Append("<img alt=''");
            //            //sb1.Append("src='" + drMembers["categoryName"].ToString());
            //            //sb1.Append("'>");
            //            sb1.Append("<p style='text-align:center;'>" + data.categoryName.ToString() + "</p>");
            //            //sb1.Append("<p style='text-align:center;'>" + drMembers["role"] + "</p>");
            //            sb1.Append("</li>");

            //        }

                    //Label1.Text = sb1.ToString();
            //    }
            //}
        }

    }
}