<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="prjIdoitResolver.ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
		<div class="row my-4 my-md-5">
			<div class="col-12 col-md-10 offset-md-1 col-lg-8 offset-lg-2">
				<h3 class="font-35 font-weight-bold fables-second-text-color text-center mb-3">我要提問</h3>
				<p class="fables-forth-text-color text-center">有什麼問題都可以在這裡提出哦，管理員會盡快為您解答! </p>

			</div>
		</div>
		<div class="row overflow-hidden">
			<div class="col-12 wow slideInLeft" data-wow-duration="1.5s" style="visibility: visible; animation-duration: 1.5s; animation-name: slideInLeft;">
				<form class="fables-contact-form">
					<div class="form-row">
						<div class="form-group col-md-12">
							<%--<input type="text" class="form-control p-3 rounded-0" placeholder="姓名">--%>
							<asp:TextBox ID="Name" runat="server" class="form-control p-3 rounded-0" placeholder="姓名"></asp:TextBox>
						</div>
						
						<%--<div class="form-group col-md-6">
							<input type="text" class="form-control p-3 rounded-0" placeholder="Last Name">
						</div>--%>
					</div>
					<div class="form-row">
						<div class="form-group col-md-6">
							<%--<input type="email" class="form-control p-3 rounded-0" placeholder="信箱">--%>
							<asp:TextBox ID="Email" runat="server" class="form-control p-3 rounded-0" placeholder="信箱"></asp:TextBox>
						</div>
						<div class="form-group col-md-6">
							<%--<input type="text" class="form-control p-3 rounded-0" placeholder="提問主旨">--%>
							<asp:TextBox ID="QuestionTitle" runat="server" class="form-control p-3 rounded-0" placeholder="提問主旨"></asp:TextBox>
						</div>
					</div>
					<div class="form-row">
						<div class="form-group col-md-12">
							<%--<textarea class="form-control p-3 rounded-0" placeholder="提問內容" rows="4"></textarea>--%>
							<asp:TextBox ID="QuestionBody" runat="server" class="form-control p-3 rounded-0" placeholder="提問內容" rows="4" TextMode="MultiLine"></asp:TextBox>

						</div>
					</div>
					<div class="form-row">
						<div class="form-group col-md-12 text-center">
							<%--<button type="submit" class="btn fables-second-background-color fables-btn-rounded white-color px-7 font-20 py-2">Send</button>--%>
                            <asp:Button ID="Submit" runat="server" Text="Send" class="btn fables-second-background-color fables-btn-rounded white-color px-7 font-20 py-2" OnClick="Submit_Click"/>
						</div>
                        <asp:Label ID="Message" runat="server" Text=""></asp:Label>
					</div>
				</form>


			</div>

		</div>
	</div>

</asp:Content>
