CREATE TABLE [dbo].[ClassroomCourses] (
    [Id]         INT            NOT NULL,
    [RoomNumber] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.ClassroomCourses] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.ClassroomCourses_dbo.Courses_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Courses] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Id]
    ON [dbo].[ClassroomCourses]([Id] ASC);

