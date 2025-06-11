USE [master]
GO
/****** Object:  Database [specclothes_db]    Script Date: 11.06.2025 14:01:31 ******/
CREATE DATABASE [specclothes_db]

GO
ALTER DATABASE [specclothes_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [specclothes_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [specclothes_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [specclothes_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [specclothes_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [specclothes_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [specclothes_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [specclothes_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [specclothes_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [specclothes_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [specclothes_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [specclothes_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [specclothes_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [specclothes_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [specclothes_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [specclothes_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [specclothes_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [specclothes_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [specclothes_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [specclothes_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [specclothes_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [specclothes_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [specclothes_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [specclothes_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [specclothes_db] SET RECOVERY FULL 
GO
ALTER DATABASE [specclothes_db] SET  MULTI_USER 
GO
ALTER DATABASE [specclothes_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [specclothes_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [specclothes_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [specclothes_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [specclothes_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [specclothes_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'specclothes_db', N'ON'
GO
ALTER DATABASE [specclothes_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [specclothes_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [specclothes_db]
GO
/****** Object:  DatabaseRole [Worker]    Script Date: 11.06.2025 14:01:31 ******/
CREATE ROLE [Worker]
GO
/****** Object:  DatabaseRole [Manager]    Script Date: 11.06.2025 14:01:31 ******/
CREATE ROLE [Manager]
GO
/****** Object:  DatabaseRole [Admin]    Script Date: 11.06.2025 14:01:31 ******/
CREATE ROLE [Admin]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_securitypredicate]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--DROP FUNCTION dbo.fn_securitypredicate;
CREATE FUNCTION [dbo].[fn_securitypredicate](@Role AS nvarchar(50))
RETURNS TABLE
WITH SCHEMABINDING
AS
    RETURN SELECT 1 AS result
    WHERE @Role = Substring(USER_NAME(), 0, PATINDEX('%User', USER_NAME()))
GO
/****** Object:  Table [dbo].[Archive]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Archive](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_Archive] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContentSklads]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContentSklads](
	[ID_sklad] [int] NOT NULL,
	[ID_clothe] [nvarchar](10) NOT NULL,
	[ID_size] [int] NOT NULL,
	[count] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[operation] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_logs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturers]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[type] [nvarchar](10) NOT NULL,
	[phone] [nvarchar](11) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[inn] [nvarchar](11) NOT NULL,
	[rating] [tinyint] NOT NULL,
 CONSTRAINT [PK_Manufacturers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_client] [int] NOT NULL,
	[ID_specclothes_dbclothe] [nvarchar](10) NOT NULL,
	[ID_size] [int] NOT NULL,
	[count] [int] NOT NULL,
	[datestart] [date] NOT NULL,
	[datefinish] [date] NULL,
	[ID_status] [int] NOT NULL,
	[In_Acrhive] [bit] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[article] [nvarchar](10) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[discount] [int] NOT NULL,
	[ID_manufacturer] [int] NOT NULL,
 CONSTRAINT [PK_Clothes] PRIMARY KEY CLUSTERED 
(
	[article] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsInCart]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsInCart](
	[ID_client] [int] NOT NULL,
	[ID_product] [nvarchar](10) NOT NULL,
	[ID_size] [int] NOT NULL,
	[count] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[salary] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sizes]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sizes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](5) NOT NULL,
	[value] [tinyint] NOT NULL,
 CONSTRAINT [PK_Sizes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sklads]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sklads](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Sklads] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[ID_role] [int] NOT NULL,
	[ID_size] [int] NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[phone] [nvarchar](11) NOT NULL,
	[dateofbirth] [date] NOT NULL,
	[login] [nvarchar](20) NOT NULL,
	[password] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD  CONSTRAINT [DF__Orders__In_Acrhi__367C1819]  DEFAULT ((0)) FOR [In_Acrhive]
GO
ALTER TABLE [dbo].[ContentSklads]  WITH CHECK ADD  CONSTRAINT [FK_ContentSklads_Products] FOREIGN KEY([ID_clothe])
REFERENCES [dbo].[Products] ([article])
GO
ALTER TABLE [dbo].[ContentSklads] CHECK CONSTRAINT [FK_ContentSklads_Products]
GO
ALTER TABLE [dbo].[ContentSklads]  WITH CHECK ADD  CONSTRAINT [FK_ContentSklads_Sizes] FOREIGN KEY([ID_size])
REFERENCES [dbo].[Sizes] ([ID])
GO
ALTER TABLE [dbo].[ContentSklads] CHECK CONSTRAINT [FK_ContentSklads_Sizes]
GO
ALTER TABLE [dbo].[ContentSklads]  WITH CHECK ADD  CONSTRAINT [FK_ContentSklads_Sklads] FOREIGN KEY([ID_sklad])
REFERENCES [dbo].[Sklads] ([ID])
GO
ALTER TABLE [dbo].[ContentSklads] CHECK CONSTRAINT [FK_ContentSklads_Sklads]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Clothes] FOREIGN KEY([ID_specclothes_dbclothe])
REFERENCES [dbo].[Products] ([article])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Clothes]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Statuses] FOREIGN KEY([ID_status])
REFERENCES [dbo].[Statuses] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Statuses]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([ID_client])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Clothes_Manufacturers] FOREIGN KEY([ID_manufacturer])
REFERENCES [dbo].[Manufacturers] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Clothes_Manufacturers]
GO
ALTER TABLE [dbo].[ProductsInCart]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInCart_Products] FOREIGN KEY([ID_product])
REFERENCES [dbo].[Products] ([article])
GO
ALTER TABLE [dbo].[ProductsInCart] CHECK CONSTRAINT [FK_ProductsInCart_Products]
GO
ALTER TABLE [dbo].[ProductsInCart]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInCart_Sizes] FOREIGN KEY([ID_size])
REFERENCES [dbo].[Sizes] ([ID])
GO
ALTER TABLE [dbo].[ProductsInCart] CHECK CONSTRAINT [FK_ProductsInCart_Sizes]
GO
ALTER TABLE [dbo].[ProductsInCart]  WITH CHECK ADD  CONSTRAINT [FK_ProductsInCart_Users] FOREIGN KEY([ID_client])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[ProductsInCart] CHECK CONSTRAINT [FK_ProductsInCart_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([ID_role])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
/****** Object:  StoredProcedure [dbo].[Archive_Order]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Archive_Order]
AS
BEGIN
    -- Копируем данные в архив
    INSERT INTO Archive (OrderID, UserID, ProductID, Date)
    SELECT ID, ID_client, ID_specclothes_dbclothe, datefinish
    FROM Orders
    WHERE In_Acrhive = 0 AND datefinish < DATEADD(year, -1, GETDATE()); -- Архивируем записи старше 1 года
    -- Устанавливаем флаг "In_Acrhive" для заархивированных записей
    UPDATE Orders
    SET In_Acrhive = 'True'
    WHERE ID IN (SELECT ID FROM Archive) AND datefinish < DATEADD(year, -1, GETDATE());--Только записи старше года

END;
GO
/****** Object:  StoredProcedure [dbo].[ProductView]    Script Date: 11.06.2025 14:01:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ProductView] AS
BEGIN
SELECT name AS Product, article, price FROM Products
END
--вставка данных некоторых таблиц
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([ID], [name], [salary]) VALUES (1, N'Администратор', CAST(125000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Roles] ([ID], [name], [salary]) VALUES (2, N'Менеджер', CAST(75000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Roles] ([ID], [name], [salary]) VALUES (3, N'Кладовщик', CAST(45000 AS Decimal(18, 0)))
GO
INSERT [dbo].[Roles] ([ID], [name], [salary]) VALUES (4, N'Сварщик', CAST(40000 AS Decimal(18, 0)))
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Sizes] ON 
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (1, N'XXS', 44)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (2, N'XS', 46)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (3, N'S', 48)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (4, N'M', 50)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (5, N'L', 52)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (6, N'XL', 54)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (7, N'XXL', 56)
GO
INSERT [dbo].[Sizes] ([ID], [name], [value]) VALUES (8, N'XXXL', 58)
GO
SET IDENTITY_INSERT [dbo].[Sizes] OFF
GO
SET IDENTITY_INSERT [dbo].[Statuses] ON 
GO
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (1, N'Сборка')
GO 
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (2, N'В пути')
GO
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (3, N'Получен, но товары не складированы')
GO
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (4, N'Получен и товары складированы')
GO
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (5, N'Отменен получателем')
GO
INSERT [dbo].[Statuses] ([ID], [name]) VALUES (6, N'Отменен отправителем')
GO
SET IDENTITY_INSERT [dbo].[Statuses] OFF
GO
SET IDENTITY_INSERT [dbo].[Manufacturers] ON 
GO
INSERT [dbo].[Manufacturers] ([ID], [name], [type], [phone], [email], [address], [inn], [rating]) VALUES (1, N'Спец СБ', N'ООО ОА', N'89616732331', N'spec-sb@gmail.com', N'105484, г. Москва, б-р Сиреневый, 62А', N'	7719759657', 4)
GO
INSERT [dbo].[Manufacturers] ([ID], [name], [type], [phone], [email], [address], [inn], [rating]) VALUES (2, N'Иформ', N'ООО', N'89378020095', N'falja07@mail.ru', N'обл. Московская, г.о. Люберцы, г., ул. Красная, д. 1, ком. 34', N'7701177351', 5)
GO
INSERT [dbo].[Manufacturers] ([ID], [name], [type], [phone], [email], [address], [inn], [rating]) VALUES (6, N'Формс', N'ОАО', N'89205430050', N'forms_oao@mail.ru', N'обл. Псковская, ул. Ватникова, д. 1', N'7710023041', 3)
GO
SET IDENTITY_INSERT [dbo].[Manufacturers] OFF
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'1', N'Перчатки трикотажные ЛЮКС', N'Термозащитная', CAST(29 AS Decimal(18, 0)), 12, 1)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'10', N'Нарукавники сварщика "Болид"', N'Термозащитная', CAST(1365 AS Decimal(18, 0)), 5, 6)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'11', N'Фартук сварщика "Воркшоп"', N'Летняя', CAST(2902 AS Decimal(18, 0)), 15, 6)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'12', N'Костюм сварщика цельноспилковый утепленный', N'Зимняя', CAST(14590 AS Decimal(18, 0)), 9, 2)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'14', N'Зимние рабочие защитные спилковые перчатки', N'Зимняя', CAST(743 AS Decimal(18, 0)), 7, 1)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'2', N'Полукомбинезон КОРПОРАЦИЯ летний', N'Летняя', CAST(9090 AS Decimal(18, 0)), 7, 2)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'3', N'Костюм сварщика ГИПЕРИОН 2', N'Термозащитная', CAST(21158 AS Decimal(18, 0)), 9, 2)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'4', N'Маска сварочная ', N'Головной убор', CAST(2000 AS Decimal(18, 0)), 5, 2)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'6', N'Костюм "Сварщик зимний комбинированный"', N'Зимняя', CAST(15150 AS Decimal(18, 0)), 10, 6)
GO
INSERT [dbo].[Products] ([article], [name], [type], [price], [discount], [ID_manufacturer]) VALUES (N'9', N'Подшлемник сварщика "Болид" ', N'Головной убор', CAST(1968 AS Decimal(18, 0)), 13, 6)
GO
--добавление администратора
INSERT INTO Users VALUES ('Админ', 'Админ', 'Админ', '1', '3',	'me@gmail.com',	'89000000000',	'2000-01-01',	'', '');
GO
USE [master]
GO
ALTER DATABASE [specclothes_db] SET  READ_WRITE 
GO
