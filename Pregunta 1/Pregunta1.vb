Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)
        If a > b Then GoTo a_c Else GoTo elsea_b
a_c:
        If a > c Then GoTo b_c Else GoTo elsea_c
        TextBox4.Text += TextBox4.Text + "igual me estoy"
b_c:
        If b > c Then GoTo c_b_a Else GoTo elseb_c
        TextBox4.Text += TextBox4.Text + "igual me estoy"
c_b_a:
        TextBox4.Text = c.ToString + " " + b.ToString + " " + a.ToString
        GoTo salir
elseb_c:
        TextBox4.Text = b.ToString + " " + c.ToString + " " + a.ToString
        GoTo salir
elsea_c:
        TextBox4.Text = b.ToString + " " + a.ToString + " " + c.ToString
        GoTo salir
elsea_b:
        If b > c Then GoTo a_c1 Else GoTo elseb_c1
a_c1:
        If a > c Then GoTo c_a_b Else GoTo elsea_c1
c_a_b:
        TextBox4.Text = c.ToString + " " + a.ToString + " " + b.ToString
        GoTo salir
elsea_c1:
        TextBox4.Text = a.ToString + " " + c.ToString + " " + b.ToString
        GoTo salir
elseb_c1:
        TextBox4.Text = a.ToString + " " + b.ToString + " " + c.ToString
        GoTo salir
salir:

    End Sub
End Class
