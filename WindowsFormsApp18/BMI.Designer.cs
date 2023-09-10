
namespace WindowsFormsApp18
{
    partial class BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI));
            this.output = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.calculator = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specificUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workoutChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bicepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumbellCurlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hammerCurlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoulderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overheadPressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barbellShToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arnoldPressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standingCalfRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.legPressCalfRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neckBridgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperAbsWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumbBellCrunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerAbsWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hangingLegRaisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grammerRaiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tricepWorkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGripBenchPressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.declineTricepsExtensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forearmWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.behindtheBackCableCurlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eZBarPreacherCurlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(140, 366);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(310, 59);
            this.output.TabIndex = 17;
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(140, 457);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(310, 84);
            this.answer.TabIndex = 16;
            // 
            // calculator
            // 
            this.calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculator.Location = new System.Drawing.Point(159, 289);
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(103, 33);
            this.calculator.TabIndex = 15;
            this.calculator.Text = "Calculate";
            this.calculator.UseVisualStyleBackColor = true;
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(333, 289);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(103, 33);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Body Mass Index(BMI) Calculator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.dataLoadToolStripMenuItem,
            this.workoutChartToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.searchToolStripMenuItem.Text = "Search ";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // dataLoadToolStripMenuItem
            // 
            this.dataLoadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.specificUserToolStripMenuItem});
            this.dataLoadToolStripMenuItem.Name = "dataLoadToolStripMenuItem";
            this.dataLoadToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.dataLoadToolStripMenuItem.Text = "Registered users";
            this.dataLoadToolStripMenuItem.Click += new System.EventHandler(this.dataLoadToolStripMenuItem_Click);
            // 
            // specificUserToolStripMenuItem
            // 
            this.specificUserToolStripMenuItem.Name = "specificUserToolStripMenuItem";
            this.specificUserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.specificUserToolStripMenuItem.Text = "Users";
            this.specificUserToolStripMenuItem.Click += new System.EventHandler(this.specificUserToolStripMenuItem_Click);
            // 
            // workoutChartToolStripMenuItem
            // 
            this.workoutChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bicepToolStripMenuItem,
            this.shoulderToolStripMenuItem,
            this.calfToolStripMenuItem,
            this.neckToolStripMenuItem,
            this.upperAbsWorkoutToolStripMenuItem,
            this.lowerAbsWorkoutToolStripMenuItem,
            this.tricepWorkOutToolStripMenuItem,
            this.forearmWorkoutToolStripMenuItem});
            this.workoutChartToolStripMenuItem.Name = "workoutChartToolStripMenuItem";
            this.workoutChartToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.workoutChartToolStripMenuItem.Text = "Workout Chart";
            // 
            // bicepToolStripMenuItem
            // 
            this.bicepToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bicepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumbellCurlToolStripMenuItem,
            this.hammerCurlToolStripMenuItem});
            this.bicepToolStripMenuItem.Name = "bicepToolStripMenuItem";
            this.bicepToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bicepToolStripMenuItem.Text = "Bicep Workout";
            // 
            // dumbellCurlToolStripMenuItem
            // 
            this.dumbellCurlToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dumbellCurlToolStripMenuItem.Name = "dumbellCurlToolStripMenuItem";
            this.dumbellCurlToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.dumbellCurlToolStripMenuItem.Text = "Dumbell Curl";
            this.dumbellCurlToolStripMenuItem.Click += new System.EventHandler(this.dumbellCurlToolStripMenuItem_Click);
            // 
            // hammerCurlToolStripMenuItem
            // 
            this.hammerCurlToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.hammerCurlToolStripMenuItem.Name = "hammerCurlToolStripMenuItem";
            this.hammerCurlToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.hammerCurlToolStripMenuItem.Text = "Hammer Curl";
            this.hammerCurlToolStripMenuItem.Click += new System.EventHandler(this.hammerCurlToolStripMenuItem_Click);
            // 
            // shoulderToolStripMenuItem
            // 
            this.shoulderToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.shoulderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overheadPressToolStripMenuItem,
            this.barbellShToolStripMenuItem,
            this.arnoldPressToolStripMenuItem});
            this.shoulderToolStripMenuItem.Name = "shoulderToolStripMenuItem";
            this.shoulderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.shoulderToolStripMenuItem.Text = "Shoulder Workout";
            // 
            // overheadPressToolStripMenuItem
            // 
            this.overheadPressToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.overheadPressToolStripMenuItem.Name = "overheadPressToolStripMenuItem";
            this.overheadPressToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.overheadPressToolStripMenuItem.Text = "Overhead Press";
            this.overheadPressToolStripMenuItem.Click += new System.EventHandler(this.overheadPressToolStripMenuItem_Click);
            // 
            // barbellShToolStripMenuItem
            // 
            this.barbellShToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.barbellShToolStripMenuItem.Name = "barbellShToolStripMenuItem";
            this.barbellShToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.barbellShToolStripMenuItem.Text = "Barbell Shrug";
            this.barbellShToolStripMenuItem.Click += new System.EventHandler(this.barbellShToolStripMenuItem_Click);
            // 
            // arnoldPressToolStripMenuItem
            // 
            this.arnoldPressToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.arnoldPressToolStripMenuItem.Name = "arnoldPressToolStripMenuItem";
            this.arnoldPressToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.arnoldPressToolStripMenuItem.Text = "Arnold Press";
            this.arnoldPressToolStripMenuItem.Click += new System.EventHandler(this.arnoldPressToolStripMenuItem_Click);
            // 
            // calfToolStripMenuItem
            // 
            this.calfToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.calfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standingCalfRaiseToolStripMenuItem,
            this.legPressCalfRaiseToolStripMenuItem});
            this.calfToolStripMenuItem.Name = "calfToolStripMenuItem";
            this.calfToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.calfToolStripMenuItem.Text = "Calf Workout";
            // 
            // standingCalfRaiseToolStripMenuItem
            // 
            this.standingCalfRaiseToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.standingCalfRaiseToolStripMenuItem.Name = "standingCalfRaiseToolStripMenuItem";
            this.standingCalfRaiseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.standingCalfRaiseToolStripMenuItem.Text = "Standing Calf Raise";
            this.standingCalfRaiseToolStripMenuItem.Click += new System.EventHandler(this.standingCalfRaiseToolStripMenuItem_Click);
            // 
            // legPressCalfRaiseToolStripMenuItem
            // 
            this.legPressCalfRaiseToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.legPressCalfRaiseToolStripMenuItem.Name = "legPressCalfRaiseToolStripMenuItem";
            this.legPressCalfRaiseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.legPressCalfRaiseToolStripMenuItem.Text = "Leg Press Calf Raise";
            this.legPressCalfRaiseToolStripMenuItem.Click += new System.EventHandler(this.legPressCalfRaiseToolStripMenuItem_Click);
            // 
            // neckToolStripMenuItem
            // 
            this.neckToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.neckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neckBridgeToolStripMenuItem,
            this.backExtensionToolStripMenuItem});
            this.neckToolStripMenuItem.Name = "neckToolStripMenuItem";
            this.neckToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.neckToolStripMenuItem.Text = "Neck Workout";
            // 
            // neckBridgeToolStripMenuItem
            // 
            this.neckBridgeToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.neckBridgeToolStripMenuItem.Name = "neckBridgeToolStripMenuItem";
            this.neckBridgeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.neckBridgeToolStripMenuItem.Text = "Neck Bridge";
            this.neckBridgeToolStripMenuItem.Click += new System.EventHandler(this.neckBridgeToolStripMenuItem_Click);
            // 
            // backExtensionToolStripMenuItem
            // 
            this.backExtensionToolStripMenuItem.BackColor = System.Drawing.Color.LightSalmon;
            this.backExtensionToolStripMenuItem.Name = "backExtensionToolStripMenuItem";
            this.backExtensionToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.backExtensionToolStripMenuItem.Text = "Back Extension";
            this.backExtensionToolStripMenuItem.Click += new System.EventHandler(this.backExtensionToolStripMenuItem_Click);
            // 
            // upperAbsWorkoutToolStripMenuItem
            // 
            this.upperAbsWorkoutToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.upperAbsWorkoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dumbBellCrunchToolStripMenuItem,
            this.tuckToolStripMenuItem});
            this.upperAbsWorkoutToolStripMenuItem.Name = "upperAbsWorkoutToolStripMenuItem";
            this.upperAbsWorkoutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.upperAbsWorkoutToolStripMenuItem.Text = "Upper Abs Workout";
            // 
            // dumbBellCrunchToolStripMenuItem
            // 
            this.dumbBellCrunchToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.dumbBellCrunchToolStripMenuItem.Name = "dumbBellCrunchToolStripMenuItem";
            this.dumbBellCrunchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dumbBellCrunchToolStripMenuItem.Text = "Dumbbell Crunch";
            this.dumbBellCrunchToolStripMenuItem.Click += new System.EventHandler(this.dumbBellCrunchToolStripMenuItem_Click);
            // 
            // tuckToolStripMenuItem
            // 
            this.tuckToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.tuckToolStripMenuItem.Name = "tuckToolStripMenuItem";
            this.tuckToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.tuckToolStripMenuItem.Text = "Tuck and Crunch";
            this.tuckToolStripMenuItem.Click += new System.EventHandler(this.tuckToolStripMenuItem_Click);
            // 
            // lowerAbsWorkoutToolStripMenuItem
            // 
            this.lowerAbsWorkoutToolStripMenuItem.BackColor = System.Drawing.Color.YellowGreen;
            this.lowerAbsWorkoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hangingLegRaisesToolStripMenuItem,
            this.grammerRaiseToolStripMenuItem});
            this.lowerAbsWorkoutToolStripMenuItem.Name = "lowerAbsWorkoutToolStripMenuItem";
            this.lowerAbsWorkoutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.lowerAbsWorkoutToolStripMenuItem.Text = "Lower Abs Workout";
            // 
            // hangingLegRaisesToolStripMenuItem
            // 
            this.hangingLegRaisesToolStripMenuItem.BackColor = System.Drawing.Color.YellowGreen;
            this.hangingLegRaisesToolStripMenuItem.Name = "hangingLegRaisesToolStripMenuItem";
            this.hangingLegRaisesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.hangingLegRaisesToolStripMenuItem.Text = "Hanging Leg Raise";
            this.hangingLegRaisesToolStripMenuItem.Click += new System.EventHandler(this.hangingLegRaisesToolStripMenuItem_Click);
            // 
            // grammerRaiseToolStripMenuItem
            // 
            this.grammerRaiseToolStripMenuItem.BackColor = System.Drawing.Color.YellowGreen;
            this.grammerRaiseToolStripMenuItem.Name = "grammerRaiseToolStripMenuItem";
            this.grammerRaiseToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.grammerRaiseToolStripMenuItem.Text = "Grammer Raise";
            this.grammerRaiseToolStripMenuItem.Click += new System.EventHandler(this.grammerRaiseToolStripMenuItem_Click);
            // 
            // tricepWorkOutToolStripMenuItem
            // 
            this.tricepWorkOutToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.tricepWorkOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeGripBenchPressToolStripMenuItem,
            this.declineTricepsExtensionToolStripMenuItem});
            this.tricepWorkOutToolStripMenuItem.Name = "tricepWorkOutToolStripMenuItem";
            this.tricepWorkOutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.tricepWorkOutToolStripMenuItem.Text = "Tricep WorkOut";
            this.tricepWorkOutToolStripMenuItem.Click += new System.EventHandler(this.tricepWorkOutToolStripMenuItem_Click);
            // 
            // closeGripBenchPressToolStripMenuItem
            // 
            this.closeGripBenchPressToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.closeGripBenchPressToolStripMenuItem.Name = "closeGripBenchPressToolStripMenuItem";
            this.closeGripBenchPressToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.closeGripBenchPressToolStripMenuItem.Text = "Close-Grip Bench Press";
            this.closeGripBenchPressToolStripMenuItem.Click += new System.EventHandler(this.closeGripBenchPressToolStripMenuItem_Click);
            // 
            // declineTricepsExtensionToolStripMenuItem
            // 
            this.declineTricepsExtensionToolStripMenuItem.BackColor = System.Drawing.Color.Turquoise;
            this.declineTricepsExtensionToolStripMenuItem.Name = "declineTricepsExtensionToolStripMenuItem";
            this.declineTricepsExtensionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.declineTricepsExtensionToolStripMenuItem.Text = "Decline Triceps Extension";
            this.declineTricepsExtensionToolStripMenuItem.Click += new System.EventHandler(this.declineTricepsExtensionToolStripMenuItem_Click);
            // 
            // forearmWorkoutToolStripMenuItem
            // 
            this.forearmWorkoutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.forearmWorkoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.behindtheBackCableCurlToolStripMenuItem,
            this.eZBarPreacherCurlToolStripMenuItem});
            this.forearmWorkoutToolStripMenuItem.Name = "forearmWorkoutToolStripMenuItem";
            this.forearmWorkoutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.forearmWorkoutToolStripMenuItem.Text = "Forearm Workout";
            // 
            // behindtheBackCableCurlToolStripMenuItem
            // 
            this.behindtheBackCableCurlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.behindtheBackCableCurlToolStripMenuItem.Name = "behindtheBackCableCurlToolStripMenuItem";
            this.behindtheBackCableCurlToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.behindtheBackCableCurlToolStripMenuItem.Text = "Behind-the-Back Cable Curl";
            this.behindtheBackCableCurlToolStripMenuItem.Click += new System.EventHandler(this.behindtheBackCableCurlToolStripMenuItem_Click);
            // 
            // eZBarPreacherCurlToolStripMenuItem
            // 
            this.eZBarPreacherCurlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.eZBarPreacherCurlToolStripMenuItem.Name = "eZBarPreacherCurlToolStripMenuItem";
            this.eZBarPreacherCurlToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.eZBarPreacherCurlToolStripMenuItem.Text = "EZ-Bar Preacher Curl";
            this.eZBarPreacherCurlToolStripMenuItem.Click += new System.EventHandler(this.eZBarPreacherCurlToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 396);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(410, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "inches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(413, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "lb";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // weight
            // 
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(201, 149);
            this.weight.Multiline = true;
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(206, 26);
            this.weight.TabIndex = 22;
            this.weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_KeyPress);
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(201, 206);
            this.height.Multiline = true;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(206, 26);
            this.height.TabIndex = 23;
            this.height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_KeyPress);
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.output);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.calculator);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BMI";
            this.Text = "BMI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button calculator;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specificUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workoutChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bicepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumbellCurlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hammerCurlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoulderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overheadPressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barbellShToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arnoldPressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standingCalfRaiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legPressCalfRaiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neckBridgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperAbsWorkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumbBellCrunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerAbsWorkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hangingLegRaisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grammerRaiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tricepWorkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeGripBenchPressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declineTricepsExtensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forearmWorkoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem behindtheBackCableCurlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eZBarPreacherCurlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
    }
}