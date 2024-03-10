<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="post.aspx.cs" Inherits="ChatRoom.components.post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="txtUser">User:</label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br /><br />

            <label for="txtDescription">Blog Description:</label><br />
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox><br /><br />

            <asp:Button ID="btnSubmit" runat="server" Text="post" onClick="btnSubmit_Click"/>
        </div>
    </form>
</body>
</html>
