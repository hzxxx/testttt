﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Model
{
    //团队信息
    public class TourGroupMap:ClassMap<DJ_TourGroup>
    {
        public TourGroupMap()
        {
            Id(x => x.Id);
            References<DJ_DijiesheInfo>(x => x.DJ_DijiesheInfo);
            Map(x => x.Name);
            Map(x => x.BeginDate);
            Map(x => x.EndDate);
            Map(x => x.CarNo);
            Map(x => x.DaysAmount);
            Map(x => x.DriverName);
            Map(x => x.DriverPhone);
            Map(x => x.GuideIdCardNo);
            Map(x => x.AdultsAmount);
            Map(x => x.ChildrenAmount);

            Map(x => x.GuideName);
            Map(x => x.GuidePhone);
            HasMany<DJ_Route>(x => x.RouteDescription);
            HasMany<DJ_TourGroupMember>(x => x.Members);
        }
    }
}