CREATE TABLE [dbo].[Courses] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Instructor_Id] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Courses] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Courses_HumanResources.Person_Instructor_Id] FOREIGN KEY ([Instructor_Id]) REFERENCES [HumanResources].[Person] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Instructor_Id]
    ON [dbo].[Courses]([Instructor_Id] ASC);

