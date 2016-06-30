<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xDBHelper.aspx.cs" Inherits="SitecoreXDBHelper.xDBHelper" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="InfoBox" runat="server"></asp:Literal>
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
            <tr>
              <td>Identification Level:</td>
              <td>
                <asp:Literal ID="IdentificationLevel" runat="server"></asp:Literal>
              </td>
            </tr>
            <tr>
              <td>Identifier:</td>
              <td>
                <asp:Literal ID="Identifier" runat="server"></asp:Literal>
              </td>
            </tr>
            <tr>
              <td>Contact Identity:</td>
              <td>
                Any unique identifyer (E-Mail, UserId,...)<br/>
                <asp:TextBox ID="ContactIdentity" runat="server"></asp:TextBox>
                <asp:Button ID="IdentifyButton" runat="server" Text="Identify" OnClick="IdentifyClick" />
              </td>
            </tr>
            <tr>
              <td>Contact Data:</td>
              <td>
                
                FirstName: <asp:TextBox ID="ContactFirstName" runat="server"></asp:TextBox><br/>
                Surname: <asp:TextBox ID="ContactSurname" runat="server"></asp:TextBox><br/>
                <asp:Button ID="SaveDataButton" runat="server" Text="Save" OnClick="SaveDataClick" />
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
