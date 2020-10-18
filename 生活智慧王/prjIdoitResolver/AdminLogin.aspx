<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="prjIdoitResolver.AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="fables-light-background-color">
        <div class="container">
            <nav aria-label="breadcrumb">
                <ol class="fables-breadcrumb breadcrumb px-0 py-3">
                    <li class="breadcrumb-item"><a href="/Index.aspx" class="fables-second-text-color">Home</a></li>
                    <li class="breadcrumb-item active" aria-current="page">Signin</li>
                </ol>
            </nav>
        </div>
    </div>
    <div class="container">
        <div class="row my-4 my-lg-5">
            <div class="col-12 col-md-8 offset-md-2 col-lg-6 offset-lg-3 text-center">
                <img src="assets/My_images/Homepagepng.png" alt="signin" class="img-fluid" width="250">
                <p class="font-20 semi-font fables-main-text-color mt-4 mb-4 mb-lg-5">管理者登入</p>
                <form>
                    <div class="form-group">
                        <div class="input-icon">
                            <span class="fables-iconemail fables-input-icon mt-2 font-13"></span>
                            <%-- <input type="email" class="form-control rounded-0 py-3 pl-5 font-13 sign-register-input" placeholder="Email">--%>
                            <asp:TextBox ID="Email" runat="server" class="form-control rounded-0 py-3 pl-5 font-13 sign-register-input" placeholder="Email"></asp:TextBox>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="input-icon">
                            <span class="fables-iconpassword fables-input-icon font-19 mt-1"></span>
                            <%--<input type="password" class="form-control rounded-0 py-3 pl-5 font-13 sign-register-input" placeholder="Password">--%>
                            <asp:TextBox ID="Password" runat="server" class="form-control rounded-0 py-3 pl-5 font-13 sign-register-input" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>

                    </div>
                    <%--<button type="submit" class="btn btn-block rounded-0 white-color fables-main-hover-background-color fables-second-background-color font-16 semi-font py-3">登入</button>--%>

                    <asp:Button ID="Submit" runat="server" Text="登入" class="btn btn-block rounded-0 white-color fables-main-hover-background-color fables-second-background-color font-16 semi-font py-3" OnClick="Submit_Click" />
                </form>
            </div>
        </div>

    </div>
</asp:Content>
