
/*
Ĭ��Ȩ��ȫ������Ϊ δ����
*/
update DJ_TourEnterprise set CountryVeryfyState=2 where CountryVeryfyState=0
update DJ_TourEnterprise set CityVeryfyState=2 where CityVeryfyState=0
update DJ_TourEnterprise set ProvinceVeryfyState=2 where ProvinceVeryfyState=0
/*�޸Ĺ����ŵ�Ȩ��*/
  update TourMembership set PermissionType =7 
  where Id in (
   select TourMembership_id from DJ_User_Gov)
   /*��idΪ�����ľ�������������Χ*/
update DJ_TourEnterprise set CountryVeryfyState=1,CityVeryfyState=1 where Id%2=1
