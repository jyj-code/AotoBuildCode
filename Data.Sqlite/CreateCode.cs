﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Sqlite
{
    public class CreateCode : IData.ICreateCode
    {
        /// <summary>
        /// 得到数据层命名空间
        /// </summary>
        /// <returns></returns>
        public string GetDataNameSpace()
        {
            return "System.Data.SQLite";
        }

        /// <summary>
        /// 得到参数名称
        /// </summary>
        /// <returns></returns>
        public string GetParamsName(string name)
        {
            return "?";
        }
        /// <summary>
        /// 得到参数名称(实例化参数时用的名称)
        /// </summary>
        /// <returns></returns>
        public string GetParamsName1(string name)
        {
            return string.Format("?{0}", name);
        }
        /// <summary>
        /// 得到参数类型
        /// </summary>
        /// <returns></returns>
        public string GetParamsType()
        {
            return "SQLiteParameter";
        }
        /// <summary>
        /// 得到DataReader类型
        /// </summary>
        /// <returns></returns>
        public string GetDataReaderType()
        {
            return "SQLiteDataReader";
        }
        /// <summary>
        /// 查询自增ID的方法
        /// </summary>
        /// <returns></returns>
        public string GetIdentityMethod()
        {
            return "last_insert_rowid()";
        }
    }
}
