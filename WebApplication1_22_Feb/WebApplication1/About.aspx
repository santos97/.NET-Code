<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:GridView ID="GridView1" runat="server" CssClass="table" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
        <Columns>
            <asp:BoundField DataField="DLNumber" HeaderText="DLNumber" SortExpression="DLNumber" />
            <asp:BoundField DataField="BorrowerName" HeaderText="BorrowerName" SortExpression="BorrowerName" />
            <asp:BoundField DataField="Car" HeaderText="Car" SortExpression="Car" />
            <asp:BoundField DataField="deposit" HeaderText="deposit" SortExpression="deposit" />
            <asp:BoundField DataField="Hours" HeaderText="Hours" SortExpression="Hours" />
        </Columns>
    </asp:GridView>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="WebApplication1.Models.ApplicationDbContext" EntityTypeName="" TableName="CarModels">
    </asp:LinqDataSource>
    
</asp:Content>
