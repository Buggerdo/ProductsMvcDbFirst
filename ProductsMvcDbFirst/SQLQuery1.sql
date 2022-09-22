CREATE DATABASE ProductsMvcDbFirst;
GO

USE productsMvcDbFirst
GO


CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Brand] [nvarchar](100) NOT NULL,
	[Wholesale cost] [decimal](8, 2) NOT NULL,
	[Price] [decimal](8, 2) NOT NULL,
	[Current stock] [int] NOT NULL,
	[Last updated] [DATETIME] NOT NULL
	)

	-- Scaffold-DbContext 'Data Source=TROYSPC;Initial Catalog=ProductsMvcDbFirst; Integrated Security=SSPI;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models