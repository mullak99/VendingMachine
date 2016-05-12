<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsoleForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.consoleText = New System.Windows.Forms.TextBox()
        Me.clearConsole = New System.Windows.Forms.Button()
        Me.runtime_tick_label = New System.Windows.Forms.Label()
        Me.runtime_tick_count = New System.Windows.Forms.Label()
        Me.close_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'consoleText
        '
        Me.consoleText.Location = New System.Drawing.Point(13, 26)
        Me.consoleText.MaxLength = 1000000
        Me.consoleText.Multiline = True
        Me.consoleText.Name = "consoleText"
        Me.consoleText.ReadOnly = True
        Me.consoleText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.consoleText.Size = New System.Drawing.Size(531, 284)
        Me.consoleText.TabIndex = 0
        '
        'clearConsole
        '
        Me.clearConsole.Location = New System.Drawing.Point(15, 316)
        Me.clearConsole.Name = "clearConsole"
        Me.clearConsole.Size = New System.Drawing.Size(75, 25)
        Me.clearConsole.TabIndex = 1
        Me.clearConsole.Text = "Clear"
        Me.clearConsole.UseVisualStyleBackColor = True
        '
        'runtime_tick_label
        '
        Me.runtime_tick_label.AutoSize = True
        Me.runtime_tick_label.Location = New System.Drawing.Point(12, 10)
        Me.runtime_tick_label.Name = "runtime_tick_label"
        Me.runtime_tick_label.Size = New System.Drawing.Size(110, 13)
        Me.runtime_tick_label.TabIndex = 2
        Me.runtime_tick_label.Text = "Current Runtime Tick:"
        '
        'runtime_tick_count
        '
        Me.runtime_tick_count.AutoSize = True
        Me.runtime_tick_count.Location = New System.Drawing.Point(117, 10)
        Me.runtime_tick_count.Name = "runtime_tick_count"
        Me.runtime_tick_count.Size = New System.Drawing.Size(13, 13)
        Me.runtime_tick_count.TabIndex = 3
        Me.runtime_tick_count.Text = "0"
        '
        'close_button
        '
        Me.close_button.Location = New System.Drawing.Point(469, 316)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(75, 25)
        Me.close_button.TabIndex = 4
        Me.close_button.Text = "Close"
        Me.close_button.UseVisualStyleBackColor = True
        '
        'ConsoleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 351)
        Me.Controls.Add(Me.close_button)
        Me.Controls.Add(Me.runtime_tick_count)
        Me.Controls.Add(Me.runtime_tick_label)
        Me.Controls.Add(Me.clearConsole)
        Me.Controls.Add(Me.consoleText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ConsoleForm"
        Me.Text = "Console"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents consoleText As TextBox
    Friend WithEvents clearConsole As Button
    Friend WithEvents runtime_tick_label As Label
    Friend WithEvents runtime_tick_count As Label
    Friend WithEvents close_button As Button
End Class
