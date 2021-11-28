Public Class SudokuBoard
    Public cells(8, 8) As Cell
    Public Sub New()
        For i As Integer = 0 To 8
            For i2 As Integer = 0 To 8
                cells(i, i2) = New Cell()
            Next
        Next
    End Sub

    Public Enum Area
        Region
        Row
        Column
    End Enum
    Public Function GetCells(area As Area) As Integer()

        Dim cells(8) As Integer

        For i As Integer = 0 To 8
            'region i
            Dim blnNums(8) As Boolean

            'get cell index
            For i2 As Integer = 0 To 8
                'get column
                Dim iColumn As Integer = i2 Mod 3

                'get row
                Dim iRow As Integer = i2 / 3


                Select Case area
                    Case Area.Region
                        iColumn = i2 Mod 3
                        iRow = i2 / 3

                    Case Area.Row
                    Case Area.Column
                End Select

                If blnNums(iRow * 3 + iColumn) Then
                    Return False
                End If

            Next
        Next

    End Function
End Class
