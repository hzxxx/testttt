﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ExcelOplib
{
    public class ExcelGroupOpr
    {
        public List<Entity.GroupBasic> getBasiclist(string path)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                #region 07
                //path即是excel文档的路径。
                string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Replace('/', '\\') + @";Extended Properties=""Excel 12.0;HDR=YES""";
                //Sheet1为excel中表的名字
                string sql = "select 团队名称,起止时间,天数,人数,成人,儿童,上车集合点,返程点 from [基本信息$]";
                OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                #endregion
                #region 03
                if (dt == null || dt.Rows.Count == 0)
                {
                    conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + @";Extended Properties=Excel 8.0";
                    cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                    ad = new OleDbDataAdapter(cmd);
                    ad.Fill(dt);
                }
                #endregion
                List<Entity.GroupBasic> gblist = new List<Entity.GroupBasic>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //如果excel中的某行为空,跳过
                    if (string.IsNullOrEmpty(dt.Rows[i][1].ToString())) continue;

                    //如果excel中的行不为空,添加
                    gblist.Add(new Entity.GroupBasic()
                    {
                        Name = dt.Rows[i][0].ToString().Replace("\n", "").Trim(),
                        Bedate = dt.Rows[i][1].ToString().Replace("\n", "").Trim(),
                        Days = dt.Rows[i][2].ToString().Replace("\n", "").Trim(),
                        PeopleTotal = dt.Rows[i][3].ToString().Replace("\n", "").Trim(),
                        PeopleAdult = dt.Rows[i][4].ToString().Replace("\n", "").Trim(),
                        PeopleChild = dt.Rows[i][5].ToString().Replace("\n", "").Trim(),
                        StartPlace = dt.Rows[i][6].ToString().Replace("\n", "").Trim(),
                        EndPlace = dt.Rows[i][7].ToString().Replace("\n", "").Trim()
                    });
                }
                //如果获取到了list,就把上传上来的文件删除
                File.Delete(path.Replace('/', '\\'));
                return gblist;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public List<Entity.GroupMember> getMemberlist(string path)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                #region 07
                //path即是excel文档的路径。
                string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Replace('/', '\\') + @";Extended Properties=""Excel 12.0;HDR=YES""";
                //Sheet1为excel中表的名字
                string sql = "select 类型,姓名,身份证号,电话号码,导游证号,车牌号 from [团队信息$]";
                OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                #endregion
                #region 03
                if (dt == null || dt.Rows.Count == 0)
                {
                    conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + @";Extended Properties=Excel 8.0";
                    cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                    ad = new OleDbDataAdapter(cmd);
                    ad.Fill(dt);
                }
                #endregion
                List<Entity.GroupMember> gmlist = new List<Entity.GroupMember>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //如果excel中的某行为空,跳过
                    if (string.IsNullOrEmpty(dt.Rows[i][1].ToString())) continue;

                    //如果excel中的行不为空,添加
                    gmlist.Add(new Entity.GroupMember()
                    {
                        Memtype = dt.Rows[i][0].ToString().Replace("\n", "").Trim(),
                        Memname = dt.Rows[i][1].ToString().Replace("\n", "").Trim(),
                        Memid = dt.Rows[i][2].ToString().Replace("\n", "").Trim(),
                        Memphone = dt.Rows[i][3].ToString().Replace("\n", "").Trim(),
                        GuideNo = dt.Rows[i][4].ToString().Replace("\n", "").Trim(),
                        Carno = dt.Rows[i][5].ToString().Replace("\n", "").Trim()
                    });
                }
                //如果获取到了list,就把上传上来的文件删除
                File.Delete(path.Replace('/', '\\'));
                return gmlist;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public List<Entity.GroupRoute> getRoutelist(string path)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                #region 07
                //path即是excel文档的路径。
                string conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path.Replace('/', '\\') + @";Extended Properties=""Excel 12.0;HDR=YES""";
                //Sheet1为excel中表的名字
                string sql = "select 日期,早餐,中餐,晚餐,住宿,景点,购物点 from [行程信息$]";
                OleDbCommand cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                OleDbDataAdapter ad = new OleDbDataAdapter(cmd);
                ad.Fill(dt);
                #endregion
                #region 03
                if (dt == null || dt.Rows.Count == 0)
                {
                    conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + @";Extended Properties=Excel 8.0";
                    cmd = new OleDbCommand(sql, new OleDbConnection(conn));
                    ad = new OleDbDataAdapter(cmd);
                    ad.Fill(dt);
                }
                #endregion
                List<Entity.GroupRoute> grlist = new List<Entity.GroupRoute>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //如果excel中的某行为空,跳过
                    if (string.IsNullOrEmpty(dt.Rows[i][1].ToString())) continue;

                    //如果excel中的行不为空,添加
                    grlist.Add(new Entity.GroupRoute()
                    {
                        RouteDate = dt.Rows[i][0].ToString().Replace("\n", "").Trim(),
                        Breakfast = dt.Rows[i][1].ToString().Replace("\n", "").Trim(),
                        Lunch = dt.Rows[i][2].ToString().Replace("\n", "").Trim(),
                        Dinner = dt.Rows[i][3].ToString().Replace("\n", "").Trim(),
                        Hotel = dt.Rows[i][4].ToString().Replace("\n", "").Trim(),
                        Scenic = dt.Rows[i][5].ToString().Replace("\n", "").Trim(),
                        ShoppingPoint = dt.Rows[i][6].ToString().Replace("\n", "").Trim()
                    });
                }
                //如果获取到了list,就把上传上来的文件删除
                File.Delete(path.Replace('/', '\\'));
                return grlist;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}