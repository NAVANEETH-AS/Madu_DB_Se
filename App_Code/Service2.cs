using System;
using System.Web.Services;
using System.Data;
using System.Net;
using System.IO;

/// <summary>
/// Summary description for Service2
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service2 : System.Web.Services.WebService
{
    madu_dbcon.Service2 sercon2 = new madu_dbcon.Service2();
    public Service2()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_insert_db(string Txtcertificatename, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon2.Set_Higher_Education_Certificate_insert(Txtcertificatename, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_List_db(int Cert_ID, int Comp_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon2.Set_Higher_Education_Certificate_List(Cert_ID, Comp_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_Manage_db(int Cert_ID,int Manage_type, int Comp_ID,string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon2.Set_Higher_Education_Certificate_Manage(Cert_ID, Manage_type,Comp_ID, UserID);
        return Dts;
    }
    //hari companywise training dashboard 
    //take company details and sub category --start-

    [WebMethod]
    public DataTable get_company_details_db(int COMPID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon2.get_company_details(COMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable get_training_category_details_db(int COMPID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon2.get_training_category_details(COMPID);
        return Dts;
    }
    //take company details and sub category --end-
}
