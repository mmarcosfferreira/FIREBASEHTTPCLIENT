Public Class user
   Public Property Id() As String
   Public Property Cpf() As String
   Public Property Email() As String
   Public Property RegistrationDate() As String
   Public Property Name() As String


   Sub New()

   End Sub
   Sub New(id As String, cpf As String, email As String, registrationDate As String, name As String)
	 Me.Id = id
	 Me.Cpf = cpf
	 Me.Email = email
	 Me.RegistrationDate = registrationDate
	 Me.Name = name
   End Sub

End Class
