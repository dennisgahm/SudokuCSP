Public Class Form1
    Private sudokuBoard As New SudokuBoard

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim str As String() = {
        "800473000",
        "026851090",
        "005000800",
        "013008400",
        "607302900",
        "050097608",
        "062730500",
        "030200706",
        "400600020"
        }
        Dim num As Integer = str.Length
        For i As Integer = 0 To 8
            For i2 As Integer = 0 To 8
                Label1.Text = Label1.Text & str(i)(i2)
                sudokuBoard.cells(i, i2) = New Cell(Convert.ToInt32(str(i)(i2)))
            Next
            Label1.Text = Label1.Text & vbCrLf
        Next

        'Solve
        'Psuedo-code
        'CSP_Solver create instance
        Dim cspSolver As CSP_Solver = New CSP_Solver(sudokuBoard)

        Dim blnSolved As Boolean = False
        While (blnSolved = False)
            'consistency check
            If cspSolver.IsConsistent() Then

            End If
            'if not consistent, backtrack
            'if consistent, apply another variable to a value
            '  have a heuristic or way of deciding which variable and which value
            '    this decision should be made in CSP_Solver
        End While

    End Sub
End Class
