<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xDBHelper.aspx.cs" Inherits="SitecoreXDBHelper.xDBHelper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <div>
        <table>
          <tbody>
            <tr>
              <td>Interaction ID:</td>
              <td>
                <asp:Literal ID="InteractionLabel" runat="server"></asp:Literal>
              </td>
            </tr>
            <tr>
              <td>Contact ID:</td>
              <td>
                <asp:Literal ID="ContactLabel" runat="server"></asp:Literal>
              </td>
            </tr>
            <tr>
              <td>Browser:</td>
              <td>
                <asp:Literal ID="BrowserVersionLabel" runat="server"></asp:Literal>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
      <div>
        <asp:Button ID="SessionAbandonButton" runat="server" Text="Flush session" OnClick="SessionAbandonClick" />
      </div>
    </div>
    </form>
</body>
</html>
