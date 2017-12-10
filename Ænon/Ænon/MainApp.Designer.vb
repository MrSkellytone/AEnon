<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dev = New System.Windows.Forms.ComboBox()
        Me.model = New System.Windows.Forms.ComboBox()
        Me.vers = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rootfs = New System.Windows.Forms.Label()
        Me.ramdsk = New System.Windows.Forms.Label()
        Me.rramdsk = New System.Windows.Forms.Label()
        Me.applelogo = New System.Windows.Forms.Label()
        Me.batchar0 = New System.Windows.Forms.Label()
        Me.recovery = New System.Windows.Forms.Label()
        Me.kernel = New System.Windows.Forms.Label()
        Me.devtree = New System.Windows.Forms.Label()
        Me.iboot = New System.Windows.Forms.Label()
        Me.batchar1 = New System.Windows.Forms.Label()
        Me.batlow0 = New System.Windows.Forms.Label()
        Me.batfull = New System.Windows.Forms.Label()
        Me.ibec = New System.Windows.Forms.Label()
        Me.batlow1 = New System.Windows.Forms.Label()
        Me.ibss = New System.Windows.Forms.Label()
        Me.llb = New System.Windows.Forms.Label()
        Me.glphchar = New System.Windows.Forms.Label()
        Me.glphplug = New System.Windows.Forms.Label()
        Me.RFkey = New System.Windows.Forms.TextBox()
        Me.URAMkey = New System.Windows.Forms.TextBox()
        Me.RRkey = New System.Windows.Forms.TextBox()
        Me.BL1key = New System.Windows.Forms.TextBox()
        Me.DTkey = New System.Windows.Forms.TextBox()
        Me.GCkey = New System.Windows.Forms.TextBox()
        Me.ALkey = New System.Windows.Forms.TextBox()
        Me.BC0key = New System.Windows.Forms.TextBox()
        Me.BL0key = New System.Windows.Forms.TextBox()
        Me.BFkey = New System.Windows.Forms.TextBox()
        Me.BC1key = New System.Windows.Forms.TextBox()
        Me.GPkey = New System.Windows.Forms.TextBox()
        Me.RMkey = New System.Windows.Forms.TextBox()
        Me.LLBkey = New System.Windows.Forms.TextBox()
        Me.KCkey = New System.Windows.Forms.TextBox()
        Me.BSSkey = New System.Windows.Forms.TextBox()
        Me.BOOTkey = New System.Windows.Forms.TextBox()
        Me.BECkey = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BL1iv = New System.Windows.Forms.TextBox()
        Me.BL0iv = New System.Windows.Forms.TextBox()
        Me.URAMiv = New System.Windows.Forms.TextBox()
        Me.RRiv = New System.Windows.Forms.TextBox()
        Me.BFiv = New System.Windows.Forms.TextBox()
        Me.BECiv = New System.Windows.Forms.TextBox()
        Me.BOOTiv = New System.Windows.Forms.TextBox()
        Me.BSSiv = New System.Windows.Forms.TextBox()
        Me.DTiv = New System.Windows.Forms.TextBox()
        Me.ALiv = New System.Windows.Forms.TextBox()
        Me.KCiv = New System.Windows.Forms.TextBox()
        Me.BC0iv = New System.Windows.Forms.TextBox()
        Me.GCiv = New System.Windows.Forms.TextBox()
        Me.LLBiv = New System.Windows.Forms.TextBox()
        Me.GPiv = New System.Windows.Forms.TextBox()
        Me.RMiv = New System.Windows.Forms.TextBox()
        Me.BC1iv = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the device and iOS version to get your keys."
        '
        'dev
        '
        Me.dev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dev.FormattingEnabled = True
        Me.dev.Items.AddRange(New Object() {"iPhone", "iPad", "iPad Mini", "iPod touch"})
        Me.dev.Location = New System.Drawing.Point(17, 38)
        Me.dev.Name = "dev"
        Me.dev.Size = New System.Drawing.Size(152, 21)
        Me.dev.TabIndex = 1
        '
        'model
        '
        Me.model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.model.FormattingEnabled = True
        Me.model.Location = New System.Drawing.Point(175, 38)
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(152, 21)
        Me.model.TabIndex = 2
        '
        'vers
        '
        Me.vers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.vers.FormattingEnabled = True
        Me.vers.Location = New System.Drawing.Point(333, 38)
        Me.vers.Name = "vers"
        Me.vers.Size = New System.Drawing.Size(152, 21)
        Me.vers.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Reveal keys"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label2.Location = New System.Drawing.Point(305, 495)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Made by @MrSkellytone and @AaroniusLeonius "
        '
        'rootfs
        '
        Me.rootfs.AutoSize = True
        Me.rootfs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootfs.Location = New System.Drawing.Point(12, 62)
        Me.rootfs.Name = "rootfs"
        Me.rootfs.Size = New System.Drawing.Size(138, 20)
        Me.rootfs.TabIndex = 6
        Me.rootfs.Text = "Root Filesystem"
        Me.rootfs.Visible = False
        '
        'ramdsk
        '
        Me.ramdsk.AutoSize = True
        Me.ramdsk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ramdsk.Location = New System.Drawing.Point(13, 129)
        Me.ramdsk.Name = "ramdsk"
        Me.ramdsk.Size = New System.Drawing.Size(142, 20)
        Me.ramdsk.TabIndex = 7
        Me.ramdsk.Text = "Update Ramdisk"
        Me.ramdsk.Visible = False
        '
        'rramdsk
        '
        Me.rramdsk.AutoSize = True
        Me.rramdsk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rramdsk.Location = New System.Drawing.Point(12, 201)
        Me.rramdsk.Name = "rramdsk"
        Me.rramdsk.Size = New System.Drawing.Size(147, 20)
        Me.rramdsk.TabIndex = 8
        Me.rramdsk.Text = "Restore Ramdisk"
        Me.rramdsk.Visible = False
        '
        'applelogo
        '
        Me.applelogo.AutoSize = True
        Me.applelogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.applelogo.Location = New System.Drawing.Point(12, 268)
        Me.applelogo.Name = "applelogo"
        Me.applelogo.Size = New System.Drawing.Size(95, 20)
        Me.applelogo.TabIndex = 9
        Me.applelogo.Text = "AppleLogo"
        Me.applelogo.Visible = False
        '
        'batchar0
        '
        Me.batchar0.AutoSize = True
        Me.batchar0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchar0.Location = New System.Drawing.Point(12, 340)
        Me.batchar0.Name = "batchar0"
        Me.batchar0.Size = New System.Drawing.Size(149, 20)
        Me.batchar0.TabIndex = 10
        Me.batchar0.Text = "BatteryCharging0"
        Me.batchar0.Visible = False
        '
        'recovery
        '
        Me.recovery.AutoSize = True
        Me.recovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recovery.Location = New System.Drawing.Point(585, 420)
        Me.recovery.Name = "recovery"
        Me.recovery.Size = New System.Drawing.Size(127, 20)
        Me.recovery.TabIndex = 11
        Me.recovery.Text = "RecoveryMode"
        Me.recovery.Visible = False
        '
        'kernel
        '
        Me.kernel.AutoSize = True
        Me.kernel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kernel.Location = New System.Drawing.Point(583, 268)
        Me.kernel.Name = "kernel"
        Me.kernel.Size = New System.Drawing.Size(111, 20)
        Me.kernel.TabIndex = 12
        Me.kernel.Text = "KernelCache"
        Me.kernel.Visible = False
        '
        'devtree
        '
        Me.devtree.AutoSize = True
        Me.devtree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.devtree.Location = New System.Drawing.Point(308, 268)
        Me.devtree.Name = "devtree"
        Me.devtree.Size = New System.Drawing.Size(99, 20)
        Me.devtree.TabIndex = 13
        Me.devtree.Text = "DeviceTree"
        Me.devtree.Visible = False
        '
        'iboot
        '
        Me.iboot.AutoSize = True
        Me.iboot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iboot.Location = New System.Drawing.Point(583, 129)
        Me.iboot.Name = "iboot"
        Me.iboot.Size = New System.Drawing.Size(51, 20)
        Me.iboot.TabIndex = 14
        Me.iboot.Text = "iBoot"
        Me.iboot.Visible = False
        '
        'batchar1
        '
        Me.batchar1.AutoSize = True
        Me.batchar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batchar1.Location = New System.Drawing.Point(12, 420)
        Me.batchar1.Name = "batchar1"
        Me.batchar1.Size = New System.Drawing.Size(149, 20)
        Me.batchar1.TabIndex = 15
        Me.batchar1.Text = "BatteryCharging1"
        Me.batchar1.Visible = False
        '
        'batlow0
        '
        Me.batlow0.AutoSize = True
        Me.batlow0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batlow0.Location = New System.Drawing.Point(308, 129)
        Me.batlow0.Name = "batlow0"
        Me.batlow0.Size = New System.Drawing.Size(109, 20)
        Me.batlow0.TabIndex = 16
        Me.batlow0.Text = "BatteryLow0"
        Me.batlow0.Visible = False
        '
        'batfull
        '
        Me.batfull.AutoSize = True
        Me.batfull.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batfull.Location = New System.Drawing.Point(317, 62)
        Me.batfull.Name = "batfull"
        Me.batfull.Size = New System.Drawing.Size(96, 20)
        Me.batfull.TabIndex = 17
        Me.batfull.Text = "BatteryFull"
        Me.batfull.Visible = False
        '
        'ibec
        '
        Me.ibec.AutoSize = True
        Me.ibec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibec.Location = New System.Drawing.Point(585, 62)
        Me.ibec.Name = "ibec"
        Me.ibec.Size = New System.Drawing.Size(49, 20)
        Me.ibec.TabIndex = 18
        Me.ibec.Text = "iBEC"
        Me.ibec.Visible = False
        '
        'batlow1
        '
        Me.batlow1.AutoSize = True
        Me.batlow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.batlow1.Location = New System.Drawing.Point(308, 201)
        Me.batlow1.Name = "batlow1"
        Me.batlow1.Size = New System.Drawing.Size(109, 20)
        Me.batlow1.TabIndex = 19
        Me.batlow1.Text = "BatteryLow1"
        Me.batlow1.Visible = False
        '
        'ibss
        '
        Me.ibss.AutoSize = True
        Me.ibss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ibss.Location = New System.Drawing.Point(585, 201)
        Me.ibss.Name = "ibss"
        Me.ibss.Size = New System.Drawing.Size(49, 20)
        Me.ibss.TabIndex = 20
        Me.ibss.Text = "iBSS"
        Me.ibss.Visible = False
        '
        'llb
        '
        Me.llb.AutoSize = True
        Me.llb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llb.Location = New System.Drawing.Point(585, 348)
        Me.llb.Name = "llb"
        Me.llb.Size = New System.Drawing.Size(41, 20)
        Me.llb.TabIndex = 21
        Me.llb.Text = "LLB"
        Me.llb.Visible = False
        '
        'glphchar
        '
        Me.glphchar.AutoSize = True
        Me.glphchar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glphchar.Location = New System.Drawing.Point(308, 340)
        Me.glphchar.Name = "glphchar"
        Me.glphchar.Size = New System.Drawing.Size(127, 20)
        Me.glphchar.TabIndex = 22
        Me.glphchar.Text = "GlyphCharging"
        Me.glphchar.Visible = False
        '
        'glphplug
        '
        Me.glphplug.AutoSize = True
        Me.glphplug.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.glphplug.Location = New System.Drawing.Point(308, 420)
        Me.glphplug.Name = "glphplug"
        Me.glphplug.Size = New System.Drawing.Size(104, 20)
        Me.glphplug.TabIndex = 23
        Me.glphplug.Text = "GlyphPlugin"
        Me.glphplug.Visible = False
        '
        'RFkey
        '
        Me.RFkey.Location = New System.Drawing.Point(12, 85)
        Me.RFkey.Name = "RFkey"
        Me.RFkey.ReadOnly = True
        Me.RFkey.Size = New System.Drawing.Size(269, 20)
        Me.RFkey.TabIndex = 24
        Me.RFkey.Visible = False
        '
        'URAMkey
        '
        Me.URAMkey.Location = New System.Drawing.Point(12, 152)
        Me.URAMkey.Name = "URAMkey"
        Me.URAMkey.ReadOnly = True
        Me.URAMkey.Size = New System.Drawing.Size(269, 20)
        Me.URAMkey.TabIndex = 25
        Me.URAMkey.Visible = False
        '
        'RRkey
        '
        Me.RRkey.Location = New System.Drawing.Point(12, 219)
        Me.RRkey.Name = "RRkey"
        Me.RRkey.ReadOnly = True
        Me.RRkey.Size = New System.Drawing.Size(269, 20)
        Me.RRkey.TabIndex = 26
        Me.RRkey.Visible = False
        '
        'BL1key
        '
        Me.BL1key.Location = New System.Drawing.Point(308, 219)
        Me.BL1key.Name = "BL1key"
        Me.BL1key.ReadOnly = True
        Me.BL1key.Size = New System.Drawing.Size(269, 20)
        Me.BL1key.TabIndex = 27
        Me.BL1key.Visible = False
        '
        'DTkey
        '
        Me.DTkey.Location = New System.Drawing.Point(308, 291)
        Me.DTkey.Name = "DTkey"
        Me.DTkey.ReadOnly = True
        Me.DTkey.Size = New System.Drawing.Size(269, 20)
        Me.DTkey.TabIndex = 28
        Me.DTkey.Visible = False
        '
        'GCkey
        '
        Me.GCkey.Location = New System.Drawing.Point(308, 371)
        Me.GCkey.Name = "GCkey"
        Me.GCkey.ReadOnly = True
        Me.GCkey.Size = New System.Drawing.Size(269, 20)
        Me.GCkey.TabIndex = 29
        Me.GCkey.Visible = False
        '
        'ALkey
        '
        Me.ALkey.Location = New System.Drawing.Point(12, 291)
        Me.ALkey.Name = "ALkey"
        Me.ALkey.ReadOnly = True
        Me.ALkey.Size = New System.Drawing.Size(269, 20)
        Me.ALkey.TabIndex = 30
        Me.ALkey.Visible = False
        '
        'BC0key
        '
        Me.BC0key.Location = New System.Drawing.Point(12, 371)
        Me.BC0key.Name = "BC0key"
        Me.BC0key.ReadOnly = True
        Me.BC0key.Size = New System.Drawing.Size(269, 20)
        Me.BC0key.TabIndex = 31
        Me.BC0key.Visible = False
        '
        'BL0key
        '
        Me.BL0key.Location = New System.Drawing.Point(308, 152)
        Me.BL0key.Name = "BL0key"
        Me.BL0key.ReadOnly = True
        Me.BL0key.Size = New System.Drawing.Size(269, 20)
        Me.BL0key.TabIndex = 32
        Me.BL0key.Visible = False
        '
        'BFkey
        '
        Me.BFkey.Location = New System.Drawing.Point(308, 85)
        Me.BFkey.Name = "BFkey"
        Me.BFkey.ReadOnly = True
        Me.BFkey.Size = New System.Drawing.Size(269, 20)
        Me.BFkey.TabIndex = 33
        Me.BFkey.Visible = False
        '
        'BC1key
        '
        Me.BC1key.Location = New System.Drawing.Point(12, 446)
        Me.BC1key.Name = "BC1key"
        Me.BC1key.ReadOnly = True
        Me.BC1key.Size = New System.Drawing.Size(269, 20)
        Me.BC1key.TabIndex = 34
        Me.BC1key.Visible = False
        '
        'GPkey
        '
        Me.GPkey.Location = New System.Drawing.Point(308, 446)
        Me.GPkey.Name = "GPkey"
        Me.GPkey.ReadOnly = True
        Me.GPkey.Size = New System.Drawing.Size(269, 20)
        Me.GPkey.TabIndex = 35
        Me.GPkey.Visible = False
        '
        'RMkey
        '
        Me.RMkey.Location = New System.Drawing.Point(589, 446)
        Me.RMkey.Name = "RMkey"
        Me.RMkey.ReadOnly = True
        Me.RMkey.Size = New System.Drawing.Size(269, 20)
        Me.RMkey.TabIndex = 36
        Me.RMkey.Visible = False
        '
        'LLBkey
        '
        Me.LLBkey.Location = New System.Drawing.Point(589, 371)
        Me.LLBkey.Name = "LLBkey"
        Me.LLBkey.ReadOnly = True
        Me.LLBkey.Size = New System.Drawing.Size(269, 20)
        Me.LLBkey.TabIndex = 37
        Me.LLBkey.Visible = False
        '
        'KCkey
        '
        Me.KCkey.Location = New System.Drawing.Point(587, 291)
        Me.KCkey.Name = "KCkey"
        Me.KCkey.ReadOnly = True
        Me.KCkey.Size = New System.Drawing.Size(269, 20)
        Me.KCkey.TabIndex = 38
        Me.KCkey.Visible = False
        '
        'BSSkey
        '
        Me.BSSkey.Location = New System.Drawing.Point(589, 219)
        Me.BSSkey.Name = "BSSkey"
        Me.BSSkey.ReadOnly = True
        Me.BSSkey.Size = New System.Drawing.Size(269, 20)
        Me.BSSkey.TabIndex = 39
        Me.BSSkey.Visible = False
        '
        'BOOTkey
        '
        Me.BOOTkey.Location = New System.Drawing.Point(587, 152)
        Me.BOOTkey.Name = "BOOTkey"
        Me.BOOTkey.ReadOnly = True
        Me.BOOTkey.Size = New System.Drawing.Size(269, 20)
        Me.BOOTkey.TabIndex = 40
        Me.BOOTkey.Visible = False
        '
        'BECkey
        '
        Me.BECkey.Location = New System.Drawing.Point(587, 85)
        Me.BECkey.Name = "BECkey"
        Me.BECkey.ReadOnly = True
        Me.BECkey.Size = New System.Drawing.Size(269, 20)
        Me.BECkey.TabIndex = 41
        Me.BECkey.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(727, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 31)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Credits"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BL1iv
        '
        Me.BL1iv.Location = New System.Drawing.Point(308, 245)
        Me.BL1iv.Name = "BL1iv"
        Me.BL1iv.ReadOnly = True
        Me.BL1iv.Size = New System.Drawing.Size(269, 20)
        Me.BL1iv.TabIndex = 44
        Me.BL1iv.Visible = False
        '
        'BL0iv
        '
        Me.BL0iv.Location = New System.Drawing.Point(308, 178)
        Me.BL0iv.Name = "BL0iv"
        Me.BL0iv.ReadOnly = True
        Me.BL0iv.Size = New System.Drawing.Size(269, 20)
        Me.BL0iv.TabIndex = 45
        Me.BL0iv.Visible = False
        '
        'URAMiv
        '
        Me.URAMiv.Location = New System.Drawing.Point(12, 178)
        Me.URAMiv.Name = "URAMiv"
        Me.URAMiv.ReadOnly = True
        Me.URAMiv.Size = New System.Drawing.Size(269, 20)
        Me.URAMiv.TabIndex = 46
        Me.URAMiv.Visible = False
        '
        'RRiv
        '
        Me.RRiv.Location = New System.Drawing.Point(12, 245)
        Me.RRiv.Name = "RRiv"
        Me.RRiv.ReadOnly = True
        Me.RRiv.Size = New System.Drawing.Size(269, 20)
        Me.RRiv.TabIndex = 47
        Me.RRiv.Visible = False
        '
        'BFiv
        '
        Me.BFiv.Location = New System.Drawing.Point(308, 106)
        Me.BFiv.Name = "BFiv"
        Me.BFiv.ReadOnly = True
        Me.BFiv.Size = New System.Drawing.Size(269, 20)
        Me.BFiv.TabIndex = 48
        Me.BFiv.Visible = False
        '
        'BECiv
        '
        Me.BECiv.Location = New System.Drawing.Point(587, 106)
        Me.BECiv.Name = "BECiv"
        Me.BECiv.ReadOnly = True
        Me.BECiv.Size = New System.Drawing.Size(269, 20)
        Me.BECiv.TabIndex = 49
        Me.BECiv.Visible = False
        '
        'BOOTiv
        '
        Me.BOOTiv.Location = New System.Drawing.Point(587, 178)
        Me.BOOTiv.Name = "BOOTiv"
        Me.BOOTiv.ReadOnly = True
        Me.BOOTiv.Size = New System.Drawing.Size(269, 20)
        Me.BOOTiv.TabIndex = 50
        Me.BOOTiv.Visible = False
        '
        'BSSiv
        '
        Me.BSSiv.Location = New System.Drawing.Point(589, 245)
        Me.BSSiv.Name = "BSSiv"
        Me.BSSiv.ReadOnly = True
        Me.BSSiv.Size = New System.Drawing.Size(269, 20)
        Me.BSSiv.TabIndex = 51
        Me.BSSiv.Visible = False
        '
        'DTiv
        '
        Me.DTiv.Location = New System.Drawing.Point(308, 317)
        Me.DTiv.Name = "DTiv"
        Me.DTiv.ReadOnly = True
        Me.DTiv.Size = New System.Drawing.Size(269, 20)
        Me.DTiv.TabIndex = 52
        Me.DTiv.Visible = False
        '
        'ALiv
        '
        Me.ALiv.Location = New System.Drawing.Point(12, 317)
        Me.ALiv.Name = "ALiv"
        Me.ALiv.ReadOnly = True
        Me.ALiv.Size = New System.Drawing.Size(269, 20)
        Me.ALiv.TabIndex = 53
        Me.ALiv.Visible = False
        '
        'KCiv
        '
        Me.KCiv.Location = New System.Drawing.Point(587, 317)
        Me.KCiv.Name = "KCiv"
        Me.KCiv.ReadOnly = True
        Me.KCiv.Size = New System.Drawing.Size(269, 20)
        Me.KCiv.TabIndex = 54
        Me.KCiv.Visible = False
        '
        'BC0iv
        '
        Me.BC0iv.Location = New System.Drawing.Point(12, 397)
        Me.BC0iv.Name = "BC0iv"
        Me.BC0iv.ReadOnly = True
        Me.BC0iv.Size = New System.Drawing.Size(269, 20)
        Me.BC0iv.TabIndex = 55
        Me.BC0iv.Visible = False
        '
        'GCiv
        '
        Me.GCiv.Location = New System.Drawing.Point(308, 397)
        Me.GCiv.Name = "GCiv"
        Me.GCiv.ReadOnly = True
        Me.GCiv.Size = New System.Drawing.Size(269, 20)
        Me.GCiv.TabIndex = 56
        Me.GCiv.Visible = False
        '
        'LLBiv
        '
        Me.LLBiv.Location = New System.Drawing.Point(589, 397)
        Me.LLBiv.Name = "LLBiv"
        Me.LLBiv.ReadOnly = True
        Me.LLBiv.Size = New System.Drawing.Size(269, 20)
        Me.LLBiv.TabIndex = 57
        Me.LLBiv.Visible = False
        '
        'GPiv
        '
        Me.GPiv.Location = New System.Drawing.Point(308, 472)
        Me.GPiv.Name = "GPiv"
        Me.GPiv.ReadOnly = True
        Me.GPiv.Size = New System.Drawing.Size(269, 20)
        Me.GPiv.TabIndex = 58
        Me.GPiv.Visible = False
        '
        'RMiv
        '
        Me.RMiv.Location = New System.Drawing.Point(589, 472)
        Me.RMiv.Name = "RMiv"
        Me.RMiv.ReadOnly = True
        Me.RMiv.Size = New System.Drawing.Size(269, 20)
        Me.RMiv.TabIndex = 59
        Me.RMiv.Visible = False
        '
        'BC1iv
        '
        Me.BC1iv.Location = New System.Drawing.Point(12, 472)
        Me.BC1iv.Name = "BC1iv"
        Me.BC1iv.ReadOnly = True
        Me.BC1iv.Size = New System.Drawing.Size(269, 20)
        Me.BC1iv.TabIndex = 60
        Me.BC1iv.Text = "l"
        Me.BC1iv.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Key - top ; IV - down"
        Me.Label3.Visible = False
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 512)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BC1iv)
        Me.Controls.Add(Me.RMiv)
        Me.Controls.Add(Me.GPiv)
        Me.Controls.Add(Me.LLBiv)
        Me.Controls.Add(Me.GCiv)
        Me.Controls.Add(Me.BC0iv)
        Me.Controls.Add(Me.KCiv)
        Me.Controls.Add(Me.ALiv)
        Me.Controls.Add(Me.DTiv)
        Me.Controls.Add(Me.BSSiv)
        Me.Controls.Add(Me.BOOTiv)
        Me.Controls.Add(Me.BECiv)
        Me.Controls.Add(Me.BFiv)
        Me.Controls.Add(Me.RRiv)
        Me.Controls.Add(Me.URAMiv)
        Me.Controls.Add(Me.BL0iv)
        Me.Controls.Add(Me.BL1iv)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BECkey)
        Me.Controls.Add(Me.BOOTkey)
        Me.Controls.Add(Me.BSSkey)
        Me.Controls.Add(Me.KCkey)
        Me.Controls.Add(Me.LLBkey)
        Me.Controls.Add(Me.RMkey)
        Me.Controls.Add(Me.GPkey)
        Me.Controls.Add(Me.BC1key)
        Me.Controls.Add(Me.BFkey)
        Me.Controls.Add(Me.BL0key)
        Me.Controls.Add(Me.BC0key)
        Me.Controls.Add(Me.ALkey)
        Me.Controls.Add(Me.GCkey)
        Me.Controls.Add(Me.DTkey)
        Me.Controls.Add(Me.BL1key)
        Me.Controls.Add(Me.RRkey)
        Me.Controls.Add(Me.URAMkey)
        Me.Controls.Add(Me.RFkey)
        Me.Controls.Add(Me.glphplug)
        Me.Controls.Add(Me.glphchar)
        Me.Controls.Add(Me.llb)
        Me.Controls.Add(Me.ibss)
        Me.Controls.Add(Me.batlow1)
        Me.Controls.Add(Me.ibec)
        Me.Controls.Add(Me.batfull)
        Me.Controls.Add(Me.batlow0)
        Me.Controls.Add(Me.batchar1)
        Me.Controls.Add(Me.iboot)
        Me.Controls.Add(Me.devtree)
        Me.Controls.Add(Me.kernel)
        Me.Controls.Add(Me.recovery)
        Me.Controls.Add(Me.batchar0)
        Me.Controls.Add(Me.applelogo)
        Me.Controls.Add(Me.rramdsk)
        Me.Controls.Add(Me.ramdsk)
        Me.Controls.Add(Me.rootfs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.vers)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.dev)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainApp"
        Me.Text = "Ænon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dev As ComboBox
    Friend WithEvents model As ComboBox
    Friend WithEvents vers As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rootfs As Label
    Friend WithEvents ramdsk As Label
    Friend WithEvents rramdsk As Label
    Friend WithEvents applelogo As Label
    Friend WithEvents batchar0 As Label
    Friend WithEvents recovery As Label
    Friend WithEvents kernel As Label
    Friend WithEvents devtree As Label
    Friend WithEvents iboot As Label
    Friend WithEvents batchar1 As Label
    Friend WithEvents batlow0 As Label
    Friend WithEvents batfull As Label
    Friend WithEvents ibec As Label
    Friend WithEvents batlow1 As Label
    Friend WithEvents ibss As Label
    Friend WithEvents llb As Label
    Friend WithEvents glphchar As Label
    Friend WithEvents glphplug As Label
    Friend WithEvents RFkey As TextBox
    Friend WithEvents URAMkey As TextBox
    Friend WithEvents RRkey As TextBox
    Friend WithEvents BL1key As TextBox
    Friend WithEvents DTkey As TextBox
    Friend WithEvents GCkey As TextBox
    Friend WithEvents ALkey As TextBox
    Friend WithEvents BC0key As TextBox
    Friend WithEvents BL0key As TextBox
    Friend WithEvents BFkey As TextBox
    Friend WithEvents BC1key As TextBox
    Friend WithEvents GPkey As TextBox
    Friend WithEvents RMkey As TextBox
    Friend WithEvents LLBkey As TextBox
    Friend WithEvents KCkey As TextBox
    Friend WithEvents BSSkey As TextBox
    Friend WithEvents BOOTkey As TextBox
    Friend WithEvents BECkey As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BL1iv As TextBox
    Friend WithEvents BL0iv As TextBox
    Friend WithEvents URAMiv As TextBox
    Friend WithEvents RRiv As TextBox
    Friend WithEvents BFiv As TextBox
    Friend WithEvents BECiv As TextBox
    Friend WithEvents BOOTiv As TextBox
    Friend WithEvents BSSiv As TextBox
    Friend WithEvents DTiv As TextBox
    Friend WithEvents ALiv As TextBox
    Friend WithEvents KCiv As TextBox
    Friend WithEvents BC0iv As TextBox
    Friend WithEvents GCiv As TextBox
    Friend WithEvents LLBiv As TextBox
    Friend WithEvents GPiv As TextBox
    Friend WithEvents RMiv As TextBox
    Friend WithEvents BC1iv As TextBox
    Friend WithEvents Label3 As Label
End Class
