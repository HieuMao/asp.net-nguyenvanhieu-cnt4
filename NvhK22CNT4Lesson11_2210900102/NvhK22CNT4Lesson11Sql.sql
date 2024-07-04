USE [NvhK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[NvhCategory]    Script Date: 7/4/2024 9:37:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NvhCategory](
	[NvhId] [int] NOT NULL,
	[NvhCateName] [nvarchar](50) NULL,
	[NvhStatus] [bit] NULL,
 CONSTRAINT [PK_NvhCategory] PRIMARY KEY CLUSTERED 
(
	[NvhId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NvhProduct]    Script Date: 7/4/2024 9:37:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NvhProduct](
	[NvhId2210900102] [nvarchar](50) NOT NULL,
	[NvhProName] [nvarchar](50) NULL,
	[NvhQty] [int] NULL,
	[NvhPrice] [float] NULL,
	[NvhCateId] [int] NULL,
	[NvhActive] [bit] NULL,
 CONSTRAINT [PK_NvhProduct] PRIMARY KEY CLUSTERED 
(
	[NvhId2210900102] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NvhCategory] ([NvhId], [NvhCateName], [NvhStatus]) VALUES (1, N'2210900102', 1)
INSERT [dbo].[NvhCategory] ([NvhId], [NvhCateName], [NvhStatus]) VALUES (2, N'Iphone', 0)
GO
INSERT [dbo].[NvhProduct] ([NvhId2210900102], [NvhProName], [NvhQty], [NvhPrice], [NvhCateId], [NvhActive]) VALUES (N'2210900102', N'Nguyễn Văn Hiếu', 10, 100, 1, 1)
INSERT [dbo].[NvhProduct] ([NvhId2210900102], [NvhProName], [NvhQty], [NvhPrice], [NvhCateId], [NvhActive]) VALUES (N'P001', N'Iphone Pro MAx', 1, 200, 1, 1)
GO
ALTER TABLE [dbo].[NvhProduct]  WITH CHECK ADD  CONSTRAINT [FK_NvhProduct_NvhCategory] FOREIGN KEY([NvhCateId])
REFERENCES [dbo].[NvhCategory] ([NvhId])
GO
ALTER TABLE [dbo].[NvhProduct] CHECK CONSTRAINT [FK_NvhProduct_NvhCategory]
GO
