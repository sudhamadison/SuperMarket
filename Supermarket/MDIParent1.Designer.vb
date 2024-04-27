<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProductInformatioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchasedProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnedProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewBillsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ChangePasswordToolStripMenuItem, Me.EditProductInformatioToolStripMenuItem, Me.EditCustomerInformationToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(55, 20)
        Me.FileMenu.Text = "Admin"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(189, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'EditProductInformatioToolStripMenuItem
        '
        Me.EditProductInformatioToolStripMenuItem.Name = "EditProductInformatioToolStripMenuItem"
        Me.EditProductInformatioToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EditProductInformatioToolStripMenuItem.Text = "Dealer Information"
        '
        'EditCustomerInformationToolStripMenuItem
        '
        Me.EditCustomerInformationToolStripMenuItem.Name = "EditCustomerInformationToolStripMenuItem"
        Me.EditCustomerInformationToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.EditCustomerInformationToolStripMenuItem.Text = "Customer Information"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchasedProductsToolStripMenuItem, Me.ReturnProductsToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(66, 20)
        Me.EditMenu.Text = "Products"
        '
        'PurchasedProductsToolStripMenuItem
        '
        Me.PurchasedProductsToolStripMenuItem.Name = "PurchasedProductsToolStripMenuItem"
        Me.PurchasedProductsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.PurchasedProductsToolStripMenuItem.Text = "Purchase products"
        '
        'ReturnProductsToolStripMenuItem
        '
        Me.ReturnProductsToolStripMenuItem.Name = "ReturnProductsToolStripMenuItem"
        Me.ReturnProductsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ReturnProductsToolStripMenuItem.Text = "Purchase Return"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.ReturnedProductsToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(45, 20)
        Me.ViewMenu.Text = "Sales"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ReturnedProductsToolStripMenuItem
        '
        Me.ReturnedProductsToolStripMenuItem.Name = "ReturnedProductsToolStripMenuItem"
        Me.ReturnedProductsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReturnedProductsToolStripMenuItem.Text = "Sales Return"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(53, 20)
        Me.ToolsMenu.Text = "Stocks"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "Update Stock"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewBillsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(52, 20)
        Me.WindowsMenu.Text = "Billing"
        '
        'ViewBillsToolStripMenuItem
        '
        Me.ViewBillsToolStripMenuItem.Name = "ViewBillsToolStripMenuItem"
        Me.ViewBillsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewBillsToolStripMenuItem.Text = "View Bills"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(59, 20)
        Me.HelpMenu.Text = "Reports"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(57, 6)
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProductInformatioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerInformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PurchasedProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnedProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewBillsToolStripMenuItem As ToolStripMenuItem
End Class
