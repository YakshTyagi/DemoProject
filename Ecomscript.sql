USE [master]
GO
/****** Object:  Database [Demo_Project]    Script Date: 20-12-2021 13:20:44 ******/
CREATE DATABASE [Demo_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Demo_Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Demo_Project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Demo_Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Demo_Project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Demo_Project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Demo_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Demo_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Demo_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Demo_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Demo_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Demo_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [Demo_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Demo_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Demo_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Demo_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Demo_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Demo_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Demo_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Demo_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Demo_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Demo_Project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Demo_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Demo_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Demo_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Demo_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Demo_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Demo_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Demo_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Demo_Project] SET RECOVERY FULL 
GO
ALTER DATABASE [Demo_Project] SET  MULTI_USER 
GO
ALTER DATABASE [Demo_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Demo_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Demo_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Demo_Project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Demo_Project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Demo_Project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Demo_Project', N'ON'
GO
ALTER DATABASE [Demo_Project] SET QUERY_STORE = OFF
GO
USE [Demo_Project]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[ID] [uniqueidentifier] NOT NULL,
	[City] [varchar](100) NOT NULL,
	[State] [varchar](100) NOT NULL,
	[Country] [varchar](100) NOT NULL,
	[AddressLine1] [varchar](100) NOT NULL,
	[AddressLine2] [varchar](100) NULL,
	[Zip_Code] [int] NOT NULL,
	[Label] [varchar](100) NULL,
	[UserID] [uniqueidentifier] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CART]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CART](
	[CustomerID] [uniqueidentifier] NULL,
	[QUANTITY] [int] NULL,
	[IS_WISHLIST_ITEM] [bit] NULL,
	[ProductVariationID] [uniqueidentifier] NULL,
	[ProductID] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [uniqueidentifier] NOT NULL,
	[CategoryName] [varchar](100) NOT NULL,
	[ProductID] [uniqueidentifier] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_METADATA_FIELD]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_METADATA_FIELD](
	[CategoryMetadataFieldID] [uniqueidentifier] NOT NULL,
	[CategoryFIELDName] [nvarchar](4000) NOT NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryMetadataFieldID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CATEGORY_METADATA_FIELD_VALUES]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORY_METADATA_FIELD_VALUES](
	[CategoryMetadataFieldID] [uniqueidentifier] NULL,
	[CategoryID] [uniqueidentifier] NULL,
	[Values] [nvarchar](4000) NOT NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[UserID] [uniqueidentifier] NULL,
	[Customer_Contact] [numeric](10, 0) NOT NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Customer_Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[OrderProductId] [uniqueidentifier] NOT NULL,
	[OrderId] [uniqueidentifier] NULL,
	[Quantity] [int] NULL,
	[Price] [numeric](10, 2) NULL,
	[ProductVariationID] [uniqueidentifier] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[OrderProductId] [uniqueidentifier] NULL,
	[FromStatus] [date] NULL,
	[ToStatus] [date] NULL,
	[TRANSITION_NOTES_COMMENTS] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderTable](
	[OrderId] [uniqueidentifier] NOT NULL,
	[CustomerID] [uniqueidentifier] NULL,
	[Amount_Paid] [numeric](10, 2) NULL,
	[AddressId] [uniqueidentifier] NULL,
	[Date_created] [date] NULL,
	[last_updated] [datetime] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
	[ProductVariationId] [uniqueidentifier] NULL,
	[ProductId] [uniqueidentifier] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [uniqueidentifier] NOT NULL,
	[Sellerid] [uniqueidentifier] NULL,
	[P_Name] [varchar](100) NOT NULL,
	[P_Description] [varchar](250) NOT NULL,
	[Is_Cancelable] [bit] NULL,
	[Is_Returnable] [bit] NULL,
	[Brand] [varchar](100) NOT NULL,
	[Is_Active] [bit] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Review]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Review](
	[Customer_User_ID] [uniqueidentifier] NULL,
	[Review] [varchar](1000) NULL,
	[Rating] [float] NULL,
	[ProductID] [uniqueidentifier] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Variation]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Variation](
	[ProductVariationID] [uniqueidentifier] NOT NULL,
	[ProductID] [uniqueidentifier] NULL,
	[Qunatity_Available] [int] NULL,
	[Price] [numeric](10, 2) NULL,
	[Variation_Metadata] [nvarchar](4000) NULL,
	[Primary_Image_Name] [varchar](1000) NULL,
	[Is_Active] [bit] NULL,
	[date_created] [datetime] NULL,
	[last_updated] [datetime] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductVariationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleTable]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleTable](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Authority] [varchar](50) NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seller]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seller](
	[Sellerid] [uniqueidentifier] NULL,
	[GST] [nvarchar](15) NOT NULL,
	[Company_Contact] [numeric](10, 0) NOT NULL,
	[Company_Name] [varchar](100) NOT NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL,
	[SellerNote] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Company_Contact] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[UserID] [uniqueidentifier] NULL,
	[RoleID] [int] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](100) NULL,
	[updated_by] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 20-12-2021 13:20:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[ID] [uniqueidentifier] NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[First_Name] [varchar](100) NOT NULL,
	[Last_Name] [varchar](100) NOT NULL,
	[UPassword] [nvarchar](max) NOT NULL,
	[Is_Deleted] [bit] NULL,
	[Is_Active] [bit] NULL,
	[date_created] [date] NULL,
	[last_updated] [date] NULL,
	[created_by] [varchar](500) NULL,
	[updated_by] [varchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Addresses] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Addresses] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CART] ADD  DEFAULT ((0)) FOR [IS_WISHLIST_ITEM]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (newid()) FOR [CategoryID]
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CATEGORY_METADATA_FIELD] ADD  DEFAULT (newid()) FOR [CategoryMetadataFieldID]
GO
ALTER TABLE [dbo].[CATEGORY_METADATA_FIELD] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[CATEGORY_METADATA_FIELD_VALUES] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[OrderProduct] ADD  DEFAULT (newid()) FOR [OrderProductId]
GO
ALTER TABLE [dbo].[OrderProduct] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[OrderStatus] ADD  DEFAULT (getdate()) FOR [FromStatus]
GO
ALTER TABLE [dbo].[OrderTable] ADD  DEFAULT (newid()) FOR [OrderId]
GO
ALTER TABLE [dbo].[OrderTable] ADD  DEFAULT (getdate()) FOR [Date_created]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (newid()) FOR [ProductID]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [Is_Cancelable]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [Is_Returnable]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT ((0)) FOR [Is_Active]
GO
ALTER TABLE [dbo].[Product] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Product_Review] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Product_Variation] ADD  DEFAULT (newid()) FOR [ProductVariationID]
GO
ALTER TABLE [dbo].[RoleTable] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Seller] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[UserRole] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[UserTable] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[UserTable] ADD  DEFAULT ((0)) FOR [Is_Deleted]
GO
ALTER TABLE [dbo].[UserTable] ADD  DEFAULT ((0)) FOR [Is_Active]
GO
ALTER TABLE [dbo].[UserTable] ADD  DEFAULT (getdate()) FOR [date_created]
GO
ALTER TABLE [dbo].[Addresses]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[CART]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[CART]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[CART]  WITH CHECK ADD FOREIGN KEY([ProductVariationID])
REFERENCES [dbo].[Product_Variation] ([ProductVariationID])
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[CATEGORY_METADATA_FIELD_VALUES]  WITH CHECK ADD FOREIGN KEY([CategoryMetadataFieldID])
REFERENCES [dbo].[CATEGORY_METADATA_FIELD] ([CategoryMetadataFieldID])
GO
ALTER TABLE [dbo].[CATEGORY_METADATA_FIELD_VALUES]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD FOREIGN KEY([OrderId])
REFERENCES [dbo].[OrderTable] ([OrderId])
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD FOREIGN KEY([ProductVariationID])
REFERENCES [dbo].[Product_Variation] ([ProductVariationID])
GO
ALTER TABLE [dbo].[OrderStatus]  WITH CHECK ADD FOREIGN KEY([OrderProductId])
REFERENCES [dbo].[OrderProduct] ([OrderProductId])
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([ID])
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD FOREIGN KEY([ProductVariationId])
REFERENCES [dbo].[Product_Variation] ([ProductVariationID])
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([Sellerid])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[Product_Review]  WITH CHECK ADD FOREIGN KEY([Customer_User_ID])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[Product_Review]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Product_Variation]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Seller]  WITH CHECK ADD FOREIGN KEY([Sellerid])
REFERENCES [dbo].[UserTable] ([ID])
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD FOREIGN KEY([RoleID])
REFERENCES [dbo].[RoleTable] ([RoleID])
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTable] ([ID])
GO
USE [master]
GO
ALTER DATABASE [Demo_Project] SET  READ_WRITE 
GO
