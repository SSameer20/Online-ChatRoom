<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ChatRoom.components.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style/register.css" rel="stylesheet" />
</head>
<body>
    <form id="register" runat="server">
        <div>
            <div class="register-form">

                <asp:Label ID="title" runat="server" Text="Register"></asp:Label>

                <div class="email-area">
                    <asp:Label ID="lblEmail" runat="server" Text="email"></asp:Label>
                    <input id="txtEmail" runat="server" type="text" />
                </div>

                <div class="user-name">
                    <asp:Label ID="lblUser" runat="server" Text="Username : "></asp:Label>
                    <input id="txtUsername" runat="server" type="text" />
                </div>

                <div class="password-area">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <input id="txtPassword" runat="server" type="password" />
                </div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                <asp:Button ID="btnLogin" runat="server" Text="Login" onClick="btnLogin_Click"/>
            </div>
        </div>
    </form>

</body>
</html>
