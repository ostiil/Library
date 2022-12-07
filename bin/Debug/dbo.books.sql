CREATE TABLE [dbo].[books] (
    [id_book]        NUMERIC (5) NOT NULL,
    [name_book]      CHAR (50)   NOT NULL,
    [autor]          CHAR (50)   NULL,
    [year_of_public] CHAR(50)        NULL,
    [quantity]       NUMERIC (5) NULL,
    PRIMARY KEY CLUSTERED ([id_book] ASC)
);

