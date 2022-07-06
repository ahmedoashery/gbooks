namespace gbooks
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainMenuBar = new DevExpress.XtraBars.BarManager(this.components);
            this.MainNavBar = new DevExpress.XtraBars.Bar();
            this.FileMenu = new DevExpress.XtraBars.BarSubItem();
            this.NewCompanySubMenuItem = new DevExpress.XtraBars.BarSubItem();
            this.NewCompanyFromFile = new DevExpress.XtraBars.BarSubItem();
            this.EditMenu = new DevExpress.XtraBars.BarSubItem();
            this.ViewMenu = new DevExpress.XtraBars.BarSubItem();
            this.ListsMenu = new DevExpress.XtraBars.BarSubItem();
            this.AccountsMenu = new DevExpress.XtraBars.BarSubItem();
            this.CompanyMenu = new DevExpress.XtraBars.BarSubItem();
            this.CustomersMenu = new DevExpress.XtraBars.BarSubItem();
            this.VendorsMenu = new DevExpress.XtraBars.BarSubItem();
            this.BankMenu = new DevExpress.XtraBars.BarSubItem();
            this.ReportsMenu = new DevExpress.XtraBars.BarSubItem();
            this.WindowMenu = new DevExpress.XtraBars.BarSubItem();
            this.HelpMenu = new DevExpress.XtraBars.BarSubItem();
            this.SkinMenu = new DevExpress.XtraBars.SkinBarSubItem();
            this.SkinPaletteMenu = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.MainDocumnetsContaier = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.MainNativeMDIView = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(this.components);
            this.homeDocument = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.Document(this.components);
            this.MainDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.MainDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barDockingMenuItem2 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocumnetsContaier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNativeMDIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDockManager)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.MainDockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuBar
            // 
            this.MainMenuBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.MainNavBar});
            this.MainMenuBar.DockControls.Add(this.barDockControlTop);
            this.MainMenuBar.DockControls.Add(this.barDockControlBottom);
            this.MainMenuBar.DockControls.Add(this.barDockControlLeft);
            this.MainMenuBar.DockControls.Add(this.barDockControlRight);
            this.MainMenuBar.Form = this;
            this.MainMenuBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDockingMenuItem1,
            this.FileMenu,
            this.EditMenu,
            this.ViewMenu,
            this.ListsMenu,
            this.AccountsMenu,
            this.CompanyMenu,
            this.CustomersMenu,
            this.VendorsMenu,
            this.BankMenu,
            this.ReportsMenu,
            this.WindowMenu,
            this.HelpMenu,
            this.SkinMenu,
            this.SkinPaletteMenu,
            this.NewCompanySubMenuItem,
            this.NewCompanyFromFile,
            this.barButtonItem1,
            this.barMdiChildrenListItem1,
            this.barDockingMenuItem2,
            this.barWorkspaceMenuItem1,
            this.barToolbarsListItem1});
            this.MainMenuBar.MainMenu = this.MainNavBar;
            this.MainMenuBar.MaxItemId = 31;
            // 
            // MainNavBar
            // 
            this.MainNavBar.BarName = "MainMenu";
            this.MainNavBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.MainNavBar.DockCol = 0;
            this.MainNavBar.DockRow = 0;
            this.MainNavBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MainNavBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.FileMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.ViewMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.ListsMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.AccountsMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.CompanyMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.CustomersMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.VendorsMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.BankMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.ReportsMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.WindowMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.HelpMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.SkinMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.SkinPaletteMenu)});
            this.MainNavBar.OptionsBar.UseWholeRow = true;
            this.MainNavBar.Text = "MainMenu";
            // 
            // FileMenu
            // 
            this.FileMenu.Caption = "ملف";
            this.FileMenu.Id = 8;
            this.FileMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.NewCompanySubMenuItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.NewCompanyFromFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barMdiChildrenListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDockingMenuItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barWorkspaceMenuItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barToolbarsListItem1)});
            this.FileMenu.Name = "FileMenu";
            // 
            // NewCompanySubMenuItem
            // 
            this.NewCompanySubMenuItem.Caption = "شركة جديدة";
            this.NewCompanySubMenuItem.Id = 24;
            this.NewCompanySubMenuItem.Name = "NewCompanySubMenuItem";
            // 
            // NewCompanyFromFile
            // 
            this.NewCompanyFromFile.Caption = "شركة جديدة من ملف موجود";
            this.NewCompanyFromFile.Id = 25;
            this.NewCompanyFromFile.Name = "NewCompanyFromFile";
            // 
            // EditMenu
            // 
            this.EditMenu.Caption = "تعديل";
            this.EditMenu.Id = 9;
            this.EditMenu.Name = "EditMenu";
            // 
            // ViewMenu
            // 
            this.ViewMenu.Caption = "عرض";
            this.ViewMenu.Id = 10;
            this.ViewMenu.Name = "ViewMenu";
            // 
            // ListsMenu
            // 
            this.ListsMenu.Caption = "قوائم";
            this.ListsMenu.Id = 11;
            this.ListsMenu.Name = "ListsMenu";
            // 
            // AccountsMenu
            // 
            this.AccountsMenu.Caption = "حسابات";
            this.AccountsMenu.Id = 13;
            this.AccountsMenu.Name = "AccountsMenu";
            // 
            // CompanyMenu
            // 
            this.CompanyMenu.Caption = "شركة";
            this.CompanyMenu.Id = 14;
            this.CompanyMenu.Name = "CompanyMenu";
            // 
            // CustomersMenu
            // 
            this.CustomersMenu.Caption = "عملاء";
            this.CustomersMenu.Id = 15;
            this.CustomersMenu.Name = "CustomersMenu";
            // 
            // VendorsMenu
            // 
            this.VendorsMenu.Caption = "موردين";
            this.VendorsMenu.Id = 16;
            this.VendorsMenu.Name = "VendorsMenu";
            // 
            // BankMenu
            // 
            this.BankMenu.Caption = "بنوك";
            this.BankMenu.Id = 18;
            this.BankMenu.Name = "BankMenu";
            // 
            // ReportsMenu
            // 
            this.ReportsMenu.Caption = "تقارير";
            this.ReportsMenu.Id = 19;
            this.ReportsMenu.Name = "ReportsMenu";
            // 
            // WindowMenu
            // 
            this.WindowMenu.Caption = "نوافذ";
            this.WindowMenu.Id = 20;
            this.WindowMenu.Name = "WindowMenu";
            // 
            // HelpMenu
            // 
            this.HelpMenu.Caption = "مساعدة!";
            this.HelpMenu.Id = 21;
            this.HelpMenu.Name = "HelpMenu";
            // 
            // SkinMenu
            // 
            this.SkinMenu.Caption = "تصميم";
            this.SkinMenu.Id = 22;
            this.SkinMenu.Name = "SkinMenu";
            // 
            // SkinPaletteMenu
            // 
            this.SkinPaletteMenu.Enabled = false;
            this.SkinPaletteMenu.Id = 23;
            this.SkinPaletteMenu.Name = "SkinPaletteMenu";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainMenuBar;
            this.barDockControlTop.Size = new System.Drawing.Size(796, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 422);
            this.barDockControlBottom.Manager = this.MainMenuBar;
            this.barDockControlBottom.Size = new System.Drawing.Size(796, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.MainMenuBar;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(796, 24);
            this.barDockControlRight.Manager = this.MainMenuBar;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 398);
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "Window";
            this.barDockingMenuItem1.Id = 7;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // MainDocumnetsContaier
            // 
            this.MainDocumnetsContaier.ContainerControl = this;
            this.MainDocumnetsContaier.MenuManager = this.MainMenuBar;
            this.MainDocumnetsContaier.View = this.MainNativeMDIView;
            this.MainDocumnetsContaier.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.MainNativeMDIView});
            // 
            // MainNativeMDIView
            // 
            this.MainNativeMDIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.homeDocument});
            // 
            // homeDocument
            // 
            this.homeDocument.Bounds = new System.Drawing.Rectangle(0, 0, 596, 400);
            this.homeDocument.Caption = "الرئيسية";
            this.homeDocument.ControlName = "Home";
            this.homeDocument.ControlTypeName = "gbooks.Views.Home";
            // 
            // MainDockManager
            // 
            this.MainDockManager.Form = this;
            this.MainDockManager.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.MainDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.MainDockPanel});
            this.MainDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel2.ID = new System.Guid("98ae61c7-37c9-43be-aa8c-fd58ebebe1bd");
            this.dockPanel2.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedIndex = 1;
            this.dockPanel2.Size = new System.Drawing.Size(200, 200);
            this.dockPanel2.Text = "dockPanel2";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // MainDockPanel
            // 
            this.MainDockPanel.Controls.Add(this.dockPanel1_Container);
            this.MainDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.MainDockPanel.ID = new System.Guid("629b84e8-b2e3-4669-a255-a6a09a711686");
            this.MainDockPanel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("MainDockPanel.ImageOptions.SvgImage")));
            this.MainDockPanel.Location = new System.Drawing.Point(596, 24);
            this.MainDockPanel.Name = "MainDockPanel";
            this.MainDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.MainDockPanel.Size = new System.Drawing.Size(200, 398);
            this.MainDockPanel.Text = "روابط سريعة";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 371);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 26;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 27;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barDockingMenuItem2
            // 
            this.barDockingMenuItem2.Caption = "barDockingMenuItem2";
            this.barDockingMenuItem2.Id = 28;
            this.barDockingMenuItem2.Name = "barDockingMenuItem2";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 29;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 30;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 422);
            this.Controls.Add(this.MainDockPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Gbooks Accounting Software";
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDocumnetsContaier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNativeMDIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDockManager)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.MainDockPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager MainMenuBar;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockPanel MainDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager MainDocumnetsContaier;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView MainNativeMDIView;
        private DevExpress.XtraBars.Docking.DockManager MainDockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.BarSubItem FileMenu;
        private DevExpress.XtraBars.BarSubItem EditMenu;
        private DevExpress.XtraBars.BarSubItem ViewMenu;
        private DevExpress.XtraBars.BarSubItem ListsMenu;
        private DevExpress.XtraBars.BarSubItem AccountsMenu;
        private DevExpress.XtraBars.BarSubItem CompanyMenu;
        private DevExpress.XtraBars.BarSubItem CustomersMenu;
        private DevExpress.XtraBars.BarSubItem VendorsMenu;
        private DevExpress.XtraBars.BarSubItem BankMenu;
        private DevExpress.XtraBars.BarSubItem ReportsMenu;
        private DevExpress.XtraBars.BarSubItem WindowMenu;
        private DevExpress.XtraBars.BarSubItem HelpMenu;
        private DevExpress.XtraBars.Bar MainNavBar;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.Document Home;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.Document homeDocument;
        private DevExpress.XtraBars.SkinBarSubItem SkinMenu;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem SkinPaletteMenu;
        private DevExpress.XtraBars.BarSubItem NewCompanySubMenuItem;
        private DevExpress.XtraBars.BarSubItem NewCompanyFromFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarDockingMenuItem barDockingMenuItem2;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
    }
}

