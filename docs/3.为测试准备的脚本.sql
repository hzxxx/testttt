/*
ɾ�������ظ�����ҵ*/
select *
from DJ_TourEnterprise where Name in ('����ɽ���Ļ�԰','���ϳ���')
delete from DJ_TourEnterprise where id in(116
,450
,378
,470)
delete from Scenic where DJ_TourEnterprise_id in(116
,450
,378
,470) 
delete from Ticket where Scenic_id in (116
,450
,378
,470) 
select *
delete from TicketPrice where Ticket_id in 
  (select Id from Ticket where Scenic_id in(116
,450
,378
,470))
select * 
delete
from DJ_User_TourEnterprise where Enterprise_id in (116
,450
,378
,470)
/*�޸Ĺ����ŵ�Ȩ��*/
  update TourMembership set PermissionType =7 
  where Id in (
   select TourMembership_id from DJ_User_Gov)
   /*��idΪ�����ľ�������������Χ*/
update DJ_TourEnterprise set CountryVeryfyState=1,CityVeryfyState=1 where Id%2=1
