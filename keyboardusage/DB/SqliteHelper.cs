using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using KeyBoardUsage.Model;
using KeyBoardUsage.Utils;

namespace KeyBoardUsage.DB
{
    public class SqliteHelper
    {
        /// <summary>
        /// 初始化存储文件
        /// </summary>
        public void InitDb()
        {
            if (File.Exists(System.Environment.CurrentDirectory + "\\DB\\USAGE.db"))
            {
                Config.DatabaseFile = System.Environment.CurrentDirectory + "\\DB\\USAGE.db";
                BaseUtils.DataBase.SqliteHelper.ConnectionString = " Data Source=" + Config.DatabaseFile + ";Version=3;";
            }
            else
            {
                Directory.CreateDirectory(System.Environment.CurrentDirectory + "\\DB");
                BaseUtils.DataBase.SqliteHelper.CreateDBFile(System.Environment.CurrentDirectory + "\\DB\\USAGE.db");
                Config.DatabaseFile = System.Environment.CurrentDirectory + "\\DB\\USAGE.db";
                BaseUtils.DataBase.SqliteHelper.ConnectionString = " Data Source=" + Config.DatabaseFile + ";Version=3;";
                InitTable();
            }
        }

        /// <summary>
        /// 存了个字符串sql
        /// </summary>
        public void InitTable()
        {
            string CreateTable = "CREATE TABLE \"USAGE_A\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_B\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_C\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_D\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_E\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_G\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_H\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_I\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_J\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_K\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_L\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_M\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_N\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_O\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_P\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_Q\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_R\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_S\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_T\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_U\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_V\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_W\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_X\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_Y\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_Z\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_1\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_2\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_3\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_4\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_5\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_6\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_7\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_8\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_9\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_0\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F1\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F2\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F3\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F4\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F5\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F6\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F7\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F8\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F9\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F10\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F11\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_F12\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_ESC\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_TAB\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_CAPSLOCK\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_SHIFT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_CTRL\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_ALT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_HOME\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_END\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_INSERT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_DELETE\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_BACKSPACE\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_PLUS\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_MINUS\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_LBRACKET\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_RBRACKET\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_CONLONS\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_QUOTATION\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_GT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_LT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_QUESTION\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_PAGEUP\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_PAGEDOWN\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_UP\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_DOWN\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_LEFT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_RIGHT\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_PRTSC\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_SLASH\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_WAVE\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_WIN\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); CREATE TABLE \"USAGE_ENTER\" (\"id\"  INTEGER NOT NULL,\"time\"  INTEGER,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\")); ";
            BaseUtils.DataBase.SqliteHelper.ExecuteSql(CreateTable);
            CreateTable = " CREATE TABLE \"USAGE_TOTAL\" (\"name\"  TEXT,\"id\"  INTEGER NOT NULL,\"count\"  INTEGER DEFAULT 0,PRIMARY KEY (\"id\"));";
            BaseUtils.DataBase.SqliteHelper.ExecuteSql(CreateTable);
            CreateTable = "INSERT INTO \"USAGE_TOTAL\" (\"NAME\",\"COUNT\") VALUES ('TOTAL',  0); INSERT INTO \"USAGE_TOTAL\"  (\"NAME\",\"COUNT\") VALUES ('MAIN', 0); INSERT INTO \"USAGE_TOTAL\"  (\"NAME\",\"COUNT\") VALUES ('NUMBER',  0); INSERT INTO \"USAGE_TOTAL\"  (\"NAME\",\"COUNT\") VALUES ('FUNC',  0); INSERT INTO \"USAGE_TOTAL\"  (\"NAME\",\"COUNT\") VALUES ('CTRL',  0);;";
            BaseUtils.DataBase.SqliteHelper.ExecuteSql(CreateTable);
        }

        public void InsertModelData(List<UsageCount> modelList)
        {
            foreach (var count in modelList)
            {
                string sql = ModelToSQL(count);
                BaseUtils.DataBase.SqliteHelper.ExecuteSql(sql);
            }
        }

        public void UpdateTotalCount(Dictionary<string, int> totalDic)
        {
            string updateTotalSql = " ";

            foreach (var dic in totalDic)
            {
                if (dic.Key == "TOTAL")
                {
                    updateTotalSql = updateTotalSql + "UPDATE USAGE_TOTAL SET COUNT = " + dic.Value + " WHERE NAME = 'TOTAL';";
                }
                else if (dic.Key == "MAIN")
                {
                    updateTotalSql = updateTotalSql + "UPDATE USAGE_TOTAL SET COUNT = " + dic.Value + " WHERE NAME = 'MAIN';";
                }
                else if (dic.Key == "NUMBER")
                {
                    updateTotalSql = updateTotalSql + "UPDATE USAGE_TOTAL SET COUNT = " + dic.Value + " WHERE NAME = 'NUMBER';";
                }
                else if (dic.Key == "FUNC")
                {
                    updateTotalSql = updateTotalSql + "UPDATE USAGE_TOTAL SET COUNT = " + dic.Value + " WHERE NAME = 'FUNC';";
                }
                else if (dic.Key == "CTRL")
                {
                    updateTotalSql = updateTotalSql + "UPDATE USAGE_TOTAL SET COUNT = " + dic.Value + " WHERE NAME = 'CTRL';";
                }
            }
            BaseUtils.DataBase.SqliteHelper.ExecuteSql(updateTotalSql);
        }

        public Dictionary<string, int> GetTotalCount()
        {
            string updateTotalSql = " SELECT * FROM USAGE_TOTAL;";
            DataSet ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            Dictionary<string, int> totalDic = new Dictionary<string, int>();
            totalDic.Add("TOTAL", Convert.ToInt32(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]));
            totalDic.Add("MAIN", Convert.ToInt32(ds.Tables[0].Rows[1]["COUNT"]));
            totalDic.Add("NUMBER", Convert.ToInt32(ds.Tables[0].Rows[2]["COUNT"]));
            totalDic.Add("FUNC", Convert.ToInt32(ds.Tables[0].Rows[3]["COUNT"]));
            totalDic.Add("CTRL", Convert.ToInt32(ds.Tables[0].Rows[4]["COUNT"]));
            return totalDic;
        }

        public double[] GetCharCount()
        {
            double[] resultArr = new double[26];
            string updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_A ;";
            DataSet ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[0] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_B ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[1] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_C ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[2] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_D ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[3] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_E ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[4] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[5] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_G ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[6] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_H ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[7] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_I ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[8] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_J ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[9] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_K ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[10] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_L ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[11] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_M ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[12] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_N ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[13] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_O ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[14] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_P ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[15] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_Q ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[16] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_R ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[17] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_S ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[18] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_T ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[19] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_U ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[20] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_V ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[21] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_W ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[22] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_X ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[23] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_Y ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[24] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_Z ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[25] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            return resultArr;
        }

        public double[] GetNumberCount()
        {
            double[] resultArr = new double[10];
            string updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_1 ;";
            DataSet ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[0] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_2 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[1] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_3 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[2] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_4 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[3] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_5 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[4] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_6 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[5] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_7 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[6] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_8 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[7] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_9 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[8] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_0 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[9] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            return resultArr;
        }

        public double[] GetFuncCount()
        {
            double[] resultArr = new double[12];
            string updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F1 ;";
            DataSet ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[0] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F2 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[1] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F3 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[2] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F4 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[3] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F5 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[4] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F6 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[5] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F7 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[6] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F8 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[7] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F9 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[8] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F10 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[9] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F11 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[10] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            updateTotalSql = " SELECT SUM(count)  AS COUNT  FROM USAGE_F12 ;";
            ds = BaseUtils.DataBase.SqliteHelper.Query(updateTotalSql);
            resultArr[11] = Convert.ToDouble(ds.Tables[0].Rows[0]["COUNT"] == DBNull.Value ? 0 : ds.Tables[0].Rows[0]["COUNT"]);
            return resultArr;
        }

        public double[] GetCtrlCount()
        {
            double[] resultArr = new double[11];
            return resultArr;
        }

        public List<UsageCount> GetList(string name)
        {
            List<UsageCount> modelList = new List<UsageCount>();
            return modelList;
        }

        private string ModelToSQL(UsageCount model)
        {
            DateTime oldTime = new DateTime(1970, 1, 1);
            TimeSpan span = model.time.Subtract(oldTime);
            double milliSecondsTime = span.TotalMilliseconds;
            string sql = "INSERT INTO \"" + model.TableName + "\" (\"time\",\"count\") VALUES ( " + milliSecondsTime + "," + model.Count + ");";
            return sql;
        }

        private UsageCount DTToModel(DataTable dt)
        {
            UsageCount count = new UsageCount();
            return count;
        }
    }
}