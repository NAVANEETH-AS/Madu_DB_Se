using System;
using System.Web.Services;
using System.Data;
using System.Net;

/// <summary>
/// Summary description for Service3
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service3 : System.Web.Services.WebService
{

    madu_dbcon.Service3 sercon1 = new madu_dbcon.Service3();

    public Service3()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    /////////////////////////////LOGIN/////////////////////////////////
    //
  
    [WebMethod]
    public string encypt_db(string passw)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.encypt(passw);
    }

    [WebMethod]
    public string login_db(string usrid, string passwd)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.login(usrid, passwd);
    }
    [WebMethod]
    public DataTable madu_load_db(string n, string val)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.madu_load(n, val);
    }
    [WebMethod]
    public DataSet UserLoginSessions_db(string Username, string Password, string SessionId, string HostName, string IpAddress, string MacId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.UserLoginSessions(Username, Password, SessionId, HostName, IpAddress, MacId);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Category_insert_db(int COMPID, string Cteglist, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_insert(COMPID, Cteglist, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Category_Image_Update_db(string contentname, int MenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Image_Update(contentname, MenuID);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Higher_Education_Category_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Select();
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Sub_Category_insert_db(int COMPID, string Cteglist, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Sub_Category_insert(COMPID, Cteglist, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_univeristies_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_univeristies_Select();
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_institution_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_institution_Select();
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Higher_Education_Course_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Select();
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_CatandSub_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_CatandSub_Select();
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Higher_Education_Course_Apply_db(int CompID, string EMPCOD, int HighCourseID, int HighBatchID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Apply(CompID, EMPCOD, HighCourseID, HighBatchID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Cancel_db(int CompID, string EMPCOD, int HighCourseID, int HighBatchID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Cancel(CompID, EMPCOD, HighCourseID, HighBatchID);
        return Dts;
    }

    [WebMethod]
    public string insert_custom_app_details_db(int comp_id, string course_name, string username, string empcode, string designation, string department,
       int action, string university, int edutype, string Institution, string Duration, string ApproximateFee, string Remarks)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.insert_custom_app_details(comp_id, course_name, username, empcode, designation, department, action, university, edutype, Institution, Duration, ApproximateFee, Remarks);

    }
    [WebMethod]
    public DataTable GET_HIGH_EDU_UNIVERSITY_db(int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_UNIVERSITY(CompID);
    }

    [WebMethod]
    public DataTable GET_HIGH_EDU_CATEGORY_SUBCAT_db(int CompID, int CategoryID, int Type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_CATEGORY_SUBCAT(CompID, CategoryID, Type);
    }

    [WebMethod]
    public string INSERT_HIGHR_EDU_COURSE_db(int CompID, string Course_Name, string Course_Duration, int CategoryID, int StreamID, int UniversityID, string Eligibility, string Link, string CourseFormat, string Description, string Lastdatetoapply, string CreatedBy, string CoverImage, int Action)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.INSERT_HIGHR_EDU_COURSE(CompID, Course_Name, Course_Duration, CategoryID, StreamID, UniversityID, Eligibility, Link, CourseFormat, Description, Lastdatetoapply, CreatedBy, CoverImage, Action);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_view_Related_Select_db(int HighCourseID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_view_Related_Select(HighCourseID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Applied_Select_db(int COMPID, string USERID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Applied_Select(COMPID, USERID);
        return Dts;
    }
    [WebMethod]
    public DataSet GET_HIGH_EDU_COURSES_USER_db(int CompID, int Category, int SubCategory, int Offsetrow, int PageNo)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_COURSES_USER(CompID, Category, SubCategory, Offsetrow, PageNo);
    }
    //J-03-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Category_Select_All_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Select_All();
        return Dts;
    }
    [WebMethod]
    public DataSet GET_HIGH_EDU_COURSES_USER_UNI_db(int CompID, int Category, int SubCategory, int Offsetrow, int PageNo)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_COURSES_USER_UNI(CompID, Category, SubCategory, Offsetrow, PageNo);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_view_Select_db(int HighCourseID, string UsrID, int HighBatchID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_view_Select(HighCourseID, UsrID, HighBatchID);
        return Dts;
    }
    //J-04-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Category_Select_Delete_db(string CatID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Select_Delete(CatID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Category_Select_ByCat_All_db(int CatID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Select_ByCat_All(CatID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Category_Update_db(int COMPID, string Cteglist, string UserID, string CatID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Category_Update(COMPID, Cteglist, UserID, CatID);
        return Dts;
    }

    [WebMethod]
    public DataTable GET_HIGH_EDU_COURSE_APPLICATION_db(int CompID, int Status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_COURSE_APPLICATION(CompID, Status);
    }
    [WebMethod]
    public string UPDATE_HIGHR_EDU_COURSE_db(int CompID, string Course_Name, string Course_Duration, int CategoryID, int StreamID, int UniversityID, string Eligibility, string Link, string CourseFormat, string Description, string Lastdatetoapply, string CreatedBy, string CoverImage, int CourseID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.UPDATE_HIGHR_EDU_COURSE(CompID, Course_Name, Course_Duration, CategoryID, StreamID, UniversityID, Eligibility, Link, CourseFormat, Description, Lastdatetoapply, CreatedBy, CoverImage, CourseID);
    }
    [WebMethod]
    public DataTable GET_HIGH_EDU_COURSES_BYID_db(int CompID, int CourseID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_COURSES_BYID(CompID, CourseID);
    }
    [WebMethod]
    public string DELETE_HIGH_EDU_COURSES_DB(int CompID, int CourseID, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.DELETE_HIGH_EDU_COURSES(CompID, CourseID, ModifiedBy);
    }
    [WebMethod]
    public DataTable GET_HIGH_EDU_COURSES_db(int CompID, int Status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GET_HIGH_EDU_COURSES(CompID, Status);
    }
    [WebMethod]
    public string insert_university_details_db(int comp_id, string university_name, int type, string web_link, string created_by, int action,
      string university_img, int univ_id, int priority)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.insert_university_details(comp_id, university_name, type, web_link, created_by, action, university_img, univ_id, priority);

    }
    [WebMethod]
    public DataTable fetch_higher_education_details_db(int CompID, int P_type, int university_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon1.fetch_higher_education_details(CompID, P_type, university_id);
        return dts;
    }
    //J-05-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_SubCategory_Select_Delete_db(string CatID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_SubCategory_Select_Delete(CatID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_CatandSub_View_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_CatandSub_View_Select();
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_CatandSub_View_Select_ADMIN_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_CatandSub_View_Select_ADMIN();
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Higher_Education_SubCategory_Select_db(string CatID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_SubCategory_Select(CatID);
        return Dts;
    }
    //J-06-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Nationaluniveristies_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Nationaluniveristies_Select();
        return Dts;
    }
    //J-10-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Count_Setting_insert_db(string CoursesC, string LearnersC, string UniversitiesC, string InstitutionsC, string NationalUniversitiesC, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Count_Setting_insert(CoursesC, LearnersC, UniversitiesC, InstitutionsC, NationalUniversitiesC, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Count_Select_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Count_Select();
        return Dts;
    }
    //J-12-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Employee_Select_All_db(string EMPCODE)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Employee_Select_All(EMPCODE);
        return Dts;
    }
    //J-13-08-2021
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Rating_db(int CompID, string EMPCODE, int HighCourseID, string Rateval, string RateFeed)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Rating(CompID, EMPCODE, HighCourseID, Rateval, RateFeed);
        return Dts;
    }
    //J-16-08-2021

    [WebMethod]
    public DataTable Get_Higher_Education_Course_Rate_view_Select_db(int HighCourseID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Rate_view_Select(HighCourseID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Select_startedAdmission_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Select_startedAdmission();
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_insert_db(string Txtcertificatename, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Certificate_insert(Txtcertificatename, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_List_db(int Cert_ID, int Comp_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Certificate_List(Cert_ID, Comp_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_Manage_db(int Cert_ID, int Manage_type, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Certificate_Manage(Cert_ID, Manage_type, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Employee_ByID_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Employee_ByID(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_High_Edu_Custom_Application_List_db(int CompID, int Status, string fromdate, string Todate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_High_Edu_Custom_Application_List(CompID, Status, fromdate, Todate);
    }
    [WebMethod]
    public DataTable Preview_Individual_Exam_Report_Details_db(string CompID, string EMPCODE)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Preview_Individual_Exam_Report_Details(CompID, EMPCODE);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Higher_Education_Menus_db(string EmpCode, string EmpRoleId, string EmpUsername, string CompCode, string ParentId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Menus(EmpCode, EmpRoleId, EmpUsername, CompCode, ParentId);
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Certificate_Update_db(string Txtcertificatename, int Comp_ID, string UserID, string Cert_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Certificate_Update(Txtcertificatename, Comp_ID, UserID, Cert_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Qualification_List_db(int Quali_ID, int Comp_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Qualification_List(Quali_ID, Comp_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Qualification_insert_db(string TxtQualificationname, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Qualification_insert(TxtQualificationname, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Qualification_Manage_db(int Quali_ID, int Manage_type, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Qualification_Manage(Quali_ID, Manage_type, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Qualification_Update_db(string Qualificationname, int Comp_ID, string UserID, string Quali_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Qualification_Update(Qualificationname, Comp_ID, UserID, Quali_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Course_Detail_db(int comp_id, string UniveristyID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Set_Higher_Education_Course_Detail(comp_id, UniveristyID);
    }

    [WebMethod]
    public DataTable Get_Higher_Education_Syllabus_Insert_db(string contentname, string UniverityID, string Course_ID, string str_File, string CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Get_Higher_Education_Syllabus_Insert(contentname, UniverityID, Course_ID, str_File, CompID);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Syllabus_Table_Detail_db(int CompID, int p_Type, int p_SyllabusID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Get_Higher_Education_Syllabus_Table_Detail(CompID, p_Type, p_SyllabusID);
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Syllabus_Manage_db(int Syllabus_ID, int Manage_type, int Comp_ID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Set_Higher_Education_Syllabus_Manage(Syllabus_ID, Manage_type, Comp_ID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Syllabus_Update_db(string contentname, string EditedID, string str_File, string CompID, int TypeID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Get_Higher_Education_Syllabus_Update(contentname, EditedID, str_File, CompID, TypeID);
    }

    [WebMethod]
    public DataTable higher_University_fetch_by_Type_db(int Universitytype, string UserID, int Comp_ID, int Manage_Type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.higher_University_fetch_by_Type(Universitytype, UserID, Comp_ID, Manage_Type);
    }

    [WebMethod]
    public DataTable higher_University_fetch_by_Type1_db(int Universitytype, string UserID, int Comp_ID, int Manage_Type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Higher_University_fetch_by_type1(Universitytype, UserID, Comp_ID, Manage_Type);
    }
    [WebMethod]
    public DataTable higher_University_fetch_all_db(int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.higher_University_fetch_all(Comp_ID);
    }
    [WebMethod]
    public string HIG_EDU_INST_SAVE_DB(int P_inst_id, string P_Inst_name, string P_inst_Address, int P_Uni_id, int P_Inst_nature, int P_comp_id, string P_created_by)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_INST_SAVE(P_inst_id, P_Inst_name, P_inst_Address, P_Uni_id, P_Inst_nature, P_comp_id, P_created_by);



    }
    [WebMethod]
    public DataTable HIG_EDU_INSTITUSION_SELECT_DB(int Comp_ID, int P_Inst_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_INSTITUSION_SELECT(Comp_ID, P_Inst_id);
    }
    [WebMethod]
    public string HIG_EDU_INSTITUSION_DELETE_DB(int P_inst_id, int P_comp_id, string P_created_by)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_INSTITUSION_DELETE(P_inst_id, P_comp_id, P_created_by);



    }
    [WebMethod]
    public DataTable HIG_EDU_UNI_BSD_INS_DB(int University_type, int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.HIG_EDU_UNI_BSD_INS(University_type, Comp_ID);
    }
    [WebMethod]
    public DataTable HIG_EDU_CRS_BY_INST_DB(int Inst_Type, int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.HIG_EDU_CRS_BY_INST(Inst_Type, Comp_ID);
    }
    [WebMethod]
    public DataTable HIG_EDU_STREAM_BY_CRS_DB(int CrsID, int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.HIG_EDU_STREAM_BY_CRS(CrsID, Comp_ID);
    }
    [WebMethod]
    public DataTable Set_Higher_Education_Course_Qualification_List_db(int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.Set_Higher_Education_Course_Qualification_List(Comp_ID);
    }
    [WebMethod]
    public string HIG_EDU_TRAINING_CREATE_UPDATE_DB(int P_Training_id, int P_nomination_type, int P_edu_type, int P_UNIVERSITY_TYPE, int P_university_id, int P_learning_type, int P_institusion_id, int P_course_id, int P_stream_id, int P_qualification_id, int P_gender, int P_age_limit_min, int P_age_limit_max, string P_created_by, int P_comp_id, string P_Certificate, int P_CategoryID, int P_SubCategoryID,string Descrp)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_TRAINING_CREATE_UPDATE(P_Training_id, P_nomination_type, P_edu_type, P_UNIVERSITY_TYPE, P_university_id, P_learning_type, P_institusion_id, P_course_id, P_stream_id, P_qualification_id, P_gender, P_age_limit_min, P_age_limit_max, P_created_by, P_comp_id, P_Certificate, P_CategoryID, P_SubCategoryID, Descrp);



    }
    [WebMethod]
    public string HIG_EDU_Batch_CREATE_UPDATE_DB(int P_Training_id, int P_Batch_ID, string P_Batch_name, string P_Start_date, string P_End_date, string P_last_date, int P_Duration_day, int P_Duration_mon, int P_Duration_YYYY, int P_bond_id, int P_Application_id, int P_approximate_fee, int P_syllabus_id, int P_sem_yyyy, int No_sem_yyyy, int P_Payment_type, int P_No_installment, string P_created_by, int P_comp_id, int No_paper)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_Batch_CREATE_UPDATE(P_Training_id, P_Batch_ID, P_Batch_name, P_Start_date, P_End_date, P_last_date, P_Duration_day, P_Duration_mon, P_Duration_YYYY, P_bond_id, P_Application_id, P_approximate_fee, P_syllabus_id, P_sem_yyyy, No_sem_yyyy, P_Payment_type, P_No_installment, P_created_by, P_comp_id, No_paper);



    }

    [WebMethod]
    public DataTable Higher_Education_Applic_frm_list_fetch_db(int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Education_Applic_frm_list_fetch(comp_id);
    }
    [WebMethod]
    public DataTable higher_Course_details_bind_db(int Training_ID, int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_Course_details_bind(Training_ID, comp_id);
    }
    [WebMethod]
    public DataTable higher_Syllabus_details_bind_db(int Crs_ID, int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_Syllabus_details_bind(Crs_ID, comp_id);
    }

    [WebMethod]
    public DataTable higher_Course_TrngBatch_details_bind_db(int Training_ID, int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_Course_TrngBatch_details_bind(Training_ID, comp_id);
    }
    [WebMethod]
    public DataSet higher_train_det_fetch_db(int comp_id, int page_no, string srch_txt)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.higher_train_det_fetch(comp_id, page_no, srch_txt);
    }





    [WebMethod]
    public DataTable train_batch_see_db(int comp_id, int training_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.train_batch_see(comp_id, training_id);
    }



    [WebMethod]
    public string higher_course_batch_delete_db(int comp_id, int training_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_course_batch_delete(comp_id, training_id);
    }

    [WebMethod]
    public DataTable HIG_EDU_SUB_BATCH_LIST_DB(int p_training_id, int P_Batch_id, int p_comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.HIG_EDU_SUB_BATCH_LIST(p_training_id, P_Batch_id, p_comp_id);
    }
    [WebMethod]
    public string HIG_EDU_Sub_batch_save_db(int P_Training_id, int P_Batch_ID, string P_Sub_batch_id, string P_Selection, int P_comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_Sub_batch_save(P_Training_id, P_Batch_ID, P_Sub_batch_id, P_Selection, P_comp_id);
    }
    [WebMethod]
    public DataTable HIG_EDU_BATCH_FEES_DB(int P_Training_id, int P_Batch_id, int P_comp_id, int P_sub_batch_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.HIG_EDU_BATCH_FEES(P_Training_id, P_Batch_id, P_comp_id, P_sub_batch_id);
    }
    [WebMethod]
    public DataTable HIG_EDU_FEES_DETAILS_DB(int P_comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.HIG_EDU_FEES_DETAILS(P_comp_id);
    }

    [WebMethod]
    public string HIG_EDU_Fee_details_save_db(int P_Training_id, int P_Batch_ID, string P_Fee_id, string P_Amount, int P_comp_id, int P_Group_id, int Sub_Batch_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_Fee_details_save(P_Training_id, P_Batch_ID, P_Fee_id, P_Amount, P_comp_id, P_Group_id, Sub_Batch_id);



    }
    [WebMethod]
    public DataTable HIG_EDU_BATCH_FEES_details_db(int P_group_id, int P_Training_id, int P_Batch_id, int P_comp_id, int P_sub_batch_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.HIG_EDU_BATCH_FEES_details(P_group_id, P_Training_id, P_Batch_id, P_comp_id, P_sub_batch_id);
    }
    [WebMethod]
    public DataTable PROC_MADU_HIGHER_EXCEL_AUDIENCE_UPLOAD_DB(string P_USER_ID, string P_COMP_ID, int P_TRAINING_ID, int P_BATCH_ID, int P_SUB_BATCH_ID, string P_UPLOADED_BY, string P_COMPLETION_STATUS, string P_RESULT_STATUS, string P_TOTAL_NO_PAPER, string P_COMP_PAPER, string TOTALMARKSCORED, string TOTALMAXIMUMMARK, string P_COMPLETION_DATE, string P_RESULT_UPDATED_DATE)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.PROC_MADU_HIGHER_EXCEL_AUDIENCE_UPLOAD(P_USER_ID, P_COMP_ID, P_TRAINING_ID, P_BATCH_ID, P_SUB_BATCH_ID, P_UPLOADED_BY, P_COMPLETION_STATUS, P_RESULT_STATUS, P_TOTAL_NO_PAPER, P_COMP_PAPER, TOTALMARKSCORED, TOTALMAXIMUMMARK, P_COMPLETION_DATE, P_RESULT_UPDATED_DATE);
    }
    [WebMethod]
    public DataTable PROC_MADU_HIGHER_EXCEL_AUDIENCE_SELECT_DB(int P_TRAINING_ID, int P_BATCH_ID, int P_SUB_BATCH_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.PROC_MADU_HIGHER_EXCEL_AUDIENCE_SELECT(P_TRAINING_ID, P_BATCH_ID, P_SUB_BATCH_ID);
    }
    [WebMethod]
    public DataTable PROC_MADU_HIGHER_EXCEL_AUDIENCE_DELETE_DB(string strDelte)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.PROC_MADU_HIGHER_EXCEL_AUDIENCE_DELETE(strDelte);
    }
    [WebMethod]
    public DataTable HIG_EDU_Penalty_details_db(int P_Training_id, int P_Batch_id, int P_comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.HIG_EDU_Penalty_details(P_Training_id, P_Batch_id, P_comp_id);
    }
    [WebMethod]
    public string HIG_EDU_Penalty_Update_db(int P_Training_id, int P_Batch_ID, int Incheck, int Cocheck, int Ppcheck, int Pen_incomp, string From_days_str, string To_days_str, string Per_days_str, string From_Paper_str, string To_Paper_str, string Per_Paper_str, int P_comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_Penalty_Update(P_Training_id, P_Batch_ID, Incheck, Cocheck, Ppcheck, Pen_incomp, From_days_str, To_days_str, Per_days_str, From_Paper_str, To_Paper_str, Per_Paper_str, P_comp_id);

    }
    [WebMethod]
    public DataTable higher_individual_report_db(string user_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_individual_report(user_id);
    }
    [WebMethod]
    public DataTable higher_batch_report_db(int TRAINING_ID, int BATCH_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_batch_report(TRAINING_ID, BATCH_ID);
    }
    [WebMethod]
    public DataTable HIGHER_CRS_USER_DETAILS_DB(int P_TRAINING_ID, int P_BATCH_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_CRS_USER_DETAILS(P_TRAINING_ID, P_BATCH_ID);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Certificate_view_Select_db(int P_BATCH_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Course_Certificate_view_Select(P_BATCH_ID);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Application_Document_Upload_db(int CertificateID, int EditedID, string userid, string DocName)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Application_Document_Upload(CertificateID, EditedID, userid, DocName);
    }
    [WebMethod]
    public DataTable HIGHER_APPLICATION_STATUS_db(int P_APP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_STATUS(P_APP_ID);
    }
    [WebMethod]
    public DataTable HIGHER_APPLICATION_Document_view_db(int P_APP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_Document_view(P_APP_ID);
    }
    [WebMethod]
    public int HIGHER_APPLICATION_USER_Document_Submit_db(int P_APP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_USER_Document_Submit(P_APP_ID);
    }
    [WebMethod]
    public DataTable HIGHER_ID_CARD_FETCH_DB(int P_APP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_ID_CARD_FETCH(P_APP_ID);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Discontinue_db(string Rasonforleaving, int ApplicationID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Discontinue(Rasonforleaving, ApplicationID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Course_ListDetails_Select_db(int COMPID, string USERID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_ListDetails_Select(COMPID, USERID);
        return Dts;
    }
    [WebMethod]
    public int HIGHER_APPLICATION_USER_Certificate_Submit_db(int P_APP_ID, int P_STATUS)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_USER_Certificate_Submit(P_APP_ID, P_STATUS);
    }
    //university type fetch//
    [WebMethod]
    public DataTable higher_uni_type_fetch_db(string created_by, int comp_id)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.higher_uni_type_fetch(created_by, comp_id);
    }

    //university//insert//

    [WebMethod]
    public string Higher_edu_university_insert_db(string uni_type_name, string user_id, int comany_id, int uni_type, string UniImage)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_university_insert(uni_type_name, user_id, comany_id, uni_type, UniImage);
    }

    //university//detail//fetch//


    [WebMethod]
    public DataSet higher_uni_details_fetch_db(string created_by, int comp_id, int page_no, string search_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_uni_detail_fetch(created_by, comp_id, page_no, search_txt);
    }

    //university//edit//fetch//

    [WebMethod]
    public DataTable higher_uni_edit_fetch_db(string created_by, int comp_id, int uni_type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_uni_edit_fetch(created_by, comp_id, uni_type);
    }

    //university//delete///



    [WebMethod]
    public string higher_uni__delete_db(string created_by, int comp_id, int uni_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_uni__delete(created_by, comp_id, uni_id);
    }

    //university//edit//

    [WebMethod]
    public string higher_uni__edit_db(string created_by, int comp_id, int uni_id, string uni_name, int uni_type_id, string uniimage)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_uni__edit(created_by, comp_id, uni_id, uni_name, uni_type_id, uniimage);
    }


    //university//full fetch//

    [WebMethod]
    public DataTable higher_uni_full_fetch_db(string created_by, int comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.higher_uni_full_fetch(created_by, comp_id);
    }

    //course//insert//

    [WebMethod]
    public string Higher_edu_course_insert_db(string course_name, string user_id, int comany_id, int uni_id, int ins_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_course_insert(course_name, user_id, comany_id, uni_id, ins_id);
    }


    //course//detail//fetch//


    [WebMethod]
    public DataSet higher_course_detail_fetch_db(string created_by, int comp_id, int page_no, string search_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_course_detail_fetch(created_by, comp_id, page_no, search_txt);
    }


    //course//delete//

    [WebMethod]
    public string higher_course__delete_db(string created_by, int comp_id, int uni_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_course__delete(created_by, comp_id, uni_id);
    }

    //course//edit//fetch//

    [WebMethod]
    public DataTable higher_course_edit_fetch_db(string created_by, int comp_id, int course_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_course_edit_fetch(created_by, comp_id, course_id);
    }

    //course//edit//

    [WebMethod]
    public string higher_course__edit_db(string created_by, int comp_id, int course_id, string course_name, int uni_id, int instid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_course__edit(created_by, comp_id, course_id, course_name, uni_id, instid);
    }
    [WebMethod]
    public DataTable HIGHER_APPLICATION_DETAILS_DB(int P_TRAINING_ID, int P_BATCH_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_DETAILS(P_TRAINING_ID, P_BATCH_ID);
    }
    [WebMethod]
    public string APPROVEORREJECT_HIGH_EDU_APPLICATION_DB(int CompID, string ApplicationID, int Status, string ModifiedBy, string P_Comment)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.APPROVEORREJECT_HIGH_EDU_APPLICATION(CompID, ApplicationID, Status, ModifiedBy, P_Comment);
    }
    [WebMethod]
    public DataTable Get_Higher_Education_Application_IDCard_Upload_db(int CertificateID, int EditedID, string userid, string DocName)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Application_IDCard_Upload(CertificateID, EditedID, userid, DocName);
    }




    ////////////////////////
    ///
    [WebMethod]
    public DataTable higher_stream_full_fetch_db(string created_by, int comp_id, int course_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_stream_full_fetch(created_by, comp_id, course_id);
    }



    //full//course//fetch//

    [WebMethod]
    public DataTable Heigher_edu_course__mstr_dtls_fetch_db(int Compap_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Heigher_edu_course__mstr_dtls_fetch(Compap_Id);
    }
    //course//detail//fetch//





    //bond master//insert//

    [WebMethod]
    public DataTable Higher_edu_bond_insert_db(string bond_name, string bond_file, string user_id, int comany_id, int course_id, int stream_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_bond_insert(bond_name, bond_file, user_id, comany_id, course_id, stream_id);
    }


    ///bond//details//fetch//



    [WebMethod]
    public DataSet higher_bond_detail_fetch_db(int comp_id, int course_id, int stream_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_bond_detail_fetch(comp_id, course_id, stream_id);
    }


    //bond//details//binding//

    [WebMethod]
    public DataSet higher_bond_detail_bind_db(int comp_id, int page_no, string search_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_bond_detail_bind(comp_id, page_no, search_txt);
    }

    //bond//delete///

    [WebMethod]
    public string higher_bond_delete_db(int comp_id, int bond_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_bond_delete(comp_id, bond_id);
    }

    //bond//edit//fetch//

    [WebMethod]
    public DataTable higher_bond_edit_fetch_db(int comp_id, int bond_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_bond_edit_fetch(comp_id, bond_id);
    }

    //bond//edit//

    [WebMethod]
    public DataTable Higher_edu_bond_edit_db(int bond_id, string bond_name, string bond_file, string user_id, int comp_id, int course_id, int stream_id, int type_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_bond_edit(bond_id, bond_name, bond_file, user_id, comp_id, course_id, stream_id, type_id);
    }

    [WebMethod]
    public DataTable Higher_edu_applic_frm_fetch_all_db(int comp_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Education_Applic_frm_list_fetch(comp_Id);
    }
    [WebMethod]
    public string Higher_edu_application_frm_del_db(string user_id, int Comp_ID, int Applic_frmId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Education_application_frm_delete(user_id, Comp_ID, Applic_frmId);
    }
    [WebMethod]
    public DataTable Higher_Education_application_frm_edit_fetch_db(int applic_frm_Id, string userId, int comp_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Education_Applic_frm_edit_fetch(applic_frm_Id, userId, comp_Id);
    }
    [WebMethod]
    public DataTable Higher_Education_application_frm_edit_db(string userId, int compID, int applica_frm_Id, int courseId, string appfrm_name, string app_filename, int type_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Education_application_frm_edit(userId, compID, applica_frm_Id, courseId, appfrm_name, app_filename, type_ID);
    }
    [WebMethod]
    public DataTable Higher_education_admission_from_insert_db(int course_Id, string admis_frm_name, string admis_file_name, string usr_Id, int comp_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Educ_Admission_form_master_insert(course_Id, admis_frm_name, admis_file_name, usr_Id, comp_Id);
    }
    [WebMethod]
    public string Higher_edu_course_stream_insert_db(string stream_name, int course_id, string UserId, int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_Edu_stream_insert(stream_name, course_id, UserId, comp_id);
    }
    [WebMethod]
    public DataTable Higher_edu_course_strem_fetch_db(string user_ID, int Compap_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Heigher_edu_course_stream_mstr_fetch(user_ID, Compap_Id);
    }
    [WebMethod]
    public string Higher_edu_course_stream_delete_db(string user_id, int comany_id, int stream_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_course_stream_del(user_id, comany_id, stream_id);
    }
    [WebMethod]
    public DataTable Higher_edu_course_edit_strem_fetch_db(int Stream_Id, string user_ID, int Compap_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Heigher_edu_course_stream_edit_fetch(Stream_Id, user_ID, Compap_Id);
    }
    [WebMethod]
    public string Higher_edu_course_stream_edit_db(string user_id, int comany_id, int strem_Id, int course_id, string stream_name)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Higher_edu_course_stream_edit(user_id, comany_id, strem_Id, course_id, stream_name);
    }
    [WebMethod]
    public string Get_Higher_Education_Course_Image_Update_db(string course_name, int uni_idu, int uni_d, int ins_d, string str_File)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Course_Image_Update(course_name, uni_idu, uni_d, ins_d, str_File);
    }
    [WebMethod]
    public DataTable train_batch_Edit_details_db(int CompID, int BatchID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.train_batch_Edit_details(CompID, BatchID);
    }
    [WebMethod]
    public string HIG_EDU_Batch_Delete_DB(int P_Batch_id, string P_UserID, int P_Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIG_EDU_Batch_Delete(P_Batch_id, P_UserID, P_Comp_ID);
    }
    [WebMethod]
    public DataTable HIGHER_EXECUTIVEAPPLICATION_DETAILS_DB(int P_TRAINING_ID, int P_BATCH_ID,string User_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_EXECUTIVEAPPLICATION_DETAILS(P_TRAINING_ID, P_BATCH_ID, User_ID);
    }
    [WebMethod]
    public DataTable HIGHER_APPLICATION_USER_EXECU_Submit_db(string EXStartDate, string EXEndDate, string EXMaxMark, string EXObtainedMark, string EXTotalPapers, string EXCompletedPapers, string Coursecompyes, string passstatus,string ModifiedBy,string User_ID,int training_id,int Batch_id,int Sub_Batch_id,string Status,string Command)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_APPLICATION_USER_EXECU_Submit(EXStartDate, EXEndDate, EXMaxMark, EXObtainedMark, EXTotalPapers, EXCompletedPapers, Coursecompyes, passstatus, ModifiedBy, User_ID, training_id, Batch_id, Sub_Batch_id, Status, Command);
    }
    [WebMethod]
    public DataTable PROC_MADU_HIGHER_EXCEL_AUDIENCE_EXECUTIVE_UPLOAD_DB(string P_USER_ID, string P_COMP_ID, int P_TRAINING_ID, int P_BATCH_ID, int P_SUB_BATCH_ID, string P_UPLOADED_BY, string P_COMPLETION_STATUS, string P_RESULT_STATUS, string P_TOTAL_NO_PAPER, string P_COMP_PAPER, string TOTALMARKSCORED, string TOTALMAXIMUMMARK, string P_COMPLETION_DATE, string P_RESULT_UPDATED_DATE,string COURSESTARTDATE, string COURSEENDDATE, string CERTIFICATECOMP)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.PROC_MADU_HIGHER_EXCEL_AUDIENCE_EXECUTIVE_UPLOAD(P_USER_ID, P_COMP_ID, P_TRAINING_ID, P_BATCH_ID, P_SUB_BATCH_ID, P_UPLOADED_BY, P_COMPLETION_STATUS, P_RESULT_STATUS, P_TOTAL_NO_PAPER, P_COMP_PAPER, TOTALMARKSCORED, TOTALMAXIMUMMARK, P_COMPLETION_DATE, P_RESULT_UPDATED_DATE, COURSESTARTDATE, COURSEENDDATE, CERTIFICATECOMP);
    }
    [WebMethod]
    public DataTable higher_Firm_report_db(int CmpID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_Firm_report(CmpID);
    }
    [WebMethod]
    public DataTable higher_datewise_report_db(string Fromdate,string Todate)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_datewise_report(Fromdate, Todate);
    }
    [WebMethod]
    public DataTable higher_education_Course_Details_db(int CompID, int Edutype)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_Details(CompID, Edutype);
    }
    [WebMethod]
    public DataTable higher_Coursewise_report_db(int Edutype,int Coursedet)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_Coursewise_report(Edutype, Coursedet);
    }
    [WebMethod]
    public DataTable higher_education_Course_batch_Details_db(int CompID, int Edutype,int Courddet)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_batch_Details(CompID, Edutype, Courddet);
    }
    [WebMethod]
    public DataTable higher_education_Course_Summary_Details_db(int CompID, int Edutype, int Courddet,int btchdet,int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_Summary_Details(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_donut_Details_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_donut_Details(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_percentage_Details_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_percentage_Details(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_Company_Details_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_Company_Details(CompID, Edutype, Courddet, btchdet, compid);
    }

    ///NEW
    [WebMethod]
    public DataTable Get_Higher_Education_Voucher_Document_Upload_db(string userid, int CompId, string Remarks, int course_id, string VoucherNumber,string str_File)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Higher_Education_Voucher_Document_Upload(userid, CompId, Remarks, course_id, VoucherNumber, str_File);
    }
    [WebMethod]
    public DataTable higher_viewCourseVoucherDetailsPenality_db(string userid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_viewCourseVoucherDetailsPenality(userid);
    }
    [WebMethod]
    public DataTable Get_User_Voucher_Details_User_db(int CompID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_User_Voucher_Details_User(CompID);
    }
    [WebMethod]
    public DataTable higher_FeeDetails_Update_db(string UserID, int CompID, int APPID, int Amountval,string CreatedUsrID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_FeeDetails_Update(UserID, CompID, APPID, Amountval, CreatedUsrID);
    }
    [WebMethod]
    public DataTable higher_individual_Paid_History_report_db(string user_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_individual_Paid_History_report(user_id);
    }
    [WebMethod]
    public DataTable higher_FeeDetails_Delete_db(int DeleteID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_FeeDetails_Delete(DeleteID);
    }
    [WebMethod]
    public DataTable higher_education_Course_coursewise_Details_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_coursewise_Details(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_coursewise_Fee_Details_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_coursewise_Fee_Details(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_coursewise_Fee_Details_Update_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_coursewise_Fee_Details_Update(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable higher_education_Course_coursewise_Fee_Details_Budget_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_education_Course_coursewise_Fee_Details_Budget(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable PROC_MADU_HIGHER_VOUCHER_EXCEL_AUDIENCE_UPLOAD_DB(string P_APPLICATIONID,string P_USER_ID, string P_COMP_ID, string P_PAIDAMOUNT, string PENALITY_CHECK,string P_COMAPNY_PAID,string P_PENALITY_PERC,string P_RDAMOUNT)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.PROC_MADU_HIGHER_VOUCHER_EXCEL_AUDIENCE_UPLOAD(P_APPLICATIONID, P_USER_ID, P_COMP_ID, P_PAIDAMOUNT, PENALITY_CHECK, P_COMAPNY_PAID, P_PENALITY_PERC, P_RDAMOUNT);
    }
    [WebMethod]
    public DataTable higher_uni_details_Dashboard_fetch_db(int CompID, int Edutype, int Courddet, int btchdet, int compid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_uni_details_Dashboard_fetch(CompID, Edutype, Courddet, btchdet, compid);
    }
    [WebMethod]
    public DataTable HIGHER_TRANSFER_DETAILS_UPDATE_db(string EmpCode, string Remarksval)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_TRANSFER_DETAILS_UPDATE(EmpCode, Remarksval);
    }
    [WebMethod]
    public DataTable higher_individual_Paid_report_db(string user_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_individual_Paid_report(user_id);
    }
    [WebMethod]
    public DataTable INDIVIDUAL_PAID_REPORT_DB(string P_USER_ID, int P_COMP_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.INDIVIDUAL_PAID_REPORT( P_USER_ID,  P_COMP_ID);
    }
    [WebMethod]
    public string INDIVIDUAL_PAID_UPDATE_db(string P_USER_ID, int P_COMP_ID, int P_PAIDAMOUNT, string P_PAIDDATE, int P_PAIDTYPE, string P_FILE, int P_EDIT_ID) {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.INDIVIDUAL_PAID_UPDATE( P_USER_ID,  P_COMP_ID,  P_PAIDAMOUNT,  P_PAIDDATE,  P_PAIDTYPE,  P_FILE,  P_EDIT_ID);
    }

    [WebMethod]
    public DataTable higher_individual_Paid_Details_db(string user_id,int compID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_individual_Paid_Details(user_id, compID);
    }



    [WebMethod]
    public DataTable HIGHER_EDU_FIRM_RECOVERY_db(int Edutype)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_EDU_FIRM_RECOVERY(Edutype);
    }



    //[WebMethod]
    //public DataTable SELECT_HIGHER_FIRM_RECOVERY_db(int CompID, int Edutype)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon1.SELECT_HIGHER_FIRM_RECOVERY(CompID, Edutype);
    //}

    [WebMethod]
    public DataTable higher_edu_total_candidates_db( int comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_edu_total_candidates(comp_id);
    }

    //higher_edu_total_course-view//

    [WebMethod]
    public DataTable higher_edu_total_course_view_db(int comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_edu_total_course_view(comp_id);
    }


    //high_edu_total_university//


    [WebMethod]
    public DataTable Higher_edu_university_view_db(int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_edu_university_view(comp_id);
    }
    //
    //[WebMethod]
    //public DataTable higher_edu_course_summary_db(int Edutype,int COMPANY_ID, string Cources )
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon1.higher_edu_course_summary(Edutype, COMPANY_ID, Cources);
    //}

    //------

    [WebMethod]
    public DataTable HIGHER_TOTAL_CANDIDATE_VIEW_db(int CompID, int Edutype, int cource_id, int batch_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_TOTAL_CANDIDATE_VIEW(CompID, Edutype, cource_id, batch_id);
    }
    [WebMethod]
    public DataTable HIGHER_TOTAL_COURSE_VIEW_DB(int CompID, int Edutype, int cource_id, int batch_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_TOTAL_COURSE_VIEW(CompID, Edutype, cource_id, batch_id);
    }
    [WebMethod]
    public DataTable HIGHER_TOTAL_CUNIVERSITY_VIEW_DB(int CompID, int Edutype, int cource_id, int batch_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_TOTAL_CUNIVERSITY_VIEW(CompID, Edutype, cource_id, batch_id);
    }
    [WebMethod]
    public DataTable higher_edu_course_summary_db(int Edutype, int COMPANY_ID, string COURSE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_edu_course_summary(Edutype, COMPANY_ID, COURSE);
    }

    [WebMethod]
    public DataTable higher_edu_course_summary_admin_db(int Edutype,int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.higher_edu_course_summary_admin(Edutype, CompID);
    }


    [WebMethod]
    public DataTable SELECT_HIGHER_FIRM_RECOVERY_db(int CompID, int Edutype)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.SELECT_HIGHER_FIRM_RECOVERY(CompID, Edutype);
    }


    //employee transfer-Data Migration-Start
    [WebMethod]
    public string HIGHER_EMPLOYEE_FIRMTRANSFER_db(string USER_ID_OLD, string USER_ID_NEW, int COMP_ID, int OLD_COMP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.HIGHER_EMPLOYEE_FIRMTRANSFER(USER_ID_OLD, USER_ID_NEW, COMP_ID, OLD_COMP_ID);
    }

    //employee transfer-Data Migration-End

}
