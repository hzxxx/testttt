﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace BLL
{
    public class BLLDijiesheInfo
    {
        IDAL.IDijieshe daldjs = new DAL.DALDijieshe();

        #region DJS
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="area"></param>
        /// <param name="cpn">管理人姓名</param>
        /// <param name="cpp">管理人手机</param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public Guid AddDjs(string name, string address, Model.Area area, string cpn, string cpp, string phone)
        {
            Model.DJ_TourEnterprise djs = new Model.DJ_DijiesheInfo()
            {
                Name = name,
                Address = address,
                Area = area,
                ChargePersonName = cpn,
                ChargePersonPhone = cpp,
                Phone = phone,
                Type = Model.EnterpriseType.旅行社
            };
            return daldjs.AddDJS(djs);
        }

        public IList<DJ_TourEnterprise> GetDjs8all()
        {
            return daldjs.GetDJS8All();
        }

        /// <summary>
        /// 查询地接社
        /// </summary>
        /// <param name="areaid">地区id</param>
        /// <returns></returns>
        public IList<Model.DJ_TourEnterprise> GetDJS8area(int areaid)
        {
            return GetDJS8Muti(areaid, null, null, null);
        }

        /// <summary>
        /// 查询地接社
        /// </summary>
        /// <param name="type">企业类型</param>
        /// <returns></returns>
        public IList<Model.DJ_TourEnterprise> GetDJS8type(string type)
        {
            return GetDJS8Muti(0, type, null, null);
        }

        /// <summary>
        /// 查询地接社
        /// </summary>
        /// <param name="id">企业id</param>
        /// <returns></returns>
        public IList<Model.DJ_TourEnterprise> GetDJS8id(string id)
        {
            return GetDJS8Muti(0, null, id, null);
        }

        /// <summary>
        /// 查询地接社
        /// </summary>
        /// <param name="name">名称查询</param>
        /// <returns></returns>
        public IList<Model.DJ_TourEnterprise> GetDJS8name(string name)
        {
            return GetDJS8Muti(0, null, null, name);
        }

        /// <summary>
        /// 多条件查询地接社
        /// </summary>
        /// <param name="areaid"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="namelike"></param>
        /// <returns></returns>
        public IList<Model.DJ_TourEnterprise> GetDJS8Muti(int areaid, string type, string id, string namelike)
        {
            return daldjs.GetDJS8Muti(areaid, type, id, namelike);
        }
        #endregion

        #region group

        /// <summary>
        /// 添加团队基本信息
        /// </summary>
        public Guid AddBasicinfo(DJ_DijiesheInfo djs, string gname, DateTime gbdate, DateTime gedate, int gdays, int adults, int children)
        {
            DJ_TourGroup tg = new DJ_TourGroup();
            tg.DJ_DijiesheInfo = djs;
            tg.Name = gname;
            tg.BeginDate = gbdate;
            tg.EndDate = gedate;
            tg.DaysAmount = gdays;
            tg.AdultsAmount = adults;
            tg.ChildrenAmount = children;
            return daldjs.AddGroup(tg);
        }

        #endregion
    }
}