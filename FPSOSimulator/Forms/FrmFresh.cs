using FPSOSimulator;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FPSOSimulator.Forms
{
    public delegate void CloseFormClient();
    class FrmFresh
    {
       
        public enum FrmTypes
        {
            FrmExit,
            frmMain,
            NFRMDefectInfoSet,
            NFRMAlarm,
            //frmShowModelValue,
            NFRMParasSet,
            NFRMDefectHistory,
            FrmClient



        }
        public event FPSOSimulator.Forms.CloseFormClient CloseClientNow;
        public FrmBack myFrmBack = new FrmBack();
        private List<Form> myForms;
        private FrmTypes myFrmType;
        private FrmTypes myFrmTypePre;
        private static FrmFresh myFrmFresh;

        /// <summary>
        /// 私有构造函数，防止实例化
        /// </summary>
        private FrmFresh()
        {

        }

        /// <summary>
        /// 初始化窗体列表
        /// </summary>
        public void InitForms()
        {
            FrmBase.SetMyUI();
            FrmBase.SetUserConfiguration();
            
            myForms = new List<Form>();
            FrmBase myFrmBase;
            myFrmBase = GetForms(FrmTypes.frmMain);
            myForms.Add(myFrmBase);
            myFrmBase = GetForms(FrmTypes.NFRMDefectInfoSet);
            myForms.Add(myFrmBase);
            myFrmBase = GetForms(FrmTypes.NFRMAlarm);
            myForms.Add(myFrmBase);
            //myFrmBase = GetForms(FrmTypes.frmShowModelValue);
            //myForms.Add(myFrmBase);
            myFrmBase = GetForms(FrmTypes.NFRMParasSet);
            myForms.Add(myFrmBase);
            myFrmBase = GetForms(FrmTypes.NFRMDefectHistory);
            myForms.Add(myFrmBase);

            myFrmBase = GetForms(FrmTypes.FrmClient);
            myForms.Add(myFrmBase);
            //myFrmBase = GetForms(FrmTypes.FrmFuelCurvenm);
            //myForms.Add(myFrmBase);
            //myFrmBase = GetForms(FrmTypes.FrmFuelCurvekw);
            //myForms.Add(myFrmBase);
            //myFrmBase = GetForms(FrmTypes.FrmFuelTime);
            //myForms.Add(myFrmBase);
            InitShow();
        }

        /// <summary>
        /// 初始显示
        /// </summary>
        private void InitShow()
        {
            myFrmBack.Hide();
            myFrmType = FrmTypes.frmMain;
            this.ShowForms();
            myFrmTypePre = myFrmType;
            
        }

        /// <summary>
        /// 创建各种窗体
        /// </summary>
        /// <param name="frmType"></param>
        /// <returns></returns>
        private FrmBase GetForms(FrmTypes frmType)
        {
            FrmBase myFrmBase = null;
            switch (frmType)
            {
                case FrmTypes.frmMain:
                    myFrmBase = new frmMain();
                    break;
                case FrmTypes.NFRMDefectInfoSet:
                    myFrmBase = new NFRMDefectInfoSet();
                    break;
                case FrmTypes.NFRMAlarm:
                    myFrmBase = new NFRMAlarm();
                    break;
                //case FrmTypes.frmShowModelValue:
                //    myFrmBase = new frmShowModelValue();
                //    break;
                case FrmTypes.NFRMParasSet:
                    myFrmBase = new NFRMParasSet();
                    break;
                case FrmTypes.NFRMDefectHistory:
                    myFrmBase = new NFRMDefectHistory();
                    break;
                case FrmTypes.FrmClient:
                    myFrmBase = new FrmClient();
                    //CloseClientNow += new CloseFormClient(myFrmBase.F_CloseClient());
                    break;
                    //case FrmTypes.FrmFuelCurvekw:
                    //    myFrmBase = new FrmFuelCurvekw();
                    //    break;
                    //case FrmTypes.FrmFuelTime:
                    //    myFrmBase = new FrmFuelTime();
                    //    break;
            }
            return myFrmBase;
        }

        /// <summary>
        /// 设置窗体类型
        /// </summary>
        /// <param name="frmType"></param>
        public void SetFrmType(FrmTypes frmType)
        {
            this.myFrmType = frmType;
        }

        /// <summary>
        /// 改变显示的窗体
        /// </summary>
        /// <returns></returns>
        public bool ChangeForms()
        {
            bool isShowOk = false;
            bool isHideOk = false;
            bool isOk = false;
            isShowOk = ShowForms();
            isHideOk = HideForms();
            myFrmTypePre = myFrmType;
            isOk = isShowOk && isHideOk;
            return isOk;
        }

        /// <summary>
        /// 显示窗体
        /// </summary>
        /// <returns></returns>
        private bool ShowForms()
        {
            FrmBase myForm;
           
            bool isOk = false;
            if (myFrmType != myFrmTypePre)
            {
                switch (myFrmType)
                {
                    case FrmTypes.frmMain:
                        myForm = (frmMain)myForms[0];
                        myForm.FrmShow();
                        break;
                    case FrmTypes.NFRMDefectInfoSet:
                        myForm = (NFRMDefectInfoSet)myForms[1];
                        myForm.FrmShow();
                        break;
                    case FrmTypes.NFRMAlarm:
                        myForm = (NFRMAlarm)myForms[2];
                        myForm.FrmShow();
                        break;
                    //case FrmTypes.frmShowModelValue:
                    //    myForm = (frmShowModelValue)myForms[3];
                    //    myForm.FrmShow();
                    //    break;
                    case FrmTypes.NFRMParasSet:
                        myForm = (NFRMParasSet)myForms[3];
                        myForm.FrmShow();
                        break;

                    case FrmTypes.NFRMDefectHistory:
                        myForm = (NFRMDefectHistory)myForms[4];
                        myForm.FrmShow();
                        break;
                    //case FrmTypes.FrmFuelCurvenm:
                    //    myForm = (FrmFuelCurvenm)myForms[5];
                    //    myForm.FrmShow();
                    //    break;
                    //case FrmTypes.FrmFuelCurvekw:
                    //    myForm = (FrmFuelCurvekw)myForms[6];
                    //    myForm.FrmShow();
                    //    break;
                    case FrmTypes.FrmClient:

                        myForm = (FrmClient)myForms[5];
                        myForm.FrmShow();
                        break;
                }
            }
            isOk = true;
            return isOk;
        }

        /// <summary>
        /// 退出系统，关闭所有窗体
        /// </summary>
        private void CloseForms()
        {
            if (myFrmType == FrmTypes.FrmExit)
            {
                myFrmBack.FrmClose();
                //FrmBase myForm;
                foreach (FrmBase myform in myForms)

                {
                    myform.FrmClose();
                    myform.Close();
                }
            }
        }

        /// <summary>
        /// 隐藏窗体
        /// </summary>
        /// <returns></returns>
        private bool HideForms()
        {
            FrmBase myForm;
            bool isOk = false;
            if (myFrmType != myFrmTypePre)
            {
                switch (myFrmTypePre)
                {
                    case FrmTypes.FrmExit:
                        myFrmBack.Close();
                        break;
                    case FrmTypes.frmMain:
                        myForm = (frmMain)myForms[0];
                        myForm.FrmHide();
                        break;
                    case FrmTypes.NFRMDefectInfoSet:
                        myForm = (NFRMDefectInfoSet)myForms[1];
                        myForm.FrmHide();
                        break;
                     case FrmTypes.NFRMAlarm:
                        myForm = (NFRMAlarm)myForms[2];
                        myForm.FrmHide();
                        break;                   
                    //case FrmTypes.frmShowModelValue:
                    //    myForm = (frmShowModelValue)myForms[3];
                    //    myForm.FrmHide();
                    //    break;
                    case FrmTypes.NFRMParasSet:
                        myForm = (NFRMParasSet)myForms[3];
                        myForm.FrmHide();
                        break;
                    case FrmTypes.NFRMDefectHistory:
                        myForm = (NFRMDefectHistory)myForms[4];
                        myForm.FrmHide();
                        break;


                    case FrmTypes.FrmClient:
                        myForm = (FrmClient)myForms[5];
                        myForm.FrmHide();
                        break;
                        //case FrmTypes.FrmFuelCurvekw:
                        //    myForm = (FrmFuelCurvekw)myForms[6];
                        //    myForm.FrmHide();
                        //    break;
                        //case FrmTypes.FrmFuelTime:
                        //    myForm = (FrmFuelTime)myForms[7];
                        //    myForm.FrmHide();
                        //    break;
                }
            }
            isOk = true;
            return isOk;
        }

        /// <summary>
        /// 获取刷新界面类
        /// </summary>
        /// <returns></returns>
        public static FrmFresh GetFrmFresh()
        {
            if (myFrmFresh == null)
            {
                myFrmFresh = new FrmFresh();
            }
            return myFrmFresh;
        }

        /// <summary>
        /// 执行刷新
        /// </summary>
        public void ExecFrmFresh()
        {
            this.ChangeForms();
            this.InvokeDelegate();
            this.CloseForms();
        }

        #region "my Delegate for form refresh"
        #region "Delegate add for all
        /// <summary>
        /// add routine
        /// </summary>
        /// <param name="mdelegate"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void DelegateAdd(FrmRefreshDelegate mdelegate)
        {
            try
            {
                myFrmRefreshDelegate = (FrmRefreshDelegate)Delegate.Combine(myFrmRefreshDelegate, mdelegate);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Remove routine
        /// </summary>
        /// <param name="mdelegate"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void DelegateRemove(FrmRefreshDelegate mdelegate)
        {
            try
            {
                myFrmRefreshDelegate = (FrmRefreshDelegate)Delegate.Remove(myFrmRefreshDelegate, mdelegate);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// invoke delegate
        /// </summary>
        public void InvokeDelegate()
        {
            try
            {
                if (myFrmRefreshDelegate != null)
                {
                    myFrmRefreshDelegate();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        /// <summary>
        /// Form Refresh Delegate
        /// </summary>
        public delegate void FrmRefreshDelegate();
        private FrmRefreshDelegate myFrmRefreshDelegate;
        #endregion

    }
}
