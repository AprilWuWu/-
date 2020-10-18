using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;/*組合想要使用的字串*/
using System.IO;/*加入*/
using System.Data;/*加入*/
using System.Configuration;/*加入*/


namespace prjIdoitResolver
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
              
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserName");
            Session.Remove("UserID");
            Response.Redirect("/AdminLogin.aspx");
        }
     
        
    }
}