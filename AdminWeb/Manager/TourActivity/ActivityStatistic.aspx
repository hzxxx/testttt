﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Manager/manager.master" AutoEventWireup="true" CodeFile="ActivityStatistic.aspx.cs" Inherits="Manager_TourActivity_ActivityStatistic" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphmain" Runat="Server">
    门票总结
    <asp:RadioButtonList ID="RadioButtonList1" runat="server"  AutoPostBack="true"
        RepeatDirection="Horizontal" 
        onselectedindexchanged="RadioButtonList1_SelectedIndexChanged">
        <asp:ListItem Selected="True" Text="按时间维度" Value="按时间维度"></asp:ListItem>
        <asp:ListItem  Text="按供应商维度" Value="按供应商维度"></asp:ListItem>
        <asp:ListItem Text="按门票维度" Value="按门票维度"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:Repeater runat="server" ID="rptTime">
        <HeaderTemplate>
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        活动日期
                    </td>
                    <td>
                        售出票总数
                    </td>
                    <td>
                        验票总数
                    </td>
                    <td>
                        详细情况
                    </td>
                </tr>
            
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <%# DateTime.Parse((Container.DataItem).ToString()).ToString("yyyy-MM-dd") %>
                </td>
                <td>
                    
                </td>
                <td>
                
                </td>
                <td>
                    
                </td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            <tr>
                总计
            </tr>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
