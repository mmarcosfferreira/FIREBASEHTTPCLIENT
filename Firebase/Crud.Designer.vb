<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Crud
	Inherits System.Windows.Forms.Form

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
	 Me.DgvDados = New System.Windows.Forms.DataGridView()
	 Me.BtnAdicionar = New System.Windows.Forms.Button()
	 Me.BtnDeletar = New System.Windows.Forms.Button()
	 Me.BtnEditar = New System.Windows.Forms.Button()
	 Me.TxtEmail = New System.Windows.Forms.TextBox()
	 Me.BtnCarregar = New System.Windows.Forms.Button()
	 Me.Label1 = New System.Windows.Forms.Label()
	 Me.Txtcpf = New System.Windows.Forms.TextBox()
	 Me.TxtUsuario = New System.Windows.Forms.Label()
	 Me.Txtid = New System.Windows.Forms.TextBox()
	 Me.Label2 = New System.Windows.Forms.Label()
	 Me.Label3 = New System.Windows.Forms.Label()
	 Me.Txtname = New System.Windows.Forms.TextBox()
	 Me.Label4 = New System.Windows.Forms.Label()
	 Me.MskRegistrationdate = New System.Windows.Forms.MaskedTextBox()
	 CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
	 Me.SuspendLayout()
	 '
	 'DgvDados
	 '
	 Me.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
	 Me.DgvDados.Location = New System.Drawing.Point(14, 365)
	 Me.DgvDados.Name = "DgvDados"
	 Me.DgvDados.RowTemplate.Height = 25
	 Me.DgvDados.Size = New System.Drawing.Size(378, 118)
	 Me.DgvDados.TabIndex = 14
	 '
	 'BtnAdicionar
	 '
	 Me.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System
	 Me.BtnAdicionar.Location = New System.Drawing.Point(19, 327)
	 Me.BtnAdicionar.Name = "BtnAdicionar"
	 Me.BtnAdicionar.Size = New System.Drawing.Size(83, 32)
	 Me.BtnAdicionar.TabIndex = 10
	 Me.BtnAdicionar.Text = "Record"
	 Me.BtnAdicionar.UseVisualStyleBackColor = True
	 '
	 'BtnDeletar
	 '
	 Me.BtnDeletar.Location = New System.Drawing.Point(206, 327)
	 Me.BtnDeletar.Name = "BtnDeletar"
	 Me.BtnDeletar.Size = New System.Drawing.Size(83, 32)
	 Me.BtnDeletar.TabIndex = 12
	 Me.BtnDeletar.Text = "Delete"
	 Me.BtnDeletar.UseVisualStyleBackColor = True
	 '
	 'BtnEditar
	 '
	 Me.BtnEditar.Location = New System.Drawing.Point(115, 327)
	 Me.BtnEditar.Name = "BtnEditar"
	 Me.BtnEditar.Size = New System.Drawing.Size(83, 32)
	 Me.BtnEditar.TabIndex = 11
	 Me.BtnEditar.Text = "Edit"
	 Me.BtnEditar.UseVisualStyleBackColor = True
	 '
	 'TxtEmail
	 '
	 Me.TxtEmail.Location = New System.Drawing.Point(14, 194)
	 Me.TxtEmail.Name = "TxtEmail"
	 Me.TxtEmail.Size = New System.Drawing.Size(202, 23)
	 Me.TxtEmail.TabIndex = 7
	 Me.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
	 '
	 'BtnCarregar
	 '
	 Me.BtnCarregar.Location = New System.Drawing.Point(298, 327)
	 Me.BtnCarregar.Name = "BtnCarregar"
	 Me.BtnCarregar.Size = New System.Drawing.Size(83, 32)
	 Me.BtnCarregar.TabIndex = 13
	 Me.BtnCarregar.Text = "Load"
	 Me.BtnCarregar.UseVisualStyleBackColor = True
	 '
	 'Label1
	 '
	 Me.Label1.AutoSize = True
	 Me.Label1.Location = New System.Drawing.Point(14, 172)
	 Me.Label1.Name = "Label1"
	 Me.Label1.Size = New System.Drawing.Size(36, 15)
	 Me.Label1.TabIndex = 6
	 Me.Label1.Text = "Email"
	 '
	 'Txtcpf
	 '
	 Me.Txtcpf.Location = New System.Drawing.Point(14, 89)
	 Me.Txtcpf.Name = "Txtcpf"
	 Me.Txtcpf.Size = New System.Drawing.Size(202, 23)
	 Me.Txtcpf.TabIndex = 3
	 Me.Txtcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
	 '
	 'TxtUsuario
	 '
	 Me.TxtUsuario.AutoSize = True
	 Me.TxtUsuario.Location = New System.Drawing.Point(14, 68)
	 Me.TxtUsuario.Name = "TxtUsuario"
	 Me.TxtUsuario.Size = New System.Drawing.Size(26, 15)
	 Me.TxtUsuario.TabIndex = 2
	 Me.TxtUsuario.Text = "Cpf"
	 '
	 'Txtid
	 '
	 Me.Txtid.Location = New System.Drawing.Point(14, 42)
	 Me.Txtid.Name = "Txtid"
	 Me.Txtid.Size = New System.Drawing.Size(202, 23)
	 Me.Txtid.TabIndex = 1
	 Me.Txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
	 '
	 'Label2
	 '
	 Me.Label2.AutoSize = True
	 Me.Label2.Location = New System.Drawing.Point(14, 22)
	 Me.Label2.Name = "Label2"
	 Me.Label2.Size = New System.Drawing.Size(17, 15)
	 Me.Label2.TabIndex = 0
	 Me.Label2.Text = "Id"
	 '
	 'Label3
	 '
	 Me.Label3.AutoSize = True
	 Me.Label3.Location = New System.Drawing.Point(14, 236)
	 Me.Label3.Name = "Label3"
	 Me.Label3.Size = New System.Drawing.Size(96, 15)
	 Me.Label3.TabIndex = 8
	 Me.Label3.Text = "Registration date"
	 '
	 'Txtname
	 '
	 Me.Txtname.Location = New System.Drawing.Point(14, 138)
	 Me.Txtname.Name = "Txtname"
	 Me.Txtname.Size = New System.Drawing.Size(202, 23)
	 Me.Txtname.TabIndex = 5
	 Me.Txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
	 '
	 'Label4
	 '
	 Me.Label4.AutoSize = True
	 Me.Label4.Location = New System.Drawing.Point(14, 116)
	 Me.Label4.Name = "Label4"
	 Me.Label4.Size = New System.Drawing.Size(39, 15)
	 Me.Label4.TabIndex = 4
	 Me.Label4.Text = "Name"
	 '
	 'MskRegistrationdate
	 '
	 Me.MskRegistrationdate.BeepOnError = True
	 Me.MskRegistrationdate.Location = New System.Drawing.Point(14, 254)
	 Me.MskRegistrationdate.Mask = "00/00/0000 90:00"
	 Me.MskRegistrationdate.Name = "MskRegistrationdate"
	 Me.MskRegistrationdate.Size = New System.Drawing.Size(202, 23)
	 Me.MskRegistrationdate.TabIndex = 9
	 Me.MskRegistrationdate.ValidatingType = GetType(Date)
	 '
	 'Crud
	 '
	 Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
	 Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	 Me.ClientSize = New System.Drawing.Size(414, 495)
	 Me.Controls.Add(Me.MskRegistrationdate)
	 Me.Controls.Add(Me.Label4)
	 Me.Controls.Add(Me.Label3)
	 Me.Controls.Add(Me.Txtname)
	 Me.Controls.Add(Me.Label2)
	 Me.Controls.Add(Me.TxtUsuario)
	 Me.Controls.Add(Me.Label1)
	 Me.Controls.Add(Me.Txtid)
	 Me.Controls.Add(Me.Txtcpf)
	 Me.Controls.Add(Me.TxtEmail)
	 Me.Controls.Add(Me.BtnEditar)
	 Me.Controls.Add(Me.BtnCarregar)
	 Me.Controls.Add(Me.BtnDeletar)
	 Me.Controls.Add(Me.BtnAdicionar)
	 Me.Controls.Add(Me.DgvDados)
	 Me.Name = "Crud"
	 Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
	 Me.Text = "Crud "
	 CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).EndInit()
	 Me.ResumeLayout(False)
	 Me.PerformLayout()

   End Sub

   Friend WithEvents DgvDados As DataGridView
	Friend WithEvents BtnAdicionar As Button
	Friend WithEvents BtnDeletar As Button
	Friend WithEvents BtnEditar As Button
	Friend WithEvents TxtEmail As TextBox
	Friend WithEvents BtnCarregar As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Txtcpf As TextBox
	Friend WithEvents TxtUsuario As Label
	Friend WithEvents Txtid As TextBox
	Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents Txtname As TextBox
   Friend WithEvents Label4 As Label
   Friend WithEvents MskRegistrationdate As MaskedTextBox
End Class
