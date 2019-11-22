Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button3.Click, Button2.Click, Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button12.Click, Button11.Click, Button10.Click, Button31.Click, Button30.Click
        Dim b As Button = sender

        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text

        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label1.Text = "0"
        Label2.Text = " "
    End Sub

    Private Sub arithmetic_function(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click, Button20.Click, Button17.Click, Button15.Click, Button14.Click, Button13.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label2.Text = Label1.Text
        Label1.Text = " "
        op = ops.Text
        Label2.Text = Label2.Text + " " + op
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click

        s = Label1.Text
        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "/" Then
            a = f / s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            Label1.Text = a
            Label2.Text = ""


        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click, Button27.Click
        Label1.Text = "0"
        Label2.Text = "0"
    End Sub

    Private Sub Sin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Cos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Tan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub Log_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
