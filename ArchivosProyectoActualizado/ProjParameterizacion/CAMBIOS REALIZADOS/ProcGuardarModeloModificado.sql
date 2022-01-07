	CREATE OR ALTER PROCEDURE dbo.SpMarca002GuardarModelo 
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
	