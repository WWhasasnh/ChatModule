
namespace Sitecore.Feature.Chat.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class ChatController : Controller
    {
    
        public ActionResult LiveChat()
        {
            Sitecore.Analytics.Data.TrackingField t = new Sitecore.Analytics.Data.TrackingField(Sitecore.Context.Item.Fields["__tracking"]);
            List<Analytics.Data.ContentProfile> profilesList = t.Profiles.ToList();

            foreach (var profile in profilesList)
            {
                foreach (var key in profile.Keys)
                {

                }
            }

            return View();
        }

        public ActionResult GetChatLog()
        {
            string csrName = Sitecore.Context.User.Name;

            MongoOperations objMongoOperations = new MongoOperations();
            List<ChatEntity> liChat = objMongoOperations.GetChatLog();

            liChat = liChat.Where(p => p.From == csrName).ToList();


            return Json(liChat, JsonRequestBehavior.AllowGet);
        }
    }
}