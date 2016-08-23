using Sitecore.Shell.Framework.Commands;
using Sitecore.Web.UI.Sheer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.LiveChat.Commands
{
    public class OpenLiveChat : Command
    {
        public override void Execute(CommandContext context)
        {
            SheerResponse.ShowModalDialog("/sitecore/shell/sitecore/client/Your Apps/LiveChat/LiveChat", "500px", "500px");
        }
    }
}