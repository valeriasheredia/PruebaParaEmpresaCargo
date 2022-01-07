Imports Microsoft.Diagnostics.Runtime

Module Respuesta


    Public Sub Msg(label As Label, ByVal operacao As Integer, ByVal texto As String) ' , TamanhoFonte As Integer?)


        Dim Mfont As New Font("Sans Serif", 10, FontStyle.Regular)
        label.Font = Mfont

        label.BackColor = Color.Transparent
        label.Text = texto.ToUpper
        '  label.TextAlign = ContentAlignment.MiddleLeft



        If (operacao = 0) Then
            label.ForeColor = Color.Red
        End If
        If (operacao = 1) Then
            label.ForeColor = Color.Green
        End If
        If (operacao = 2) Then
            label.ForeColor = Color.Orange
        End If

    End Sub


End Module
