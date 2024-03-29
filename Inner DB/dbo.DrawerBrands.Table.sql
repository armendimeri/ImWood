USE [ImWood]
GO
/****** Object:  Table [dbo].[DrawerBrands]    Script Date: 7/13/2020 3:59:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DrawerBrands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_DrawerBrands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DrawerBrands] ON 

INSERT [dbo].[DrawerBrands] ([ID], [Name]) VALUES (1, N'Blum')
INSERT [dbo].[DrawerBrands] ([ID], [Name]) VALUES (2, N'Hettich')
INSERT [dbo].[DrawerBrands] ([ID], [Name]) VALUES (3, N'OptiLuxe')
INSERT [dbo].[DrawerBrands] ([ID], [Name]) VALUES (4, N'Smart slide')
SET IDENTITY_INSERT [dbo].[DrawerBrands] OFF
