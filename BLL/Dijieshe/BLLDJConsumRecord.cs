﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDAL;
using DAL;
using Model;

namespace BLL
{
    public class BLLDJConsumRecord
    {
        IDJGroupConsumRecord IDjgroup = new DALDJ_GroupConsumRecord();

        public void Save(DJ_TourEnterprise Enterprise, DJ_Route route, DateTime consumtime, int AdultsAmount, int ChildrenAmount)
        {
            DJ_GroupConsumRecord dj_group = new DJ_GroupConsumRecord();
            dj_group.AdultsAmount = AdultsAmount;
            dj_group.ChildrenAmount = ChildrenAmount;
            dj_group.ConsumeTime = consumtime;
            dj_group.Enterprise = Enterprise;
            //dj_group.Route = route;
            IDjgroup.Save(dj_group);
        }

        public Model.DJ_GroupConsumRecord GetGroupConsumRecordByRouteId(Guid RouteId)
        {
            return IDjgroup.GetGroupConsumRecordByRouteId(RouteId);
        }
    }
}