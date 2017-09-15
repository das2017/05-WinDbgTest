USE [WinDbgDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[TblCity](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CityNameC] [varchar](400) NOT NULL CONSTRAINT [DF_TblCity_CityNameC]  DEFAULT (''),
	[CityCode] [varchar](3) NOT NULL CONSTRAINT [DF_TblCity_CityCode]  DEFAULT (''),
	[AirportCode] [varchar](3) NOT NULL CONSTRAINT [DF_TblCity_AirPort]  DEFAULT (''),
 CONSTRAINT [PK_TblCity] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TblCity', @level2type=N'COLUMN',@level2name=N'ID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市中文名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TblCity', @level2type=N'COLUMN',@level2name=N'CityNameC'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市三字码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TblCity', @level2type=N'COLUMN',@level2name=N'CityCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'机场三字码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TblCity', @level2type=N'COLUMN',@level2name=N'AirportCode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'城市信息表' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'TblCity'
GO