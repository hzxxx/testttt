﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace DAL
{
    public class DALDJ_User:DalBase,IDAL.IDJ_User
    {
        #region User_TourEnterprise
        /// <summary>
        /// 根据enterprise 获取 user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Model.DJ_User_TourEnterprise GetUser_TEbyId(Guid id)
        {
            string sql = "select u from DJ_User_TourEnterprise u where u.Enterprise.Id='" + id + "'";
            IQuery query = session.CreateQuery(sql);
            return query.FutureValue<Model.DJ_User_TourEnterprise>().Value;
        }
        #endregion
    }
}