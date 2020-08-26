<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LD3WebForm.aspx.cs" Inherits="LD3_Web_App.LD3WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LD3</title>
    <link href="Main.css" rel="stylesheet" />
</head>
<body>
    <form id="main" runat="server">
        <div>
            <h1>Web Servisa tests</h1>
        </div>              
        <div id ="mainBody">
            <div>
                <asp:Label CssClass="Label" ID="LabelAdd" runat="server" Text="Ievadi modificējamo tesktu:"></asp:Label>
                <asp:TextBox CssClass="textBox" ID="TextAdd" runat="server" autocomplete="off"></asp:TextBox>
            </div>            
            <div>
                <asp:TextBox CssClass="textBox1" ID="TextPost" runat="server" autocomplete="off"></asp:TextBox>
            </div>
                
            <div>
                <asp:Button ID="BtnService" runat="server" Text="Pārveidot" font-size="30px" margin-left="1350px"
                            margin-right="10px" height="50px" width="150px" margin-top="10px" OnClick="BtnService_Click"/>
            </div>
        </div>
    </form>
</body>
</html>
