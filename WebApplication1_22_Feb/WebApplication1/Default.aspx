<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
        <div class="col-md-8">
            <section id="CustomerForm">
                <div class="form-horizontal">
                    <h4>Enter Details.</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="DLNumber" CssClass="col-md-2 control-label">DLNumber</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="DLNumber" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="DLNumber"
                                CssClass="text-danger" ErrorMessage="The DLNumber field is required." />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="BorrowerName" CssClass="col-md-2 control-label">Borrower Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="BorrowerName" CssClass="form-control"/>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Car" CssClass="col-md-2 control-label">Car</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Car" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Car"
                                CssClass="text-danger" ErrorMessage="The Car field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Hours" CssClass="col-md-2 control-label">Hours</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Hours" CssClass="form-control"/>
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Hours"
                                CssClass="text-danger" ErrorMessage="The Hours field is required." />
                        </div>
                    </div>

                  
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="BookCar" Text="BookCar" CssClass="btn btn-default" />
                        </div>
                       <p> &nbsp;</p>
                    </div>
                </div>
            </section>
        </div>

   
    </div>

   <%-- <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>
