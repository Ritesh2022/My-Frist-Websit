<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sesstion1.aspx.cs" Inherits="WebApplication3.Sesstion1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
               <td>
                   <asp:Label ID="lblUser" runat="server" Text="User Name">                                                            
                    </asp:Label>
               </td>
                <td>
                    
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
               <td>
                   <asp:Label ID="lblPassword" runat="server" Text="Password">                                                            
                    </asp:Label>
               </td>
                <td>
                   
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                     <asp:Button ID="btnResotre" runat="server" Text="Restore" OnClick="btnResotre_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
