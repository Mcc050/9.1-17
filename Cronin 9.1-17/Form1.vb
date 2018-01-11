Public Class lstBox

    
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim this As Integer = lstboxNumbers.Items.Count - 1
        Dim that(this) As String
        For i As Integer = 0 To this
            that(i) = CStr(lstboxNumbers.Items(i))
        Next
        IO.File.WriteAllLines("Other.txt", that)

        Dim alpha() As String = IO.File.ReadAllLines("Other.txt")

        Dim query = From beta In alpha
        Let data = line.Split(","c)
        Let charlie = data(0)
        Order By charlie
        Select charlie
        For i As Integer = query To 0 Step -1
            lstboxNumbers.Items.Add(alpha(i))
        Next
    End Sub
End Class
