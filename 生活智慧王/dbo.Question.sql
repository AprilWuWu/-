CREATE TABLE [dbo].[Question] (
    [id]         INT        IDENTITY (1, 1) NOT NULL,
    [title]      NTEXT      NOT NULL,
    [categoryID] INT        NOT NULL,
    [content]    NTEXT      NOT NULL,
    [datetime]   SMALLDATETIME      NOT NULL,
    [img]        NTEXT      NOT NULL,
    [hits]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

