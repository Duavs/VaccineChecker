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
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim MILabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim FirstDose_Covid19Label As System.Windows.Forms.Label
        Dim SecondDose_Covid19Label As System.Windows.Forms.Label
        Dim FirstDoseLabel As System.Windows.Forms.Label
        Dim SecondDoseLabel As System.Windows.Forms.Label
        Dim Vaccine_BrandLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DbvaccineDataSet = New VaccineChecker.dbvaccineDataSet()
        Me.VaccinatedlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VaccinatedlistTableAdapter = New VaccineChecker.dbvaccineDataSetTableAdapters.vaccinatedlistTableAdapter()
        Me.TableAdapterManager = New VaccineChecker.dbvaccineDataSetTableAdapters.TableAdapterManager()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.tbxlastname = New System.Windows.Forms.TextBox()
        Me.tbxfirstname = New System.Windows.Forms.TextBox()
        Me.tbxmi = New System.Windows.Forms.TextBox()
        Me.dtpbirthday = New System.Windows.Forms.DateTimePicker()
        Me.cbfirstdose = New System.Windows.Forms.CheckBox()
        Me.cbseconddose = New System.Windows.Forms.CheckBox()
        Me.dtpfirstdose = New System.Windows.Forms.DateTimePicker()
        Me.dtpseconddose = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbvaccine = New System.Windows.Forms.ComboBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        MILabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        FirstDose_Covid19Label = New System.Windows.Forms.Label()
        SecondDose_Covid19Label = New System.Windows.Forms.Label()
        FirstDoseLabel = New System.Windows.Forms.Label()
        SecondDoseLabel = New System.Windows.Forms.Label()
        Vaccine_BrandLabel = New System.Windows.Forms.Label()
        CType(Me.DbvaccineDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VaccinatedlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(30, 28)
        IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(29, 23)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Location = New System.Drawing.Point(30, 60)
        LastnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(89, 23)
        LastnameLabel.TabIndex = 4
        LastnameLabel.Text = "Lastname:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(30, 91)
        FirstnameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(90, 23)
        FirstnameLabel.TabIndex = 6
        FirstnameLabel.Text = "Firstname:"
        '
        'MILabel
        '
        MILabel.AutoSize = True
        MILabel.Location = New System.Drawing.Point(30, 119)
        MILabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        MILabel.Name = "MILabel"
        MILabel.Size = New System.Drawing.Size(32, 23)
        MILabel.TabIndex = 8
        MILabel.Text = "MI:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(30, 150)
        Date_of_BirthLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(110, 23)
        Date_of_BirthLabel.TabIndex = 10
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'FirstDose_Covid19Label
        '
        FirstDose_Covid19Label.AutoSize = True
        FirstDose_Covid19Label.Location = New System.Drawing.Point(16, 42)
        FirstDose_Covid19Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstDose_Covid19Label.Name = "FirstDose_Covid19Label"
        FirstDose_Covid19Label.Size = New System.Drawing.Size(154, 23)
        FirstDose_Covid19Label.TabIndex = 12
        FirstDose_Covid19Label.Text = "First Dose Vaccine:"
        '
        'SecondDose_Covid19Label
        '
        SecondDose_Covid19Label.AutoSize = True
        SecondDose_Covid19Label.Location = New System.Drawing.Point(287, 40)
        SecondDose_Covid19Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SecondDose_Covid19Label.Name = "SecondDose_Covid19Label"
        SecondDose_Covid19Label.Size = New System.Drawing.Size(179, 23)
        SecondDose_Covid19Label.TabIndex = 14
        SecondDose_Covid19Label.Text = "Second Dose Vaccine:"
        '
        'FirstDoseLabel
        '
        FirstDoseLabel.AutoSize = True
        FirstDoseLabel.Location = New System.Drawing.Point(16, 76)
        FirstDoseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FirstDoseLabel.Name = "FirstDoseLabel"
        FirstDoseLabel.Size = New System.Drawing.Size(90, 23)
        FirstDoseLabel.TabIndex = 16
        FirstDoseLabel.Text = "First Dose:"
        '
        'SecondDoseLabel
        '
        SecondDoseLabel.AutoSize = True
        SecondDoseLabel.Location = New System.Drawing.Point(16, 105)
        SecondDoseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        SecondDoseLabel.Name = "SecondDoseLabel"
        SecondDoseLabel.Size = New System.Drawing.Size(115, 23)
        SecondDoseLabel.TabIndex = 18
        SecondDoseLabel.Text = "Second Dose:"
        '
        'Vaccine_BrandLabel
        '
        Vaccine_BrandLabel.AutoSize = True
        Vaccine_BrandLabel.Location = New System.Drawing.Point(16, 133)
        Vaccine_BrandLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Vaccine_BrandLabel.Name = "Vaccine_BrandLabel"
        Vaccine_BrandLabel.Size = New System.Drawing.Size(124, 23)
        Vaccine_BrandLabel.TabIndex = 20
        Vaccine_BrandLabel.Text = "Vaccine Brand:"
        '
        'DbvaccineDataSet
        '
        Me.DbvaccineDataSet.DataSetName = "dbvaccineDataSet"
        Me.DbvaccineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VaccinatedlistBindingSource
        '
        Me.VaccinatedlistBindingSource.DataMember = "vaccinatedlist"
        Me.VaccinatedlistBindingSource.DataSource = Me.DbvaccineDataSet
        '
        'VaccinatedlistTableAdapter
        '
        Me.VaccinatedlistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VaccineChecker.dbvaccineDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vaccinatedlistTableAdapter = Me.VaccinatedlistTableAdapter
        '
        'tbxID
        '
        Me.tbxID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VaccinatedlistBindingSource, "ID", True))
        Me.tbxID.Location = New System.Drawing.Point(186, 26)
        Me.tbxID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(298, 24)
        Me.tbxID.TabIndex = 3
        '
        'tbxlastname
        '
        Me.tbxlastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VaccinatedlistBindingSource, "Lastname", True))
        Me.tbxlastname.Location = New System.Drawing.Point(186, 57)
        Me.tbxlastname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxlastname.Name = "tbxlastname"
        Me.tbxlastname.Size = New System.Drawing.Size(298, 24)
        Me.tbxlastname.TabIndex = 5
        '
        'tbxfirstname
        '
        Me.tbxfirstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VaccinatedlistBindingSource, "Firstname", True))
        Me.tbxfirstname.Location = New System.Drawing.Point(186, 86)
        Me.tbxfirstname.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxfirstname.Name = "tbxfirstname"
        Me.tbxfirstname.Size = New System.Drawing.Size(298, 24)
        Me.tbxfirstname.TabIndex = 7
        '
        'tbxmi
        '
        Me.tbxmi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VaccinatedlistBindingSource, "MI", True))
        Me.tbxmi.Location = New System.Drawing.Point(186, 116)
        Me.tbxmi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.tbxmi.Name = "tbxmi"
        Me.tbxmi.Size = New System.Drawing.Size(298, 24)
        Me.tbxmi.TabIndex = 9
        '
        'dtpbirthday
        '
        Me.dtpbirthday.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VaccinatedlistBindingSource, "Date of Birth", True))
        Me.dtpbirthday.Location = New System.Drawing.Point(186, 145)
        Me.dtpbirthday.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpbirthday.Name = "dtpbirthday"
        Me.dtpbirthday.Size = New System.Drawing.Size(298, 24)
        Me.dtpbirthday.TabIndex = 11
        '
        'cbfirstdose
        '
        Me.cbfirstdose.BackColor = System.Drawing.Color.Transparent
        Me.cbfirstdose.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VaccinatedlistBindingSource, "FirstDose Covid19", True))
        Me.cbfirstdose.Location = New System.Drawing.Point(174, 42)
        Me.cbfirstdose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbfirstdose.Name = "cbfirstdose"
        Me.cbfirstdose.Size = New System.Drawing.Size(25, 26)
        Me.cbfirstdose.TabIndex = 13
        Me.cbfirstdose.UseVisualStyleBackColor = False
        '
        'cbseconddose
        '
        Me.cbseconddose.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VaccinatedlistBindingSource, "SecondDose Covid19", True))
        Me.cbseconddose.Location = New System.Drawing.Point(470, 40)
        Me.cbseconddose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbseconddose.Name = "cbseconddose"
        Me.cbseconddose.Size = New System.Drawing.Size(24, 26)
        Me.cbseconddose.TabIndex = 15
        Me.cbseconddose.UseVisualStyleBackColor = True
        '
        'dtpfirstdose
        '
        Me.dtpfirstdose.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VaccinatedlistBindingSource, "FirstDose", True))
        Me.dtpfirstdose.Location = New System.Drawing.Point(174, 71)
        Me.dtpfirstdose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpfirstdose.Name = "dtpfirstdose"
        Me.dtpfirstdose.Size = New System.Drawing.Size(320, 24)
        Me.dtpfirstdose.TabIndex = 17
        '
        'dtpseconddose
        '
        Me.dtpseconddose.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VaccinatedlistBindingSource, "SecondDose", True))
        Me.dtpseconddose.Location = New System.Drawing.Point(174, 101)
        Me.dtpseconddose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpseconddose.Name = "dtpseconddose"
        Me.dtpseconddose.Size = New System.Drawing.Size(320, 24)
        Me.dtpseconddose.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.dtpbirthday)
        Me.GroupBox1.Controls.Add(IDLabel)
        Me.GroupBox1.Controls.Add(Date_of_BirthLabel)
        Me.GroupBox1.Controls.Add(Me.tbxID)
        Me.GroupBox1.Controls.Add(Me.tbxmi)
        Me.GroupBox1.Controls.Add(LastnameLabel)
        Me.GroupBox1.Controls.Add(MILabel)
        Me.GroupBox1.Controls.Add(Me.tbxlastname)
        Me.GroupBox1.Controls.Add(Me.tbxfirstname)
        Me.GroupBox1.Controls.Add(FirstnameLabel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Hangul
        Me.GroupBox1.Location = New System.Drawing.Point(47, 150)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(519, 201)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  Person Infromation"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Controls.Add(Me.cmbvaccine)
        Me.GroupBox2.Controls.Add(Me.cbfirstdose)
        Me.GroupBox2.Controls.Add(FirstDose_Covid19Label)
        Me.GroupBox2.Controls.Add(Vaccine_BrandLabel)
        Me.GroupBox2.Controls.Add(Me.dtpseconddose)
        Me.GroupBox2.Controls.Add(SecondDose_Covid19Label)
        Me.GroupBox2.Controls.Add(SecondDoseLabel)
        Me.GroupBox2.Controls.Add(Me.cbseconddose)
        Me.GroupBox2.Controls.Add(Me.dtpfirstdose)
        Me.GroupBox2.Controls.Add(FirstDoseLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(47, 363)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(519, 182)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vaccine Information"
        '
        'cmbvaccine
        '
        Me.cmbvaccine.FormattingEnabled = True
        Me.cmbvaccine.Items.AddRange(New Object() {"AstraZeneca Vaccine", "BioNTech Vaccine", "Covaxin", "Johnson & Johnson Vaccine", "Moderna Vaccine", "Sinopharm", "Sinovac", "Sputnik Vaccine"})
        Me.cmbvaccine.Location = New System.Drawing.Point(174, 133)
        Me.cmbvaccine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbvaccine.Name = "cmbvaccine"
        Me.cmbvaccine.Size = New System.Drawing.Size(320, 31)
        Me.cmbvaccine.Sorted = True
        Me.cmbvaccine.TabIndex = 22
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.AliceBlue
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnsave.Font = New System.Drawing.Font("Comfortaa", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(75, 565)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(74, 36)
        Me.btnsave.TabIndex = 24
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.AliceBlue
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clear.Font = New System.Drawing.Font("Comfortaa", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(475, 565)
        Me.clear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(74, 36)
        Me.clear.TabIndex = 27
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'DataGridView
        '
        Me.DataGridView.BackgroundColor = System.Drawing.Color.LightCyan
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView.Location = New System.Drawing.Point(598, 173)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersWidth = 51
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(682, 368)
        Me.DataGridView.TabIndex = 28
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(506, 494)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(0, 17)
        Me.lbltotal.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(594, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1279, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 37)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(675, 570)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(208, 25)
        Me.TextBox1.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Comfortaa", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(603, 571)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 23)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Search ID"
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.AliceBlue
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnupdate.Font = New System.Drawing.Font("Comfortaa", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(206, 564)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 37)
        Me.btnupdate.TabIndex = 36
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AliceBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Comfortaa", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 564)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rawk Brush", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(479, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(468, 104)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Beat COVID -  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("NuevoDisco", 61.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(797, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 101)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "19"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Brush Script MT", 28.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(1045, 550)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(269, 59)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Get Vaccinated!"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Gray
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(47, 150)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(524, 207)
        Me.TextBox2.TabIndex = 41
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Gray
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(47, 363)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(524, 187)
        Me.TextBox3.TabIndex = 42
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1330, 622)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vaccination Info"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.DbvaccineDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VaccinatedlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbvaccineDataSet As dbvaccineDataSet
    Friend WithEvents VaccinatedlistBindingSource As BindingSource
    Friend WithEvents VaccinatedlistTableAdapter As dbvaccineDataSetTableAdapters.vaccinatedlistTableAdapter
    Friend WithEvents TableAdapterManager As dbvaccineDataSetTableAdapters.TableAdapterManager
    Friend WithEvents tbxID As TextBox
    Friend WithEvents tbxlastname As TextBox
    Friend WithEvents tbxfirstname As TextBox
    Friend WithEvents tbxmi As TextBox
    Friend WithEvents dtpbirthday As DateTimePicker
    Friend WithEvents cbfirstdose As CheckBox
    Friend WithEvents cbseconddose As CheckBox
    Friend WithEvents dtpfirstdose As DateTimePicker
    Friend WithEvents dtpseconddose As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbvaccine As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents clear As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
