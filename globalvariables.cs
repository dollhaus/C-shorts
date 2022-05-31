//This is an example of a session class that I use. It simplifies what goes into, and comes out of, the session. It was originally designed for webforms, but can easily be adapted to other frameworks. 


using System;
using System.Web;

namespace project.path.session
{
    [Serializable]
    public class globalvariables
    {

        public globalvariables()
        {
            checkExisting();
        }

        private void save()
        {
            HttpContext.Current.Session["globalvariables"] = this;
        }

        private void checkExisting()
        {
            if (HttpContext.Current.Session["globalvariables"] == null)
            {
                HttpContext.Current.Session["globalvariables"] = this;
            }
            else
            {
                globalvariables variables = (globalvariables)HttpContext.Current.Session["globalvariables"];
                this.SessionString = variables.SessionString

                variables = null;
            }
        }

        string sessionString = "";
        
        public string SessionString { get { return sessionString; } set { sessionString = value; save(); } }
        
        
    }
}
