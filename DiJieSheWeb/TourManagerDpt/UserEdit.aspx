﻿<%@ Page Title="" Language="C#" MasterPageFile="~/TourManagerDpt/manager.master" AutoEventWireup="true" CodeFile="UserEdit.aspx.cs" Inherits="TourManagerDpt_UserEdit" %>
<%@ MasterType VirtualPath="~/TourManagerDpt/manager.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style type="text/css"> 
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="main" Runat="Server">
    <div class="detail_titlebg">
        用户编辑
    </div>
    <div class="detaillist">
        <table border="0" cellpadding="0" cellspacing="0" width="40%">
            <tr>
                <td>
                    用户名
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    权限
                </td>
                <td >
                    <asp:CheckBoxList ID="cbList" runat="server" CssClass="rbl" style="border:none !important">
                        <asp:ListItem Value="1" >行业管理员</asp:ListItem>
                        <asp:ListItem Value="2" >信息维护员</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="BtnSave" runat="server" Text="保存" CssClass="btn" 
                        onclick="BtnSave_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
