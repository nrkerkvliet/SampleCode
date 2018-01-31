<%@ Page Title="3-B: Maintain products" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductMaintenance.aspx.cs" Inherits="SportsPro.Administration.ProductMaintenance" %>

<asp:Content ID="main" ContentPlaceHolderID="mainContent" runat="server">
    <div class="container">
    <div class="row">

        <%-- Products GridView --%>
        <div class="col-sm-12 table-responsive">
            <!-- GridView control can go here -->
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductCode" DataSourceID="SqlDataSource1" CssClass="table table-bordered table-condensed table-hover" OnPreRender="GridView1_PreRender" OnRowDeleted="GridView1_RowDeleted" OnRowUpdated="GridView1_RowUpdated">
                <Columns>
                    <asp:BoundField DataField="ProductCode" HeaderText="Product Code" SortExpression="ProductCode" ReadOnly="True">
                        <ItemStyle CssClass="col-sm-2" />
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label runat="server" id="lblGridName" Text='<%# Bind("Name") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <div class="col-xs-11 col-edit">
                                <asp:TextBox runat="server" id="txtGridName" Text='<%# Bind("Name") %>'></asp:TextBox>
                            </div>    
                            <asp:RequiredFieldValidator CssClass="text-danger" ID="rfvGridName" runat="server" ControlToValidate="txtGridName" ValidationGroup="Edit" ErrorMessage="Name is a required field">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemStyle CssClass="col-xs-4"/>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Version">
                        <ItemTemplate>
                            <asp:Label runat="server" id="lblGridVersion" Text='<%# Bind("Version") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <div class="col-xs-11 col-edit">
                                <asp:TextBox runat="server" id="txtGridVersion" Text='<%# Bind("Version") %>'></asp:TextBox>
                            </div>
                            <asp:RequiredFieldValidator CssClass="text-danger" ID="rfvGridVersion" runat="server" ControlToValidate="txtGridVersion" ValidationGroup="Edit" ErrorMessage="Version is a required field">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemStyle CssClass="col-xs-3"/>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderText="Release Date">
                        <ItemTemplate>
                            <asp:Label runat="server" id="lblGridRelease"  Text='<%# Bind("ReleaseDate") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <div class="col-xs-11 col-edit">
                                <asp:TextBox runat="server" id="txtGridRelease" TextMode="Date" Text='<%# Bind("ReleaseDate") %>'></asp:TextBox>
                            </div>
                            <asp:RequiredFieldValidator CssClass="text-danger" ID="rfvGridRelease" runat="server" ControlToValidate="txtGridRelease" ValidationGroup="Edit" ErrorMessage="Release date is a required field">*</asp:RequiredFieldValidator>
                        </EditItemTemplate>
                        <ItemStyle CssClass="col-xs-3"/>
                    </asp:TemplateField>
                    <asp:CommandField CausesValidation="True" ShowEditButton="True" ValidationGroup="Edit">
                        <ItemStyle CssClass="col-xs-1"/>
                    </asp:CommandField>
                    <asp:CommandField CausesValidation="True" ShowDeleteButton="True">
                        <ItemStyle CssClass="col-xs-1"/>
                    </asp:CommandField>
                </Columns>
                <HeaderStyle CssClass="bg-halloween"/>
                <AlternatingRowStyle CssClass="altRow"/>
                <EditRowStyle CssClass="warning"/>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TechSupportConnectionString %>"
                ConflictDetection="CompareAllValues" OldValuesParameterFormatString="original_{0}"
                SelectCommand="SELECT [ProductCode], [Name], [ReleaseDate], [Version] FROM [Products] ORDER BY [ProductCode]"
                DeleteCommand="DELETE FROM [Products] 
                    WHERE [ProductCode] = @original_ProductCode
                    AND [Name] = @original_Name
                    AND [Version] = @original_Version
                    AND [ReleaseDate] = @original_ReleaseDate"
                InsertCommand="INSERT INTO [Products] 
                    ([ProductCode], [Name], [Version], [ReleaseDate]) 
                    VALUES (@ProductCode, @Name, @Version, @ReleaseDate)"
                UpdateCommand="UPDATE [Products] 
                    SET [Name] = @Name,
                        [Version] = @Version,
                        [ReleaseDate] = @ReleaseDate
                    WHERE [ProductCode] = @original_ProductCode
                        AND [Name] = @original_Name
                        AND [Version] = @original_Version
                        AND [ReleaseDate] = @original_ReleaseDate">
                <DeleteParameters>
                    <asp:Parameter Name="original_ProductCode" Type="String"/>
                    <asp:Parameter Name="original_Name" Type="String"/>
                    <asp:Parameter Name="original_Version" Type="String"/>
                    <asp:Parameter Name="original_ReleaseDate" Type="DateTime"/>
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="ProductCode" Type="String"/>
                    <asp:Parameter Name="Name" Type="String"/>
                    <asp:Parameter Name="Version" Type="String"/>
                    <asp:Parameter Name="ReleaseDate" Type="DateTime"/>
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String"/>
                    <asp:Parameter Name="Version" Type="String"/>
                    <asp:Parameter Name="ReleaseDate" Type="DateTime"/>
                    <asp:Parameter Name="original_ProductCode" Type="String"/>
                    <asp:Parameter Name="original_Name" Type="String"/>
                    <asp:Parameter Name="original_Version" Type="String"/>
                    <asp:Parameter Name="original_ReleaseDate" Type="DateTime"/>
                </UpdateParameters>
            </asp:SqlDataSource>
            <%-- Sql data source --%>
            
        </div>
    </div>

    <%-- Validation summary and message label --%>
        <p>To add a new product, enter the product information and click Add Product</p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please correct the following errors:" ValidationGroup="Edit" CssClass="text-danger"/>
    <asp:Label ID="lblMsg" runat="server" Text="" CssClass="text-danger"></asp:Label>
    <%-- Product code text box --%>
     <div class="col-xs-12">
    <div class="form-group">
        <label for="txtCode" class="col-sm-2 text-left">Product Code</label>
        <div class="col-sm-4">
            <asp:TextBox ID="txtCode" runat="server" MaxLength="15" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-sm-offset-3 col-sm-4">
            <asp:RequiredFieldValidator ID="rfvCode" runat="server" ControlToValidate="txtCode" CssClass="text-danger" ErrorMessage="Product code is a required field"></asp:RequiredFieldValidator>
        </div>
    </div>
    <%-- Name text box --%>

        <div class="form-group">
            <label for="txtName" class="col-sm-2 text-left">Name</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtName" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-offset-3 col-sm-4">
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" CssClass="text-danger" ErrorMessage="Name is a required field"></asp:RequiredFieldValidator>
            </div>
        </div>
        <%-- Version text box --%>
        <div class="form-group">
            <label for="txtVersion" class="col-sm-2 text-left">Version</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtVersion" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-offset-3 col-sm-4">
                <asp:RequiredFieldValidator ID="rfvVersion" runat="server" ControlToValidate="txtVersion" CssClass="text-danger" ErrorMessage="Version is a required field"></asp:RequiredFieldValidator>
            </div>
        </div>
        <%-- Release date text box --%>
        <div class="form-group">
            <label for="txtRelease" class="col-sm-2 text-left">Release date</label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtRelease" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-sm-offset-3 col-sm-4">
                <asp:RequiredFieldValidator ID="rfvRelease" runat="server" ControlToValidate="txtRelease" CssClass="text-danger" ErrorMessage="Release date is a required field"></asp:RequiredFieldValidator>
            </div>
        </div>
        <%-- Add button --%>
        <div class="row">
            <div class="col-sm-offset-2 col-sm-1">
                <asp:Button ID="btnAdd" runat="server" Text="Add Product" CssClass="btn btn-primary" OnClick="btnAdd_Click" />
            </div>
        </div>
    </div>
    </div>
</asp:Content>
