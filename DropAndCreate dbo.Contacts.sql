USE [ContactsManagerAppContext-20180528160351]
GO

/****** Object: Table [dbo].[Contacts] Script Date: 5/29/2018 1:58:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Contacts];


GO
CREATE TABLE [dbo].[Contacts] (
    [ContactID]   INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]   NVARCHAR (50)  NULL,
    [LastName]    NVARCHAR (50)  NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [PhoneNumber] NVARCHAR (12)  NULL,
    [Status]      TINYINT        NULL
);


