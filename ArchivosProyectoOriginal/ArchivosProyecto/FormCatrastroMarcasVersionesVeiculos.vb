Imports System.Data.SqlClient

Public Class FormCatrastroMarcasVersionesVeiculos

    Private Sub FormCatrastoMarcaVersionesVeiculos_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.MaximizeBox = False
        Me.ControlBox = False
        Me.WindowState = FormWindowState.Normal

        LabelMensagem.Text = " "
        DataGridViewMarca.ClearSelection()
        DataGridViewModelo.ClearSelection()
        GroupBoxModelo.Visible = False
        GroupBoxMarca.Visible = True
        LabelMensagem.Text = ""
        CarregarMarca()
        LabelCodMarca.Text = 0
        LabelCodModeloMarca.Text = 0
        ClassConexao.CodigoUsuario = 1
    End Sub

    Private Sub ButtonLimpiarMarca_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarMarca.Click
        Limpiar()
        LabelCodModeloMarca.Text = 0
        LabelCodMarca.Text = 0
    End Sub

    Private Sub Limpiar()

        GroupBoxModelo.Visible = False
        GroupBoxMarca.Visible = True

        TextBoxModeloMarca.Text = String.Empty
        CheckBoxActivoMarca.Checked = True
        CheckBoxActivoModelo.Checked = True
        TextBoxMarca.Text = String.Empty
        DataGridViewModelo.DataSource = Nothing
        LabelMensagem.Text = String.Empty

        DataGridViewMarca.ClearSelection()
        DataGridViewModelo.ClearSelection()

    End Sub

    Private Sub ButtonLimpiarModelo_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarModelo.Click
        Limpiar()
        LabelCodModeloMarca.Text = 0
        LabelCodMarca.Text = 0
    End Sub

    Sub CarregarMarca()
        Dim conexao As New SqlConnection(ClassConexao.Descript())
        Dim Comando As New SqlDataAdapter("SpMarca001CarregaMarca", conexao)
        Dim ds As New DataSet

        Comando.SelectCommand.CommandType = CommandType.StoredProcedure
        Try
            conexao.Open()
            Comando.Fill(ds, "Tabela")
            Me.DataGridViewMarca.DataSource = ds
            Me.DataGridViewMarca.DataMember = "Tabela"
        Catch ex As Exception
            Respuesta.Msg(LabelMensagem, 0, "Error")
        Finally
            Comando.Dispose()
            conexao.Close()
        End Try
    End Sub

    Sub CarregarModelo(idmarca As Integer)

        Dim conexao As New SqlConnection(ClassConexao.Descript())
        Dim Comando As New SqlDataAdapter("[SpMarca001CarregaModelo]", conexao)
        Dim ds As New DataSet

        Comando.SelectCommand.CommandType = CommandType.StoredProcedure
        Comando.SelectCommand.Parameters.Add("@IdMarca", SqlDbType.Int).Value = idmarca
        Try
            conexao.Open()
            Comando.Fill(ds, "Tabela")
            Me.DataGridViewModelo.DataSource = ds
            Me.DataGridViewModelo.DataMember = "Tabela"
        Catch ex As Exception
            Respuesta.Msg(LabelMensagem, 0, "Error")
        Finally
            Comando.Dispose()
            conexao.Close()

        End Try

    End Sub

    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        LabelCodModeloMarca.Text = 0

        If TextBoxMarca.Text = "" Then
            Respuesta.Msg(LabelMensagem, 0, "informar a la marca")
            Exit Sub

        End If
        Dim conexao As New SqlConnection(ClassConexao.Descript())

        Dim comando As New SqlCommand("SpMarca001Guardar", conexao)
        Dim parametro As SqlParameter
        parametro = comando.Parameters.Add("@Resp", Data.SqlDbType.NVarChar, 500)
        parametro.Direction = Data.ParameterDirection.Output
        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 19).Value = TextBoxMarca.Text
        If LabelCodMarca.Text > 0 Then
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = LabelCodMarca.Text
        End If
        comando.Parameters.Add("@Usr", SqlDbType.Int).Value = ClassConexao.CodigoUsuario
        comando.Parameters.Add("@Status", SqlDbType.Bit).Value = CheckBoxActivoMarca.Checked

        Try

            comando.CommandType = Data.CommandType.StoredProcedure
            conexao.Open()
            comando.ExecuteNonQuery()

            CarregarMarca()
            CarregarModelo(comando.Parameters("@Resp").Value.ToString.Split("|")(0))
            LabelCodMarca.Text = comando.Parameters("@Resp").Value.ToString.Split("|")(0)

            GroupBoxModelo.Visible = True
            TextBoxMarca.Text = ""
            CheckBoxActivoModelo.Checked = False
            Respuesta.Msg(LabelMensagem, 1, comando.Parameters("@Resp").Value)
        Catch exc As Exception
            Respuesta.Msg(LabelMensagem, 0, "Error")
        Finally
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try
    End Sub
    Private Sub DataGridViewMarca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMarca.CellContentClick

        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            Try
                LabelCodModeloMarca.Text = 0
                CarregarModelo(DataGridViewMarca.Rows(e.RowIndex).Cells("ID").Value)
                TextBoxMarca.Text = DataGridViewMarca.Rows(e.RowIndex).Cells("Marca").Value
                LabelCodMarca.Text = DataGridViewMarca.Rows(e.RowIndex).Cells("ID").Value
                CheckBoxActivoMarca.Checked = DataGridViewMarca.Rows(e.RowIndex).Cells("Status").Value
                GroupBoxModelo.Visible = True
                TextBoxModeloMarca.Text = String.Empty
                CheckBoxActivoModelo.Checked = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DataGridViewModelo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewModelo.CellContentClick
        If e.RowIndex > -1 And e.ColumnIndex = 0 Then
            Try
                LabelCodModeloMarca.Text = 0
                TextBoxModeloMarca.Text = DataGridViewModelo.Rows(e.RowIndex).Cells("Modelo").Value
                LabelCodModeloMarca.Text = DataGridViewModelo.Rows(e.RowIndex).Cells("ID").Value
                CheckBoxActivoModelo.Checked = DataGridViewModelo.Rows(e.RowIndex).Cells("Status").Value
            Catch ex As Exception
                Respuesta.Msg(LabelMensagem, 0, "Error")
            End Try
        End If
    End Sub

    Private Sub ButtonGuardarModelo_Click(sender As Object, e As EventArgs) Handles ButtonGuardarModelo.Click
        If TextBoxModeloMarca.Text = "" Then
            Respuesta.Msg(LabelMensagem, 0, "informar al modelo!")
            Exit Sub
        End If
        If LabelCodMarca.Text = "0" Then
            Respuesta.Msg(LabelMensagem, 0, "seleccionar una marca")
            Exit Sub
        End If
        Dim conexao As New SqlConnection(ClassConexao.Descript())

        Dim comando As New SqlCommand("SpMarca002GuardarModelo", conexao)
        Dim parametro As SqlParameter

        parametro = comando.Parameters.Add("@Resp", Data.SqlDbType.NVarChar, 500)
        parametro.Direction = Data.ParameterDirection.Output

        comando.Parameters.Add("@Modelo", SqlDbType.NVarChar, 3).Value = TextBoxModeloMarca.Text
        If LabelCodModeloMarca.Text > 0 Then
            comando.Parameters.Add("@ID", SqlDbType.Int).Value = LabelCodModeloMarca.Text
        End If
        comando.Parameters.Add("@usr", SqlDbType.Int).Value = ClassConexao.CodigoUsuario
        comando.Parameters.Add("@Status", SqlDbType.Bit).Value = CheckBoxActivoModelo.Checked

        Try

            comando.CommandType = Data.CommandType.StoredProcedure
            conexao.Open()
            comando.ExecuteNonQuery()
            CarregarMarca()
            CarregarModelo(LabelCodMarca.Text)
            GroupBoxModelo.Visible = True
            TextBoxMarca.Text = ""
            CheckBoxActivoModelo.Checked = False
            Respuesta.Msg(LabelMensagem, 1, comando.Parameters("@Resp").Value)
            LabelCodModeloMarca.Text = 0
        Catch exc As Exception
            Respuesta.Msg(LabelMensagem, 0, "Error")
        Finally
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonFechar_Click(sender As Object, e As EventArgs) Handles ButtonFechar.Click
        Me.Close()
    End Sub
End Class