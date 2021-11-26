Public Class SudokuBoard
    Public cells(8, 8) As Cell
    Public Sub New()
        For i As Integer = 0 To 8
            For i2 As Integer = 0 To 8
                cells(i, i2) = New Cell()
            Next
        Next
    End Sub
End Class
