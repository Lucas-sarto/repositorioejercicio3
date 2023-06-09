<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdEjecutar = New System.Windows.Forms.Button()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.lblMenor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdEjecutar
        '
        Me.cmdEjecutar.Location = New System.Drawing.Point(180, 185)
        Me.cmdEjecutar.Name = "cmdEjecutar"
        Me.cmdEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.cmdEjecutar.TabIndex = 0
        Me.cmdEjecutar.Text = "Ejecutar"
        Me.cmdEjecutar.UseVisualStyleBackColor = True
        '
        'lblMayor
        '
        Me.lblMayor.AutoSize = True
        Me.lblMayor.Location = New System.Drawing.Point(70, 79)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(39, 13)
        Me.lblMayor.TabIndex = 1
        Me.lblMayor.Text = "Label1"
        '
        'lblMenor
        '
        Me.lblMenor.AutoSize = True
        Me.lblMenor.Location = New System.Drawing.Point(73, 119)
        Me.lblMenor.Name = "lblMenor"
        Me.lblMenor.Size = New System.Drawing.Size(39, 13)
        Me.lblMenor.TabIndex = 2
        Me.lblMenor.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 292)
        Me.Controls.Add(Me.lblMenor)
        Me.Controls.Add(Me.lblMayor)
        Me.Controls.Add(Me.cmdEjecutar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdEjecutar As System.Windows.Forms.Button
    Friend WithEvents lblMayor As System.Windows.Forms.Label
    Friend WithEvents lblMenor As System.Windows.Forms.Label

End Class
