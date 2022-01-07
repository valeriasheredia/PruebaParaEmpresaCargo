<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCatrastroMarcasVersionesVeiculos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxMarca = New System.Windows.Forms.GroupBox()
        Me.LabelCodMarca = New System.Windows.Forms.Label()
        Me.LabelDescricao = New System.Windows.Forms.Label()
        Me.ButtonLimpiarMarca = New System.Windows.Forms.Button()
        Me.TextBoxMarca = New System.Windows.Forms.TextBox()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.CheckBoxActivoMarca = New System.Windows.Forms.CheckBox()
        Me.TextBoxModeloMarca = New System.Windows.Forms.TextBox()
        Me.LabelMensagem = New System.Windows.Forms.Label()
        Me.GroupBoxModelo = New System.Windows.Forms.GroupBox()
        Me.DataGridViewModelo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonLimpiarModelo = New System.Windows.Forms.Button()
        Me.CheckBoxActivoModelo = New System.Windows.Forms.CheckBox()
        Me.ButtonGuardarModelo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelCodModeloMarca = New System.Windows.Forms.Label()
        Me.DataGridViewMarca = New System.Windows.Forms.DataGridView()
        Me.Check = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.GroupBoxMarca.SuspendLayout()
        Me.GroupBoxModelo.SuspendLayout()
        CType(Me.DataGridViewModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxMarca
        '
        Me.GroupBoxMarca.Controls.Add(Me.LabelCodMarca)
        Me.GroupBoxMarca.Controls.Add(Me.LabelDescricao)
        Me.GroupBoxMarca.Controls.Add(Me.ButtonLimpiarMarca)
        Me.GroupBoxMarca.Controls.Add(Me.TextBoxMarca)
        Me.GroupBoxMarca.Controls.Add(Me.ButtonGuardar)
        Me.GroupBoxMarca.Controls.Add(Me.CheckBoxActivoMarca)
        Me.GroupBoxMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxMarca.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxMarca.Location = New System.Drawing.Point(0, 42)
        Me.GroupBoxMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBoxMarca.Name = "GroupBoxMarca"
        Me.GroupBoxMarca.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBoxMarca.Size = New System.Drawing.Size(808, 223)
        Me.GroupBoxMarca.TabIndex = 31
        Me.GroupBoxMarca.TabStop = False
        Me.GroupBoxMarca.Text = "Catastro Marca"
        '
        'LabelCodMarca
        '
        Me.LabelCodMarca.AutoSize = True
        Me.LabelCodMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelCodMarca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelCodMarca.Location = New System.Drawing.Point(466, 0)
        Me.LabelCodMarca.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelCodMarca.Name = "LabelCodMarca"
        Me.LabelCodMarca.Size = New System.Drawing.Size(27, 32)
        Me.LabelCodMarca.TabIndex = 241
        Me.LabelCodMarca.Text = "0"
        Me.LabelCodMarca.Visible = False
        '
        'LabelDescricao
        '
        Me.LabelDescricao.AutoSize = True
        Me.LabelDescricao.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelDescricao.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelDescricao.Location = New System.Drawing.Point(52, 62)
        Me.LabelDescricao.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelDescricao.Name = "LabelDescricao"
        Me.LabelDescricao.Size = New System.Drawing.Size(84, 32)
        Me.LabelDescricao.TabIndex = 6
        Me.LabelDescricao.Text = "Marca:"
        '
        'ButtonLimpiarMarca
        '
        Me.ButtonLimpiarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarMarca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonLimpiarMarca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ButtonLimpiarMarca.Location = New System.Drawing.Point(563, 100)
        Me.ButtonLimpiarMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonLimpiarMarca.Name = "ButtonLimpiarMarca"
        Me.ButtonLimpiarMarca.Size = New System.Drawing.Size(147, 67)
        Me.ButtonLimpiarMarca.TabIndex = 14
        Me.ButtonLimpiarMarca.Text = "Limpiar"
        Me.ButtonLimpiarMarca.UseVisualStyleBackColor = True
        '
        'TextBoxMarca
        '
        Me.TextBoxMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxMarca.Location = New System.Drawing.Point(52, 98)
        Me.TextBoxMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TextBoxMarca.MaxLength = 10
        Me.TextBoxMarca.Name = "TextBoxMarca"
        Me.TextBoxMarca.Size = New System.Drawing.Size(297, 53)
        Me.TextBoxMarca.TabIndex = 239
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonGuardar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ButtonGuardar.Location = New System.Drawing.Point(393, 100)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(147, 67)
        Me.ButtonGuardar.TabIndex = 13
        Me.ButtonGuardar.Text = "Guardar"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'CheckBoxActivoMarca
        '
        Me.CheckBoxActivoMarca.AutoSize = True
        Me.CheckBoxActivoMarca.Checked = True
        Me.CheckBoxActivoMarca.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxActivoMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxActivoMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxActivoMarca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CheckBoxActivoMarca.Location = New System.Drawing.Point(52, 163)
        Me.CheckBoxActivoMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CheckBoxActivoMarca.Name = "CheckBoxActivoMarca"
        Me.CheckBoxActivoMarca.Size = New System.Drawing.Size(101, 36)
        Me.CheckBoxActivoMarca.TabIndex = 23
        Me.CheckBoxActivoMarca.Text = "Activo"
        Me.CheckBoxActivoMarca.UseVisualStyleBackColor = True
        '
        'TextBoxModeloMarca
        '
        Me.TextBoxModeloMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxModeloMarca.Location = New System.Drawing.Point(65, 70)
        Me.TextBoxModeloMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.TextBoxModeloMarca.MaxLength = 3
        Me.TextBoxModeloMarca.Name = "TextBoxModeloMarca"
        Me.TextBoxModeloMarca.Size = New System.Drawing.Size(297, 53)
        Me.TextBoxModeloMarca.TabIndex = 240
        '
        'LabelMensagem
        '
        Me.LabelMensagem.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LabelMensagem.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelMensagem.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelMensagem.ForeColor = System.Drawing.Color.Red
        Me.LabelMensagem.Location = New System.Drawing.Point(0, 0)
        Me.LabelMensagem.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelMensagem.Name = "LabelMensagem"
        Me.LabelMensagem.Size = New System.Drawing.Size(1946, 42)
        Me.LabelMensagem.TabIndex = 7
        Me.LabelMensagem.Text = "LabelMensaje"
        Me.LabelMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxModelo
        '
        Me.GroupBoxModelo.Controls.Add(Me.DataGridViewModelo)
        Me.GroupBoxModelo.Controls.Add(Me.Panel1)
        Me.GroupBoxModelo.Controls.Add(Me.LabelCodModeloMarca)
        Me.GroupBoxModelo.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBoxModelo.ForeColor = System.Drawing.Color.Black
        Me.GroupBoxModelo.Location = New System.Drawing.Point(808, 42)
        Me.GroupBoxModelo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBoxModelo.Name = "GroupBoxModelo"
        Me.GroupBoxModelo.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBoxModelo.Size = New System.Drawing.Size(1138, 1000)
        Me.GroupBoxModelo.TabIndex = 32
        Me.GroupBoxModelo.TabStop = False
        Me.GroupBoxModelo.Text = "Modelo - Marca"
        '
        'DataGridViewModelo
        '
        Me.DataGridViewModelo.AllowUserToAddRows = False
        Me.DataGridViewModelo.AllowUserToDeleteRows = False
        Me.DataGridViewModelo.AllowUserToResizeColumns = False
        Me.DataGridViewModelo.AllowUserToResizeRows = False
        Me.DataGridViewModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewModelo.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewModelo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridViewModelo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridViewModelo.ColumnHeadersHeight = 25
        Me.DataGridViewModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewModelo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewModelo.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewModelo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewModelo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewModelo.EnableHeadersVisualStyles = False
        Me.DataGridViewModelo.Location = New System.Drawing.Point(5, 222)
        Me.DataGridViewModelo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridViewModelo.MultiSelect = False
        Me.DataGridViewModelo.Name = "DataGridViewModelo"
        Me.DataGridViewModelo.ReadOnly = True
        Me.DataGridViewModelo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridViewModelo.RowHeadersVisible = False
        Me.DataGridViewModelo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridViewModelo.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewModelo.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridViewModelo.RowTemplate.Height = 26
        Me.DataGridViewModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewModelo.ShowCellErrors = False
        Me.DataGridViewModelo.ShowCellToolTips = False
        Me.DataGridViewModelo.ShowEditingIcon = False
        Me.DataGridViewModelo.ShowRowErrors = False
        Me.DataGridViewModelo.Size = New System.Drawing.Size(1128, 772)
        Me.DataGridViewModelo.TabIndex = 243
        Me.DataGridViewModelo.TabStop = False
        '
        'DataGridViewCheckBoxColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Editar"
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewCheckBoxColumn1.Frozen = True
        Me.DataGridViewCheckBoxColumn1.HeaderText = "   "
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 30
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.Width = 33
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ButtonLimpiarModelo)
        Me.Panel1.Controls.Add(Me.TextBoxModeloMarca)
        Me.Panel1.Controls.Add(Me.CheckBoxActivoModelo)
        Me.Panel1.Controls.Add(Me.ButtonGuardarModelo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(5, 30)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1128, 192)
        Me.Panel1.TabIndex = 244
        '
        'ButtonLimpiarModelo
        '
        Me.ButtonLimpiarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLimpiarModelo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonLimpiarModelo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ButtonLimpiarModelo.Location = New System.Drawing.Point(553, 70)
        Me.ButtonLimpiarModelo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonLimpiarModelo.Name = "ButtonLimpiarModelo"
        Me.ButtonLimpiarModelo.Size = New System.Drawing.Size(133, 67)
        Me.ButtonLimpiarModelo.TabIndex = 14
        Me.ButtonLimpiarModelo.Text = "Limpiar"
        Me.ButtonLimpiarModelo.UseVisualStyleBackColor = True
        '
        'CheckBoxActivoModelo
        '
        Me.CheckBoxActivoModelo.AutoSize = True
        Me.CheckBoxActivoModelo.Checked = True
        Me.CheckBoxActivoModelo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxActivoModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxActivoModelo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBoxActivoModelo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.CheckBoxActivoModelo.Location = New System.Drawing.Point(65, 133)
        Me.CheckBoxActivoModelo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CheckBoxActivoModelo.Name = "CheckBoxActivoModelo"
        Me.CheckBoxActivoModelo.Size = New System.Drawing.Size(101, 36)
        Me.CheckBoxActivoModelo.TabIndex = 23
        Me.CheckBoxActivoModelo.Text = "Activo"
        Me.CheckBoxActivoModelo.UseVisualStyleBackColor = True
        '
        'ButtonGuardarModelo
        '
        Me.ButtonGuardarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonGuardarModelo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonGuardarModelo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ButtonGuardarModelo.Location = New System.Drawing.Point(395, 68)
        Me.ButtonGuardarModelo.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonGuardarModelo.Name = "ButtonGuardarModelo"
        Me.ButtonGuardarModelo.Size = New System.Drawing.Size(133, 67)
        Me.ButtonGuardarModelo.TabIndex = 13
        Me.ButtonGuardarModelo.Text = "Guardar"
        Me.ButtonGuardarModelo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(65, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Modelo:"
        '
        'LabelCodModeloMarca
        '
        Me.LabelCodModeloMarca.AutoSize = True
        Me.LabelCodModeloMarca.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelCodModeloMarca.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelCodModeloMarca.Location = New System.Drawing.Point(534, 0)
        Me.LabelCodModeloMarca.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelCodModeloMarca.Name = "LabelCodModeloMarca"
        Me.LabelCodModeloMarca.Size = New System.Drawing.Size(27, 32)
        Me.LabelCodModeloMarca.TabIndex = 242
        Me.LabelCodModeloMarca.Text = "0"
        Me.LabelCodModeloMarca.Visible = False
        '
        'DataGridViewMarca
        '
        Me.DataGridViewMarca.AllowUserToAddRows = False
        Me.DataGridViewMarca.AllowUserToDeleteRows = False
        Me.DataGridViewMarca.AllowUserToResizeColumns = False
        Me.DataGridViewMarca.AllowUserToResizeRows = False
        Me.DataGridViewMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewMarca.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewMarca.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.DataGridViewMarca.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridViewMarca.ColumnHeadersHeight = 25
        Me.DataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Check})
        Me.DataGridViewMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewMarca.EnableHeadersVisualStyles = False
        Me.DataGridViewMarca.Location = New System.Drawing.Point(0, 265)
        Me.DataGridViewMarca.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DataGridViewMarca.MultiSelect = False
        Me.DataGridViewMarca.Name = "DataGridViewMarca"
        Me.DataGridViewMarca.ReadOnly = True
        Me.DataGridViewMarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridViewMarca.RowHeadersVisible = False
        Me.DataGridViewMarca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridViewMarca.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewMarca.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DataGridViewMarca.RowTemplate.Height = 26
        Me.DataGridViewMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMarca.ShowCellErrors = False
        Me.DataGridViewMarca.ShowCellToolTips = False
        Me.DataGridViewMarca.ShowEditingIcon = False
        Me.DataGridViewMarca.ShowRowErrors = False
        Me.DataGridViewMarca.Size = New System.Drawing.Size(808, 777)
        Me.DataGridViewMarca.TabIndex = 209
        Me.DataGridViewMarca.TabStop = False
        '
        'Check
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "Editar"
        Me.Check.DefaultCellStyle = DataGridViewCellStyle4
        Me.Check.Frozen = True
        Me.Check.HeaderText = "     "
        Me.Check.MinimumWidth = 30
        Me.Check.Name = "Check"
        Me.Check.ReadOnly = True
        Me.Check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Check.Width = 43
        '
        'ButtonFechar
        '
        Me.ButtonFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFechar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonFechar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ButtonFechar.Location = New System.Drawing.Point(1883, 0)
        Me.ButtonFechar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(63, 42)
        Me.ButtonFechar.TabIndex = 241
        Me.ButtonFechar.Text = "X"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'FormCatrastroMarcasVersionesVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1946, 1042)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonFechar)
        Me.Controls.Add(Me.DataGridViewMarca)
        Me.Controls.Add(Me.GroupBoxMarca)
        Me.Controls.Add(Me.GroupBoxModelo)
        Me.Controls.Add(Me.LabelMensagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MinimizeBox = False
        Me.Name = "FormCatrastroMarcasVersionesVeiculos"
        Me.Text = "FormCadastraCarrinhoRecebimento"
        Me.GroupBoxMarca.ResumeLayout(False)
        Me.GroupBoxMarca.PerformLayout()
        Me.GroupBoxModelo.ResumeLayout(False)
        Me.GroupBoxModelo.PerformLayout()
        CType(Me.DataGridViewModelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxMarca As GroupBox
    Friend WithEvents LabelDescricao As Label
    Friend WithEvents ButtonLimpiarMarca As Button
    Friend WithEvents LabelMensagem As Label
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents CheckBoxActivoMarca As CheckBox
    Friend WithEvents GroupBoxModelo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonLimpiarModelo As Button
    Friend WithEvents ButtonGuardarModelo As Button
    Friend WithEvents CheckBoxActivoModelo As CheckBox
    Friend WithEvents TextBoxModeloMarca As TextBox
    Friend WithEvents TextBoxMarca As TextBox
    Friend WithEvents LabelCodMarca As Label
    Friend WithEvents LabelCodModeloMarca As Label
    Public WithEvents DataGridViewMarca As DataGridView
    Public WithEvents DataGridViewModelo As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewButtonColumn
    Friend WithEvents Check As DataGridViewButtonColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonFechar As Button
End Class
