using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sitecore.Analytics;

namespace SitecoreXDBHelper
{
  public partial class xDBHelper : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      InteractionLabel.Text = Tracker.Current.Interaction.InteractionId.ToString();
      ContactLabel.Text = Tracker.Current.Contact.ContactId.ToString();
      var browserInfo = Tracker.Current.Interaction.BrowserInfo;
      BrowserVersionLabel.Text = string.Format("{0} - {1}, {2}", browserInfo.BrowserMajorName,
        browserInfo.BrowserMinorName, browserInfo.BrowserVersion);
    }

    protected void SessionAbandonClick(object sender, EventArgs e)
    {
      Session.Abandon();
    }
  }
}