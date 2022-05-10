
Imports Newtonsoft.Json
Imports System.Text
Imports System.Net.Http
Imports System.Net

'
Public Class Crud


   '# criar o projeto no firebase usando o conceito de banco de dados não relacional formato árvore
   '# interação c o dataBase (REST API)
   '# importe as bibliotecas request e json para comunicação,
   '# linq do seu banco de dados
   Dim Uri As String = "https://user-7ecc9-default-rtdb.firebaseio.com"

   '# edita uma Entidade (PATCH)

   'pegar uma Entidade ou todas as vendas(GET)

   'deletar uma Entidade (DELETE)

   '# cria um nova entidade (POST)


   Public Async Function Added() As Task(Of Boolean)

	 Dim U As New user(Txtid.Text, Txtcpf.Text, TxtEmail.Text, MskRegistrationdate.Text, Txtname.Text)


	 Dim retornou As Boolean = False

	 'payload -sobrecarga - dicionario
	 Dim Dic As New Dictionary(Of String, String) From {
	    {"id", U.Id},
	    {"cpf", U.Cpf},
	    {"email", U.Email},
	    {"registrationDate", U.RegistrationDate},
	    {"name", U.Name}
	    }

	 Try
	    Using cliente As New HttpClient()
		  Dim dados = New Http.StringContent(JsonConvert.SerializeObject(Dic), Encoding.UTF8)

		  With cliente
			.DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

			Dim Response As HttpResponseMessage = Await cliente.PostAsync("https://user-7ecc9-default-rtdb.firebaseio.com/Credenciais/Html/.json", dados)

			If (Response.IsSuccessStatusCode) Then
			   'Dim P As Uri = Response.Headers.Location

			   Dim M = String.Format("Adicionado com sucesso " & $"{{0}}", Response.Content.ReadAsStringAsync.Result)
			   MsgBox(M.ToString)

			   retornou = True
			End If

		  End With

	    End Using

	 Catch ex As Exception
	    MsgBox(ex.Message.ToString())
	 End Try

	 Return retornou

   End Function




   Public Async Function Edited(ByVal id As String) As Task(Of Boolean) 'editado

	 Dim U As New user(Txtid.Text, Txtcpf.Text, TxtEmail.Text, MskRegistrationdate.Text, Txtname.Text)

	 Dim Editou As Boolean = False

	 Dim dic As New Dictionary(Of String, String) From {
	    {"cpf", U.Cpf},
	    {"email", U.Email},
	    {"registrationDate", U.RegistrationDate},
	    {"name", U.Name}
	    }

	 Using cliente As New HttpClient
	    Dim dados = New Http.StringContent(JsonConvert.SerializeObject(dic), Encoding.UTF8)
	    With cliente
		  .DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

		  Dim Response As HttpResponseMessage = Await cliente.PatchAsync(Uri + "/" + "Credenciais/Html" + "/.json", dados)

		  If (Response.IsSuccessStatusCode) Then
			Dim P As Uri = Response.Headers.Location

			MsgBox("Editado com sucesso " + Response.StatusCode)
			Editou = True
		  End If

	    End With
	 End Using
	 Return Editou

   End Function

   Public Function deleted() 'deletado

   End Function

   Friend dt As DataTable

   Public Async Function loaded() As Task(Of Boolean)  'carregado
	 Dim B As Boolean = False
	 Using cliente As New HttpClient
	    With cliente
		  .DefaultRequestHeaders.Accept.Clear()
		  .DefaultRequestHeaders.Accept.Add(New Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"))

		  Dim Response As HttpResponseMessage = Await cliente.GetAsync(Uri + "/.json")

		  If (Response.IsSuccessStatusCode) Then
			Dim P As Uri = Response.Headers.Location
			Dim m As String = Response.Content.ReadAsStringAsync.Result.ToString()
			DgvDados.DataSource = JsonConvert.DeserializeObject(Of user())(m).ToList()
			B = True
		  End If

	    End With

	    Return B

	 End Using

   End Function

   Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
	 Call Added()
   End Sub

   Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
	 Call Edited(Txtid.Text)
   End Sub

   Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
	 Dim tabela As New DataTable
	 loaded()

	 tabela = dt
	 DgvDados.DataSource = tabela
   End Sub

   Private Sub Crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	 MskRegistrationdate.Text = Now

   End Sub


   Private Sub MskRegistrationdate_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MskRegistrationdate.MaskInputRejected

   End Sub
End Class