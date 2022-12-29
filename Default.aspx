<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 273px;
        }
    </style>
</head>
<body style="height: 288px">
    <form id="form1" runat="server">
        <div>
            Show infos of employee<br />
            <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Show" Width="48px" />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </div>
                </div>
             
    </form>
</body>
</html>
