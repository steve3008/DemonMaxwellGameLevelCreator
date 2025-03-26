namespace DemonMaxwellGameLevelCreator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLoadBck = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoadLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonAddWall = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemArc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHorz = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStraight = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBox = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemParabola = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonAddBalls = new System.Windows.Forms.ToolStripButton();
            this.panelLevel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxArc = new System.Windows.Forms.GroupBox();
            this.textBoxArcAngleTo = new System.Windows.Forms.TextBox();
            this.labelArcStartEndTo = new System.Windows.Forms.Label();
            this.textBoxArcAngleFrom = new System.Windows.Forms.TextBox();
            this.labelArcStartEnd = new System.Windows.Forms.Label();
            this.checkBoxArcRemovable = new System.Windows.Forms.CheckBox();
            this.textBoxArcRadius = new System.Windows.Forms.TextBox();
            this.labelArcRadius = new System.Windows.Forms.Label();
            this.textBoxArcCentreY = new System.Windows.Forms.TextBox();
            this.textBoxArcCentreX = new System.Windows.Forms.TextBox();
            this.labelArcCentre = new System.Windows.Forms.Label();
            this.buttonSnapToNearest = new System.Windows.Forms.Button();
            this.labelCurrCursorCoords = new System.Windows.Forms.Label();
            this.labelCoords = new System.Windows.Forms.Label();
            this.labelTotalNumBalls = new System.Windows.Forms.Label();
            this.textBoxTotalNumBalls = new System.Windows.Forms.TextBox();
            this.textBoxLevelNum = new System.Windows.Forms.TextBox();
            this.labelLevelNum = new System.Windows.Forms.Label();
            this.numericUpDownObjSel = new System.Windows.Forms.NumericUpDown();
            this.groupBoxStraight = new System.Windows.Forms.GroupBox();
            this.checkBoxStraightRemovable = new System.Windows.Forms.CheckBox();
            this.textBoxStraightEndY = new System.Windows.Forms.TextBox();
            this.textBoxStraightEndX = new System.Windows.Forms.TextBox();
            this.labelStraightEnd = new System.Windows.Forms.Label();
            this.textBoxStraightStartY = new System.Windows.Forms.TextBox();
            this.textBoxStraightStartX = new System.Windows.Forms.TextBox();
            this.labelStraightStart = new System.Windows.Forms.Label();
            this.groupBoxBallSet = new System.Windows.Forms.GroupBox();
            this.textBoxBallSetNumBalls = new System.Windows.Forms.TextBox();
            this.labelBallSetNumBalls = new System.Windows.Forms.Label();
            this.textBoxBallSetColB = new System.Windows.Forms.TextBox();
            this.textBoxBallSetColG = new System.Windows.Forms.TextBox();
            this.textBoxBallSetColR = new System.Windows.Forms.TextBox();
            this.labelBallSetCol = new System.Windows.Forms.Label();
            this.textBoxBallSetGravityY = new System.Windows.Forms.TextBox();
            this.textBoxBallSetGravityX = new System.Windows.Forms.TextBox();
            this.labelBallSetGravity = new System.Windows.Forms.Label();
            this.textBoxBallSetRadius = new System.Windows.Forms.TextBox();
            this.labelBallSetRadius = new System.Windows.Forms.Label();
            this.textBoxBallSetVelRange = new System.Windows.Forms.TextBox();
            this.labelBallSetVelRange = new System.Windows.Forms.Label();
            this.textBoxBallSetHei = new System.Windows.Forms.TextBox();
            this.textBoxBallSetWid = new System.Windows.Forms.TextBox();
            this.labelBallSetWidHei = new System.Windows.Forms.Label();
            this.textBoxBallSetY = new System.Windows.Forms.TextBox();
            this.textBoxBallSetX = new System.Windows.Forms.TextBox();
            this.labelBallSetTopLeft = new System.Windows.Forms.Label();
            this.groupBoxBox = new System.Windows.Forms.GroupBox();
            this.checkBoxBoxRemovable = new System.Windows.Forms.CheckBox();
            this.checkBoxBoxBounceCorners = new System.Windows.Forms.CheckBox();
            this.checkBoxBoxMoveableY = new System.Windows.Forms.CheckBox();
            this.checkBoxBoxMoveableX = new System.Windows.Forms.CheckBox();
            this.textBoxBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxBoxWidth = new System.Windows.Forms.TextBox();
            this.labelBoxWidHei = new System.Windows.Forms.Label();
            this.textBoxBoxY = new System.Windows.Forms.TextBox();
            this.textBoxBoxX = new System.Windows.Forms.TextBox();
            this.labelBoxTopLeft = new System.Windows.Forms.Label();
            this.groupBoxVert = new System.Windows.Forms.GroupBox();
            this.checkBoxVertRemovable = new System.Windows.Forms.CheckBox();
            this.checkBoxVertFiniteEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxVertFiniteStart = new System.Windows.Forms.CheckBox();
            this.textBoxVertX = new System.Windows.Forms.TextBox();
            this.labelVertX = new System.Windows.Forms.Label();
            this.textBoxVertBot = new System.Windows.Forms.TextBox();
            this.labelVertBot = new System.Windows.Forms.Label();
            this.textBoxVertTop = new System.Windows.Forms.TextBox();
            this.labelVertTop = new System.Windows.Forms.Label();
            this.groupBoxHorz = new System.Windows.Forms.GroupBox();
            this.checkBoxHorzRemovable = new System.Windows.Forms.CheckBox();
            this.checkBoxHorzFiniteEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxHorzFiniteStart = new System.Windows.Forms.CheckBox();
            this.textBoxHorzY = new System.Windows.Forms.TextBox();
            this.labelHorzY = new System.Windows.Forms.Label();
            this.textBoxHorzRight = new System.Windows.Forms.TextBox();
            this.labelHorzRight = new System.Windows.Forms.Label();
            this.textBoxHorzLeft = new System.Windows.Forms.TextBox();
            this.labelHorzLeft = new System.Windows.Forms.Label();
            this.labelObjSel = new System.Windows.Forms.Label();
            this.textBoxNumBallSets = new System.Windows.Forms.TextBox();
            this.labelNumBallSets = new System.Windows.Forms.Label();
            this.textBoxNumWalls = new System.Windows.Forms.TextBox();
            this.labelNumWalls = new System.Windows.Forms.Label();
            this.textBoxNumObjs = new System.Windows.Forms.TextBox();
            this.labelNumObjs = new System.Windows.Forms.Label();
            this.groupBoxParabola = new System.Windows.Forms.GroupBox();
            this.checkBoxParabolaRemovable = new System.Windows.Forms.CheckBox();
            this.textBoxParabolaHeight = new System.Windows.Forms.TextBox();
            this.textBoxParabolaWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParabolaY = new System.Windows.Forms.TextBox();
            this.textBoxParabolaX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripButtonSaveLevelAsImage = new System.Windows.Forms.ToolStripButton();
            this.textBoxArcStartY = new System.Windows.Forms.TextBox();
            this.textBoxArcStartX = new System.Windows.Forms.TextBox();
            this.labelArcStart = new System.Windows.Forms.Label();
            this.textBoxArcEndY = new System.Windows.Forms.TextBox();
            this.textBoxArcEndX = new System.Windows.Forms.TextBox();
            this.labelArcEnd = new System.Windows.Forms.Label();
            this.buttonArcSetStartAndEnd = new System.Windows.Forms.Button();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxArc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjSel)).BeginInit();
            this.groupBoxStraight.SuspendLayout();
            this.groupBoxBallSet.SuspendLayout();
            this.groupBoxBox.SuspendLayout();
            this.groupBoxVert.SuspendLayout();
            this.groupBoxHorz.SuspendLayout();
            this.groupBoxParabola.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLoadBck,
            this.toolStripButtonLoadLevel,
            this.toolStripButtonSaveLevel,
            this.toolStripDropDownButtonAddWall,
            this.toolStripButtonAddBalls,
            this.toolStripButtonSaveLevelAsImage});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMain.Size = new System.Drawing.Size(922, 28);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonLoadBck
            // 
            this.toolStripButtonLoadBck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadBck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLoadBck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadBck.Image")));
            this.toolStripButtonLoadBck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadBck.Name = "toolStripButtonLoadBck";
            this.toolStripButtonLoadBck.Size = new System.Drawing.Size(126, 25);
            this.toolStripButtonLoadBck.Text = "Load Backdrop...";
            this.toolStripButtonLoadBck.Click += new System.EventHandler(this.toolStripButtonLoadBck_Click);
            // 
            // toolStripButtonLoadLevel
            // 
            this.toolStripButtonLoadLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonLoadLevel.Enabled = false;
            this.toolStripButtonLoadLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLoadLevel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoadLevel.Image")));
            this.toolStripButtonLoadLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoadLevel.Name = "toolStripButtonLoadLevel";
            this.toolStripButtonLoadLevel.Size = new System.Drawing.Size(97, 25);
            this.toolStripButtonLoadLevel.Text = "Load Level...";
            this.toolStripButtonLoadLevel.Click += new System.EventHandler(this.toolStripButtonLoadLevel_Click);
            // 
            // toolStripButtonSaveLevel
            // 
            this.toolStripButtonSaveLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSaveLevel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveLevel.Image")));
            this.toolStripButtonSaveLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveLevel.Name = "toolStripButtonSaveLevel";
            this.toolStripButtonSaveLevel.Size = new System.Drawing.Size(87, 25);
            this.toolStripButtonSaveLevel.Text = "Save Level";
            this.toolStripButtonSaveLevel.Click += new System.EventHandler(this.toolStripButtonSaveLevel_Click);
            // 
            // toolStripDropDownButtonAddWall
            // 
            this.toolStripDropDownButtonAddWall.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonAddWall.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemArc,
            this.toolStripMenuItemHorz,
            this.toolStripMenuItemVert,
            this.toolStripMenuItemStraight,
            this.toolStripMenuItemBox,
            this.toolStripMenuItemParabola});
            this.toolStripDropDownButtonAddWall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButtonAddWall.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonAddWall.Image")));
            this.toolStripDropDownButtonAddWall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonAddWall.Name = "toolStripDropDownButtonAddWall";
            this.toolStripDropDownButtonAddWall.Size = new System.Drawing.Size(94, 25);
            this.toolStripDropDownButtonAddWall.Text = "Add Wall...";
            this.toolStripDropDownButtonAddWall.Click += new System.EventHandler(this.toolStripDropDownButtonAddWall_Click);
            // 
            // toolStripMenuItemArc
            // 
            this.toolStripMenuItemArc.Name = "toolStripMenuItemArc";
            this.toolStripMenuItemArc.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemArc.Text = "Arc";
            this.toolStripMenuItemArc.Click += new System.EventHandler(this.toolStripMenuItemArc_Click);
            // 
            // toolStripMenuItemHorz
            // 
            this.toolStripMenuItemHorz.Name = "toolStripMenuItemHorz";
            this.toolStripMenuItemHorz.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemHorz.Text = "Horizontal";
            this.toolStripMenuItemHorz.Click += new System.EventHandler(this.toolStripMenuItemHorz_Click);
            // 
            // toolStripMenuItemVert
            // 
            this.toolStripMenuItemVert.Name = "toolStripMenuItemVert";
            this.toolStripMenuItemVert.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemVert.Text = "Vertical";
            this.toolStripMenuItemVert.Click += new System.EventHandler(this.toolStripMenuItemVert_Click);
            // 
            // toolStripMenuItemStraight
            // 
            this.toolStripMenuItemStraight.Name = "toolStripMenuItemStraight";
            this.toolStripMenuItemStraight.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemStraight.Text = "Straight";
            this.toolStripMenuItemStraight.Click += new System.EventHandler(this.toolStripMenuItemStraight_Click);
            // 
            // toolStripMenuItemBox
            // 
            this.toolStripMenuItemBox.Name = "toolStripMenuItemBox";
            this.toolStripMenuItemBox.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemBox.Text = "Box";
            this.toolStripMenuItemBox.Click += new System.EventHandler(this.toolStripMenuItemBox_Click);
            // 
            // toolStripMenuItemParabola
            // 
            this.toolStripMenuItemParabola.Name = "toolStripMenuItemParabola";
            this.toolStripMenuItemParabola.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemParabola.Text = "Parabola";
            this.toolStripMenuItemParabola.Click += new System.EventHandler(this.toolStripMenuItemParabola_Click);
            // 
            // toolStripButtonAddBalls
            // 
            this.toolStripButtonAddBalls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddBalls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonAddBalls.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddBalls.Image")));
            this.toolStripButtonAddBalls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddBalls.Name = "toolStripButtonAddBalls";
            this.toolStripButtonAddBalls.Size = new System.Drawing.Size(87, 25);
            this.toolStripButtonAddBalls.Text = "Add Balls...";
            this.toolStripButtonAddBalls.Click += new System.EventHandler(this.toolStripButtonAddBalls_Click);
            // 
            // panelLevel
            // 
            this.panelLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLevel.Location = new System.Drawing.Point(8, 6);
            this.panelLevel.Margin = new System.Windows.Forms.Padding(2);
            this.panelLevel.Name = "panelLevel";
            this.panelLevel.Size = new System.Drawing.Size(696, 714);
            this.panelLevel.TabIndex = 1;
            this.panelLevel.SizeChanged += new System.EventHandler(this.panelLevel_SizeChanged);
            this.panelLevel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLevel_Paint);
            this.panelLevel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelLevel_MouseMove);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxParabola);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxArc);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSnapToNearest);
            this.splitContainer1.Panel1.Controls.Add(this.labelCurrCursorCoords);
            this.splitContainer1.Panel1.Controls.Add(this.labelCoords);
            this.splitContainer1.Panel1.Controls.Add(this.labelTotalNumBalls);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTotalNumBalls);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLevelNum);
            this.splitContainer1.Panel1.Controls.Add(this.labelLevelNum);
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownObjSel);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxStraight);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxBallSet);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxBox);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxVert);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxHorz);
            this.splitContainer1.Panel1.Controls.Add(this.labelObjSel);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumBallSets);
            this.splitContainer1.Panel1.Controls.Add(this.labelNumBallSets);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumWalls);
            this.splitContainer1.Panel1.Controls.Add(this.labelNumWalls);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumObjs);
            this.splitContainer1.Panel1.Controls.Add(this.labelNumObjs);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.panelLevel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.splitContainer1.Size = new System.Drawing.Size(922, 728);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            this.splitContainer1.TabStop = false;
            // 
            // groupBoxArc
            // 
            this.groupBoxArc.Controls.Add(this.buttonArcSetStartAndEnd);
            this.groupBoxArc.Controls.Add(this.textBoxArcEndY);
            this.groupBoxArc.Controls.Add(this.textBoxArcEndX);
            this.groupBoxArc.Controls.Add(this.labelArcEnd);
            this.groupBoxArc.Controls.Add(this.textBoxArcStartY);
            this.groupBoxArc.Controls.Add(this.textBoxArcStartX);
            this.groupBoxArc.Controls.Add(this.labelArcStart);
            this.groupBoxArc.Controls.Add(this.textBoxArcAngleTo);
            this.groupBoxArc.Controls.Add(this.labelArcStartEndTo);
            this.groupBoxArc.Controls.Add(this.textBoxArcAngleFrom);
            this.groupBoxArc.Controls.Add(this.labelArcStartEnd);
            this.groupBoxArc.Controls.Add(this.checkBoxArcRemovable);
            this.groupBoxArc.Controls.Add(this.textBoxArcRadius);
            this.groupBoxArc.Controls.Add(this.labelArcRadius);
            this.groupBoxArc.Controls.Add(this.textBoxArcCentreY);
            this.groupBoxArc.Controls.Add(this.textBoxArcCentreX);
            this.groupBoxArc.Controls.Add(this.labelArcCentre);
            this.groupBoxArc.Location = new System.Drawing.Point(7, 494);
            this.groupBoxArc.Name = "groupBoxArc";
            this.groupBoxArc.Size = new System.Drawing.Size(184, 209);
            this.groupBoxArc.TabIndex = 11;
            this.groupBoxArc.TabStop = false;
            this.groupBoxArc.Text = " Wall - Arc ";
            this.groupBoxArc.Visible = false;
            // 
            // textBoxArcAngleTo
            // 
            this.textBoxArcAngleTo.Location = new System.Drawing.Point(142, 72);
            this.textBoxArcAngleTo.Name = "textBoxArcAngleTo";
            this.textBoxArcAngleTo.Size = new System.Drawing.Size(35, 20);
            this.textBoxArcAngleTo.TabIndex = 21;
            this.textBoxArcAngleTo.Text = "000";
            this.textBoxArcAngleTo.TextChanged += new System.EventHandler(this.textBoxArcAngleTo_TextChanged);
            // 
            // labelArcStartEndTo
            // 
            this.labelArcStartEndTo.AutoSize = true;
            this.labelArcStartEndTo.Location = new System.Drawing.Point(124, 75);
            this.labelArcStartEndTo.Name = "labelArcStartEndTo";
            this.labelArcStartEndTo.Size = new System.Drawing.Size(16, 13);
            this.labelArcStartEndTo.TabIndex = 20;
            this.labelArcStartEndTo.Text = "to";
            // 
            // textBoxArcAngleFrom
            // 
            this.textBoxArcAngleFrom.Location = new System.Drawing.Point(85, 72);
            this.textBoxArcAngleFrom.Name = "textBoxArcAngleFrom";
            this.textBoxArcAngleFrom.Size = new System.Drawing.Size(35, 20);
            this.textBoxArcAngleFrom.TabIndex = 18;
            this.textBoxArcAngleFrom.Text = "000";
            this.textBoxArcAngleFrom.TextChanged += new System.EventHandler(this.textBoxArcAngleFrom_TextChanged);
            // 
            // labelArcStartEnd
            // 
            this.labelArcStartEnd.AutoSize = true;
            this.labelArcStartEnd.Location = new System.Drawing.Point(8, 75);
            this.labelArcStartEnd.Name = "labelArcStartEnd";
            this.labelArcStartEnd.Size = new System.Drawing.Size(71, 13);
            this.labelArcStartEnd.TabIndex = 19;
            this.labelArcStartEnd.Text = "Angles, From:";
            // 
            // checkBoxArcRemovable
            // 
            this.checkBoxArcRemovable.AutoSize = true;
            this.checkBoxArcRemovable.Location = new System.Drawing.Point(9, 101);
            this.checkBoxArcRemovable.Name = "checkBoxArcRemovable";
            this.checkBoxArcRemovable.Size = new System.Drawing.Size(80, 17);
            this.checkBoxArcRemovable.TabIndex = 17;
            this.checkBoxArcRemovable.Text = "Removable";
            this.checkBoxArcRemovable.UseVisualStyleBackColor = true;
            this.checkBoxArcRemovable.CheckedChanged += new System.EventHandler(this.checkBoxArcRemovable_CheckedChanged);
            // 
            // textBoxArcRadius
            // 
            this.textBoxArcRadius.Location = new System.Drawing.Point(104, 48);
            this.textBoxArcRadius.Name = "textBoxArcRadius";
            this.textBoxArcRadius.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcRadius.TabIndex = 14;
            this.textBoxArcRadius.Text = "1.0000";
            this.textBoxArcRadius.TextChanged += new System.EventHandler(this.textBoxArcRadius_TextChanged);
            // 
            // labelArcRadius
            // 
            this.labelArcRadius.AutoSize = true;
            this.labelArcRadius.Location = new System.Drawing.Point(7, 51);
            this.labelArcRadius.Name = "labelArcRadius";
            this.labelArcRadius.Size = new System.Drawing.Size(43, 13);
            this.labelArcRadius.TabIndex = 15;
            this.labelArcRadius.Text = "Radius:";
            // 
            // textBoxArcCentreY
            // 
            this.textBoxArcCentreY.Location = new System.Drawing.Point(130, 25);
            this.textBoxArcCentreY.Name = "textBoxArcCentreY";
            this.textBoxArcCentreY.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcCentreY.TabIndex = 13;
            this.textBoxArcCentreY.Text = "0.0000";
            this.textBoxArcCentreY.TextChanged += new System.EventHandler(this.textBoxArcCentreY_TextChanged);
            // 
            // textBoxArcCentreX
            // 
            this.textBoxArcCentreX.Location = new System.Drawing.Point(77, 25);
            this.textBoxArcCentreX.Name = "textBoxArcCentreX";
            this.textBoxArcCentreX.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcCentreX.TabIndex = 11;
            this.textBoxArcCentreX.Text = "0.0000";
            this.textBoxArcCentreX.TextChanged += new System.EventHandler(this.textBoxArcCentreX_TextChanged);
            // 
            // labelArcCentre
            // 
            this.labelArcCentre.AutoSize = true;
            this.labelArcCentre.Location = new System.Drawing.Point(7, 28);
            this.labelArcCentre.Name = "labelArcCentre";
            this.labelArcCentre.Size = new System.Drawing.Size(41, 13);
            this.labelArcCentre.TabIndex = 12;
            this.labelArcCentre.Text = "Centre:";
            // 
            // buttonSnapToNearest
            // 
            this.buttonSnapToNearest.Enabled = false;
            this.buttonSnapToNearest.Location = new System.Drawing.Point(7, 171);
            this.buttonSnapToNearest.Name = "buttonSnapToNearest";
            this.buttonSnapToNearest.Size = new System.Drawing.Size(184, 23);
            this.buttonSnapToNearest.TabIndex = 0;
            this.buttonSnapToNearest.Text = "TODO: Snap to nearest other object";
            this.buttonSnapToNearest.UseVisualStyleBackColor = true;
            this.buttonSnapToNearest.Visible = false;
            this.buttonSnapToNearest.Click += new System.EventHandler(this.buttonSnapToNearest_Click);
            // 
            // labelCurrCursorCoords
            // 
            this.labelCurrCursorCoords.AutoSize = true;
            this.labelCurrCursorCoords.Location = new System.Drawing.Point(10, 416);
            this.labelCurrCursorCoords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrCursorCoords.Name = "labelCurrCursorCoords";
            this.labelCurrCursorCoords.Size = new System.Drawing.Size(174, 13);
            this.labelCurrCursorCoords.TabIndex = 0;
            this.labelCurrCursorCoords.Text = "Current Mouse Pointer Coordinates:";
            // 
            // labelCoords
            // 
            this.labelCoords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCoords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoords.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoords.Location = new System.Drawing.Point(7, 434);
            this.labelCoords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoords.Name = "labelCoords";
            this.labelCoords.Size = new System.Drawing.Size(184, 53);
            this.labelCoords.TabIndex = 0;
            this.labelCoords.Text = "--, --";
            this.labelCoords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalNumBalls
            // 
            this.labelTotalNumBalls.AutoSize = true;
            this.labelTotalNumBalls.Location = new System.Drawing.Point(14, 88);
            this.labelTotalNumBalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalNumBalls.Name = "labelTotalNumBalls";
            this.labelTotalNumBalls.Size = new System.Drawing.Size(108, 13);
            this.labelTotalNumBalls.TabIndex = 0;
            this.labelTotalNumBalls.Text = "Total number of balls:";
            // 
            // textBoxTotalNumBalls
            // 
            this.textBoxTotalNumBalls.Location = new System.Drawing.Point(135, 86);
            this.textBoxTotalNumBalls.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalNumBalls.Name = "textBoxTotalNumBalls";
            this.textBoxTotalNumBalls.ReadOnly = true;
            this.textBoxTotalNumBalls.Size = new System.Drawing.Size(42, 20);
            this.textBoxTotalNumBalls.TabIndex = 0;
            this.textBoxTotalNumBalls.Text = "0";
            // 
            // textBoxLevelNum
            // 
            this.textBoxLevelNum.Location = new System.Drawing.Point(139, 8);
            this.textBoxLevelNum.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLevelNum.Name = "textBoxLevelNum";
            this.textBoxLevelNum.Size = new System.Drawing.Size(31, 20);
            this.textBoxLevelNum.TabIndex = 0;
            this.textBoxLevelNum.TextChanged += new System.EventHandler(this.textBoxLevelNum_TextChanged);
            // 
            // labelLevelNum
            // 
            this.labelLevelNum.AutoSize = true;
            this.labelLevelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevelNum.Location = new System.Drawing.Point(14, 10);
            this.labelLevelNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLevelNum.Name = "labelLevelNum";
            this.labelLevelNum.Size = new System.Drawing.Size(89, 13);
            this.labelLevelNum.TabIndex = 0;
            this.labelLevelNum.Text = "Level Number:";
            // 
            // numericUpDownObjSel
            // 
            this.numericUpDownObjSel.Location = new System.Drawing.Point(135, 107);
            this.numericUpDownObjSel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownObjSel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownObjSel.Name = "numericUpDownObjSel";
            this.numericUpDownObjSel.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownObjSel.TabIndex = 0;
            this.numericUpDownObjSel.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownObjSel.ValueChanged += new System.EventHandler(this.numericUpDownObjSel_ValueChanged);
            // 
            // groupBoxStraight
            // 
            this.groupBoxStraight.Controls.Add(this.checkBoxStraightRemovable);
            this.groupBoxStraight.Controls.Add(this.textBoxStraightEndY);
            this.groupBoxStraight.Controls.Add(this.textBoxStraightEndX);
            this.groupBoxStraight.Controls.Add(this.labelStraightEnd);
            this.groupBoxStraight.Controls.Add(this.textBoxStraightStartY);
            this.groupBoxStraight.Controls.Add(this.textBoxStraightStartX);
            this.groupBoxStraight.Controls.Add(this.labelStraightStart);
            this.groupBoxStraight.Location = new System.Drawing.Point(7, 205);
            this.groupBoxStraight.Name = "groupBoxStraight";
            this.groupBoxStraight.Size = new System.Drawing.Size(184, 102);
            this.groupBoxStraight.TabIndex = 10;
            this.groupBoxStraight.TabStop = false;
            this.groupBoxStraight.Text = " Wall - Straight ";
            this.groupBoxStraight.Visible = false;
            // 
            // checkBoxStraightRemovable
            // 
            this.checkBoxStraightRemovable.AutoSize = true;
            this.checkBoxStraightRemovable.Location = new System.Drawing.Point(9, 75);
            this.checkBoxStraightRemovable.Name = "checkBoxStraightRemovable";
            this.checkBoxStraightRemovable.Size = new System.Drawing.Size(80, 17);
            this.checkBoxStraightRemovable.TabIndex = 17;
            this.checkBoxStraightRemovable.Text = "Removable";
            this.checkBoxStraightRemovable.UseVisualStyleBackColor = true;
            this.checkBoxStraightRemovable.CheckedChanged += new System.EventHandler(this.checkBoxStraightRemovable_CheckedChanged);
            // 
            // textBoxStraightEndY
            // 
            this.textBoxStraightEndY.Location = new System.Drawing.Point(130, 48);
            this.textBoxStraightEndY.Name = "textBoxStraightEndY";
            this.textBoxStraightEndY.Size = new System.Drawing.Size(47, 20);
            this.textBoxStraightEndY.TabIndex = 16;
            this.textBoxStraightEndY.Text = "1.0000";
            this.textBoxStraightEndY.TextChanged += new System.EventHandler(this.textBoxStraightEndY_TextChanged);
            // 
            // textBoxStraightEndX
            // 
            this.textBoxStraightEndX.Location = new System.Drawing.Point(77, 48);
            this.textBoxStraightEndX.Name = "textBoxStraightEndX";
            this.textBoxStraightEndX.Size = new System.Drawing.Size(47, 20);
            this.textBoxStraightEndX.TabIndex = 14;
            this.textBoxStraightEndX.Text = "1.0000";
            this.textBoxStraightEndX.TextChanged += new System.EventHandler(this.textBoxStraightEndX_TextChanged);
            // 
            // labelStraightEnd
            // 
            this.labelStraightEnd.AutoSize = true;
            this.labelStraightEnd.Location = new System.Drawing.Point(7, 51);
            this.labelStraightEnd.Name = "labelStraightEnd";
            this.labelStraightEnd.Size = new System.Drawing.Size(29, 13);
            this.labelStraightEnd.TabIndex = 15;
            this.labelStraightEnd.Text = "End:";
            // 
            // textBoxStraightStartY
            // 
            this.textBoxStraightStartY.Location = new System.Drawing.Point(130, 25);
            this.textBoxStraightStartY.Name = "textBoxStraightStartY";
            this.textBoxStraightStartY.Size = new System.Drawing.Size(47, 20);
            this.textBoxStraightStartY.TabIndex = 13;
            this.textBoxStraightStartY.Text = "0.0000";
            this.textBoxStraightStartY.TextChanged += new System.EventHandler(this.textBoxStraightStartY_TextChanged);
            // 
            // textBoxStraightStartX
            // 
            this.textBoxStraightStartX.Location = new System.Drawing.Point(77, 25);
            this.textBoxStraightStartX.Name = "textBoxStraightStartX";
            this.textBoxStraightStartX.Size = new System.Drawing.Size(47, 20);
            this.textBoxStraightStartX.TabIndex = 11;
            this.textBoxStraightStartX.Text = "0.0000";
            this.textBoxStraightStartX.TextChanged += new System.EventHandler(this.textBoxStraightStartX_TextChanged);
            // 
            // labelStraightStart
            // 
            this.labelStraightStart.AutoSize = true;
            this.labelStraightStart.Location = new System.Drawing.Point(7, 28);
            this.labelStraightStart.Name = "labelStraightStart";
            this.labelStraightStart.Size = new System.Drawing.Size(32, 13);
            this.labelStraightStart.TabIndex = 12;
            this.labelStraightStart.Text = "Start:";
            // 
            // groupBoxBallSet
            // 
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetNumBalls);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetNumBalls);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetColB);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetColG);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetColR);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetCol);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetGravityY);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetGravityX);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetGravity);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetRadius);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetRadius);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetVelRange);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetVelRange);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetHei);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetWid);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetWidHei);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetY);
            this.groupBoxBallSet.Controls.Add(this.textBoxBallSetX);
            this.groupBoxBallSet.Controls.Add(this.labelBallSetTopLeft);
            this.groupBoxBallSet.Location = new System.Drawing.Point(7, 206);
            this.groupBoxBallSet.Name = "groupBoxBallSet";
            this.groupBoxBallSet.Size = new System.Drawing.Size(184, 188);
            this.groupBoxBallSet.TabIndex = 9;
            this.groupBoxBallSet.TabStop = false;
            this.groupBoxBallSet.Text = " Ball Set  - Rnd";
            this.groupBoxBallSet.Visible = false;
            // 
            // textBoxBallSetNumBalls
            // 
            this.textBoxBallSetNumBalls.Location = new System.Drawing.Point(77, 20);
            this.textBoxBallSetNumBalls.Name = "textBoxBallSetNumBalls";
            this.textBoxBallSetNumBalls.Size = new System.Drawing.Size(65, 20);
            this.textBoxBallSetNumBalls.TabIndex = 40;
            this.textBoxBallSetNumBalls.Text = "0000";
            this.textBoxBallSetNumBalls.TextChanged += new System.EventHandler(this.textBoxBallSetNumBalls_TextChanged);
            // 
            // labelBallSetNumBalls
            // 
            this.labelBallSetNumBalls.AutoSize = true;
            this.labelBallSetNumBalls.Location = new System.Drawing.Point(7, 23);
            this.labelBallSetNumBalls.Name = "labelBallSetNumBalls";
            this.labelBallSetNumBalls.Size = new System.Drawing.Size(57, 13);
            this.labelBallSetNumBalls.TabIndex = 41;
            this.labelBallSetNumBalls.Text = "Num Balls:";
            // 
            // textBoxBallSetColB
            // 
            this.textBoxBallSetColB.Location = new System.Drawing.Point(147, 163);
            this.textBoxBallSetColB.Name = "textBoxBallSetColB";
            this.textBoxBallSetColB.Size = new System.Drawing.Size(30, 20);
            this.textBoxBallSetColB.TabIndex = 39;
            this.textBoxBallSetColB.Text = "000";
            this.textBoxBallSetColB.TextChanged += new System.EventHandler(this.textBoxBallSetColB_TextChanged);
            // 
            // textBoxBallSetColG
            // 
            this.textBoxBallSetColG.Location = new System.Drawing.Point(112, 163);
            this.textBoxBallSetColG.Name = "textBoxBallSetColG";
            this.textBoxBallSetColG.Size = new System.Drawing.Size(30, 20);
            this.textBoxBallSetColG.TabIndex = 38;
            this.textBoxBallSetColG.Text = "000";
            this.textBoxBallSetColG.TextChanged += new System.EventHandler(this.textBoxBallSetColG_TextChanged);
            // 
            // textBoxBallSetColR
            // 
            this.textBoxBallSetColR.Location = new System.Drawing.Point(77, 163);
            this.textBoxBallSetColR.Name = "textBoxBallSetColR";
            this.textBoxBallSetColR.Size = new System.Drawing.Size(30, 20);
            this.textBoxBallSetColR.TabIndex = 36;
            this.textBoxBallSetColR.Text = "000";
            this.textBoxBallSetColR.TextChanged += new System.EventHandler(this.textBoxBallSetColR_TextChanged);
            // 
            // labelBallSetCol
            // 
            this.labelBallSetCol.AutoSize = true;
            this.labelBallSetCol.Location = new System.Drawing.Point(7, 166);
            this.labelBallSetCol.Name = "labelBallSetCol";
            this.labelBallSetCol.Size = new System.Drawing.Size(40, 13);
            this.labelBallSetCol.TabIndex = 37;
            this.labelBallSetCol.Text = "Colour:";
            // 
            // textBoxBallSetGravityY
            // 
            this.textBoxBallSetGravityY.Location = new System.Drawing.Point(130, 139);
            this.textBoxBallSetGravityY.Name = "textBoxBallSetGravityY";
            this.textBoxBallSetGravityY.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetGravityY.TabIndex = 35;
            this.textBoxBallSetGravityY.Text = "0.0000";
            this.textBoxBallSetGravityY.TextChanged += new System.EventHandler(this.textBoxBallSetGravityY_TextChanged);
            // 
            // textBoxBallSetGravityX
            // 
            this.textBoxBallSetGravityX.Location = new System.Drawing.Point(77, 139);
            this.textBoxBallSetGravityX.Name = "textBoxBallSetGravityX";
            this.textBoxBallSetGravityX.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetGravityX.TabIndex = 33;
            this.textBoxBallSetGravityX.Text = "0.0000";
            this.textBoxBallSetGravityX.TextChanged += new System.EventHandler(this.textBoxBallSetGravityX_TextChanged);
            // 
            // labelBallSetGravity
            // 
            this.labelBallSetGravity.AutoSize = true;
            this.labelBallSetGravity.Location = new System.Drawing.Point(7, 142);
            this.labelBallSetGravity.Name = "labelBallSetGravity";
            this.labelBallSetGravity.Size = new System.Drawing.Size(43, 13);
            this.labelBallSetGravity.TabIndex = 34;
            this.labelBallSetGravity.Text = "Gravity:";
            // 
            // textBoxBallSetRadius
            // 
            this.textBoxBallSetRadius.Location = new System.Drawing.Point(77, 116);
            this.textBoxBallSetRadius.Name = "textBoxBallSetRadius";
            this.textBoxBallSetRadius.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetRadius.TabIndex = 31;
            this.textBoxBallSetRadius.Text = "0.2000";
            this.textBoxBallSetRadius.TextChanged += new System.EventHandler(this.textBoxBallSetRadius_TextChanged);
            // 
            // labelBallSetRadius
            // 
            this.labelBallSetRadius.AutoSize = true;
            this.labelBallSetRadius.Location = new System.Drawing.Point(7, 119);
            this.labelBallSetRadius.Name = "labelBallSetRadius";
            this.labelBallSetRadius.Size = new System.Drawing.Size(43, 13);
            this.labelBallSetRadius.TabIndex = 32;
            this.labelBallSetRadius.Text = "Radius:";
            // 
            // textBoxBallSetVelRange
            // 
            this.textBoxBallSetVelRange.Location = new System.Drawing.Point(77, 94);
            this.textBoxBallSetVelRange.Name = "textBoxBallSetVelRange";
            this.textBoxBallSetVelRange.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetVelRange.TabIndex = 29;
            this.textBoxBallSetVelRange.Text = "0.2000";
            this.textBoxBallSetVelRange.TextChanged += new System.EventHandler(this.textBoxBallSetVelRange_TextChanged);
            // 
            // labelBallSetVelRange
            // 
            this.labelBallSetVelRange.AutoSize = true;
            this.labelBallSetVelRange.Location = new System.Drawing.Point(7, 97);
            this.labelBallSetVelRange.Name = "labelBallSetVelRange";
            this.labelBallSetVelRange.Size = new System.Drawing.Size(60, 13);
            this.labelBallSetVelRange.TabIndex = 30;
            this.labelBallSetVelRange.Text = "Vel Range:";
            // 
            // textBoxBallSetHei
            // 
            this.textBoxBallSetHei.Location = new System.Drawing.Point(130, 67);
            this.textBoxBallSetHei.Name = "textBoxBallSetHei";
            this.textBoxBallSetHei.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetHei.TabIndex = 28;
            this.textBoxBallSetHei.Text = "1.0000";
            this.textBoxBallSetHei.TextChanged += new System.EventHandler(this.textBoxBallSetHei_TextChanged);
            // 
            // textBoxBallSetWid
            // 
            this.textBoxBallSetWid.Location = new System.Drawing.Point(77, 67);
            this.textBoxBallSetWid.Name = "textBoxBallSetWid";
            this.textBoxBallSetWid.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetWid.TabIndex = 26;
            this.textBoxBallSetWid.Text = "1.0000";
            this.textBoxBallSetWid.TextChanged += new System.EventHandler(this.textBoxBallSetWid_TextChanged);
            // 
            // labelBallSetWidHei
            // 
            this.labelBallSetWidHei.AutoSize = true;
            this.labelBallSetWidHei.Location = new System.Drawing.Point(7, 70);
            this.labelBallSetWidHei.Name = "labelBallSetWidHei";
            this.labelBallSetWidHei.Size = new System.Drawing.Size(48, 13);
            this.labelBallSetWidHei.TabIndex = 27;
            this.labelBallSetWidHei.Text = "Wid Hei:";
            // 
            // textBoxBallSetY
            // 
            this.textBoxBallSetY.Location = new System.Drawing.Point(130, 46);
            this.textBoxBallSetY.Name = "textBoxBallSetY";
            this.textBoxBallSetY.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetY.TabIndex = 25;
            this.textBoxBallSetY.Text = "0.0000";
            this.textBoxBallSetY.TextChanged += new System.EventHandler(this.textBoxBallSetY_TextChanged);
            // 
            // textBoxBallSetX
            // 
            this.textBoxBallSetX.Location = new System.Drawing.Point(77, 46);
            this.textBoxBallSetX.Name = "textBoxBallSetX";
            this.textBoxBallSetX.Size = new System.Drawing.Size(47, 20);
            this.textBoxBallSetX.TabIndex = 23;
            this.textBoxBallSetX.Text = "0.0000";
            this.textBoxBallSetX.TextChanged += new System.EventHandler(this.textBoxBallSetX_TextChanged);
            // 
            // labelBallSetTopLeft
            // 
            this.labelBallSetTopLeft.AutoSize = true;
            this.labelBallSetTopLeft.Location = new System.Drawing.Point(7, 49);
            this.labelBallSetTopLeft.Name = "labelBallSetTopLeft";
            this.labelBallSetTopLeft.Size = new System.Drawing.Size(50, 13);
            this.labelBallSetTopLeft.TabIndex = 24;
            this.labelBallSetTopLeft.Text = "Top Left:";
            // 
            // groupBoxBox
            // 
            this.groupBoxBox.Controls.Add(this.checkBoxBoxRemovable);
            this.groupBoxBox.Controls.Add(this.checkBoxBoxBounceCorners);
            this.groupBoxBox.Controls.Add(this.checkBoxBoxMoveableY);
            this.groupBoxBox.Controls.Add(this.checkBoxBoxMoveableX);
            this.groupBoxBox.Controls.Add(this.textBoxBoxHeight);
            this.groupBoxBox.Controls.Add(this.textBoxBoxWidth);
            this.groupBoxBox.Controls.Add(this.labelBoxWidHei);
            this.groupBoxBox.Controls.Add(this.textBoxBoxY);
            this.groupBoxBox.Controls.Add(this.textBoxBoxX);
            this.groupBoxBox.Controls.Add(this.labelBoxTopLeft);
            this.groupBoxBox.Location = new System.Drawing.Point(7, 207);
            this.groupBoxBox.Name = "groupBoxBox";
            this.groupBoxBox.Size = new System.Drawing.Size(184, 118);
            this.groupBoxBox.TabIndex = 8;
            this.groupBoxBox.TabStop = false;
            this.groupBoxBox.Text = " Wall - Box ";
            this.groupBoxBox.Visible = false;
            // 
            // checkBoxBoxRemovable
            // 
            this.checkBoxBoxRemovable.AutoSize = true;
            this.checkBoxBoxRemovable.Location = new System.Drawing.Point(95, 97);
            this.checkBoxBoxRemovable.Name = "checkBoxBoxRemovable";
            this.checkBoxBoxRemovable.Size = new System.Drawing.Size(86, 17);
            this.checkBoxBoxRemovable.TabIndex = 26;
            this.checkBoxBoxRemovable.Text = "Removeable";
            this.checkBoxBoxRemovable.UseVisualStyleBackColor = true;
            this.checkBoxBoxRemovable.CheckedChanged += new System.EventHandler(this.checkBoxBoxRemovable_CheckedChanged);
            // 
            // checkBoxBoxBounceCorners
            // 
            this.checkBoxBoxBounceCorners.AutoSize = true;
            this.checkBoxBoxBounceCorners.Checked = true;
            this.checkBoxBoxBounceCorners.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBoxBounceCorners.Location = new System.Drawing.Point(5, 97);
            this.checkBoxBoxBounceCorners.Name = "checkBoxBoxBounceCorners";
            this.checkBoxBoxBounceCorners.Size = new System.Drawing.Size(89, 17);
            this.checkBoxBoxBounceCorners.TabIndex = 25;
            this.checkBoxBoxBounceCorners.Text = "Bnce corners";
            this.checkBoxBoxBounceCorners.UseVisualStyleBackColor = true;
            this.checkBoxBoxBounceCorners.CheckedChanged += new System.EventHandler(this.checkBoxBoxBounceCorners_CheckedChanged);
            // 
            // checkBoxBoxMoveableY
            // 
            this.checkBoxBoxMoveableY.AutoSize = true;
            this.checkBoxBoxMoveableY.Location = new System.Drawing.Point(95, 74);
            this.checkBoxBoxMoveableY.Name = "checkBoxBoxMoveableY";
            this.checkBoxBoxMoveableY.Size = new System.Drawing.Size(83, 17);
            this.checkBoxBoxMoveableY.TabIndex = 24;
            this.checkBoxBoxMoveableY.Text = "Moveable Y";
            this.checkBoxBoxMoveableY.UseVisualStyleBackColor = true;
            this.checkBoxBoxMoveableY.CheckedChanged += new System.EventHandler(this.checkBoxBoxMoveableY_CheckedChanged);
            // 
            // checkBoxBoxMoveableX
            // 
            this.checkBoxBoxMoveableX.AutoSize = true;
            this.checkBoxBoxMoveableX.Location = new System.Drawing.Point(5, 74);
            this.checkBoxBoxMoveableX.Name = "checkBoxBoxMoveableX";
            this.checkBoxBoxMoveableX.Size = new System.Drawing.Size(83, 17);
            this.checkBoxBoxMoveableX.TabIndex = 23;
            this.checkBoxBoxMoveableX.Text = "Moveable X";
            this.checkBoxBoxMoveableX.UseVisualStyleBackColor = true;
            this.checkBoxBoxMoveableX.CheckedChanged += new System.EventHandler(this.checkBoxBoxMoveableX_CheckedChanged);
            // 
            // textBoxBoxHeight
            // 
            this.textBoxBoxHeight.Location = new System.Drawing.Point(130, 44);
            this.textBoxBoxHeight.Name = "textBoxBoxHeight";
            this.textBoxBoxHeight.Size = new System.Drawing.Size(47, 20);
            this.textBoxBoxHeight.TabIndex = 22;
            this.textBoxBoxHeight.Text = "1.0000";
            this.textBoxBoxHeight.TextChanged += new System.EventHandler(this.textBoxBoxHeight_TextChanged);
            // 
            // textBoxBoxWidth
            // 
            this.textBoxBoxWidth.Location = new System.Drawing.Point(77, 44);
            this.textBoxBoxWidth.Name = "textBoxBoxWidth";
            this.textBoxBoxWidth.Size = new System.Drawing.Size(47, 20);
            this.textBoxBoxWidth.TabIndex = 20;
            this.textBoxBoxWidth.Text = "1.0000";
            this.textBoxBoxWidth.TextChanged += new System.EventHandler(this.textBoxBoxWidth_TextChanged);
            // 
            // labelBoxWidHei
            // 
            this.labelBoxWidHei.AutoSize = true;
            this.labelBoxWidHei.Location = new System.Drawing.Point(7, 47);
            this.labelBoxWidHei.Name = "labelBoxWidHei";
            this.labelBoxWidHei.Size = new System.Drawing.Size(48, 13);
            this.labelBoxWidHei.TabIndex = 21;
            this.labelBoxWidHei.Text = "Wid Hei:";
            // 
            // textBoxBoxY
            // 
            this.textBoxBoxY.Location = new System.Drawing.Point(130, 23);
            this.textBoxBoxY.Name = "textBoxBoxY";
            this.textBoxBoxY.Size = new System.Drawing.Size(47, 20);
            this.textBoxBoxY.TabIndex = 19;
            this.textBoxBoxY.Text = "0.0000";
            this.textBoxBoxY.TextChanged += new System.EventHandler(this.textBoxBoxY_TextChanged);
            // 
            // textBoxBoxX
            // 
            this.textBoxBoxX.Location = new System.Drawing.Point(77, 23);
            this.textBoxBoxX.Name = "textBoxBoxX";
            this.textBoxBoxX.Size = new System.Drawing.Size(47, 20);
            this.textBoxBoxX.TabIndex = 17;
            this.textBoxBoxX.Text = "0.0000";
            this.textBoxBoxX.TextChanged += new System.EventHandler(this.textBoxBoxX_TextChanged);
            // 
            // labelBoxTopLeft
            // 
            this.labelBoxTopLeft.AutoSize = true;
            this.labelBoxTopLeft.Location = new System.Drawing.Point(7, 26);
            this.labelBoxTopLeft.Name = "labelBoxTopLeft";
            this.labelBoxTopLeft.Size = new System.Drawing.Size(50, 13);
            this.labelBoxTopLeft.TabIndex = 18;
            this.labelBoxTopLeft.Text = "Top Left:";
            // 
            // groupBoxVert
            // 
            this.groupBoxVert.Controls.Add(this.checkBoxVertRemovable);
            this.groupBoxVert.Controls.Add(this.checkBoxVertFiniteEnd);
            this.groupBoxVert.Controls.Add(this.checkBoxVertFiniteStart);
            this.groupBoxVert.Controls.Add(this.textBoxVertX);
            this.groupBoxVert.Controls.Add(this.labelVertX);
            this.groupBoxVert.Controls.Add(this.textBoxVertBot);
            this.groupBoxVert.Controls.Add(this.labelVertBot);
            this.groupBoxVert.Controls.Add(this.textBoxVertTop);
            this.groupBoxVert.Controls.Add(this.labelVertTop);
            this.groupBoxVert.Location = new System.Drawing.Point(7, 206);
            this.groupBoxVert.Name = "groupBoxVert";
            this.groupBoxVert.Size = new System.Drawing.Size(184, 131);
            this.groupBoxVert.TabIndex = 7;
            this.groupBoxVert.TabStop = false;
            this.groupBoxVert.Text = " Wall - Vertical ";
            this.groupBoxVert.Visible = false;
            // 
            // checkBoxVertRemovable
            // 
            this.checkBoxVertRemovable.AutoSize = true;
            this.checkBoxVertRemovable.Location = new System.Drawing.Point(9, 107);
            this.checkBoxVertRemovable.Name = "checkBoxVertRemovable";
            this.checkBoxVertRemovable.Size = new System.Drawing.Size(80, 17);
            this.checkBoxVertRemovable.TabIndex = 14;
            this.checkBoxVertRemovable.Text = "Removable";
            this.checkBoxVertRemovable.UseVisualStyleBackColor = true;
            this.checkBoxVertRemovable.CheckedChanged += new System.EventHandler(this.checkBoxVertRemovable_CheckedChanged);
            // 
            // checkBoxVertFiniteEnd
            // 
            this.checkBoxVertFiniteEnd.AutoSize = true;
            this.checkBoxVertFiniteEnd.Checked = true;
            this.checkBoxVertFiniteEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVertFiniteEnd.Location = new System.Drawing.Point(103, 84);
            this.checkBoxVertFiniteEnd.Name = "checkBoxVertFiniteEnd";
            this.checkBoxVertFiniteEnd.Size = new System.Drawing.Size(72, 17);
            this.checkBoxVertFiniteEnd.TabIndex = 13;
            this.checkBoxVertFiniteEnd.Text = "Finite end";
            this.checkBoxVertFiniteEnd.UseVisualStyleBackColor = true;
            this.checkBoxVertFiniteEnd.CheckedChanged += new System.EventHandler(this.checkBoxVertFiniteEnd_CheckedChanged);
            // 
            // checkBoxVertFiniteStart
            // 
            this.checkBoxVertFiniteStart.AutoSize = true;
            this.checkBoxVertFiniteStart.Checked = true;
            this.checkBoxVertFiniteStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVertFiniteStart.Location = new System.Drawing.Point(9, 84);
            this.checkBoxVertFiniteStart.Name = "checkBoxVertFiniteStart";
            this.checkBoxVertFiniteStart.Size = new System.Drawing.Size(74, 17);
            this.checkBoxVertFiniteStart.TabIndex = 0;
            this.checkBoxVertFiniteStart.Text = "Finite start";
            this.checkBoxVertFiniteStart.UseVisualStyleBackColor = true;
            this.checkBoxVertFiniteStart.CheckedChanged += new System.EventHandler(this.checkBoxVertFiniteStart_CheckedChanged);
            // 
            // textBoxVertX
            // 
            this.textBoxVertX.Location = new System.Drawing.Point(38, 46);
            this.textBoxVertX.Name = "textBoxVertX";
            this.textBoxVertX.Size = new System.Drawing.Size(47, 20);
            this.textBoxVertX.TabIndex = 11;
            this.textBoxVertX.Text = "0.5000";
            this.textBoxVertX.TextChanged += new System.EventHandler(this.textBoxVertX_TextChanged);
            // 
            // labelVertX
            // 
            this.labelVertX.AutoSize = true;
            this.labelVertX.Location = new System.Drawing.Point(18, 49);
            this.labelVertX.Name = "labelVertX";
            this.labelVertX.Size = new System.Drawing.Size(17, 13);
            this.labelVertX.TabIndex = 12;
            this.labelVertX.Text = "X:";
            // 
            // textBoxVertBot
            // 
            this.textBoxVertBot.Location = new System.Drawing.Point(130, 25);
            this.textBoxVertBot.Name = "textBoxVertBot";
            this.textBoxVertBot.Size = new System.Drawing.Size(47, 20);
            this.textBoxVertBot.TabIndex = 9;
            this.textBoxVertBot.Text = "1.0000";
            this.textBoxVertBot.TextChanged += new System.EventHandler(this.textBoxVertBot_TextChanged);
            // 
            // labelVertBot
            // 
            this.labelVertBot.AutoSize = true;
            this.labelVertBot.Location = new System.Drawing.Point(87, 28);
            this.labelVertBot.Name = "labelVertBot";
            this.labelVertBot.Size = new System.Drawing.Size(43, 13);
            this.labelVertBot.TabIndex = 10;
            this.labelVertBot.Text = "Bottom:";
            // 
            // textBoxVertTop
            // 
            this.textBoxVertTop.Location = new System.Drawing.Point(38, 25);
            this.textBoxVertTop.Name = "textBoxVertTop";
            this.textBoxVertTop.Size = new System.Drawing.Size(47, 20);
            this.textBoxVertTop.TabIndex = 7;
            this.textBoxVertTop.Text = "0.0000";
            this.textBoxVertTop.TextChanged += new System.EventHandler(this.textBoxVertTop_TextChanged);
            // 
            // labelVertTop
            // 
            this.labelVertTop.AutoSize = true;
            this.labelVertTop.Location = new System.Drawing.Point(7, 28);
            this.labelVertTop.Name = "labelVertTop";
            this.labelVertTop.Size = new System.Drawing.Size(29, 13);
            this.labelVertTop.TabIndex = 8;
            this.labelVertTop.Text = "Top:";
            // 
            // groupBoxHorz
            // 
            this.groupBoxHorz.Controls.Add(this.checkBoxHorzRemovable);
            this.groupBoxHorz.Controls.Add(this.checkBoxHorzFiniteEnd);
            this.groupBoxHorz.Controls.Add(this.checkBoxHorzFiniteStart);
            this.groupBoxHorz.Controls.Add(this.textBoxHorzY);
            this.groupBoxHorz.Controls.Add(this.labelHorzY);
            this.groupBoxHorz.Controls.Add(this.textBoxHorzRight);
            this.groupBoxHorz.Controls.Add(this.labelHorzRight);
            this.groupBoxHorz.Controls.Add(this.textBoxHorzLeft);
            this.groupBoxHorz.Controls.Add(this.labelHorzLeft);
            this.groupBoxHorz.Location = new System.Drawing.Point(7, 206);
            this.groupBoxHorz.Name = "groupBoxHorz";
            this.groupBoxHorz.Size = new System.Drawing.Size(184, 133);
            this.groupBoxHorz.TabIndex = 0;
            this.groupBoxHorz.TabStop = false;
            this.groupBoxHorz.Text = " Wall - Horizontal ";
            this.groupBoxHorz.Visible = false;
            // 
            // checkBoxHorzRemovable
            // 
            this.checkBoxHorzRemovable.AutoSize = true;
            this.checkBoxHorzRemovable.Location = new System.Drawing.Point(9, 105);
            this.checkBoxHorzRemovable.Name = "checkBoxHorzRemovable";
            this.checkBoxHorzRemovable.Size = new System.Drawing.Size(80, 17);
            this.checkBoxHorzRemovable.TabIndex = 14;
            this.checkBoxHorzRemovable.Text = "Removable";
            this.checkBoxHorzRemovable.UseVisualStyleBackColor = true;
            this.checkBoxHorzRemovable.CheckedChanged += new System.EventHandler(this.checkBoxHorzRemovable_CheckedChanged);
            // 
            // checkBoxHorzFiniteEnd
            // 
            this.checkBoxHorzFiniteEnd.AutoSize = true;
            this.checkBoxHorzFiniteEnd.Checked = true;
            this.checkBoxHorzFiniteEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHorzFiniteEnd.Location = new System.Drawing.Point(103, 84);
            this.checkBoxHorzFiniteEnd.Name = "checkBoxHorzFiniteEnd";
            this.checkBoxHorzFiniteEnd.Size = new System.Drawing.Size(72, 17);
            this.checkBoxHorzFiniteEnd.TabIndex = 13;
            this.checkBoxHorzFiniteEnd.Text = "Finite end";
            this.checkBoxHorzFiniteEnd.UseVisualStyleBackColor = true;
            this.checkBoxHorzFiniteEnd.CheckedChanged += new System.EventHandler(this.checkBoxHorzFiniteEnd_CheckedChanged);
            // 
            // checkBoxHorzFiniteStart
            // 
            this.checkBoxHorzFiniteStart.AutoSize = true;
            this.checkBoxHorzFiniteStart.Checked = true;
            this.checkBoxHorzFiniteStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHorzFiniteStart.Location = new System.Drawing.Point(9, 84);
            this.checkBoxHorzFiniteStart.Name = "checkBoxHorzFiniteStart";
            this.checkBoxHorzFiniteStart.Size = new System.Drawing.Size(74, 17);
            this.checkBoxHorzFiniteStart.TabIndex = 0;
            this.checkBoxHorzFiniteStart.Text = "Finite start";
            this.checkBoxHorzFiniteStart.UseVisualStyleBackColor = true;
            this.checkBoxHorzFiniteStart.CheckedChanged += new System.EventHandler(this.checkBoxHorzFiniteStart_CheckedChanged);
            // 
            // textBoxHorzY
            // 
            this.textBoxHorzY.Location = new System.Drawing.Point(38, 51);
            this.textBoxHorzY.Name = "textBoxHorzY";
            this.textBoxHorzY.Size = new System.Drawing.Size(47, 20);
            this.textBoxHorzY.TabIndex = 11;
            this.textBoxHorzY.Text = "0.5000";
            this.textBoxHorzY.TextChanged += new System.EventHandler(this.textBoxHorzY_TextChanged);
            // 
            // labelHorzY
            // 
            this.labelHorzY.AutoSize = true;
            this.labelHorzY.Location = new System.Drawing.Point(18, 54);
            this.labelHorzY.Name = "labelHorzY";
            this.labelHorzY.Size = new System.Drawing.Size(17, 13);
            this.labelHorzY.TabIndex = 12;
            this.labelHorzY.Text = "Y:";
            // 
            // textBoxHorzRight
            // 
            this.textBoxHorzRight.Location = new System.Drawing.Point(130, 25);
            this.textBoxHorzRight.Name = "textBoxHorzRight";
            this.textBoxHorzRight.Size = new System.Drawing.Size(47, 20);
            this.textBoxHorzRight.TabIndex = 9;
            this.textBoxHorzRight.Text = "1.0000";
            this.textBoxHorzRight.TextChanged += new System.EventHandler(this.textBoxHorzRight_TextChanged);
            // 
            // labelHorzRight
            // 
            this.labelHorzRight.AutoSize = true;
            this.labelHorzRight.Location = new System.Drawing.Point(92, 28);
            this.labelHorzRight.Name = "labelHorzRight";
            this.labelHorzRight.Size = new System.Drawing.Size(35, 13);
            this.labelHorzRight.TabIndex = 10;
            this.labelHorzRight.Text = "Right:";
            // 
            // textBoxHorzLeft
            // 
            this.textBoxHorzLeft.Location = new System.Drawing.Point(38, 25);
            this.textBoxHorzLeft.Name = "textBoxHorzLeft";
            this.textBoxHorzLeft.Size = new System.Drawing.Size(47, 20);
            this.textBoxHorzLeft.TabIndex = 7;
            this.textBoxHorzLeft.Text = "0.0000";
            this.textBoxHorzLeft.TextChanged += new System.EventHandler(this.textBoxHorzLeft_TextChanged);
            // 
            // labelHorzLeft
            // 
            this.labelHorzLeft.AutoSize = true;
            this.labelHorzLeft.Location = new System.Drawing.Point(7, 28);
            this.labelHorzLeft.Name = "labelHorzLeft";
            this.labelHorzLeft.Size = new System.Drawing.Size(28, 13);
            this.labelHorzLeft.TabIndex = 8;
            this.labelHorzLeft.Text = "Left:";
            // 
            // labelObjSel
            // 
            this.labelObjSel.AutoSize = true;
            this.labelObjSel.Location = new System.Drawing.Point(14, 109);
            this.labelObjSel.Name = "labelObjSel";
            this.labelObjSel.Size = new System.Drawing.Size(84, 13);
            this.labelObjSel.TabIndex = 6;
            this.labelObjSel.Text = "Object selected:";
            // 
            // textBoxNumBallSets
            // 
            this.textBoxNumBallSets.Location = new System.Drawing.Point(135, 66);
            this.textBoxNumBallSets.Name = "textBoxNumBallSets";
            this.textBoxNumBallSets.ReadOnly = true;
            this.textBoxNumBallSets.Size = new System.Drawing.Size(42, 20);
            this.textBoxNumBallSets.TabIndex = 3;
            this.textBoxNumBallSets.Text = "0";
            // 
            // labelNumBallSets
            // 
            this.labelNumBallSets.AutoSize = true;
            this.labelNumBallSets.Location = new System.Drawing.Point(14, 69);
            this.labelNumBallSets.Name = "labelNumBallSets";
            this.labelNumBallSets.Size = new System.Drawing.Size(100, 13);
            this.labelNumBallSets.TabIndex = 4;
            this.labelNumBallSets.Text = "Number of ball sets:";
            // 
            // textBoxNumWalls
            // 
            this.textBoxNumWalls.Location = new System.Drawing.Point(135, 47);
            this.textBoxNumWalls.Name = "textBoxNumWalls";
            this.textBoxNumWalls.ReadOnly = true;
            this.textBoxNumWalls.Size = new System.Drawing.Size(42, 20);
            this.textBoxNumWalls.TabIndex = 1;
            this.textBoxNumWalls.Text = "0";
            // 
            // labelNumWalls
            // 
            this.labelNumWalls.AutoSize = true;
            this.labelNumWalls.Location = new System.Drawing.Point(14, 50);
            this.labelNumWalls.Name = "labelNumWalls";
            this.labelNumWalls.Size = new System.Drawing.Size(85, 13);
            this.labelNumWalls.TabIndex = 2;
            this.labelNumWalls.Text = "Number of walls:";
            // 
            // textBoxNumObjs
            // 
            this.textBoxNumObjs.Location = new System.Drawing.Point(135, 28);
            this.textBoxNumObjs.Name = "textBoxNumObjs";
            this.textBoxNumObjs.ReadOnly = true;
            this.textBoxNumObjs.Size = new System.Drawing.Size(42, 20);
            this.textBoxNumObjs.TabIndex = 0;
            this.textBoxNumObjs.Text = "0";
            // 
            // labelNumObjs
            // 
            this.labelNumObjs.AutoSize = true;
            this.labelNumObjs.Location = new System.Drawing.Point(14, 31);
            this.labelNumObjs.Name = "labelNumObjs";
            this.labelNumObjs.Size = new System.Drawing.Size(96, 13);
            this.labelNumObjs.TabIndex = 0;
            this.labelNumObjs.Text = "Number of objects:";
            // 
            // groupBoxParabola
            // 
            this.groupBoxParabola.Controls.Add(this.checkBoxParabolaRemovable);
            this.groupBoxParabola.Controls.Add(this.textBoxParabolaHeight);
            this.groupBoxParabola.Controls.Add(this.textBoxParabolaWidth);
            this.groupBoxParabola.Controls.Add(this.label1);
            this.groupBoxParabola.Controls.Add(this.textBoxParabolaY);
            this.groupBoxParabola.Controls.Add(this.textBoxParabolaX);
            this.groupBoxParabola.Controls.Add(this.label2);
            this.groupBoxParabola.Location = new System.Drawing.Point(7, 229);
            this.groupBoxParabola.Name = "groupBoxParabola";
            this.groupBoxParabola.Size = new System.Drawing.Size(184, 103);
            this.groupBoxParabola.TabIndex = 12;
            this.groupBoxParabola.TabStop = false;
            this.groupBoxParabola.Text = " Wall - Parabola ";
            this.groupBoxParabola.Visible = false;
            // 
            // checkBoxParabolaRemovable
            // 
            this.checkBoxParabolaRemovable.AutoSize = true;
            this.checkBoxParabolaRemovable.Location = new System.Drawing.Point(9, 72);
            this.checkBoxParabolaRemovable.Name = "checkBoxParabolaRemovable";
            this.checkBoxParabolaRemovable.Size = new System.Drawing.Size(86, 17);
            this.checkBoxParabolaRemovable.TabIndex = 26;
            this.checkBoxParabolaRemovable.Text = "Removeable";
            this.checkBoxParabolaRemovable.UseVisualStyleBackColor = true;
            this.checkBoxParabolaRemovable.CheckedChanged += new System.EventHandler(this.checkBoxParabolaRemovable_CheckedChanged);
            // 
            // textBoxParabolaHeight
            // 
            this.textBoxParabolaHeight.Location = new System.Drawing.Point(130, 44);
            this.textBoxParabolaHeight.Name = "textBoxParabolaHeight";
            this.textBoxParabolaHeight.Size = new System.Drawing.Size(47, 20);
            this.textBoxParabolaHeight.TabIndex = 22;
            this.textBoxParabolaHeight.Text = "1.0000";
            this.textBoxParabolaHeight.TextChanged += new System.EventHandler(this.textBoxParabolaHeight_TextChanged);
            // 
            // textBoxParabolaWidth
            // 
            this.textBoxParabolaWidth.Location = new System.Drawing.Point(77, 44);
            this.textBoxParabolaWidth.Name = "textBoxParabolaWidth";
            this.textBoxParabolaWidth.Size = new System.Drawing.Size(47, 20);
            this.textBoxParabolaWidth.TabIndex = 20;
            this.textBoxParabolaWidth.Text = "1.0000";
            this.textBoxParabolaWidth.TextChanged += new System.EventHandler(this.textBoxParabolaWidth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Wid Hei:";
            // 
            // textBoxParabolaY
            // 
            this.textBoxParabolaY.Location = new System.Drawing.Point(130, 23);
            this.textBoxParabolaY.Name = "textBoxParabolaY";
            this.textBoxParabolaY.Size = new System.Drawing.Size(47, 20);
            this.textBoxParabolaY.TabIndex = 19;
            this.textBoxParabolaY.Text = "0.0000";
            this.textBoxParabolaY.TextChanged += new System.EventHandler(this.textBoxParabolaY_TextChanged);
            // 
            // textBoxParabolaX
            // 
            this.textBoxParabolaX.Location = new System.Drawing.Point(77, 23);
            this.textBoxParabolaX.Name = "textBoxParabolaX";
            this.textBoxParabolaX.Size = new System.Drawing.Size(47, 20);
            this.textBoxParabolaX.TabIndex = 17;
            this.textBoxParabolaX.Text = "0.0000";
            this.textBoxParabolaX.TextChanged += new System.EventHandler(this.textBoxParabolaX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Top Left:";
            // 
            // toolStripButtonSaveLevelAsImage
            // 
            this.toolStripButtonSaveLevelAsImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSaveLevelAsImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSaveLevelAsImage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveLevelAsImage.Image")));
            this.toolStripButtonSaveLevelAsImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveLevelAsImage.Name = "toolStripButtonSaveLevelAsImage";
            this.toolStripButtonSaveLevelAsImage.Size = new System.Drawing.Size(153, 25);
            this.toolStripButtonSaveLevelAsImage.Text = "Save Level as Image";
            this.toolStripButtonSaveLevelAsImage.Click += new System.EventHandler(this.toolStripButtonSaveLevelAsImage_Click);
            // 
            // textBoxArcStartY
            // 
            this.textBoxArcStartY.Location = new System.Drawing.Point(130, 134);
            this.textBoxArcStartY.Name = "textBoxArcStartY";
            this.textBoxArcStartY.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcStartY.TabIndex = 24;
            this.textBoxArcStartY.Text = "0.0000";
            this.textBoxArcStartY.TextChanged += new System.EventHandler(this.textBoxArcStartY_TextChanged);
            // 
            // textBoxArcStartX
            // 
            this.textBoxArcStartX.Location = new System.Drawing.Point(77, 134);
            this.textBoxArcStartX.Name = "textBoxArcStartX";
            this.textBoxArcStartX.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcStartX.TabIndex = 22;
            this.textBoxArcStartX.Text = "0.0000";
            this.textBoxArcStartX.TextChanged += new System.EventHandler(this.textBoxArcStartX_TextChanged);
            // 
            // labelArcStart
            // 
            this.labelArcStart.AutoSize = true;
            this.labelArcStart.Location = new System.Drawing.Point(7, 137);
            this.labelArcStart.Name = "labelArcStart";
            this.labelArcStart.Size = new System.Drawing.Size(32, 13);
            this.labelArcStart.TabIndex = 23;
            this.labelArcStart.Text = "Start:";
            // 
            // textBoxArcEndY
            // 
            this.textBoxArcEndY.Location = new System.Drawing.Point(130, 155);
            this.textBoxArcEndY.Name = "textBoxArcEndY";
            this.textBoxArcEndY.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcEndY.TabIndex = 27;
            this.textBoxArcEndY.Text = "0.0000";
            this.textBoxArcEndY.TextChanged += new System.EventHandler(this.textBoxArcEndY_TextChanged);
            // 
            // textBoxArcEndX
            // 
            this.textBoxArcEndX.Location = new System.Drawing.Point(77, 155);
            this.textBoxArcEndX.Name = "textBoxArcEndX";
            this.textBoxArcEndX.Size = new System.Drawing.Size(47, 20);
            this.textBoxArcEndX.TabIndex = 25;
            this.textBoxArcEndX.Text = "0.0000";
            this.textBoxArcEndX.TextChanged += new System.EventHandler(this.textBoxArcEndX_TextChanged);
            // 
            // labelArcEnd
            // 
            this.labelArcEnd.AutoSize = true;
            this.labelArcEnd.Location = new System.Drawing.Point(7, 158);
            this.labelArcEnd.Name = "labelArcEnd";
            this.labelArcEnd.Size = new System.Drawing.Size(29, 13);
            this.labelArcEnd.TabIndex = 26;
            this.labelArcEnd.Text = "End:";
            // 
            // buttonArcSetStartAndEnd
            // 
            this.buttonArcSetStartAndEnd.Enabled = false;
            this.buttonArcSetStartAndEnd.Location = new System.Drawing.Point(6, 178);
            this.buttonArcSetStartAndEnd.Name = "buttonArcSetStartAndEnd";
            this.buttonArcSetStartAndEnd.Size = new System.Drawing.Size(172, 23);
            this.buttonArcSetStartAndEnd.TabIndex = 0;
            this.buttonArcSetStartAndEnd.Text = "Update start and end";
            this.buttonArcSetStartAndEnd.UseVisualStyleBackColor = true;
            this.buttonArcSetStartAndEnd.Click += new System.EventHandler(this.buttonArcSetStartAndEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 756);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Demon Maxwell Game Level Creator";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxArc.ResumeLayout(false);
            this.groupBoxArc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObjSel)).EndInit();
            this.groupBoxStraight.ResumeLayout(false);
            this.groupBoxStraight.PerformLayout();
            this.groupBoxBallSet.ResumeLayout(false);
            this.groupBoxBallSet.PerformLayout();
            this.groupBoxBox.ResumeLayout(false);
            this.groupBoxBox.PerformLayout();
            this.groupBoxVert.ResumeLayout(false);
            this.groupBoxVert.PerformLayout();
            this.groupBoxHorz.ResumeLayout(false);
            this.groupBoxHorz.PerformLayout();
            this.groupBoxParabola.ResumeLayout(false);
            this.groupBoxParabola.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadBck;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoadLevel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonAddWall;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemArc;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorz;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVert;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStraight;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemParabola;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddBalls;
        private System.Windows.Forms.Panel panelLevel;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveLevel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelNumObjs;
        private System.Windows.Forms.TextBox textBoxNumObjs;
        private System.Windows.Forms.TextBox textBoxNumWalls;
        private System.Windows.Forms.Label labelNumWalls;
        private System.Windows.Forms.TextBox textBoxNumBallSets;
        private System.Windows.Forms.Label labelNumBallSets;
        private System.Windows.Forms.Label labelObjSel;
        private System.Windows.Forms.GroupBox groupBoxHorz;
        private System.Windows.Forms.TextBox textBoxHorzLeft;
        private System.Windows.Forms.Label labelHorzLeft;
        private System.Windows.Forms.TextBox textBoxHorzRight;
        private System.Windows.Forms.Label labelHorzRight;
        private System.Windows.Forms.TextBox textBoxHorzY;
        private System.Windows.Forms.Label labelHorzY;
        private System.Windows.Forms.CheckBox checkBoxHorzFiniteEnd;
        private System.Windows.Forms.CheckBox checkBoxHorzFiniteStart;
        private System.Windows.Forms.CheckBox checkBoxHorzRemovable;
        private System.Windows.Forms.GroupBox groupBoxVert;
        private System.Windows.Forms.CheckBox checkBoxVertRemovable;
        private System.Windows.Forms.CheckBox checkBoxVertFiniteEnd;
        private System.Windows.Forms.CheckBox checkBoxVertFiniteStart;
        private System.Windows.Forms.TextBox textBoxVertX;
        private System.Windows.Forms.Label labelVertX;
        private System.Windows.Forms.TextBox textBoxVertBot;
        private System.Windows.Forms.Label labelVertBot;
        private System.Windows.Forms.TextBox textBoxVertTop;
        private System.Windows.Forms.Label labelVertTop;
        private System.Windows.Forms.GroupBox groupBoxBox;
        private System.Windows.Forms.GroupBox groupBoxBallSet;
        private System.Windows.Forms.GroupBox groupBoxStraight;
        private System.Windows.Forms.TextBox textBoxStraightStartY;
        private System.Windows.Forms.TextBox textBoxStraightStartX;
        private System.Windows.Forms.Label labelStraightStart;
        private System.Windows.Forms.TextBox textBoxStraightEndY;
        private System.Windows.Forms.TextBox textBoxStraightEndX;
        private System.Windows.Forms.Label labelStraightEnd;
        private System.Windows.Forms.CheckBox checkBoxStraightRemovable;
        private System.Windows.Forms.TextBox textBoxBoxHeight;
        private System.Windows.Forms.TextBox textBoxBoxWidth;
        private System.Windows.Forms.Label labelBoxWidHei;
        private System.Windows.Forms.TextBox textBoxBoxY;
        private System.Windows.Forms.TextBox textBoxBoxX;
        private System.Windows.Forms.Label labelBoxTopLeft;
        private System.Windows.Forms.CheckBox checkBoxBoxMoveableY;
        private System.Windows.Forms.CheckBox checkBoxBoxMoveableX;
        private System.Windows.Forms.CheckBox checkBoxBoxRemovable;
        private System.Windows.Forms.CheckBox checkBoxBoxBounceCorners;
        private System.Windows.Forms.TextBox textBoxBallSetHei;
        private System.Windows.Forms.TextBox textBoxBallSetWid;
        private System.Windows.Forms.Label labelBallSetWidHei;
        private System.Windows.Forms.TextBox textBoxBallSetY;
        private System.Windows.Forms.TextBox textBoxBallSetX;
        private System.Windows.Forms.Label labelBallSetTopLeft;
        private System.Windows.Forms.TextBox textBoxBallSetVelRange;
        private System.Windows.Forms.Label labelBallSetVelRange;
        private System.Windows.Forms.TextBox textBoxBallSetRadius;
        private System.Windows.Forms.Label labelBallSetRadius;
        private System.Windows.Forms.TextBox textBoxBallSetGravityY;
        private System.Windows.Forms.TextBox textBoxBallSetGravityX;
        private System.Windows.Forms.Label labelBallSetGravity;
        private System.Windows.Forms.TextBox textBoxBallSetColB;
        private System.Windows.Forms.TextBox textBoxBallSetColG;
        private System.Windows.Forms.TextBox textBoxBallSetColR;
        private System.Windows.Forms.Label labelBallSetCol;
        private System.Windows.Forms.TextBox textBoxBallSetNumBalls;
        private System.Windows.Forms.Label labelBallSetNumBalls;
        private System.Windows.Forms.NumericUpDown numericUpDownObjSel;
        private System.Windows.Forms.Label labelLevelNum;
        private System.Windows.Forms.TextBox textBoxLevelNum;
        private System.Windows.Forms.TextBox textBoxTotalNumBalls;
        private System.Windows.Forms.Label labelTotalNumBalls;
        private System.Windows.Forms.Label labelCoords;
        private System.Windows.Forms.Label labelCurrCursorCoords;
        private System.Windows.Forms.Button buttonSnapToNearest;
        private System.Windows.Forms.GroupBox groupBoxArc;
        private System.Windows.Forms.CheckBox checkBoxArcRemovable;
        private System.Windows.Forms.TextBox textBoxArcRadius;
        private System.Windows.Forms.Label labelArcRadius;
        private System.Windows.Forms.TextBox textBoxArcCentreY;
        private System.Windows.Forms.TextBox textBoxArcCentreX;
        private System.Windows.Forms.Label labelArcCentre;
        private System.Windows.Forms.TextBox textBoxArcAngleTo;
        private System.Windows.Forms.Label labelArcStartEndTo;
        private System.Windows.Forms.TextBox textBoxArcAngleFrom;
        private System.Windows.Forms.Label labelArcStartEnd;
        private System.Windows.Forms.GroupBox groupBoxParabola;
        private System.Windows.Forms.CheckBox checkBoxParabolaRemovable;
        private System.Windows.Forms.TextBox textBoxParabolaHeight;
        private System.Windows.Forms.TextBox textBoxParabolaWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParabolaY;
        private System.Windows.Forms.TextBox textBoxParabolaX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveLevelAsImage;
        private System.Windows.Forms.TextBox textBoxArcEndY;
        private System.Windows.Forms.TextBox textBoxArcEndX;
        private System.Windows.Forms.Label labelArcEnd;
        private System.Windows.Forms.TextBox textBoxArcStartY;
        private System.Windows.Forms.TextBox textBoxArcStartX;
        private System.Windows.Forms.Label labelArcStart;
        private System.Windows.Forms.Button buttonArcSetStartAndEnd;
    }
}

