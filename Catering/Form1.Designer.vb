<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picPlatter = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picBg = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdiCheese = New System.Windows.Forms.RadioButton()
        Me.rdiPinwheel = New System.Windows.Forms.RadioButton()
        Me.rdiVeggie = New System.Windows.Forms.RadioButton()
        Me.rdiSnC = New System.Windows.Forms.RadioButton()
        Me.rdiFruit = New System.Windows.Forms.RadioButton()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.grpPay = New System.Windows.Forms.GroupBox()
        Me.rdiPckUp = New System.Windows.Forms.RadioButton()
        Me.rdiPrPy = New System.Windows.Forms.RadioButton()
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPay.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPlatter
        '
        Me.picPlatter.Image = CType(resources.GetObject("picPlatter.Image"), System.Drawing.Image)
        Me.picPlatter.Location = New System.Drawing.Point(409, 12)
        Me.picPlatter.Name = "picPlatter"
        Me.picPlatter.Size = New System.Drawing.Size(378, 250)
        Me.picPlatter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlatter.TabIndex = 0
        Me.picPlatter.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Star Market"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(129, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Catering"
        '
        'picBg
        '
        Me.picBg.BackColor = System.Drawing.Color.AntiqueWhite
        Me.picBg.Location = New System.Drawing.Point(38, 99)
        Me.picBg.Name = "picBg"
        Me.picBg.Size = New System.Drawing.Size(301, 214)
        Me.picBg.TabIndex = 3
        Me.picBg.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(424, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Loyalty Points:"
        '
        'rdiCheese
        '
        Me.rdiCheese.AutoSize = True
        Me.rdiCheese.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rdiCheese.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiCheese.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiCheese.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiCheese.Location = New System.Drawing.Point(55, 115)
        Me.rdiCheese.Name = "rdiCheese"
        Me.rdiCheese.Size = New System.Drawing.Size(236, 22)
        Me.rdiCheese.TabIndex = 6
        Me.rdiCheese.TabStop = True
        Me.rdiCheese.Text = "Gourmet Cheese $49.99"
        Me.rdiCheese.UseVisualStyleBackColor = False
        '
        'rdiPinwheel
        '
        Me.rdiPinwheel.AutoSize = True
        Me.rdiPinwheel.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rdiPinwheel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiPinwheel.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiPinwheel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiPinwheel.Location = New System.Drawing.Point(55, 155)
        Me.rdiPinwheel.Name = "rdiPinwheel"
        Me.rdiPinwheel.Size = New System.Drawing.Size(236, 22)
        Me.rdiPinwheel.TabIndex = 7
        Me.rdiPinwheel.TabStop = True
        Me.rdiPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.rdiPinwheel.UseVisualStyleBackColor = False
        '
        'rdiVeggie
        '
        Me.rdiVeggie.AutoSize = True
        Me.rdiVeggie.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rdiVeggie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiVeggie.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiVeggie.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiVeggie.Location = New System.Drawing.Point(55, 195)
        Me.rdiVeggie.Name = "rdiVeggie"
        Me.rdiVeggie.Size = New System.Drawing.Size(156, 22)
        Me.rdiVeggie.TabIndex = 8
        Me.rdiVeggie.TabStop = True
        Me.rdiVeggie.Text = "Veggie $29.99"
        Me.rdiVeggie.UseVisualStyleBackColor = False
        '
        'rdiSnC
        '
        Me.rdiSnC.AutoSize = True
        Me.rdiSnC.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rdiSnC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiSnC.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiSnC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiSnC.Location = New System.Drawing.Point(55, 235)
        Me.rdiSnC.Name = "rdiSnC"
        Me.rdiSnC.Size = New System.Drawing.Size(276, 22)
        Me.rdiSnC.TabIndex = 9
        Me.rdiSnC.TabStop = True
        Me.rdiSnC.Text = "Sausage and Cheese $49.99"
        Me.rdiSnC.UseVisualStyleBackColor = False
        '
        'rdiFruit
        '
        Me.rdiFruit.AutoSize = True
        Me.rdiFruit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.rdiFruit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiFruit.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiFruit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiFruit.Location = New System.Drawing.Point(55, 275)
        Me.rdiFruit.Name = "rdiFruit"
        Me.rdiFruit.Size = New System.Drawing.Size(146, 22)
        Me.rdiFruit.TabIndex = 10
        Me.rdiFruit.TabStop = True
        Me.rdiFruit.Text = "Fruit $29.99"
        Me.rdiFruit.UseVisualStyleBackColor = False
        '
        'tbxInput
        '
        Me.tbxInput.BackColor = System.Drawing.Color.AntiqueWhite
        Me.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxInput.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.tbxInput.Location = New System.Drawing.Point(585, 271)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(40, 26)
        Me.tbxInput.TabIndex = 13
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCalc.Enabled = False
        Me.btnCalc.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalc.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCalc.Location = New System.Drawing.Point(461, 303)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(125, 30)
        Me.btnCalc.TabIndex = 14
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Tan
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(622, 303)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 30)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.lblPay.Location = New System.Drawing.Point(339, 345)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(428, 18)
        Me.lblPay.TabIndex = 16
        Me.lblPay.Text = "Your order of a costs using loyalty points"
        '
        'grpPay
        '
        Me.grpPay.BackColor = System.Drawing.Color.AntiqueWhite
        Me.grpPay.Controls.Add(Me.rdiPckUp)
        Me.grpPay.Controls.Add(Me.rdiPrPy)
        Me.grpPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpPay.Location = New System.Drawing.Point(80, 331)
        Me.grpPay.Name = "grpPay"
        Me.grpPay.Size = New System.Drawing.Size(200, 85)
        Me.grpPay.TabIndex = 17
        Me.grpPay.TabStop = False
        '
        'rdiPckUp
        '
        Me.rdiPckUp.AutoSize = True
        Me.rdiPckUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiPckUp.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiPckUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiPckUp.Location = New System.Drawing.Point(6, 49)
        Me.rdiPckUp.Name = "rdiPckUp"
        Me.rdiPckUp.Size = New System.Drawing.Size(176, 22)
        Me.rdiPckUp.TabIndex = 1
        Me.rdiPckUp.TabStop = True
        Me.rdiPckUp.Text = "Pay Upon Pickup"
        Me.rdiPckUp.UseVisualStyleBackColor = True
        '
        'rdiPrPy
        '
        Me.rdiPrPy.AutoSize = True
        Me.rdiPrPy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdiPrPy.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdiPrPy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.rdiPrPy.Location = New System.Drawing.Point(6, 12)
        Me.rdiPrPy.Name = "rdiPrPy"
        Me.rdiPrPy.Size = New System.Drawing.Size(96, 22)
        Me.rdiPrPy.TabIndex = 0
        Me.rdiPrPy.TabStop = True
        Me.rdiPrPy.Text = "Pre-Pay"
        Me.rdiPrPy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(799, 471)
        Me.Controls.Add(Me.grpPay)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.rdiFruit)
        Me.Controls.Add(Me.rdiSnC)
        Me.Controls.Add(Me.rdiVeggie)
        Me.Controls.Add(Me.rdiPinwheel)
        Me.Controls.Add(Me.rdiCheese)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.picBg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picPlatter)
        Me.Name = "Form1"
        Me.Text = "Star Market Catering"
        CType(Me.picPlatter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPay.ResumeLayout(False)
        Me.grpPay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlatter As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picBg As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rdiCheese As RadioButton
    Friend WithEvents rdiPinwheel As RadioButton
    Friend WithEvents rdiVeggie As RadioButton
    Friend WithEvents rdiSnC As RadioButton
    Friend WithEvents rdiFruit As RadioButton
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPay As Label
    Friend WithEvents grpPay As GroupBox
    Friend WithEvents rdiPrPy As RadioButton
    Friend WithEvents rdiPckUp As RadioButton
End Class
