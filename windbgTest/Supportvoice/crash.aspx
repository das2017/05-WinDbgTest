<%@ Page Language="C#" debug="false" %>
<script runat="server">

    protected void btnCrash_Click(Object sender, System.EventArgs e)
    {
        Server.Transfer("crash.aspx", true);
    }

</script>
<html>
<head>
</head>
<body>
    <form id="Form1" runat="server" method="POST">
	    <asp:Button id="btnCrash" onclick="btnCrash_Click" runat="server" Text="Crash ASP.NET"></asp:Button>
    </form>
</body>
</html>