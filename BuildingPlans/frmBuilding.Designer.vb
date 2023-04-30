<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuilding
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
        Me.grpUnitType = New System.Windows.Forms.GroupBox()
        Me.radMeters = New System.Windows.Forms.RadioButton()
        Me.radInches = New System.Windows.Forms.RadioButton()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblUnitLength = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblConvertedLength = New System.Windows.Forms.Label()
        Me.lblConverted = New System.Windows.Forms.Label()
        Me.lblUnitChoice = New System.Windows.Forms.Label()
        Me.grpUnitType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUnitType
        '
        Me.grpUnitType.BackColor = System.Drawing.Color.AliceBlue
        Me.grpUnitType.Controls.Add(Me.radMeters)
        Me.grpUnitType.Controls.Add(Me.radInches)
        Me.grpUnitType.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUnitType.ForeColor = System.Drawing.Color.Sienna
        Me.grpUnitType.Location = New System.Drawing.Point(104, 170)
        Me.grpUnitType.Name = "grpUnitType"
        Me.grpUnitType.Size = New System.Drawing.Size(244, 106)
        Me.grpUnitType.TabIndex = 13
        Me.grpUnitType.TabStop = False
        Me.grpUnitType.Text = "Your Unit Type:"
        '
        'radMeters
        '
        Me.radMeters.AutoSize = True
        Me.radMeters.Location = New System.Drawing.Point(6, 49)
        Me.radMeters.Name = "radMeters"
        Me.radMeters.Size = New System.Drawing.Size(144, 27)
        Me.radMeters.TabIndex = 1
        Me.radMeters.Text = "Meters (Metric)"
        Me.radMeters.UseVisualStyleBackColor = True
        '
        'radInches
        '
        Me.radInches.AutoSize = True
        Me.radInches.Checked = True
        Me.radInches.Location = New System.Drawing.Point(6, 22)
        Me.radInches.Name = "radInches"
        Me.radInches.Size = New System.Drawing.Size(155, 27)
        Me.radInches.TabIndex = 0
        Me.radInches.TabStop = True
        Me.radInches.Text = "Inches (Imperial)"
        Me.radInches.UseVisualStyleBackColor = True
        '
        'txtLength
        '
        Me.txtLength.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLength.ForeColor = System.Drawing.Color.Sienna
        Me.txtLength.Location = New System.Drawing.Point(281, 125)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(47, 33)
        Me.txtLength.TabIndex = 12
        Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUnitLength
        '
        Me.lblUnitLength.AutoSize = True
        Me.lblUnitLength.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitLength.ForeColor = System.Drawing.Color.Sienna
        Me.lblUnitLength.Location = New System.Drawing.Point(99, 125)
        Me.lblUnitLength.Name = "lblUnitLength"
        Me.lblUnitLength.Size = New System.Drawing.Size(140, 25)
        Me.lblUnitLength.TabIndex = 11
        Me.lblUnitLength.Text = "Enter a length:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Goudy Old Style", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Sienna
        Me.lblHeading.Location = New System.Drawing.Point(60, 47)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(371, 37)
        Me.lblHeading.TabIndex = 10
        Me.lblHeading.Text = "Building Plans Conversion"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Sienna
        Me.btnClear.Location = New System.Drawing.Point(239, 359)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 41)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Sienna
        Me.btnCalculate.Location = New System.Drawing.Point(94, 359)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(116, 41)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblConvertedLength
        '
        Me.lblConvertedLength.AutoSize = True
        Me.lblConvertedLength.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertedLength.ForeColor = System.Drawing.Color.Sienna
        Me.lblConvertedLength.Location = New System.Drawing.Point(271, 299)
        Me.lblConvertedLength.Name = "lblConvertedLength"
        Me.lblConvertedLength.Size = New System.Drawing.Size(84, 25)
        Me.lblConvertedLength.TabIndex = 15
        Me.lblConvertedLength.Text = "0000.00"
        '
        'lblConverted
        '
        Me.lblConverted.AutoSize = True
        Me.lblConverted.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConverted.ForeColor = System.Drawing.Color.Sienna
        Me.lblConverted.Location = New System.Drawing.Point(65, 299)
        Me.lblConverted.Name = "lblConverted"
        Me.lblConverted.Size = New System.Drawing.Size(174, 25)
        Me.lblConverted.TabIndex = 14
        Me.lblConverted.Text = "Converted Length:"
        '
        'lblUnitChoice
        '
        Me.lblUnitChoice.AutoSize = True
        Me.lblUnitChoice.Font = New System.Drawing.Font("Goudy Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitChoice.ForeColor = System.Drawing.Color.Sienna
        Me.lblUnitChoice.Location = New System.Drawing.Point(370, 299)
        Me.lblUnitChoice.Name = "lblUnitChoice"
        Me.lblUnitChoice.Size = New System.Drawing.Size(0, 25)
        Me.lblUnitChoice.TabIndex = 18
        '
        'frmBuilding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.lblUnitChoice)
        Me.Controls.Add(Me.grpUnitType)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.lblUnitLength)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblConvertedLength)
        Me.Controls.Add(Me.lblConverted)
        Me.Name = "frmBuilding"
        Me.Text = "Building Plans Conversion"
        Me.grpUnitType.ResumeLayout(False)
        Me.grpUnitType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpUnitType As GroupBox
    Friend WithEvents radMeters As RadioButton
    Friend WithEvents radInches As RadioButton
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblUnitLength As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblConvertedLength As Label
    Friend WithEvents lblConverted As Label
    Friend WithEvents lblUnitChoice As Label
End Class
