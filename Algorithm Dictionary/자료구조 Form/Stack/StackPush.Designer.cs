﻿namespace Algorithm_Dictionary.자료구조_Form.Stack
{
    partial class StackPush
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
            this.tb_push = new System.Windows.Forms.TextBox();
            this.pb_push = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_push)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_push
            // 
            this.tb_push.BackColor = System.Drawing.SystemColors.Window;
            this.tb_push.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.tb_push.Location = new System.Drawing.Point(16, 27);
            this.tb_push.Multiline = true;
            this.tb_push.Name = "tb_push";
            this.tb_push.ReadOnly = true;
            this.tb_push.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_push.Size = new System.Drawing.Size(444, 145);
            this.tb_push.TabIndex = 0;
            // 
            // pb_push
            // 
            this.pb_push.Image = global::Algorithm_Dictionary.Properties.Resources.스택_삽입_;
            this.pb_push.Location = new System.Drawing.Point(19, 193);
            this.pb_push.Name = "pb_push";
            this.pb_push.Size = new System.Drawing.Size(440, 244);
            this.pb_push.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_push.TabIndex = 1;
            this.pb_push.TabStop = false;
            // 
            // StackPush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 456);
            this.Controls.Add(this.pb_push);
            this.Controls.Add(this.tb_push);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StackPush";
            this.Text = "StackPush";
            this.Load += new System.EventHandler(this.StackPush_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_push)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_push;
        private System.Windows.Forms.PictureBox pb_push;
    }
}