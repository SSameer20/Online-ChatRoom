<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ChatRoom.login" %>

<!DOCTYPE html>
<link href="style/login.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chatroom | online discussion platform</title>
    <style>
        body {
            margin: 30vh 40vw;
            background-color: aqua;
        }



        #login {
            border: solid 0.1rem black;
        }

        .login-form div {
            display: flex;
            flex-direction: column;
            padding: 10px 0px;
            width: 250px;
        }

        #title {
            font-size: x-large;
            color: palevioletred;
        }
    </style>

</head>
<body>
    <form id="login" runat="server">
        <div>
            <div class="login-form">

                <asp:Label ID="title" runat="server" Text="Login"></asp:Label>
                <div class="user-name">
                    <asp:Label ID="lblUser" runat="server" Text="Username : "></asp:Label>
                    <input id="txtUsername" runat="server" type="text" />
                </div>

                <div class="password-area">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    <input id="txtPassword" runat="server" type="password" />
                </div>

                <asp:Button ID="btnSubmit" runat="server" Text="Login" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

            </div>
        </div>
    </form>
</body>
</html>
