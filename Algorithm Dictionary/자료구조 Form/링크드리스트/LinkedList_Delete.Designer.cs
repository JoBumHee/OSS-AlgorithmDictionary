﻿namespace Algorithm_Dictionary.자료구조_Form.링크드리스트
{
    partial class LinkedList_Delete
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
            this.tb_Delete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Delete
            // 
            this.tb_Delete.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Delete.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.tb_Delete.Location = new System.Drawing.Point(13, 16);
            this.tb_Delete.Multiline = true;
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.ReadOnly = true;
            this.tb_Delete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Delete.Size = new System.Drawing.Size(1018, 407);
            this.tb_Delete.TabIndex = 0;
            // 
            // LinkedList_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 435);
            this.Controls.Add(this.tb_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LinkedList_Delete";
            this.Text = "링크드리스트 해제화";
            this.Load += new System.EventHandler(this.LinkedList_Delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Delete;
    }
}