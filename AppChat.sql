USE [chatapp]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/7/2020 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[name] [varchar](10) NOT NULL,
	[password] [varchar](100) NOT NULL,
	[role] [bit] NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 6/7/2020 9:20:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[NameRoom] [nchar](50) NULL,
	[name] [nchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'admin', N'123', 1, 0)
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'ducde', N'123', 0, 1)
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'vanha', N'123', 0, 1)
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'voton', N'123', 0, 1)
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'                                                  ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'ducde                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'vanha                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'voton                                             ')

