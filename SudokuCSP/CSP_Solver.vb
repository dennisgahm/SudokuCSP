Public Class CSP_Solver
    Dim board As SudokuBoard

    Public Sub New(sudokuBoard As SudokuBoard)
        board = sudokuBoard
    End Sub
    Public Function IsConsistent() As Boolean
        'Check regions consistent
        For i As Integer = 0 To 8
            'region i
            Dim blnNums(8) As Boolean

            'get cell index
            For i2 As Integer = 0 To 8
                'get column
                Dim iColumn As Integer = i2 Mod 3

                'get row
                Dim iRow As Integer = i2 / 3

                If blnNums(iRow * 3 + iColumn) Then
                    Return False
                End If

            Next
        Next
        'Check rows consistent

        'Check columns consistent
        Return True
    End Function
End Class
