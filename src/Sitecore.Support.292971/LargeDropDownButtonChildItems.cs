using Sitecore.Diagnostics;
using Sitecore.ExperienceEditor.Speak.Server.Responses;
using Sitecore.SecurityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.ExperienceEditor.Speak.Ribbon.Requests.LargeDropDownButton
{
  public class LargeDropDownButtonChildItems : Sitecore.ExperienceEditor.Speak.Ribbon.Requests.LargeDropDownButton.LargeDropDownButtonChildItems
  {
    public override PipelineProcessorResponseValue ProcessRequest()
    {
      PipelineProcessorResponseValue chidList;
      using (new SecurityDisabler())
      {
        chidList = base.ProcessRequest();
      }
      return chidList;
    }
  }
}