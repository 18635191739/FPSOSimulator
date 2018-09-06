using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPSOSimulator.FormInquire
{
    class InquireBase
    {

        #region "inquiry parameter values property"
        private string[] inqPCDate;
        public string[] InqPCDate
        {
            get
            {
                return inqPCDate;
            }
            set
            {
                inqPCDate = value;
            }
        }

        private string[] paramValues;
        public string[] ParamValues
        {
            get
            {
                return paramValues;
            }
            set
            {
                paramValues = value;
            }
        }

        private string[] paramDeadBand;
        public string[] ParamDeadBand
        {
            get
            {
                return paramDeadBand;
            }
            set
            {
                paramDeadBand = value;
            }
        }
        #endregion

        private DataTable dtInq;
        /// <summary>
        /// 查询之后返回查询的数据表
        /// </summary>
        public DataTable DtInq
        {
            get
            {
                return dtInq;
            }
            set
            {
                dtInq = value;
            }
        }

        private bool bolInquireRequest = false;
        /// <summary>
        /// 查询请求标志
        /// </summary>
        public bool BolInquireRequest
        {
            get
            {
                return bolInquireRequest;
            }
            set
            {
                bolInquireRequest = value;
            }
        }

        private bool bolInquiring = false;
        /// <summary>
        /// 查询中的标志
        /// </summary>
        public bool BolInquiring
        {
            get
            {
                return bolInquiring;
            }
            set
            {
                bolInquiring = value;
            }
        }

        private bool bolInquired = false;
        /// <summary>
        /// 完成查询的标志
        /// </summary>
        public bool BolInquired
        {
            get
            {
                return bolInquired;
            }
            set
            {
                bolInquired = value;
            }
        }

        /// <summary>
        /// 设置查询请求标志
        /// </summary>
        public void SetInquireRequest()
        {
            bolInquireRequest = true;
            bolInquired = false;
            bolInquiring = false;
        }

        /// <summary>
        /// 设置查询中标志
        /// </summary>
        public void SetInquiring()
        {
            bolInquireRequest = false;
            bolInquired = false;
            bolInquiring = true;
        }

        /// <summary>
        /// 设置查询成功标志
        /// </summary>
        public void SetInquired()
        {
            bolInquired = true;
            bolInquireRequest = false;
            bolInquiring = false;
        }

        /// <summary>
        /// 复位所有的查询标志
        /// </summary>
        public void ResetAllInquireFlag()
        {
            bolInquired = false;
            bolInquireRequest = false;
            bolInquiring = false;
        }

        /// <summary>
        /// 设置查询字符串
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="inqFields"></param>
        /// <param name="inqCondition"></param>
        /// <param name="strOrderField"></param>
        /// <param name="bolIsOrdered"></param>
        /// <returns></returns>
        protected virtual StringBuilder SetInquireText(string tableName, string[] inqFields, string[] inqCondition, string strOrderField = null, bool bolIsOrdered = false)
        {
            StringBuilder cmdStrB = new StringBuilder();

            cmdStrB.Append("SELECT ");

            for (int i = 0; i < inqFields.Length; ++i)
            {
                cmdStrB.Append(inqFields[i]);
                if (i != (inqFields.Length - 1))
                {
                    cmdStrB.Append(",");
                }
                else
                {
                    cmdStrB.Append(" FROM ");
                }
            }

            cmdStrB.Append(tableName);

            cmdStrB.Append(" WHERE ");

            for (int i = 0; i < inqCondition.Length; ++i)
            {
                cmdStrB.Append("(");
                cmdStrB.Append(inqCondition[i]);
                cmdStrB.Append(" between ");
                cmdStrB.Append("?");
                cmdStrB.Append(inqCondition[i]);
                cmdStrB.Append("Start");
                cmdStrB.Append(" and ");
                cmdStrB.Append("?");
                cmdStrB.Append(inqCondition[i]);
                cmdStrB.Append("End)");
                if (i != (inqCondition.Length - 1))
                {
                    cmdStrB.Append(" and ");
                }
            }

            if (bolIsOrdered)
            {
                cmdStrB.Append(" order by ");
                cmdStrB.Append(strOrderField);
                cmdStrB.Append(" ASC");
            }

            return cmdStrB;
        }

        /// <summary>
        /// 获取查询之后的data reader
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="myparam"></param>
        /// <returns></returns>
        public MySqlDataReader GetInqReader(string cmdText, MySqlParameter[] myparam)
        {
            MySqlDataReader reader = SQLHelper.ExecuteReader(cmdText, System.Data.CommandType.Text, myparam);
            return reader;
        }

        /// <summary>
        /// 初始化数据表
        /// </summary>
        /// <param name="colname">列名</param>
        /// <param name="coltype">字段类型</param>
        /// <param name="dt">返回数据表</param>
        protected void InitDt(string[] colname, Type[] coltype, out DataTable dt)
        {
            try
            {
                dt = new DataTable();
                for (int i = 0; i < coltype.Length; ++i)
                {
                    dt.Columns.Add(colname[i], coltype[i]);
                }
            }
            catch
            {
                throw;
            }
        }        

        /// <summary>
        /// 获取参数数组
        /// </summary>
        /// <param name="inqPCDate"></param>
        /// <param name="paramValues"></param>
        /// <param name="paramDeadBand"></param>
        /// <returns></returns>
        public virtual MySqlParameter[] GetInqParam(string[] inqPCDate, string[] paramValues = null, string[] paramDeadBand = null)
        {
            return null;
        }

        /// <summary>
        /// 转换 reader 为 datatable
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public virtual DataTable TurnRdToDb(ref MySqlDataReader reader)
        {
            return null;
        }

        /// <summary>
        /// 根据数据表名称查询并返回一个data table
        /// </summary>
        /// <param name="tbName"></param>
        /// <returns></returns>
        public virtual DataTable GetDataTable(string tbName)
        {
            return null;
        }

    }
}
