CREATE TABLE [dbo].[Grades] (
    [Id]         INT IDENTITY (1, 1) NOT NULL,
    [Score]      INT NOT NULL,
    [Course_Id]  INT NOT NULL,
    [Student_Id] INT NOT NULL,
    CONSTRAINT [PK_dbo.Grades] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Grades_dbo.Courses_Course_Id] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Courses] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Grades_HumanResources.Person_Student_Id] FOREIGN KEY ([Student_Id]) REFERENCES [HumanResources].[Person] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Course_Id]
    ON [dbo].[Grades]([Course_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Student_Id]
    ON [dbo].[Grades]([Student_Id] ASC);

