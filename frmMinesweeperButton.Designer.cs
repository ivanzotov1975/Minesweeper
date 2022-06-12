namespace Minesweeper
{
    partial class frmMinesweeperButton
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
            this.tbMaxRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaxCols = new System.Windows.Forms.TextBox();
            this.btnSetBoard = new System.Windows.Forms.Button();
            this.tbMaxMines = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.chbShowMines = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbMaxRows
            // 
            this.tbMaxRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaxRows.Location = new System.Drawing.Point(16, 393);
            this.tbMaxRows.Name = "tbMaxRows";
            this.tbMaxRows.Size = new System.Drawing.Size(38, 23);
            this.tbMaxRows.TabIndex = 3;
            this.tbMaxRows.Text = "15";
            this.tbMaxRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columns";
            // 
            // tbMaxCols
            // 
            this.tbMaxCols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaxCols.Location = new System.Drawing.Point(73, 393);
            this.tbMaxCols.Name = "tbMaxCols";
            this.tbMaxCols.Size = new System.Drawing.Size(38, 23);
            this.tbMaxCols.TabIndex = 5;
            this.tbMaxCols.Text = "20";
            this.tbMaxCols.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetBoard
            // 
            this.btnSetBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetBoard.Location = new System.Drawing.Point(16, 422);
            this.btnSetBoard.Name = "btnSetBoard";
            this.btnSetBoard.Size = new System.Drawing.Size(112, 23);
            this.btnSetBoard.TabIndex = 7;
            this.btnSetBoard.Text = "Set Board";
            this.btnSetBoard.UseVisualStyleBackColor = true;
            this.btnSetBoard.Click += new System.EventHandler(this.btnSetBoard_Click);
            // 
            // tbMaxMines
            // 
            this.tbMaxMines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMaxMines.Location = new System.Drawing.Point(134, 393);
            this.tbMaxMines.Name = "tbMaxMines";
            this.tbMaxMines.Size = new System.Drawing.Size(38, 23);
            this.tbMaxMines.TabIndex = 10;
            this.tbMaxMines.Text = "25";
            this.tbMaxMines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mines";
            // 
            // panelBoard
            // 
            this.panelBoard.AutoSize = true;
            this.panelBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBoard.Location = new System.Drawing.Point(3, 2);
            this.panelBoard.MinimumSize = new System.Drawing.Size(100, 100);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(100, 100);
            this.panelBoard.TabIndex = 12;
            // 
            // chbShowMines
            // 
            this.chbShowMines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbShowMines.AutoSize = true;
            this.chbShowMines.Checked = true;
            this.chbShowMines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowMines.Location = new System.Drawing.Point(178, 397);
            this.chbShowMines.Name = "chbShowMines";
            this.chbShowMines.Size = new System.Drawing.Size(90, 19);
            this.chbShowMines.TabIndex = 13;
            this.chbShowMines.Text = "Show Mines";
            this.chbShowMines.UseVisualStyleBackColor = true;
            // 
            // frmMinesweeperButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panelBoard);
            this.Controls.Add(this.chbShowMines);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMaxMines);
            this.Controls.Add(this.btnSetBoard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaxCols);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMaxRows);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmMinesweeperButton";
            this.Text = "Minesweeper - using Buttons as cells";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbMaxRows;
        private Label label1;
        private Label label2;
        private TextBox tbMaxCols;
        private Button btnSetBoard;
        private TextBox tbMaxMines;
        private Label label3;
        private Panel panelBoard;
        private CheckBox chbShowMines;
    }
}