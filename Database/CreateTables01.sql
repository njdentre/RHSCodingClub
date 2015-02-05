/****** Object: Table [dbo].[Student] Script Date: 1/28/2015 9:09:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Student];


GO
CREATE TABLE [dbo].[Student] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [firstName] VARCHAR (50) NULL,
    [lastName]  VARCHAR (50) NULL,
    [isDeleted] INT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


/****** Object: Table [dbo].[Course] Script Date: 1/28/2015 9:20:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Course];


GO
CREATE TABLE [dbo].[Course] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [name]  VARCHAR (50) NULL,
    [level] VARCHAR (10) NULL,
    [isDeleted] INT NOT NULL DEFAULT 0, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


/****** Object: Table [dbo].[StudentCourse] Script Date: 1/28/2015 9:20:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[StudentCourse];


GO
CREATE TABLE [dbo].[StudentCourse] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [studentId]  INT NOT NULL,
    [courseId]   INT NOT NULL,
    [finalGrade] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


