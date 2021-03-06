USE [Chatapp]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/23/2020 2:19:00 AM ******/
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
/****** Object:  Table [dbo].[Message]    Script Date: 6/23/2020 2:19:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[MyName] [nchar](10) NULL,
	[RecipientName] [nchar](10) NULL,
	[Message] [nvarchar](250) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Room]    Script Date: 6/23/2020 2:19:00 AM ******/
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
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'thuy1', N'123', 0, 1)
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'vanha', N'123', 0, 1)
INSERT [dbo].[Account] ([name], [password], [role], [status]) VALUES (N'voton', N'123', 0, 1)
INSERT [dbo].[Message] ([MyName], [RecipientName], [Message]) VALUES (N'ducde     ', N'vanha     ', N'Anh yêu em')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'                                                  ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'ducde                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'HocNhom                                           ', N'vanha                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'anhyeus                                           ', N'                                                  ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'anhyeus                                           ', N'vanha                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'anhyeus                                           ', N'ducde                                             ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'anhyeus                                           ', N'                                                  ')
INSERT [dbo].[Room] ([NameRoom], [name]) VALUES (N'ganhyeus                                          ', N'                                                  ')
