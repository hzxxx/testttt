  
  
  INSERT [TourOnline].[dbo].[DJ_TourEnterprise] 
  ([Name],[Address],[ChargePersonName],[ChargePersonPhone],[Phone],[Type],[Area_id])
  VALUES
  ('����������','������������','������','15988880000','0571-88886666',5,'1019')

  
  INSERT INTO [TourOnline].[dbo].[DJ_DijiesheInfo]
  VALUES(438)

  INSERT INTO [TourOnline].[dbo].[DJ_Group_Base]
VALUES ('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1A',1,'141034198005171821','������',
'15988765412',438)
INSERT INTO [TourOnline].[dbo].[DJ_Group_Base]
VALUES ('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1B',1,'141034198005174280','���綬',
'15988765413',438)
INSERT INTO [TourOnline].[dbo].[DJ_Group_Guide]
VALUES('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1A','DY001')
INSERT INTO [TourOnline].[dbo].[DJ_Group_Guide]
VALUES('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1B','DY002')

  INSERT INTO [TourOnline].[dbo].[DJ_Group_Base]
VALUES ('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1C',1,'141034198005171821','������',
'15988765412',438)
INSERT INTO [TourOnline].[dbo].[DJ_Group_Base]
VALUES ('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1D',1,'141034198005174280','���綫',
'15988765413',438)
INSERT INTO [TourOnline].[dbo].[DJ_Group_Driver]
VALUES('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1C','��A00001')
INSERT INTO [TourOnline].[dbo].[DJ_Group_Driver]
VALUES('B889DEA4-D3A1-4A48-BBF3-A0D20110BD1D','��A00001')

--�Ŷ���Ϣ
insert into DJ_TourEnterprise values('���ݵؽ���','��Ϫ·358��','����','330203515695','874569253',1,5,1019)
insert into DJ_dijiesheInfo values(438)
insert into DJ_TourGroup values('e4fd78ba-9ed6-49a4-9331-66f93d4f85b7','�㽭����������','2012-10-7','2012-10-9',3,20,3,438)
insert into DJ_Group_Worker values(newid(),'330203198705265484','������','18992548675','54786523q',1,'e4fd78ba-9ed6-49a4-9331-66f93d4f85b7')
insert into DJ_Route values(newid(),1,8,15,'�ι۽���ɽ����',435,null,'e4fd78ba-9ed6-49a4-9331-66f93d4f85b7')