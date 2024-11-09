using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Cainiao.DAL.Helpers
{
    public class SqlHelper
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        /// <summary>
        /// 增删改语句
        /// </summary>
        /// <param name="sql">sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            int result;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = BuilderCommand(connection, sql, commandType, null, parameters);
                result = command.ExecuteNonQuery();
                command.Parameters.Clear();
            }

            return result;
        }

        /// <summary>
        /// 执行Sql查询，返回第一行第一列的值
        /// </summary>
        /// <param name="sql">sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            object result;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = BuilderCommand(connection, sql, commandType, null, parameters);
                result = command.ExecuteScalar();
                command.Parameters.Clear();
            }

            return (result == null || result == DBNull.Value) ? null : result;
        }

        /// <summary>
        /// 执行查询，返回DataReader
        /// </summary>
        /// <param name="sql">sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static SqlDataReader ExecuteReader(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            var connection = new SqlConnection(ConnectionString);
            var command = BuilderCommand(connection, sql, commandType, null, parameters);
            try
            {
                var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception e)
            {
                connection.Close();
                throw new Exception("创建Reader对象发生异常", e);
            }
        }

        /// <summary>
        /// 执行查询，查询结果填充到DataTable
        /// </summary>
        /// <param name="sql">sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            DataTable dt;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = BuilderCommand(connection, sql, commandType, null, parameters);
                var adapter = new SqlDataAdapter(command);
                dt = new DataTable();
                adapter.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// 执行查询，查询结果填充到DataSet
        /// </summary>
        /// <param name="sql">sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            DataSet ds;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var command = BuilderCommand(connection, sql, commandType, null, parameters);
                var adapter = new SqlDataAdapter(command);
                ds = new DataSet();
                adapter.Fill(ds);
            }

            return ds;
        }

        /// <summary>
        /// 构建SqlCommand
        /// </summary>
        /// <param name="connection">数据库连接对象</param>
        /// <param name="sql">Sql语句或存储过程名称</param>
        /// <param name="commandType">Sql或存储过程</param>
        /// <param name="tx">事务对象</param>
        /// <param name="parameters">参数列表</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static SqlCommand BuilderCommand(SqlConnection connection, string sql, CommandType commandType,
            SqlTransaction tx, SqlParameter[] parameters)
        {
            if (connection is null) throw new ArgumentNullException(nameof(connection), "连接对象不能为空");
            var command = new SqlCommand(sql, connection);
            command.CommandType = commandType;

            if (connection.State != ConnectionState.Open) connection.Open();
            if (tx != null) command.Transaction = tx;

            if (parameters != null && parameters.Length > 0)
            {
                command.Parameters.Clear();
                command.Parameters.AddRange(parameters);
            }

            return command;
        }

        /// <summary>
        /// 将参数数组添加到IDbCommand参数集合中
        /// </summary>
        /// <param name="command"></param>
        /// <param name="parameters"></param>
        public static void AddParameters(IDbCommand command, SqlParameter[] parameters)
        {
            if (parameters == null || parameters.Length <= 0) return;
            foreach (var parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
        }

        /// <summary>
        /// 初始化IDbCommand
        /// </summary>
        /// <param name="command"></param>
        /// <param name="sql"></param>
        /// <param name="commandType"></param>
        /// <param name="parameters"></param>
        public static void InitDbCommand(IDbCommand command, string sql, CommandType commandType,
            SqlParameter[] parameters)
        {
            command.CommandText = sql;
            command.CommandType = commandType;
            command.Parameters.Clear();
            AddParameters(command, parameters);
        }

        /// <summary>
        /// 更新DataTable到数据库
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteDataTable(DataTable dataTable, string sql)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                var adapter = new SqlDataAdapter(sql, connection);
                _ = new SqlCommandBuilder(adapter);
                return adapter.Update(dataTable);
            }
        }
    }
}