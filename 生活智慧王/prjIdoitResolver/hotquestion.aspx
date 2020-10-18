<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="hotquestion.aspx.cs" Inherits="prjIdoitResolver.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3 class="font-35 font-weight-bold fables-second-text-color text-center mb-3">熱門留言</h3>
    <br />
     <!--<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>

  <!--以下設定資料庫來源及帳密設定，後續只要呼叫name即可使用該資料庫-->
  <!--<connectionStrings>
    <add name="Database1" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1;Integrated Security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>
  <!--資料庫連線設定完成-->

    <div style='margin-left: 723px;'>   
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="名字" SortExpression="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="QuestionTitle" HeaderText="標題" SortExpression="QuestionTitle" />
                <asp:BoundField DataField="QuestionBody" HeaderText="內容" SortExpression="QuestionBody" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Database1 %>" SelectCommand="SELECT [Id], [Name], [Email], [QuestionTitle], [QuestionBody] FROM [Quiz]"></asp:SqlDataSource>
    </div>
    <br />
    <br />
</asp:Content>
