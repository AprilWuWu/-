using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace prjIdoitResolver.categorys
{

    public partial class search : System.Web.UI.Page
    {
        //public List<Question> searchData;
        //public Category categoryData;
        protected void Page_Load(object sender, EventArgs e) { }
    }
    
        class WhereSample3
    {
        static void Main()
        {
            // Data source
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Create the query with a method call in the where clause.
            // Note: This won't work in LINQ to SQL unless you have a
            // stored procedure that is mapped to a method by this name.
            var queryEvenNums =
                from num in numbers
                where IsEven(num)
                select num;

            // Execute the query.
            foreach (var s in queryEvenNums)
            {
                Console.Write(s.ToString() + " ");
            }
        }


        // Method may be instance method or static method.
        static bool IsEven(int i)
        {
            return i % 2 == 0;
        }
    }

    //Output: 4 8 6 2 0


    //Output: 4 1 3 2 0

    //if (!Page.IsPostBack)
    //{
    //    string searchTerm = ""; //定易搜尋字串
    //    if (!string.IsNullOrEmpty(Request.QueryString["search"])) //看?後面有沒有search
    //    {
    //        searchTerm = Request.QueryString["search"];
    //    }
    //    using (Database1Entities db = new Database1Entities())
    //    {
    //        searchData = db.Questions.Where(x =>
    //                x.title.Contains(searchTerm)
    //                || x.content.Contains(searchTerm)
    //            )
    //            .ToList();
    //        searchData.ForEach(x =>
    //        {
    //            x.img = db.Categories.Find(x.categoryID).image;
    //            if (x.content.Length > 20)
    //            {
    //                x.content = x.content.Substring(0, 20) + "...";
    //            }
    //        });
    //    }
    //}
}
