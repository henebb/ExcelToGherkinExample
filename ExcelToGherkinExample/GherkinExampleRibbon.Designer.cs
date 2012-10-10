namespace ExcelToGherkinExample
{
    partial class GherkinExampleRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public GherkinExampleRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.CreateGherkinExample = this.Factory.CreateRibbonGroup();
            this.CreateGherkinExampleButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.CreateGherkinExample.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.CreateGherkinExample);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // CreateGherkinExample
            // 
            this.CreateGherkinExample.Items.Add(this.CreateGherkinExampleButton);
            this.CreateGherkinExample.Label = "Create Gherkin Exampl";
            this.CreateGherkinExample.Name = "CreateGherkinExample";
            // 
            // CreateGherkinExampleButton
            // 
            this.CreateGherkinExampleButton.Label = "Convert Selected Region";
            this.CreateGherkinExampleButton.Name = "CreateGherkinExampleButton";
            this.CreateGherkinExampleButton.ShowImage = true;
            this.CreateGherkinExampleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CreateGherkinExampleButtonClick);
            // 
            // GherkinExampleRibbon
            // 
            this.Name = "GherkinExampleRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.CreateGherkinExample.ResumeLayout(false);
            this.CreateGherkinExample.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup CreateGherkinExample;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CreateGherkinExampleButton;
    }

    partial class ThisRibbonCollection
    {
        internal GherkinExampleRibbon GherkinExampleRibbon
        {
            get { return this.GetRibbon<GherkinExampleRibbon>(); }
        }
    }
}
