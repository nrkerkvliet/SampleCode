<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="a_01_carApp.Models.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-xs-12">
                <asp:GridView CssClass="table table-condensed table-bordered table-striped" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                    <Columns>
                        <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                        <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName" />
                        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AutoAppConnectionString %>" SelectCommand="SELECT [FName], [LName], [Id] FROM [Accounts] ORDER BY [Id]"></asp:SqlDataSource>
                <asp:GridView CssClass="table table-condensed table-bordered table-striped" ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
                        <asp:BoundField DataField="Model" HeaderText="Model" SortExpression="Model" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AutoAppConnectionString %>" SelectCommand="SELECT [Id], [Make], [Model] FROM [Vehicles] ORDER BY [Id]"></asp:SqlDataSource>
            </div>
        </div>
    </form>
</body>
</html>
