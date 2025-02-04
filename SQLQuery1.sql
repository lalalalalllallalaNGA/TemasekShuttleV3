
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




