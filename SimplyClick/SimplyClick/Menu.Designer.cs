namespace SimplyClick
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            Minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            ToggleCheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            Watermark = new Label();
            IntervalPanel = new Guna.UI2.WinForms.Guna2Panel();
            MaxDelayLabel = new Label();
            MinDelayLabel = new Label();
            ClickDelayMaxBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ClickDelayMinBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            RandomDelayCB = new Guna.UI2.WinForms.Guna2CheckBox();
            DelayTypeLabel = new Label();
            DelayTypeList = new Guna.UI2.WinForms.Guna2ComboBox();
            ClickDelayLabel = new Label();
            DelayBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            IntervalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClickDelayMaxBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ClickDelayMinBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DelayBox).BeginInit();
            SuspendLayout();
            // 
            // BorderlessForm
            // 
            BorderlessForm.BorderRadius = 6;
            BorderlessForm.ContainerControl = this;
            BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            BorderlessForm.HasFormShadow = false;
            BorderlessForm.TransparentWhileDrag = true;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Exit.BackColor = Color.Transparent;
            Exit.CustomizableEdges = customizableEdges13;
            Exit.FillColor = Color.Transparent;
            Exit.IconColor = Color.WhiteSmoke;
            Exit.Location = new Point(459, 12);
            Exit.Name = "Exit";
            Exit.ShadowDecoration.CustomizableEdges = customizableEdges14;
            Exit.Size = new Size(29, 29);
            Exit.TabIndex = 0;
            Exit.UseTransparentBackground = true;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.BackColor = Color.Transparent;
            Minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            Minimize.CustomizableEdges = customizableEdges11;
            Minimize.FillColor = Color.Transparent;
            Minimize.IconColor = Color.WhiteSmoke;
            Minimize.Location = new Point(424, 12);
            Minimize.Name = "Minimize";
            Minimize.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Minimize.Size = new Size(29, 29);
            Minimize.TabIndex = 1;
            Minimize.UseTransparentBackground = true;
            // 
            // ToggleCheckbox
            // 
            ToggleCheckbox.Animated = true;
            ToggleCheckbox.AutoSize = true;
            ToggleCheckbox.CheckedState.BorderColor = Color.Green;
            ToggleCheckbox.CheckedState.BorderRadius = 0;
            ToggleCheckbox.CheckedState.BorderThickness = 0;
            ToggleCheckbox.CheckedState.FillColor = Color.Green;
            ToggleCheckbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToggleCheckbox.Location = new Point(206, 263);
            ToggleCheckbox.Name = "ToggleCheckbox";
            ToggleCheckbox.Size = new Size(89, 25);
            ToggleCheckbox.TabIndex = 2;
            ToggleCheckbox.Text = "Disabled";
            ToggleCheckbox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            ToggleCheckbox.UncheckedState.BorderRadius = 0;
            ToggleCheckbox.UncheckedState.BorderThickness = 0;
            ToggleCheckbox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            ToggleCheckbox.CheckedChanged += ToggleCheckbox_CheckedChanged;
            // 
            // guna2Separator1
            // 
            guna2Separator1.FillColor = Color.DimGray;
            guna2Separator1.Location = new Point(12, 47);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(476, 10);
            guna2Separator1.TabIndex = 3;
            // 
            // Watermark
            // 
            Watermark.AutoSize = true;
            Watermark.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Watermark.ForeColor = Color.WhiteSmoke;
            Watermark.Location = new Point(12, 12);
            Watermark.Name = "Watermark";
            Watermark.Size = new Size(246, 30);
            Watermark.TabIndex = 4;
            Watermark.Text = "Simply Click 1.0 - InDev";
            // 
            // IntervalPanel
            // 
            IntervalPanel.BackColor = Color.Transparent;
            IntervalPanel.Controls.Add(MaxDelayLabel);
            IntervalPanel.Controls.Add(MinDelayLabel);
            IntervalPanel.Controls.Add(ClickDelayMaxBox);
            IntervalPanel.Controls.Add(ClickDelayMinBox);
            IntervalPanel.Controls.Add(RandomDelayCB);
            IntervalPanel.Controls.Add(DelayTypeLabel);
            IntervalPanel.Controls.Add(DelayTypeList);
            IntervalPanel.Controls.Add(ClickDelayLabel);
            IntervalPanel.Controls.Add(DelayBox);
            IntervalPanel.CustomizableEdges = customizableEdges9;
            IntervalPanel.FillColor = Color.FromArgb(25, 25, 25);
            IntervalPanel.Location = new Point(35, 63);
            IntervalPanel.Name = "IntervalPanel";
            IntervalPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            IntervalPanel.Size = new Size(431, 131);
            IntervalPanel.TabIndex = 5;
            IntervalPanel.UseTransparentBackground = true;
            // 
            // MaxDelayLabel
            // 
            MaxDelayLabel.AutoSize = true;
            MaxDelayLabel.ForeColor = Color.Silver;
            MaxDelayLabel.Location = new Point(160, 71);
            MaxDelayLabel.Name = "MaxDelayLabel";
            MaxDelayLabel.Size = new Size(62, 15);
            MaxDelayLabel.TabIndex = 8;
            MaxDelayLabel.Text = "Max Delay";
            // 
            // MinDelayLabel
            // 
            MinDelayLabel.AutoSize = true;
            MinDelayLabel.ForeColor = Color.Silver;
            MinDelayLabel.Location = new Point(25, 71);
            MinDelayLabel.Name = "MinDelayLabel";
            MinDelayLabel.Size = new Size(60, 15);
            MinDelayLabel.TabIndex = 7;
            MinDelayLabel.Text = "Min Delay";
            // 
            // ClickDelayMaxBox
            // 
            ClickDelayMaxBox.BackColor = Color.Transparent;
            ClickDelayMaxBox.BorderColor = Color.FromArgb(20, 20, 20);
            ClickDelayMaxBox.CustomizableEdges = customizableEdges1;
            ClickDelayMaxBox.DecimalPlaces = 3;
            ClickDelayMaxBox.Enabled = false;
            ClickDelayMaxBox.FillColor = Color.FromArgb(30, 30, 30);
            ClickDelayMaxBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClickDelayMaxBox.ForeColor = Color.WhiteSmoke;
            ClickDelayMaxBox.Location = new Point(160, 89);
            ClickDelayMaxBox.Maximum = new decimal(new int[] { 32766, 0, 0, 0 });
            ClickDelayMaxBox.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            ClickDelayMaxBox.Name = "ClickDelayMaxBox";
            ClickDelayMaxBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ClickDelayMaxBox.Size = new Size(100, 36);
            ClickDelayMaxBox.TabIndex = 6;
            ClickDelayMaxBox.UseTransparentBackground = true;
            ClickDelayMaxBox.Value = new decimal(new int[] { 3000, 0, 0, 196608 });
            ClickDelayMaxBox.ValueChanged += ClickDelayMaxBox_ValueChanged;
            // 
            // ClickDelayMinBox
            // 
            ClickDelayMinBox.BackColor = Color.Transparent;
            ClickDelayMinBox.BorderColor = Color.FromArgb(20, 20, 20);
            ClickDelayMinBox.CustomizableEdges = customizableEdges3;
            ClickDelayMinBox.DecimalPlaces = 3;
            ClickDelayMinBox.Enabled = false;
            ClickDelayMinBox.FillColor = Color.FromArgb(30, 30, 30);
            ClickDelayMinBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClickDelayMinBox.ForeColor = Color.WhiteSmoke;
            ClickDelayMinBox.Location = new Point(25, 89);
            ClickDelayMinBox.Maximum = new decimal(new int[] { 32766, 0, 0, 0 });
            ClickDelayMinBox.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            ClickDelayMinBox.Name = "ClickDelayMinBox";
            ClickDelayMinBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ClickDelayMinBox.Size = new Size(100, 36);
            ClickDelayMinBox.TabIndex = 5;
            ClickDelayMinBox.UseTransparentBackground = true;
            ClickDelayMinBox.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            ClickDelayMinBox.ValueChanged += ClickDelayMinBox_ValueChanged;
            // 
            // RandomDelayCB
            // 
            RandomDelayCB.Animated = true;
            RandomDelayCB.AutoSize = true;
            RandomDelayCB.CheckedState.BorderColor = Color.Green;
            RandomDelayCB.CheckedState.BorderRadius = 0;
            RandomDelayCB.CheckedState.BorderThickness = 0;
            RandomDelayCB.CheckedState.FillColor = Color.Green;
            RandomDelayCB.Location = new Point(302, 56);
            RandomDelayCB.Name = "RandomDelayCB";
            RandomDelayCB.Size = new Size(103, 19);
            RandomDelayCB.TabIndex = 4;
            RandomDelayCB.Text = "Random Delay";
            RandomDelayCB.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            RandomDelayCB.UncheckedState.BorderRadius = 0;
            RandomDelayCB.UncheckedState.BorderThickness = 0;
            RandomDelayCB.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            RandomDelayCB.CheckedChanged += RandomDelayCB_CheckedChanged;
            // 
            // DelayTypeLabel
            // 
            DelayTypeLabel.AutoSize = true;
            DelayTypeLabel.ForeColor = Color.Silver;
            DelayTypeLabel.Location = new Point(155, 5);
            DelayTypeLabel.Name = "DelayTypeLabel";
            DelayTypeLabel.Size = new Size(63, 15);
            DelayTypeLabel.TabIndex = 3;
            DelayTypeLabel.Text = "Delay Type";
            // 
            // DelayTypeList
            // 
            DelayTypeList.BackColor = Color.Transparent;
            DelayTypeList.BorderColor = Color.FromArgb(20, 20, 20);
            DelayTypeList.CustomizableEdges = customizableEdges5;
            DelayTypeList.DrawMode = DrawMode.OwnerDrawFixed;
            DelayTypeList.DropDownStyle = ComboBoxStyle.DropDownList;
            DelayTypeList.FillColor = Color.FromArgb(30, 30, 30);
            DelayTypeList.FocusedColor = Color.FromArgb(94, 148, 255);
            DelayTypeList.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            DelayTypeList.Font = new Font("Segoe UI", 10F);
            DelayTypeList.ForeColor = Color.WhiteSmoke;
            DelayTypeList.ItemHeight = 30;
            DelayTypeList.Items.AddRange(new object[] { "Miliseconds", "Seconds", "Minutes", "Hours" });
            DelayTypeList.Location = new Point(155, 23);
            DelayTypeList.Name = "DelayTypeList";
            DelayTypeList.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DelayTypeList.Size = new Size(117, 36);
            DelayTypeList.StartIndex = 0;
            DelayTypeList.TabIndex = 2;
            DelayTypeList.SelectedIndexChanged += DelayTypeList_SelectedIndexChanged;
            // 
            // ClickDelayLabel
            // 
            ClickDelayLabel.AutoSize = true;
            ClickDelayLabel.ForeColor = Color.Silver;
            ClickDelayLabel.Location = new Point(25, 5);
            ClickDelayLabel.Name = "ClickDelayLabel";
            ClickDelayLabel.Size = new Size(65, 15);
            ClickDelayLabel.TabIndex = 1;
            ClickDelayLabel.Text = "Click Delay";
            // 
            // DelayBox
            // 
            DelayBox.BackColor = Color.Transparent;
            DelayBox.BorderColor = Color.FromArgb(20, 20, 20);
            DelayBox.CustomizableEdges = customizableEdges7;
            DelayBox.DecimalPlaces = 3;
            DelayBox.FillColor = Color.FromArgb(30, 30, 30);
            DelayBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DelayBox.ForeColor = Color.WhiteSmoke;
            DelayBox.Location = new Point(25, 23);
            DelayBox.Maximum = new decimal(new int[] { 32766, 0, 0, 0 });
            DelayBox.Minimum = new decimal(new int[] { 1, 0, 0, 196608 });
            DelayBox.Name = "DelayBox";
            DelayBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            DelayBox.Size = new Size(100, 36);
            DelayBox.TabIndex = 0;
            DelayBox.UseTransparentBackground = true;
            DelayBox.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            DelayBox.ValueChanged += DelayBox_ValueChanged;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(500, 450);
            Controls.Add(IntervalPanel);
            Controls.Add(Watermark);
            Controls.Add(guna2Separator1);
            Controls.Add(ToggleCheckbox);
            Controls.Add(Minimize);
            Controls.Add(Exit);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simply Click";
            IntervalPanel.ResumeLayout(false);
            IntervalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ClickDelayMaxBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ClickDelayMinBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DelayBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize;
        private Guna.UI2.WinForms.Guna2CheckBox ToggleCheckbox;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Label Watermark;
        private Guna.UI2.WinForms.Guna2Panel IntervalPanel;
        private Guna.UI2.WinForms.Guna2NumericUpDown DelayBox;
        private Label ClickDelayLabel;
        private Guna.UI2.WinForms.Guna2ComboBox DelayTypeList;
        private Label DelayTypeLabel;
        private Guna.UI2.WinForms.Guna2CheckBox RandomDelayCB;
        private Guna.UI2.WinForms.Guna2NumericUpDown ClickDelayMaxBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown ClickDelayMinBox;
        private Label MinDelayLabel;
        private Label MaxDelayLabel;
    }
}
