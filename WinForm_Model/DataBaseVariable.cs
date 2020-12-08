using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Model
{
    class DataBaseVariable
    {
        
    
        static string AppName = "GB Data Ver 1.0.2020";
        static string g_DSS_ID;
        static string g_iPOP_ID;
        static Form frm;
        static Form frmlogin;
        static Form frm_main2;
        static bool IsHold;
        static string usrID;
        static string usrNme;
        static bool IsAdminOrUser;
        static string IsFirstOrSecondUser;
        static Form ProgBar;
        static string msgBoxCaption;
        static string Password;
        static ToolStripMenuItem frmEnrollment;
        static ToolStripMenuItem frmFollowup;
        static ToolStripMenuItem frmLabForm;
        static ToolStripMenuItem frmRandomisation;
        static ToolStripMenuItem frmReconfirmEligibility;
        static ToolStripMenuItem frmArms;
        static string MotherName;
        static int WhichReport;
        static string g_DBName;
        static bool IsPilotPhaseEntry = false;
        static public bool Success = false;
        static string tabname = "";
        static DateTime StartDt;
        static DateTime EndDt;
        static DateTime StartDate_Audit;
        static DateTime EndDate_Audit;
        static bool IsDateWise = false;
        static bool IsUserWise = false;
        static bool IsWholeReport = false;
        static bool IsErr = false;
        static bool IsMonthWise = false;
        static string uID = "";

        static bool val1 = false;
        static bool val2 = false;
        static bool val3 = false;
        static bool CohortCase = false;
        static bool IsNotEligibile = false;


        static bool iserrormsg = false;



        static string _dtabname = "";
        static string _dform_id = "";
        static string _dvisitid = "";
        static bool _disdual = false;
        static bool _disupdatefromdual = false;
        static string _dentryname = "";
        static Form _dual_form_show;
        static bool _dualnormalupdate = false;
        static string _dualfieldname = "";
        static string _dualformno = "";

        static int _childno = 0;
        static int _childcount_dtl = 1;


        static string _citycode = "0";


        static double _clusterno = 0;
        static double _formid = 0;
        static int _hhno = 0;

        static bool _isformopen = false;


        static bool myval = false;

        static bool IsEligible = false;


        static string _dual_form_id;
        static string _dual_child_sno;


        static string _stddt;
        static string _etdt;

        static string lang;



        public DataBaseVariable(string AppName)
        {
            AppName = AppName;
        }


        public static string EligibilityID
        {
            get
            {
                return g_DSS_ID;
            }

            set
            {
                g_DSS_ID = value;
            }
        }

        public static string iPOPID
        {
            get
            {
                return g_iPOP_ID;
            }

            set
            {
                g_iPOP_ID = value;
            }
        }

        public static string AppName1
        {
            get
            {
                return AppName;
            }

            set
            {
                AppName = value;
            }
        }

        public static Form frm1
        {
            get
            {
                return frm;
            }

            set
            {
                frm = value;
            }
        }

        public static Form frmlogin1
        {
            get
            {
                return frmlogin;
            }

            set
            {
                frmlogin = value;
            }
        }


        public static bool IsHold1
        {
            get
            {
                return IsHold;
            }

            set
            {
                IsHold = value;
            }
        }

        public static string UserID
        {
            get
            {
                return usrID;
            }

            set
            {
                usrID = value;
            }
        }

        public static string UserName
        {
            get
            {
                return usrNme;
            }

            set
            {
                usrNme = value;
            }
        }


        public static string IsUserFirstOrSecond
        {
            get
            {
                return IsFirstOrSecondUser;
            }

            set
            {
                IsFirstOrSecondUser = value;
            }
        }


        public static Form frmProgBar
        {
            get
            {
                return ProgBar;
            }

            set
            {
                ProgBar = value;
            }
        }

        public static string SetCaption
        {
            get
            {
                return msgBoxCaption;
            }

            set
            {
                msgBoxCaption = value;
            }
        }

        public static bool IsAdmin
        {
            get
            {
                return IsAdminOrUser;
            }

            set
            {
                IsAdminOrUser = value;
            }
        }


        public static string GetPassword
        {
            get
            {
                return Password;
            }

            set
            {
                Password = value;
            }
        }


        public static ToolStripMenuItem EnableDisableEnrollment
        {
            get
            {
                return frmEnrollment;
            }

            set
            {
                frmEnrollment = value;
            }
        }


        public static ToolStripMenuItem EnableDisableFollowup
        {
            get
            {
                return frmFollowup;
            }

            set
            {
                frmFollowup = value;
            }
        }


        public static ToolStripMenuItem EnableDisableLabForm
        {
            get
            {
                return frmLabForm;
            }

            set
            {
                frmLabForm = value;
            }
        }


        public static ToolStripMenuItem EnableDisableRandomisation
        {
            get
            {
                return frmRandomisation;
            }

            set
            {
                frmRandomisation = value;
            }
        }



        public static ToolStripMenuItem EnableDisableReconfirmEligibility
        {
            get
            {
                return frmReconfirmEligibility;
            }

            set
            {
                frmReconfirmEligibility = value;
            }
        }


        public static ToolStripMenuItem EnableDisableArms
        {
            get
            {
                return frmArms;
            }

            set
            {
                frmArms = value;
            }
        }


        public static string GetSetMotherName
        {
            get
            {
                return MotherName;
            }

            set
            {
                MotherName = value;
            }
        }

        public static int IsDualEntryReport
        {
            get
            {
                return WhichReport;
            }

            set
            {
                WhichReport = value;
            }
        }

        public static string GetDBName
        {
            get
            {
                return g_DBName;
            }

            set
            {
                g_DBName = value;
            }
        }


        public static bool PilotPhaseEntry
        {
            get
            {
                return IsPilotPhaseEntry;
            }

            set
            {
                IsPilotPhaseEntry = value;
            }
        }


        public static string tablename
        {
            get
            {
                return tabname;
            }

            set
            {
                tabname = value;
            }
        }


        public static DateTime StartDate
        {
            get
            {
                return StartDt;
            }

            set
            {
                StartDt = value;
            }
        }


        public static DateTime EndDate
        {
            get
            {
                return EndDt;
            }

            set
            {
                EndDt = value;
            }
        }

        public static DateTime StartDate_val
        {
            get
            {
                return StartDate_Audit;
            }

            set
            {
                StartDate_Audit = value;
            }
        }


        public static DateTime EndDate_val
        {
            get
            {
                return EndDate_Audit;
            }

            set
            {
                EndDate_Audit = value;
            }
        }


        public static bool DateWiseGroupby
        {
            get
            {
                return IsDateWise;
            }

            set
            {
                IsDateWise = value;
            }
        }


        public static bool UserWiseGroupby
        {
            get
            {
                return IsUserWise;
            }

            set
            {
                IsUserWise = value;
            }
        }

        public static bool IsEntryStatusWholeReport
        {
            get
            {
                return IsWholeReport;
            }

            set
            {
                IsWholeReport = value;
            }
        }


        public static bool IsError
        {
            get
            {
                return IsErr;
            }

            set
            {
                IsErr = value;
            }
        }


        public static bool IsSuccess
        {
            get
            {
                return Success;
            }

            set
            {
                Success = value;
            }
        }



        public static bool MonthWiseGroupby
        {
            get
            {
                return IsMonthWise;
            }

            set
            {
                IsMonthWise = value;
            }
        }


        public static string user_ID
        {
            get
            {
                return uID;
            }

            set
            {
                uID = value;
            }
        }


        public static bool store_Value1
        {
            get
            {
                return val1;
            }

            set
            {
                val1 = value;
            }
        }


        public static bool store_Value2
        {
            get
            {
                return val2;
            }

            set
            {
                val2 = value;
            }
        }


        public static bool store_Value3
        {
            get
            {
                return val3;
            }

            set
            {
                val3 = value;
            }
        }


        public static bool store_myval
        {
            get
            {
                return myval;
            }

            set
            {
                myval = value;
            }
        }


        public static bool store_elig
        {
            get
            {
                return IsEligible;
            }

            set
            {
                IsEligible = value;
            }
        }



        public static bool IsCohortCase
        {
            get
            {
                return CohortCase;
            }

            set
            {
                CohortCase = value;
            }
        }




        public static bool IsEligibileOrNot
        {
            get
            {
                return IsNotEligibile;
            }

            set
            {
                IsNotEligibile = value;
            }
        }




        public static string dualformname
        {
            get
            {
                return _dtabname;
            }

            set
            {
                _dtabname = value;
            }
        }


        public static string dualformid
        {
            get
            {
                return _dform_id;
            }

            set
            {
                _dform_id = value;
            }
        }


        public static string dualvisitid
        {
            get
            {
                return _dvisitid;
            }

            set
            {
                _dvisitid = value;
            }
        }



        public static bool dualisperforming
        {
            get
            {
                return _disdual;
            }

            set
            {
                _disdual = value;
            }
        }


        public static bool dualisupdate
        {
            get
            {
                return _disupdatefromdual;
            }

            set
            {
                _disupdatefromdual = value;
            }
        }



        public static string dual_whichentry
        {
            get
            {
                return _dentryname;
            }

            set
            {
                _dentryname = value;
            }
        }



        public static string dual_formno
        {
            get
            {
                return _dualformno;
            }

            set
            {
                _dualformno = value;
            }
        }



        public static bool dual_normal_update
        {
            get
            {
                return _dualnormalupdate;
            }

            set
            {
                _dualnormalupdate = value;
            }
        }



        public static Form dual_form_show_hide
        {
            get
            {
                return _dual_form_show;
            }

            set
            {
                _dual_form_show = value;
            }
        }




        public static string dual_fieldname
        {
            get
            {
                return _dualfieldname;
            }

            set
            {
                _dualfieldname = value;
            }
        }



        public static bool showerror_msg
        {
            get
            {
                return iserrormsg;
            }

            set
            {
                iserrormsg = value;
            }
        }



        public static int ChildNo
        {
            get
            {
                return _childno;
            }

            set
            {
                _childno = value;
            }
        }



        public static int ChildCountDtl
        {
            get
            {
                return _childcount_dtl;
            }

            set
            {
                _childcount_dtl = value;
            }
        }



        public static int HHNo
        {
            get
            {
                return _hhno;
            }

            set
            {
                _hhno = value;
            }
        }



        public static string CityCode
        {
            get
            {
                return _citycode;
            }

            set
            {
                _citycode = value;
            }
        }


        public static double ClusterNO
        {
            get
            {
                return _clusterno;
            }

            set
            {
                _clusterno = value;
            }
        }


        public static double FormID
        {
            get
            {
                return _formid;
            }

            set
            {
                _formid = value;
            }
        }


        public static bool IsFormOpen
        {
            get
            {
                return _isformopen;
            }

            set
            {
                _isformopen = value;
            }
        }



        public static string dual_form_id
        {
            get
            {
                return _dual_form_id;
            }

            set
            {
                _dual_form_id = value;
            }
        }



        public static string dual_child_sno
        {
            get
            {
                return _dual_child_sno;
            }

            set
            {
                _dual_child_sno = value;
            }
        }



        public static string Store_StDt
        {
            get
            {
                return _stddt;
            }

            set
            {
                _stddt = value;
            }
        }



        public static string Store_EtDt
        {
            get
            {
                return _etdt;
            }

            set
            {
                _etdt = value;
            }
        }



        public static string setLanguage
        {
            get
            {
                return lang;
            }

            set
            {
                lang = value;
            }
        }


        public static Form frm_main1
        {
            get
            {
                return frm_main2;
            }

            set
            {
                frm_main2 = value;
            }
        }



    }
}
