USE [master]
GO
/****** Object:  Database [ProjParameterizacion]    Script Date: 06/01/2022 17:50:04 ******/
CREATE DATABASE [ProjParameterizacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjParameterizacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ProjParameterizacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjParameterizacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ProjParameterizacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjParameterizacion] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjParameterizacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjParameterizacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjParameterizacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjParameterizacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjParameterizacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjParameterizacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjParameterizacion] SET  MULTI_USER 
GO
ALTER DATABASE [ProjParameterizacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjParameterizacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjParameterizacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjParameterizacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjParameterizacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjParameterizacion] SET QUERY_STORE = OFF
GO
USE [ProjParameterizacion]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [ProjParameterizacion]
GO
/****** Object:  Table [dbo].[TbParam001Marca]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbParam001Marca](
	[TbParam001Codigo] [int] IDENTITY(1,1) NOT NULL,
	[TbParam001Descripcion] [nvarchar](10) NULL,
	[TbParam001Status] [bit] NULL,
	[TbParam001Fecha] [datetime] NULL,
	[TbParam001_Sist001Usr] [int] NULL,
 CONSTRAINT [PK_TbParametro001Marca] PRIMARY KEY CLUSTERED 
(
	[TbParam001Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbParam002Modelo]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbParam002Modelo](
	[TbParam002Codigo] [int] IDENTITY(1,1) NOT NULL,
	[TbParam002Modelo] [nvarchar](3) NULL,
	[TbParam002_Param001Codigo] [int] NULL,
	[TbParam002Status] [bit] NULL,
	[TbParam002Fecha] [datetime] NULL,
	[TbParam02_Sist001Usr] [int] NULL,
 CONSTRAINT [PK_TbParam002Modelo] PRIMARY KEY CLUSTERED 
(
	[TbParam002Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbParam001Marca] ON 

INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (1, N'VOLKSWAGEM', 1, CAST(N'2021-10-24T23:55:50.463' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (2, N'RENAULT', 1, CAST(N'2021-10-24T23:51:48.123' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (3, N'AUDI', 1, CAST(N'2021-10-24T23:53:40.740' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (4, N'FERRARI', 0, CAST(N'2021-10-24T23:58:04.827' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (5, N'BUGATTI', 0, CAST(N'2021-10-24T23:58:02.887' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (6, N'FIAT', 0, CAST(N'2021-10-24T23:58:02.887' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (7, N'MERCEDES', 0, CAST(N'2022-01-06T10:17:50.850' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (8, N'FORD', 0, CAST(N'2022-01-06T10:21:08.600' AS DateTime), 1)
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) 
VALUES (9, N'TOYOTA', 0, CAST(N'2022-01-06T12:59:12.143' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[TbParam001Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[TbParam002Modelo] ON 

INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr])
VALUES (1, N'1.0', 1, 1, CAST(N'2021-10-24T23:46:12.063' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (2, N'1.5', 1, 1, CAST(N'2021-10-24T23:45:44.147' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (3, N'2.0', 1, 1, CAST(N'2021-10-24T23:45:48.170' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (4, N'1.0', 2, 0, CAST(N'2022-01-06T12:56:38.080' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (5, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:14.977' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (6, N'2.5', 2, 0, CAST(N'2021-10-24T23:51:16.587' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (7, N'3.0', 2, 0, CAST(N'2021-10-24T23:51:16.807' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (8, N'3.5', 2, 0, CAST(N'2021-10-24T23:51:16.993' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (9, N'4.0', 2, 0, CAST(N'2022-01-06T12:57:07.557' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (10, N'1.2', 1, 0, CAST(N'2022-01-06T11:53:52.913' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (11, N'1.3', 1, 0, CAST(N'2022-01-06T12:55:26.100' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (12, N'1.0', 4, 0, CAST(N'2022-01-06T11:47:39.197' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (13, N'2.5', 1, 0, CAST(N'2022-01-06T11:54:01.637' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (14, N'2.1', 1, 0, CAST(N'2022-01-06T12:39:59.500' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (15, N'1.0', 9, 0, CAST(N'2022-01-06T12:59:18.190' AS DateTime), 1)
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) 
VALUES (16, N'1.5', 9, 0, CAST(N'2022-01-06T12:59:33.853' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[TbParam002Modelo] OFF
GO
ALTER TABLE [dbo].[TbParam002Modelo]  WITH CHECK ADD  CONSTRAINT [FK_TbParam002Modelo_TbParam001Marca] FOREIGN KEY([TbParam002_Param001Codigo])
REFERENCES [dbo].[TbParam001Marca] ([TbParam001Codigo])
GO
ALTER TABLE [dbo].[TbParam002Modelo] CHECK CONSTRAINT [FK_TbParam002Modelo_TbParam001Marca]
GO
/****** Object:  StoredProcedure [dbo].[SpMarca001CarregaMarca]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[SpMarca001CarregaMarca]

AS 
 

	SELECT 
		 [TbParam001Codigo]			ID
		,[TbParam001Descripcion]	[Marca]
		,[TbParam001Status]			[Status]
		,CONVERt(char(10),[TbParam001Fecha],103)  Fecha
	FROM [dbo].[TbParam001Marca]

 

GO
/****** Object:  StoredProcedure [dbo].[SpMarca001CarregaModelo]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   procedure [dbo].[SpMarca001CarregaModelo]
	@IdMarca	as int 

AS
 

	SELECT 
		 [TbParam002Codigo]									ID
		,[TbParam001Descripcion]							Marca
		,[TbParam002Modelo]									Modelo
		,[TbParam001Descripcion] +'-' + [TbParam002Modelo]	MarcaModelo
		,[TbParam002Status]									[Status]	
		,CONVERt(char(10),[TbParam002Fecha],103)		    Fecha
	FROM  [dbo].[TbParam002Modelo]
	INNER JOIN [dbo].[TbParam001Marca] ON [TbParam002_Param001Codigo]		= [TbParam001Codigo]
	WHERE [TbParam001Codigo]			= @IdMarca    

GO
/****** Object:  StoredProcedure [dbo].[SpMarca001Guardar]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SpMarca001Guardar] 
				 @Descripcion as nvarchar(10)
			   , @Status as      BIT
			   , @Usr as         int
			   , @ID as          int           = NULL
			   , @RESP AS        NVARCHAR(500) OUTPUT
AS
BEGIN
	-- FIJAMOS LA TRANSACCIÓN COMO SERIALIZABLE, PARA EVITAR PROBLEMAS CON LA CONCURRENCIA	
	SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	
	DECLARE @EXISTE TINYINT;
	SELECT @EXISTE = COUNT(*) FROM dbo.TbParam001Marca 
		WHERE @Descripcion = TbParam001Descripcion;
	-- AHORA SI EXISTE ES 0 ENTONCES NO HAY REGISTROS COINCIDENTES
	IF @ID IS NULL
	---
	BEGIN
		---
		IF @EXISTE = 0
		BEGIN
			INSERT INTO dbo.TbParam001Marca(TbParam001Descripcion
										  , TbParam001Status
										  , TbParam001Fecha
										  , TbParam001_Sist001Usr)
			VALUES (@Descripcion, 0, GetDate(), @Usr);
			
			
			SET @RESP = Cast(Scope_Identity() as nvarchar(10)) + N'| Marca guardada con éxito!';
		END
		---
		ELSE
		BEGIN
			---
			SET @RESP = N'| La marca ya ha sigo cargada"!';
		END
	END 
		---;
	ELSE 
	---
	BEGIN 
		---
		UPDATE TbParam001Marca
			   SET TbParam001Descripcion = @Descripcion
				 , TbParam001Status = 0
				 , TbParam001Fecha = GetDate()
				 , TbParam001_Sist001Usr = @Usr
		WHERE TbParam001Codigo = @ID;
		SET @RESP = Cast(@ID as nvarchar(10)) + N'| Marca cambiada con éxito!';
		---
	END;
END;

GO
/****** Object:  StoredProcedure [dbo].[SpMarca002GuardarModelo]    Script Date: 06/01/2022 17:50:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE   PROCEDURE [dbo].[SpMarca002GuardarModelo] 
		@Modelo				as nvarchar(3)
		,@codMarca				int 
		,@Status				as int
		,@usr					as int
		,@ID					as int  = NULL 
		,@RESP					AS NVARCHAR(500) OUTPUT  

	AS
	BEGIN
		-- FIJAMOS LA TRANSACCIÓN COMO SERIALIZABLE, PARA EVITAR PROBLEMAS CON LA CONCURRENCIA	
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	
		DECLARE @EXISTE TINYINT;
		SELECT @EXISTE = COUNT(*) FROM dbo.TbParam002Modelo 
			WHERE @Modelo = TbParam002Modelo and @codMarca = TbParam002_Param001Codigo;
		-- AHORA SI EXISTE ES 0 ENTONCES NO HAY REGISTROS COINCIDENTES
	IF @ID IS NULL
		---
		BEGIN
			---
		IF @EXISTE = 0
			BEGIN
				INSERT INTO dbo.TbParam002Modelo(TbParam002Modelo
											  , TbParam002_Param001Codigo
											  , TbParam002Status
											  , TbParam002Fecha
											  , TbParam02_Sist001Usr)
				VALUES (@Modelo, @codMarca,0, GetDate(), @Usr);
			
			
				SET @RESP = Cast(Scope_Identity() as nvarchar(10)) + N'| Modelo guardado con éxito!';
		END
			---	
	ELSE
		BEGIN
				---
			SET @RESP = N'| Modelo existente"!';
		END
	END 
			---;
	ELSE 
		----------------------------------------------------------------------------------------
		BEGIN 
			---
		-- FIJAMOS LA TRANSACCIÓN COMO SERIALIZABLE, PARA EVITAR PROBLEMAS CON LA CONCURRENCIA	
		SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
	
		DECLARE @EXISTEUP TINYINT;
		SELECT @EXISTEUP = COUNT(*) FROM dbo.TbParam002Modelo 
			WHERE @Modelo = TbParam002Modelo and @codMarca = TbParam002_Param001Codigo;
		-- AHORA SI EXISTE ES 0 ENTONCES NO HAY REGISTROS COINCIDENTES
	IF @ID IS NOT NULL
		---
		BEGIN
			---
		IF @EXISTEUP = 0
			BEGIN
			UPDATE TbParam002Modelo
				   SET TbParam002Modelo = @Modelo
					 , TbParam002_Param001Codigo = @codMarca
					 , TbParam002Status=0
					 , TbParam002Fecha = GetDate()
					 , TbParam02_Sist001Usr = @Usr
			WHERE TbParam002Codigo = @ID AND @codMarca = TbParam002_Param001Codigo;

			SET @RESP = Cast(@ID as nvarchar(10)) + N'| Modelo cambiado con éxito!';
		END
	END
			---	
	ELSE
				
				SET @RESP = N'| Modelo existente"!';
	END
	END
	
GO
USE [master]
GO
ALTER DATABASE [ProjParameterizacion] SET  READ_WRITE 
GO
