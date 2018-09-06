using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Data;

namespace FPSOSimulator.FormInquire
{
    class InquireRefresher
    {
        #region "private fields"
        private List<InquireBase> myInqList = new List<InquireBase>();
        private Timer mytimer;
        #endregion

        #region "property"
        private string tbName;
        /// <summary>
        /// 要查询的数据表名称
        /// </summary>
        public string TbName
        {
            get
            {
                return tbName;
            }
            set
            {
                tbName = value;
            }
        }
        #endregion

        public enum InquireType
        {
            InqNull,
            InqShipSpdOptim,
            InqDraftOpt,      
            InqMETune,
            InqHullClean,
            InqFuelCurvenm,
            InqFuelCurvekw
        }

        public InquireRefresher()
        {
            InitTimer();
            InitInqList();
        }

        /// <summary>
        /// initiate inquire list，注意按enum InquireType的顺序添加
        /// </summary>
        private void InitInqList()
        {
            //InquireBase myInquireBase;
            //myInquireBase = GetInquires(InquireType.InqShipSpdOptim);
            //myInqList.Add(myInquireBase);
            //myInquireBase = GetInquires(InquireType.InqDraftOpt);
            //myInqList.Add(myInquireBase);
            //myInquireBase = GetInquires(InquireType.InqMETune);
            //myInqList.Add(myInquireBase);
            //myInquireBase = GetInquires(InquireType.InqHullClean);
            //myInqList.Add(myInquireBase);
            //myInquireBase = GetInquires(InquireType.InqFuelCurvenm);
            //myInqList.Add(myInquireBase);
            //myInquireBase = GetInquires(InquireType.InqFuelCurvekw);
            //myInqList.Add(myInquireBase);
        }

        /// <summary>
        /// 设置各个查询器
        /// </summary>
        /// <param name="inquiretype"></param>
        /// <returns></returns>
        //private InquireBase GetInquires(InquireType inquiretype)
        //{
        //    InquireBase myInquireBase = null;
        //    switch (inquiretype)
        //    {
        //        case InquireType.InqShipSpdOptim:
        //            myInquireBase = new NFRMDefectInfoSetInq();
        //            break;
        //        case InquireType.InqDraftOpt:
        //            myInquireBase = new NFRMAlarmInq();
        //            break;
        //        case InquireType.InqMETune:
        //            myInquireBase = new frmShowModelValueInq();
        //            break;
        //        case InquireType.InqHullClean:
        //            myInquireBase = new NFRMParasSetInq();
        //            break;
        //        case InquireType.InqFuelCurvenm:
        //            myInquireBase = new FrmFuelCurvenmInq();
        //            break;
        //        case InquireType.InqFuelCurvekw:
        //            myInquireBase = new FrmFuelCurvekwInq();
        //            break;
        //    }
        //    return myInquireBase;
        //}

        /// <summary>
        /// 设置查询时钟
        /// </summary>
        private void InitTimer()
        {
            mytimer = new Timer(10);
            mytimer.AutoReset = true;
            mytimer.Enabled = true;
            mytimer.Start();
            //mytimer.Elapsed += RefreshInquire;
        }

        /// <summary>
        /// 获取查询请求标志
        /// </summary>
        /// <param name="inqType"></param>
        /// <returns></returns>
        public bool GetInquireRequest(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                return myInqList[intInqType].BolInquireRequest;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 获取查询中标志
        /// </summary>
        /// <param name="inqType"></param>
        /// <returns></returns>
        public bool GetInquiring(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                return myInqList[intInqType].BolInquiring;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 获取已完成查询标志
        /// </summary>
        /// <param name="inqType"></param>
        /// <returns></returns>
        public bool GetInquired(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                return myInqList[intInqType].BolInquired;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 获得查询后，生成的数据表
        /// </summary>
        /// <param name="inqType"></param>
        /// <returns></returns>
        public DataTable GetInquireDt(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                return myInqList[intInqType].DtInq;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 设置查询请求标志
        /// </summary>
        /// <param name="inqType"></param>
        public void SetInquireRequest(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                myInqList[intInqType].SetInquireRequest();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 复位所有的标志
        /// </summary>
        /// <param name="inqType"></param>
        public void ResetInquireFlags(InquireType inqType)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                myInqList[intInqType].ResetAllInquireFlag();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 设置查询参数的数值
        /// </summary>
        /// <param name="inqType"></param>
        /// <param name="inqPCDate"></param>
        /// <param name="paramValues"></param>
        /// <param name="paramDeadBand"></param>
        public void SetInquireParameterValues(InquireType inqType, string[] inqPCDate, string[] paramValues = null, string[] paramDeadBand = null)
        {
            try
            {
                int intInqType = (int)inqType - 1;
                myInqList[intInqType].InqPCDate = inqPCDate;
                myInqList[intInqType].ParamValues = paramValues;
                myInqList[intInqType].ParamDeadBand = paramDeadBand;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// 子过程，用于每个界面的查询更新
        /// </summary>
        /// <param name="inqType"></param>
        //private void RefreshInquire(InquireType inqType)
        //{
        //    try
        //    {
        //        switch (inqType)
        //        {
        //            case InquireType.InqShipSpdOptim:
        //                NFRMDefectInfoSetInq myNFRMDefectInfoSetInq = (NFRMDefectInfoSetInq)myInqList[0];
        //                myNFRMDefectInfoSetInq.DtInq = myNFRMDefectInfoSetInq.GetDataTable(tbName);
        //                break;
        //            case InquireType.InqDraftOpt:
        //                NFRMAlarmInq myNFRMAlarmInq = (NFRMAlarmInq)myInqList[1];
        //                myNFRMAlarmInq.DtInq = myNFRMAlarmInq.GetDataTable(TbName);
        //                break;
        //            case InquireType.InqMETune:
        //                frmShowModelValueInq myfrmShowModelValueInq = (frmShowModelValueInq)myInqList[2];
        //                myfrmShowModelValueInq.DtInq = myfrmShowModelValueInq.GetDataTable(TbName);
        //                break;
        //            case InquireType.InqHullClean:
        //                NFRMParasSetInq myNFRMParasSetInq = (NFRMParasSetInq)myInqList[3];
        //                myNFRMParasSetInq.DtInq = myNFRMParasSetInq.GetDataTable(TbName);
        //                break;
        //            case InquireType.InqFuelCurvenm:
        //                FrmFuelCurvenmInq myFrmFuelCurvenmInq = (FrmFuelCurvenmInq)myInqList[4];
        //                myFrmFuelCurvenmInq.DtInq = myFrmFuelCurvenmInq.GetDataTable(TbName);
        //                break;
        //            case InquireType.InqFuelCurvekw:
        //                FrmFuelCurvekwInq myFrmFuelCurvekwInq = (FrmFuelCurvekwInq)myInqList[5];
        //                myFrmFuelCurvekwInq.DtInq = myFrmFuelCurvekwInq.GetDataTable(TbName);
        //                break;
        //        }
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}

        /// <summary>
        /// 更新查询的主时钟过程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void RefreshInquire(object sender, ElapsedEventArgs e)
        //{
        //    try
        //    {
        //        mytimer.Stop();

        //        for (int i = 0; i < myInqList.Count; ++i)
        //        {
        //            if (myInqList[i].BolInquireRequest || myInqList[i].BolInquiring)
        //            {
        //                myInqList[i].SetInquiring();
        //                InquireType myInqType = (InquireType)(i + 1);
        //                RefreshInquire(myInqType);
        //                myInqList[i].SetInquired();
        //            }
        //        }
                               
        //    }
        //    catch (Exception ex)
        //    {
        //        Forms.FrmException.ShowException(ex, "InquireRefresher");               
        //    }
        //    finally
        //    {
        //        mytimer.Start();
        //    }
        //}

    }
}
