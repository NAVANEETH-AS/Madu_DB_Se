using System;
using System.Web.Services;
using System.Data;
using System.Net;


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{

    madu_dbcon.Service sercon = new madu_dbcon.Service();

    public Service()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    // [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
    public string signup_db(string usrid, string usernm, int catid, string mobno, string email, string company, string companyadd, string country, string passwd, string empid, string RegNo, string GstNo, string PanNo)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.signup(usrid, usernm, catid, mobno, email, company, companyadd, country, passwd, empid, RegNo, GstNo, PanNo);
    }
    //HEERA DIGITAL LIBRARY EXAMCOMPLETED
    [WebMethod]
    public DataTable Profile_Bind_completed_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_completed_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    //HEERA DIGITAL LIBRARY ONGOING
    [WebMethod]

    public DataTable Profile_Bind_ongoingexam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_ongoing_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }
    //HEERA DIGITAL LIBRARY UPCOMING
    [WebMethod]

    public DataTable Profile_Bind_upcomingexam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_upcomingexam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    //HEERA DIGITAL LIBRARY EXPIRED
    [WebMethod]

    public DataTable Profile_Bind_expiredexam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_expiredexam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    //HEERA DIGITAL LIBRARY EXAMSCOUNT
    [WebMethod]

    public DataTable Profile_Bind_examcount_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_examcount_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    //Jithin

    [WebMethod]
    public DataTable Select_Elearning_Course_Mob_db(int usr_track_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Select_Elearning_Course_Mob(usr_track_id);
        return Dts;
    }​​​​​​​

    [WebMethod]
    public string Insert_QuestionPaper_Answer_played_Save_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QUESID)//Insert Answer Details
    {
        string Dts = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_played_Save_Details(EXAMID, CMPID, UserID, trID, QUESID);
        return Dts;
    }

    [WebMethod]
    public DataTable Preview_Internal_Exam_Manager_Dashboard_db(string CompID, string FromDate, string ToDate, string ExamType)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Internal_Exam_Manager_Dashboard(CompID, FromDate, ToDate, ExamType);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_External_Exam_Manager_Dashboard_db(string CompID, string FromDate, string ToDate, string ExamType)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_External_Exam_Manager_Dashboard(CompID, FromDate, ToDate, ExamType);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_Individual_Exam_Report_db(string CompID, string FromDate, string ToDate, string EMPCODE)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Individual_Exam_Report(CompID, FromDate, ToDate, EMPCODE);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_Individual_Exam_Report_Details_db(string CompID, string EMPCODE)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Individual_Exam_Report_Details(CompID, EMPCODE);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_ExamList_type_db(int CompID, int ExamType)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_ExamList_type(CompID, ExamType);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_Exam_Wise_Report_db(int CompID, string FromDate, string ToDate, string Philos, string Exa2, int EXAMTYPE)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Exam_Wise_Report(CompID, FromDate, ToDate, Philos, Exa2, EXAMTYPE);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_Internal_Exam_Assigned_Report_db(int CompID, int ExamID, int TYPSTAT)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Internal_Exam_Assigned_Report(CompID, ExamID, TYPSTAT);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_External_Exam_Assigned_Report_db(int CompID, int ExamID, int TYPSTAT)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_External_Exam_Assigned_Report(CompID, ExamID, TYPSTAT);
        return Dts;
    }


    //j-30-04-2021
    [WebMethod]
    public DataTable User_Attended_exam_Doc_AnswerSheet_Details_Track_db(int CompID, int Exam_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_Doc_AnswerSheet_Details_Track(CompID, Exam_id, TrkID);
        return Dts;
    }
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_DOC_Ques_Details_Track_db(int CompID, int Exam_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_DOC_Ques_Details_Track(CompID, Exam_id, TrkID);
        return Dts;
    }
    //J-03-05-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_DOC_Ques_Details_insert_db(int CompID, int Exam_id, string User_id, string TrkID, string QuestID, string Qnum, int MaxMark, int MarkObt, string RevNo)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_DOC_Ques_Details_insert(CompID, Exam_id, User_id, TrkID, QuestID, Qnum, MaxMark, MarkObt, RevNo);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_QuestionPaper_DOC_UserTrack_Update_db(string Comp_ID, string Exam_ID, string User_id, string trID, string OPID, string revCommen, string RevNo)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_DOC_UserTrack_Update(Comp_ID, Exam_ID, User_id, trID, OPID, revCommen, RevNo);
        return Dts;
    }

    [WebMethod]
    public DataTable DocumentChangedQuestionInsert_db(string Question, string QUESTIONID, string Mark, string TryCount, string WordLimit, string QUestionPatternID, string QUestionPatternTypeID, string QUestionCompID, string QUestionCatID, string QUestionSubID, string AudioLimit, string QuesACount) //Changed Questions insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.DocumentChangedQuestionInsert(Question, QUESTIONID, Mark, TryCount, WordLimit, QUestionPatternID, QUestionPatternTypeID, QUestionCompID, QUestionCatID, QUestionSubID, AudioLimit, QuesACount);
        return Dts;
    }
    //J-15-04-2021
    [WebMethod]
    public DataTable DocumentChangedSubQuestionInsert_db(string QUESTIONID, string EXMID, string SubQues, string SubQuesMark, string QUestionCompID) //Changed Questions insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.DocumentChangedSubQuestionInsert(QUESTIONID, EXMID, SubQues, SubQuesMark, QUestionCompID);
        return Dts;
    }

    //J-04-05-2021


    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Doc_Details_db(int CompID, int Exam_id, string user_id, string TrkID, string Dtype)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Doc_Details(CompID, Exam_id, user_id, TrkID, Dtype);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_Question_Usr_Qstn_DOC_Bind_db(string EXAMID, string CMPID, string UserID, string trID, string QustnID, string Dtype)//preview User Questn Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Question_Usr_Qstn_DOC_Bind(EXAMID, CMPID, UserID, trID, QustnID, Dtype);
        return Dts;
    }

    //J-07-04-2021
    [WebMethod]
    public DataTable Get_Exam_modulewises_db(string UserId, int CompanyID, int ModuleType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Exam_modulewises(UserId, CompanyID, ModuleType);
        return Dts;
    }
    [WebMethod]
    public string SaveTemplateDetails_db(int OrganizationId, int ModuleId, int NotiTypeId, int TypeNotId, string editorDetails)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.SaveTemplateDetails(OrganizationId, ModuleId, NotiTypeId, TypeNotId, editorDetails);
    }
    //J-08-04-2021
    [WebMethod]
    public string INS_Reviewer_Schedule_Notifi_EXAMS_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Reviewer_Schedule_Notifi_EXAMS(EXAM_ID, UserID, CMPID, EXPDATE);
    }
    //J-30-03-2021
    [WebMethod]
    public string User_Attended_exam_Reval_Status_Update_db(int TrkID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.User_Attended_exam_Reval_Status_Update(TrkID);
    }
    //J-SUR-29-03-2021
    [WebMethod]
    public DataTable Survey_Dashboard_Counts_db(int CMPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_Counts(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Survey_Dashboard_TopTrend_db(int CMPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_TopTrend(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Survey_Dashboard_TopTrend_Quest_db(int CMPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_TopTrend_Quest(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_Pool_questn_pool_Delete_db(int comp_id, int modul_type, int category, int qtype, int QiD)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_Pool_questn_pool_Delete(comp_id, modul_type, category, qtype, QiD);
    }
    [WebMethod]
    public DataTable fetch_Pool_questn_pool_Drp_Question_db(int comp_id, int modul_type, int category, int qtype, int QiD)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_Pool_questn_pool_Drp_Question(comp_id, modul_type, category, qtype, QiD);
    }
    [WebMethod]
    public string Update_survey_quest_db(string survy_question, string survytype, int qust_type, string modifidby, int companyid, int moduleid, int QID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Update_survey_quest(survy_question, survytype, qust_type, modifidby, companyid, moduleid, QID);
    }
    [WebMethod]
    public string Update_survey_Option_db(string survy_question, string survytype, int qust_type, string modifidby, int companyid, int moduleid, int QID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Update_survey_Option(survy_question, survytype, qust_type, modifidby, companyid, moduleid, QID);
    }



    //J-29-03-2021
    [WebMethod]
    public string INS_Reviewer_Schedule_Notifi_EXAM_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Reviewer_Schedule_Notifi_EXAM(EXAM_ID, UserID, CMPID, EXPDATE);
    }
    [WebMethod]
    public string INS_Revaluator_Schedule_Notifi_EXAM_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Revaluator_Schedule_Notifi_EXAM(EXAM_ID, UserID, CMPID, EXPDATE);
    }
    [WebMethod]
    public string INS_Revaluator_Application1_Notifi_EXAM_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Revaluator_Application1_Notifi_EXAM(EXAM_ID, UserID, CMPID, EXPDATE);
    }

    //J-23-03-2021
    [WebMethod]
    public DataTable Profile_Bind_complete_List_Exam_Dtls_Reval_db(string CMP_ID, string UsrID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_complete_List_Exam_Dtls_Reval(CMP_ID, UsrID, EXMID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_complete_List_Exam_Dtls_Reval1_db(string CMP_ID, string UsrID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_complete_List_Exam_Dtls_Reval1(CMP_ID, UsrID, EXMID);
        return Dts;
    }

    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Details_Reval_db(int CompID, int Exam_id, string user_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Details_Reval(CompID, Exam_id, user_id, TrkID);
        return Dts;
    }
    //j-24-03-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Details_Reval2_db(int CompID, int Exam_id, string user_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Details_Reval2(CompID, Exam_id, user_id, TrkID);
        return Dts;
    }
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Details_Rev_db(int CompID, int Exam_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Details_Rev(CompID, Exam_id, TrkID);
        return Dts;
    }
    [WebMethod]
    public string INS_Reviewer_Notifi_EXAM_Complete_db(int EXAM_ID, string UserID, int CMPID, int trkID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Reviewer_Notifi_EXAM_Complete(EXAM_ID, UserID, CMPID, trkID);
    }

    [WebMethod]
    public string INS_AUDI_EXAM_INTERNAL_DB(int examid, int compid, string Audience)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon.INS_AUDI_EXAM_INTERNAL(examid, compid, Audience);
    }
    //J-22-03-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Reviewer_Status_Submit_db(string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Reviewer_Status_Submit(TrkID);
        return Dts;
    }

    //J-17-03-2021
    [WebMethod]
    public DataTable Qstn_AssignmentChecking_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Qstn_AssignmentChecking_Details(EXAMID, CMPID, UserID, trID, QID);
        return Dts;
    }
    [WebMethod]
    public DataTable AssignmentMarkforReview_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID, string Attnd)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AssignmentMarkforReview_Details(EXAMID, CMPID, UserID, trID, QID, Attnd);
        return Dts;
    }


    //J-13-03-2021
    [WebMethod]
    public DataTable Online_Exam_ProctorSettings_insert_db(int EXAMID, int MobileDetectedC, int BooKDetectedC, int VoiceDetectedC, int MultiplePersonDetectedC, int NoPersonMobileDetectedC, int LeaveAttemptDetectedC, int LookintoScreenDetectedC)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Online_Exam_ProctorSettings_insert(EXAMID, MobileDetectedC, BooKDetectedC, VoiceDetectedC, MultiplePersonDetectedC, NoPersonMobileDetectedC, LeaveAttemptDetectedC, LookintoScreenDetectedC);
        return Dts;
    }
    [WebMethod]
    public DataTable Online_Exam_ProctorSettings_Update_db(int EXAMID, int MobileDetectedC, int BooKDetectedC, int VoiceDetectedC, int MultiplePersonDetectedC, int NoPersonMobileDetectedC, int LeaveAttemptDetectedC, int LookintoScreenDetectedC)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Online_Exam_ProctorSettings_Update(EXAMID, MobileDetectedC, BooKDetectedC, VoiceDetectedC, MultiplePersonDetectedC, NoPersonMobileDetectedC, LeaveAttemptDetectedC, LookintoScreenDetectedC);
        return Dts;
    }
    [WebMethod]
    public DataTable menu_exm_mstr_fetch_Proctor_Settings_db(int Comp_id, int Exam_id)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.menu_exm_mstr_fetch_Proctor_Settings(Comp_id, Exam_id);
        return Dts;
    }​​​​​​​
            //J-15-03-2021
            [WebMethod]
    public DataTable Reviewer_Exam_Details_db(int EXAM_ID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Reviewer_Exam_Details(EXAM_ID);
        return Dts;
    }​​​​​​​
            [WebMethod]
    public string INS_Reviewer_Notifi_EXAM_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Reviewer_Notifi_EXAM(EXAM_ID, UserID, CMPID, EXPDATE);
    }

    [WebMethod]
    public DataTable Revaluator_Exam_Details_db(int EXAM_ID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Revaluator_Exam_Details(EXAM_ID);
        return Dts;
    }​​​​​​​
            [WebMethod]
    public string INS_Revaluator_Notifi_EXAM_db(int EXAM_ID, string UserID, int CMPID, string EXPDATE)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Revaluator_Notifi_EXAM(EXAM_ID, UserID, CMPID, EXPDATE);
    }


    //j-05-03-2021
    [WebMethod]
    public DataTable Insert_User_Certificate_Exam_db(string user_id, int CompID, int Exam_id, string ImageName, string Courseid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_User_Certificate_Exam(user_id, CompID, Exam_id, ImageName, Courseid);
        return Dts;
    }
    //j-06-03-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Details_Track_db(int CompID, int Exam_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Details_Track(CompID, Exam_id, TrkID);
        return Dts;
    }
    //j-08-03-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Ques_Details_Track_db(int CompID, int Exam_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Ques_Details_Track(CompID, Exam_id, TrkID);
        return Dts;
    }
    //j-08-03-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Ques_Details_Evaluate_db(int Exam_id, string QuesID, int CompID, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Ques_Details_Evaluate(Exam_id, QuesID, CompID, TrkID);
        return Dts;
    }
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Reviewer_Submit_db(int Comp_ID, int Exam_ID, string TrkID, string Qid, string QAns, string RevComments, string PMark, string NegMark, string lastC, string RevNo)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Reviewer_Submit(Comp_ID, Exam_ID, TrkID, Qid, QAns, RevComments, PMark, NegMark, lastC, RevNo);
        return Dts;
    }
    //J-09-03-2021

    [WebMethod]
    public DataTable Profile_Bind_Reviewer_Complete_Update_db(string CompID, string UserID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Reviewer_Complete_Update(CompID, UserID, EXMID);
        return Dts;
    }
    [WebMethod]
    public DataTable User_Attended_GuideLine_Details_db(int CompID, int Exam_id, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_GuideLine_Details(CompID, Exam_id, user_id);
        return Dts;
    }
    //J-11-03-2021
    [WebMethod]
    public DataTable Profile_Bind_Revaluator_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Revaluator_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Revaluator_Attendee_List_db(string CMP_ID, string UsrID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Revaluator_Attendee_List(CMP_ID, UsrID, EXMID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Revaluator_Completed_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Revaluator_Completed_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Revaluator_NotCompleted_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Revaluator_NotCompleted_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    //J-02-03-2021
    [WebMethod]
    public DataTable Profile_Bind_complete_List_Exam_Dtls_db(string CMP_ID, string UsrID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_complete_List_Exam_Dtls(CMP_ID, UsrID, EXMID);
        return Dts;
    }
    //j-03-02-2021
    [WebMethod]
    public DataTable User_Attended_exam_AnswerSheet_Details_db(int CompID, int Exam_id, string user_id, string TrkID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_AnswerSheet_Details(CompID, Exam_id, user_id, TrkID);
        return Dts;
    }

    //J-26-02-2021
    [WebMethod]
    public DataTable Profile_Bind_Check_Visibility_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Check_Visibility(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_TaskList_Count_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_TaskList_Count(CompID, UserID);
        return Dts;
    }
    [WebMethod]

    public DataTable Profile_Bind_Taskcount_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Taskcount_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_completed_Task_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_completed_Task_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Reviewer_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Reviewer_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }

    //J-27-02-2021
    [WebMethod]
    public DataTable Profile_Bind_Reviewer_Completed_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Reviewer_Completed_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Reviewer_NotCompleted_Exam_Dtls_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Reviewer_NotCompleted_Exam_Dtls(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Reviewer_Attendee_List_db(string CMP_ID, string UsrID, string EXMID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Reviewer_Attendee_List(CMP_ID, UsrID, EXMID);
        return Dts;
    }

    [WebMethod]
    public DataSet selflearning_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.selflearning_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet completed_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.completed_course_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet ongoing_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.ongoing_course_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet notattended_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.notattended_course_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet expired_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Expired_course_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet Refered_course_user_details_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Refered_course_user_details(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet Selflearning_all_count_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Selflearning_all_count(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet refer_all_count_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.refer_all_count(UserId, EmpCompId);
        return dts;
    }
    [WebMethod]
    public string Proctor_resp_db(string Evnttpe, string cntr, string resid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string ret = sercon.Proctor_resp(Evnttpe, cntr, resid);
        return ret;
    }

    [WebMethod]
    public DataTable madu_plancomp_Select_db(string CMP_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.madu_planc_omp_Select_db(CMP_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Course_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Course_Total_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Course_Total_Details(CMP_ID, UsrID);
        return Dts;
    }

    [WebMethod]
    public DataTable Profile_Bind_Completed_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Completed_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }
    //[WebMethod]
    //public DataTable Profile_Bind_ongoing_Exam_Details_db(string CMP_ID, string UsrID)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.Profile_Bind_ongoing_Exam_Details(CMP_ID, UsrID);
    //    return Dts;
    //}
    [WebMethod]
    public DataTable Profile_Bind_notattend_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_notattend_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Course_Monthly_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Course_Monthly_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Course_PreMonthly_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Course_PreMonthly_Details(CMP_ID, UsrID);
        return Dts;
    }

    [WebMethod]
    public DataTable Profile_Bind_Exam_Monthly_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Exam_Monthly_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Exam_PreMonthly_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Exam_PreMonthly_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Expired_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Expired_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Upcoming_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Upcoming_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }

    [WebMethod]
    public DataTable Profile_Bind_Completed_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Completed_Course_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_ongoing_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_ongoing_Course_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_notattend_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_notattend_Course_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_Expired_Course_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Expired_Course_Details(CMP_ID, UsrID);
        return Dts;
    }
    [WebMethod]
    public string qst_option_insert_Match_db(int qstn_id, string qst_option, string mod_of_optn, string option_path, string currect_ansr, int created_by, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.qst_option_insert_Match(qstn_id, qst_option, mod_of_optn, option_path, currect_ansr, created_by, status);
    }
    [WebMethod]
    public DataTable Imgqst_option_insert_db(int qstn_id, string qst_option, string mod_of_optn, string option_path, string currect_ansr, int created_by, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Imgqst_option_insert(qstn_id, qst_option, mod_of_optn, option_path, currect_ansr, created_by, status);
        return Dts;
    }
    [WebMethod]
    public DataTable Imgqst_option_insert_Match_db(int qstn_id, string qst_option, string mod_of_optn, string option_path, string currect_ansr, int created_by, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Imgqst_option_insert_Match(qstn_id, qst_option, mod_of_optn, option_path, currect_ansr, created_by, status);
        return Dts;
    }
    [WebMethod]
    public string Templ_Insert_db(string Teml_Name, string Teml_Content, string Templ_UserSess, string Teml_Time, int Teml_Type)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Templ_Insert(Teml_Name, Teml_Content, Templ_UserSess, Teml_Time, Teml_Type);
    }
    [WebMethod]
    public string plan_insertion_db(string flag, string usr_id, string plan_id, string pay_status, string catg)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.plan_insertion(flag, usr_id, plan_id, pay_status, catg);
    }

    //bilu


    [WebMethod]
    public string Madu_plan_sub_db(string trid, string usr_id, string usernm, string mob, string mail, string pay_md)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_plan_sub(trid, usr_id, usernm, mob, mail, pay_md);


    }

    [WebMethod]
    public string Madu_plan_sub_tran_db(string trid, string usr_id, string resps, string payuid, string bnkid, string psts)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_plan_sub_tran(trid, usr_id, resps, payuid, bnkid, psts);


    }



    //bilu serv end
    [WebMethod]
    public string qstn_type_db(string qstn_type, string crt_by, int status)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.qstn_type(qstn_type, crt_by, status);
    }
    [WebMethod]
    public string qstn_cat_db(string cat_name, string crt_by, int status)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.qstn_cat(cat_name, crt_by, status);
    }
    [WebMethod]

    public string qstnpool_db(string question, int qstn_typ_id, int qstn_cat_id, string exm_usr_typ, string content_type, int upload_status, string prodct_code, int qstn_status, string comp_id, string expiry_time, string created_by, string evaluation_type, int status, string questn_path, int total_answers)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.qstnpool(question, qstn_typ_id, qstn_cat_id, exm_usr_typ, content_type, upload_status, prodct_code, qstn_status, comp_id, expiry_time, created_by, evaluation_type, status, questn_path, total_answers);
    }


    [WebMethod]
    public string Menu_Insert_db(string UMenu, int CompanyID, int RoleID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Menu_Insert(UMenu, CompanyID, RoleID);
    }

    [WebMethod]
    public DataTable User_Contact_US_Details_db(string CName, string CEmail, string CMobile, string CMessage)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.User_Contact_US_Details(CName, CEmail, CMobile, CMessage);
        return Dts;
    }

    [WebMethod]
    public DataTable ContentResource_Edit_db(string ContentName, int MenuID, string FExt, string CExt, string ResourceCode, string Description, int MainCID, string Edition, string Volume, int EditCode, int LangID, int CmpID, int PlanID, string LinkVid, string Payment, string PayCheck)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.ContentResource_Edit(ContentName, MenuID, FExt, CExt, ResourceCode, Description, MainCID, Edition, Volume, EditCode, LangID, CmpID, PlanID, LinkVid, Payment, PayCheck);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_BuyContent_Insert_db(string CompID, string UserID, string ContentID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Insert_BuyContent_Insert(CompID, UserID, ContentID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_PaidContent_Details_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Insert_PaidContent_Details(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_learnCourse_Details_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Insert_learnCourse_Details(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_Intrest_Details_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Insert_Intrest_Details(CompID, UserID);
        return Dts;
    }

    [WebMethod]
    public DataTable madu_Lastest_db(string CmpID, string PlnID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.madu_Lastest(CmpID, PlnID);
        return Dts;
    }

    [WebMethod]
    public string MenuListUpdate_db(int MenuID, int Status)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.MenuListUpdate(MenuID, Status);
    }
    [WebMethod]
    public string Templ_Status_db(int TCMID, int Status)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Templ_StatusUpdate(TCMID, Status);
    }
    [WebMethod]
    public DataTable Menu_Master_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_Master();
        return Dts;
    }
    [WebMethod]
    public DataTable Theme_Config_db(string CmpID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Theme_Configs(CmpID);
        return Dts;
    }
    [WebMethod]
    public DataTable Theme_ConfigG_db(string ComPID, string CmpnyLogoFExt, string CompanyURL, string CEOFExt, string CEOVIDFExt, string INDEXVID1FExt, string INDEXVID2FExt, string DigLibVID1FExt, string DigLibVID2FExt, string Designation, string OwnerBy, string CEOQuote)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Theme_Configs_Details(ComPID, CmpnyLogoFExt, CompanyURL, CEOFExt, CEOVIDFExt, INDEXVID1FExt, INDEXVID2FExt, DigLibVID1FExt, DigLibVID2FExt, Designation, OwnerBy, CEOQuote);
        return Dts;
    }
    [WebMethod]
    public DataTable Menu_SubSelect_db(int SubMenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_SubSelect(SubMenuID);
        return Dts;
    }
    [WebMethod]
    public DataTable Menu_Content_db(int SubMenuID, int RoleId, int CompanyID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_Content(SubMenuID, RoleId, CompanyID);
        return Dts;
    }
    [WebMethod]
    public DataTable EditMenu_Content_db(int EditID, int SubMenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.EditMenu_Content(EditID, SubMenuID);
        return Dts;
    }

    [WebMethod]
    public DataTable Delete_Content_db(int DeleteID, int MenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Delete_Content(DeleteID, MenuID);
        return Dts;
    }

    [WebMethod]
    public DataTable Menu_Subreturn_db(int SubMenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_Subreturn(SubMenuID);
        return Dts;
    }

    [WebMethod]
    public DataTable Role_Master_db(int CompValue)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Role_Master(CompValue);
        return Dts;
    }
    [WebMethod]
    public DataTable Content_Master_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_Master();
        return Dts;
    }
    [WebMethod]
    public DataTable Content_Language_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_Language();
        return Dts;
    }
    [WebMethod]
    public DataTable Content_plan_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_plan();
        return Dts;
    }
    [WebMethod]
    public DataTable Content_Company_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_Company();
        return Dts;
    }
    [WebMethod]
    public DataTable Content_SuperCompany_db(string CmpID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_SuperCompany(CmpID);
        return Dts;
    }
    [WebMethod]
    public DataTable Content_OrgCompany_db(string CmpID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_OrgCompany(CmpID);
        return Dts;
    }
    [WebMethod]
    public DataTable Content_SubOrgCompany_db(string CmpID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Content_SubOrgCompany(CmpID);
        return Dts;
    }
    [WebMethod]
    public DataTable TempfieldDt_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.TempfieldDt().Tables[0];
        return Dts;
    }

    [WebMethod]

    public DataTable MenuList_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.MenuList();
        return Dts;
    }
    [WebMethod]

    public DataTable NotificationList_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.NotificationList();
        return Dts;
    }

    [WebMethod]
    public DataTable NotificationListEmail_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.NotificationListEmail();
        return Dts;
    }
    [WebMethod]
    public DataTable NotificationListSystem_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.NotificationListSystem();
        return Dts;
    }


    [WebMethod]
    public DataTable Menu_MasterUser_db(string CompID, string RoleID, int PlanID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_MasterUser(CompID, RoleID, PlanID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_Exam_Code_Details_db(string EXAMID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_Exam_Code_Details(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable CheckPendingExamSettings_db(string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.CheckPendingExamSettings(CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable qst_Exam_Question_Paper_Details_db(string EXAMID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_Exam_Question_Paper_Details(EXAMID, CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable qst_Paper_insert_db(string ExamID, string QuestionPaperName, string CATID, string SUBCATID, string PATTERNID, string QUESTIONID, string TOTALMARK, string N_MARK, string CMPID, string TotalQ, string ACount)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_Paper_insert(ExamID, QuestionPaperName, CATID, SUBCATID, PATTERNID, QUESTIONID, TOTALMARK, N_MARK, CMPID, TotalQ, ACount);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_Paper_Remove_db(string ExamID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_Paper_Remove(ExamID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_QPQ_Pattern_Check_Details_db(string PATTERNID, string QuestionPaperID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_QPQ_Pattern_Check_Details(PATTERNID, QuestionPaperID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_QPQ_Details_db(string flt, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_QPQ_Details(flt, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_QPQ_Chge_Details_db(string flt)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_QPQ_Chge_Details(flt);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_Search_FLT_Details_db(string SearchText, string FLTID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_Search_FLT_Details(SearchText, FLTID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_PATTERN_FLT_Details_db(string FilterIDValue, string PATTERNID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_PATTERN_FLT_Details(FilterIDValue, PATTERNID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PTRN_TYPE_db(string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PTRN_TYPE(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_PatternDetails_db(string flt, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_PatternDetails(flt, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_Details_db(string flt, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_Details(flt, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PAP_PATTREN_Details_db(string PATTERNID, string FilterIDValue, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_PATTREN_Details(PATTERNID, FilterIDValue, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PAP_PATTREN_FIL_Details_db(string FLTID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_PATTREN_FIL_Details(FLTID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PAP_FIL_Details_db(string FLTID, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_FIL_Details(FLTID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PAP_Details_db(string flt, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_Details(flt, CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable qst_PAP_Details_Filter_Search_db(string flt, string FLTID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_Details_Filter_Search(flt, FLTID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PAP_Details_Search(string flt)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PAP_Details_Srch_db(flt);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_FILT_db(string COMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_FILT(COMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_FLT_Details_db(string FLT, string CMPID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_FLT_Details(FLT, CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable qst_FILT_Sub_db(string COMPID, string FID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_FILT_Sub(COMPID, FID);
        return Dts;

    }

    [WebMethod]
    public DataTable qst_PL_Details_OP_db(string qid)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_Details_OP(qid);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_PL_Details_OP_Asitis_db(string qid)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_PL_Details_OP_Asitis(qid);
        return Dts;
    }

    [WebMethod]
    public DataTable ChangedQuestionDetailsCollect_db(string QUESTIONID) //Collect Changed Questions Pattern and Pattern Type Details Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionDetailsCollect(QUESTIONID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionDetailsCollect_db(string QUESTIONID) //Collect Changed Questions Pattern and Pattern Type Details Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionDetailsCollect(QUESTIONID);
        return Dts;
    }

    [WebMethod]
    public DataTable ChangedQuestionDetailsCollectDeta_db(string QUESTIONID, string EXMID) //Collect Changed Questions Pattern and Pattern Type Details Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionDetailsCollectDeta(QUESTIONID, EXMID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionptrnDetailsCollectDeta_db(string QUESTIONID, string EXMID) //Collect Changed Questions Pattern and Pattern Type Details Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionptrnDetailsCollectDeta(QUESTIONID, EXMID);
        return Dts;
    }

    [WebMethod]
    public DataTable Preview_Pattern_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Pattern_Bind(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Details_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Details_Bind(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_UsrAttended_Details_Bind_db(string EXAMID, string CMPID, string UserID, string trID)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_UsrAttended_Details_Bind(EXAMID, CMPID, UserID, trID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_PatternCount_Bind_db(string EXAMID, string CMPID, string UserID, string trID)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_PatternCount_Bind(EXAMID, CMPID, UserID, trID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Usr_Details_Bind_db(string EXAMID, string CMPID, string UserID, string trID)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Usr_Details_Bind(EXAMID, CMPID, UserID, trID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Option_Details_Bind_db(string EXAMID, string CMPID, string UserID, string trID, string QID)//preview User Option Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Option_Details_Bind(EXAMID, CMPID, UserID, trID, QID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_QuestionPaper_Answer_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID, string Ans, string OPID)//Insert Answer Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_Details(EXAMID, CMPID, UserID, trID, QID, Ans, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_QuestionPaper_Answer_Audio_Details_db(string trID, string QID, string Ans, string OPID)//Insert Answer Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_Audio_Details(trID, QID, Ans, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Qstn_Audio_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Qstn_Audio_Details(EXAMID, CMPID, UserID, trID, QID);
        return Dts;
    }


    //J-23-02-2021
    [WebMethod]
    public DataTable ChangedQuestionOptionInsertFill_db(string Option, string QUESTIONID, string CorrectAnswer, string OPID, string OPValues)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionInsertFill(Option, QUESTIONID, CorrectAnswer, OPID, OPValues);
        return Dts;
    }
    //J-24-02-2021
    [WebMethod]
    public DataTable profile_Exam_Valid_Checking_db(string UserID, string CMPID, string Exam_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.profile_Exam_Valid_Checking(UserID, CMPID, Exam_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable profile_Exam_Update_Checking_db(string UserID, string CMPID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.profile_Exam_Update_Checking(UserID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Option_Details_Clr_Bind_db(string EXAMID, string CMPID, string UserID, string trID, string QID)//preview User Option Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Option_Details_Clr_Bind(EXAMID, CMPID, UserID, trID, QID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_QuestionPaper_Answer_Match_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID, string Ans, string QOPID, string AOPID)//Insert Answer Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_Match_Details(EXAMID, CMPID, UserID, trID, QID, Ans, QOPID, AOPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Insert_QuestionPaper_Answer_Match_Tripple_Details_db(string EXAMID, string CMPID, string UserID, string trID, string QID, string Ans, string QOPID, string AOPID, string AOP3ID)//Insert Answer Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_Match_Tripple_Details(EXAMID, CMPID, UserID, trID, QID, Ans, QOPID, AOPID, AOP3ID);
        return Dts;
    }
    [WebMethod]
    public string Insert_QuestionPaper_Answer_Save_Details_db(string EXAMID, string CMPID, string UserID, string trID, string blendedId)//Insert Answer Details
    {
        string Dts = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Insert_QuestionPaper_Answer_Save_Details(EXAMID, CMPID, UserID, trID, blendedId);
        return Dts;
    }

    [WebMethod]
    public DataTable Preview_Question_Usr_Details_Bind_db(string EXAMID, string CMPID, string UserID, string trID)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Question_Usr_Details_Bind_db(EXAMID, CMPID, UserID, trID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_Question_Usr_Qstn_Bind_db(string EXAMID, string CMPID, string UserID, string trID, string QustnID)//preview User Questn Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Question_Usr_Qstn_Bind(EXAMID, CMPID, UserID, trID, QustnID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Date_Details_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Date_Details_Bind(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_inv_Details_Bind_db(string EXAMID, string CMPID, string dateInv) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_inv_Details_Bind(EXAMID, CMPID, dateInv);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Rev_Details_Bind_db(string EXAMID, string CMPID, string dateInv) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Rev_Details_Bind(EXAMID, CMPID, dateInv);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Aud_Details_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Aud_Details_Bind(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Edit_Details_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Edit_Details_Bind(EXAMID, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Preview_QuestionPaper_Continue_Details_Bind_db(string EXAMID, string CMPID) //preview Questions Pattern
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_QuestionPaper_Continue_Details_Bind(EXAMID, CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable Preview_Question_Bind_db(string ExamID, string QSTID, string PatternID, string CMPID) //Preview Question Paper
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Question_Bind(ExamID, QSTID, PatternID, CMPID);
        return Dts;
    }

    [WebMethod]
    public DataTable ChangedQuestionFilInsert_db(string Question, string QUESTIONID, string Mark, string TryCount, string WordLimit, string QUestionPatternID, string QUestionPatternTypeID, string QUestionCompID, string QUestionCatID, string QUestionSubID, string AudioLimit, string ExactPer, string PartialyPer, string PatternPer, string SplitCount) //Changed Questions insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionFilInsert(Question, QUESTIONID, Mark, TryCount, WordLimit, QUestionPatternID, QUestionPatternTypeID, QUestionCompID, QUestionCatID, QUestionSubID, AudioLimit, ExactPer, PartialyPer, PatternPer, SplitCount);
        return Dts;
    }

    [WebMethod]
    public DataTable ChangedQuestionInsert_db(string Question, string QUESTIONID, string Mark, string TryCount, string WordLimit, string QUestionPatternID, string QUestionPatternTypeID, string QUestionCompID, string QUestionCatID, string QUestionSubID, string AudioLimit) //Changed Questions insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionInsert(Question, QUESTIONID, Mark, TryCount, WordLimit, QUestionPatternID, QUestionPatternTypeID, QUestionCompID, QUestionCatID, QUestionSubID, AudioLimit);
        return Dts;
    }

    [WebMethod]
    public DataTable ChangedQuestionAssignmentInsert_db(string Question, string QUESTIONID, string Mark, string TryCount, string WordLimit, string QUestionPatternID, string QUestionPatternTypeID, string QUestionCompID, string QUestionCatID, string QUestionSubID, string AudioLimit, string LVANSWER, string LPANSWER, string PDFANSWER, string JPGANSWER, string WORDANSWER, string EXCELANSWER, string ATANSWER, string VTANSWER)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionAssignmentInsert(Question, QUESTIONID, Mark, TryCount, WordLimit, QUestionPatternID, QUestionPatternTypeID, QUestionCompID, QUestionCatID, QUestionSubID, AudioLimit, LVANSWER, LPANSWER, PDFANSWER, JPGANSWER, WORDANSWER, EXCELANSWER, ATANSWER, VTANSWER);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionPathInsert_db(string QUESTIONID, string fileSourceNew, string CMPID) //Changed Questions Path insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionPathInsert(QUESTIONID, fileSourceNew, CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionPathInsert_db(string QUESTIONID, string fileSourceNew, string CMPID, string OPID) //Changed Questions Path insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionPathInsert(QUESTIONID, fileSourceNew, CMPID, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionPathInsertA_db(string QUESTIONID, string fileSourceNew, string CMPID, string OPID) //Changed Questions Path insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionPathInsertA(QUESTIONID, fileSourceNew, CMPID, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionPathInsertB_db(string QUESTIONID, string fileSourceNew, string CMPID, string OPID) //Changed Questions Path insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionPathInsertB(QUESTIONID, fileSourceNew, CMPID, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionPathInsertC_db(string QUESTIONID, string fileSourceNew, string CMPID, string OPID) //Changed Questions Path insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionPathInsertC(QUESTIONID, fileSourceNew, CMPID, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionOptionInsert_db(string Option, string QUESTIONID, string CorrectAnswer, string OPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionOptionInsert(Option, QUESTIONID, CorrectAnswer, OPID);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionDrOptionInsert_db(string Option, string QUESTIONID, string CorrectOPtionA, string CorrectOPtionB) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionDrOptionInsert(Option, QUESTIONID, CorrectOPtionA, CorrectOPtionB);
        return Dts;
    }
    [WebMethod]
    public DataTable ChangedQuestionDrTrippleOptionInsert_db(string Option, string QUESTIONID, string CorrectOPtionA, string CorrectOPtionB, string CorrectOPtionC) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ChangedQuestionDrTrippleOptionInsert(Option, QUESTIONID, CorrectOPtionA, CorrectOPtionB, CorrectOPtionC);
        return Dts;
    }

    [WebMethod]
    public string Madu_Content_Tran_db(string trid, string CmpID, string usr_id, string usernm, string mob, string mail, string pay_md, string ContentID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_Content_Tran(trid, CmpID, usr_id, usernm, mob, mail, pay_md, ContentID);


    }
    [WebMethod]
    public string Madu_Content_tran_Stat_db(string trid, string usr_id, string resps, string payuid, string bnkid, string psts)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_Content_tran_Stat(trid, usr_id, resps, payuid, bnkid, psts);


    }
    [WebMethod]
    public string ContactEnquiry_db(string Name, string EmailID, string Mobile, string Message)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ContactEnquiry(Name, EmailID, Mobile, Message);
    }
    [WebMethod]
    public DataTable SurveyExists_db(int companyId, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.SurveyExists(companyId, UserID);
        return Dts;


    }

    //VILT
    [WebMethod]
    public DataTable Instructor_Crs_End_db(int companyId, int courseId, int moduleId, string userId)
    {
        DataTable dt = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dt = sercon.Instructor_Crs_End(companyId, courseId, moduleId, userId);
        return dt;
    }

    


    

    //J-22-02-2-2021
    [WebMethod]
    public DataTable profile_Login_Session_Update_db(string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.profile_Login_Session_Update(UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable profile_Login_Session_Update_Log_db(string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.profile_Login_Session_Update_Log(UserID);
        return Dts;
    }
    // Digital Libraray Admin 18-10-2021
    [WebMethod]
    public DataTable Menu_MasterUserSuper_db(string CompID, string RoleID, int PlanID, string UserID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_MasterUserSuper(CompID, RoleID, PlanID, UserID);
        return Dts;
    }

    [WebMethod]
    public DataTable Menu_MasterUser_Master_db(string CompID, string RoleID, int PlanID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_MasterUser_Master(CompID, RoleID, PlanID);
        return Dts;
    }

    [WebMethod]
    public DataTable Menu_SubSelectUser_db(int SubMenuID, string CompID, string RoleID, int PlanID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_SubSelectUser(SubMenuID, CompID, RoleID, PlanID);
        return Dts;
    }

    [WebMethod]
    public DataTable Menu_SubSelectUser_Super_db(int SubMenuID, string CompID, string RoleID, int PlanID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_SubSelectUser_Super(SubMenuID, CompID, RoleID, PlanID, UsrID);
        return Dts;
    }


    [WebMethod]

    public DataTable digital_master_cat_edit_form_db(int menu_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.digital_master_edit_category_form(menu_id);
        return Dts;
    }

    [WebMethod]
    public string digital_master_category_submit_db(int menu_id, string menu_name)
    {
        string Dts = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.dig_master_category_submit(menu_id, menu_name);
        return Dts;
    }

    [WebMethod]
    public string digital_master_category_delete_db(string menu_id)
    {
        string Dts = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.dig_master_category_delete(menu_id);
        return Dts;
    }
    [WebMethod]

    public string digi_delete_content_db(int comp_id, string resource_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        string msg = sercon.digi_delete_content(comp_id, resource_id);
        return msg;
    }
    [WebMethod]

    public DataTable digital_content_delete_remove_db(int cmpny, int menu)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.digital_master_delete_remove(cmpny, menu);
        return Dts;
    }


    [WebMethod]

    public DataTable digital_master_edit_resource_db(int cmpny, int res_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.digital_master_edit_resource(cmpny, res_id);
        return Dts;
    }



    [WebMethod]
    public DataTable ContentResource_Super_insert_db(string ContentName, int MenuID, string FExt, string CExt, string ResourceCode, string Description, int MainCID, string Edition, string Volume, int LangID, int CmpID, int PlanID, string LinkVid, string Payment, string PayCheck, string usrID, string res_duration)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.ContentResource_Super_insert(ContentName, MenuID, FExt, CExt, ResourceCode, Description, MainCID, Edition, Volume, LangID, CmpID, PlanID, LinkVid, Payment, PayCheck, usrID, res_duration);
        return Dts;
    }

    [WebMethod]
    public DataTable ContentResource_insert_db(string ContentName, int MenuID, string FExt, string CExt, string ResourceCode, string Description, int MainCID, string Edition, string Volume, int LangID, int CmpID, int PlanID, string LinkVid, string Payment, string PayCheck, string contnt_duration, int CatType, int usertype)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        Dts = sercon.ContentResource_insert(ContentName, MenuID, FExt, CExt, ResourceCode, Description, MainCID, Edition, Volume, LangID, CmpID, PlanID, LinkVid, Payment, PayCheck, contnt_duration, CatType, usertype);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Digital_Competency_List_db(int type, int CompID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Get_Digital_Competency_List(type, CompID);
    }

    [WebMethod]
    public string Insert_Digital_Competency_Mapping_db(int CompID, int CoreCompetcy_ID, int Competcy_ID, int SubCompetcy_ID, int Category_ID, string CreatedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Insert_Digital_Competency_Mapping(CompID, CoreCompetcy_ID, Competcy_ID, SubCompetcy_ID, Category_ID, CreatedBy);
    }


    //Jithin End
    //BLENDED ENHANCEMENT START


    //Altered Service
    [WebMethod]
    public DataTable GetTrainingDtlsByModuleType_db(int CompId, int ModuleType)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetTrainingDtlsByModuleType(CompId, ModuleType);
    }


    //Aletered Service-- to get activity pool
    [WebMethod]
    public DataTable Ble_Get_Activities_db(int companyId, int blendedId, string selectedModules, string searchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Ble_Get_Activities(companyId, blendedId, selectedModules, searchText);
        return Dts;
    }


    //BLENDED ENHANCEMENT END
    // Start Adarsh

    //[WebMethod]
    //public DataTable report_refered_learng_course_asign_db(int P_Comp_ID, int traning_Id, int P_courseid)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.report_refered_lrng_corse_wise_asign_ser(P_Comp_ID, traning_Id, P_courseid);
    //}

    [WebMethod]
    public DataTable report_refered_learng_course_asign_db(int P_Comp_ID, int traning_Id, int P_courseid, int modeOfAssign)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_corse_wise_asign_ser(P_Comp_ID, traning_Id, P_courseid, modeOfAssign);
    }




    [WebMethod]
    public DataTable fetch_refered_course_list_db(int P_Comp_ID, int CourseId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_refered_course_list_ser(P_Comp_ID, CourseId);
    }

    [WebMethod]
    public DataTable report_refered_elrng_curse_wise_db(int P_Comp_ID, string from_date, string to_date, string philosophy, string department, string courseid, int cours_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_elearning_corse_wise_ser(P_Comp_ID, from_date, to_date, philosophy, department, courseid, cours_Id);
    }

    //[WebMethod]
    //public DataTable report_refered_learng_curse_wise_count_db(int P_Comp_ID, int P_courseid)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.report_refered_lrng_count_corse_wise_ser(P_Comp_ID, P_courseid);
    //}

    [WebMethod]
    public DataTable report_refered_learng_curse_wise_count_db(string fromDate, string toDate, string philosophy, string departments, string courseList, int companyId, int courseId, int modeOfAssign)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_count_corse_wise_ser(fromDate, toDate, philosophy, departments, courseList, companyId, courseId, modeOfAssign);
    }








    [WebMethod]
    public DataTable report_refered_learng_course_attended_db(int P_Comp_ID, int traning_Id, int P_courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_corse_wise_attended_ser(P_Comp_ID, traning_Id, P_courseid);
    }

    //[WebMethod]
    //public DataTable report_refered_complt_course_wise_db(int P_Comp_ID, int traning_Id, int P_courseid)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.report_refered_lrng_completed_course_wise_ser(P_Comp_ID, traning_Id, P_courseid);
    //}

    [WebMethod]
    public DataTable report_refered_complt_course_wise_db(int P_Comp_ID, int traning_Id, int P_courseid, int modeOfAssign)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_completed_course_wise_ser(P_Comp_ID, traning_Id, P_courseid, modeOfAssign);
    }

    [WebMethod]
    public DataTable report_refered_learng_course_notattended_db(int P_Comp_ID, int traning_Id, int P_courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_corse_wise_notattended_ser(P_Comp_ID, traning_Id, P_courseid);
    }

    [WebMethod]
    public DataTable report_refered_course_payed_db(int P_Comp_ID, int traning_Id, int P_courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_corse_wise_payed_ser(P_Comp_ID, traning_Id, P_courseid);
    }

    //[WebMethod]
    //public DataTable report_refered_pending_course_wise_db(int P_Comp_ID, int traning_Id, int P_courseid)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.report_refered_lrng_pending_course_wise_ser(P_Comp_ID, traning_Id, P_courseid);
    //}

    [WebMethod]
    public DataTable report_refered_pending_course_wise_db(int P_Comp_ID, int traning_Id, int P_courseid, int modeOfAssign)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_refered_lrng_pending_course_wise_ser(P_Comp_ID, traning_Id, P_courseid, modeOfAssign);
    }


    [WebMethod]

    public DataTable fetch_department_list_db(int P_Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_department_list_ser(P_Comp_ID);
    }

    [WebMethod]
    public DataTable fetch_course_list_db(int P_Comp_ID, int CourseId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_course_list_ser(P_Comp_ID, CourseId);
    }

    [WebMethod]

    public DataTable report_self_elrng_curse_wise(int P_Comp_ID, string from_date, string to_date, string philosophy, string department, string courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_self_elrng_corse_wise(P_Comp_ID, from_date, to_date, philosophy, department, courseid);
    }

    [WebMethod]

    public DataTable report_self_vilt_curse_wise_db(int P_Comp_ID, string from_date, string to_date, string philosophy, string department, string courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_self_lrng_vilt_corse_wise_ser(P_Comp_ID, from_date, to_date, philosophy, department, courseid);
    }

    [WebMethod]

    public DataTable report_self_ilt_curse_wise_db(int P_Comp_ID, string from_date, string to_date, string philosophy, string department, string courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_self_learng_ilt_corse_wise_ser(P_Comp_ID, from_date, to_date, philosophy, department, courseid);
    }

    [WebMethod]
    public DataTable report_self_blended_curse_wise_db(int P_Comp_ID, string from_date, string to_date, string philosophy, string department, string courseid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_self_learng_blnded_corse_wise_ser(P_Comp_ID, from_date, to_date, philosophy, department, courseid);
    }

    [WebMethod]
    public DataTable report_self_lrng_curse_wise_count_db(int P_Comp_ID, int P_courseid, string P_From_date, string P_To_date, string p_department)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.report_self_lrng_count_corse_wise_ser(P_Comp_ID, P_courseid, P_From_date, P_To_date, p_department);
    }

    [WebMethod]
    public DataTable Report_self_lern_indvidual_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_self_lrng_idvdl_report_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_self_lern_vilt_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_self_lrng_vilt_idvdl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_self_lern_ilt_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_self_lrng_ilt_idvdl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_self_lern_blend_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_Self_lrng_blnded_indvl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_refer_lern_indvidual_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_refer_lrng_idvdl_report_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_refer_lern_vilt_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_refer_lrng_vilt_idvdl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_refer_lern_ilt_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_refer_lrng_ilt_idvdl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_refer_lern_blend_indl_admin_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_refer_lrng_blnded_indvl_admin_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }
    [WebMethod]
    public DataTable elearning_ProctoringReport_db(int company_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.elearning_ProctoringReport_ser(company_id);

    }

    [WebMethod]
    public DataTable Survey_Dashboard_Counts_User_DB(int CMPID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_Counts_User(CMPID, UserID);
        return Dts;
    }

    [WebMethod]
    public DataTable Survey_Dashboard_TopTrend_User_db(int CMPID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_TopTrend_User(CMPID, UserID);
        return Dts;
    }

    [WebMethod]
    public DataTable Survey_Dashboard_TopTrend_Quest_User_db(int CMPID, string UserID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Survey_Dashboard_TopTrend_Quest_User(CMPID, UserID);
        return Dts;
    }


    [WebMethod]
    public DataTable Report_poll_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_poll_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public DataTable Report_poll_details_db(int P_Comp_ID, int P_Fetch_count, int Min_count, int poll_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_poll_details_ser(P_Comp_ID, P_Fetch_count, Min_count, poll_Id);
    }

    [WebMethod]
    public DataTable Report_survey_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_survey_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public DataTable Report_survey_details_db(int P_Comp_ID, int P_Fetch_count, int Min_count, int surveyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_Survy_details_ser(P_Comp_ID, P_Fetch_count, Min_count, surveyId);
    }

    [WebMethod]
    public string fetch_survy_notif_complete(int serv_id, string user_id, int compnyid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_srvy_notify_complete(serv_id, user_id, compnyid);
    }

    [WebMethod]
    public DataTable Report_self_lrng_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_self_lerng_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public DataTable Report_synchro_details_db(int P_Comp_ID, int P_Fetch_count, int Min_count, int content_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_Synchro_details_ser(P_Comp_ID, P_Fetch_count, Min_count, content_Id);
    }

    [WebMethod]
    public DataTable Report_synchronous_con(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_synchro_learning_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public DataTable Report_exam_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_exam_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }


    [WebMethod]
    public DataTable Report_exam_details_db(int P_Comp_ID, int P_Fetch_count, int Min_count, int exam_crid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_exam_details_ser(P_Comp_ID, P_Fetch_count, Min_count, exam_crid);
    }
    [WebMethod]
    public string Survey_Admin_Delete_Survey_db(int compnyId, int module_ID, int Delete_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Survey_Admin_Delete_Survey(compnyId, module_ID, Delete_ID);
    }
    [WebMethod]
    public DataTable Admin_srvey_QusList_db(int P_CompanyId, int P_module_type, int P_surveyid)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Admin_srvey_QusList(P_CompanyId, P_module_type, P_surveyid);
        return Dts;
    }​​​​​​​


            [WebMethod]

    public DataTable fetch_srvy_reportuser_count_con(int CompID, int moduleid, int servy_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_srvy_reportuser_count_ser(CompID, moduleid, servy_id);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_survy_question_count_db(int CompID, int moduleid, int servy_id, string userId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_srvy_total_quest_count_ser(CompID, moduleid, servy_id, userId);
        return Dts;
    }

    [WebMethod]
    public DataTable srvy_Qus_report_db(int P_Comp_ID, int P_module_ID, int P_survey_id, int P_Qus_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.srvy_Qus_report(P_Comp_ID, P_module_ID, P_survey_id, P_Qus_id);
    }

    [WebMethod]
    public DataTable srvy_Fetch_all_Qus_db(int P_Comp_ID, int P_module_ID, int P_survey_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.srvy_Fetch_all_Qus(P_Comp_ID, P_module_ID, P_survey_id);
    }

    [WebMethod]
    public string srvey_usr_trk_dtails_update_con(int srvy_id, string user_id, int compId, int modulId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.srvey_usr_trk_dtl_updt_ser(srvy_id, user_id, compId, modulId);
    }

    [WebMethod]
    public DataTable Report_Ilt_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_Ilt_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public DataTable Report_Vilt_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_Vilt_ser(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }


    [WebMethod]
    public string synchro_content_insert(int training_id, string content_title, string content_discrib, string create_date, string created_by, int status, int company_id, string Sync_audi)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.shync_lrn_cont_insrt(training_id, content_title, content_discrib, create_date, created_by, status, company_id, Sync_audi);
    }
    [WebMethod]
    public string synchro_insert_question(int traing_id, int qust_type, string question, int status, int company_id, int contenid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.synchro_question_insert(traing_id, qust_type, question, status, company_id, contenid);
    }
    [WebMethod]
    public string synchro_insert_question_option(int op_syncro_qust_id, string op_options, string op_currect_answer, string op_mode_of_option, string op_matching_answers, string op_attend_date, int op_status, int op_company_id, int op_usr_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.synchro_quest_option(op_syncro_qust_id, op_options, op_currect_answer, op_mode_of_option, op_matching_answers, op_attend_date, op_status, op_company_id, op_usr_id);
    }

    [WebMethod]
    public string synchro_insert_audience(int training_id, string audience_code, string created_by, int status, int company_id, int content_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.synchro_audience_insert(training_id, audience_code, created_by, status, company_id, content_ID);
    }
    [WebMethod]
    public string synchro_insert_usertrack(int traing_id, int questnId, string user_Id, string ans_opt_id, string atten_date, string attn_status, string exam_result, string created_by, int comp_id, int contntId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.synchro_usertrak_insert(traing_id, questnId, user_Id, ans_opt_id, atten_date, attn_status, exam_result, created_by, comp_id, contntId);
    }
    [WebMethod]
    public DataTable fetch_syncro_content(int compn_id, int trainingId, int contentid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.synchro_fetch_content(compn_id, trainingId, contentid);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_User_track_content_db(int compn_id, string user_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_User_track_content(compn_id, user_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable qst_QPQ_File_Details_db(string flt)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.qst_QPQ_File_Details(flt);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_synchro_question(int compn_id, int trainingId, int contentId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.synchro_fetch_question(compn_id, trainingId, contentId);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_quest_options(int comp_id, int question_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.synchro_fetch_qstoption(comp_id, question_id);
        return Dts;
    }
    //EXTERNAL EXAM PERSONAL DETAILS

    //[WebMethod]
    //public DataTable exam_external_fetch_quali_db(int comp_id)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.exam_external_fetch_quali(comp_id);
    //    return Dts;
    //}

    //[WebMethod]
    //public DataTable exam_external_fetch_stream_db(int comp_id, int quali_id)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.exam_external_fetch_stream(comp_id, quali_id);
    //    return Dts;
    //}

    //[WebMethod]
    //public DataTable exam_external_fetch_state_db(int comp_id, string search_text)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.exam_external_fetch_state(comp_id, search_text);
    //    return Dts;
    //}
    [WebMethod]
    public DataTable Get_Exam_Percentage_db(int COMPID, string Stdate, string EndDate, int type)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Exam_Percentage(COMPID, Stdate, EndDate, type);
        return Dts;
    }
    //[WebMethod]
    //public string exam_external_update_user_dlts_db(int COMP_ID, string name, int age, int gender, string mob, string email, string aadhar, string address_1, string address_2, int pin_code, string district, string state, string postoffice, string thaluk, string qualification, string stream, string college, string university, int year, string job_location, string user_id)
    //{
    //    string str;
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    str = sercon.exam_external_update_user_dlts(COMP_ID, name, age, gender, mob, email, aadhar, address_1, address_2, pin_code, district, state, postoffice, thaluk, qualification, stream, college, university, year, job_location, user_id);
    //    return str;
    //}


    [WebMethod]
    public DataTable synchro_quest_type_fetch(int companyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_synchro_qust_type(companyId);
        return Dts;
    }
    // End Adarsh
    // SUDHEV

    [WebMethod]
    public DataTable Preview_Individual_EL_Report_db(string CompID, string FromDate, string ToDate, string EMPCODE)//preview User Exam Details
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Preview_Individual_EL_Report(CompID, FromDate, ToDate, EMPCODE);
        return Dts;
    }

    [WebMethod]
    public DataTable COURSE_WISE_DTL_EL_db(int P_Comp_ID, int Traing_id, int Type_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.COURSE_WISE_DTL_EL(P_Comp_ID, Traing_id, Type_id);
    }
    [WebMethod]
    public DataTable COURSE_WISE_EL_db(string P_From_date, string P_To_date, int P_Comp_ID, string Course, string Phylo)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.COURSE_WISE_EL(P_From_date, P_To_date, P_Comp_ID, Course, Phylo);
    }





    [WebMethod]
    public DataTable FETCH_ALL_COURSE_DB(int COMPID, int Module_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.FETCH_ALL_COURSE(COMPID, Module_ID);
    }

    [WebMethod]
    public string Delete_Audience_Grp_db(int Comp_ID, int TrainingID, string Audi_str, string UsrID)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Delete_Audience_Grp(Comp_ID, TrainingID, Audi_str, UsrID);
        return str;
    }

    [WebMethod]
    public DataSet My_team_garph_db(string Start_date, string end_date, string type_foramte, string User_id, int comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.My_team_garph(Start_date, end_date, type_foramte, User_id, comp_id);
    }

    [WebMethod]
    public DataTable Report_Learning_db(string P_From_date, string P_To_date, int P_Comp_ID, string Deptname, string moduletype)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Report_Learning(P_From_date, P_To_date, P_Comp_ID, Deptname, moduletype);
    }


    [WebMethod]
    public DataTable CourseList_Not_attended_db(string UserId, int EmpCompId)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.CourseList_Not_attended(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataTable Fetch_Evaluation_details_db(string P_User_id, int CompID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Fetch_Evaluation_details(P_User_id, CompID);
        return Dts;
    }​​​​​​​

            [WebMethod]
    public string Competency_Add_new_db(int P_type, int P_status, int edit_id, string Name, string Company_name, int CompID)
    {​​​​​​​
            System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Competency_Add_new(P_type, P_status, edit_id, Name, Company_name, CompID);
    }​​​​​​​
            [WebMethod]
    public DataTable Proc_madu_Competency_list_db(int P_type, int CompID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Proc_madu_Competency_list(P_type, CompID);
        return Dts;
    }​​​​​​​


            [WebMethod]
    public string Audience_Selected_edit_db(int CompId, string Audi_code)
    {​​​​​​​
            System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Audience_Selected_edit(CompId, Audi_code);
    }​​​​​​​
            [WebMethod]
    public DataTable Audience_Sel_Audi_list_db(int CompID, string Audi_list, int P_type, string Audi_code)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Audience_Sel_Audi_list(CompID, Audi_list, P_type, Audi_code);
        return Dts;
    }​​​​​​​

            [WebMethod]
    public DataTable Audience_Sub_catogery_db(int CompID, int Main_cat)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Audience_Sub_catogery_db(CompID, Main_cat);
        return Dts;
    }​​​​​​​

            [WebMethod]
    public DataTable Audience_Main_catogery_db(int CompID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Audience_Main_catogery(CompID);
        return Dts;
    }​​​​​​​

            [WebMethod]
    public DataTable My_Rank_List_db(string UserID, int CompID, int P_Type)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.My_Rank_List(UserID, CompID, P_Type);
        return Dts;
    }​​​​​​​
    [WebMethod]
    public DataTable Track_menu_name_db(int SubMenuID, string CompID, string RoleID, int PlanID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Track_menu_name(SubMenuID, CompID, RoleID, PlanID);
        return Dts;
    }
    [WebMethod]
    public DataTable My_Team_List_db(string UserID, int CompID)
    {​​​​​​​
            DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.My_Team_List(UserID, CompID);
        return Dts;
    }​​​​​​​
    [WebMethod]
    public DataSet selflearning_count_percentage_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.selflearning_count_percentage(UserId, EmpCompId);
        return dts;
    }
    [WebMethod]
    public DataTable Get_Exam_Individual_Percentage_db(int COMPID, string Stdate, string EndDate, string EMPCODE)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Exam_Individual_Percentage(COMPID, Stdate, EndDate, EMPCODE);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Exam_wise_Percentage_db(int COMPID, string Stdate, string EndDate, string Philos, string Exa2, int type)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Exam_wise_Percentage(COMPID, Stdate, EndDate, Philos, Exa2, type);
        return Dts;
    }

    ///Adasrsh
        [WebMethod]
    public DataSet ILT_report_datas_db(int EmpCompId, string UserId, int trng_id, string philosophy, string start_date, string end_date)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.ILT_report_datas(EmpCompId, UserId, trng_id, philosophy, start_date, end_date);
        return dts;
    }

    [WebMethod]
    public DataSet ILT_user_wise_report_db(int EmpCompId, string UserId, int trng_id, string philosophy, string start_date, string end_date,
    int type, int mod_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.ILT_user_wise_report(EmpCompId, UserId, trng_id, philosophy, start_date, end_date, type, mod_id);
        return dts;
    }

    [WebMethod]
    public DataTable Report_blnded_indvidual_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_blnded_indvidual_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_elearn_indvidual_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_elearn_indvidual_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }

    [WebMethod]
    public DataTable Report_vilt_indvidual_db(string P_From_date, string P_To_date, int P_Comp_ID, string P_userId, string philosophy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Report_vilt_indvidual_ser(P_From_date, P_To_date, P_Comp_ID, P_userId, philosophy);
    }
    ///end Adarsh

    [WebMethod]
    public DataTable DashBoard_Area_Attribute_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon.DashBoard_Area_Attribute(Comp_id, UserID); ;
    }

    [WebMethod]
    public DataTable DashBoard_Area_Intrest_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.DashBoard_Area_Intrest(Comp_id, UserID); ;
    }

    [WebMethod]
    public DataTable DashBoard_Area_Skills_db(int Comp_id, string UserID)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon.DashBoard_Area_Skills(Comp_id, UserID); ;
    }

    [WebMethod]
    public DataTable My_user_Rank_List_db(string UserID, int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.My_user_Rank_List(UserID, CompID);
        return Dts;
    }

  
    [WebMethod]
    public DataSet UsermainRpt_GraphData_Content_db(int companyId, string UserID, string gblDateFormat, string startDate, string endDate)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.UsermainRpt_GraphData_Content(companyId, UserID, gblDateFormat, startDate, endDate);
        return ds;
    }

    [WebMethod]
    public DataSet UsermainRpt_GraphData_db(int companyId, string UserID, string gblDateFormat, string startDate, string endDate)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.UsermainRpt_GraphData(companyId, UserID, gblDateFormat, startDate, endDate);
        return ds;
    }

  

    [WebMethod]
    public DataSet UsermainRpt_GraphData_eLearning_db(int companyId, string UserID, string gblDateFormat, string startDate, string endDate)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.UsermainRpt_GraphData_eLearning(companyId, UserID, gblDateFormat, startDate, endDate);
        return ds;
    }

    //[WebMethod]
    //public DataTable Survey_Audiance_db(int COMPY_ID, string Search_txt)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.Survey_Audiance(COMPY_ID, Search_txt);
    //}
    //[WebMethod]
    //public DataTable Search_Pool_questn_pool_db(int comp_Id, int module_type, int Cat_Type, int Qus_type, string Search_text)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.Search_Pool_questn_pool(comp_Id, module_type, Cat_Type, Qus_type, Search_text);
    //}
    [WebMethod]
    public DataTable MaduCookiesDetails_db(string UserId, int CompanyID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.MaduCookiesDetails(UserId, CompanyID);
        return Dts;
    }
    [WebMethod]
    public DataTable AcceptMaduDetails_db(string UserId, int CompanyID, int AcceptType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AcceptMaduDetails(UserId, CompanyID, AcceptType);
        return Dts;
    }
    [WebMethod]
    public DataSet UsermainRpt_GraphData_Personal_db(int companyId, string UserID)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.UsermainRpt_GraphData_Personal(companyId, UserID);
        return ds;
    }

   
    [WebMethod]
    public DataSet LearningRpt_GraphData_db(int companyId, string gblDateFormat, string startDate, string endDate)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.LearningRpt_GraphData(companyId, gblDateFormat, startDate, endDate);
        return ds;
    }

    [WebMethod]
    public DataSet LearningRpt_StaticData_db(int companyId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.LearningRpt_StaticData(companyId);
        return ds;
    }

  

    [WebMethod]

    public DataTable compet(int comp_id, string start_date, string end_date)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.completion_due_counts(comp_id, start_date, end_date);
    }

    [WebMethod]
    public DataSet ilt_course_wise_report_db(string start_date, string end_date, string philosophy, string training, int cmp_id, int type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_course_wise_report(start_date, end_date, philosophy, training, cmp_id, type);
    }

    [WebMethod]
    public DataTable Get_All_Trng_List_db(int COMPID, int Module_ID, string Stdate, string EndDate, string priority, string TrngID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_All_Trng_List(COMPID, Module_ID, Stdate, EndDate, priority, TrngID);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Trng_Percentage_db(int COMPID, int Module_ID, string Stdate, string EndDate, int type, string TrngID, string Priority)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Trng_Percentage(COMPID, Module_ID, Stdate, EndDate, type, TrngID, Priority);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_VILT_USER_STATUS_db(int COMPID, int Module_ID, int TrngID, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_VILT_USER_STATUS(COMPID, Module_ID, TrngID, status);
        return Dts;
    }

    //[WebMethod]
    //public DataSet ilt_course_wise_report_db(string start_date, string end_date, string philosophy, string training, int cmp_id, int type)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.ilt_course_wise_report(start_date, end_date, philosophy, training, cmp_id, type);
    //}

    [WebMethod]
    public DataTable Get_BLENDED_USER_STATUS_db(int COMPID, int Module_ID, int TrngID, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_BLENDED_USER_STATUS(COMPID, Module_ID, TrngID, status);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Report_Course_List(int P_Comp_ID, int CourseId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Report_Course_List(P_Comp_ID, CourseId);
        return Dts;
    }

    //[WebMethod]

    //public DataTable get_zone_name_db(string comp_id)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

    //    return sercon.get_zone_name(comp_id);
    //}
    //[WebMethod]

    //public DataTable Overdue_courses_db(int comp_id, string start_date, string end_date)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

    //    return sercon.Overdue_courses(comp_id, start_date, end_date);
    //}

    //[WebMethod]

    //public DataTable completion_zone_db(int comp_id, string start_date, string end_date, int zone_id)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

    //    return sercon.completion_zone(comp_id, start_date, end_date, zone_id);
    //}

    [WebMethod]
    public DataSet ILT_session_report_datas_db(int EmpCompId, string UserId, int trng_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.ILT_session_report_datas(EmpCompId, UserId, trng_id);
        return dts;
    }
    [WebMethod]
    public DataTable Profile_Bind_ongoing_Exam_Details_db(string CMP_ID, string UsrID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_ongoing_Exam_Details(CMP_ID, UsrID);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_attendence_datas_db(int training_id, int course_id, int cmpid, int sess_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return Dts = sercon.fetch_attendence_datas(training_id, course_id, cmpid, sess_id);
    }



    [WebMethod]
    public DataTable My_Mob_Rank_List_db(string UserID, int CompID, int P_Type, int Inital_val)
    {​​​​​​​
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.My_Mob_Rank_List(UserID, CompID, P_Type, Inital_val);
        return Dts;
    }​​​​​​​

    

    [WebMethod]
    public string refer_Cousre_new_db(int tr_id, string ref_id, string userId, int CompId)
    {​​​​​​​
            string result = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        result = sercon.refer_Cousre_new(tr_id, ref_id, userId, CompId);
        return result;
    }​​​​​​​
     [WebMethod]
    public DataSet refer_friend_users_db(int EmpCompId, int trainingid, string searchtext)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.refer_friend_users(EmpCompId, trainingid, searchtext);
        return dts;
    }

    [WebMethod]
    public DataTable Self_REQUEST_DETAILS_db(string UserID, int CompID, int P_type, int P_Status, int Course_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Self_REQUEST_DETAILS(UserID, CompID, P_type, P_Status, Course_id);
        return Dts;

    }


    [WebMethod]
    public string Self_Status_update_db(string Status_list, int P_Status, int P_Comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Self_Status_update(Status_list, P_Status, P_Comp_id);
    }

    [WebMethod]
    public string Madu_Training_tran_Stat_db(string trid, string usr_id, string resps, string payuid, string bnkid, string psts, Int64 Track_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;


        return sercon.Madu_Training_tran_Stat(trid, usr_id, resps, payuid, bnkid, psts, Track_ID);

    }
    [WebMethod]
    public string Madu_Training_Tran_db(string trid, string CmpID, string usr_id, string usernm, string mob, string mail, string pay_md, string Tran_PAYID, int Track_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_Training_Tran(trid, CmpID, usr_id, usernm, mob, mail, pay_md, Tran_PAYID, Track_ID);

    }
    [WebMethod]
    public string Profile_update_db(string User_id, int Comp_id, string Photoname, string Email, string Contact, string WhatsAppNumber)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Profile_update(User_id, Comp_id, Photoname, Email, Contact, WhatsAppNumber);

    }

    [WebMethod]
    public DataTable Get_Login_Report_db(int companyId, int reportType, int reportOutType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Login_Report(companyId, reportType, reportOutType);
        return Dts;
    }

    [WebMethod]
    public DataTable Insert_Training_payment_Insert_db(string CompID, string UserID, int track_ID, int training_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        Dts = sercon.Insert_Training_payment_Insert(CompID, UserID, track_ID, training_id);
        return Dts;
    }



    [WebMethod]
    public string Resume_update_db(string User_id, int Comp_id, string Photoname, string Email, string Contact, string About, string Philosaphy, string Ed_year, string Ed_course, string Ed_Univer, string Exp_year, string Exp_des, string Exp_Org, string AWD_year, string AWARD, string ACH_year, string Acheivments, string LER_year, string Learning, string Hobby_str)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Resume_update(User_id, Comp_id, Photoname, Email, Contact, About, Philosaphy, Ed_year, Ed_course, Ed_Univer, Exp_year, Exp_des, Exp_Org, AWD_year, AWARD, ACH_year, Acheivments, LER_year, Learning, Hobby_str);
    }
    [WebMethod]
    public DataTable Resume_details_fetch_db(string UserID, int CompID)
    {
        DataTable ds = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Resume_details_fetch(UserID, CompID);
        return ds;
    }



    [WebMethod]
    public DataTable Get_Personal_details_db(string User_id, int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Personal_details(User_id, CompID);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_Grade_scale_list_db(int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Grade_scale_list(CompID);
        return Dts;
    }

    [WebMethod]
    public string Mark_grade_Inherit_db(int Grade_id, int CompID, string UserID, string company_name)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Mark_grade_Inherit(Grade_id, CompID, UserID, company_name);
    }
    [WebMethod]
    public DataTable fetch_Grade_scale_details_db(int Grade_id, int CompID)
    {
        DataTable ds = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.fetch_Grade_scale_details(Grade_id, CompID);
        return ds;
    }

    [WebMethod]
    public DataTable Exam_Selected_Review_method(int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Review_method(Exam_id);
        return Dts;
    }
    [WebMethod]
    public string Mark_grade_Delete_db(string Delete_str, int CompID, string UserID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Mark_grade_Delete(Delete_str, CompID, UserID);
    }
    [WebMethod]
    public string Mark_grade_update_db(int Grade_id, int Comp_id, string comp_name, string Grade_name, string Scale_Des, string Grade, string Mark, string Mark_Des, string User_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Mark_grade_update(Grade_id, Comp_id, comp_name, Grade_name, Scale_Des, Grade, Mark, Mark_Des, User_id);
    }


    [WebMethod]

    public DataTable Exam_Selected_Appover_Exam(int COMPY_ID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Appover_Exam(COMPY_ID, Exam_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Selected_Notific(int COMPY_ID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Notific(COMPY_ID, Exam_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Selected_Invigilator(int COMPY_ID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Invigilator(COMPY_ID, Exam_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Selected_Reviwer(int COMPY_ID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Reviwer(COMPY_ID, Exam_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Admin_Fetch(int Comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Admin_Fetch(Comp_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Crs_Topic_fetch(int Comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Crs_Topic_fetch(Comp_id);
        return Dts;
    }


    [WebMethod]
    public string Exam_Settings_Update(int EXAM_ID, int EXAM_METHOD, int PROCTOR_METHOD, int CRS_CATGY, int CRS_SUB_CATGY, int CRS_TYPE, int TRAINING_TYPE, string CRS_NAME, string CRS_DESCRIPTION, int PRORITY, int PASS_PERCENT, int GRD_SCALE_ID, int ATTEMPT_AVAILABLE, string EXAM_START_DATE, string EXAM_END_DATE, string EXAM_START_TIME, string EXAM_END_TIME, string VENU, string duration, int Date_set, int Expire_duration, int Expire_formate, int reviewExpiry)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_Settings_Update(EXAM_ID, EXAM_METHOD, PROCTOR_METHOD, CRS_CATGY, CRS_SUB_CATGY, CRS_TYPE, TRAINING_TYPE, CRS_NAME, CRS_DESCRIPTION, PRORITY, PASS_PERCENT, GRD_SCALE_ID, ATTEMPT_AVAILABLE, EXAM_START_DATE, EXAM_END_DATE, EXAM_START_TIME, EXAM_END_TIME, VENU, duration, Date_set, Expire_duration, Expire_formate, reviewExpiry);
    }
    [WebMethod]
    public string Exam_Settings_Update2(int EXAM_ID, string certificate, int topic, string Created_by, int Revaluvation_value, int payment_1, int payment_2, int Audi_type, string AnsViewType, int Noof1RevaluationCheck, int Noof1RevaluationApply, int Noof2RevaluationCheck, int Noof2RevaluationApply)//, 
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_Settings_Update2(EXAM_ID, certificate, topic, Created_by, Revaluvation_value, payment_1, payment_2, Audi_type, AnsViewType, Noof1RevaluationCheck, Noof1RevaluationApply, Noof2RevaluationCheck, Noof2RevaluationApply);//, 
    }

    [WebMethod]
    public DataTable Selected_Feedback_qus(int COMPY_ID, int Mapping, int module)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Selected_Feedback_qus(COMPY_ID, Mapping, module);
        return Dts;
    }


    [WebMethod]
    public DataSet UserLoginSessions_Exter_exam_db(string Username, string Password, string SessionId, string HostName, string IpAddress, string MacId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UserLoginSessions_EXTER_EXAM(Username, Password, SessionId, HostName, IpAddress, MacId);
    }

    [WebMethod]
    public DataTable AUDI_EXAM_FETCH_EX_DB(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AUDI_EXAM_FETCH_EX(COMPY_ID);
        return Dts;
    }

    [WebMethod]
    public string INS_AUDI_EXAM_EXTERNAL_DB(int examid, string name, string email, string phone, int compid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_AUDI_EXAM_EXTERNAL(examid, name, email, phone, compid);
    }

    [WebMethod]
    public string Exam_Settings_Update5(int EXAM_ID, int Is_reuseable, int Preview_method, string Preview_Time, int page_status)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_Settings_Update5(EXAM_ID, Is_reuseable, Preview_method, Preview_Time, page_status);
    }

    [WebMethod]
    public string Online_Exam_insert(int EXAM_MTD, int PROCTOR_MTD, int CRS_CATRY, int CRS_SUB_CATRY, int CRS_TYPE, int TRAINING_TYPE, string CRS_DESCRIPTION, int PRORITY, string EXAM_CODE, string EXAM_STATUS, int COMP_ID, int PASS_PERCENTAGE, int GRADE_SCALE, string CREATED_BY, string CREATED_ON, int ATTEMPT, string VENU, string CRS_NAME, string START_DATE, string END_DATE, string START_TIME, string END_TIME, int Course_ID, string duration, int Date_set, int Expire_duration, int Expire_formate, int reviewExpiry)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Online_Exam_insert(EXAM_MTD, PROCTOR_MTD, CRS_CATRY, CRS_SUB_CATRY, CRS_TYPE, TRAINING_TYPE, CRS_DESCRIPTION, PRORITY, EXAM_CODE, EXAM_STATUS, COMP_ID, PASS_PERCENTAGE, GRADE_SCALE, CREATED_BY, CREATED_ON, ATTEMPT, VENU, CRS_NAME, START_DATE, END_DATE, START_TIME, END_TIME, Course_ID, duration, Date_set, Expire_duration, Expire_formate, reviewExpiry);
    }

    [WebMethod]
    public DataTable menu_exm_mstr_fetch_ser(int Comp_id, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.menu_exm_mstr_fetch_ser(Comp_id, Exam_id);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_course_category_list(int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_course_category(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_course_sub_catgry_id(int Comp_ID, int course_categ_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_course_sub_category_by_id(Comp_ID, course_categ_id);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_course_list(int COMPY_ID, int CATR_ID, int SUB_CATRY, int CRS_TYP)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_course_list(COMPY_ID, CATR_ID, SUB_CATRY, CRS_TYP);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_course_details(int COMPY_ID, int TRNG_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_course_details(COMPY_ID, TRNG_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_course_Type(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_course_type(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_Exam_Notif_type(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Exam_Notif_type(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_Feedback_qus(int COMPY_ID, int ModUle)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Feedback_qus(COMPY_ID, ModUle);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_Grade_scale_type(int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Grade_scale_type(CompID);
        return Dts;
    }

    [WebMethod]

    public DataTable fetch_Training_type(int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Training_type(CompID);
        return Dts;
    }



    [WebMethod]
    public string EXAM_REVIEW_METHOD(int Exam_Id, int METHOD_ID_A, int MAIN_PER, int ASSISTANT_1_PER, int ASSISTANT_2_PER, string SPECIFIED_REVIWER_NAME)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.EXAM_REVIEW_METHOD(Exam_Id, METHOD_ID_A, MAIN_PER, ASSISTANT_1_PER, ASSISTANT_2_PER, SPECIFIED_REVIWER_NAME);
    }


    [WebMethod]
    public string AUDI_EXAM_USERTRACK_add(string QRY, string exam_code)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.AUDI_EXAM_USERTRACK_add(QRY, exam_code);
    }

    [WebMethod]
    public DataTable AUDI_EXAM_QUERY(string Audi_code)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AUDI_EXAM_QUERY(Audi_code);
        return Dts;
    }
    [WebMethod]
    public DataTable AUDI_EXAM_FETCH(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AUDI_EXAM_FETCH(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable REVIEWR_fetch(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.REVIEWR_fetch(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Approver_Exam_fetch(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Approver_Exam_fetch(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Invigilator_fetch(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Invigilator_fetch(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public DataTable Certificate_fetch(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Certificate_fetch(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public string INS_AUDI_EXAM(int examid, string Audi, string createdby, string createddate, int compid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_AUDI_EXAM(examid, Audi, createdby, createddate, compid);
    }
    [WebMethod]
    public string INS_REVIEWER_EXAM(int examid, string username, string Role, string created, string Review_date, string created_on, int compid, string reviewid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_REVIEWER_EXAM(examid, username, Role, created, Review_date, created_on, compid, reviewid);
    }
    [WebMethod]
    public string INS_Approver_EXAM(int examid, string username, string created, string Created_On, int Comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Approver_EXAM(examid, username, created, Created_On, Comp_id);
    }
    [WebMethod]
    public string INS_Feedback_qus(int examid, string feedbakstr, string created, int module, int Comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Feedback_qus(examid, feedbakstr, created, module, Comp_id);
    }
    [WebMethod]
    public string INS_INVIGILATOR_EXAM(int examid, string username, string Role, string created, string Review_date, string created_on, int compid, string invigId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_INVIGILATOR_EXAM(examid, username, Role, created, Review_date, created_on, compid, invigId);
    }
    [WebMethod]
    public string INS_Notifi_EXAM(int examid, string Type, string mode, string interval, string start_date, string End_date, string Time1, string Time2, int Auto, int Comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.INS_Notifi_EXAM(examid, Type, mode, interval, start_date, End_date, Time1, Time2, Auto, Comp_id);
    }
    [WebMethod]
    public DataTable Exam_Code_Fetch(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Code_Fetch(COMPY_ID);
        return Dts;
    }
    [WebMethod]
    public string Exam_course_Update(int Examid, string Examcode, int grade, int Certificate, int passpercent, int audience, int product, int traingid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_course_Update(Examid, Examcode, grade, Certificate, passpercent, audience, product, traingid);
    }
    [WebMethod]
    public DataTable fetch_certificate_byname(int Compny_Id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_certificate_byname_ser(Compny_Id);
        return Dts;
    }
    [WebMethod]
    public DataTable AUDI_RULE_fetch_con()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.AUDI_RULE_fetch_ser();
        return Dts;
    }
    [WebMethod]
    public DataTable profile_Fetch_sel_Exam_details(int CompID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.profile_Fetch_sel_Exam_details(CompID, Exam_id);
        return Dts;
    }
    //12-12-2020
    [WebMethod]
    public DataTable User_Attended_exam_Details_db(int CompID, int Exam_id, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.User_Attended_exam_Details(CompID, Exam_id, user_id);
        return Dts;
    }

    [WebMethod]
    public string Exam_User_Track_Ins_db(int examid, string user_Id, int comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_User_Track_Ins(examid, user_Id, comp_id);
    }
    [WebMethod]
    public string Exam_User_Answer_sheet_Ins_db(int examid, string user_Id, int comp_id, int track_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_User_Answer_sheet_Ins(examid, user_Id, comp_id, track_id);
    }

    [WebMethod]
    public DataTable Exam_Answer_sheet_preview_db(int CompID, int Exam_id, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Answer_sheet_preview(CompID, Exam_id, user_id);
        return Dts;
    }
    [WebMethod]
    public DataTable Exam_Answer_sheet_pattern_db(int CompID, int Exam_id, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Answer_sheet_pattern(CompID, Exam_id, user_id);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_user_track_details_db(int Comp_ID, int Track_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_user_track_details(Comp_ID, Track_ID);
        return Dts;
    }

    [WebMethod]
    public DataTable Exam_Answer_sheet_Review_db(int Track_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Answer_sheet_Review(Track_ID);
        return Dts;
    }
    [WebMethod]
    public string Exam_Answer_sheet_Review_Update_db(int Track_ID, string Qus_Str, string Comment_Str, string Pos_Mark_Str, string Neg_Mark_Str, string User_id, int Exam_Id, int Comp_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Exam_Answer_sheet_Review_Update(Track_ID, Qus_Str, Comment_Str, Pos_Mark_Str, Neg_Mark_Str, User_id, Exam_Id, Comp_ID);
    }

    [WebMethod]
    public string Proctoring_image_ins_db(int exam_id, int comp_id, string user_id, string face_img, string cardimg, int action)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Proctoring_image_ins(exam_id, comp_id, user_id, face_img, cardimg, action);
    }
    [WebMethod]
    public DataTable Insert_Revaluation_payment_Insert_db(string CompID, string UserID, int track_ID, int Rev_no, int exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        Dts = sercon.Insert_Revaluation_payment_Insert(CompID, UserID, track_ID, Rev_no, exam_id);
        return Dts;
    }

    [WebMethod]
    public string Madu_Revaluation_Tran_db(string trid, string CmpID, string usr_id, string usernm, string mob, string mail, string pay_md, string REV_PAYID, int Track_ID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Madu_Revaluation_Tran(trid, CmpID, usr_id, usernm, mob, mail, pay_md, REV_PAYID, Track_ID);

    }
    [WebMethod]
    public string Madu_Revaluation_tran_Stat_db(string trid, string usr_id, string resps, string payuid, string bnkid, string psts, int Track_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon.Madu_Revaluation_tran_Stat(trid, usr_id, resps, payuid, bnkid, psts, Track_ID);




    }
    //12-01-2021
    [WebMethod]
    public DataTable EXAM_COURSE_ID_FETCH_DB(int EXM_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.EXAM_COURSE_ID_FETCH(EXM_ID);
        return Dts;
    }
    //15-01-2021
    //[WebMethod]
    //public Course_all_details_db(int comp_id,string user_ID)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.Course_all_details(comp_id, user_ID);
    //    return Dts;
    //}

    //END SUDHEV

    //VISHNU START

    [WebMethod]
    public DataSet Get_Inst_poll_admin_db(int OrganizationId, int ModuleID, string SearchText, string FromDate, string ToDate)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_admin(OrganizationId, ModuleID, SearchText, FromDate, ToDate);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Inst_poll_admin_Details_db(int OrganizationId, int ModuleID, string SearchText, string FromDate, string ToDate, int TrngID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_admin_Details(OrganizationId, ModuleID, SearchText, FromDate, ToDate, TrngID);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Inst_poll_audience_Details_db(int OrganizationId, int ModuleID, string SearchText, int TrngID, int InstID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_audience_Details(OrganizationId, ModuleID, SearchText, TrngID, InstID);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Inst_poll_Question_Details_db(int OrganizationId, int ModuleID, string SearchText, int TrngID, int InstID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_Question_Details(OrganizationId, ModuleID, SearchText, TrngID, InstID);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Inst_poll_qns_res_users_db(int OrganizationId, int ModuleID, string SearchText, int QnsID, int InstID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_qns_res_users(OrganizationId, ModuleID, SearchText, QnsID, InstID);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Inst_poll_qns_res_answers_db(int OrganizationId, int ModuleID, string SearchText, int QnsID, int InstID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Inst_poll_qns_res_answers(OrganizationId, ModuleID, SearchText, QnsID, InstID);
        return Dts;
    }

    //new
    [WebMethod]
    public DataTable Get_Custom_Noti_temp_Audience_db(int OrganizationId, int NotiID, string Audicode)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Custom_Noti_temp_Audience(OrganizationId, NotiID, Audicode);
        return Dts;
    }
    [WebMethod]
    public string Create_Custom_noti_temp_db(string Notiname, string NotiType, string Stdate, string Enddate, string Content, string Subject, int perioday, int periohour, int periominute, string ModifiedBy, int CompnyID, string StrtTime)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Custom_noti_temp(Notiname, NotiType, Stdate, Enddate, Content, Subject, perioday, periohour, periominute, ModifiedBy, CompnyID, StrtTime);
    }
    [WebMethod]
    public string Create_Cus_audi_ruleset_db(int NotiID, int CompID, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Cus_audi_ruleset(NotiID, CompID, ModifiedBy);
    }
    [WebMethod]
    public DataTable Get_Custom_Noti_ruleset_db(int OrganizationId, int NotiID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Custom_Noti_ruleset(OrganizationId, NotiID);
        return Dts;
    }
    [WebMethod]
    public string Delete_Ruleset_db(int NotiID, string AudiCode, int CompID, int Type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Delete_Ruleset(NotiID, AudiCode, CompID, Type);
    }
    //new end

    [WebMethod]
    public string Create_Custom_notification_db(string Notiname, string NotiType, string Stdate, string Enddate, string Content, string Subject, int perioday, int periohour, int periominute, string ModifiedBy, int CompnyID, string StrtTime, int NotiID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Custom_notification(Notiname, NotiType, Stdate, Enddate, Content, Subject, perioday, periohour, periominute, ModifiedBy, CompnyID, StrtTime, NotiID);
    }

    [WebMethod]
    public string Custom_Noti_Audi_insert_db(int NotiID, int compny_id, string CustomaudioList, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Custom_Noti_Audi_insert(NotiID, compny_id, CustomaudioList, ModifiedBy);
    }
    [WebMethod]
    public DataTable Get_Custom_Notific_db(int OrganizationId, int CatId, int ActiveStatus, string Notitype, string SearchText, string FromDate, string ToDate)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Custom_Notific(OrganizationId, CatId, ActiveStatus, Notitype, SearchText, FromDate, ToDate);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Custom_Notific_Preview_db(int OrganizationId, int NotiID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Custom_Notific_Preview(OrganizationId, NotiID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Custom_Notific_Audience_db(int OrganizationId, int NotiID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Custom_Notific_Audience(OrganizationId, NotiID);
        return Dts;
    }
    [WebMethod]
    public string DeleteNotification_db(int Id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteNotification(Id, ModifiedBy);
    }

    [WebMethod]
    public string Update_Content_Duration_db(string ResourceID, int CompID, string UserID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Update_Content_Duration(ResourceID, CompID, UserID);
    }

    [WebMethod]
    public int Get_Datecompare_db(string StrtDate, string EndDate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        int count = 0;
        count = sercon.Get_Datecompare(StrtDate, EndDate);
        return count;
    }

    [WebMethod]
    public string Reset_Pswrd_OTP_Send_db(string OTP, string UserID, string CMP_ID, string type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Reset_Pswrd_OTP_Send(OTP, UserID, CMP_ID, type);
    }
    [WebMethod]
    public DataTable Get_User_ByID_db(string UserID, string Mobile, string Email, int type)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_User_ByID(UserID, Mobile, Email, type);
        return Dts;
    }

    [WebMethod]
    public string Change_Password_admin_db(string userID, string NewPassword, int CompanyID, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Change_Password_admin(userID, NewPassword, CompanyID, modifiedBy);
    }

    //FEEDBK
    [WebMethod]
    public DataTable Get_FeedaBack_Qst_MST_db(int company_id, int moduletype, int category, int Qus_type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Get_FeedaBack_Qst_MST(company_id, moduletype, category, Qus_type);
    }
    [WebMethod]
    public string DeleteFeedBkQns_db(int Id, string ModifiedBy, int cmpID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteFeedBkQns(Id, ModifiedBy, cmpID);
    }
    //FEEDBK
    //POLL NEW
    [WebMethod]
    public DataTable Poll_Dashboard_Counts_db(int CMPID) //Changed Questions Options insert Connection Service
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_Counts(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Poll_Dashboard_TopTrend_db(int CMPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_TopTrend(CMPID);
        return Dts;
    }
    [WebMethod]
    public DataTable Poll_Dashboard_TopTrend_Quest_db(int CMPID) //Changed Questions Options insert Connection Service
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_TopTrend_Quest(CMPID);
        return Dts;
    }
    //POLL NEW END 
    //MASTER
    [WebMethod]
    public string Insert_Category_Master_db(int Cattype, int CatID, string CatNAme, int status, string ModifiedBy, int CompnyID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Insert_Category_Master(Cattype, CatID, CatNAme, status, ModifiedBy, CompnyID);
    }

    [WebMethod]
    public string DeleteCategory_db(int Cattype, string QueryID, string ModifiedBy, int CmpID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteCategory(Cattype, QueryID, ModifiedBy, CmpID);
    }
    //END MASTER

    [WebMethod]
    public DataSet Get_ContentResource_db(int CategoryID, int UserType, int CompCode, int PlanCatID, int Language, string SearchText, string UserIDs)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Get_ContentResource(CategoryID, UserType, CompCode, PlanCatID, Language, SearchText, UserIDs);
    }


    [WebMethod]
    public string decypt_db(string passw)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.decrypt(passw);
    }
    [WebMethod]
    public DataTable Get_ContentResource_Search_db(int CategoryID, int UserType, int CompCode, int PlanCatID, int Language, string SearchText)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Get_ContentResource_Search(CategoryID, UserType, CompCode, PlanCatID, Language, SearchText);
    }
    [WebMethod]
    public DataTable get_path_con(int resid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.get_path_ser(resid);
        return Dts;
    }
    [WebMethod]
    public string GetPlanId_db(string UsrId, string Role_Id, string Comp_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetPlanId(UsrId, Role_Id, Comp_Id);
    }
    [WebMethod]
    public DataTable GetMenuName_db(int MenuId, string usrId, int CompCode, int RoleId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetMenuName(MenuId, usrId, CompCode, RoleId);
        return Dts;
    }
    //----admin--//
    [WebMethod]
    public DataTable Get_salutation_db(int companyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_salutation(companyId);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_UserJobType_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserJobType(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_UserJobType_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserJobType_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_UserAsgnmntStatus_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserAsgnmntStatus_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_UserLanguage_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserLanguage_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_AssgnStatus_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_AssgnStatus(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_UserLanguages_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserLanguages(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Designation_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Designations(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Grade_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Grade(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Post_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Post(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Designation_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Designation_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Grade_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Grade_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Post_idwise_db(string CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Post_idwise(CompID);
        return Dts;
    }
    [WebMethod]
    public string Create_UserJobType_db(string jobtypename, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_UserJobType(jobtypename, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string Create_AssgnStatus_db(string AsgnmntName, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_AssgnStatus(AsgnmntName, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string Create_UserLanguage_db(string AsgnmntName, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_UserLanguage(AsgnmntName, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string Create_Designation_db(string AsgnmntName, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Designation(AsgnmntName, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string Create_Grade_db(string AsgnmntName, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Grade(AsgnmntName, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string Create_Post_db(string AsgnmntName, string createdby, string modifiedby, string CompID, string code, int status, int createorupdate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Post(AsgnmntName, createdby, modifiedby, CompID, status, createorupdate, code);

    }
    [WebMethod]
    public string DeleteUserTypeById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteUserTypeById(id, ModifiedBy);
    }
    [WebMethod]
    public string DeleteAsgnmntStatusById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteAsgnmntStatusById(id, ModifiedBy);
    }
    [WebMethod]
    public string DeleteUserLanguageById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteUserLangById(id, ModifiedBy);
    }
    [WebMethod]
    public string DeleteDesignationById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteDesignationById(id, ModifiedBy);
    }
    [WebMethod]
    public string DeleteGradeById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteGradeById(id, ModifiedBy);
    }
    [WebMethod]
    public string DeletePostById_db(int id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeletePostById(id, ModifiedBy);
    }
    [WebMethod]
    public DataTable Get_AssgnStatus_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Asgnmntstatus_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_UserType_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_UserJobType_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Designation_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Designation_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Grade_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Grade_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Post_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Post_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Language_Active_db(string CompID, string SearchText)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Language_Active(CompID, SearchText);
        return Dts;
    }
    [WebMethod]
    public string CreateEmployee_db(int OrganizationId, int SubOrganizationId, int DepartmentId, int RoleId, int prefix, string FirstName, string MiddleName, string LastName, string Address, string PinCode, string EmployeeCode, int GenderId, int Title, int Grade, string DateOfJoining, string Mobile, string Email, string Password, int UserType, int AsgnmntStatus, int Language, int Designation, int UserStatus, string WorkEmail, string WorkMobile, int isinstructor, int isviewcmpnyusr, string DirectManager, string approver, int SubDept, int IsReviewer, int IsInvigilator, int IsTrainingCoordinator)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CreateEmployee(OrganizationId, SubOrganizationId, DepartmentId, RoleId, prefix, FirstName, MiddleName, LastName, Address, PinCode, EmployeeCode, GenderId, Title, Grade, DateOfJoining, Mobile, Email, Password, UserType, AsgnmntStatus, Language, Designation, UserStatus, WorkEmail, WorkMobile, isinstructor, isviewcmpnyusr, DirectManager, approver, SubDept, IsReviewer, IsInvigilator, IsTrainingCoordinator);
    }
    [WebMethod]
    public string UpdateEmployee_db(int OrganizationId, int SubOrganizationId, string DepartmentId, int RoleId, int prefix, string FirstName, string MiddleName, string LastName, string Address, string PinCode, string EmployeeCode, int GenderId, string Title, string Grade, string DateOfJoining, string Mobile, string Email, string Password, string UserType, string AsgnmntStatus, string Language, string Designation, int UserStatus, string WorkEmail, string WorkMobile, int isinstructor, int isviewcmpnyusr, string DirectManager, string approver, string SubDept, int IsReviewer, int IsInvigilator, int IsTrainingCoordinator)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateEmployee(OrganizationId, SubOrganizationId, DepartmentId, RoleId, prefix, FirstName, MiddleName, LastName, Address, PinCode, EmployeeCode, GenderId, Title, Grade, DateOfJoining, Mobile, Email, Password, UserType, AsgnmntStatus, Language, Designation, UserStatus, WorkEmail, WorkMobile, isinstructor, isviewcmpnyusr, DirectManager, approver, SubDept, IsReviewer, IsInvigilator, IsTrainingCoordinator);
    }
    [WebMethod]
    public DataTable Get_Employee_ByCmp_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Employee_ByCmp(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Employee_ByID_db(string CompID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Employee_ByID(CompID, UserID);
        return Dts;
    }
    [WebMethod]
    public string Create_Content_History_db(string ResourceID, string Title, string URL, int CompID, string UserID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_Content_History(ResourceID, Title, URL, CompID, UserID);

    }
    [WebMethod]
    public DataTable Get_ContentResource_ByID_db(int ResourceID, int CmpID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Get_ContentResource_ByID(ResourceID, CmpID);
    }
    [WebMethod]
    public DataSet GetSubDepartmentDetails_ByCode_db(int OrganizationId, string departmentid, string SearchText, string status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetSubDepartmentDetails_ByCode(OrganizationId, departmentid, SearchText, status);
    }
    //VISHNU END
    //ByAnjana//
    [WebMethod]
    public string Insert_ble_User_Certificate_db(int prm_user_track_id, string prm_user_id, int prm_comp_id, string prm_updateAction, string prm_pageMode, string prm_certificate_name, string prm_blendedid)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_ble_User_Certificate(prm_user_track_id, prm_user_id, prm_comp_id, prm_updateAction, prm_pageMode, prm_certificate_name, prm_blendedid);
        return str;
    }

    [WebMethod]
    public DataTable GetContentRequest_db(string UserId, string CmpId, string RoleId, string sortExpn, string filtertext, string filter1text, string filter2text, string searchtext)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetContentRequest(UserId, CmpId, RoleId, sortExpn, filtertext, filter1text, filter2text, searchtext);
    }

    [WebMethod]
    public string AddContentRequest_db(string Id, string contenReqNo, string req_Content, string description, string req_Priority, string url, string requestedUserId, string mobi, string mail, string companyId, string role_id, string contentCatType, string UpdateAction)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.AddContentRequest(Id, contenReqNo, req_Content, description, req_Priority, url, requestedUserId, mobi, mail, companyId, role_id, contentCatType, UpdateAction);

    }
    [WebMethod]
    public DataTable FetchContentCategoryType_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.FetchContentCategoryType();


    }
    [WebMethod]
    public string CheckChildMenu_db(String ParentId, String usr, string cmpnyId, String Role)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckChildMenu(ParentId, usr, cmpnyId, Role);

    }

    [WebMethod]
    public DataTable FetchPriorityDrp_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.FetchPriorityDrp();


    }

    [WebMethod]
    public string GetContentReqNo_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetContentReqNo();

    }



    [WebMethod]
    public DataTable GetUsrDetails_db(string UserId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetUsrDetails(UserId);

    }



    [WebMethod]
    public DataSet GetFaq_db(string usrId, int CompId, int role_Id, string searchcontent)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetFaq(usrId, CompId, role_Id, searchcontent);
    }

    //ByAnjana//
    //Dileep

    //Vilt new   
    [WebMethod]
    public DataSet Get_Vilt_Recorded_Session_db(int companyId, int courseId, int moduleId, string userId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Get_Vilt_Recorded_Session(companyId, courseId, moduleId, userId);
        return ds;
    }

    [WebMethod]
    public DataTable Get_CourseParticipants_Attendance_db(int companyId, int courseId, int moduleId, int filterAttendanceId, int filterCompleteStatus, string searchText)
    {
        DataTable dt = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dt = sercon.Get_CourseParticipants_Attendance(companyId, courseId, moduleId, filterAttendanceId, filterCompleteStatus, searchText);
        return dt;
    }

    //New
   

    [WebMethod]
    public string Update_VirtualCourse_Attendance_db(int courseId, int companyId, string selectedUserId, string operation, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Update_VirtualCourse_Attendance(courseId, companyId, selectedUserId, operation, userId);
    }

    [WebMethod]
    public DataTable Check_Course_Approve_Conditions_db(int courseId, int companyId, int moduleId, string userId)
    {
        DataTable dt = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dt = sercon.Check_Course_Approve_Conditions(courseId, companyId, moduleId, userId);
        return dt;
    }

    [WebMethod]
    public DataTable Get_DateTime_Now_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_DateTime_Now();
        return Dts;
    }

    //NEW
    //Dashboard Dileep Start  
    [WebMethod]
    public DataTable Profile_Bind_Instructor_Dtls_db(string companyId, string userId, string status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Profile_Bind_Instructor_Dtls(companyId, userId, status);
        return Dts;
    }
    [WebMethod]
    public DataSet Profile_Bind_Learng_TaskList_Count_db(string companyId, string userId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Profile_Bind_Learng_TaskList_Count(companyId, userId);
        return ds;
    }



    //Dashboard Dileep End

    //NEW
    //VILT Start

    [WebMethod]
    public string Vilt_Scheduled_Meeting_Cancel_db(int courseId, int companyId, string meetingKey, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Scheduled_Meeting_Cancel(courseId, companyId, meetingKey, userId);
    }
    [WebMethod]
    public string Vilt_Meeting_Updation_db(int courseId, int companyId, string hostCalendar, string userId, string attendeeCalendar)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Meeting_Updation(courseId, companyId, hostCalendar, userId, attendeeCalendar);
    }


    [WebMethod]
    public string Instructor_Crs_Start_db(int companyId, int courseId, int moduleId, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Instructor_Crs_Start(companyId, courseId, moduleId, userId);
    }

    //VILT End



    [WebMethod]
    public string Insert_User_Updates_db(int CatType, string date, string Description, string title, string Url, int status, string ModifiedBy, int CompnyID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Insert_User_Updates(CatType, date, Description, title, Url, status, ModifiedBy, CompnyID);
    }

    [WebMethod]
    public DataTable LatestDigitalUploads_db(string companyId, string planId, Int64 parentCat)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        Dts = sercon.LatestDigitalUploads(companyId, planId, parentCat);
        return Dts;
    }
    [WebMethod]
    public DataTable GetTopDigitalCategories_db(string companyId, string planId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        Dts = sercon.GetTopDigitalCategories(companyId, planId);
        return Dts;
    }
    [WebMethod]
    public DataTable GetCompanyDetails_db(int companyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetCompanyDetails(companyId);
        return Dts;
    }

    [WebMethod]
    public DataTable GetUpdates_db(int OrganizationId, int CatId, int ActiveStatus, string SearchText, string FromDate, string ToDate)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetUpdates(OrganizationId, CatId, ActiveStatus, SearchText, FromDate, ToDate);
        return Dts;
    }
    [WebMethod]
    public string InsertEmployee_db(int OrganizationId, int SubOrganizationId, int DepartmentId, int RoleId, string FirstName, string LastName, string Address, string PinCode, string EmployeeCode, int GenderId, string Title, string Grade, string DateOfJoining, string Mobile, string Email, string Password)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.InsertEmployee(OrganizationId, SubOrganizationId, DepartmentId, RoleId, FirstName, LastName, Address, PinCode, EmployeeCode, GenderId, Title, Grade, DateOfJoining, Mobile, Email, Password);
    }
    [WebMethod]
    public DataSet AdminMenus_db(string EmpCode, string EmpRoleId, string EmpUsername, string CompCode, string ParentId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetMenus(EmpCode, EmpRoleId, EmpUsername, CompCode, ParentId);
    }

    [WebMethod]
    public DataSet GetRoles_db(int CompanyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetRoles(CompanyId);
    }
    [WebMethod]
    public DataTable AllRoles_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetAllRoles();
    }
    [WebMethod]
    public DataSet AllForms_Db(int RoleId, int CompanyId, int UserType, int PlanCatId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetAllForms(RoleId, CompanyId, UserType, PlanCatId);
    }
    [WebMethod]
    public string AssignForms_db(int MenuId, int RoleId, int CompanyId, string ModifiedBy, int P_View, int P_Create, int P_Edit, int P_Delete, int P_Upload, int P_Download)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.AssignForms(MenuId, RoleId, CompanyId, ModifiedBy, P_View, P_Create, P_Edit, P_Delete, P_Upload, P_Download);
    }
    [WebMethod]
    public string DeleteAssignForms_db(int MenuId, int RoleId, int CompanyId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteAssignForms(MenuId, RoleId, CompanyId, ModifiedBy);
    }
    [WebMethod]
    public DataSet UserLoginSessions_db(string Username, string Password, string SessionId, string HostName, string IpAddress, string MacId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UserLoginSessions(Username, Password, SessionId, HostName, IpAddress, MacId);
    }
    [WebMethod]
    public DataSet AllOrganizations_db(int CompId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.AllOrganizations(CompId);
    }
    [WebMethod]
    public string SubOrgCreation_db(int OrganizationId, string SubOrgName, string SubOrgAddress, string Mail, string Mobile, int CountryId, string CompanyPrefix, int CompanyType, string ModifiedBy, int UsrPrefixId, string FirstName, string MiddleName, string LastName, string ManualCode, string PinCode, string CompRegNo, string CompGstNo, string PanNo)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.SubOrgCreation(OrganizationId, SubOrgName, SubOrgAddress, Mail, Mobile, CountryId, CompanyPrefix, CompanyType, ModifiedBy, UsrPrefixId, FirstName, MiddleName, LastName, ManualCode, PinCode, CompRegNo, CompGstNo, PanNo);
    }
    [WebMethod]
    public DataSet AllSubOrganizations_db(int OrganizationId, string SearchText)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.AllSubOrganizations(OrganizationId, SearchText);
    }
    [WebMethod]
    public string DepartmentCreation_db(int CompanyId, string DepartmentName, int DepartmentType, string ModifiedBy, string DepartmentCode)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DepartmentCreation(CompanyId, DepartmentName, DepartmentType, ModifiedBy, DepartmentCode);
    }
    [WebMethod]
    public DataSet GetOrganizationDetails_db(int CompId, string SearchText)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetOrganizationDetails(CompId, SearchText);
    }
    [WebMethod]
    public string DeleteOrganization_db(int CompanyId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteOrganization(CompanyId, ModifiedBy);
    }
    [WebMethod]
    public DataSet GetOrganizationDetailsById_db(Int64 CompId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetOrganizationDetailsById(CompId);
    }
    [WebMethod]
    public string UpdateOrganizationById_db(int UpdCompId, string FirstName, string MiddleName, string LastName, string Mobile, string Email, string CompanyName, string Address, int ChoosenPlanId, int CountryId, string ModifiedBy, string CompanyRegNo, string CompanyGstNo, string CompanyPanNo, string ManualCompCode, int ActiveStat, string CompPrefix, int UserPrefix)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateOrganizationById(UpdCompId, FirstName, MiddleName, LastName, Mobile, Email, CompanyName, Address, ChoosenPlanId, CountryId, ModifiedBy, CompanyRegNo, CompanyGstNo, CompanyPanNo, ManualCompCode, ActiveStat, CompPrefix, UserPrefix);
    }
    [WebMethod]
    public DataSet GetSubOrganizationDetailsById_db(int SubCompId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetSubOrganizationDetailsById(SubCompId);
    }
    [WebMethod]
    public string UpdateSubOrganizationById_db(int SubCompanyId, string SubCompanyName, string Mobile, string Email, string Address, int CountryId, string FirstName, string MiddleName, string LastName, string CompanyRegNo, string CompanyGstNo, string CompanyPanNo, string ManualCompCode, string CompPrefix, int ActiveStat, int UserPrefixId, string ModifiedBy, string CompPinCode)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateSubOrganizationById(SubCompanyId, SubCompanyName, Mobile, Email, Address, CountryId, FirstName, MiddleName, LastName, CompanyRegNo, CompanyGstNo, CompanyPanNo, ManualCompCode, CompPrefix, ActiveStat, UserPrefixId, ModifiedBy, CompPinCode);
    }
    [WebMethod]
    public DataSet GetDepartmentDetails_db(int OrganizationId, string SearchText, string status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetDepartmentDetails(OrganizationId, SearchText, status);
    }
    [WebMethod]
    public DataSet GetDepartmentDetailsById_db(int DepartmentId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetDepartmentDetailsById(DepartmentId);
    }
    [WebMethod]
    public string UpdateDepartmentById_db(int DepartmentId, string DepartmentName, string DepartmentCode, string ModifiedBy, int ActiveStat)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateDepartmentById(DepartmentId, DepartmentName, DepartmentCode, ModifiedBy, ActiveStat);
    }
    [WebMethod]
    public string DeleteDepartment_db(int DepartmentId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteDepartment(DepartmentId, ModifiedBy);
    }
    [WebMethod]
    public string DeleteSubOrganization_db(int SubCompanyId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteSubOrganization(SubCompanyId, ModifiedBy);
    }
    [WebMethod]
    public string InsertRole_db(int CompanyId, string RoleName, int ParentRoleId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.InsertRole(CompanyId, RoleName, ParentRoleId, ModifiedBy);
    }
    [WebMethod]
    public string UpdateRole_db(int CompanyId, string RoleName, int EditRoleId, string ModifiedBy, int ActiveStat)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateRole(CompanyId, RoleName, EditRoleId, ModifiedBy, ActiveStat);
    }
    [WebMethod]
    public DataSet GetRoleById_db(int RoleId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetRoleById(RoleId);
    }
    [WebMethod]
    public DataSet GetRolesByAutoId_db(int CompanyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetRolesByAutoId(CompanyId);
    }
    [WebMethod]
    public string DeleteRoleById_db(int RoleId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteRoleById(RoleId, ModifiedBy);
    }
    [WebMethod]
    public string InsertOrganization_db(string FirstName, string MiddleName, string LastName, string Mobile, string Mail, string CompanyName, string CompanyAddress, int ChoosenPlanId, int CountryId, string Password, int DefaultRoleId, string EmployeeCode, string ModifiedBy, string CompanyRegNo, string CompanyGstNo, string CompanyPanNo, string ManualCompCode, string CompPrefix, int UserPrefix, Int64 CompPinCode)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.InsertOrganization(FirstName, MiddleName, LastName, Mobile, Mail, CompanyName, CompanyAddress, ChoosenPlanId, CountryId, Password, DefaultRoleId, EmployeeCode, ModifiedBy, CompanyRegNo, CompanyGstNo, CompanyPanNo, ManualCompCode, CompPrefix, UserPrefix, CompPinCode);
    }
    [WebMethod]
    public DataSet CheckUserRights_db(int CompanyId, int RoleId, string EmpCode, string PageUrl)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckUserRights(CompanyId, RoleId, EmpCode, PageUrl);
    }
    [WebMethod]
    public string SubDepartmentCreation_db(int CompanyId, int DepartmentId, string SubDepartmentName, string SubDepCode, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.SubDepartmentCreation(CompanyId, DepartmentId, SubDepartmentName, SubDepCode, ModifiedBy);
    }
    [WebMethod]
    public DataSet GetSubDepartmentDetails_db(int OrganizationId, int departmentid, string SearchText, string status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetSubDepartmentDetails(OrganizationId, departmentid, SearchText, status);
    }
    [WebMethod]
    public DataSet GetSubDepartmentDetailsById_db(int SubDepartmentId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetSubDepartmentDetailsById(SubDepartmentId);
    }
    [WebMethod]
    public string UpdateSubDepartmentById_db(int SubDepartmentId, string DepartmentName, string DepartmentCode, int ActiveStat, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateSubDepartmentById(SubDepartmentId, DepartmentName, DepartmentCode, ActiveStat, ModifiedBy);
    }
    [WebMethod]
    public string DeleteSubDepartment_db(int SubDepartmentId, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteSubDepartment(SubDepartmentId, ModifiedBy);
    }
    [WebMethod]
    public string IndividualUserReg_db(string Mail, string Name, Int64 Mobile, string Password, string ModifiedBy, int PlanCatId, string Address)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.IndividualUserReg(Mail, Name, Mobile, Password, ModifiedBy, PlanCatId, Address);
    }
    [WebMethod]
    public DataTable GetIndividualUsers_db(string SearchText)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetIndividualUsers(SearchText);
    }
    [WebMethod]
    public DataTable GetIndividualUserById_db(string UserId, int CompanyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetIndividualUserById(UserId, CompanyId);
    }
    [WebMethod]
    public string UpdateIndividualUser_db(string Mail, string Name, Int64 Mobile, int PlanCatId, string Address, string UserId, int CompanyId, string ModifiedBy, int ActiveStat)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateIndividualUser(Mail, Name, Mobile, PlanCatId, Address, UserId, CompanyId, ModifiedBy, ActiveStat);
    }
    [WebMethod]

    public DataTable GetCountries_db(int companyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetCountries(companyId);
        return Dts;
    }

    [WebMethod]
    public DataTable GetNextCompId_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetNextCompId();
        return Dts;
    }
    [WebMethod]
    public bool CheckCompCodeExists_db(string ManualCompCode)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckCompCodeExists(ManualCompCode);
    }
    [WebMethod]
    public bool CheckCompPrefixExists_db(string CompanyPrefix)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckCompPrefixExists(CompanyPrefix);
    }
    [WebMethod]
    public bool CheckNoOfRolesInComp_db(int RoleId, int CompanyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckNoOfRolesInComp(RoleId, CompanyId);
    }
    [WebMethod]
    public DataTable GetAllCompanies_db(int CompanyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetAllCompanies(CompanyId);
        return Dts;
    }
    [WebMethod]
    public string CheckIndUserExist_db(Int64 Mobile, string Email)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CheckIndUserExist(Mobile, Email);
    }
    [WebMethod]
    public string CreateUpdates_db(int OrganizationId, string Title, string Content, string Date, int ActiveStat, string ModifiedBy, int CatId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.CreateUpdates(OrganizationId, Title, Content, Date, ActiveStat, ModifiedBy, CatId);
    }
    [WebMethod]
    public DataTable GetUpdateCategories_db()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetUpdateCategories();
        return Dts;
    }

    [WebMethod]
    public string DeleteUpdates_db(int Id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeleteUpdates(Id, ModifiedBy);
    }
    [WebMethod]
    public DataSet GetUpdatesById_db(int Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetUpdatesById(Id);
    }
    [WebMethod]
    public string UpdateDailyUpdates_db(int Id, string Title, string Content, string Date, int ActiveStat, string ModifiedBy, int CatId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.UpdateDailyUpdates(Id, Title, Content, Date, ActiveStat, ModifiedBy, CatId);
    }
    //DileepEnd
    //Ajay
    //Admin Dashboard Datas 27-05-2021
    [WebMethod]
    public DataSet el_fetch_status_column_atmpt_hstry_db(int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.el_fetch_status_column_atmpt_hstry(EmpCompId);
        return dts;
    }

    [WebMethod]
    public DataSet Admin_dashboard_fetch_db(int EmpCompId, string trngid)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Admin_dashboard_fetch(EmpCompId, trngid);
        return dts;
    }

    //Admin Dashboard Datas 27-05-2021

    //get approver_comment_id 28-05-2021

    [WebMethod]
    public DataSet get_approver_id_comment_db(int EmpCompId, int trng_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.get_approver_id_comment(EmpCompId, trng_id);
        return dts;
    }

    //get approver_comment_id 28-05-2021

    //Delete Training 29-05-2021

    [WebMethod]
    public string Delete_Trng_db(int comp_id, int tr_id, string usrid, int status)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Delete_Trng(comp_id, tr_id, usrid, status);
    }

    //Delete Training 29-05-2021

    //fetch attempt history 31-05-2021

    [WebMethod]
    public DataSet el_fetch_attempt_history_db(int EmpCompId, int trngid, int trackid, string userid)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.el_fetch_attempt_history(EmpCompId, trngid, trackid, userid);
        return dts;
    }

    //fetch attempt history 31-05-2021

    //update elearning  attempt history  01-06-2021

    [WebMethod]
    public string update_elearning_attend_history_db(int comp_id, string userid, int trackid, int trng_id, string attend_date, string status,
    string reslt_status, int score, string duration, string completion, int history_id, string edited_by)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.update_elearning_attend_history(comp_id, userid, trackid, trng_id, attend_date, status,
        reslt_status, score, duration, completion, history_id, edited_by);

    }

    //update elearning  attempt history  01-06-2021


    [WebMethod]
    public DataTable ilt_sessn_fetch_first_session_db(int training_id, int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return Dts = sercon.ilt_sessn_fetch_first_session(training_id, cmpid);
    }


    //blended ilt training insert 06-05-2021

    [WebMethod]
    public string ilt_blend_rating_insert_con(int traingid, string UserId, int company_Id, int rating)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_blend_rating_insert_ser(traingid, UserId, company_Id, rating);
    }

    //blended ilt training insert 06-05-2021

    //blended ilt cancel button 07-05-21

    [WebMethod]
    public string blended_ilt_cancel_button_condition_check_db(int tr_id, int comp_id, string usrid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.blended_ilt_cancel_button_condition_check(tr_id, comp_id, usrid);
    }

    //blended ilt cancel button 07-05-21

    //ilt instructor check consitions 13-05-2021

    [WebMethod]
    public string ilt_instructor_check_consition_db(int trng_id, int compid, int session_id, string userid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_instructor_check_consition(trng_id, compid, session_id, userid);
    }


    //ilt submitted for approval 11-05-2021

    [WebMethod]
    public string ilt_submitted_for_approval_db(int tr_id, int comp_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_submitted_for_approval(tr_id, comp_id);
    }

    //ilt submitted for appr


    // training cancel status for users 30-4-2021
    [WebMethod]
    public DataSet training_cancel_status_of_users_db(string UserId, int EmpCompId, string status)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.training_cancel_status_of_users(UserId, EmpCompId, status);
        return dts;
    }
    // training cancel status for users 30-4-2021


    [WebMethod]
    public string regularize_attendance_db(string usrid, string punch_in, string punch_in_time, string punch_out, string punch_out_time, string attendence,
    int tr_id, int comp_id, int module_id, int sessionid, string regularized_by
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.regularize_attendance(usrid, punch_in, punch_in_time, punch_out, punch_out_time, attendence,
        tr_id, comp_id, module_id, sessionid, regularized_by);
    }

    //manager task cancel request  15-4-2021
    [WebMethod]
    public DataSet manager_cancel_task_page_get_details_db(string UserId, int EmpCompId, string status)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.manager_cancel_task_page_get_details(UserId, EmpCompId, status);
        return dts;
    }
    //manager task cancel request  15-4-2021


    //fetch training details 17-4-21

    [WebMethod]
    public DataSet fetch_training_cancellation_details_db(int EmpCompId, string UserId, int training_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.fetch_training_cancellation_details(EmpCompId, UserId, training_id);
        return dts;
    }

    //fetch training details 17-4-21

    //update training cancel status manager and coordinator 18-4-21
    [WebMethod]
    public string itl_tring_cancel_update_status_db(int traing_id, int trackid, string user_Id, int cancl_status, string remark, int compnyId,
    string appr_user_id, int mngr_or_coordinator, int module_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.itl_tring_cancel_update_status(traing_id, trackid, user_Id, cancl_status, remark, compnyId, appr_user_id,
        mngr_or_coordinator, module_id);
    }


    [WebMethod]
    public string ilt_trng_update_db(int comp_id, string userId, int tr_id)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.ilt_trng_update(comp_id, userId, tr_id);
        return str;
    }
    //update training cancel status manager and coordinator 18-4-21

    //get training coordinator cancel request  18-4-21
    [WebMethod]
    public DataSet coordinator_cancel_req_detailss_db(string UserId, int EmpCompId, string cancelstatus)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.coordinator_cancel_req_details(UserId, EmpCompId, cancelstatus);
        return dts;
    }
    //get training coordinator cancel request  18-4-21

    //fetch details with trackid,usrid and training id 19-4-21
    [WebMethod]
    public DataTable fetch_trackdetails_with_trackid_db(int compnyId, int traingId, string usrid, int trackid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_trackdetails_with_trackid(compnyId, traingId, usrid, trackid);
        return Dts;
    }
    //fetch details with trackid,usrid and training id 19-4-21


    //ilt cancel button condition

    [WebMethod]
    public string cancel_button_condition_check_db(int tr_id, int comp_id, string usrid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.cancel_button_condition_check(tr_id, comp_id, usrid);
    }

    //ilt cancel button condition

    //coordinator task start

    [WebMethod]
    public DataSet coordinator_task_page_get_details_db(string UserId, int EmpCompId, string status)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.coordinator_task_page_get_details(UserId, EmpCompId, status);
        return dts;
    }

    //coordinator task end 

    //coordinator enter

    [WebMethod]
    public string coordinator_enter_session_db(int trng_id, int compid, int session_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.coordinator_enter_session(trng_id, compid, session_id);
    }

    //end 

    //fetch session data with sessionid start 

    [WebMethod]
    public DataTable get_ilt_sess_details_punching_db(int cmp_id, int trid, int sess_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.get_ilt_sess_details_punching(cmp_id, trid, sess_id);
        return Dts;
    }

    //fetch session data with sessionid end 

    //fetch audience list as per session from usertrack start

    [WebMethod]
    public DataTable fetch_audience_list_for_sessions_db(int training_id, int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_audience_list_for_sessions(training_id, cmpid);
        return Dts;
    }
    //fetch audience list as per session from usertrack end 

    //ilt attendence save start

    [WebMethod]
    public string insert_session_attendence_db(string usrid, string punch_in, string punch_in_time, string punch_out, string punch_out_time, string attendence,
    int tr_id, int comp_id, int module_id, int sessionid, string regularized_by, int punch_type, string option
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_session_attendence(usrid, punch_in, punch_in_time, punch_out, punch_out_time, attendence,
        tr_id, comp_id, module_id, sessionid, regularized_by, punch_type, option);
    }

    //ilt attendence save end 

    //ilt update session table with coordinator punch start

    [WebMethod]
    public string insert_punch_details_into_session_db(int tr_id, int comp_id, int module_id, int sessionid, string img_name, int punch_status,
    string usrid
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_punch_details_into_session(tr_id, comp_id, module_id, sessionid, img_name, punch_status,
        usrid);
    }

    //ilt update session table with coordinator punch end 

    //fetch attendence datas start

    //[WebMethod]
    //public DataTable fetch_attendence_datas_db(int training_id, int cmpid, int sess_id)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return Dts = sercon.fetch_attendence_datas(training_id, cmpid, sess_id);
    //}



    //fetch attendence datas start


    //audiencecode
    [WebMethod]
    public string GetaudienceCode_db(int cmpnyId)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.GetaudienceCode(cmpnyId);
        return str;
    }

    [WebMethod]
    public DataTable audi_Code_exist_db(int COMPY_ID, string rulecode)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.audi_Code_exist(COMPY_ID, rulecode);
        return Dts;
    }

    [WebMethod]
    public DataTable fetchusers_with_query_db(string query, int compid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetchusers_with_query(query, compid);
        return Dts;
    }


    //audience insert
    [WebMethod]
    public string insert_audi_con(string insert_qry, string ruleset_names, string audience_name, string audience_code, string description,
    string primary_domain, int status, int cmp_id, string action)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_audi_ser(insert_qry, ruleset_names, audience_name, audience_code, description, primary_domain, status, cmp_id, action);
    }

    [WebMethod]
    public DataTable ruleset_fetch_con(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ruleset_fetch_ser(comp_id);
        return Dts;
    }

    //audience list fetch

    [WebMethod]
    public DataTable audience_list_fetch_con(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.audience_list_fetch_ser(comp_id);
        return Dts;
    }

    [WebMethod]//datas_fetch_with_rulecode//ruleset_fetch_con
    public DataSet datas_fetch_with_rulecode_db(int comp_id, string rulecode)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.datas_fetch_with_rulecode(comp_id, rulecode);
        return Dts;
    }

    [WebMethod]
    public string qst_option_insert_db(int qstn_id, string qst_option, string mod_of_optn, string option_path, string currect_ansr, int created_by, int status)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.qst_option_insert(qstn_id, qst_option, mod_of_optn, option_path, currect_ansr, created_by, status);
    }


    [WebMethod]
    public DataTable Menu_cat_con(int SubMenuID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_cat_ser(SubMenuID);
        return Dts;
    }


    [WebMethod]
    public string insert_menu_con(int pid, string catname, string role_id, string emp_code, string cmp_id, int status, int planid)
    {



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;



        return sercon.insert_menu_ser(pid, catname, role_id, emp_code, cmp_id, status, planid);
    }

    [WebMethod]
    public string update_menunm_con(int pid, string catnme)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.update_menunm_ser(pid, catnme);
    }

    [WebMethod]
    public string delete_menu_con(int pid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.delete_menu_ser(pid);
    }

    [WebMethod]
    public DataTable fetch_user_con()
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_user_ser();
        return Dts;
    }
    [WebMethod]
    public DataTable getplan_with_cmp_con(int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.getplan_with_cmp_ser(cmpid);
        return Dts;
    }



    [WebMethod]
    public DataTable Menu_Master_cmpid_con(string cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_Master_cmpid_ser(cmpid);
        return Dts;
    }



    [WebMethod]
    public DataTable Menu_Master_plnid_con(string plan_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Menu_Master_plnid_ser(plan_id);
        return Dts;
    }
    //End Ajay

    //Heera
    //Elearning

    [WebMethod]
    public DataSet Get_Scrom_status_details_db(int prm_comp, int prm_training_id, string prm_user_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Get_Scrom_status_details(prm_comp, prm_training_id, prm_user_id);
        return dts;
    }



    [WebMethod]
    public DataTable Elearning_Preview_Details_db(int comp, int trangid)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Elearning_Preview_Details(comp, trangid);
        return dts;
    }

    //heera
    //elearning bind topic,audi,fdbk,approver


    //[WebMethod]
    //public DataSet Elearning_Preview_Details_Bind_db(int compny, int traingid)
    //{
    //    DataSet dts = new DataSet();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    dts = sercon.elearning_prvw_bindings(compny, traingid);
    //    return dts;
    //}


    //heera elearning USER INDEXsynchro_content_insert
    //[WebMethod]
    //public DataTable Elearning_index_user_db(int compny, int traingid)
    //{
    //    DataTable dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    dts = sercon.Elearning_user_index(compny, traingid);
    //    return dts;
    //}


    //heera elearning USER INDEX topics binding





    [WebMethod]
    public DataTable Elearning_index_user_db(int compny, int traingid, string user_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Elearning_user_index(compny, traingid, user_id);
        return dts;
    }


    //heera elearning USER INDEX topics binding
    [WebMethod]
    public DataTable Elearning_index_usertopics_db(int compny, int traingid)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Elearning_user_index_topic(compny, traingid);
        return dts;
    }
    //end heera



    //----------------  Start Elearning Module ------------------//
    //---------by anjana-----------//

    [WebMethod]
    public DataSet Get_ble_Scrom_status_details_db(int prm_comp, int prm_training_id, string prm_user_id, string prm_blendedid)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Get_ble_Scrom_status_details(prm_comp, prm_training_id, prm_user_id, prm_blendedid);
        return dts;
    }

    [WebMethod]
    public DataTable Get_ble_User_Track_Details_db(int compny, int traingid, string user_id, int user_track_id, string prm_blendedid)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Get_ble_User_Track_Details(compny, traingid, user_id, user_track_id, prm_blendedid);
        return dts;
    }

    [WebMethod]
    public string GetTrainingCode_db(int cmpnyId, int courseId)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.GetTrainingCode(cmpnyId, courseId);
        return str;
    }
    [WebMethod]
    public string insert_elearning_training_dtls_pmry_pg_db(int prm_training_id, string prm_training_name, int prm_company_id, int prm_course_id, int prm_exam_type_id, int prm_has_exam, int prm_is_referable, int prm_is_subscribable, int prm_training_type_id, int prm_status, string prm_training_code, string prm_training_description, string prm_sub_product_map_ids, string prm_created_by, string prm_updateAction, int prm_page_status, int prm_training_category, int prm_training_sub_category, string prm_p_course_owner, int prm_competency, int prm_coreCompetencyId, int prm_subCompetencyId, int prm_relativeCourseId, int Self_approver_req)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_elearning_training_dtls_pmry_pg(prm_training_id, prm_training_name, prm_company_id, prm_course_id, prm_exam_type_id, prm_has_exam, prm_is_referable, prm_is_subscribable, prm_training_type_id, prm_status, prm_training_code, prm_training_description, prm_sub_product_map_ids, prm_created_by, prm_updateAction, prm_page_status, prm_training_category, prm_training_sub_category, prm_p_course_owner, prm_competency, prm_coreCompetencyId, prm_subCompetencyId, prm_relativeCourseId, Self_approver_req);
        return str;
    }

    [WebMethod]

    public string insert_elearning_training_approval_dtls_db(int prm_training_id, int prm_company_id, int prm_course_id, string prm_approval_status, string prm_created_by, string prm_updateAction, int prm_page_status)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_elearning_training_approval_dtls(prm_training_id, prm_company_id, prm_course_id, prm_approval_status, prm_created_by, prm_updateAction, prm_page_status);
        return str;
    }


    //new
    [WebMethod]
    public string Scrom_Replace_db(int Comp_ID, int TrainingID, string Resone, int P_Case)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Scrom_Replace(Comp_ID, TrainingID, Resone, P_Case);
        return str;
    }


    [WebMethod]
    public DataTable Dashboard_duration_db(string USERID, int COMPID)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Dashboard_duration(USERID, COMPID);
    }


    [WebMethod]
    public DataSet get_training_dtls_db(int Comp_id, int Trng_id, int Module_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_training_dtls(Comp_id, Trng_id, Module_id);
    }

    [WebMethod]
    public DataSet GetUsrByType_db(int CompId, string Typ)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetUsrByType(CompId, Typ);
    }

    [WebMethod]
    public DataTable GetExamType_db(int examid, int cmpnyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetExamType(examid, cmpnyId);
        return Dts;
    }

    [WebMethod]
    public DataTable CheckCourseCode_db(int companyId, string courseCode)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.CheckCourseCode(companyId, courseCode);
        return Dts;
    }

    [WebMethod]
    public string Insert_User_Traning_Attempt_History_db(int prm_history_id, int prm_course_id, int prm_training_id, int prm_trng_user_track_id, string prm_user_id, string prm_sessn_duration, string prm_attended_date, int prm_attempt_count, int prm_try_count, string prm_try_score, string prm_start_time, string prm_end_time, int prm_comp_id, string prm_updateAction)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_User_Traning_Attempt_History(prm_history_id, prm_course_id, prm_training_id, prm_trng_user_track_id, prm_user_id, prm_sessn_duration, prm_attended_date, prm_attempt_count, prm_try_count, prm_try_score, prm_start_time, prm_end_time, prm_comp_id, prm_updateAction);
        return str;
    }

    [WebMethod]
    public string Insert_User_Certificate_db(int prm_user_track_id, string prm_user_id, int prm_comp_id, string prm_updateAction, string prm_pageMode, string prm_certificate_name)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_User_Certificate(prm_user_track_id, prm_user_id, prm_comp_id, prm_updateAction, prm_pageMode, prm_certificate_name);
        return str;
    }

    [WebMethod]
    public DataTable Get_User_Track_Details_db(int compny, int traingid, string user_id, int user_track_id)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Get_User_Track_Details(compny, traingid, user_id, user_track_id);
        return dts;
    }
    //[WebMethod]


    //public DataTable Elearning_Preview_Details_db(int comp, int trangid)
    //{
    //    DataTable dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    dts = sercon.Elearning_Preview_Details(comp, trangid);
    //    return dts;
    //}

    //heera
    //elearning bind topic,audi,fdbk,approver
    [WebMethod]
    public DataSet Elearning_Preview_Details_Bind_db(int compny, int traingid)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.elearning_prvw_bindings(compny, traingid);
        return dts;
    }


    [WebMethod]
    // heera certificate fetch

    public DataTable fetch_certificate_bynamee_db(int Compny_Id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_certificate_bynamee_ser(Compny_Id);
        return Dts;


    }


    [WebMethod]
    public DataSet GetTraningSessionDetails_db(int trainingId, int companyId, string userId)
    {
        DataSet Dts = new DataSet();

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetTrainingSessionDetails(trainingId, companyId, userId);

        return Dts;
    }

    [WebMethod]
    public string insert_elearning_training_dtls_third_pg_db(int prm_training_id, int prm_course_id, string prm_training_cover_image, string prm_scrome_id, string prm_user_id, int prm_company_id, string prm_updateAction, int prm_page_status)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_elearning_training_dtls_third_pg(prm_training_id, prm_course_id, prm_training_cover_image, prm_scrome_id, prm_user_id, prm_company_id, prm_updateAction, prm_page_status);
        return str;
    }

    [WebMethod]
    public DataTable elearning_user_attempt_history_db(int comny, int traingid, string user_id, string attemptId, string blended_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Elearning_user_history_Details(comny, traingid, user_id, attemptId, blended_id);
        return Dts;


    }

    [WebMethod]
    public string add_user_course_favorite_db(int prm_comp_id, int prm_training_id, int prm_usr_trng_track_id, int prm_course_id, string prm_user_id, int prm_is_intrested, string prm_updateAction)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.add_user_course_favorite(prm_comp_id, prm_training_id, prm_usr_trng_track_id, prm_course_id, prm_user_id, prm_is_intrested, prm_updateAction);
    }

    [WebMethod]
    public DataSet get_course_favorite_dtls_db(int prm_comp_id, int prm_training_id, string prm_usr_trng_track_id, int prm_course_id, string prm_user_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_course_favorite_dtls(prm_comp_id, prm_training_id, prm_usr_trng_track_id, prm_course_id, prm_user_id);

    }

    //---------by anjana-----------//
    //---------------- End Elearning Module ------------------//

    //[WebMethod]
    //public DataSet GetTrainingDtlsByModuleType_db(int CompId, string ModuleType)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.GetTrainingDtlsByModuleType(CompId, ModuleType);
    //}


    [WebMethod]
    public DataSet Get_Exam_User_ProctoringRep_db(int examId, int trackId, string userId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Get_Exam_User_ProctoringRep(examId, trackId, userId);
        return ds;
    }


    //VILT Start
    //VILT Start

    //vilt  new  
    [WebMethod]
    public string Trng_Attendance_Photo_Insert_db(int trainingId, int companyId, string userId, string imageName, int moduleId, int userTrackId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Attendance_Photo_Insert(trainingId, companyId, userId, imageName, moduleId, userTrackId);
    }

    //VILT    
    [WebMethod]
    public string Vilt_Mark_Attendance_db(int companyId, int trainingId, int moduleId, int userTrackId, string totalDuration, string elapsedTime, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Mark_Attendance(companyId, trainingId, moduleId, userTrackId, totalDuration, elapsedTime, userId);
    }

    [WebMethod]
    public DataTable Get_Course_Competency_db(int companyId, string competencyType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Course_Competency(companyId, competencyType);
        return Dts;
    }

    [WebMethod]
    public string Trng_Vilt_Insert_db(int primaryCompId, int crsCategoryId, int crsSubCategoryId, int trngType, string topic, string courseName, string courseCode, string courseDesc, int isRecommend, int isBlended, int mandatoryReg, string venueId, int venueDetails, int priorityType, int courseType, string courseOwner, string coordinator, int activeStatus, string startDate, string endDate, int noOfDays, string action, int viltCourseId, int pageStatus, string modifiedBy, int hasExam, int competency, int coreCompetencyId, int subCompetencyId, string createdBy, int hasInstantVote)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Vilt_Insert(primaryCompId, crsCategoryId, crsSubCategoryId, trngType, topic, courseName, courseCode, courseDesc, isRecommend, isBlended, mandatoryReg, venueId, venueDetails, priorityType, courseType, courseOwner, coordinator, activeStatus, startDate, endDate, noOfDays, action, viltCourseId, pageStatus, modifiedBy, hasExam, competency, coreCompetencyId, subCompetencyId, createdBy, hasInstantVote);
    }

    [WebMethod]

    public DataTable Vilt_GetVenueDtls_db(int CompanyId, int ToolId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Vilt_GetVenueDtls(CompanyId, ToolId);
        return Dts;
    }


    [WebMethod]
    public DataSet Vilt_Course_Dtls_Fetch_db(int CompanyId, int Course_Id, int moduleId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Vilt_Course_Dtls_Fetch(CompanyId, Course_Id, moduleId);
        return ds;
    }


    //[WebMethod]
    //public string Trng_Vilt_Edit2_db(int trainingId, int Comp_ID, string Start_Time, string End_Time, string Topic, string intInstructor1, string intInstructor2, string extInstrName, string extInstrOrg, string extInstrDesig, string fbck, int isAttendance, string action, int pageStatus, string modifiedBy, string sessionDate, int moduleId, int has_feedback)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.Trng_Vilt_Edit2(trainingId, Comp_ID, Start_Time, End_Time, Topic, intInstructor1, intInstructor2, extInstrName, extInstrOrg, extInstrDesig, fbck, isAttendance, action, pageStatus, modifiedBy, sessionDate, moduleId, has_feedback);
    //}

    
    [WebMethod]
    public string Trng_Vilt_Edit2_db(int trainingId, int Comp_ID, string Start_Time, string End_Time, string Topic, string intInstructor1, string intInstructor2, string extInstrName, string extInstrOrg, string extInstrDesig, string fbck, int isAttendance, string action, int pageStatus, string modifiedBy, string sessionDate, int moduleId, int has_feedback, string email, string mobile)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Vilt_Edit2(trainingId, Comp_ID, Start_Time, End_Time, Topic, intInstructor1, intInstructor2, extInstrName, extInstrOrg, extInstrDesig, fbck, isAttendance, action, pageStatus, modifiedBy, sessionDate, moduleId, has_feedback, email, mobile);
    }



    [WebMethod]
    public string Trng_Vilt_Edit3_db(int trainingId, int Comp_ID, int isPreponable, int isPostponable, string appList, string notific_typestr, string notific_modestr, string notific_Intstr, string sartdatrstr, string enddatrstr, string sarttimestr, string endtimestr, string AutoNotific, string audiList, string action, int pageStatus, string modifiedBy, int moduleId, string certificate)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Vilt_Edit3(trainingId, Comp_ID, isPreponable, isPostponable, appList, notific_typestr, notific_modestr, notific_Intstr, sartdatrstr, enddatrstr, sarttimestr, endtimestr, AutoNotific, audiList, action, pageStatus, modifiedBy, moduleId, certificate);
    }
    [WebMethod]
    public string Trng_Vilt_Edit4_db(int trainingId, int companyId, int moduleId, string modifiedBy, int pageStatus, string action)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Vilt_Edit4(trainingId, companyId, moduleId, modifiedBy, pageStatus, action);
    }
    [WebMethod]
    public string Trng_Vilt_Edit4_Approve_db(int trainingId, int companyId, int moduleId, string modifiedBy, int pageStatus, string action)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Trng_Vilt_Edit4_Approve(trainingId, companyId, moduleId, modifiedBy, pageStatus, action);
    }
    [WebMethod]
    public string GetCompanyBy_Course_db(int trainingId, int moduleId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetCompanyBy_Course(trainingId, moduleId);
    }
    [WebMethod]
    public DataTable session_topic_fetch_con(int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.session_topic_fetch_ser(cmpid);
        return Dts;
    }
    [WebMethod]
    public DataSet Vilt_Tool_Dtls_Fetch_db(int CompanyId, int Course_Id, int toolId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Vilt_Tool_Dtls_Fetch(CompanyId, Course_Id, toolId);
        return ds;
    }
    [WebMethod]
    public DataTable Training_User_Dtls_Fetch_db(int CompanyId, int Course_Id, int moduleId)
    {
        DataTable ds = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Training_User_Dtls_Fetch(CompanyId, Course_Id, moduleId);
        return ds;
    }
    [WebMethod]
    public string Vilt_Meeting_Insert_db(int courseId, int companyId, string meetingkey, string meetingUUID, string meetingPassword, string hostCalendar, string attendeeCalendar, string guestToken, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Meeting_Insert(courseId, companyId, meetingkey, meetingUUID, meetingPassword, hostCalendar, attendeeCalendar, guestToken, modifiedBy);
    }
    [WebMethod]
    public string Vilt_Meeting_Url_Insert_db(int courseId, int companyId, string inviteUrl, string joinUrl, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Meeting_Url_Insert(courseId, companyId, inviteUrl, joinUrl, modifiedBy);
    }
    [WebMethod]
    public string Vilt_Trng_Cancel_db(int courseId, int companyId, string cancReason, string fileSource, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Trng_Cancel(courseId, companyId, cancReason, fileSource, modifiedBy);
    }

    [WebMethod]
    public DataSet Vilt_Course_User_Dtls_Fetch_db(int companyId, int courseId, int moduleId, string userId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Vilt_Course_User_Dtls_Fetch(companyId, courseId, moduleId, userId);
        return ds;
    }
    [WebMethod]
    public string Vilt_Tool_Config_Insert_db(int companyId, string toolId, string serverName, string siteId, string adminUsername, string adminPwd, string meetCode, string launchUrl, int isCredForMeetLauch, int isRegPassReq, int isJoinWithoutPass, int isLangPref, int isInheritDomain, int isMeeting, int isEvent, int isTraining, string modifiedBy, string hostName, string partnerId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Tool_Config_Insert(companyId, toolId, serverName, siteId, adminUsername, adminPwd, meetCode, launchUrl, isCredForMeetLauch, isRegPassReq, isJoinWithoutPass, isLangPref, isInheritDomain, isMeeting, isEvent, isTraining, modifiedBy, hostName, partnerId);
    }
    [WebMethod]
    public string Vilt_Attendance_Update_db(int companyId, int courseId, int moduleId, string userId, string email, string meetingKey, string userName, string meetingName, string meetingUuId, string ipAddress, string clientAgent, string joinTime, string leaveTime, int duration, string participantType, string voipDuration, string confID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Vilt_Attendance_Update(companyId, courseId, moduleId, userId, email, meetingKey, userName, meetingName, meetingUuId, ipAddress, clientAgent, joinTime, leaveTime, duration, participantType, voipDuration, confID);
    }

    [WebMethod]
    public DataTable Check_Course_Exam_Exist_db(int companyId, int courseId, int moduleId)
    {
        DataTable dt = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dt = sercon.Check_Course_Exam_Exist(companyId, courseId, moduleId);
        return dt;
    }
    //VILT End
    [WebMethod]
    public DataTable synchro_fetch_audience(int comp_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_synchro_audience(comp_id);
        return Dts;
    }

    //------ ILT

    [WebMethod]
    public string insert_ilt_training_approval_dtls_db(int prm_training_id, int prm_company_id, int prm_course_id, string prm_approval_status,
    string prm_created_by, string prm_updateAction, int prm_page_status, string cancel_comment, string reject_comment)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_ilt_training_approval_dtls(prm_training_id, prm_company_id, prm_course_id, prm_approval_status, prm_created_by,
        prm_updateAction, prm_page_status, cancel_comment, reject_comment);
        return str;
    }


    [WebMethod]
    public DataSet approver_task_page_get_details_db(string UserId, int EmpCompId, string approver_status)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.approver_task_page_get_details(UserId, EmpCompId, approver_status);
        return dts;
    }

    [WebMethod]
    public DataTable ilt_sessn_prvw1_con(int training_id, int cmpid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ilt_sessn_prvw1_ser(training_id, cmpid);
        return Dts;
    }

    [WebMethod]
    public DataTable ilt_sessn_Certificate_con(int training_id, int cmpid, string User_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ilt_sessn_Certificate_ser(training_id, cmpid, User_ID);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_ilt_curse_topic(int compn_id, int traingn_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_ilt_course_topic(compn_id, traingn_id);
        return Dts;
    }
    [WebMethod]
    public DataTable ilt_sessn_fetch_con(int training_id, int cmpid, string date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ilt_sessn_fetch_ser(training_id, cmpid, date);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_ilt_sess_intrvel(int comp_id, int sessn_Id, string sess_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_sess_intervel(comp_id, sessn_Id, sess_date);
        return Dts;
    }

    [WebMethod]
    public string ilt_traing_cancel_con_insert(int tring_id, string user_Id, string cancl_reson, string cancl_documnt, int compnyId, int canc_status, string canc_date)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.itl_tring_cans_insert(tring_id, user_Id, cancl_reson, cancl_documnt, compnyId, canc_status, canc_date);
    }

    [WebMethod]
    public DataTable ilt_assign_type_fetch(int compnyId, int traing_id, string userId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_trainig_assignType(compnyId, traing_id, userId);
        return Dts;
    }




    [WebMethod]
    public DataTable fetch_itl_instruct_con(int compId, int traningID)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.fetch_ilt_instructor_ser(compId, traningID);
        return dts;
    }
    [WebMethod]
    public string ilt_rating_insert_con(int traingid, string UserId, int company_Id, int rating)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_rating_insert_ser(traingid, UserId, company_Id, rating);
    }
    [WebMethod]
    public DataTable fetch_itl_ratingn(int compId, string UserId, int traningID)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.fetch_ilt_rating(compId, UserId, traningID);
        return dts;
    }
    //------ END ILT
    //------ Feedback
    [WebMethod]
    public DataTable fetch_Feedback_qustion(int trangId, int COMPY_ID, int ModUle)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Ilt_Feedback_qus(trangId, COMPY_ID, ModUle);
        return Dts;
    }
    [WebMethod]
    public DataTable fetch_feedbckans(int questionid, int compId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_feedback_anser(questionid, compId);
        return Dts;
    }
    [WebMethod]
    public DataTable Fetch_feedback_answers(int questionid, int compId, int moduletype)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_survey_answers(questionid, compId, moduletype);
        return Dts;

    }
    [WebMethod]
    public string uilt_feedback_user_track(string userid, int sury_id, string questId, string ansId, string textmesg, int fedstatus, int modleype, int comp_id, string createdby)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_feedbackusertrack(userid, sury_id, questId, ansId, textmesg, fedstatus, modleype, comp_id, createdby);
    }
    //---------------
    //ILTUSER end



    //ILT

    [WebMethod]
    public DataSet GetDevices_db(int CompId, int DeviceId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetDevices(CompId, DeviceId);
    }

    [WebMethod]
    public DataTable course_Code_Fetch_db(int COMPY_ID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.course_Code_Fetch(COMPY_ID);
        return Dts;
    }

    //[WebMethod]
    //public DataSet GetUsrByType_db(int CompId, string Typ)
    //{
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.GetUsrByType(CompId, Typ);
    //}

    [WebMethod]
    public DataSet GetVenue_db(int CompId, int VenueId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetVenue(CompId, VenueId);
    }

    [WebMethod]
    public DataSet GetUsrById_db(string usrId, int CompId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.GetUsrById(usrId, CompId);
    }
    [WebMethod]
    public string insert_ilt_training_db(string coursename, string coursecode, int CRS_CATRY, int CRS_SUB_CATRY, int CRS_TYPE, int TRAINING_TYPE,
    string CRS_DESCRIPTION, int PRORITY, string STATUS, int primarycompany, string Courseprogress, string CREATED_BY,
    string co_ordinator, string topic, int VENUE, string deviceused, string START_DATE, string END_DATE, int max_seats, int noofdays,
    int hasexam, int isrefer, int isblend, string updateAction, int training_id, int page_status, int competency, int coreCompetencyId,
    int subCompetencyId, string courseowner
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_ilt_training(CRS_CATRY, CRS_SUB_CATRY, TRAINING_TYPE, max_seats, coursename, isblend,
        isrefer, hasexam, CRS_TYPE, primarycompany, VENUE, deviceused, PRORITY, Courseprogress, coursecode,
        CREATED_BY, CRS_DESCRIPTION, training_id, START_DATE, END_DATE, updateAction, topic, STATUS,
        page_status, noofdays, co_ordinator, competency, coreCompetencyId,
        subCompetencyId, courseowner);
    }



    //notification user

    [WebMethod]
    public DataSet user_notification_details_db(string UserId, int EmpCompId, string read, string notification_mode, string trid, string search_txt)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.user_notification_details(UserId, EmpCompId, read, notification_mode, trid, search_txt);
        return dts;
    }

    //notification read status update
    [WebMethod]
    public string noti_user_read_status_update_db(int prm_company_id, string user_id, int tr_id, string upstatus)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.noti_user_read_status_update(prm_company_id, user_id, tr_id, upstatus);
        return str;
    }

    //user notification count
    [WebMethod]
    public DataSet user_notification_count_db(string UserId, int EmpCompId)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.user_notification_count(UserId, EmpCompId);
        return dts;
    }

    [WebMethod]
    public string Profile_Pop_Up_update_db(int msg_id)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Profile_Pop_Up_update(msg_id);
    }


    [WebMethod]
    public DataTable Profile_Pop_Up_details_db(int CompID, int Module_id, int mode, string UserID)
    {
        DataTable ds = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Profile_Pop_Up_details(CompID, Module_id, mode, UserID);
        return ds;
    }



    // end notification user

    // ILT session add

    [WebMethod]
    public string insert_ilt_session_db(int trainingid, int Comp_ID, int module_type, int daycount, string sessioncount, string interval_count, string start_time,
    string end_time, string topic, string primary_instructor, string secondary_instructor, string external_inst_name, string external_inst_org, string external_inst_desi,
    string attendence, string interval_starttime, string interval_endtime, int page_status, string action, string startdate, string enddate, int status, string fulldate,
    string feedback, string feed_count, string external_instructor_exp, string manual_punch, string manual_in, string manual_out, string photo_punch,
    string photo_in, string photo_out, string Session_name,string instr_email, string instr_mobile
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_ilt_session(trainingid, Comp_ID, module_type, daycount, sessioncount, interval_count, start_time,
        end_time, topic, primary_instructor, secondary_instructor, external_inst_name, external_inst_org, external_inst_desi,
        attendence, interval_starttime, interval_endtime, page_status, action, startdate, enddate, status, fulldate, feedback, feed_count,
        external_instructor_exp, manual_punch, manual_in, manual_out, photo_punch, photo_in, photo_out, Session_name,instr_email,instr_mobile);
    }





    //[WebMethod]
    //public string insert_ilt_training_thirdpage_db(int trainingid, int Comp_ID, int prepond, int postpond, int instant_voting, string participantlist,
    //int certificate_temp_id, string approverlist, int approver_status, int approver_active_status, string feedbacklist, string updateaction, int pagestatus
    //, int course_id, int feedback_exist
    //)
    //{

    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    return sercon.insert_ilt_training_thirdpage(trainingid, Comp_ID, prepond, postpond, instant_voting, participantlist, certificate_temp_id,
    //    approverlist, approver_status, approver_active_status, feedbacklist, updateaction, pagestatus, course_id, feedback_exist
    //    );
    //}

    [WebMethod]
    public string insert_ilt_training_thirdpage_db(int trainingid, int Comp_ID, int prepond, int postpond, int instant_voting, string participantlist,
    int certificate_temp_id, string approverlist, int approver_status, int approver_active_status, string feedbacklist, string updateaction, int pagestatus
    , int course_id, int feedback_exist, int is_optional_fb
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_ilt_training_thirdpage(trainingid, Comp_ID, prepond, postpond, instant_voting, participantlist, certificate_temp_id,
        approverlist, approver_status, approver_active_status, feedbacklist, updateaction, pagestatus, course_id, feedback_exist, is_optional_fb
        );
    }



    [WebMethod]
    public DataSet get_ilt_training_dtls_edit_db(int Comp_id, int Trng_id, int Module_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_ilt_training_dtls_edit(Comp_id, Trng_id, Module_id);
    }

    //user exist in trainning start //29-3-2021
    [WebMethod]
    public string user_exist_in_trainning_db(int tr_id, string usrid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.user_exist_in_trainning(tr_id, usrid);
    }

    //user exist in trainning end //29-3-2021

    //photo_punch_insert 29-3-2021
    [WebMethod]
    public string insert_photo_punch_ilt_db(int tr_id, int comp_id, int module_id, int sessionid, string img_name, int punch_status,
    string usrid, string punched_time, string regularized_by
    )
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_photo_punch_ilt(tr_id, comp_id, module_id, sessionid, img_name, punch_status,
        usrid, punched_time, regularized_by);
    }







    //[WebMethod]
    //public string insert_elearning_training_approval_dtls_db(int prm_training_id, int prm_company_id, int prm_course_id, string prm_approval_status, string prm_created_by, string prm_updateAction, int prm_page_status)
    //{
    //    string str;
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    str = sercon.insert_elearning_training_approval_dtls(prm_training_id, prm_company_id, prm_course_id, prm_approval_status, prm_created_by, prm_updateAction, prm_page_status);
    //    return str;
    //}


    [WebMethod]
    public string ilt_training_cancellation_appr_db(int courseId, int companyId, string cancel_comnt, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.ilt_training_cancellation_appr(courseId, companyId, cancel_comnt, userId);
    }

    //ilt cancellation by approver 21-4-2021

    //training approve condition 22-4-2021
    [WebMethod]
    public DataTable Check_ilt_Course_Approve_Conditions_db(int courseId, int companyId, int moduleId, string userId)
    {
        DataTable dt = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dt = sercon.Check_ilt_Course_Approve_Conditions(courseId, companyId, moduleId, userId);
        return dt;
    }

    //training approve condition 22-4-2021

    [WebMethod]
    public DataTable ilt_sessn_fetch_sessn_feedback_con(int sess_id, int traing_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ilt_sessn_fetch_sessn_feedback_ser(sess_id, traing_id);
        return Dts;
    }

    [WebMethod]
    public DataTable ilt_sessn_fetch_sessn_intervals_con(int Train_ID, int Comp_id, string str_date)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.ilt_sessn_fetch_sessn_intervals_ser(Train_ID, Comp_id, str_date);
        return Dts;
    }

    //[WebMethod]
    //public DataTable session_topic_fetch_con(int cmpid)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.session_topic_fetch_ser(cmpid);
    //    return Dts;
    //}

    //ILT end 

    [WebMethod]
    public string encypt_db(string passw)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.encypt(passw);
    }

    [WebMethod]
    public string login_db(string usrid, string passwd)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.login(usrid, passwd);
    }


    [WebMethod]
    public string forgotpassword_db(string mailid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.forgotpassword(mailid);
    }

    [WebMethod]
    public string signupotp_db(string userid, string mobno)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.signupotp(userid, mobno);
    }
    [WebMethod]
    public string SupAdminIntimation_db(string UserId, string MobileNo, string CatId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.SupAdminIntimation(UserId, MobileNo, CatId);
    }
    [WebMethod]
    public string signupotpv_db(string userid, string mobno, string passwd, string otp, string cat)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.signupotpv(userid, mobno, passwd, otp, cat);
    }
    [WebMethod]
    public DataTable madu_load_db(string n, string val)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.madu_load(n, val);
    }

    //digital
    [WebMethod]
    public DataTable Get_training_modulewise_db(string UserId, int CompanyID, int ModuleType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_training_modulewise(UserId, CompanyID, ModuleType);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Exam_modulewise_db(string UserId, int CompanyID, int ModuleType)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Exam_modulewise(UserId, CompanyID, ModuleType);
        return Dts;
    }


    //end digital
    //SURVEY AND POLLING
    //VISHNU

    [WebMethod]
    public DataTable Poll_Dashboard_Counts_User_DB(int CMPID, string UserID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_Counts_User(CMPID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Poll_Dashboard_TopTrend_User_db(int CMPID, string UserID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_TopTrend_User(CMPID, UserID);
        return Dts;
    }
    [WebMethod]
    public DataTable Poll_Dashboard_TopTrend_Quest_User_db(int CMPID, string UserID)
    {

        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Poll_Dashboard_TopTrend_Quest_User(CMPID, UserID);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_SrvyPoll_QnsType_db(int CompanyID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Srvypoll_QnsType(CompanyID);
        return Dts;
    }
    [WebMethod]
    public string Insert_InstantPollQns_db(string Instpoll_question, int CategoryType, string modifidby, int companyid, int moduleid, string answeropt, int QnsType, int TrngID, int SessionID, string PollName, int InStPollExistID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Insert_InstantPollQns(Instpoll_question, CategoryType, modifidby, companyid, moduleid, answeropt, QnsType, TrngID, SessionID, PollName, InStPollExistID);
    }

    [WebMethod]
    public DataTable Get_ILTSessn_Exists_db(int CompID, string UserID, int TrngID, int SessnID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_ILTSessn_Exists(CompID, UserID, TrngID, SessnID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_InstPOll_Exists_db(int CompID, string UserID, int TrngID, int SessnID, string CreatedDate)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_InstPOll_Exists(CompID, UserID, TrngID, SessnID, CreatedDate);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Instantpoll_User_db(int CompID, string UserID, int TrngID, int SessnID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instantpoll_User(CompID, UserID, TrngID, SessnID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Instantpoll_Ans_db(int CompID, string UserID, int TrngID, int QnsID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instantpoll_Ans(CompID, UserID, TrngID, QnsID);
        return Dts;
    }
    [WebMethod]
    public string Insert_InstantPollQnsUserTrk_db(string UserID, int InstPollID, int QnsID, int AnsID, string PollName, string PollCode, int ModuleID, string CreatedBy, int CompanyID, int QnsType, int TrngID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Insert_InstantPollQnsUserTrk(UserID, InstPollID, QnsID, AnsID, PollName, PollCode, ModuleID, CreatedBy, CompanyID, QnsType, TrngID);
    }
    [WebMethod]
    public DataTable Get_Instantpoll_Dtls_Instr_db(int CompID, string UserID, int TrngID, int SessionID, string Searchtext, int ModuleID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instantpoll_Dtls_Instr(CompID, UserID, TrngID, SessionID, Searchtext, ModuleID);
        return Dts;
    }

    [WebMethod]
    public DataTable Get_Instpoll_MapQns_Dtls_Instr_db(int CompID, string UserID, int TrngID, int SessionID, string Searchtext, int InstPollID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instpoll_MapQns_Dtls_Instr(CompID, UserID, TrngID, SessionID, Searchtext, InstPollID);
        return Dts;
    }

    [WebMethod]
    public DataSet Get_Instpoll_Respond_Usrs_db(int CompID, int QnsID, int TrngID, int SessionID, string Searchtext, int InstPollID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instpoll_Respond_Usrs(CompID, QnsID, TrngID, SessionID, Searchtext, InstPollID);
        return Dts;
    }
    [WebMethod]
    public DataTable Get_Instpoll_Dtls_User_db(int CompID, string UserID, int TrngID, int SessionID, string Searchtext)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Instpoll_Dtls_User(CompID, UserID, TrngID, SessionID, Searchtext);
        return Dts;
    }
    //END VISHNU
    //ADRASH

    [WebMethod]
    public DataTable Fetch_pool_answers_db(int questionid, int compId, int moduletype, int catogery)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_poll_answers(questionid, compId, moduletype, catogery);
        return Dts;
    }

    [WebMethod]
    public string insert_createSurveytype(string surveyname, int surveyCode, string surv_disrib, int ser_status, int moduletype, int compny_id, string create_by, string survtype)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_new_survey(surveyname, surveyCode, surv_disrib, ser_status, moduletype, compny_id, create_by, survtype);
    }



    [WebMethod]
    public DataTable get_surv_Details(int companyId, string userId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_survey_details(companyId, userId);
    }
    [WebMethod]
    public DataTable fetch_survy_questn_con(int servy_Id, int companId, int moduletype)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_survey_question(servy_Id, companId, moduletype);
    }
    [WebMethod]
    public DataTable fetch_survey_questn_pool(int comp_id, int modul_type, int quest_type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_servy_qustpool(comp_id, modul_type, quest_type);
    }

    [WebMethod]
    public DataTable Fetch_survey_answers_con(int questionid, int compId, int moduletype)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_survey_answer_ser(questionid, compId, moduletype);
        return Dts;
    }
    [WebMethod]
    public string create_survy_qustionpaper_con(string surv_Name, string surv_code, string surv_discript, int totqustno, string qustns_id, int surv_status, int modul_type, int compny_Id, string createdBy, string modifby, int survytype)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_questionpaper_ser(surv_Name, surv_code, surv_discript, totqustno, qustns_id, surv_status, modul_type, compny_Id, createdBy, modifby, survytype);
    }


    [WebMethod]
    public DataTable Fetch_Poll_LIst_db(int COMPY_ID, int module_ID, int sort, int filter)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Fetch_Poll_LIst(COMPY_ID, module_ID, sort, filter);
        return Dts;
    }

    [WebMethod]
    public string survy_updte_con(string survy_name, string survstrat_date, string survend_date)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.survey_details_update_ser(survy_name, survstrat_date, survend_date);
    }
    [WebMethod]
    public DataTable fetch_survy_audience_con(int companyId)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_audience(companyId);
    }
    [WebMethod]
    public string survay_share_update(int compny_id, int moduleId, int QUS_ID, string strt_date, string end_date, string strt_time, string end_Time, string Audi_str, string email_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.share_survey_upadte(compny_id, moduleId, QUS_ID, strt_date, end_date, strt_time, end_Time, Audi_str, email_txt);
    }
    [WebMethod]
    public DataTable Fetch_Poll_Qus_db(int COMPY_ID, int module_ID, int sort, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Fetch_Poll_Qus(COMPY_ID, module_ID, sort, user_id);
        return Dts;
    }

    [WebMethod]
    public DataTable fetch_sury_maping_con(int COMPY_ID, int module_ID, int survy_id, string User_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_user_survey_map(COMPY_ID, module_ID, survy_id, User_id);
        return Dts;
    }

    [WebMethod]
    public string Srvy_AudiLoop_custom_db(int SrvyID, int compny_id, int moduleId, string CustomAudiList)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Srvy_AudiLoop_custom(SrvyID, compny_id, moduleId, CustomAudiList);
    }

    [WebMethod]
    public DataTable Fetch_Poll_Qustion_option_db(int COMPY_ID, int module_ID, int QUS_ID, string user_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Fetch_Poll_Qustion_option(COMPY_ID, module_ID, QUS_ID, user_id);
        return Dts;
    }
    [WebMethod]
    public string update_sury_track_details(string user_id, int serv_id, int questId, string answers_id, int modultype, int compnyid)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.servy_usr_tarck_detil_insert(user_id, serv_id, questId, answers_id, modultype, compnyid);
    }
    //END ADRASH

    [WebMethod]
    public string Ins_Poll_Share_dtails_db(int compnyId, int moduleId, int QUS_ID, string Start_Time, string End_Time, string Start_Date_save, string End_Date_save, string Audi_str, string email_txt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Ins_Poll_Share_dtails(compnyId, moduleId, QUS_ID, Start_Time, End_Time, Start_Date_save, End_Date_save, Audi_str, email_txt);
    }

    //END SURVEY AND POLLING





    //---------------- Start blended curriculum Module ------------------//
    //Dileep Blended Start

    [WebMethod]
    public int Check_UserId_Exist_db(string userId)
    {
        int outResult = 0;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        outResult = sercon.Check_UserId_Exist(userId);
        return outResult;
    }

    [WebMethod]
    public DataSet Blended_CheckCourseCompletion_db(int companyId, int blendedId, int moduleId, string userId, string blendedUserTrackId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Blended_CheckCourseCompletion(companyId, blendedId, moduleId, userId, blendedUserTrackId);
        return ds;
    }

    [WebMethod]
    public DataTable Ble_Get_ActivityModules_db(int companyId)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Ble_Get_ActivityModules(companyId);
        return Dts;
    }
    //[WebMethod]
    //public DataTable Ble_Get_Activities_db(int companyId, int trainingId, string selectedCategories, string selectedSubCategories, string selectedModules, string searchText)
    //{
    //    DataTable Dts = new DataTable();
    //    System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
    //    Dts = sercon.Ble_Get_Activities(companyId, trainingId, selectedCategories, selectedSubCategories, selectedModules, searchText);
    //    return Dts;
    //}
    [WebMethod]
    public string Insert_Blended_Curriculum_Index2_db(int courseId, int companyId, string addedClustSettings, string addedActivitySettings, string action, int pageStatus, string modifiedBy, int moduleId)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_Blended_Curriculum_Index2(courseId, companyId, addedClustSettings, addedActivitySettings, action, pageStatus, modifiedBy, moduleId);
        return str;
    }
    [WebMethod]
    public string Insert_Blended_Curriculum_Cluster_db(int courseId, int companyId, int is_PassAllIndiActivities, int is_Sequence, int passPercent, string dueStartDate, string dueEndDate, int dueDays, int is_DueToday, int minActiToAttend, int is_AttendAll, string activitySettings, string action, int pageStatus, string modifiedBy, int moduleId, string clusterName)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_Blended_Curriculum_Cluster(courseId, companyId, is_PassAllIndiActivities, is_Sequence, passPercent, dueStartDate, dueEndDate, dueDays, is_DueToday, minActiToAttend, is_AttendAll, activitySettings, action, pageStatus, modifiedBy, moduleId, clusterName);
        return str;
    }

    [WebMethod]
    public DataSet Blend_Course_User_Dtls_Fetch_db(int companyId, int courseId, int moduleId, string userId, string blendedId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Blend_Course_User_Dtls_Fetch(companyId, courseId, moduleId, userId, blendedId);
        return ds;
    }

    //---------by anjana-----------//

    [WebMethod]
    public DataSet Get_Audience_User_View_db(int prm_comp_id, int prm_trng_id, string prm_audi_id, string prm_audi_user_id, string prm_search_text)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Audience_User_View(prm_comp_id, prm_trng_id, prm_audi_id, prm_audi_user_id, prm_search_text);
        return Dts;
    }

    [WebMethod]
    public string Delete_Audi_User_db(int prm_comp_id, int prm_trng_id, string prm_audi_id, string prm_audi_user_id, string prm_delete_type, string prm_user_id)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Delete_Audi_User(prm_comp_id, prm_trng_id, prm_audi_id, prm_audi_user_id, prm_delete_type, prm_user_id);
        return str;
    }

    [WebMethod]
    public string Self_Apply_Request_db(int P_Track_ID, string P_User_id, int P_Comp_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Self_Apply_Request(P_Track_ID, P_User_id, P_Comp_id);
    }

    [WebMethod]
    public string insert_trng_paricipants_db(int prm_training_id, int prm_course_id, string prm_user_id, int prm_company_id, string prm_updateAction, int prm_trng_partcpnts_id, string prm_audi_type, string prm_participant_code, string prm_audience_name, int prm_is_selflearnable, string prm_payment_type, int prm_payment_amt, string prm_self_regn_end_dt, string prm_assign_dt_in_days, string prm_assign_date, int prm_has_duedate, string prm_due_dt_in_days, string prm_due_date, string prm_participants_list, int prm_assign_priority, int prm_status)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_trng_paricipants(prm_training_id, prm_course_id, prm_user_id, prm_company_id, prm_updateAction, prm_trng_partcpnts_id, prm_audi_type, prm_participant_code, prm_audience_name, prm_is_selflearnable, prm_payment_type, prm_payment_amt, prm_self_regn_end_dt, prm_assign_dt_in_days, prm_assign_date, prm_has_duedate, prm_due_dt_in_days, prm_due_date, prm_participants_list, prm_assign_priority, prm_status);
        return str;
    }

    [WebMethod]
    public DataTable Get_Exam_Details_From_Training_db(int CmpID, int TrngID)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Get_Exam_Details_From_Training(CmpID, TrngID);
        return dts;
    }

    [WebMethod]
    public DataTable Elearning_index_user_ble_db(int compny, int traingid, string user_id, string blendedid)
    {
        DataTable dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.Elearning_user_ble_index(compny, traingid, user_id, blendedid);
        return dts;
    }

    [WebMethod]
    public string Insert_ble_User_Traning_Attempt_History_db(int prm_history_id, int prm_course_id, int prm_training_id, int prm_trng_user_track_id, string prm_user_id, string prm_sessn_duration, string prm_attended_date, int prm_attempt_count, int prm_try_count, string prm_try_score, string prm_start_time, string prm_end_time, int prm_comp_id, string prm_updateAction, string blendedid)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Insert_ble_User_Traning_Attempt_History(prm_history_id, prm_course_id, prm_training_id, prm_trng_user_track_id, prm_user_id, prm_sessn_duration, prm_attended_date, prm_attempt_count, prm_try_count, prm_try_score, prm_start_time, prm_end_time, prm_comp_id, prm_updateAction, blendedid);
        return str;
    }


    [WebMethod]
    public string insert_blended_curriculum_index1_db(int prm_blend_cur_id, int prm_course_id, int prm_company_id, string prm_blend_cur_name, string prm_code, string prm_description, string prm_blend_cur_status, int prm_avail_reg, int prm_priority, string prm_course_owner, int prm_active_status, string prm_start_date, string prm_end_date, int prm_no_of_days, string prm_due_date, string prm_expiry_date, string prm_user_id, string prm_updateAction, int prm_page_status,
    int crsCategoryId, int crsSubCategoryId, int trngType, int competency, int coreCompetencyId, int subCompetencyId, string createdBy, int hasExam, int isRecommend, int userExpiryDays, int userDueDays, string prm_mark_grade_temp_id, string prm_relativeCourseId)



    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_blended_curriculum_index1(prm_blend_cur_id, prm_course_id, prm_company_id, prm_blend_cur_name, prm_code, prm_description, prm_blend_cur_status, prm_avail_reg, prm_priority, prm_course_owner, prm_active_status, prm_start_date, prm_end_date, prm_no_of_days, prm_due_date, prm_expiry_date, prm_user_id, prm_updateAction, prm_page_status,
        crsCategoryId, crsSubCategoryId, trngType, competency, coreCompetencyId, subCompetencyId, createdBy, hasExam, isRecommend, userExpiryDays, userDueDays, prm_mark_grade_temp_id, prm_relativeCourseId);
        return str;
    }

    [WebMethod]
    public DataSet Get_Ble_Prerequisite_Course_Info_db(int companyId, int trainingId, string userId, int moduleId)
    {
        DataSet ds = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        ds = sercon.Get_Ble_Prerequisite_Course_Info(companyId, trainingId, userId, moduleId);
        return ds;
    }

    [WebMethod]
    public DataSet GetBle_TrainingSessionDetails_db(int trainingId, int companyId, string userId, string BlendedId)
    {
        DataSet Dts = new DataSet();



        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.GetBle_TrainingSessionDetails(trainingId, companyId, userId, BlendedId);



        return Dts;
    }



    [WebMethod]
    public string Blended_User_Finish_Course_db(int ble_training_id, int company_id, int ble_course_id, string user_id)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.Blended_User_Finish_Course(ble_training_id, company_id, ble_course_id, user_id);
        return str;
    }

    [WebMethod]
    public string insert_blended_curriculum_index3_db(int prm_blend_cur_id, int prm_course_id, int prm_company_id, string prm_certificate_temp_id, string prm_feedback_list, string prm_appvr_list, int prm_apprv_status, string prm_user_id, string prm_updateAction, int prm_page_status, string notific_typestr, string notific_modestr, string notific_Intstr, string sartdatrstr, string enddatrstr, string sarttimestr, string endtimestr, string AutoNotific, string audiList, int has_feedback)

    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_blended_curriculum_index3(prm_blend_cur_id, prm_course_id, prm_company_id, prm_certificate_temp_id, prm_feedback_list, prm_appvr_list, prm_apprv_status, prm_user_id, prm_updateAction, prm_page_status, notific_typestr, notific_modestr, notific_Intstr, sartdatrstr, enddatrstr, sarttimestr, endtimestr, AutoNotific, audiList, has_feedback);
        return str;
    }

    [WebMethod]
    public DataSet get_blended_curriculum_dtls_db(int Comp_id, int Trng_id, int Module_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_blended_curriculum_dtls(Comp_id, Trng_id, Module_id);
    }

    [WebMethod]
    public DataSet get_userwise_blended_curriculum_dtls_db(int Comp_id, int Trng_id, int Module_id, string user_id, int blend_usr_trng_track_id, string ble_act_clu_Id, string ble_activity_Id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.get_userwise_blended_curriculum_dtls(Comp_id, Trng_id, Module_id, user_id, blend_usr_trng_track_id, ble_act_clu_Id, ble_activity_Id);
    }


    [WebMethod]
    public string insert_course_topic_db(int comp_id, string topic_name, int status, int action, string topic_id, string created_by)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_course_topic(comp_id, topic_name, status, action, topic_id, created_by);

    }

    // insert topics 12-06-2021

    //fetch topics using count 12-6-2021

    [WebMethod]
    public DataSet fetch_topics_used_counts_db(int EmpCompId, string topic_id)
    {
        DataSet dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        dts = sercon.fetch_topics_used_counts(EmpCompId, topic_id);
        return dts;
    }

    //fetch topics using count 12-6-2021

    //update course topics 12-6-2021
    [WebMethod]
    public string update_course_topic_db(int Comp_ID, string topic_name, int type, string main_topic_id, string sub_topic_id,
    string topic_id, string edited_by)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.update_course_topic(Comp_ID, topic_name, type, main_topic_id, sub_topic_id, topic_id, edited_by);

    }

    //update course topics 12-6-2021

    //Delete course topic 15-06-2021
    [WebMethod]
    public string delete_course_topic_db(int type, string delete_id, string modified_by, int Comp_ID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.delete_course_topic(type, delete_id, modified_by, Comp_ID);

    }

    //Delete course topic 15-06-2021

    [WebMethod]
    public string feedback_button_condition_check_db(int tr_id, int comp_id, string usrid)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.feedback_button_condition_check(tr_id, comp_id, usrid);
    }

    //session wise feedback save 07-4-2021

    [WebMethod]
    public string save_session_wise_feedback_db(string userid, int sury_id, string questId, string ansId, string textmesg, int fedstatus,
    int modleype, int comp_id, string createdby, int sess_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.save_session_wise_feedback(userid, sury_id, questId, ansId, textmesg, fedstatus, modleype, comp_id, createdby, sess_id);
    }

    //session wise feedback save 07-4-2021


    //condition for sess_feedback_button 4-4-21
    [WebMethod]
    public string condition_for_sess_feedback_btn_db(int trangId, int COMPY_ID, int ModUle, int sess_id, string usrid)
    {
        string str = "";
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.condition_for_sess_feedback_btn(trangId, COMPY_ID, ModUle, sess_id, usrid);
        return str;
    }
    //condition for sess_feedback_button 4-4-21


    //fetch sessionwise feedback 03-04-2021
    [WebMethod]
    public DataTable session_wise_feedback_fetch_db(int trangId, int COMPY_ID, int ModUle, int sess_id, string usrid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.session_wise_feedback_fetch(trangId, COMPY_ID, ModUle, sess_id, usrid);
        return Dts;
    }
    //fetch sessionwise feedback 03-04-2021


    [WebMethod]
    public string insert_blended_training_approval_dtls_db(int blended_id, int prm_company_id, int prm_course_id, string prm_approval_status, string prm_created_by, string prm_updateAction, int prm_page_status)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_blended_training_approval_dtls(blended_id, prm_company_id, prm_course_id, prm_approval_status, prm_created_by, prm_updateAction, prm_page_status);
        return str;
    }

    //ajay blended end 
    //---------by anjana-----------//
    //ajay blended start ilt user
    [WebMethod]
    public string uilt_feedback_user_track_blended(string userid, int sury_id, string questId, string ansId, string textmesg, int fedstatus, int modleype, int comp_id, string createdby, int blended_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insert_feedbackusertrack_blended(userid, sury_id, questId, ansId, textmesg, fedstatus, modleype, comp_id, createdby, blended_id);
    }
    //ajay blended end ilt user
    //---------------- End blended curriculum Module ------------------//

    //survey and poll
    [WebMethod]
    public string Create_New_Poll_Qus_Paper_db(int compnyId, int moduleId, string User_id, string QP_name)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Create_New_Poll_Qus_Paper(compnyId, moduleId, User_id, QP_name);
    }


    [WebMethod]
    public DataTable fetch_Pool_questn_pool_db(int comp_id, int modul_type, int category, int Qus_type)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.fetch_Pool_questn_pool(comp_id, modul_type, category, Qus_type);
    }


    [WebMethod]
    public string Ins_Poll_Selected_qus_db(int compnyId, int moduleId, string User_id, string QP_name, int QUS_ID, string Qus_str)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Ins_Poll_Selected_qus(compnyId, moduleId, User_id, QP_name, QUS_ID, Qus_str);
    }

    [WebMethod]
    public DataSet fetch_user_survey_report_con(int comp_id, int module_id, int survy_id)
    {

        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_user_survey_report_ser(comp_id, module_id, survy_id);

        return Dts;
    }

    [WebMethod]
    public DataTable fetch_sury_report_table(int modulId, int compnyId, int surveyid)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_servy_result_table(modulId, compnyId, surveyid);
        return Dts;
    }

    [WebMethod]
    public DataSet fetch_sury_report_usr_tble(int modulId, int surevy_id, int compnyId, int qustnId, string usrId)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_servy_usr_report_tbl(modulId, surevy_id, compnyId, qustnId, usrId);
        return Dts;
    }


    [WebMethod]
    public string Insert_survey_quest_db(string survy_question, string survytype, int qust_type, string modifidby, int companyid, int moduleid, string answeropt)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.insrt_surveyquestion(survy_question, survytype, qust_type, modifidby, companyid, moduleid, answeropt);
    }


    // end survey and poll


    //madu portal

    [WebMethod]
    public string plan_dtl_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return "Hello World";
    }

    [WebMethod]
    public string plan_subscribe_db()
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return "Hello World";
    }

    //change pass
    [WebMethod]
    public string Change_Password_db(string userID, string Currentpsswrd, string NewPassword, int CompanyID, string modifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Change_Password(userID, Currentpsswrd, NewPassword, CompanyID, modifiedBy);
    }
    //
    //poll
    [WebMethod]
    public string Poll_usr_tarck_detil_insert_db(string user_id, int serv_id, int questId, string answers_id, int modultype, int compnyid, int QnsType)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Poll_usr_tarck_detil_insert(user_id, serv_id, questId, answers_id, modultype, compnyid, QnsType);
    }
    [WebMethod]
    public DataTable Get_Poll_MapQns_Dtls_admin_db(int CompID, string UserID, string Searchtext, int PollID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Poll_MapQns_Dtls_admin(CompID, UserID, Searchtext, PollID);
        return Dts;
    }
    [WebMethod]
    public DataSet Get_Poll_Respond_Usrs_db(int CompID, int QnsID, string Searchtext, int PollID)
    {
        DataSet Dts = new DataSet();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Get_Poll_Respond_Usrs(CompID, QnsID, Searchtext, PollID);
        return Dts;
    }


    //NEW 
    [WebMethod]
    public DataTable PollExists_db(int CompanyID, string UserID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.PollExists(CompanyID, UserID);
    }

    [WebMethod]
    public string DeletepollQns_db(int Id, string ModifiedBy)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.DeletepollQns(Id, ModifiedBy);
    }
    [WebMethod]
    public string Deletepoll_db(int Id, string ModifiedBy, int ModuleID)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.Deletepoll(Id, ModifiedBy, ModuleID);
    }
    //NEW END

    [WebMethod]
    public DataTable fetch_Priority_type(int CompID)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.fetch_Priority_type(CompID);
        return Dts;
    }

    [WebMethod]
    public DataTable Report_Elearning_db(string P_From_date, string P_To_date, int P_Comp_ID, int P_Fetch_count, int Min_count)
    {

        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;

        return sercon.Report_Elearning(P_From_date, P_To_date, P_Comp_ID, P_Fetch_count, Min_count);
    }

    [WebMethod]
    public string insert_elearning_training_dtls_secndy_pg_db(int prm_training_id, int prm_course_id, string prm_start_date, string prm_end_date, int prm_no_of_days, string prm_expiry_date, int prm_no_of_attmpt, string prm_crs_duratn, string prm_participants_list, int prm_certificate_temp_id, string prm_feedback_list, string prm_appvr_list, int prm_apprv_status, int prm_apprv_active_status, string prm_user_id, int prm_company_id, string prm_updateAction, int prm_page_status, int prm_has_feedback, int prm_mark_grade_temp_id, int Expire_days, int Due_days)
    {
        string str;
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        str = sercon.insert_elearning_training_dtls_secndy_pg(prm_training_id, prm_course_id, prm_start_date, prm_end_date, prm_no_of_days, prm_expiry_date, prm_no_of_attmpt, prm_crs_duratn, prm_participants_list, prm_certificate_temp_id, prm_feedback_list, prm_appvr_list, prm_apprv_status, prm_apprv_active_status, prm_user_id, prm_company_id, prm_updateAction, prm_page_status, prm_has_feedback, prm_mark_grade_temp_id, Expire_days, Due_days);
        return str;
    }

    [WebMethod]
    public DataTable Exam_Selected_Audience(int COMPY_ID, int Exam_id)
    {
        DataTable Dts = new DataTable();
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        Dts = sercon.Exam_Selected_Audience(COMPY_ID, Exam_id);
        return Dts;
    }​​​​​
     [WebMethod]
    public string admin_edit_status_db(int comp_id, int tr_id)
    {
        System.Net.ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
        return sercon.admin_edit_status(comp_id, tr_id);
    }

    }
    
   
