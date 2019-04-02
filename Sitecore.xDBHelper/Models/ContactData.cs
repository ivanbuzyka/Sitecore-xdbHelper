using System;

namespace Sitecore.xDBHelper.Models
{
  public class ContactData
  {
    public string Identificator { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Gender { get; set; }

    public DateTime? Birthday { get; set; }
  }
}