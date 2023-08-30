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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Main_Page))
        ToolTip1 = New ToolTip(components)
        Panel1 = New Panel()
        Panel3 = New Panel()
        btn_accuel = New FontAwesome.Sharp.IconButton()
        btn_purchases = New FontAwesome.Sharp.IconButton()
        btn_customers = New FontAwesome.Sharp.IconButton()
        btn_items = New FontAwesome.Sharp.IconButton()
        btn_supplier = New FontAwesome.Sharp.IconButton()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(btn_accuel)
        Panel1.Controls.Add(btn_purchases)
        Panel1.Controls.Add(btn_customers)
        Panel1.Controls.Add(btn_items)
        Panel1.Controls.Add(btn_supplier)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(168, 609)
        Panel1.TabIndex = 4
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Green
        Panel3.Location = New Point(0, 323)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(166, 4)
        Panel3.TabIndex = 10
        ' 
        ' btn_accuel
        ' 
        btn_accuel.AutoSize = True
        btn_accuel.BackColor = Color.Silver
        btn_accuel.FlatStyle = FlatStyle.Flat
        btn_accuel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_accuel.ForeColor = Color.Black
        btn_accuel.IconChar = FontAwesome.Sharp.IconChar.House
        btn_accuel.IconColor = Color.Black
        btn_accuel.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_accuel.IconSize = 30
        btn_accuel.ImageAlign = ContentAlignment.MiddleLeft
        btn_accuel.Location = New Point(-1, 116)
        btn_accuel.Name = "btn_accuel"
        btn_accuel.Size = New Size(166, 40)
        btn_accuel.TabIndex = 9
        btn_accuel.Text = "         Accuel"
        btn_accuel.TextAlign = ContentAlignment.MiddleLeft
        btn_accuel.UseVisualStyleBackColor = False
        ' 
        ' btn_purchases
        ' 
        btn_purchases.AutoSize = True
        btn_purchases.FlatStyle = FlatStyle.Flat
        btn_purchases.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_purchases.ForeColor = Color.Black
        btn_purchases.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        btn_purchases.IconColor = Color.Black
        btn_purchases.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_purchases.IconSize = 30
        btn_purchases.ImageAlign = ContentAlignment.MiddleLeft
        btn_purchases.Location = New Point(-1, 204)
        btn_purchases.Name = "btn_purchases"
        btn_purchases.Size = New Size(165, 40)
        btn_purchases.TabIndex = 8
        btn_purchases.Text = "        Page Purchases"
        btn_purchases.UseVisualStyleBackColor = True
        ' 
        ' btn_customers
        ' 
        btn_customers.AutoSize = True
        btn_customers.FlatStyle = FlatStyle.Flat
        btn_customers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_customers.ForeColor = Color.Black
        btn_customers.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        btn_customers.IconColor = Color.Black
        btn_customers.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_customers.IconSize = 30
        btn_customers.ImageAlign = ContentAlignment.MiddleLeft
        btn_customers.Location = New Point(-1, 246)
        btn_customers.Name = "btn_customers"
        btn_customers.Size = New Size(166, 40)
        btn_customers.TabIndex = 7
        btn_customers.Text = "        Page Customers"
        btn_customers.UseVisualStyleBackColor = True
        ' 
        ' btn_items
        ' 
        btn_items.FlatStyle = FlatStyle.Flat
        btn_items.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_items.ForeColor = Color.Black
        btn_items.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        btn_items.IconColor = Color.Black
        btn_items.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_items.IconSize = 30
        btn_items.ImageAlign = ContentAlignment.MiddleLeft
        btn_items.Location = New Point(-1, 287)
        btn_items.Name = "btn_items"
        btn_items.Size = New Size(166, 40)
        btn_items.TabIndex = 6
        btn_items.Text = "Page items"
        btn_items.UseVisualStyleBackColor = True
        ' 
        ' btn_supplier
        ' 
        btn_supplier.AutoSize = True
        btn_supplier.BackColor = Color.Silver
        btn_supplier.FlatStyle = FlatStyle.Flat
        btn_supplier.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btn_supplier.ForeColor = Color.Black
        btn_supplier.IconChar = FontAwesome.Sharp.IconChar.Briefcase
        btn_supplier.IconColor = Color.Black
        btn_supplier.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_supplier.IconSize = 30
        btn_supplier.ImageAlign = ContentAlignment.MiddleLeft
        btn_supplier.Location = New Point(-1, 160)
        btn_supplier.Name = "btn_supplier"
        btn_supplier.Size = New Size(166, 40)
        btn_supplier.TabIndex = 5
        btn_supplier.Text = "      Page Suppliers"
        btn_supplier.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonFace
        Panel2.Location = New Point(171, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(885, 606)
        Panel2.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(161, 107)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Main_Page
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1058, 609)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
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
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_supplier As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_purchases As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_customers As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_items As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_accuel As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
