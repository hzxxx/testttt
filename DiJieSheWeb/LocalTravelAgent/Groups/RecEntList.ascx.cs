﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

public partial class LocalTravelAgent_Groups_RecEntList : System.Web.UI.UserControl
{
    BLLDJEnterprise bllEnt = new BLLDJEnterprise();
    BLLDJ_GovManageDepartment bllGov = new BLLDJ_GovManageDepartment();
    public int Index = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindRecEnt();
        }
    }

    private void bindRecEnt()
    {
        Guid dptid;
        Guid.TryParse(Request.QueryString["dptid"],out dptid);
        DJ_GovManageDepartment Gov= bllGov.GetById(dptid);
        List<DJ_TourEnterprise> ListEnt = new List<DJ_TourEnterprise>();
        if(ddlArea.SelectedValue=="全部")
            ListEnt = bllEnt.GetRewardEntList(Gov, null, RewardType.已纳入).ToList();
        if (ddlArea.SelectedValue == "景区")
            ListEnt = bllEnt.GetRewardEntList(Gov, EnterpriseType.景点, RewardType.已纳入).ToList();
        if(ddlArea.SelectedValue=="宾馆")
            ListEnt = bllEnt.GetRewardEntList(Gov, EnterpriseType.宾馆, RewardType.已纳入).ToList();
        rptRecList.DataSource = ListEnt;
        rptRecList.DataBind();
    }
    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        bindRecEnt();
    }
}