namespace ShutdownTool
{
    partial class stdwntool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stdwntool));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.tbCountdown = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(166, 12);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(106, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // bExec
            // 
            this.bExec.Location = new System.Drawing.Point(166, 64);
            this.bExec.Name = "bExec";
            this.bExec.Size = new System.Drawing.Size(106, 26);
            this.bExec.TabIndex = 1;
            this.bExec.Text = "Exec";
            this.bExec.UseVisualStyleBackColor = true;
            this.bExec.Click += new System.EventHandler(this.bExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter shutdown-time in hrs: ";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(15, 64);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(106, 26);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tbCountdown
            // 
            this.tbCountdown.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbCountdown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountdown.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCountdown.Location = new System.Drawing.Point(203, 38);
            this.tbCountdown.Margin = new System.Windows.Forms.Padding(150, 100, 150, 100);
            this.tbCountdown.Name = "tbCountdown";
            this.tbCountdown.ReadOnly = true;
            this.tbCountdown.Size = new System.Drawing.Size(69, 19);
            this.tbCountdown.TabIndex = 4;
            // 
            // stdwntool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.tbCountdown);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExec);
            this.Controls.Add(this.tbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "stdwntool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Tool";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stdwntool_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbCountdown;
        private System.Windows.Forms.Timer timer1;
    }
}

