/****** Object: SqlProcedure [dbo].[StudentDelete] Script Date: 2/9/2015 7:48:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[StudentDelete];


GO
CREATE PROCEDURE [dbo].[StudentDelete]
	@Id int
AS
	UPDATE Student SET isDeleted = 1 WHERE Id = @Id
RETURN 0


/****** Object: SqlProcedure [dbo].[StudentInsert] Script Date: 2/9/2015 7:48:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[StudentInsert];


GO
CREATE PROCEDURE [dbo].[StudentInsert]
	@firstName AS VARCHAR(50),
	@lastName AS VARCHAR(50)
AS
	INSERT INTO Student
				(firstName,
				 lastName)
	VALUES		(@firstName,
				 @lastName)
RETURN 0


/****** Object: SqlProcedure [dbo].[StudentSearch] Script Date: 2/9/2015 7:52:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[StudentSearch];


GO
CREATE PROCEDURE [dbo].[StudentSearch]
	@QueryType VARCHAR(10) = NULL,
	@Id INT = NULL,
	@firstName AS VARCHAR(50) = NULL,
	@lastName AS VARCHAR(50) = NULL,
	@isDeleted AS INT = NULL
AS
	IF @QueryType = 'ALL'
	BEGIN
		SELECT Id,
			   firstName,
			   lastName,
			   isDeleted
		FROM   Student
	END
	ELSE
	BEGIN
		SELECT Id,
			   firstName,
			   lastName,
			   isDeleted
		FROM   Student
		WHERE  (Id = @Id OR @Id IS NULL) AND
			   (firstName = @firstName OR @firstName IS NULL) AND
			   (lastName = @lastName OR @lastName IS NULL) AND
			   (isDeleted = @isDeleted OR @isDeleted IS NULL)
	END
RETURN 0


/****** Object: SqlProcedure [dbo].[StudentUpdate] Script Date: 2/9/2015 7:50:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE [dbo].[StudentUpdate];


GO
CREATE PROCEDURE [dbo].[StudentUpdate]
	@Id AS INT,
	@firstName AS VARCHAR(50),
	@lastName AS VARCHAR(50),
	@isDeleted AS INT
AS
	UPDATE Student
	SET firstName = @firstName,
	    lastName = @lastName,
		isDeleted = @isDeleted
	WHERE Id = @Id
RETURN 0
