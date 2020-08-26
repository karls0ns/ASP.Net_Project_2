using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LD3_Service
{
    /// <summary>
    /// Summary description for StringWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class StringWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Edit(string txt)
        {
            string work = txt;
            
            //Lieko tukšumu likvidēšana
            string new_st = "";
            for (int j = 0; j < work.Length; j++)
            {
                if (work.Substring(j, 1) == " ")
                {
                    if (j < work.Length - 1 && work.Substring(j + 1, 1) != " ")
                    {
                        new_st += work.Substring(j, 1);
                    }
                }
                else                    
                {
                    new_st += work.Substring(j, 1);
                }
            }
            work = new_st.Trim();

            //Tukšumu pirms . un , likvidēšana
            new_st = "";
            for (int j = 0; j < work.Length; j++)
            {
                if (work.Substring(j, 1) == " ")
                {
                    if (j < work.Length - 1 && (work.Substring(j + 1, 1) == "," || work.Substring(j + 1, 1) == "."))
                    {
                            
                    }
                    else
                    {
                        new_st += work.Substring(j, 1);
                    }
                }
                else
                {
                    new_st += work.Substring(j, 1);
                }
            }
            work = new_st.Trim();

            //Tukšumu pēc . un , ieviešana
            new_st = "";
            for (int j = 0; j < work.Length; j++)
            {
                if (work.Substring(j, 1) == ","|| work.Substring(j, 1) == ".")
                {
                    if (j < work.Length - 1 && work.Substring(j + 1, 1) != " ")
                    {
                        new_st += work.Substring(j, 1);
                        new_st += " ";
                    }
                    else
                    {
                        new_st += work.Substring(j, 1);
                    }
                }
                else
                {
                    new_st += work.Substring(j, 1);
                }
            }
            work = new_st.Trim();
            return work;            
        }
    }
}
