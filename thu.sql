USE [QUANLYCHUNGCU]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] NOT NULL,
	[ApartmentId] [int] NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[InfoId] [int] NULL,
	[RoleId] [int] NULL,
	[TrangThai] [tinyint] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[AddressId] [int] NOT NULL,
	[City] [nvarchar](max) NULL,
	[District] [nvarchar](max) NULL,
	[ward] [nvarchar](max) NULL,
	[StreetAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Apartment]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartment](
	[ApartmentId] [int] NOT NULL,
	[BuildingId] [int] NULL,
	[ApartmentNumber] [int] NULL,
	[FloorNumber] [int] NULL,
	[Area] [float] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_CanHo] PRIMARY KEY CLUSTERED 
(
	[ApartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Apartment_Service]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Apartment_Service](
	[ApartmentId] [int] NOT NULL,
	[ServiceId] [int] NOT NULL,
	[StartDay] [nchar](10) NULL,
	[EndDay] [nchar](10) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_Apartment_Service] PRIMARY KEY CLUSTERED 
(
	[ApartmentId] ASC,
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Building]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Building](
	[BuildingId] [int] NOT NULL,
	[BuildingName] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
	[City] [varchar](max) NULL,
	[Zip] [varchar](max) NULL,
	[FloorNumber] [int] NULL,
	[ApartmentNumber] [int] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_ChungCu] PRIMARY KEY CLUSTERED 
(
	[BuildingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractId] [int] NOT NULL,
	[ApartmentId] [int] NULL,
	[AccountId] [int] NULL,
	[StartDay] [nchar](10) NULL,
	[EndDay] [date] NULL,
	[Monthly_rent] [decimal](18, 0) NULL,
	[Deposit] [decimal](18, 0) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[ContractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ElectricMeter]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ElectricMeter](
	[ElectricMeterId] [int] NOT NULL,
	[ApartmentId] [int] NULL,
	[RegistrationDate] [date] NULL,
	[Code] [varchar](max) NULL,
	[DeadingDate] [date] NULL,
	[NumberOne] [float] NULL,
	[NumberEnd] [float] NULL,
	[Price] [decimal](18, 0) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_ElectricMeter] PRIMARY KEY CLUSTERED 
(
	[ElectricMeterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[History]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[History](
	[HistoryId] [int] NOT NULL,
	[AccountId] [int] NULL,
	[Day] [date] NULL,
	[description] [varchar](max) NULL,
	[Action] [tinyint] NULL,
	[Screen] [varchar](max) NULL,
 CONSTRAINT [PK_History] PRIMARY KEY CLUSTERED 
(
	[HistoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InFo]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InFo](
	[InfoId] [int] NOT NULL,
	[FullName] [varchar](max) NULL,
	[BirthDay] [nchar](10) NULL,
	[Sex] [tinyint] NULL,
	[AddressId] [int] NULL,
 CONSTRAINT [PK_InFo] PRIMARY KEY CLUSTERED 
(
	[InfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[NewsId] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Slug] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[CreateDay] [date] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResidentsRequired]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResidentsRequired](
	[RequestId] [int] NOT NULL,
	[AccountId] [int] NULL,
	[ApartmentId] [int] NULL,
	[Title] [varchar](max) NULL,
	[description] [varchar](max) NULL,
	[CreateDay] [date] NULL,
	[FixDay] [date] NULL,
	[Pending] [int] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_ResidentsRequired] PRIMARY KEY CLUSTERED 
(
	[RequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Revenue]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Revenue](
	[RevenueId] [int] NOT NULL,
	[ApartmentId] [int] NULL,
	[TotalMoney] [decimal](18, 0) NULL,
	[Pay] [decimal](18, 0) NULL,
	[Debt] [decimal](18, 0) NULL,
	[ServiceFee] [decimal](18, 0) NULL,
	[CodeVoucher] [varchar](max) NULL,
	[ReceivingMoney] [decimal](18, 0) NULL,
	[DayCreat] [date] NULL,
	[DayPay] [date] NULL,
	[Payments] [tinyint] NULL,
	[AccountId] [int] NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_Revenue] PRIMARY KEY CLUSTERED 
(
	[RevenueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] NOT NULL,
	[RoleName] [varbinary](max) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceId] [int] NOT NULL,
	[ServiceName] [nchar](10) NULL,
	[description] [nchar](10) NULL,
	[ServiceFee] [decimal](18, 0) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WaterMeter]    Script Date: 12/2/2023 11:40:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WaterMeter](
	[WaterMeterId] [int] NOT NULL,
	[ApartmentId] [int] NULL,
	[RegistrationDate] [date] NULL,
	[Code] [varchar](max) NULL,
	[DeadingDate] [date] NULL,
	[NumberOne] [float] NULL,
	[NumberEnd] [float] NULL,
	[Price] [decimal](18, 0) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_WaterMeter] PRIMARY KEY CLUSTERED 
(
	[WaterMeterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Apartment]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_InFo] FOREIGN KEY([InfoId])
REFERENCES [dbo].[InFo] ([InfoId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_InFo]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[Apartment]  WITH CHECK ADD  CONSTRAINT [FK_CanHo_ChungCu] FOREIGN KEY([BuildingId])
REFERENCES [dbo].[Building] ([BuildingId])
GO
ALTER TABLE [dbo].[Apartment] CHECK CONSTRAINT [FK_CanHo_ChungCu]
GO
ALTER TABLE [dbo].[Apartment_Service]  WITH CHECK ADD  CONSTRAINT [FK_Apartment_Service_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[Apartment_Service] CHECK CONSTRAINT [FK_Apartment_Service_Apartment]
GO
ALTER TABLE [dbo].[Apartment_Service]  WITH CHECK ADD  CONSTRAINT [FK_Apartment_Service_Service] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Service] ([ServiceId])
GO
ALTER TABLE [dbo].[Apartment_Service] CHECK CONSTRAINT [FK_Apartment_Service_Service]
GO
ALTER TABLE [dbo].[Contract]  WITH CHECK ADD  CONSTRAINT [FK_Contract_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[Contract] CHECK CONSTRAINT [FK_Contract_Apartment]
GO
ALTER TABLE [dbo].[ElectricMeter]  WITH CHECK ADD  CONSTRAINT [FK_ElectricMeter_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[ElectricMeter] CHECK CONSTRAINT [FK_ElectricMeter_Apartment]
GO
ALTER TABLE [dbo].[History]  WITH CHECK ADD  CONSTRAINT [FK_History_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[History] CHECK CONSTRAINT [FK_History_Account]
GO
ALTER TABLE [dbo].[InFo]  WITH CHECK ADD  CONSTRAINT [FK_InFo_Address] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Address] ([AddressId])
GO
ALTER TABLE [dbo].[InFo] CHECK CONSTRAINT [FK_InFo_Address]
GO
ALTER TABLE [dbo].[ResidentsRequired]  WITH CHECK ADD  CONSTRAINT [FK_ResidentsRequired_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[ResidentsRequired] CHECK CONSTRAINT [FK_ResidentsRequired_Apartment]
GO
ALTER TABLE [dbo].[Revenue]  WITH CHECK ADD  CONSTRAINT [FK_Revenue_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[Revenue] CHECK CONSTRAINT [FK_Revenue_Apartment]
GO
ALTER TABLE [dbo].[WaterMeter]  WITH CHECK ADD  CONSTRAINT [FK_WaterMeter_Apartment] FOREIGN KEY([ApartmentId])
REFERENCES [dbo].[Apartment] ([ApartmentId])
GO
ALTER TABLE [dbo].[WaterMeter] CHECK CONSTRAINT [FK_WaterMeter_Apartment]
GO
