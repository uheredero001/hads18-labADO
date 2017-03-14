Public Class TareasGenericasProfesor
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If (Session("user") Is Nothing) Or (Session("rol") Is Nothing) Or (Session("rol").Equals("P") = False) Then
                Response.Redirect("Inicio.aspx")
            Else
                Response.Write("holaaaaa")
                DropDownList1 = New DropDownList
                DropDownList1.DataSource = AsignaturasProfe
                GridView1 = New GridView
                GridView1.DataSource = BaseDeDatosHads18
                GridView1.DataBind()

            End If
        Else


        End If
    End Sub

End Class