﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommonLibrary;
using System.Security.Cryptography;
using System.Text;
using System.IO;

public partial class example_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpPostHelp hph = new HttpPostHelp();
        string newstr = "123";
        newstr = hph.Encrypt(newstr, "abcdefgh");
        newstr = Server.UrlEncode(newstr);
        string data = hph.PostDataToUrl(newstr, "http://www.tol.cn/example/Handler.ashx");
        Label1.Text = data;
    }




}