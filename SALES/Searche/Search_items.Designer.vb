﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_items
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(10, 83)
        DataGridView1.Margin = New Padding(5, 6, 5, 6)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New Size(757, 200)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Location = New Point(0, 2)
        GroupBox1.Margin = New Padding(5, 6, 5, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(5, 6, 5, 6)
        GroupBox1.Size = New Size(781, 345)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"NAME", "BARCODE"})
        ComboBox1.Location = New Point(31, 32)
        ComboBox1.Margin = New Padding(4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(174, 29)
        ComboBox1.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(253, 32)
        TextBox1.Margin = New Padding(5, 6, 5, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(489, 29)
        TextBox1.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "info"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.DataPropertyName = "ID"
        Column2.HeaderText = "Code"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.DataPropertyName = "ITEM_NAME"
        Column3.HeaderText = "Name"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.DataPropertyName = "ITEM_CODE"
        Column4.HeaderText = "Barkoude"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Search_items
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(781, 349)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Search_items"
        Text = "Search_items"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
