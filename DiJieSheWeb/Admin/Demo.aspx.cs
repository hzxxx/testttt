﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Model;
using BLL;
public partial class Admin_Demo : System.Web.UI.Page
{


    string dptAdminAccount = "hzlyj";//管理部门登录帐号

    string dijiesheAdminAcount = "entAdmin_438";//地接社管理员
    string dijiesheName = "杭州西湖旅行社";

    string hoteladmin = "entAdmin_439";
    string hotelName = "香格里拉宾馆";

    string scenicName = "印象西湖";
    string scenicAdminAccount = "yinxiangxihu_admin";

    DJ_TourEnterprise demoHotel;
    DJ_TourEnterprise demoDjs;
    DJ_TourEnterprise demoScenic;
    protected void Page_Load(object sender, EventArgs e)
    {
        demoHotel = bllEnt.GetDJS8name(hotelName)[0];
        demoDjs = bllEnt.GetDJS8name(dijiesheName)[0];
        demoScenic = bllEnt.GetDJS8name(scenicName)[0];
    }
    /*GovAdmin_-75259*/

    protected void btnDptAdminLogin_Click(object sender, EventArgs e)
    {
        DemoLogin(dptAdminAccount, "/TourManagerDpt/");
    }

    protected void btnAdminLogin_Click(object sender, EventArgs e)
    {
        DemoLogin("admin", "/admin/");
    }
    protected void btnDjsLogin_Click(object sender, EventArgs e)
    {
        DemoLogin(dijiesheAdminAcount, "/LocalTravelAgent/");
    }
    protected void btnEntLogin_Click(object sender, EventArgs e)
    {
        DemoLogin(hoteladmin, "/TourEnterprise/");
    }
    protected void btnDjsCreatGroup_Click(object sender, EventArgs e)
    {
        DJ_TourGroup group = CreateDemoGroup(DateTime.Now);
        bllGroup.Save(group);
        DemoLogin(dijiesheAdminAcount, "/LocalTravelAgent/Groups/grouplist.aspx");
    }
    BLLDJTourGroup bllGroup = new BLLDJTourGroup();
    BLLDJEnterprise bllEnt = new BLLDJEnterprise();
    private DJ_TourGroup CreateDemoGroup(DateTime beginTime)
    {
        DJ_TourGroup group = new DJ_TourGroup();
        group.BeginDate = beginTime;
        group.DJ_DijiesheInfo = (Model.DJ_DijiesheInfo)demoDjs;
        group.EndDate = beginTime.AddDays(1);

        DJ_TourGroupMember memberdaoyou = new DJ_TourGroupMember();
        memberdaoyou.DJ_TourGroup = group;
        memberdaoyou.IdCardNo = "210905197807210546";
        memberdaoyou.SpecialCardNo = "导游证号: D-3706-004050";
        memberdaoyou.MemberType = MemberType.导游;
        memberdaoyou.PhoneNum = "13280008000";
        memberdaoyou.RealName = "张三";

        DJ_TourGroupMember membersiji = new DJ_TourGroupMember();
        membersiji.DJ_TourGroup = group;
        membersiji.IdCardNo = "210905197807210546";
        membersiji.SpecialCardNo = "驾驶证号:362101096266";
        membersiji.MemberType = MemberType.司机;
        membersiji.PhoneNum = "13280008000";
        membersiji.RealName = "王师傅";


        DJ_TourGroupMember member1 = new DJ_TourGroupMember();
        member1.DJ_TourGroup = group;
        member1.IdCardNo = "210905197807210546";
        member1.MemberType = MemberType.成人游客;
        member1.PhoneNum = "13280008000";
        member1.RealName = "张三";

        DJ_TourGroupMember member2 = new DJ_TourGroupMember();
        member2.DJ_TourGroup = group;
        member2.IdCardNo = "210905197807210546";
        member2.MemberType = MemberType.儿童;
        member2.PhoneNum = "13280008000";
        member2.RealName = "张小明";

        DJ_TourGroupMember member3 = new DJ_TourGroupMember();
        member3.DJ_TourGroup = group;
        member3.SpecialCardNo = "证件号:HK0930234";
        member3.MemberType = MemberType.港澳台;
        member3.PhoneNum = "13280008000";
        member3.RealName = "张学友";

        DJ_TourGroupMember member4 = new DJ_TourGroupMember();
        member4.DJ_TourGroup = group;
        member4.SpecialCardNo = "证件号:019203493l";
        member4.MemberType = MemberType.外宾;
        member4.PhoneNum = "13280008000";
        member4.RealName = "Carl Smith";

        group.Members.Add(membersiji);
        group.Members.Add(memberdaoyou);
        group.Members.Add(member1);
        group.Members.Add(member2);
        group.Members.Add(member3);
        group.Members.Add(member4);

        group.Name = "[Demo]杭州双休游" + Math.Abs(Guid.NewGuid().GetHashCode()).ToString().Substring(0, 6);
        group.No = "SRY2012" + Math.Abs(Guid.NewGuid().GetHashCode()).ToString().Substring(0, 4);

        DJ_Route route1 = new DJ_Route();
        route1.DayNo = 1;
        route1.Description = "住宿";
        route1.DJ_TourGroup = group;
        route1.Enterprise = demoHotel;

        DJ_Route route11 = new DJ_Route();
        route11.DayNo = 1;
        route11.Description = "景点";
        route11.DJ_TourGroup = group;
        route11.Enterprise = demoScenic;

        DJ_Route route2 = new DJ_Route();
        route2.DayNo = 2;
        route2.Description = "景点";
        route2.DJ_TourGroup = group;
        route2.Enterprise = demoScenic;
        //group.Routes

        group.Routes.Add(route1);
        group.Routes.Add(route2);
        group.Routes.Add(route11);
        return group;

    }

    BLL.BLLDJConsumRecord bllConsum = new BLLDJConsumRecord();
    protected void btnReport_Click(object sender, EventArgs e)
    {
        /// 创建很多团队 并且为所有团队都验票通过.
        ///

        List<DJ_TourGroup> Groups = new List<DJ_TourGroup>();
        for (int i = 1; i < 12; i++)
        {
            DateTime beginDate = new DateTime(DateTime.Now.Year, i, 10);
            DJ_TourGroup g = CreateDemoGroup(beginDate);
            bllGroup.Save(g);
            Groups.Add(g);
        }



    //
        foreach (DJ_TourGroup g in Groups)
        {
            foreach (DJ_Route r in g.Routes)
            {
                Model.DJ_GroupConsumRecord cr = new DJ_GroupConsumRecord();
                cr.Route = r;
                cr.AdultsAmount = r.DJ_TourGroup.AdultsAmount;
                cr.ChildrenAmount = r.DJ_TourGroup.ChildrenAmount;
                cr.ConsumeTime = r.DJ_TourGroup.BeginDate.AddDays(r.DayNo);
                cr.Enterprise = r.Enterprise;
                bllConsum.Save(cr);
            }
        }



    }
    private void DeleteDemoDate()
    { 
        
    }

    private void DemoLogin(string userName, string targetUrl)
    {
        FormsAuthentication.SetAuthCookie(userName, true);
        //  Response.Redirect(targetUrl);
        ClientScript.RegisterStartupScript(this.Page.GetType(), "",
        "var opener=window.open('" + targetUrl + "','Graph','width=960,height=650;'); opener=null;", true);
    }
}