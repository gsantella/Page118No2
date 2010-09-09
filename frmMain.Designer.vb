<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnDisplayAccountSummary = New System.Windows.Forms.Button
        Me.lstDisplayAccountSummary = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'btnDisplayAccountSummary
        '
        Me.btnDisplayAccountSummary.Location = New System.Drawing.Point(70, 41)
        Me.btnDisplayAccountSummary.Name = "btnDisplayAccountSummary"
        Me.btnDisplayAccountSummary.Size = New System.Drawing.Size(129, 39)
        Me.btnDisplayAccountSummary.TabIndex = 0
        Me.btnDisplayAccountSummary.Text = "Display Account Summary"
        Me.btnDisplayAccountSummary.UseVisualStyleBackColor = True
        '
        'lstDisplayAccountSummary
        '
        Me.lstDisplayAccountSummary.FormattingEnabled = True
        Me.lstDisplayAccountSummary.Location = New System.Drawing.Point(13, 109)
        Me.lstDisplayAccountSummary.Name = "lstDisplayAccountSummary"
        Me.lstDisplayAccountSummary.Size = New System.Drawing.Size(259, 134)
        Me.lstDisplayAccountSummary.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lstDisplayAccountSummary)
        Me.Controls.Add(Me.btnDisplayAccountSummary)
        Me.Name = "Form1"
        Me.Text = "Credit Card Amounts"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplayAccountSummary As System.Windows.Forms.Button
    Friend WithEvents lstDisplayAccountSummary As System.Windows.Forms.ListBox

End Class
