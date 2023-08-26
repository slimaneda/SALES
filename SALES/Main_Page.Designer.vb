<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        ToolTip1 = New ToolTip(components)
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Button1.Location = New Point(4, 5)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(208, 147)
        Button1.TabIndex = 0
        Button1.Text = "Page Suppliers"
        ToolTip1.SetToolTip(Button1, "بطاقة مورد ")
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button2.Location = New Point(4, 159)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(208, 146)
        Button2.TabIndex = 1
        Button2.Text = "Page Customers"
        ToolTip1.SetToolTip(Button2, "بطاقة زبون")
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        Button3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(220, 5)
        Button3.Margin = New Padding(4, 4, 4, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(208, 147)
        Button3.TabIndex = 2
        Button3.Text = "Page items"
        ToolTip1.SetToolTip(Button3, "بطاقة صنف")
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        Button4.Location = New Point(220, 160)
        Button4.Margin = New Padding(4, 4, 4, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(208, 144)
        Button4.TabIndex = 3
        Button4.Text = "Page Purchases"
        ToolTip1.SetToolTip(Button4, "شاشة المشتريات")
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Main_Page
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(431, 311)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "Main_Page"
        RightToLeftLayout = True
        Text = "Página principal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
