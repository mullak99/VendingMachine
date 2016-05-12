Public Class ConsoleForm

    Dim currentTick As Integer = 0

    Private Sub clearConsole_Click(sender As Object, e As EventArgs) Handles clearConsole.Click
        consoleText.Text = ""
    End Sub

    Public Sub addDebugLine(text As String)
        If consoleText.TextLength > consoleText.MaxLength - 100 Then
            consoleText.Text = ""
        End If
        consoleText.AppendText("[Tick:" & currentTick & "]: " & text & Environment.NewLine)
    End Sub

    Public Sub setRuntimeTick(tick As Integer)
        runtime_tick_count.Text = Convert.ToString(tick)
        currentTick = tick
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Visible = False
        e.Cancel = True
    End Sub

    Private Sub close_button_Click(sender As Object, e As EventArgs) Handles close_button.Click
        Me.Visible = False
    End Sub
End Class