using System;
using System.Web.Services;
using System.Data;
using System.Net;

/// <summary>
/// Summary description for Service1
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Service1 : System.Web.Services.WebService
{
    madu_dbcon.Service1 sercon1 = new madu_dbcon.Service1();
    madu_dbcon.Service2 sercon2 = new madu_dbcon.Service2();
    public Service1()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    //JITHIN J-29-07-2021
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
    public DataTable Get_Higher_Education_Course_Apply_db(int CompID, string EMPCOD, int HighCourseID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Apply(CompID, EMPCOD, HighCourseID);
        return Dts;
    }
    [WebMethod]
    public string insert_custom_app_details_db(int comp_id, string course_name, string username, string empcode, string designation, string department,
       int action, string university)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.insert_custom_app_details(comp_id, course_name, username, empcode, designation, department, action, university);

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
    public DataTable Get_Higher_Education_Course_view_Select_db(int HighCourseID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_view_Select(HighCourseID, UsrID);
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
    public string APPROVEORREJECT_HIGH_EDU_APPLICATION_DB(int CompID, string ApplicationID, int Status, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.APPROVEORREJECT_HIGH_EDU_APPLICATION(CompID, ApplicationID, Status, ModifiedBy);
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
    //J-03-09-2021
    [WebMethod]
    public DataTable Get_High_Edu_Custom_Application_List_db(int CompID, int Status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_High_Edu_Custom_Application_List(CompID, Status);
    }
    //JITHIN START DIGITAL LIBRARY PART2 J-24-08-2021

    [WebMethod]
    public DataTable SuperAdmin_Specification_insert_db(string CategName, string USERID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.SuperAdmin_Specification_insert(CategName, USERID);
        return Dts;
    }
    
  
    //DIGITAL LIBRARY ADMIN 18-10-2021
    [WebMethod]
    public DataTable Get_Super_admin_specification_db(int TypeV, string usrId)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Super_admin_specification(TypeV, usrId);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_specification_by_companyId_db(int compny_id)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_specification_by_companny_Id(compny_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Super_admin_specification_Selected_db(int TypeV, string usrId)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Super_admin_specification_Selected(TypeV, usrId);
        return Dts;
    }

    [WebMethod]
    public DataTable digital_master_edit_resource_db(int cmpny, int res_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.digital_master_edit_resource(cmpny, res_id);
        return Dts;
    }

    [WebMethod]
    public DataTable insert_spcific_details_db(string specifi_dtl, int compny_id, int resid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.insert_specifi_master(specifi_dtl, compny_id, resid);
        return Dts;
    }

    [WebMethod]
    public int edit_contentdetails_db(string cnt_res_name, string cnt_rate, string cnt_res_code, string cnt_des, /*string cnt_date,*/ string cnt_dur, string cnt_cvr, string cnt_url, string cnt_live, int compID, int cont_resId, int Cattype, int usertype)
    {
        int UpdateStatus = 0;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        UpdateStatus = sercon1.edit_content_details(cnt_res_name, cnt_rate, cnt_res_code, cnt_des,/*cnt_date,*/cnt_dur, cnt_cvr, cnt_url, cnt_live, compID, cont_resId, Cattype, usertype);
        return UpdateStatus;
    }
    [WebMethod]
    public DataTable Get_category_type_db(int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_category_type(cmpid);
        return Dts;
    }
    [WebMethod]

    public string del_specs_db(int spec_id, int comp_id, int resource_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon1.del_specs(spec_id, comp_id, resource_id);
        return msg;
    }
    [WebMethod]



    public DataTable digital_insert_content_db(int cmpny, int menu)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.digital_insert_content(cmpny, menu);
        return Dts;
    }
   
    [WebMethod]
    public DataTable VILT_Today_pop_db(string P_User_id, int P_comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        

        return sercon1.VILT_Today_pop(P_User_id, P_comp_id);
    }
    /////////////////////////////KRA//////////////////////////////////
    [WebMethod]
    public DataTable KRA_MY_TEAM_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_MY_TEAM(UserID, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_HEIRARCHY_LEVEL_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_HEIRARCHY_LEVEL(UserID, Comp_id);
    }



    [WebMethod]
    public DataTable KRA_DROP_DOWN_OPTION_db(int Drop_down, int Comp_id)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_DROP_DOWN_OPTION(Drop_down, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_MY_TASK_db(int Comp_id, string Todate, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_MY_TASK(UserID, Todate, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_MY_Holiday_db(int Comp_id, string Todate, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_MY_Holiday(UserID, Todate, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_MY_Holiday_This_db(int Comp_id, string Todate, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_MY_Holiday_This(UserID, Todate, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_Consume_HRS_db(int Comp_id, string Todate, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_Consume_HRS(UserID, Todate, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_TASK_OPTION_db(string UserID, string Todate, string Fromdate, int CompanyID, int option)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_TASK_OPTION(UserID, Todate, Fromdate, CompanyID, option);
    }
    [WebMethod]
    public DataTable KRA_TASK_DETAILS_db(string UserID, int Task_id, int CompanyID)
    {





        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;





        return sercon1.KRA_TASK_DETAILS(UserID, Task_id, CompanyID);
    }
    [WebMethod]
    public string KRA_TASK_UPDATE_STATUS_db(string P_USER_ID, int P_TASK_ID, int P_COMP_ID, string UPDATE_DATE, string UPDATE_TIME, string P_RAISE_HAND, int P_STATUS, int CompQnty)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_UPDATE_STATUS(P_USER_ID, P_TASK_ID, P_COMP_ID, UPDATE_DATE, UPDATE_TIME, P_RAISE_HAND, P_STATUS, CompQnty);



    }
    [WebMethod]
    public DataTable KRA_EMP_Role_db(string UserID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EMP_Role(UserID, CompID);
    }
    [WebMethod]
    public string KRA_doc_update_db(int Task_id, string P_file_name, int P_option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_doc_update(Task_id, P_file_name, P_option);
    }
    [WebMethod]
    public DataTable KRA_Approval_details_db(string UserID, int CompID, int P_Option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Approval_details(UserID, CompID, P_Option);
    }
    [WebMethod]
    public DataTable KRA_Approval_details_view_db(string UserID, int CompID, int P_Option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Approval_details_view(UserID, CompID, P_Option);
    }
    [WebMethod]
    public string KRA_TASK_Approval_STATUS_db(int APPROVAL_ID, int P_TASK_ID, int P_COMP_ID, string P_REMARK, string P_COMMENT, string P_RATING, int P_STATUS)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_Approval_STATUS(APPROVAL_ID, P_TASK_ID, P_COMP_ID, P_REMARK, P_COMMENT, P_RATING, P_STATUS);
    }

    [WebMethod]
    public string KRA_TASK_MY_TASK_CREATE_db(string P_Task_NAME, string P_Comp_ID, string P_Assigned_To, int P_project_nature, int P_Time_based, string P_task_exp_start_date, string P_task_exp_end_date, string P_start_time, string P_end_time, int P_priority_level, int P_criticality, int P_task_occurence, int P_per_day_man_hour, string P_discription, string P_ATTACH, string taskAction, int taskQuantity)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_MY_TASK_CREATE(P_Task_NAME, P_Comp_ID, P_Assigned_To, P_project_nature, P_Time_based, P_task_exp_start_date, P_task_exp_end_date, P_start_time, P_end_time, P_priority_level, P_criticality, P_task_occurence, P_per_day_man_hour, P_discription, P_ATTACH, taskAction, taskQuantity);
    }
    [WebMethod]
    public string KRA_TASK_ASSIGN_TASK_CREATE_db(string P_Task_NAME, string P_Comp_ID, string P_Assigned_To, int P_project_nature, int P_Time_based, string P_task_exp_start_date, string P_task_exp_end_date, string P_start_time, string P_end_time, int P_priority_level, int P_criticality, int P_task_occurence, int P_per_day_man_hour, string P_discription, string P_ATTACH, string taskAction, int taskQuantity, string createdby)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_ASSIGN_TASK_CREATE(P_Task_NAME, P_Comp_ID, P_Assigned_To, P_project_nature, P_Time_based, P_task_exp_start_date, P_task_exp_end_date, P_start_time, P_end_time, P_priority_level, P_criticality, P_task_occurence, P_per_day_man_hour, P_discription, P_ATTACH, taskAction, taskQuantity, createdby);
    }
    [WebMethod]
    public string KRA_TASK_ASSIGN_TASK_CREATE_GROUP_db(string P_Task_NAME, string P_Comp_ID, string P_Assigned_To, int P_project_nature, int P_Time_based, string P_task_exp_start_date, string P_task_exp_end_date, string P_start_time, string P_end_time, int P_priority_level, int P_criticality, int P_task_occurence, int P_per_day_man_hour, string P_discription, string P_ATTACH, string taskAction, int taskQuantity, string createdby, int ProjectID, int P_taskID, int P_option, int P_SQN_NUMBER, int WorkMode)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_ASSIGN_TASK_CREATE_GROUP(P_Task_NAME, P_Comp_ID, P_Assigned_To, P_project_nature, P_Time_based, P_task_exp_start_date, P_task_exp_end_date, P_start_time, P_end_time, P_priority_level, P_criticality, P_task_occurence, P_per_day_man_hour, P_discription, P_ATTACH, taskAction, taskQuantity, createdby, ProjectID, P_taskID, P_option, P_SQN_NUMBER, WorkMode);
    }

    [WebMethod]
    public DataTable KRA_EMP_SEARCH_db(string UserID, string SEARCH_TEXT_1, string SEARCH_TEXT_2, int CompID, int option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EMP_SEARCH(UserID, SEARCH_TEXT_1, SEARCH_TEXT_2, CompID, option);
    }
    [WebMethod]
    public string KRA_Project_update(int P_PROJECT_ID, string P_PROJECT_NAME, string P_USER_ID, int P_OPTION, int P_COMP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Project_update(P_PROJECT_ID, P_PROJECT_NAME, P_USER_ID, P_OPTION, P_COMP_ID);
    }
    [WebMethod]
    public DataTable KRA_Fetch_Temp_task_db(int P_COMP_ID, int P_Project_id, int P_Option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Fetch_Temp_task(P_COMP_ID, P_Project_id, P_Option);
    }
    [WebMethod]
    public string KRA_Assign_Temp_Task_Submit_db(int P_Project_id, int P_COMP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Assign_Temp_Task_Submit(P_Project_id, P_COMP_ID);
    }
    [WebMethod]
    public DataTable KRA_Team_surpluse_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_Team_surpluse(UserID, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_Team_Orgainization_Performance_db(int P_COMP_ID, int P_option)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_Team_Orgainization_Performance(P_COMP_ID, P_option);
    }
    [WebMethod]
    public DataTable KRA_EMP_Comparision_db(string User_ID, int CompID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_EMP_Comparision(User_ID, CompID);
    }
    [WebMethod]
    public DataTable KRA_Chat_Send_Message_db(string Sender_ID, string Receiver_ID, string txtMessgae, int CompID, int R_CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Chat_Send_Message(Sender_ID, Receiver_ID, txtMessgae, CompID, R_CompID);
    }
    [WebMethod]
    public DataTable KRA_Chat_Send_Message_Display_db(string Sender_ID, string Receiver_ID, int CompID, int R_CompID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.KRA_Chat_Send_Message_Display(Sender_ID, Receiver_ID, CompID, R_CompID);
    }
    [WebMethod]
    public DataTable KRA_INDEX_GRAPH_db(string Start_date, string end_date, string type_foramte, string User_id, int comp_id, int P_Select)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_INDEX_GRAPH(Start_date, end_date, type_foramte, User_id, comp_id, P_Select);
    }
    [WebMethod]
    public DataTable KRA_EVENTS_User_Details_db(int Comp_id, string UserID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.KRA_EVENTS_User_Details(UserID, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_Org_Toppers_db(int Comp_id, string UserID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.KRA_Org_Toppers(UserID, Comp_id);
    }
    [WebMethod]
    public DataTable KRA_Chat_Recent_Message_Display_db(string UserID, int Comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.KRA_Chat_Recent_Message_Display(Comp_id, UserID);
    }
    [WebMethod]
    public DataTable KRA_TASK_OPTION_REJECTED_DETAILS_db(int RejectID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.KRA_TASK_OPTION_REJECTED_DETAILS(RejectID);
    }

    [WebMethod]
    public DataTable KRA_Fetch_event_db(int P_COMP_ID, string FROM_DATE, string TODATE, int P_Option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Fetch_event(P_COMP_ID, FROM_DATE, TODATE, P_Option);
    }
    //-- Edit Kara Event
    [WebMethod]
    public DataTable KRA_EVENT_detaila_db(int P_COMP_ID, int Event_ID, int P_Option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EVENT_detaila(P_COMP_ID, Event_ID, P_Option);
    }

    [WebMethod]
    public DataTable Audience_Sub_catogery_db(int CompID, int Main_cat)
    {​​​​​​​
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Audience_Sub_catogery_db(CompID, Main_cat);
        return Dts;
    }​​​​​​​

   
    [WebMethod]
    public string KRA_EVENT_UPDATE_db(int P_Event_ID, int P_event_type, string P_event_name, string P_event_discription, string P_event_venue, string P_event_start_date, string P_event_end_date, int P_participants_count, int P_comp_id, int P_option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EVENT_UPDATE(P_Event_ID, P_event_type, P_event_name, P_event_discription, P_event_venue, P_event_start_date, P_event_end_date, P_participants_count, P_comp_id, P_option);
    }
    [WebMethod]
    public string KRA_EVENT_Audience_Save_db(int P_Event_ID, int P_COMP_ID, string P_USER_ID_STR, int P_option)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EVENT_Audience_insert(P_Event_ID, P_COMP_ID, P_USER_ID_STR, P_option);
    }
    [WebMethod]
    public string KRA_TASK_Delete_db(string P_USER_ID, int P_TASK_ID, int P_COMP_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_Delete(P_USER_ID, P_TASK_ID, P_COMP_ID);
    }
    [WebMethod]
    public DataTable KRA_TASK_REASSAIGN_FETCH_db(string UserID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_REASSAIGN_FETCH(UserID, CompID);
    }
    [WebMethod]
    public string KRA_TASK_REASSIGN_db(string P_Task_NAME, string P_Comp_ID, string P_Assigned_To, int P_project_nature, int P_Time_based, string P_task_exp_start_date, string P_task_exp_end_date, string P_start_time, string P_end_time, int P_priority_level, int P_criticality, int P_task_occurence, int P_per_day_man_hour, string P_discription, string P_ATTACH, string taskAction, int taskQuantity, int P_project_ID, string P_assigned_from)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_REASSIGN(P_Task_NAME, P_Comp_ID, P_Assigned_To, P_project_nature, P_Time_based, P_task_exp_start_date, P_task_exp_end_date, P_start_time, P_end_time, P_priority_level, P_criticality, P_task_occurence, P_per_day_man_hour, P_discription, P_ATTACH, taskAction, taskQuantity, P_project_ID, P_assigned_from);
    }
    [WebMethod]
    public string Proc_madu_KRA_Task_EDIT_db(int ApprovalID, string P_Task_NAME, string P_Comp_ID, string P_Assigned_To, int P_project_nature, int P_Time_based, string P_task_exp_start_date, string P_task_exp_end_date, string P_start_time, string P_end_time, int P_priority_level, int P_criticality, int P_task_occurence, int P_per_day_man_hour, string P_discription, string P_ATTACH, string taskAction, int taskQuantity, int P_project_ID, string P_assigned_from)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Proc_madu_KRA_Task_EDIT(ApprovalID, P_Task_NAME, P_Comp_ID, P_Assigned_To, P_project_nature, P_Time_based, P_task_exp_start_date, P_task_exp_end_date, P_start_time, P_end_time, P_priority_level, P_criticality, P_task_occurence, P_per_day_man_hour, P_discription, P_ATTACH, taskAction, taskQuantity, P_project_ID, P_assigned_from);
    }
    [WebMethod]
    public DataTable KRA_TASK_RAISEHAND_FETCH_db(string UserID, int CompID, int TaskID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_RAISEHAND_FETCH(UserID, CompID, TaskID);
    }
   
    [WebMethod]
    public DataTable Get_Higher_Education_Course_Select_startedAdmission_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Higher_Education_Course_Select_startedAdmission();
        return Dts;
    }
    //BLENDED ENHANCEMENT START
    [WebMethod]
    public string Blended_Curriculum_Settings1_db(int blendedCurrId, int courseTypeId, int companyId, int philosophy,
                            int trainingCategory, int trainingSubCategory, int competencyId,
                            int coreCompetencyId, int subCompetencyId, string curriculumName,
                            string curriculumCode, string curriculumDescription, string curriculumInstruction,
                            int activeStatus, string courseOwner, string createdBy, int userExpiryDays, int userDueDays,
                            int gradeTemplate, int passingPercent, int feedbackStatus, int feedbackOptional,
                            string feedbackIds, int certificateStatus, int certificateId, string updateAction,
                            int autoNotification, int pageProgress, string modifiedBy, string approverList)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_Settings1(blendedCurrId, courseTypeId, companyId, philosophy,
                             trainingCategory, trainingSubCategory, competencyId, coreCompetencyId, subCompetencyId, curriculumName,
                             curriculumCode, curriculumDescription, curriculumInstruction, activeStatus, courseOwner, createdBy, userExpiryDays,
                             userDueDays, gradeTemplate, passingPercent, feedbackStatus, feedbackOptional, feedbackIds, certificateStatus,
                             certificateId, updateAction, autoNotification, pageProgress, modifiedBy, approverList);
        return strResult;
    }
    //Blended Admin settings Second page
    [WebMethod]
    public string Blended_Curriculum_Settings2_db(int blendedId, int companyId, int isRecommendable, int hasSelfLearnApproval, int hasPrerequisiteCourse,
            int prerequisiteTrngId, int prerequisitePassStatus, int previousAssignCourseId, int assignAfterDays, int assignAfterCompletion, int hasExam,
            int examPassStatus, int pageProgress, string modifiedBy, int moduleId)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_Settings2(blendedId, companyId, isRecommendable, hasSelfLearnApproval, hasPrerequisiteCourse,
                        prerequisiteTrngId, prerequisitePassStatus, previousAssignCourseId, assignAfterDays, assignAfterCompletion, hasExam, examPassStatus,
                        pageProgress, modifiedBy, moduleId);
        return strResult;
    }
    //Blended Admin settings third page, activity management
    [WebMethod]
    public string Blended_Curriculum_Settings3_db(int blendedId, int companyId, string selectedActivities, int pageProgress, string modifiedBy, int moduleId,
        int hasSequencing, int minActivitiesToAttend)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_Settings3(blendedId, companyId, selectedActivities, pageProgress, modifiedBy, moduleId, hasSequencing, minActivitiesToAttend);
        return strResult;
    }

    //Blended Admin settings send for approval
    [WebMethod]
    public string Blended_Curriculum_SendForApproval_db(int blendedId, int companyId, int pageProgress, int moduleId, string modifiedBy)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_SendForApproval(blendedId, companyId, pageProgress, moduleId, modifiedBy);
        return strResult;
    }

    //Validating training code
    [WebMethod]
    public DataTable ValidateCourseCode_db(int companyId, int trainingId, string courseCode)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.ValidateCourseCode(companyId, trainingId, courseCode);
        return Dts;
    }

    //Blended Approver settings approval
    [WebMethod]
    public string Blended_Curriculum_Approval_db(int blendedId, int companyId, int pageProgress, int moduleId, string modifiedBy)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_Approval(blendedId, companyId, pageProgress, moduleId, modifiedBy);
        return strResult;
    }

    //Get User assigned Curriculums
    [WebMethod]
    public DataTable Get_User_Curriculumns_db(int companyId, string userId, int moduleId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_User_Curriculumns(companyId, userId, moduleId);
        return Dts;
    }

    //Get User Upcoming Curriculums
    [WebMethod]
    public DataTable Get_User_Upcoming_Curriculumns_db(int companyId, string userId, int moduleId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_User_Upcoming_Curriculumns(companyId, userId, moduleId);
        return Dts;
    }

    //Blended Launching validations
    [WebMethod]
    public DataTable Blended_Launching_Validation_db(int companyId, string userId, int blendedId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Blended_Launching_Validation(companyId, userId, blendedId);
        return Dts;
    }

    //Blended user course info
    [WebMethod]
    public DataSet Get_Userwise_Blended_Dtl_db(int companyId, int blendedId, int moduleId, string userId, int blendedUserTrackId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Get_Userwise_Blended_Dtl(companyId, blendedId, moduleId, userId, blendedUserTrackId);
    }

    //Blended User feedback submit
    [WebMethod]
    public string Curriculum_Feedback_Submit_db(string userId, int blendedId, string feedbackStr, string userComment, int moduleId, int companyId)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Curriculum_Feedback_Submit(userId, blendedId, feedbackStr, userComment, moduleId, companyId);
        return strResult;
    }

    //Blended Approver Curriculum deactivate
    [WebMethod]
    public string Blended_Curriculum_Deactivate_db(int blendedId, int companyId, int moduleId, string modifiedBy)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.Blended_Curriculum_Deactivate(blendedId, companyId, moduleId, modifiedBy);
        return strResult;
    }
    [WebMethod]
    public string Admin_Specification_insert_db(string CategName, string USERID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon1.Admin_Specification_insert(CategName, USERID, CompID);
        return msg;
    }
    //BLENDED ENHANCEMENT END
    [WebMethod]
    public DataTable Get_Mobile_app_Report_db(string P_FromDate, string P_ToDate, string P_CMPCOD) 
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_Mobile_app_Report(P_FromDate, P_ToDate, P_CMPCOD);
        return Dts;
    }
    [WebMethod]
    public DataTable Check_concurrnt_login_status_db(string user_id, string logdate)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.check_concurnt_log_status(user_id, logdate);
        return Dts;
    }
    //JITHIN END
    [WebMethod]
    public DataTable MADU_POP_CONSENT_db(int cmpid, string USER_ID, int ACTION)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.MADU_POP_CONSENT(cmpid, USER_ID, ACTION);
        return Dts;
    }
    [WebMethod]
    public DataTable KRA_Oraganogram_fetch_db(string UserID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_Oraganogram_fetch(UserID, CompID);
    }

    [WebMethod]
    public DataTable KRA_organogram_update_db(string UserID, string ReportID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_organogram_update(UserID, ReportID, CompID);
    }

    //[WebMethod]
    //public string KRA_TASK_UPDATE_task_db(int task_id, string comp_id, string task_name, string project_nature, string work_mode, int priority_level, string task_exp_start_date, string task_exp_end_date, string TIME_BASED, string START_TIME, string END_TIME, int TASK_CRITICALITY, string TASK_OCCURENCE, string HELP, string action_des, int taskQuantity)

    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon1.KRA_TASK_UPDATE_task(task_id, comp_id, task_name, project_nature, work_mode, priority_level, task_exp_start_date, task_exp_end_date, TIME_BASED, START_TIME, END_TIME, TASK_CRITICALITY, TASK_OCCURENCE, HELP, action_des, taskQuantity);

    //}

    [WebMethod]
    public string KRA_MY_TEAM_REPT_HD_VIEW_DB(string UserID, string Log_UserID, int CompanyID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_MY_TEAM_REPT_HD_VIEW(UserID, Log_UserID, CompanyID);
    }

    [WebMethod]
    public DataTable Survey_Audiance_db(int COMPY_ID, string Search_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Survey_Audiance(COMPY_ID, Search_txt);
    }

    [WebMethod]
    public DataTable Search_Pool_questn_pool_db(int comp_Id, int module_type, int Cat_Type, int Qus_type, string Search_text)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Search_Pool_questn_pool(comp_Id, module_type, Cat_Type, Qus_type, Search_text);
    }

    [WebMethod]

    public DataTable Overdue_courses_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Overdue_courses(comp_id, start_date, end_date);
    }

    [WebMethod]

    public DataTable completion_zone_db(int comp_id, string start_date, string end_date, int zone_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.completion_zone(comp_id, start_date, end_date, zone_id);
    }

    //[WebMethod]

    //public DataTable completion_due_counts_db(int comp_id, string start_date, string end_date)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

    //    return sercon.completion_due_count( comp_id,  start_date,  end_date);
    //}

    [WebMethod]

    public DataTable completion_due_counts_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.completion_due_counts(comp_id, start_date, end_date);
    }
    [WebMethod]

    public DataTable elearning_summary_zone_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.elearning_summary_zone(comp_id, start_date, end_date);
    }



    [WebMethod]

    public DataTable get_zone_name_db(string comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.get_zone_name(comp_id);
    }

    [WebMethod]

    public DataTable mobile_app_zone_report_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.mobile_app_zone_report(comp_id, start_date, end_date);
    }

    [WebMethod]

    public DataTable mobile_app_branch_report_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.mobile_app_branch_report(comp_id, start_date, end_date);
    }

    [WebMethod]

    public DataTable mobile_app_firm_report_db(string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.mobile_app_firm_report(start_date, end_date);
    }

    [WebMethod]

    public DataTable except_insur_brking_employee_db(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.except_insur_brking_employee(comp_id, start_date, end_date);
    }
    [WebMethod]

    public DataTable get_course_name_db(string comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.get_course_name(comp_id);
    }
    [WebMethod]

    public DataTable course_wise_feedback_report_db(int comp_id, int course_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.course_wise_feedback_report(comp_id, course_id);
    }

    [WebMethod]
    public string KRA_TASK_UPDATE_task_db(int task_id, string comp_id, string task_name, string project_nature, string work_mode, int priority_level, string task_exp_start_date, string task_exp_end_date, string TIME_BASED, string START_TIME, string END_TIME, int TASK_CRITICALITY, string TASK_OCCURENCE, string HELP, string action_des, int taskQuantity, string perdaymanhr)

    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_TASK_UPDATE_task(task_id, comp_id, task_name, project_nature, work_mode, priority_level, task_exp_start_date, task_exp_end_date, TIME_BASED, START_TIME, END_TIME, TASK_CRITICALITY, TASK_OCCURENCE, HELP, action_des, taskQuantity, perdaymanhr);

    }



    [WebMethod]
    public string KRA_EMP_Role_view_db(string Log_UserID, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.KRA_EMP_Role_view(Log_UserID, CompID);
    }

    [WebMethod]
    public string GetCompany_By_exam_db(int trainingId, int moduleId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.GetCompany_By_exam(trainingId, moduleId);
    }

    [WebMethod]
    public DataSet Get_exam_Audience_User_View_db(int prm_comp_id, int prm_trng_id, string prm_audi_id, string prm_audi_user_id, string prm_search_text)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Get_exam_Audience_User_View(prm_comp_id, prm_trng_id, prm_audi_id, prm_audi_user_id, prm_search_text);
        return Dts;
    }

    [WebMethod]
    public string Delete_exam_Audience_Grp_db(int Comp_ID, int TrainingID, string Audi_str, string UsrID)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon1.Delete_exam_Audience_Grp(Comp_ID, TrainingID, Audi_str, UsrID);
        return str;
    }

    [WebMethod]
    public DataTable select_exam_audi_code_db(int comp_id, int exam_id, string aud_code)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_exam_audi_code(comp_id, exam_id, aud_code);
        return Dts;
    }

    [WebMethod]
    public string Vilt_User_Cancel_delete_db(int Comp_ID, int TrainingID, string UsrID)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon1.Vilt_User_Cancel_delete(Comp_ID, TrainingID, UsrID);
        return str;
    }
    //SREE EXTERNAL EXAM



    [WebMethod]
    public DataTable exam_external_fetch_quali_db(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.exam_external_fetch_quali(comp_id);
        return Dts;
    }
    [WebMethod]
    public DataTable exam_external_fetch_stream_db(int comp_id, int quali_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.exam_external_fetch_stream(comp_id, quali_id);
        return Dts;
    }



    [WebMethod]
    public DataTable exam_external_fetch_state_db(int comp_id, string search_text)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.exam_external_fetch_state(comp_id, search_text);
        return Dts;
    }
    [WebMethod]
    public string exam_external_update_user_dlts_db(int COMP_ID, string name, int age, int gender, string mob, string email, string aadhar, string address_1, string address_2, int pin_code, string district, string state, string postoffice, string thaluk, string qualification, string stream, string college, string university, int year, string job_location, string user_id)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon1.exam_external_update_user_dlts(COMP_ID, name, age, gender, mob, email, aadhar, address_1, address_2, pin_code, district, state, postoffice, thaluk, qualification, stream, college, university, year, job_location, user_id);
        return str;
    }

    //E-learning-overdue courses

    //[WebMethod]
    //public DataSet overdue_course_user_details_db(string UserId, int EmpCompId)
    //{
    //    DataSet dts = new DataSet();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    dts = sercon1.overdue_course_user_details(UserId, EmpCompId);
    //    return dts;
    //}



    //[WebMethod]
    //public DataTable Profile_Bind_Overdue_Course_Details_db(string CMP_ID, string UsrID)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon1.Profile_Bind_Overdue_Course_Details(CMP_ID, UsrID);
    //    return Dts;
    //}



    //[WebMethod]
    //public DataTable Report_Learning_Overdue_db(string P_From_date, string P_To_date, int P_Comp_ID, string Deptname)
    //{



    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



    //    return sercon1.Report_Learning_Overdue(P_From_date, P_To_date, P_Comp_ID, Deptname);
    //}

    /// <summary>
    /// Seelakshmi Exam Manager dashboard
    /// </summary>
    /// <param name="296191"></param>
    /// <returns></returns>

    //[WebMethod]
    //public DataTable Exam_Admin_dashboard_fetch_db(int comp_id)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon1.Exam_Admin_dashboard_fetch(comp_id);
    //    return Dts;
    //}

    ///////
    //E-learning-overdue courses

    //E-learning-overdue courses



    [WebMethod]
    public DataSet overdue_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon1.overdue_course_user_details(UserId, EmpCompId);
        return dts;
    }



    [WebMethod]
    public DataTable Profile_Bind_Overdue_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Profile_Bind_Overdue_Course_Details(CMP_ID, UsrID);
        return Dts;
    }



    [WebMethod]
    public DataTable Report_Learning_Overdue_db(string P_From_date, string P_To_date, int P_Comp_ID, string Deptname)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon1.Report_Learning_Overdue(P_From_date, P_To_date, P_Comp_ID, Deptname);
    }



    //E-learning-overdue courses

    [WebMethod]
    public DataTable Check_Login_Attempt_Session_db(string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Check_Login_Attempt_Session_ser(user_id);
        return Dts;

    }

    [WebMethod]
    public DataTable insert_photo_punch_db(string user_id,string Password,int CompID,string UserID,string IP)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.insert_photo_punch(user_id, Password, CompID, UserID,IP);
        return Dts;

    }
    [WebMethod]
    public DataTable Punching_Checking_Permission_db(string user_id, int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Punching_Checking_Permission(user_id, CompID);
        return Dts;

    }
    [WebMethod]
    public DataTable Punching_Detailed_Report_db(int CompID, string FromDate, string ToDate)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Punching_Detailed_Report(CompID, FromDate, ToDate);
        return Dts;

    }
    [WebMethod]
    public string update_session_clr_login_db(string user_id, int comp_id, string mac_id, string ip_add, string session_id)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.update_session_clr_login(user_id, comp_id, mac_id, ip_add, session_id);
        return strResult;
    }

    [WebMethod]
    public string Vilt_attendence_Confirm_db(int companyId, int courseId, int moduleId, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Vilt_attendence_Confirm(companyId, courseId, moduleId, userId);
    }

    [WebMethod]
    public string ilt_no_feedback_completion_db(int training_id, int company_id, string userid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.ilt_no_feedback_completion(training_id, company_id, userid);
    }


    [WebMethod]
    public DataTable overall_search_db(int CompID, string user_id, string searchkey)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.overall_search(CompID, user_id, searchkey);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Admin_dashboard_fetch_db(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Exam_Admin_dashboard_fetch(comp_id);
        return Dts;
    }

    [WebMethod]
    public string Delete_exam_dashboard_db(int COMP_ID, string EXAM_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Delete_exam_dashboard(COMP_ID, EXAM_ID);

    }



    [WebMethod]
    public DataTable save_instrctr_db(int comp_id, int action_id, string emp_id, string psswrd, string email)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.save_instrctr(comp_id, action_id, emp_id, psswrd, email);
        return Dts;
    }


    [WebMethod]
    public DataTable Bind_exam_completed_users_db(string comp_id, string exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Bind_exam_completed_users(comp_id, exam_id);
        return Dts;
    }
    [WebMethod]
    public string dl_insert_bookmark_db(int comp_id, int resource_id, string user_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.dl_insert_bookmark(comp_id, resource_id, user_id);

    }
    [WebMethod]
    public string psswrd_policy_90dys_db(int comp_id, string user_id, string psswrd)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.psswrd_policy_90dys(comp_id, user_id, psswrd);
        return strResult;
    }

    [WebMethod]
    public DataTable Select_Roll_check_db(string user_id)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Select_Roll_check(user_id);
        return Dts;
    }



    // VILT Detailed Report- ANNIES-START

    [WebMethod]
    public DataTable Select_vilt_detailed_report_db(int Comp_ID, string from_date, string to_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.Select_vilt_detailed_report(Comp_ID, from_date, to_date);
    }
    // VILT Detailed Report- ANNIES-End



    // VILT Attendance Report- ANNIES-START
    [WebMethod]
    public DataTable VILT_Attendance_Report_db(int Comp_ID, string from_date, string to_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Attendance_Report(Comp_ID, from_date, to_date);
    }
    // VILT Attendance Report- ANNIES-END



    // VILT Dashboard Report- ANNIES-START
    [WebMethod]
    public DataTable VILT_Dashboard_Report_db(int Comp_ID, string from_date, string to_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Dashboard_Report(Comp_ID, from_date, to_date);
    }
    // VILT Dashboard Report- ANNIES-END

    //MAHESH UNNI-START



    [WebMethod]
    public DataTable Vlt_attend_rpt_db(int comp_id, string From_date, string To_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Vlt_attend_rpt(comp_id, From_date, To_date);
        return Dts;
    }

    //evaluation report

    [WebMethod]
    public DataTable evaluatin_rept_db(int comp_id, string From_date, string To_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.evaluatin_rept(comp_id, From_date, To_date);
        return Dts;
    }

    //evaluation summary

    [WebMethod]
    public DataTable evaluatin_summary_rept_db(int comp_id, string From_date, string To_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.evaluatin_summary_rept(comp_id, From_date, To_date);
        return Dts;
    }



    //MHESH UNNI -END

    //SALI-SELF AND REFERRED - START

    [WebMethod]
    public DataTable selflearning_user_details_stts_db(string UserId, int CompId, int action_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon1.selflearning_user_details_stts(UserId, CompId, action_id);
        return dts;
    }

    [WebMethod]
    public DataTable selflearning_user_details_stts_count_db(string UserId, int CompId, int action_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon1.selflearning_user_details_stts_count(UserId, CompId, action_id);
        return dts;
    }

    [WebMethod]
    public DataTable Refered_learning_details_db(string UserId, int CompId, int action_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon1.Refered_learning_details(UserId, CompId, action_id);
        return dts;
    }


    //SALI-SELF AND REFERRED - END
    [WebMethod]
    public DataTable VILT_Dashboard_Induction_db(int Comp_ID, string from_date, string to_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Dashboard_Induction(Comp_ID, from_date, to_date);
    }
    //Dashboard


    [WebMethod]
    public DataTable Select_Elrprt_db(int comp_id, string from_date, string to_date, string dptmnt, string post)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Elrprt(comp_id, from_date, to_date, dptmnt, post);
        return Dts;
    }

    [WebMethod]
    public DataTable Select_Elrprt_db1(int comp_id, string from_date, string to_date, string dptmnt, string post)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Elrprt1(comp_id, from_date, to_date, dptmnt, post);
        return Dts;
    }

    [WebMethod]
    public DataTable Select_ExamRpt_db1(int comp_id, string from_date, string to_date, string dptmnt, string post)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_ExamRpt(comp_id, from_date, to_date, dptmnt, post);
        return Dts;
    }

    [WebMethod]
    public DataTable VILT_pending_induction_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_induction(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_pending_list_ah_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_list_ah(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_pending_list_bh_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_list_bh(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_pending_list_abh_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_list_abh(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_pending_list_rm_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_list_rm(Comp_Id);
    }

    [WebMethod]
    public DataTable VILT_pending_list_gold_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_pending_list_gold(Comp_Id);
    }


    [WebMethod]
    public DataTable Virtual_training_dashboard_db(int Comp_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Virtual_training_dashboard(Comp_Id);
    }

    [WebMethod]
    public DataTable Virtual_dashboard_trained_db(int Comp_Id, string from_date, string to_date)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Virtual_dashboard_trained(Comp_Id, from_date, to_date);
    }

    //sali-vilt dashboard
    [WebMethod]
    public DataTable Select_Viltrprt_db(int comp_id, string from_date, string to_date, string dptmnt, string post)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Viltrprt(comp_id, from_date, to_date, dptmnt, post);
        return Dts;
    }

    [WebMethod]
    public DataTable Select_Viltrprt1_db(int comp_id, string from_date, string to_date, string dptmnt, string post)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Select_Viltrprt1(comp_id, from_date, to_date, dptmnt, post);
        return Dts;
    }


    //SALI WELFARE
    [WebMethod] public DataTable Welfare_User_Pendings_db(int Comp_Id, string User_id, int Action_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Welfare_User_Pendings(Comp_Id, User_id, Action_id);
    }

    //sali elearning

    [WebMethod]
    public DataTable Elearning_Heads_Dbrd_completed_db(int Comp_Id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Elearning_Heads_Dbrd_completed(Comp_Id, User_id);
        return Dts;
    }



    [WebMethod]
    public DataTable Elearning_Heads_Dbrd_db(int Comp_Id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Elearning_Heads_Dbrd(Comp_Id, User_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Team_Pending_Report_db(int Comp_Id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Team_Pending_Report(Comp_Id, User_id);
        return Dts;
    }
    [WebMethod]
    public string check_concurrent_login_out_update_db(string userid)
    {
        string strResult = string.Empty;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        strResult = sercon1.check_concurrent_login_out_update_ser(userid);
        return strResult;
    }

    [WebMethod]
    public DataTable Team_Pending_Report_Head_db(int Comp_Id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Team_Pending_Report_Head(Comp_Id, User_id);
        return Dts;
    }

    //Training-Exam-Dashboard-Start


    [WebMethod]
    public DataTable Training_Dasboard_Exam_Assign_db(int comp_id, string from_date, string to_date)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Training_Dasboard_Exam_Assign(comp_id, from_date, to_date);
        return Dts;
    }


    [WebMethod]
    public DataTable Training_Dasboard_Exam_Pass_db(int comp_id, string from_date, string to_date)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Training_Dasboard_Exam_Pass(comp_id, from_date, to_date);
        return Dts;
    }



    [WebMethod]
    public DataTable Training_Dasboard_Exam_Fail_db(int comp_id, string from_date, string to_date)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Training_Dasboard_Exam_Fail(comp_id, from_date, to_date);
        return Dts;
    }


    [WebMethod]
    public DataTable Training_Dasboard_Exam_Expired_db(int comp_id, string from_date, string to_date)
    {
        DataTable Dts = new DataTable();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon1.Training_Dasboard_Exam_Expired(comp_id, from_date, to_date);
        return Dts;
    }

    //Training-Exam-Dashboard-End

    //ILT-External_punchng-Start
    [WebMethod]
    public DataTable Ext_Instrctr_details_db(int Comp_Id, int Trnng_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Ext_Instrctr_details(Comp_Id, Trnng_id);
    }
       
    [WebMethod]
    public string external_punching_details_db(int training_id, int comp_id, int session_id, string image_name, int punch_status, int punch_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.external_punching_details(training_id, comp_id, session_id, image_name, punch_status, punch_id);
    }

    //ILT-External_punchng-End


    //firm_wise_comppletion_rprt -Start
    [WebMethod]
    public DataTable firmwise_course_report_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.firmwise_course_report();
        return Dts;
    }


    //firm_wise_comppletion_rprt -End

    //apprvr-Updation and deletion-Start
    [WebMethod]
    public string course_approver_db(int COMP_ID, int type, string emp_code)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.course_approver(COMP_ID, type, emp_code);

    }
    [WebMethod]
    public DataTable COURSEMERGE_GETUSER_db(int COMP_ID, string search_key)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.COURSEMERGE_GETUSER(COMP_ID, search_key);
        return Dts;
    }
    [WebMethod]
    public DataTable approver_fetch_db(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.approver_fetch(comp_id);
        return Dts;
    }
    //apprvr-Updation and deletion-End
    [WebMethod]

    public string CourseMerge_Report_db(int comp_id, string OldEmp_Code, string NewEmp_Code)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon1.CourseMerge_Report(comp_id, OldEmp_Code, NewEmp_Code);
        return msg;
    }

    //COURSEMERGE-END
  
    //CourseMerge -Getuser_END


    //CourseMerge -CourseNames
    [WebMethod]
    public DataTable COURSEMERGE_CourseNames_db(int comp_id, string OldEmp_Code, string NewEmp_Code)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.COURSEMERGE_CourseNames(comp_id, OldEmp_Code, NewEmp_Code);
        return Dts;
    }
    //CourseMerge -CourseNames_END
    //update attempts

    [WebMethod]
    public DataTable Admin_Ele_Updation_db(int Comp_Id, string Search_key)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Admin_Ele_Updation(Comp_Id, Search_key);
    }
    [WebMethod]
    public DataTable Admin_Ele_slct_upd_users_db(int Comp_Id, int training_id, string Search_key)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Admin_Ele_slct_upd_users(Comp_Id, training_id, Search_key);
    }


    [WebMethod]
    public DataTable Select_Adm_Usr_EleDtls_db(int Comp_id, string User_id, int Training_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Adm_Usr_EleDtls(Comp_id, User_id, Training_id);
        return Dts;
    }

    [WebMethod]
    public string Update_Adm_Usr_EleDtls_db(int comp_id, string user_id, int training_id, string strt_date, string end_date, int attempt_cnt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Update_Adm_Usr_EleDtls(comp_id, user_id, training_id, strt_date, end_date, attempt_cnt);

    }

    [WebMethod]
    public DataTable Ele_Attmpt_Histry_Reprt_db(int Comp_id, int Training_id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Ele_Attmpt_Histry_Reprt(Comp_id, Training_id, User_id);
        return Dts;
    }
    //end

    //MANAGE TRAINING CO-ORDINATOR-START

    [WebMethod]
    public string tcordinator_crse_approver_db(int Comp_id, int Type, string Emp_code)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.tcordinator_crse_approver(Comp_id, Type, Emp_code);

    }

    [WebMethod]
    public DataTable Select_Tcordinators_db(int Comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Tcordinators(Comp_id);
        return Dts;
    }

    //MANAGE TRAINING CO-ORDINATOR -END


    //ILT-VILT REPORT GENERATION- START

    [WebMethod]
    public DataTable Select_Ilt_Vilt_Trainings_db(int Company_id, string From_date, string To_date, int Action_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Select_Ilt_Vilt_Trainings(Company_id, From_date, To_date, Action_id);
        return Dts;
    }


    [WebMethod]
    public DataTable select_training_rpt3_db(int comp_id, int tr_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_training_rpt3(comp_id, tr_id);
        return Dts;
    }

    [WebMethod]
    public DataTable select_training_rpt1_db(int comp_id, int tr_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_training_rpt1(comp_id, tr_id);
        return Dts;
    }

    [WebMethod]
    public DataTable select_training_rpt2_db(int comp_id, int tr_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_training_rpt2(comp_id, tr_id);
        return Dts;

    }

    //ILT-VILT REPORT GENERATION- END


    //STAFF WELFARE -GIFTCARD-Start

    [WebMethod]
    public DataTable STAFFWELFARE_GIFTCARD_DB(int Comp_ID, string USER_ID, int CATEGORY)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.STAFFWELFARE_GIFTCARD(Comp_ID, USER_ID, CATEGORY);
        return Dts;
    }

    [WebMethod]

    public string STAFFWELFARE_GIFTCARD_ATTEMPTS_DB(int Comp_ID, string USER_ID, int ACTION)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon1.STAFFWELFARE_GIFTCARD_ATTEMPTS(Comp_ID, USER_ID, ACTION);
        return msg;
    }
    //Staffwelfare_Giftcard_confirmation_attempt_history

    [WebMethod]

    public string staffwelfare_giftcard_usr_attempt_history_db(string user_id, int comp_id, int Action, int Status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon1.staffwelfare_giftcard_usr_attempt_history(user_id, comp_id, Action, Status);
        return msg;
    }
    [WebMethod]
    public DataTable STAFFWELFARE_GIFTCARD_TEMPLATE_DB(int CompID, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.STAFFWELFARE_GIFTCARD_TEMPLATE(CompID, user_id);
        return Dts;
    }

    //STAFF WELFARE -GIFTCARD-End

    //REPORT-REPORT UPDATION NEW-start

    [WebMethod]
    public DataTable Report_export_Course_wise_EL_db(int COMPID, int TrngID, int m_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Report_export_Course_wise_EL(COMPID, TrngID, m_id);
        return Dts;

    }


    [WebMethod]
    public DataTable Report_export_elearning_Course_wise_EL_db(int COMPID, int TrngID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.Report_export_elearning_Course_wise_EL(COMPID, TrngID);
        return Dts;

    }

    //REPORT-REPORT UPDATION NEW-End


    //REPORT-EXAM NEW UPDATION-START
   

    [WebMethod]
    public DataTable fetch_export_dtls_db(int CompID, int ExamID, int p_type)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.fetch_export_dtls(CompID, ExamID, p_type);
        return Dts;
    }

    //REPORT-EXAM NEW UPDATION-END


    [WebMethod]
    public DataTable Report_self_learning_1_db(int P_comp_id, int P_TRAINID, int p_mid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Report_self_learning_1(P_comp_id, P_TRAINID, p_mid);
    }

    //PsswrdUpdationAdmin
    [WebMethod]
    public string Change_PasswordAdminNW_db(string userID, string Currentpsswrd, string NewPassword, int CompanyID, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon1.Change_PasswordAdminNW(userID, Currentpsswrd, NewPassword, CompanyID, modifiedBy);
    }


    //PANJAMI-FEEDBACK REPORT-START
  

    [WebMethod]
    public DataTable select_feedback_rpt1_db(int comp_id, string From_date, string To_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_feedback_rpt1(comp_id, From_date, To_date);
        return Dts;

    }


    [WebMethod]
    public DataTable select_feedback_rpt2_db(int comp_id, string From_date, string To_date, string trainner_id, int course_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_feedback_rpt2(comp_id, From_date, To_date, trainner_id, course_id);
        return Dts;

    }


    [WebMethod]
    public DataTable select_feedback_rpt3_db(int comp_id, string trngid, int crsid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.select_feedback_rpt3(comp_id, trngid, crsid);
        return Dts;

    }

    [WebMethod]
    public DataTable feedback_adminside_usrdtl_db(int company_id, int trng_id, int crs_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.feedback_adminside_usrdtl(company_id, trng_id, crs_id);
        return Dts;

    }

    [WebMethod]
    public DataTable feedback_admin_report_db(int company_id, int trng_id, int crs_id, int type, int qns_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.feedback_admin_report(company_id, trng_id, crs_id, type, qns_id);
        return Dts;

    }
    //PANJAMI-FEEDBACK REPORT-END


    //MAHESH-FEEDBACK REPORT-START

    [WebMethod]
    public DataSet get_instructor_dtl_db(int COMPID, int TrngID, int crsid)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.get_instructor_dtl(COMPID, TrngID, crsid);
        return Dts;

    }

    [WebMethod]
    public DataTable INSTRUCTOR_GETTRAINING_db(int COMPID, string TrnerID, string serch_key, int COURSE_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.INSTRUCTOR_GETTRAINING(COMPID, TrnerID, serch_key, COURSE_ID);
        return Dts;

    }
    [WebMethod]
    public DataTable feedback_trainerside_usrdtl_db(int COMPID, int TrningID, int action_key, int COURSE_ID, int ques_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.feedback_trainerside_usrdtl(COMPID, TrningID, action_key, COURSE_ID, ques_ID);
        return Dts;

    }


    [WebMethod]
    public DataTable INSTRUCTOR_rating_db(int COMPID, int trng_id, int COURSE_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.INSTRUCTOR_rating(COMPID, trng_id, COURSE_ID);
        return Dts;

    }


    [WebMethod]
    public DataTable TRAINING_rating_db(int COMPID, int trng_id, int COURSE_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.TRAINING_rating(COMPID, trng_id, COURSE_ID);
        return Dts;

    }

    //MAHESH-FEEDBACK REPORT-END

    //MAHESH-USERWISE REPORT-START

    [WebMethod]
    public DataTable elrng_user_report_detail_db(int COMPID, string from_date, string to_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon1.elrng_user_report_detail(COMPID, from_date, to_date);
        return Dts;

    }
    //MAHESH-USERWISE REPORT-END


    //Nisha-Modulewise_Training_Attended_List-start


    [WebMethod]
    public DataTable VILT_Trained_List_Induction_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_List_Induction(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_Trained_List_AH_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_List_AH(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_Trained_list_BH_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_list_BH(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_Trained_list_ABH_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_list_ABH(Comp_Id);
    }
    [WebMethod]
    public DataTable VILT_Trained_list_RM_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_list_RM(Comp_Id);
    }

    [WebMethod]
    public DataTable VILT_Trained_list_GOLD_db(int Comp_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.VILT_Trained_list_GOLD(Comp_Id);
    }

    //Nisha-Modulewise_Training_Attended_List-End

    //Nisha-virtual Attendance Report-Session date dropdownlist-Start

    [WebMethod]
    public DataTable ILT_VILT_TRNGDATE_LIST_db(int Comp_Id, int Trng_Id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon1.ILT_VILT_TRNGDATE_LIST(Comp_Id, Trng_Id);
    }








}








