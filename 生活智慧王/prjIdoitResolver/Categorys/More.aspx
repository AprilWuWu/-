<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="More.aspx.cs" Inherits="prjIdoitResolver.categorys.etc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <br /><br />
        <div class="col-xs-12 col-sm-12">
            <a href="#" class="thumbnail">
                <img src="<%=moreQuestion.Split('Ｓ')[3]%>" class="img-fluid">

                <%
                    if (Session["UserName"] != null)
                    {%>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="btnUpload" runat="server" Text="上傳" OnClick="btnUpload_Click" />
                <asp:Label ID="lblMessage" runat="server" font-Bolad="true"></asp:Label>

                <% }%>
                <br /><br /><h1><% =moreQuestion.Split('Ｓ')[0]%></h1><br />
                
                <p><% =moreQuestion.Split('Ｓ')[2] %></p>
                <br />
            </a>
        </div>
    </div>
</asp:Content>
