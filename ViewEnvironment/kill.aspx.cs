using System;

public partial class _Kill : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentEnvironment.KillApp();
    }
}