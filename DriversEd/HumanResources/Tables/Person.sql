CREATE TABLE [HumanResources].[Person] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [GivenName]     NVARCHAR (MAX) NULL,
    [MiddleInitial] NVARCHAR (MAX) NULL,
    [Surname]       NVARCHAR (MAX) NULL,
    [DateOfBirth]   DATETIME       NOT NULL,
    [EyeColor]      INT            NULL,
    [Course_Id]     INT            NULL,
    [Type]          NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_HumanResources.Person] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_HumanResources.Person_dbo.Courses_Course_Id] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Courses] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Course_Id]
    ON [HumanResources].[Person]([Course_Id] ASC);

