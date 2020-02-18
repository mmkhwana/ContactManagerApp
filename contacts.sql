CREATE TABLE [dbo].[Contacts] (
    [ContactID]          INT  IDENTITY (1, 1) NOT NULL,
    [FirstName]       NVARCHAR (50)    NOT NULL,
    [LastName]        NVARCHAR (50)    NOT NULL,
    [CellNumber]           NVARCHAR (254)   NOT NULL,
    [Email]           NVARCHAR (254)   NOT NULL,
    PRIMARY KEY CLUSTERED ([ContactID] ASC),
	UserID int FOREIGN KEY REFERENCES Users(UserID) 
);
