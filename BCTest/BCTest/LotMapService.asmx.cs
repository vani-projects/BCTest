using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;


namespace BCTest
{
    /// <summary>
    /// Summary description for LotMapService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LotMapService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public List<Lot> GetLots()
        {
            
            using(var db = new LotMapDataContext())
            {
                var query = from l in db.Lots
                            select l;

                if(query != null)
                {
                    return query.ToList();
                }
                
            }

            return null;
        }
    }
}
