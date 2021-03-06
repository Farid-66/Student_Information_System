USE [master]
GO
/****** Object:  Database [PreSkoolDb]    Script Date: 4/6/2022 12:25:35 PM ******/
CREATE DATABASE [PreSkoolDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PreSkoolDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PreSkoolDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PreSkoolDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PreSkoolDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PreSkoolDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PreSkoolDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PreSkoolDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PreSkoolDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PreSkoolDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PreSkoolDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PreSkoolDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [PreSkoolDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PreSkoolDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PreSkoolDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PreSkoolDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PreSkoolDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PreSkoolDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PreSkoolDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PreSkoolDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PreSkoolDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PreSkoolDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PreSkoolDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PreSkoolDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PreSkoolDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PreSkoolDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PreSkoolDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PreSkoolDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [PreSkoolDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PreSkoolDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PreSkoolDb] SET  MULTI_USER 
GO
ALTER DATABASE [PreSkoolDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PreSkoolDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PreSkoolDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PreSkoolDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PreSkoolDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PreSkoolDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PreSkoolDb] SET QUERY_STORE = OFF
GO
USE [PreSkoolDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Annuals]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Annuals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[CustomUserId] [nvarchar](450) NULL,
	[Fees] [nvarchar](50) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Annuals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassToSubjects]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassToSubjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[ClassId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL,
 CONSTRAINT [PK_ClassToSubjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[HOD] [nvarchar](150) NULL,
	[DepartmentStartDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ClassToSubjectId] [int] NOT NULL,
	[StartTime] [datetime2](7) NOT NULL,
	[EndTime] [datetime2](7) NOT NULL,
	[EventDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExpensesTypeId] [int] NOT NULL,
	[Quality] [nvarchar](100) NULL,
	[Name] [nvarchar](100) NULL,
	[Amount] [nvarchar](100) NULL,
	[SourceOfPurchase] [nvarchar](100) NULL,
	[ExpensesDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpensesTypes]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpensesTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ExpensesTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holidays]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holidays](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[HolidayTypeId] [int] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Holidays] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HolidayTypes]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HolidayTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_HolidayTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libraries]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libraries](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](50) NULL,
	[Language] [nvarchar](50) NULL,
	[DepartmentId] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Libraries] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salaries]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salaries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[CustomUserId] [nvarchar](450) NULL,
	[Amount] [nvarchar](50) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Salaries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[DepartmentId] [int] NOT NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenderId] [int] NOT NULL,
	[ClassId] [int] NOT NULL,
	[SectionId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](100) NULL,
	[MobilNumber] [nvarchar](50) NULL,
	[CustomUserId] [nvarchar](450) NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[JoiningDate] [datetime2](7) NOT NULL,
	[StudentImage] [nvarchar](450) NULL,
	[FathersName] [nvarchar](50) NULL,
	[FathersOccupation] [nvarchar](150) NULL,
	[FathersEmail] [nvarchar](50) NULL,
	[FathersMobil] [nvarchar](50) NULL,
	[MothersName] [nvarchar](50) NULL,
	[MothersOccupation] [nvarchar](150) NULL,
	[MothersEmail] [nvarchar](50) NULL,
	[MothersMobil] [nvarchar](50) NULL,
	[PresentAddress] [nvarchar](2000) NULL,
	[PermanentAddress] [nvarchar](2000) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 4/6/2022 12:25:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomUserId] [nvarchar](450) NULL,
	[GenderId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](150) NULL,
	[MobilNumber] [nvarchar](50) NULL,
	[SubjectId] [int] NOT NULL,
	[Qualification] [nvarchar](250) NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[JoiningDate] [datetime2](7) NOT NULL,
	[Experience] [nvarchar](15) NULL,
	[TeacherImage] [nvarchar](450) NULL,
	[Address] [nvarchar](250) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[ZipCode] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220315122412_init', N'5.0.13')
GO
SET IDENTITY_INSERT [dbo].[Annuals] ON 

INSERT [dbo].[Annuals] ([Id], [Title], [CustomUserId], [Fees], [CreatedDate]) VALUES (3, N'Annual', N'e5f9d6d1-7585-4d58-a21e-195ca3bea1e6', N'1200', CAST(N'2022-03-16T23:15:48.5456080' AS DateTime2))
INSERT [dbo].[Annuals] ([Id], [Title], [CustomUserId], [Fees], [CreatedDate]) VALUES (4, N'Annual', N'488bf25a-9348-4cf0-a67e-ef99438a76dd', N'1200', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Annuals] ([Id], [Title], [CustomUserId], [Fees], [CreatedDate]) VALUES (5, N'Annual', N'f60a2097-4898-412b-ac1b-14d061b9d4de', N'400', CAST(N'2022-03-30T10:50:28.8566502' AS DateTime2))
INSERT [dbo].[Annuals] ([Id], [Title], [CustomUserId], [Fees], [CreatedDate]) VALUES (6, N'Annual', N'706dd5dd-fec9-4378-86a1-0b9155bfaef2', N'1000', CAST(N'2022-03-30T12:10:57.0392569' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Annuals] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'44bac831-38d7-451f-8255-4fdfb312e12e', N'Student', N'STUDENT', N'2d360716-22f3-43de-a0d0-e111fc6a8778')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'5cdc7a2c-bc57-4900-a073-cac7c662ac65', N'Administrator', N'ADMINISTRATOR', N'b49f0cac-148a-4cd8-9ecc-4186fd5dc06c')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'f4f31fe5-fe87-4aff-a70e-0e1239af5f6d', N'Teacher', N'TEACHER', N'75d15455-2b1e-4f23-b784-a3683785aca2')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'488bf25a-9348-4cf0-a67e-ef99438a76dd', N'44bac831-38d7-451f-8255-4fdfb312e12e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'706dd5dd-fec9-4378-86a1-0b9155bfaef2', N'44bac831-38d7-451f-8255-4fdfb312e12e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e5f9d6d1-7585-4d58-a21e-195ca3bea1e6', N'44bac831-38d7-451f-8255-4fdfb312e12e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f60a2097-4898-412b-ac1b-14d061b9d4de', N'44bac831-38d7-451f-8255-4fdfb312e12e')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b884146e-5c20-4d4d-8b0b-206c693acc8d', N'5cdc7a2c-bc57-4900-a073-cac7c662ac65')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2f0f2e56-b582-4feb-8354-ab888c705287', N'f4f31fe5-fe87-4aff-a70e-0e1239af5f6d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4abac2a3-d92b-4b4a-84f4-949c26c51d4e', N'f4f31fe5-fe87-4aff-a70e-0e1239af5f6d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c8e1a747-e00a-4002-99a5-1cb1e3202969', N'f4f31fe5-fe87-4aff-a70e-0e1239af5f6d')
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2f0f2e56-b582-4feb-8354-ab888c705287', N'CustomUser', N'Zakir', N'Məhərəmmov', CAST(N'2022-03-30T12:14:26.8326646' AS DateTime2), N'zakirmeheremmov@gmail.preskool.com', N'ZAKIRMEHEREMMOV@GMAIL.PRESKOOL.COM', N'zakirmeheremmov@gmail.preskool.com', N'ZAKIRMEHEREMMOV@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEDlJSodNb8dxBNKQxA7paxEnKS+xHdTzPghUpym5zd2EU/IHqz4wx/orl4CC1FoOsA==', N'XO2B2W3L5G537F6BSYZ6LIMLS2TUFMRI', N'4851f566-d73a-40c3-ac18-88f3c2afe91f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'488bf25a-9348-4cf0-a67e-ef99438a76dd', N'CustomUser', N'Kozma  ', N'Tatari', CAST(N'2022-03-17T17:07:46.5561221' AS DateTime2), N'kozmatatari@gmail.preskool.com', N'KOZMATATARI@GMAIL.PRESKOOL.COM', N'kozmatatari@gmail.preskool.com', N'KOZMATATARI@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEFLNwY0Y55AddCoC3dn4BoLm7SYoIsNzO1G0qqKeqLLgnYpekD0d3pPI7m3G0gLYIg==', N'ENZCJGZRLAEZSAA4SJFIYMFMKTJIAK5U', N'c8aa3554-5709-4412-80c7-35730c0ee8e7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4abac2a3-d92b-4b4a-84f4-949c26c51d4e', N'CustomUser', N'Sabir', N'Əliyev', CAST(N'2022-03-30T10:54:41.1533509' AS DateTime2), N'sabiraliyev@gmail.preskool.com', N'SABIRALIYEV@GMAIL.PRESKOOL.COM', N'sabiraliyev@gmail.preskool.com', N'SABIRALIYEV@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEJPwE4Kd+2fJK25lBWwzIZ/bgWHi21GyFid4kVg0RsQ1hANVm/vnFQ62WT06owjjLw==', N'S75LY4YN7366ZWCJZ5ZTEW5UPMROHCXI', N'196414b0-bb7c-4629-b1a2-ba341e3dfcf3', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'706dd5dd-fec9-4378-86a1-0b9155bfaef2', N'CustomUser', N'Elxan', N'Seyidov', CAST(N'2022-03-30T12:09:30.4378725' AS DateTime2), N'elxanseyidov@gmail.preskool.com', N'ELXANSEYIDOV@GMAIL.PRESKOOL.COM', N'elxanseyidov@gmail.preskool.com', N'ELXANSEYIDOV@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEIPH9WCkvSQYHqn7uIEulWRH3NEIPFFlqtFTH1Et65R4yD4tKHeB1v1qMRx1om050g==', N'ZME6WG32ZDY3KQEQVFWFZAZQW4FJCIDT', N'75f528ff-9c2f-4391-bbfc-77f852815879', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b884146e-5c20-4d4d-8b0b-206c693acc8d', N'CustomUser', N'Farid', N'Alaskarov', CAST(N'2022-03-16T23:05:12.4061202' AS DateTime2), N'faridalaskarov@gmail.com', N'FARIDALASKAROV@GMAIL.COM', N'faridalaskarov@gmail.com', N'FARIDALASKAROV@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJGVkVgfp3+fzr9WuAPQ3PhmNnyQW5vUDoMSTdYjblnhJC5hkW3wcDgM5v30tgUGUw==', N'5YHCT7ICGQ7DPMZ7TH4CRNNG7DXZGDL2', N'13501e2b-284c-48b3-9727-bfbe910de8b7', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c8e1a747-e00a-4002-99a5-1cb1e3202969', N'CustomUser', N'Fazil', N'Quliyev', CAST(N'2022-03-16T19:24:57.1997445' AS DateTime2), N'fazilquliyev@gmail.preskool.com', N'FAZILQULIYEV@GMAIL.PRESKOOL.COM', N'fazilquliyev@gmail.preskool.com', N'FAZILQULIYEV@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEK+ZesDC5lmt4VmmD+IGTSUDdSulBFYggrGp/XnhqcBm75Wfg0DbE3GbANxM8QbOOA==', N'A27BNRMVTVE263HMGT653AC6G6VXHWIV', N'dffc2fb0-be6e-4bbc-84b1-0b7e3679cfee', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e5f9d6d1-7585-4d58-a21e-195ca3bea1e6', N'CustomUser', N'Levell', N'Scott', CAST(N'2022-03-16T23:11:02.0454599' AS DateTime2), N'levellscott@gmail.preskool.com', N'LEVELLSCOTT@GMAIL.PRESKOOL.COM', N'levellscott@gmail.preskool.com', N'LEVELLSCOTT@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEKB6SWvBw0/jISFVlL5h792JbLPyPqGDx63LzwFajMShdzrQrg5ulCZbSbzyncjdmQ==', N'HZG5YJCAM6KO7EBGF2CKOHGQ6G5TWYMD', N'cbefc634-1c22-45b2-a70d-b60da5a66d02', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Surname], [CreatedDate], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f60a2097-4898-412b-ac1b-14d061b9d4de', N'CustomUser', N'Nikola', N'Tesla', CAST(N'2022-03-30T10:49:04.3915060' AS DateTime2), N'nikolatesla@gmail.preskool.com', N'NIKOLATESLA@GMAIL.PRESKOOL.COM', N'nikolatesla@gmail.preskool.com', N'NIKOLATESLA@GMAIL.PRESKOOL.COM', 0, N'AQAAAAEAACcQAAAAEOsvZejA+/bBax3r16ZLL1rImvOHGCwRCk60iuCWxgDgPaQtk+N/uVCWa9Rs0tbe/Q==', N'DW6OH7LHR6F45XFGCA5SEKBQTQYH3AW5', N'63ccc989-25b4-45d5-bc29-98a61eb1ba20', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([Id], [Name]) VALUES (5, N'EL201')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (6, N'P101')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (7, N'668a1')
INSERT [dbo].[Classes] ([Id], [Name]) VALUES (8, N'668a1')
SET IDENTITY_INSERT [dbo].[Classes] OFF
GO
SET IDENTITY_INSERT [dbo].[ClassToSubjects] ON 

INSERT [dbo].[ClassToSubjects] ([Id], [Name], [ClassId], [SubjectId]) VALUES (3, N'P101/Html', 6, 3)
INSERT [dbo].[ClassToSubjects] ([Id], [Name], [ClassId], [SubjectId]) VALUES (4, N'P101/Css', 6, 4)
INSERT [dbo].[ClassToSubjects] ([Id], [Name], [ClassId], [SubjectId]) VALUES (5, N'P101/JAVASCRIPT', 6, 5)
INSERT [dbo].[ClassToSubjects] ([Id], [Name], [ClassId], [SubjectId]) VALUES (6, N'P101/English', 6, 1)
INSERT [dbo].[ClassToSubjects] ([Id], [Name], [ClassId], [SubjectId]) VALUES (7, N'668a1/C#', 7, 6)
SET IDENTITY_INSERT [dbo].[ClassToSubjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Name], [HOD], [DepartmentStartDate], [CreatedDate]) VALUES (1, N'Mechanical Engg', N'Levell Scott', CAST(N'2016-02-01T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-16T18:06:13.4963142' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Exams] ON 

INSERT [dbo].[Exams] ([Id], [Name], [ClassToSubjectId], [StartTime], [EndTime], [EventDate], [CreatedDate]) VALUES (2, N'Half Yearly', 3, CAST(N'2022-03-29T22:00:00.0000000' AS DateTime2), CAST(N'2022-03-29T12:00:00.0000000' AS DateTime2), CAST(N'2022-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-29T16:58:11.8688606' AS DateTime2))
INSERT [dbo].[Exams] ([Id], [Name], [ClassToSubjectId], [StartTime], [EndTime], [EventDate], [CreatedDate]) VALUES (3, N'Half Yearly', 3, CAST(N'2022-03-30T22:00:00.0000000' AS DateTime2), CAST(N'2022-03-30T12:00:00.0000000' AS DateTime2), CAST(N'2022-03-24T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-30T12:06:10.9161162' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Exams] OFF
GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([Id], [ExpensesTypeId], [Quality], [Name], [Amount], [SourceOfPurchase], [ExpensesDate], [CreatedDate]) VALUES (1, 1, N'34', N'Hard disk', N'400', N'Sony Center', CAST(N'2022-03-02T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-16T18:57:19.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Expenses] OFF
GO
SET IDENTITY_INSERT [dbo].[ExpensesTypes] ON 

INSERT [dbo].[ExpensesTypes] ([Id], [Name]) VALUES (1, N'College ')
SET IDENTITY_INSERT [dbo].[ExpensesTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([Id], [Name]) VALUES (1, N'Male')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (2, N'Female')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
SET IDENTITY_INSERT [dbo].[Holidays] ON 

INSERT [dbo].[Holidays] ([Id], [Name], [HolidayTypeId], [StartDate], [EndDate], [CreatedDate]) VALUES (1, N'Annual Day', 3, CAST(N'2022-02-28T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-05T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-16T19:07:49.0103083' AS DateTime2))
INSERT [dbo].[Holidays] ([Id], [Name], [HolidayTypeId], [StartDate], [EndDate], [CreatedDate]) VALUES (2, N'Novruz', 2, CAST(N'2022-03-20T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-27T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-30T12:17:02.0262417' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Holidays] OFF
GO
SET IDENTITY_INSERT [dbo].[HolidayTypes] ON 

INSERT [dbo].[HolidayTypes] ([Id], [Name]) VALUES (1, N'Annual Day')
INSERT [dbo].[HolidayTypes] ([Id], [Name]) VALUES (2, N'Public Holiday')
INSERT [dbo].[HolidayTypes] ([Id], [Name]) VALUES (3, N'College Holiday')
SET IDENTITY_INSERT [dbo].[HolidayTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Libraries] ON 

INSERT [dbo].[Libraries] ([BookId], [BookName], [Language], [DepartmentId], [CreatedDate]) VALUES (1, N'Acoustics', N'English', 1, CAST(N'2022-03-16T23:18:45.7575159' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Libraries] OFF
GO
SET IDENTITY_INSERT [dbo].[Salaries] ON 

INSERT [dbo].[Salaries] ([Id], [Title], [CustomUserId], [Amount], [CreatedDate]) VALUES (1, N'Salary', N'c8e1a747-e00a-4002-99a5-1cb1e3202969', N'600', CAST(N'2022-03-16T19:25:33.0056135' AS DateTime2))
INSERT [dbo].[Salaries] ([Id], [Title], [CustomUserId], [Amount], [CreatedDate]) VALUES (2, N'Salary', N'4abac2a3-d92b-4b4a-84f4-949c26c51d4e', N'400', CAST(N'2022-03-30T10:55:16.0000000' AS DateTime2))
INSERT [dbo].[Salaries] ([Id], [Title], [CustomUserId], [Amount], [CreatedDate]) VALUES (3, N'Salary', N'2f0f2e56-b582-4feb-8354-ab888c705287', N'500', CAST(N'2022-03-30T12:15:00.3125698' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Salaries] OFF
GO
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([Id], [Name], [DepartmentId]) VALUES (1, N'Computer Sincecis', 1)
SET IDENTITY_INSERT [dbo].[Sections] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [GenderId], [ClassId], [SectionId], [Name], [Surname], [MobilNumber], [CustomUserId], [DateOfBirth], [JoiningDate], [StudentImage], [FathersName], [FathersOccupation], [FathersEmail], [FathersMobil], [MothersName], [MothersOccupation], [MothersEmail], [MothersMobil], [PresentAddress], [PermanentAddress], [CreatedDate]) VALUES (5, 1, 6, 1, N'Levell', N'Scott', N'+994506275656', N'e5f9d6d1-7585-4d58-a21e-195ca3bea1e6', CAST(N'2022-02-27T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-11T00:00:00.0000000' AS DateTime2), N'b10537d9-27e5-4db9-8ca7-8a80a9e55c1c-avatar-04.jpg', N'Jeffrey ', N's', N'.', N'.', N'.', N'.', N'.', N'.', N'Rruga E Kavajes, Condor Center, Tirana', N'Rruga E Kavajes, Condor Center, Tirana', CAST(N'2022-03-16T23:11:02.1591079' AS DateTime2))
INSERT [dbo].[Students] ([Id], [GenderId], [ClassId], [SectionId], [Name], [Surname], [MobilNumber], [CustomUserId], [DateOfBirth], [JoiningDate], [StudentImage], [FathersName], [FathersOccupation], [FathersEmail], [FathersMobil], [MothersName], [MothersOccupation], [MothersEmail], [MothersMobil], [PresentAddress], [PermanentAddress], [CreatedDate]) VALUES (6, 2, 6, 1, N'Kozma  ', N'Tatari', N'+10506275656', N'488bf25a-9348-4cf0-a67e-ef99438a76dd', CAST(N'2002-06-12T00:00:00.0000000' AS DateTime2), CAST(N'2022-02-28T00:00:00.0000000' AS DateTime2), N'58695e21-3118-4c43-b372-b1de016ad76d-avatar-08.jpg', N'Jeffrey', N'.', N'feridquba66@gmail.com', N'+10506275656', N'.', N'.', N'feridquba66@gmail.com', N'+10506275656', N'Azerbaijan', N'Azerbaijan', CAST(N'2022-03-17T17:07:47.0038508' AS DateTime2))
INSERT [dbo].[Students] ([Id], [GenderId], [ClassId], [SectionId], [Name], [Surname], [MobilNumber], [CustomUserId], [DateOfBirth], [JoiningDate], [StudentImage], [FathersName], [FathersOccupation], [FathersEmail], [FathersMobil], [MothersName], [MothersOccupation], [MothersEmail], [MothersMobil], [PresentAddress], [PermanentAddress], [CreatedDate]) VALUES (7, 1, 6, 1, N'Nikola', N'Tesla', N'+994506275656', N'f60a2097-4898-412b-ac1b-14d061b9d4de', CAST(N'2007-02-28T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-24T00:00:00.0000000' AS DateTime2), N'81fd9373-22b9-4553-899c-489b225d4f27-download.jpg', N'Jeffrey ', N'.', N'.', N'.', N'.', N'.', N'.', N'.', N' The New Yorker Hotel, New ', N' The New Yorker Hotel, New York, United States', CAST(N'2022-03-30T10:49:05.0070000' AS DateTime2))
INSERT [dbo].[Students] ([Id], [GenderId], [ClassId], [SectionId], [Name], [Surname], [MobilNumber], [CustomUserId], [DateOfBirth], [JoiningDate], [StudentImage], [FathersName], [FathersOccupation], [FathersEmail], [FathersMobil], [MothersName], [MothersOccupation], [MothersEmail], [MothersMobil], [PresentAddress], [PermanentAddress], [CreatedDate]) VALUES (8, 1, 6, 1, N'Elxan', N'Seyidov', N'+994506275656', N'706dd5dd-fec9-4378-86a1-0b9155bfaef2', CAST(N'2002-02-14T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-24T00:00:00.0000000' AS DateTime2), N'25b0e047-89e4-4ce4-8e78-f3d41b1bf874-avatar-10.jpg', N'Kamran', N'.', N'.', N'.', N'.', N'.', N'.', N'.', N'Azerbaycan Bakı Yasamal', N'Azerbaycan Bakı Yasamal', CAST(N'2022-03-30T12:09:30.7957928' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Subjects] ON 

INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (1, N'English')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (2, N'History')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (3, N'HTML')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (4, N'CSS')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (5, N'JAVASCRIPT')
INSERT [dbo].[Subjects] ([Id], [Name]) VALUES (6, N'C#')
SET IDENTITY_INSERT [dbo].[Subjects] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([Id], [CustomUserId], [GenderId], [Name], [Surname], [MobilNumber], [SubjectId], [Qualification], [DateOfBirth], [JoiningDate], [Experience], [TeacherImage], [Address], [City], [State], [ZipCode], [Country], [CreatedDate]) VALUES (1, N'c8e1a747-e00a-4002-99a5-1cb1e3202969', 1, N'Fazil', N'Quliyev', N'+994506275656', 1, N'ff', CAST(N'1990-01-16T00:00:00.0000000' AS DateTime2), CAST(N'2021-08-11T00:00:00.0000000' AS DateTime2), N'5', N'82b64982-fa55-4f4f-8296-cd5a1779624d-avatar-10.jpg', N'123, This Appartment, Near Ocean Street New York', N'Baku', N'.', N'Az4000', N'Azerbaijan', CAST(N'2022-03-16T19:24:58.6620000' AS DateTime2))
INSERT [dbo].[Teachers] ([Id], [CustomUserId], [GenderId], [Name], [Surname], [MobilNumber], [SubjectId], [Qualification], [DateOfBirth], [JoiningDate], [Experience], [TeacherImage], [Address], [City], [State], [ZipCode], [Country], [CreatedDate]) VALUES (3, N'4abac2a3-d92b-4b4a-84f4-949c26c51d4e', 1, N'Sabir', N'Əliyev', N'+994506275656', 1, N'Eng', CAST(N'2021-08-30T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-02T00:00:00.0000000' AS DateTime2), N'5', N'47d39ba1-6730-49e9-8a0b-83da9a53f54a-avatar-10.jpg', N'123, This Appartment, Near Ocean Street New York', N'Baku', N'Az', N'Az4000', N'Azerbaijan', CAST(N'2022-03-30T10:54:41.2882686' AS DateTime2))
INSERT [dbo].[Teachers] ([Id], [CustomUserId], [GenderId], [Name], [Surname], [MobilNumber], [SubjectId], [Qualification], [DateOfBirth], [JoiningDate], [Experience], [TeacherImage], [Address], [City], [State], [ZipCode], [Country], [CreatedDate]) VALUES (4, N'2f0f2e56-b582-4feb-8354-ab888c705287', 1, N'Zakir', N'Məhərəmmov', N'+994506275656', 5, N'Frontend ', CAST(N'1998-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2022-03-10T00:00:00.0000000' AS DateTime2), N'4', N'adcee962-42a8-48f6-a04b-71ca1043af29-avatar-04.jpg', N'123, This Appartment, Near Ocean Street New York', N'Baku', N'Az', N'Az4000', N'Azerbaijan', CAST(N'2022-03-30T12:14:27.0001187' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Annuals_CustomUserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Annuals_CustomUserId] ON [dbo].[Annuals]
(
	[CustomUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClassToSubjects_ClassId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_ClassToSubjects_ClassId] ON [dbo].[ClassToSubjects]
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClassToSubjects_SubjectId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_ClassToSubjects_SubjectId] ON [dbo].[ClassToSubjects]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Exams_ClassToSubjectId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Exams_ClassToSubjectId] ON [dbo].[Exams]
(
	[ClassToSubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Expenses_ExpensesTypeId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Expenses_ExpensesTypeId] ON [dbo].[Expenses]
(
	[ExpensesTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Holidays_HolidayTypeId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Holidays_HolidayTypeId] ON [dbo].[Holidays]
(
	[HolidayTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Libraries_DepartmentId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Libraries_DepartmentId] ON [dbo].[Libraries]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Salaries_CustomUserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Salaries_CustomUserId] ON [dbo].[Salaries]
(
	[CustomUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Sections_DepartmentId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Sections_DepartmentId] ON [dbo].[Sections]
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_ClassId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Students_ClassId] ON [dbo].[Students]
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Students_CustomUserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Students_CustomUserId] ON [dbo].[Students]
(
	[CustomUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_GenderId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Students_GenderId] ON [dbo].[Students]
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Students_SectionId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Students_SectionId] ON [dbo].[Students]
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Teachers_CustomUserId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Teachers_CustomUserId] ON [dbo].[Teachers]
(
	[CustomUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Teachers_GenderId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Teachers_GenderId] ON [dbo].[Teachers]
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Teachers_SubjectId]    Script Date: 4/6/2022 12:25:36 PM ******/
CREATE NONCLUSTERED INDEX [IX_Teachers_SubjectId] ON [dbo].[Teachers]
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Annuals]  WITH CHECK ADD  CONSTRAINT [FK_Annuals_AspNetUsers_CustomUserId] FOREIGN KEY([CustomUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Annuals] CHECK CONSTRAINT [FK_Annuals_AspNetUsers_CustomUserId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ClassToSubjects]  WITH CHECK ADD  CONSTRAINT [FK_ClassToSubjects_Classes_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClassToSubjects] CHECK CONSTRAINT [FK_ClassToSubjects_Classes_ClassId]
GO
ALTER TABLE [dbo].[ClassToSubjects]  WITH CHECK ADD  CONSTRAINT [FK_ClassToSubjects_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ClassToSubjects] CHECK CONSTRAINT [FK_ClassToSubjects_Subjects_SubjectId]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_ClassToSubjects_ClassToSubjectId] FOREIGN KEY([ClassToSubjectId])
REFERENCES [dbo].[ClassToSubjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_ClassToSubjects_ClassToSubjectId]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_ExpensesTypes_ExpensesTypeId] FOREIGN KEY([ExpensesTypeId])
REFERENCES [dbo].[ExpensesTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_ExpensesTypes_ExpensesTypeId]
GO
ALTER TABLE [dbo].[Holidays]  WITH CHECK ADD  CONSTRAINT [FK_Holidays_HolidayTypes_HolidayTypeId] FOREIGN KEY([HolidayTypeId])
REFERENCES [dbo].[HolidayTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Holidays] CHECK CONSTRAINT [FK_Holidays_HolidayTypes_HolidayTypeId]
GO
ALTER TABLE [dbo].[Libraries]  WITH CHECK ADD  CONSTRAINT [FK_Libraries_Departments_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Libraries] CHECK CONSTRAINT [FK_Libraries_Departments_DepartmentId]
GO
ALTER TABLE [dbo].[Salaries]  WITH CHECK ADD  CONSTRAINT [FK_Salaries_AspNetUsers_CustomUserId] FOREIGN KEY([CustomUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Salaries] CHECK CONSTRAINT [FK_Salaries_AspNetUsers_CustomUserId]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Departments_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Departments_DepartmentId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_AspNetUsers_CustomUserId] FOREIGN KEY([CustomUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_AspNetUsers_CustomUserId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Classes_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Classes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Classes_ClassId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Genders_GenderId] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Genders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Genders_GenderId]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Sections_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Sections] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Sections_SectionId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_AspNetUsers_CustomUserId] FOREIGN KEY([CustomUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_AspNetUsers_CustomUserId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Genders_GenderId] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Genders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Genders_GenderId]
GO
ALTER TABLE [dbo].[Teachers]  WITH CHECK ADD  CONSTRAINT [FK_Teachers_Subjects_SubjectId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subjects] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teachers] CHECK CONSTRAINT [FK_Teachers_Subjects_SubjectId]
GO
USE [master]
GO
ALTER DATABASE [PreSkoolDb] SET  READ_WRITE 
GO
