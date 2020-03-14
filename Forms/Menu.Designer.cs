namespace AutoClicker
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.QuedActions = new System.Windows.Forms.ListView();
            this.InputHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelayHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepeatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.AddBTN = new System.Windows.Forms.Button();
            this.InputSelect = new System.Windows.Forms.ComboBox();
            this.MouseBOX = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CustomMouseBTN = new System.Windows.Forms.RadioButton();
            this.YposLBL = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CurrentMouseBTN = new System.Windows.Forms.RadioButton();
            this.XposLBL = new System.Windows.Forms.Label();
            this.HoursTBX = new System.Windows.Forms.TextBox();
            this.MinsTBX = new System.Windows.Forms.TextBox();
            this.HoursLBL = new System.Windows.Forms.Label();
            this.DelayBOX = new System.Windows.Forms.GroupBox();
            this.msTBX = new System.Windows.Forms.TextBox();
            this.secTBX = new System.Windows.Forms.TextBox();
            this.MSLBL = new System.Windows.Forms.Label();
            this.SecondsLBL = new System.Windows.Forms.Label();
            this.MinsLBL = new System.Windows.Forms.Label();
            this.RecordBTN = new System.Windows.Forms.Button();
            this.SelectedTBX = new System.Windows.Forms.TextBox();
            this.KeycodeTBX = new System.Windows.Forms.TextBox();
            this.TestBTN = new System.Windows.Forms.Button();
            this.MouseBOX.SuspendLayout();
            this.DelayBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuedActions
            // 
            this.QuedActions.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            resources.ApplyResources(this.QuedActions, "QuedActions");
            this.QuedActions.AutoArrange = false;
            this.QuedActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuedActions.CausesValidation = false;
            this.QuedActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InputHeader,
            this.PositionHeader,
            this.DelayHeader,
            this.RepeatHeader,
            this.KeyCodeHeader});
            this.QuedActions.FullRowSelect = true;
            this.QuedActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.QuedActions.HideSelection = false;
            this.QuedActions.Name = "QuedActions";
            this.QuedActions.UseCompatibleStateImageBehavior = false;
            this.QuedActions.View = System.Windows.Forms.View.Details;
            // 
            // InputHeader
            // 
            resources.ApplyResources(this.InputHeader, "InputHeader");
            // 
            // PositionHeader
            // 
            resources.ApplyResources(this.PositionHeader, "PositionHeader");
            // 
            // DelayHeader
            // 
            resources.ApplyResources(this.DelayHeader, "DelayHeader");
            // 
            // RepeatHeader
            // 
            resources.ApplyResources(this.RepeatHeader, "RepeatHeader");
            // 
            // KeyCodeHeader
            // 
            resources.ApplyResources(this.KeyCodeHeader, "KeyCodeHeader");
            // 
            // Delay
            // 
            this.Delay.Interval = 5000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // AddBTN
            // 
            resources.ApplyResources(this.AddBTN, "AddBTN");
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // InputSelect
            // 
            this.InputSelect.CausesValidation = false;
            resources.ApplyResources(this.InputSelect, "InputSelect");
            this.InputSelect.FormattingEnabled = true;
            this.InputSelect.Items.AddRange(new object[] {
            resources.GetString("InputSelect.Items"),
            resources.GetString("InputSelect.Items1"),
            resources.GetString("InputSelect.Items2"),
            resources.GetString("InputSelect.Items3"),
            resources.GetString("InputSelect.Items4")});
            this.InputSelect.Name = "InputSelect";
            this.InputSelect.SelectedIndexChanged += new System.EventHandler(this.InputSelect_SelectedIndexChanged);
            // 
            // MouseBOX
            // 
            this.MouseBOX.Controls.Add(this.textBox3);
            this.MouseBOX.Controls.Add(this.CustomMouseBTN);
            this.MouseBOX.Controls.Add(this.YposLBL);
            this.MouseBOX.Controls.Add(this.textBox2);
            this.MouseBOX.Controls.Add(this.CurrentMouseBTN);
            this.MouseBOX.Controls.Add(this.XposLBL);
            resources.ApplyResources(this.MouseBOX, "MouseBOX");
            this.MouseBOX.Name = "MouseBOX";
            this.MouseBOX.TabStop = false;
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // CustomMouseBTN
            // 
            resources.ApplyResources(this.CustomMouseBTN, "CustomMouseBTN");
            this.CustomMouseBTN.Name = "CustomMouseBTN";
            this.CustomMouseBTN.TabStop = true;
            this.CustomMouseBTN.UseVisualStyleBackColor = true;
            // 
            // YposLBL
            // 
            resources.ApplyResources(this.YposLBL, "YposLBL");
            this.YposLBL.Name = "YposLBL";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // CurrentMouseBTN
            // 
            resources.ApplyResources(this.CurrentMouseBTN, "CurrentMouseBTN");
            this.CurrentMouseBTN.Name = "CurrentMouseBTN";
            this.CurrentMouseBTN.TabStop = true;
            this.CurrentMouseBTN.UseVisualStyleBackColor = true;
            // 
            // XposLBL
            // 
            resources.ApplyResources(this.XposLBL, "XposLBL");
            this.XposLBL.Name = "XposLBL";
            // 
            // HoursTBX
            // 
            resources.ApplyResources(this.HoursTBX, "HoursTBX");
            this.HoursTBX.Name = "HoursTBX";
            // 
            // MinsTBX
            // 
            resources.ApplyResources(this.MinsTBX, "MinsTBX");
            this.MinsTBX.Name = "MinsTBX";
            // 
            // HoursLBL
            // 
            resources.ApplyResources(this.HoursLBL, "HoursLBL");
            this.HoursLBL.Name = "HoursLBL";
            // 
            // DelayBOX
            // 
            this.DelayBOX.Controls.Add(this.msTBX);
            this.DelayBOX.Controls.Add(this.secTBX);
            this.DelayBOX.Controls.Add(this.MSLBL);
            this.DelayBOX.Controls.Add(this.SecondsLBL);
            this.DelayBOX.Controls.Add(this.MinsLBL);
            this.DelayBOX.Controls.Add(this.HoursTBX);
            this.DelayBOX.Controls.Add(this.MinsTBX);
            this.DelayBOX.Controls.Add(this.HoursLBL);
            resources.ApplyResources(this.DelayBOX, "DelayBOX");
            this.DelayBOX.Name = "DelayBOX";
            this.DelayBOX.TabStop = false;
            // 
            // msTBX
            // 
            resources.ApplyResources(this.msTBX, "msTBX");
            this.msTBX.Name = "msTBX";
            // 
            // secTBX
            // 
            resources.ApplyResources(this.secTBX, "secTBX");
            this.secTBX.Name = "secTBX";
            // 
            // MSLBL
            // 
            resources.ApplyResources(this.MSLBL, "MSLBL");
            this.MSLBL.Name = "MSLBL";
            // 
            // SecondsLBL
            // 
            resources.ApplyResources(this.SecondsLBL, "SecondsLBL");
            this.SecondsLBL.Name = "SecondsLBL";
            // 
            // MinsLBL
            // 
            resources.ApplyResources(this.MinsLBL, "MinsLBL");
            this.MinsLBL.Name = "MinsLBL";
            // 
            // RecordBTN
            // 
            resources.ApplyResources(this.RecordBTN, "RecordBTN");
            this.RecordBTN.Name = "RecordBTN";
            this.RecordBTN.UseVisualStyleBackColor = true;
            this.RecordBTN.Click += new System.EventHandler(this.RecordBTN_Click);
            // 
            // SelectedTBX
            // 
            resources.ApplyResources(this.SelectedTBX, "SelectedTBX");
            this.SelectedTBX.Name = "SelectedTBX";
            this.SelectedTBX.ReadOnly = true;
            // 
            // KeycodeTBX
            // 
            resources.ApplyResources(this.KeycodeTBX, "KeycodeTBX");
            this.KeycodeTBX.Name = "KeycodeTBX";
            this.KeycodeTBX.ReadOnly = true;
            // 
            // TestBTN
            // 
            resources.ApplyResources(this.TestBTN, "TestBTN");
            this.TestBTN.Name = "TestBTN";
            this.TestBTN.UseVisualStyleBackColor = true;
            this.TestBTN.Click += new System.EventHandler(this.TestBTN_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestBTN);
            this.Controls.Add(this.KeycodeTBX);
            this.Controls.Add(this.SelectedTBX);
            this.Controls.Add(this.RecordBTN);
            this.Controls.Add(this.DelayBOX);
            this.Controls.Add(this.MouseBOX);
            this.Controls.Add(this.InputSelect);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.QuedActions);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyDown);
            this.MouseBOX.ResumeLayout(false);
            this.MouseBOX.PerformLayout();
            this.DelayBOX.ResumeLayout(false);
            this.DelayBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader InputHeader;
        private System.Windows.Forms.ColumnHeader PositionHeader;
        private System.Windows.Forms.ColumnHeader DelayHeader;
        private System.Windows.Forms.ColumnHeader RepeatHeader;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.ComboBox InputSelect;
        private System.Windows.Forms.GroupBox MouseBOX;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton CustomMouseBTN;
        private System.Windows.Forms.Label YposLBL;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton CurrentMouseBTN;
        private System.Windows.Forms.Label XposLBL;
        private System.Windows.Forms.TextBox HoursTBX;
        private System.Windows.Forms.TextBox MinsTBX;
        private System.Windows.Forms.Label HoursLBL;
        private System.Windows.Forms.GroupBox DelayBOX;
        private System.Windows.Forms.Label MinsLBL;
        private System.Windows.Forms.TextBox msTBX;
        private System.Windows.Forms.TextBox secTBX;
        private System.Windows.Forms.Label MSLBL;
        private System.Windows.Forms.Label SecondsLBL;
        private System.Windows.Forms.ColumnHeader KeyCodeHeader;
        private System.Windows.Forms.Button RecordBTN;
        private System.Windows.Forms.TextBox SelectedTBX;
        private System.Windows.Forms.ListView QuedActions;
        private System.Windows.Forms.TextBox KeycodeTBX;
        private System.Windows.Forms.Button TestBTN;
    }
}

