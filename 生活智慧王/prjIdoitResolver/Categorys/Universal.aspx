<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Universal.aspx.cs" Inherits="prjIdoitResolver.categorys.eat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">







    <%--<h1>食</h1>--%>
    <div class="container py-4 py-lg-5">
        <asp:Button ID="btndatetime" runat="server" Text="日期遞減" OnClick="btndatetime_Click" />
        <asp:Button ID="btntitle" runat="server" Text="標題遞減" OnClick="btntitle_Click" />
        <div class="fables-blog my-3">
            <h2 class="fables-second-text-color mb-4 mb-lg-5 font-weight-bold"></h2>
            <div class="row">
                <%--<asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="btnUpload" runat="server" Text="上傳" OnClick="btnUpload_Click" />
            <asp:Label ID="lblMessage" runat="server" font-Bolad="true"></asp:Label>--%>

                <%int recordNo = -1;
                    foreach (var test in data)
                    {
                        recordNo++;
                        if (Convert.ToInt32(recordNo / 9) + 1 == Convert.ToInt32(Request.QueryString["page"]) || (recordNo <= 8 && Request.QueryString["page"] == null))
                        {%>
                <%string[] sArray = test.Split(',');%>
                <div class="col-12 col-md-4 mb-4 mb-lg-5">
                    <a href="#">
                        <img src="<%= sArray[3] %>" alt="" class="w-100 h-75"></a>
                    <h2 class="font-18 semi-font font-18  mt-3"><a href="#" class="fables-main-text-color fables-second-hover-color"><% = sArray[0] %></a></h2>
                    <%--<p class="fables-fifth-text-color font-13 my-1">09 November, 2018</p>--%>
                    <p class="fables-forth-text-color font-14">
                        <% = sArray[2] %>
                    </p>
                    <a href="/Categorys/More.aspx?questionId=<%=sArray[4] %>" class="btn fables-main-text-color fables-second-hover-color p-0 underline mt-2">Read More</a>
                </div>
                <%}
                    } %>
            </div>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

        </div>
    </div>
</asp:Content>
