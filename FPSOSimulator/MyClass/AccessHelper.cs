using System;
using System.Data;
using System.Configuration;
using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Web.UI.HtmlControls;
using System.Data.OleDb;
using System.Collections;
using System.Text;
using ADOX;
using System.IO;
/// <summary>  
/// AcceHelper 的摘要说明  
/// </summary>  
public class AccessHelper
{
    ////数据库连接字符串  
    //public static readonly string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="  + System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
    //// 用于缓存参数的HASH表  
    //private static Hashtable parmCache = Hashtable.Synchronized(new Hashtable());
    ///// <summary>  
    ///// 给定连接的数据库用假设参数执行一个sql命令（不返回数据集）  
    ///// </summary>  
    ///// <param name="connectionString">一个有效的连接字符串</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>执行命令所影响的行数</returns>  
    //public static int ExecuteNonQuery(string connectionString, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    OleDbCommand cmd = new OleDbCommand();
    //    using (OleDbConnection conn = new OleDbConnection(connectionString))
    //    {
    //        PrepareCommand(cmd, conn, null, cmdText, commandParameters);
    //        int val = cmd.ExecuteNonQuery();
    //        cmd.Parameters.Clear();
    //        return val;
    //    }
    //}
    ///// <summary>  
    ///// 用现有的数据库连接执行一个sql命令（不返回数据集）  
    ///// </summary>  
    ///// <remarks>  
    /////举例:   
    ///// int result = ExecuteNonQuery(connString, "PublishOrders", new OleDbParameter("@prodid", 24));  
    ///// </remarks>  
    ///// <param name="conn">一个现有的数据库连接</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>执行命令所影响的行数</returns>  
    //public static int ExecuteNonQuery(OleDbConnection connection, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    OleDbCommand cmd = new OleDbCommand();
    //    PrepareCommand(cmd, connection, null, cmdText, commandParameters);
    //    int val = cmd.ExecuteNonQuery();
    //    cmd.Parameters.Clear();
    //    return val;
    //}
    ///// <summary>  
    /////使用现有的SQL事务执行一个sql命令（不返回数据集）  
    ///// </summary>  
    ///// <remarks>  
    /////举例:   
    ///// int result = ExecuteNonQuery(trans, "PublishOrders", new OleDbParameter("@prodid", 24));  
    ///// </remarks>  
    ///// <param name="trans">一个现有的事务</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>执行命令所影响的行数</returns>  
    //public static int ExecuteNonQuery(OleDbTransaction trans, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    OleDbCommand cmd = new OleDbCommand();
    //    PrepareCommand(cmd, trans.Connection, trans, cmdText, commandParameters);
    //    int val = cmd.ExecuteNonQuery();
    //    cmd.Parameters.Clear();
    //    return val;
    //}
    ///// <summary>  
    ///// 用执行的数据库连接执行一个返回数据集的sql命令  
    ///// </summary>  
    ///// <remarks>  
    ///// 举例:   
    ///// OleDbDataReader r = ExecuteReader(connString, "PublishOrders", new OleDbParameter("@prodid", 24));  
    ///// </remarks>  
    ///// <param name="connectionString">一个有效的连接字符串</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>包含结果的读取器</returns>  
    //public static OleDbDataReader ExecuteReader(string connectionString, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    //创建一个SqlCommand对象  
    //    OleDbCommand cmd = new OleDbCommand();
    //    //创建一个SqlConnection对象  
    //    OleDbConnection conn = new OleDbConnection(connectionString);
    //    //在这里我们用一个try/catch结构执行sql文本命令/存储过程，因为如果这个方法产生一个异常我们要关闭连接，因为没有读取器存在，  
    //    //因此commandBehaviour.CloseConnection 就不会执行  
    //    try
    //    {
    //        //调用 PrepareCommand 方法，对 SqlCommand 对象设置参数  
    //        PrepareCommand(cmd, conn, null, cmdText, commandParameters);
    //        //调用 SqlCommand 的 ExecuteReader 方法  
    //        OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
    //        //清除参数  
    //        cmd.Parameters.Clear();
    //        return reader;
    //    }
    //    catch
    //    {
    //        //关闭连接，抛出异常  
    //        conn.Close();
    //        throw;
    //    }
    //}
    ///// <summary>  
    ///// 返回一个DataSet数据集  
    ///// </summary>  
    ///// <param name="connectionString">一个有效的连接字符串</param>  
    ///// <param name="cmdText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>包含结果的数据集</returns>  
    //public static DataSet ExecuteDataSet(string connectionString, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    //创建一个SqlCommand对象，并对其进行初始化  
    //    OleDbCommand cmd = new OleDbCommand();
    //    using (OleDbConnection conn = new OleDbConnection(connectionString))
    //    {
    //        PrepareCommand(cmd, conn, null, cmdText, commandParameters);
    //        //创建SqlDataAdapter对象以及DataSet  
    //        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
    //        DataSet ds = new DataSet();
    //        try
    //        {
    //            //填充ds  
    //            da.Fill(ds);
    //            // 清除cmd的参数集合   
    //            cmd.Parameters.Clear();
    //            //返回ds  
    //            return ds;
    //        }
    //        catch
    //        {
    //            //关闭连接，抛出异常  
    //            conn.Close();
    //            throw;
    //        }
    //    }
    //}
    ///// <summary>  
    ///// 用指定的数据库连接字符串执行一个命令并返回一个数据集的第一列  
    ///// </summary>  
    ///// <remarks>  
    /////例如:   
    ///// Object obj = ExecuteScalar(connString, "PublishOrders", new OleDbParameter("@prodid", 24));  
    ///// </remarks>  
    /////<param name="connectionString">一个有效的连接字符串</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>用 Convert.To{Type}把类型转换为想要的 </returns>  
    //public static object ExecuteScalar(string connectionString, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    OleDbCommand cmd = new OleDbCommand();
    //    using (OleDbConnection connection = new OleDbConnection(connectionString))
    //    {
    //        PrepareCommand(cmd, connection, null, cmdText, commandParameters);
    //        object val = cmd.ExecuteScalar();
    //        cmd.Parameters.Clear();
    //        return val;
    //    }
    //}
    ///// <summary>  
    ///// 用指定的数据库连接执行一个命令并返回一个数据集的第一列  
    ///// </summary>  
    ///// <remarks>  
    ///// 例如:   
    ///// Object obj = ExecuteScalar(connString, "PublishOrders", new OleDbParameter("@prodid", 24));  
    ///// </remarks>  
    ///// <param name="conn">一个存在的数据库连接</param>  
    ///// <param name="commandText">存储过程名称或者sql命令语句</param>  
    ///// <param name="commandParameters">执行命令所用参数的集合</param>  
    ///// <returns>用 Convert.To{Type}把类型转换为想要的 </returns>  
    //public static object ExecuteScalar(OleDbConnection connection, string cmdText, params OleDbParameter[] commandParameters)
    //{
    //    OleDbCommand cmd = new OleDbCommand();
    //    PrepareCommand(cmd, connection, null, cmdText, commandParameters);
    //    object val = cmd.ExecuteScalar();
    //    cmd.Parameters.Clear();
    //    return val;
    //}
    ///// <summary>  
    ///// 将参数集合添加到缓存  
    ///// </summary>  
    ///// <param name="cacheKey">添加到缓存的变量</param>  
    ///// <param name="cmdParms">一个将要添加到缓存的sql参数集合</param>  
    //public static void CacheParameters(string cacheKey, params OleDbParameter[] commandParameters)
    //{
    //    parmCache[cacheKey] = commandParameters;
    //}
    ///// <summary>  
    ///// 找回缓存参数集合  
    ///// </summary>  
    ///// <param name="cacheKey">用于找回参数的关键字</param>  
    ///// <returns>缓存的参数集合</returns>  
    //public static OleDbParameter[] GetCachedParameters(string cacheKey)
    //{
    //    OleDbParameter[] cachedParms = (OleDbParameter[])parmCache[cacheKey];
    //    if (cachedParms == null)
    //        return null;
    //    OleDbParameter[] clonedParms = new OleDbParameter[cachedParms.Length];
    //    for (int i = 0, j = cachedParms.Length; i < j; i++)
    //        clonedParms = (OleDbParameter[])((ICloneable)cachedParms).Clone();
    //    return clonedParms;
    //}
    ///// <summary>  
    ///// 准备执行一个命令  
    ///// </summary>  
    ///// <param name="cmd">sql命令</param>  
    ///// <param name="conn">Sql连接</param>  
    ///// <param name="trans">Sql事务</param>  
    ///// <param name="cmdText">命令文本,例如：Select * from Products</param>  
    ///// <param name="cmdParms">执行命令的参数</param>  
    //private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, string cmdText, OleDbParameter[] cmdParms)
    //{
    //    //判断连接的状态。如果是关闭状态，则打开  
    //    if (conn.State != ConnectionState.Open)
    //        conn.Open();
    //    //cmd属性赋值  
    //    cmd.Connection = conn;
    //    cmd.CommandText = cmdText;
    //    //是否需要用到事务处理  
    //    if (trans != null)
    //        cmd.Transaction = trans;
    //    cmd.CommandType = CommandType.Text;
    //    //添加cmd需要的存储过程参数  
    //    if (cmdParms != null)
    //    {
    //        foreach (OleDbParameter parm in cmdParms)
    //            cmd.Parameters.Add(parm);
    //    }
    //}


    /// <summary>
    /// 创建access数据库
    /// </summary>
    /// <param name="filePath">数据库文件的全路径，如 D:\\NewDb.mdb</param>
    public bool CreateAccessDb(string filePath)
    {
        ADOX.Catalog catalog = new Catalog();
        if (!File.Exists(filePath))
        {
            try
            {
                catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;DData Source=" + filePath + ";Jet OLEDB:Engine Type=5");
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        return true;
    }
    public OleDbConnection conn = new OleDbConnection();
    public void OpenDB(string filePath, string tableName)
    {

    }
    public void InsertData(string filePath, string tableName)
    {
        //string exePath = System.Environment.CurrentDirectory;//本程序所在路径

        ////创建连接对象
        //OleDbConnection conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;data source=" + filePath);
        ////  \\\\\ + @"\" + tableName + ".mdb");

        //conn.Open();
        //DateTime current = DateTime.Now;
        ////增
        //string ColumnsName = "(测点,测点名,额定转速,转速,比功率,油门开度,RMS,0_5F,1F,2F,3F,4F,Fmax,Fm,测点类型,采集时间)";//日期时间
        //string NewValues = "(1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,'"+ current.ToString("yyyy-MM-dd HH:mm:ss") + "')";
        //string sql = "insert into " + tableName + ColumnsName + "values" + NewValues;
        ////删 
        ////string sql = "delete from 表名 where 字段1="...; 
        ////改 
        ////string sql = "update student set 学号=" ...; 
        //OleDbCommand comm = new OleDbCommand(sql, conn);
        //comm.ExecuteNonQuery();

        //conn.Close();
    }


    /// <summary>
    /// 在access数据库中创建表
    /// </summary>
    /// <param name="filePath">数据库表文件全路径如D:\\NewDb.mdb 没有则创建 </param> 
    /// <param name="tableName">表名</param>
    /// <param name="colums">ADOX.Column对象数组</param>
    public void CreateAccessTable(string filePath, string tableName)
    {
        ADOX.Catalog catalog = new Catalog();
        //数据库文件不存在则创建
        if (!File.Exists(filePath))
        {
            try
            {
                catalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Jet OLEDB:Engine Type=5");
            }
            catch (System.Exception ex)
            {

            }
        }
        ADODB.Connection cn = new ADODB.Connection();
        cn.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath, null, null, -1);
        catalog.ActiveConnection = cn;
        ADOX.Table table = new ADOX.Table();
        table.Name = tableName;


        ADOX.Column keycolumn = new ADOX.Column();
        keycolumn.ParentCatalog = catalog;
        keycolumn.Type = ADOX.DataTypeEnum.adInteger; // 必须先设置字段类型
        keycolumn.Name = "ID";
        keycolumn.DefinedSize = 9;
        keycolumn.Properties["AutoIncrement"].Value = true;
        table.Columns.Append(keycolumn, DataTypeEnum.adInteger, 0);
        table.Keys.Append("PrimaryKey", ADOX.KeyTypeEnum.adKeyPrimary, "ID", "", "");
        table.Columns.Append("测点", DataTypeEnum.adInteger, 9); //测点
        table.Columns.Append("测点名", DataTypeEnum.adWChar, 50);//
        table.Columns.Append("额定转速", DataTypeEnum.adDouble, 50);//
        table.Columns.Append("转速", DataTypeEnum.adDouble, 9);//转速
        table.Columns.Append("比功率", DataTypeEnum.adDouble, 50);//比功率
        table.Columns.Append("油门开度", DataTypeEnum.adDouble, 50);//油门开度（或功率）
        table.Columns.Append("RMS", DataTypeEnum.adDouble, 9);
        table.Columns.Append("0_5F", DataTypeEnum.adDouble, 50);
        table.Columns.Append("1F", DataTypeEnum.adDouble, 50);
        table.Columns.Append("2F", DataTypeEnum.adDouble, 9);
        table.Columns.Append("3F", DataTypeEnum.adDouble, 50);
        table.Columns.Append("4F", DataTypeEnum.adDouble, 50);
        table.Columns.Append("Fmax", DataTypeEnum.adDouble, 9);
        table.Columns.Append("Fm", DataTypeEnum.adDouble, 50);
        table.Columns.Append("测点类型", DataTypeEnum.adInteger, 9);//测点类型
        table.Columns.Append("采集时间", DataTypeEnum.adDate, 30);//日期时间






        //foreach (var column in colums)
        //{
        //    table.Columns.Append(column);
        //    //column.ParentCatalog = catalog;
        //    //column.Properties["AutoIncrement"].Value = true; //设置自动增长

        //}



        //table.Columns.Append("FileName", DataTypeEnum.adVarWChar, 50);
        //table.Columns.Append("FileDate", DataTypeEnum.adDate, 0);
        //table.Columns.Append("FileSize", DataTypeEnum.adInteger, 9);
        //table.Columns.Append("OrderID", DataTypeEnum.adInteger, 9);
        //table.Columns.Append("Sha1", DataTypeEnum.adVarWChar, 50);
        //try
        //{
        //    catalog.Tables.Append(table);
        //}
        //catch (Exception ex)
        //{
        //    //MessageBox.Show(ex.Message);
        //}


        catalog.Tables.Append(table);
        cn.Close();
    }

    internal void CreateAccessDb()
    {
        throw new NotImplementedException();
    }
    //========================================================================================调用
    //ADOX.Column[] columns = {
    //                     new ADOX.Column(){Name="id",Type=DataTypeEnum.adInteger,DefinedSize=9},
    //                     new ADOX.Column(){Name="col1",Type=DataTypeEnum.adWChar,DefinedSize=50},
    //                     new ADOX.Column(){Name="col2",Type=DataTypeEnum.adLongVarChar,DefinedSize=50}
    //                 };
    // AccessDbHelper.CreateAccessTable("d:\\111.mdb", "testTable", columns);
}
