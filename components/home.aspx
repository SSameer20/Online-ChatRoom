<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="ChatRoom.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../style/home.css" rel="stylesheet" />
    <style>
        .blog-area {
            margin: 50px 0 0 0;
        }


        .blog {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-content: baseline;
            margin: 100px 200px;
        }

        #lblBlogText {
            font-size: xx-large;
        }

        #btnPost {
            width: 250px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="navigation" id="navigation">
                <h1>Chatroom</h1>
                <div class="nav-bar">
                    <ul>
                        <li><a href="home.aspx">Home</a></li>
                        <li><a href="../login.aspx">Admin</a></li>
                        <li><a href="register.aspx">About</a></li>
                    </ul>
                </div>
            </div>

            <div class="blog">



                <asp:Label ID="lblBlogText" runat="server" Text="Blogs"></asp:Label>



                <div class="blog-area">
                    <%--GridView1--%>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="user" HeaderText="User" />
                            <asp:BoundField DataField="description" HeaderText="Description" />
                            <asp:BoundField DataField="time" HeaderText="Time" />
                            <asp:BoundField DataField="like" HeaderText="Like" />
                            <asp:TemplateField HeaderText="Action">
                                <ItemTemplate>
                                    <asp:Button ID="btnLike" runat="server" Text="Like" OnClick="btnLike_Click" CommandArgument='<%# Eval("user") %>'/>
                                </ItemTemplate>
                            </asp:TemplateField>


                        </Columns>
                    </asp:GridView>


                </div>
                <br />
                <asp:Button ID="btnPost" runat="server" Text="Post Blog" OnClick="btnPost_Click" />
            </div>
        </div>
    </form>
</body>
</html>
