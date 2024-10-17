<%@ Page Title="" Language="C#" MasterPageFile="PublicPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="QuanLySinhVien.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h1 class="text-center">Nhập thông tin sinh viên</h1>
            </div>
        </div>
    </div>

    <div id="form-add-student" class="add-student-form">
        <div class="add-student-row">
            <label for="studentId" id="labelStudentId">Mã sinh viên:</label>
            <asp:TextBox ID="txtStudentId" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="add-student-row">
            <label for="name">Họ và tên:</label>
            <asp:TextBox ID="txtName" CssClass="input" runat="server"></asp:TextBox>
        </div>
        <div class="add-student-row">
            <label for="password">Mật khẩu:</label>
            <asp:TextBox ID="txtPassword" CssClass="input" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div class="add-student-row">
            <label for="dob">Ngày sinh:</label>
            <asp:TextBox ID="txtDob" CssClass="input" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div class="add-student-row">
            <label>Giới tính:</label>
            <div class="gender-group-radiobutton">
                <asp:RadioButton ID="rbtnMale" runat="server" GroupName="Gender" Text="Nam" CssClass="" />
                <asp:RadioButton ID="rbtnFemale" runat="server" GroupName="Gender" Text="Nữ" CssClass="" />
                <asp:RadioButton ID="rbtnOther" runat="server" GroupName="Gender" Text="Khác" CssClass="" />
            </div>
        </div>
        <div>
            <asp:Button ID="btnSubmit" CssClass="button" runat="server" Text="Submit" OnClick="btnLogin_Click" />
        </div>
        <div>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </div>
</asp:Content>
