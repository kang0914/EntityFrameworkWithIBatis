﻿CREATE TABLE [dbo].[MM_CODE]
(
	[GROUP_CODE] NVARCHAR(50) NOT NULL , 
    [GROUP_NAME] NVARCHAR(50) NULL, 
    [CODE] NVARCHAR(50) NOT NULL, 
    [NAME] NVARCHAR(50) NULL, 
	[REV_NO] INT NOT NULL,
    [DATA1] NVARCHAR(50) NULL, 
    [DATA2] NVARCHAR(50) NULL, 
    [DATA3] NVARCHAR(50) NULL, 
    [IUSER] NVARCHAR(50) NULL, 
    [IDATE] DATETIME NULL, 
    [DUSER] NVARCHAR(50) NULL, 
    [DDATE] DATETIME NULL, 
    PRIMARY KEY ([GROUP_CODE], [CODE], [REV_NO])
)
