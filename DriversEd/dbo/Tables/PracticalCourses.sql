CREATE TABLE [dbo].[PracticalCourses] (
    [Id]     INT            NOT NULL,
    [Street] NVARCHAR (MAX) NULL,
    [City]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.PracticalCourses] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.PracticalCourses_dbo.Courses_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Courses] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Id]
    ON [dbo].[PracticalCourses]([Id] ASC);

