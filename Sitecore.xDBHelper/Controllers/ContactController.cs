using Sitecore.Analytics;
using Sitecore.Analytics.Model.Entities;
using Sitecore.xDBHelper.Models;
using System.Web.Mvc;

namespace Sitecore.xDBHelper.Controllers
{
  public class ContactController : Controller
  {
    // GET: Contact
    [HttpGet]
    public ActionResult Index()
    {
      var currentContact = Tracker.Current.Contact;
      var personalInfo = currentContact.GetFacet<IContactPersonalInfo>("Personal");
      var model = new ContactData()
      {
        Identificator = currentContact.Identifiers.Identifier,
        FirstName = personalInfo.FirstName,
        LastName = personalInfo.Surname,
        Birthday = personalInfo.BirthDate,
        Gender = personalInfo.Gender
      };

      return View(model);
    }

    [HttpPost]
    public ActionResult Index(ContactData data)
    {
      //
      if (!string.IsNullOrEmpty(data.Identificator))
      {
        Tracker.Current.Session.Identify(data.Identificator);
      }

      var personalInfo = Tracker.Current.Contact.GetFacet<IContactPersonalInfo>("Personal");
      personalInfo.FirstName = data.FirstName;
      personalInfo.Surname = data.LastName;
      personalInfo.Gender = data.Gender;
      personalInfo.BirthDate = data.Birthday;

      return RedirectToAction("Index");
    }

    public ActionResult Abandon()
    {
      Tracker.Current.EndTracking();
      Session.Abandon();
      return RedirectToAction("Index");
    }
  }
}