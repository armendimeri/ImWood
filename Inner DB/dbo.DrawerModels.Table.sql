USE [ImWood]
GO
/****** Object:  Table [dbo].[DrawerModels]    Script Date: 7/13/2020 3:59:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DrawerModels](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BrandID] [int] NULL,
	[x] [decimal](18, 0) NULL,
	[y] [decimal](18, 0) NULL,
	[z] [decimal](18, 0) NULL,
	[s] [decimal](18, 0) NULL,
	[a] [decimal](18, 0) NULL,
	[Name] [varchar](50) NULL,
	[Formula] [varchar](50) NOT NULL,
	[KantA1] [varchar](50) NULL,
	[KantA2] [varchar](50) NULL,
	[KantB1] [varchar](50) NULL,
	[KantB2] [varchar](50) NULL,
 CONSTRAINT [PK_DrawerModels] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DrawerModels] ON 

INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (1, 1, CAST(-75 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(83 AS Decimal(18, 0)), CAST(-132 AS Decimal(18, 0)), N'Blum Antaro M', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2, 2, CAST(-77 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), CAST(64 AS Decimal(18, 0)), CAST(-79 AS Decimal(18, 0)), N'Hettich Innotech 70', N'0', N'2front', N'', N'', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (3, 2, CAST(-77 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), CAST(143 AS Decimal(18, 0)), CAST(-79 AS Decimal(18, 0)), N'Hettich Innotech 144', N'0', N'2front', N'', N'', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (4, 2, CAST(-77 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), CAST(175 AS Decimal(18, 0)), CAST(-79 AS Decimal(18, 0)), N'Hettich Innotech 176', N'0', N'2front', N'', N'', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (5, 2, CAST(-77 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), CAST(52 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), N'Hettich Innotech Atira 54', N'0', N'2front', N'', N'', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (6, 3, CAST(-75 AS Decimal(18, 0)), CAST(-10 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(67 AS Decimal(18, 0)), CAST(-75 AS Decimal(18, 0)), N'Opti Bardh A', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (7, 3, CAST(-75 AS Decimal(18, 0)), CAST(-10 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(118 AS Decimal(18, 0)), CAST(-75 AS Decimal(18, 0)), N'Opti bardh B', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (8, 3, CAST(-75 AS Decimal(18, 0)), CAST(-10 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(182 AS Decimal(18, 0)), CAST(-75 AS Decimal(18, 0)), N'Opti bardh D', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (9, 1, CAST(-75 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(166 AS Decimal(18, 0)), CAST(-132 AS Decimal(18, 0)), N'Blum Antaro C', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (10, 1, CAST(-75 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-87 AS Decimal(18, 0)), CAST(198 AS Decimal(18, 0)), CAST(-132 AS Decimal(18, 0)), N'Blum Antaro D', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (1009, 3, CAST(-86 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-97 AS Decimal(18, 0)), CAST(83 AS Decimal(18, 0)), CAST(-98 AS Decimal(18, 0)), N'OptiLuxe A', N'0', N'1front', N'', N'1gj', N'gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (1010, 3, CAST(-86 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-97 AS Decimal(18, 0)), CAST(134 AS Decimal(18, 0)), CAST(-98 AS Decimal(18, 0)), N'OptiLuxe B', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (1011, 3, CAST(-86 AS Decimal(18, 0)), CAST(-24 AS Decimal(18, 0)), CAST(-97 AS Decimal(18, 0)), CAST(198 AS Decimal(18, 0)), CAST(-98 AS Decimal(18, 0)), N'OptiLuxe D', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2012, 2, CAST(-79 AS Decimal(18, 0)), CAST(-21 AS Decimal(18, 0)), CAST(-90 AS Decimal(18, 0)), CAST(84 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), N'Hettich Arch 94', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2013, 2, CAST(-79 AS Decimal(18, 0)), CAST(-21 AS Decimal(18, 0)), CAST(-90 AS Decimal(18, 0)), CAST(176 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), N'Hettich Arch 186', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2014, 2, CAST(-79 AS Decimal(18, 0)), CAST(-21 AS Decimal(18, 0)), CAST(-90 AS Decimal(18, 0)), CAST(208 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), N'Hettich Arch 218', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2015, 2, CAST(-79 AS Decimal(18, 0)), CAST(-21 AS Decimal(18, 0)), CAST(-90 AS Decimal(18, 0)), CAST(272 AS Decimal(18, 0)), CAST(-88 AS Decimal(18, 0)), N'Hettich Arch 282', N'0', N'1front', N'', N'1gj', N'1gj')
INSERT [dbo].[DrawerModels] ([ID], [BrandID], [x], [y], [z], [s], [a], [Name], [Formula], [KantA1], [KantA2], [KantB1], [KantB2]) VALUES (2017, 4, CAST(-45 AS Decimal(18, 0)), CAST(150 AS Decimal(18, 0)), CAST(-10 AS Decimal(18, 0)), CAST(-2 AS Decimal(18, 0)), CAST(-25 AS Decimal(18, 0)), N'Front 250/8mm', N'1', N'', N'1gj', N'', N'1gj')
SET IDENTITY_INSERT [dbo].[DrawerModels] OFF
ALTER TABLE [dbo].[DrawerModels]  WITH CHECK ADD  CONSTRAINT [FK_DrawerModels_DrawerBrands] FOREIGN KEY([BrandID])
REFERENCES [dbo].[DrawerBrands] ([ID])
GO
ALTER TABLE [dbo].[DrawerModels] CHECK CONSTRAINT [FK_DrawerModels_DrawerBrands]
GO
