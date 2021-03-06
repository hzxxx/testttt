﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BLL;

public partial class LocalTravelAgent_TEDetailStatistics : System.Web.UI.Page
{
    string Year;
    int entid;
    int totalmonth_child = 0, totalmonth_audlt = 0, totalyear_child = 0, totalyear_adult = 0;
    BLLDJEnterprise blldjent = new BLLDJEnterprise();
    BLLDJConsumRecord bllRecord = new BLLDJConsumRecord();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bind();
        }
    }

    private void bind()
    {
        List<month> List = new List<month>();
        for (int i = 1; i < 13; i++)
        {
            month m = new month(i);
            List.Add(m);
        }
        rptETDetail.DataSource = List;
        rptETDetail.DataBind();
        Year = Request.QueryString["year"];
        entid = int.Parse(Request.QueryString["entid"]);
        ETName.InnerHtml = blldjent.GetDJS8id(entid.ToString())[0].Name;
    }
    protected void rptETDetail_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
       
    }

    protected void rptETMonthDetail_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
        {
            DJ_GroupConsumRecord record = e.Item.DataItem as DJ_GroupConsumRecord;
            Literal laCountInfo = e.Item.FindControl("laCountInfo") as Literal;
            if (blldjent.GetDJS8id(entid.ToString())[0].Type == EnterpriseType.景点)
            {
                totalmonth_audlt += record.AdultsAmount;
                totalmonth_child += record.ChildrenAmount;
                totalyear_child += record.ChildrenAmount;
                totalyear_adult += record.AdultsAmount;
                laCountInfo.Text = "成人" + record.AdultsAmount.ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;" + "儿童" + record.ChildrenAmount.ToString();
            }
            if (blldjent.GetDJS8id(entid.ToString())[0].Type == EnterpriseType.宾馆)
            {
                totalmonth_audlt += record.AdultsAmount * record.LiveDay;
                totalmonth_child += record.ChildrenAmount * record.LiveDay;
                totalyear_adult += record.AdultsAmount * record.LiveDay;
                totalyear_child += record.ChildrenAmount * record.LiveDay;
                laCountInfo.Text = "成人" + (record.AdultsAmount * record.LiveDay).ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;" + "儿童" + (record.ChildrenAmount * record.LiveDay).ToString();
            }
            Literal laMonthTotal = e.Item.Parent.Parent.FindControl("laMonthTotal") as Literal;
            laMonthTotal.Text = "成人" + totalmonth_audlt.ToString() + "&nbsp;&nbsp;&nbsp;&nbsp;" + "儿童" + totalmonth_child.ToString();
        }
    }
    protected void btnExcel_Click(object sender, EventArgs e)
    {
    }
}



public class ExcelTable
{
    public string date { get; set; }
    public string detail { get; set; }
}
