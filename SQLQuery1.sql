
SELECT * INTO Schedule_Backup FROM Schedule;


UPDATE Schedule
SET BusScheduleDate = NULL,
    BusScheduleTime = NULL,
    ScheduleLocation = NULL,
    DriverDate = NULL,
    DriverTime = NULL,
    SpareDriver = NULL,
    DriverId = NULL;


    DELETE FROM Schedule;


    DBCC CHECKIDENT ('Schedule', NORESEED);


    DBCC CHECKIDENT ('Schedule', RESEED, 0);


    SELECT * FROM Schedule;


  DELETE FROM ScheduleOccurrence;

  DBCC CHECKIDENT ('ScheduleOccurrence', NORESEED);

  DBCC CHECKIDENT ('ScheduleOccurrence', RESEED, 0);

  SELECT Id FROM AspNetUsers WHERE Id IN (
    N'0b8ef920-dad6-4d01-9afa-78c3cb9d92b8',
    N'18893c71-425e-426e-8cc5-13f24d3fdc3f',
    N'363dd9c6-47c2-4759-bbfc-25701e3ff1049',
    N'3781efa7-66dc-47f0-860f-e506d04102e4',
    N'78c9271b-e508-4214-b105-b448185b1010'
);

SELECT Id FROM AspNetUsers WHERE Id IN (
    '0b8ef920-dad6-4d01-9afa-78c3cb9d92b8',
    '18893c71-425e-426e-8cc5-13f24d3fdc3f',
    '363dd9c6-47c2-4759-bbfc-25701e3ff1049',
    '3781efa7-66dc-47f0-860f-e506d04102e4',
    '78c9271b-e508-4214-b105-b448185b1010'
);

SELECT Id FROM AspNetRoles WHERE Id IN (
    'ad2bcf0c-20db-474f-8407-5a6b159518ba',
    '023f7028-ebed-4d50-a0c7-fc232628a75c',
    'f445a56e-14eb-4906-94d7-7af9e462dff9',
    'b20b199c-9749-4f01-8b80-a5a174d9c502',
    '414788fe-9218-4ce0-a736-4d28d265fdf9'
);

 --//dont use
DELETE FROM AspNetUserRoles
WHERE UserId NOT IN (SELECT Id FROM AspNetUsers)
   OR RoleId NOT IN (SELECT Id FROM AspNetRoles);



