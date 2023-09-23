<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Rainbow.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <h2>Feedback Form</h2>
    <div>
        <label for="name">Name:</label>
        <asp:TextBox ID="name" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="email">Email:</label>
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
    </div>
    <div>
        <label for="message">Message:</label>
        <asp:TextBox ID="message" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="SubmitFeedback" />
    </div>
</asp:Content>
