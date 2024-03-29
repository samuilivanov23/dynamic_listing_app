use ps_object_listing;

insert into segments(Length, BestEffortTimeMinutes, StartLocation, EndLocation) 
values
	(12.4, 21, 'start1', 'end1'),
	(13.4, 22, 'start2', 'end2'),
	(14.4, 24, 'start3', 'end3'),
	(15.4, 25, 'start4', 'end4'),
	(16.4, 26, 'start5', 'end5'),
	(17.4, 27, 'start6', 'end6'),
	(18.4, 28, 'start7', 'end7'),
	(19.4, 29, 'start8', 'end8'),
	(20.4, 30, 'start9', 'end9');

insert into athletes(FirstName, MiddleName, LastName, ActivitiesCount, Followers, Following) 
values
	('FirstName1', 'MiddleName1', 'LastName1', 36, 9, 17),
	('FirstName2', 'MiddleName2', 'LastName2', 37, 10, 18),
	('FirstName3', 'MiddleName3', 'LastName3', 38, 11, 19),
	('FirstName4', 'MiddleName4', 'LastName4', 39, 12, 20),
	('FirstName5', 'MiddleName5', 'LastName5', 40, 13, 21),
	('FirstName6', 'MiddleName6', 'LastName6', 41, 14, 22),
	('FirstName7', 'MiddleName7', 'LastName7', 42, 15, 23),
	('FirstName8', 'MiddleName8', 'LastName8', 43, 16, 24),
	('FirstName9', 'MiddleName9', 'LastName9', 55, 17, 25);

insert into activity_sessions(Distance, ElevationGain, MaxElevation, TimeMovingMinutes, TotalTimeMinutes, KudosCount)
values
	(20.77, 350, 1200, 78, 103, 14),
	(21.77, 330, 1300, 80, 104, 15),
	(22.77, 320, 1400, 82, 105, 16),
	(23.45, 342, 1212, 84, 106, 17),
	(24.76, 350, 1243, 85, 107, 18),
	(25.77, 365, 1234, 86, 108, 19),
	(26.34, 167, 1254, 87, 109, 23),
	(27.36, 275, 1122, 88, 110, 9),
	(28.71, 867, 1502, 89, 111, 63);


insert into session_analysis(HeartRateMin, HeartRateMax, HeartRateAvg, PowerAvg)
values
	(71, 181, 155, 130),
	(72, 182, 156, 131),
	(73, 183, 157, 132),
	(74, 184, 158, 133),
	(75, 185, 159, 134),
	(76, 186, 160, 135);


select * from segments;

select * from athletes;

select * from activity_sessions;

select * from session_analysis;