namespace CalckSimplTest
{
    partial class MainForm
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
            this.tbFirstNum = new System.Windows.Forms.TextBox();
            this.tbSecondNum = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btMult = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.btSquare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstNum
            // 
            this.tbFirstNum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbFirstNum.Location = new System.Drawing.Point(13, 13);
            this.tbFirstNum.Name = "tbFirstNum";
            this.tbFirstNum.Size = new System.Drawing.Size(100, 20);
            this.tbFirstNum.TabIndex = 0;
            // 
            // tbSecondNum
            // 
            this.tbSecondNum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tbSecondNum.Location = new System.Drawing.Point(150, 13);
            this.tbSecondNum.Name = "tbSecondNum";
            this.tbSecondNum.Size = new System.Drawing.Size(100, 20);
            this.tbSecondNum.TabIndex = 1;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbResult.Location = new System.Drawing.Point(12, 126);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(237, 20);
            this.tbResult.TabIndex = 2;
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(38, 68);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(75, 23);
            this.btMult.TabIndex = 3;
            this.btMult.Text = "Multiplay";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMultiplay_Click);
            // 
            // btMinus
            // 
            this.btMinus.Location = new System.Drawing.Point(150, 39);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(75, 23);
            this.btMinus.TabIndex = 5;
            this.btMinus.Text = "Minus";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.btMinus_Click);
            // 
            // btDivide
            // 
            this.btDivide.Location = new System.Drawing.Point(150, 68);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(75, 23);
            this.btDivide.TabIndex = 8;
            this.btDivide.Text = "Divide";
            this.btDivide.UseVisualStyleBackColor = true;
            this.btDivide.Click += new System.EventHandler(this.btDivide_Click);
            // 
            // btPlus
            // 
            this.btPlus.Location = new System.Drawing.Point(38, 39);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(75, 23);
            this.btPlus.TabIndex = 6;
            this.btPlus.Text = "Plus";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
            // 
            // btRoot
            // 
            this.btRoot.Location = new System.Drawing.Point(150, 97);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(75, 23);
            this.btRoot.TabIndex = 11;
            this.btRoot.Text = "Root";
            this.btRoot.UseVisualStyleBackColor = true;
            this.btRoot.Click += new System.EventHandler(this.btRoot_Click);
            // 
            // btSquare
            // 
            this.btSquare.Location = new System.Drawing.Point(38, 97);
            this.btSquare.Name = "btSquare";
            this.btSquare.Size = new System.Drawing.Size(75, 23);
            this.btSquare.TabIndex = 9;
            this.btSquare.Text = "Square";
            this.btSquare.UseVisualStyleBackColor = true;
            this.btSquare.Click += new System.EventHandler(this.btSquare_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 163);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.btSquare);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSecondNum);
            this.Controls.Add(this.tbFirstNum);
            this.Name = "MainForm";
            this.Text = "Calck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNum;
        private System.Windows.Forms.TextBox tbSecondNum;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btRoot;
        private System.Windows.Forms.Button btSquare;
    }
}

