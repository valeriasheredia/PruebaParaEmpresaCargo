USE [Parametrizacion]
GO
/****** Object:  Table [dbo].[TbParam001Marca]    Script Date: 25/10/2021 00:57:51 ******/
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
/****** Object:  Table [dbo].[TbParam002Modelo]    Script Date: 25/10/2021 00:57:51 ******/
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

GO
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) VALUES (1, N'VOLKSWAGEM', 1, CAST(N'2021-10-24T23:55:50.463' AS DateTime), 1)
GO
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) VALUES (2, N'RENAULT', 1, CAST(N'2021-10-24T23:51:48.123' AS DateTime), 1)
GO
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) VALUES (3, N'VOLKSWAGEM', 1, CAST(N'2021-10-24T23:53:40.740' AS DateTime), 1)
GO
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) VALUES (4, N'FERRARI', 0, CAST(N'2021-10-24T23:58:04.827' AS DateTime), 1)
GO
INSERT [dbo].[TbParam001Marca] ([TbParam001Codigo], [TbParam001Descripcion], [TbParam001Status], [TbParam001Fecha], [TbParam001_Sist001Usr]) VALUES (5, N'BUGATTI', 0, CAST(N'2021-10-24T23:58:02.887' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[TbParam001Marca] OFF
GO
SET IDENTITY_INSERT [dbo].[TbParam002Modelo] ON 

GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (1, N'1.0', 1, 1, CAST(N'2021-10-24T23:46:12.063' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (2, N'1.5', 1, 1, CAST(N'2021-10-24T23:45:44.147' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (3, N'2.0', 1, 1, CAST(N'2021-10-24T23:45:48.170' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (4, N'1.0', 2, 1, CAST(N'2021-10-24T23:51:04.633' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (5, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:14.977' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (6, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:16.587' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (7, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:16.807' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (8, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:16.993' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (9, N'2.0', 2, 0, CAST(N'2021-10-24T23:51:17.197' AS DateTime), 1)
GO
INSERT [dbo].[TbParam002Modelo] ([TbParam002Codigo], [TbParam002Modelo], [TbParam002_Param001Codigo], [TbParam002Status], [TbParam002Fecha], [TbParam02_Sist001Usr]) VALUES (10, N'2.5', 1, 0, CAST(N'2021-10-24T23:55:29.000' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[TbParam002Modelo] OFF
GO
ALTER TABLE [dbo].[TbParam002Modelo]  WITH CHECK ADD  CONSTRAINT [FK_TbParam002Modelo_TbParam001Marca] FOREIGN KEY([TbParam002_Param001Codigo])
REFERENCES [dbo].[TbParam001Marca] ([TbParam001Codigo])
GO
ALTER TABLE [dbo].[TbParam002Modelo] CHECK CONSTRAINT [FK_TbParam002Modelo_TbParam001Marca]
GO
/****** Object:  StoredProcedure [dbo].[SpMarca001CarregaMarca]    Script Date: 25/10/2021 00:57:51 ******/
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
/****** Object:  StoredProcedure [dbo].[SpMarca001CarregaModelo]    Script Date: 25/10/2021 00:57:51 ******/
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
/****** Object:  StoredProcedure [dbo].[SpMarca001Guardar]    Script Date: 25/10/2021 00:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE   PROCEDURE [dbo].[SpMarca001Guardar]  

		 @Descripcion			as nvarchar(10)
        ,@Status				as BIT
        ,@Usr					as int
		,@ID					as int  = NULL 
		,@RESP					AS NVARCHAR(500)  OUTPUT  

	AS
	 
		IF @ID   IS NULL
		---
		BEGIN
		---

			INSERT INTO [dbo].[TbParam001Marca]
           ([TbParam001Descripcion]
           ,[TbParam001Status]
           ,[TbParam001Fecha]
           ,[TbParam001_Sist001Usr])
			VALUES
           (@Descripcion
           ,0
           ,GETDATE()
           ,@Usr)
				
				SET @RESP   =  cast( SCOPE_IDENTITY()  as nvarchar(10) ) +  '| Marca guardada con éxito!'

		   ---
		   END 
		   ---
		   ELSE 
		   ---
		   BEGIN 
		   ---

				UPDATE [TbParam001Marca]  SET 
						 [TbParam001Descripcion]			= @Descripcion
						,[TbParam001Status]					= 0
						,[TbParam001Fecha]					= GETDATE() 
						,[TbParam001_Sist001Usr]			= @Usr   
				WHERE [TbParam001Codigo]			=  @ID 

				SET @RESP   =  cast( @ID  as nvarchar(10) ) +  '| Marca cambiada con éxito!'

			---
			END  
			---




GO
/****** Object:  StoredProcedure [dbo].[SpMarca002GuardarModelo]    Script Date: 25/10/2021 00:57:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROCEDURE [dbo].[SpMarca002GuardarModelo]

	 @Modelo				as nvarchar(3)
	,@codMarca				int 
	,@Status				as int
	,@usr					as int
	,@ID					as int  = NULL 
	,@RESP					AS NVARCHAR(500) OUTPUT  

AS

	IF @ID  IS NULL 
	---
	BEGIN  
	---

		INSERT INTO [dbo].[TbParam002Modelo]
           ([TbParam002Modelo]
           ,[TbParam002_Param001Codigo]
           ,[TbParam002Status]
           ,[TbParam002Fecha]
           ,[TbParam02_Sist001Usr])
        VALUES
           (@Modelo
           ,@codMarca
           ,@Status
           ,GETDATE()
           ,@usr)
		SET @RESP   =  cast( SCOPE_IDENTITY()  as nvarchar(10) ) +  '| Modelo guardado con éxito!'
	---
	END ELSE BEGIN  
	---
		UPDATE [TbParam002Modelo]  SET   

			 [TbParam002Modelo]				= @Modelo
			,[TbParam002_Param001Codigo]	= @codMarca
			,[TbParam002Status]				= @Status
			,[TbParam002Fecha]				= GETDATE() 
			,[TbParam02_Sist001Usr]			= @usr

		WHERE [TbParam002Codigo]			=  @ID 
		
		SET @RESP   =  cast( @ID  as nvarchar(10) ) +  '| Modelo cambiado con éxito!'

	---
	END 
	---

		 

GO
