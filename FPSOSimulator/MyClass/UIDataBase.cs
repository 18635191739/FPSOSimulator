using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FPSOSimulator.Forms
{
    class UIDataBase
    {
        private string dbName;
        private string tbName;
        private string dbPath;
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataReader dbReader;
        
        public UIDataBase()
            : this(Application.StartupPath + "\\", "user.mdb", "UITable")
        {

        }

        public UIDataBase (string dbPath,string dbName,string tbName)
        {
            this.dbPath = dbPath;
            this.dbName = dbName;
            this.tbName = tbName;
        }

        /// <summary>
        /// 打开数据库
        /// </summary>
        public void OpenConn()
        {
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.dbPath + this.dbName;
            OpenConn(connString);
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        /// <param name="contxt"></param>
        /// <param name="cmdtxt"></param>
        private void OpenConn(string contxt)
        {
            conn = new OleDbConnection();
            
            try
            {
                conn.ConnectionString = contxt;
                conn.Open();                      
            }
            catch (Exception e)
            {
                MessageBox.Show("create database connection wrong:" + e.Message);
            }
        }

        /// <summary>
        /// 创建sql查询命令
        /// </summary>
        /// <param name="isOrdered"></param>
        /// <param name="isAsc"></param>
        /// <param name="orderField"></param>
        public void CreateSelectCmd(bool isOrdered, bool isAsc, string orderField)
        {
            string cmdTxt = CreatSelectCmdString(isOrdered, isAsc, orderField);
            this.CreateSelectCmd(cmdTxt);
        }

        /// <summary>
        /// 根据命令文本创建命令
        /// </summary>
        /// <param name="cmdTxt"></param>
        private void CreateSelectCmd(string cmdTxt)
        {
            cmd = new OleDbCommand();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = cmdTxt;
            }
            catch (Exception e)
            {
                MessageBox.Show("create database command wrong:" + e.Message);
            }
        }

        /// <summary>
        /// 创建命令文本，根据是否需要排序，是否逆序，排序字段
        /// </summary>
        /// <param name="isOrdered">是否需要排序</param>
        /// <param name="isAsc">是否逆序</param>
        /// <param name="orderField">排序字段</param>
        /// <returns></returns>
        private string CreatSelectCmdString(bool isOrdered,bool isAsc, string orderField)
        {
            string cmdTxt;
            if (isOrdered)
            {
                if (isAsc)
                {
                    cmdTxt = "select * from " + tbName + " order by " + orderField + " ASC";
                }
                else
                {
                    cmdTxt = "select * from " + tbName + " order by " + orderField + " DESC";
                }
            }
            else
            {
                cmdTxt = "select * from " + tbName;
            }
            return cmdTxt;
        }
        
        /// <summary>
        /// 打开数据库并读取数据
        /// </summary>
        /// <param name="contxt"></param>
        /// <param name="cmdtxt"></param>
        public void ExecuteReader()
        {            
            try
            {                
                dbReader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("read UI database wrong:" + e.Message);
            }
        }

        public DataTable GetDateTable(string tablename)
        {
            //string strFilePath = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + Application.StartupPath + "\\111.accdb";

            string strFilePath = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.dbPath + this.dbName;

            string sql = "select * from " + tablename;
            //声明一个数据连接
            System.Data.OleDb.OleDbConnection con = new OleDbConnection(strFilePath);
            System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    //dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            finally
            {
                con.Close();
                con.Dispose();
                da.Dispose();
            }
            return dt;
        }
        /// <summary>
        /// 获取一行的所有数据
        /// </summary>
        /// <param name="valLen">数据长度（一行的列数）</param>
        /// <returns></returns>
        public object[] DbReadLine(int valLen)
        {
            object[] retVal = new object[valLen];
            if (dbReader.Read())
            {
                for (int i = 0; i < valLen; ++i)
                {
                    retVal[i] = dbReader[i];
                }
            }
            else
            {
                for (int i = 0; i < valLen; ++i)
                {
                    retVal[i] = null;
                }
            }
            return retVal;
        }

        /// <summary>
        /// 读一行数据中某一列
        /// </summary>
        /// <param name="fieldtxt"></param>
        /// <returns></returns>
        public object DbReadLine(string fieldtxt)
        {
            if (dbReader.Read())
            {
                return dbReader[fieldtxt]; //
            }
            else
            {
                return null;
            }
        }

        public void update_data(string tablename,int idx, string col,string val)
        {
            //conn.Open();
            //增  
            //string sql = "insert into 表名(字段1,字段2,字段3,字段4)values(...)";
            //删   
            //string sql = "delete from 表名 where 字段1="...;   
            //改   
            //string sql = "update student set 学号="...;
            string sql = "update " + tablename +  " set " + col  + " = '" + val + "' where Index=" + idx;

            OleDbCommand comm = new OleDbCommand(sql, conn);
            comm.ExecuteNonQuery();

            //conn.Close();
        }


        /// <summary>
        /// 关闭读取器
        /// </summary>
        public void CloseReader()
        {
            dbReader.Close();
            dbReader.Dispose();            
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConn()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
            }
        }


        public void CloseConnOnly()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }

    }
}
