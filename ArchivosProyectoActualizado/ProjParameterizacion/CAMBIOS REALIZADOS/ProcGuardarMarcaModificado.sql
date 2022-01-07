CREATE OR ALTER PROCEDURE dbo.SpMarca001Guardar 
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
			SET @RESP = N'| Marca existente"!';
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