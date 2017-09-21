<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TblnameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VS2012DataSet = New WindowsApplication1.VS2012DataSet()
        Me.Tbl_nameTableAdapter = New WindowsApplication1.VS2012DataSetTableAdapters.Tbl_nameTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmb1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TblnameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VS2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblnameBindingSource
        '
        Me.TblnameBindingSource.DataMember = "Tbl_name"
        Me.TblnameBindingSource.DataSource = Me.VS2012DataSet
        '
        'VS2012DataSet
        '
        Me.VS2012DataSet.DataSetName = "VS2012DataSet"
        Me.VS2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_nameTableAdapter
        '
        Me.Tbl_nameTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(629, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(443, 353)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(84, 24)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(479, 91)
        Me.txtsearch.MaximumSize = New System.Drawing.Size(999, 999)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(138, 22)
        Me.txtsearch.TabIndex = 54
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ID", "Firstname", "Lastname"})
        Me.ComboBox1.Location = New System.Drawing.Point(277, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(149, 21)
        Me.ComboBox1.TabIndex = 53
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(158, 291)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 25)
        Me.Button5.TabIndex = 52
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmb1
        '
        Me.cmb1.FormattingEnabled = True
        Me.cmb1.Location = New System.Drawing.Point(7, 125)
        Me.cmb1.Name = "cmb1"
        Me.cmb1.Size = New System.Drawing.Size(220, 21)
        Me.cmb1.TabIndex = 51
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(81, 291)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 25)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(533, 352)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 24)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(7, 209)
        Me.txt2.MaximumSize = New System.Drawing.Size(999, 999)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(220, 22)
        Me.txt2.TabIndex = 48
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 25)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblnameBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(247, 125)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(370, 223)
        Me.DataGridView1.TabIndex = 46
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(353, 353)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 24)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(7, 252)
        Me.txt3.MaximumSize = New System.Drawing.Size(999, 999)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(220, 22)
        Me.txt3.TabIndex = 44
        '
        'txt1
        '
        Me.txt1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(7, 164)
        Me.txt1.MaximumSize = New System.Drawing.Size(999, 999)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(220, 22)
        Me.txt1.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(625, 64)
        Me.Label1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(25, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 23)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Programmador Inc."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(629, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.cmb1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(400, 150)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "VB.NET - ADD , UPDATE , DELETE , DISPLAY , AND SEARCH"
        CType(Me.TblnameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VS2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VS2012DataSet As WindowsApplication1.VS2012DataSet
    Friend WithEvents TblnameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tbl_nameTableAdapter As WindowsApplication1.VS2012DataSetTableAdapters.Tbl_nameTableAdapter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents cmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
