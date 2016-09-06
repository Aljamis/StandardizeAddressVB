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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AddressLine1 = New System.Windows.Forms.TextBox()
        Me.AddressLine2 = New System.Windows.Forms.TextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Zip = New System.Windows.Forms.TextBox()
        Me.State = New System.Windows.Forms.TextBox()
        Me.Standardize = New System.Windows.Forms.Button()
        Me.lblAddr1 = New System.Windows.Forms.Label()
        Me.lblAddr2 = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblConf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddressLine1
        '
        Me.AddressLine1.Location = New System.Drawing.Point(21, 14)
        Me.AddressLine1.Name = "AddressLine1"
        Me.AddressLine1.Size = New System.Drawing.Size(302, 20)
        Me.AddressLine1.TabIndex = 0
        '
        'AddressLine2
        '
        Me.AddressLine2.Location = New System.Drawing.Point(21, 40)
        Me.AddressLine2.Name = "AddressLine2"
        Me.AddressLine2.Size = New System.Drawing.Size(302, 20)
        Me.AddressLine2.TabIndex = 1
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(21, 66)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(167, 20)
        Me.City.TabIndex = 2
        '
        'Zip
        '
        Me.Zip.Location = New System.Drawing.Point(261, 66)
        Me.Zip.Name = "Zip"
        Me.Zip.Size = New System.Drawing.Size(62, 20)
        Me.Zip.TabIndex = 4
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(213, 66)
        Me.State.MaxLength = 2
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(25, 20)
        Me.State.TabIndex = 3
        '
        'Standardize
        '
        Me.Standardize.Location = New System.Drawing.Point(21, 107)
        Me.Standardize.Name = "Standardize"
        Me.Standardize.Size = New System.Drawing.Size(75, 23)
        Me.Standardize.TabIndex = 5
        Me.Standardize.Text = "Standardize"
        Me.Standardize.UseVisualStyleBackColor = True
        '
        'lblAddr1
        '
        Me.lblAddr1.AutoSize = True
        Me.lblAddr1.Location = New System.Drawing.Point(127, 135)
        Me.lblAddr1.Name = "lblAddr1"
        Me.lblAddr1.Size = New System.Drawing.Size(44, 13)
        Me.lblAddr1.TabIndex = 6
        Me.lblAddr1.Text = "ADDR1"
        '
        'lblAddr2
        '
        Me.lblAddr2.AutoSize = True
        Me.lblAddr2.Location = New System.Drawing.Point(127, 148)
        Me.lblAddr2.Name = "lblAddr2"
        Me.lblAddr2.Size = New System.Drawing.Size(44, 13)
        Me.lblAddr2.TabIndex = 7
        Me.lblAddr2.Text = "ADDR2"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(127, 161)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(31, 13)
        Me.lblCity.TabIndex = 8
        Me.lblCity.Text = "CITY"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(281, 161)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(42, 13)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "STATE"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(329, 161)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(24, 13)
        Me.lblZip.TabIndex = 10
        Me.lblZip.Text = "ZIP"
        '
        'lblConf
        '
        Me.lblConf.AutoSize = True
        Me.lblConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConf.Location = New System.Drawing.Point(33, 148)
        Me.lblConf.Name = "lblConf"
        Me.lblConf.Size = New System.Drawing.Size(78, 26)
        Me.lblConf.TabIndex = 11
        Me.lblConf.Text = "CONF"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 262)
        Me.Controls.Add(Me.lblConf)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddr2)
        Me.Controls.Add(Me.lblAddr1)
        Me.Controls.Add(Me.Standardize)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.Zip)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.AddressLine2)
        Me.Controls.Add(Me.AddressLine1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Standardize Address VB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddressLine1 As System.Windows.Forms.TextBox
    Friend WithEvents AddressLine2 As System.Windows.Forms.TextBox
    Friend WithEvents City As System.Windows.Forms.TextBox
    Friend WithEvents Zip As System.Windows.Forms.TextBox
    Friend WithEvents State As System.Windows.Forms.TextBox
    Friend WithEvents Standardize As System.Windows.Forms.Button
    Friend WithEvents lblAddr1 As System.Windows.Forms.Label
    Friend WithEvents lblAddr2 As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblConf As System.Windows.Forms.Label

End Class
