USE [Nvh-Lesson10]
GO
/****** Object:  Table [dbo].[NvhAccount]    Script Date: 7/3/2024 2:04:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NvhAccount](
	[NvhID] [int] NOT NULL,
	[NvhUserName] [nvarchar](50) NULL,
	[NvhPassword] [nvarchar](50) NULL,
	[NvhFullName] [nvarchar](50) NULL,
	[NvhEmail] [nvarchar](50) NULL,
	[NvhPhone] [nvarchar](50) NULL,
	[NvhActive] [bit] NULL,
 CONSTRAINT [PK_NvhAccount] PRIMARY KEY CLUSTERED 
(
	[NvhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
