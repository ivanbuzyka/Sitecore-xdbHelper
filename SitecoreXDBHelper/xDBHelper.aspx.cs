using System;
using System.Web.UI;
using Sitecore.Analytics;
using Sitecore.Analytics.Model.Entities;

namespace SitecoreXDBHelper
{
    public partial class xDBHelper : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Tracker.Current.IsActive)
            {
                InfoBox.Text = "TRACKER IS NOT ACTIVE!";
            }

            InteractionLabel.Text = Tracker.Current.Interaction.InteractionId.ToString();
            ContactLabel.Text = Tracker.Current.Contact.ContactId.ToString();
            var browserInfo = Tracker.Current.Interaction.BrowserInfo;
            BrowserVersionLabel.Text = string.Format("{0} - {1}, {2}", browserInfo.BrowserMajorName,
                browserInfo.BrowserMinorName, browserInfo.BrowserVersion);

            IdentificationLevel.Text = Tracker.Current.Contact.Identifiers.IdentificationLevel.ToString();
            Identifier.Text = Tracker.Current.Contact.Identifiers.Identifier;

            if (!IsPostBack)
            {
                var personalInfo = Tracker.Current.Contact.GetFacet<IContactPersonalInfo>("Personal");
                ContactFirstName.Text = personalInfo.FirstName;
                ContactSurname.Text = personalInfo.Surname;
            }
        }

        protected void SessionAbandonClick(object sender, EventArgs e)
        {
            Session.Abandon();
            InfoBox.Text = "Session abandaned";
        }

        protected void IdentifyClick(object sender, EventArgs e)
        {
            Tracker.Current.Session.Identify(ContactIdentity.Text);

            InfoBox.Text = "Contact identified";
        }

        protected void SaveDataClick(object sender, EventArgs e)
        {
            var personalInfo = Tracker.Current.Contact.GetFacet<IContactPersonalInfo>("Personal");
            personalInfo.FirstName = ContactFirstName.Text;
            personalInfo.Surname = ContactSurname.Text;

            InfoBox.Text = "Contact data saved";
        }
    }
}