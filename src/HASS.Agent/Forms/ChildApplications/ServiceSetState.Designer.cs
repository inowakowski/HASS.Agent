﻿using HASS.Agent.Resources.Localization;

namespace HASS.Agent.Forms.ChildApplications
{
    partial class ServiceSetState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceSetState));
            this.LblInfo1 = new System.Windows.Forms.Label();
            this.PbStep1Configure = new System.Windows.Forms.PictureBox();
            this.LblTask1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbStep1Configure)).BeginInit();
            this.SuspendLayout();
            // 
            // LblInfo1
            // 
            this.LblInfo1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInfo1.Location = new System.Drawing.Point(2, 9);
            this.LblInfo1.Name = "LblInfo1";
            this.LblInfo1.Size = new System.Drawing.Size(615, 57);
            this.LblInfo1.TabIndex = 1;
            this.LblInfo1.Text = Languages.ServiceSetState_LblInfo1;
            this.LblInfo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PbStep1Configure
            // 
            this.PbStep1Configure.Image = global::HASS.Agent.Properties.Resources.todo_32;
            this.PbStep1Configure.Location = new System.Drawing.Point(211, 148);
            this.PbStep1Configure.Name = "PbStep1Configure";
            this.PbStep1Configure.Size = new System.Drawing.Size(32, 32);
            this.PbStep1Configure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbStep1Configure.TabIndex = 54;
            this.PbStep1Configure.TabStop = false;
            // 
            // LblTask1
            // 
            this.LblTask1.AutoSize = true;
            this.LblTask1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTask1.Location = new System.Drawing.Point(261, 154);
            this.LblTask1.Name = "LblTask1";
            this.LblTask1.Size = new System.Drawing.Size(146, 19);
            this.LblTask1.TabIndex = 55;
            this.LblTask1.Text = Languages.ServiceSetState_LblTask1;
            // 
            // ServiceSetState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(619, 284);
            this.Controls.Add(this.LblTask1);
            this.Controls.Add(this.PbStep1Configure);
            this.Controls.Add(this.LblInfo1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.Name = "ServiceSetState";
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = Languages.ServiceSetState_Title;
            this.Load += new System.EventHandler(this.ServiceSetState_Load);
            this.ResizeEnd += new System.EventHandler(this.ServiceSetState_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.PbStep1Configure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInfo1;
        private System.Windows.Forms.PictureBox PbStep1Configure;
        private System.Windows.Forms.Label LblTask1;
    }
}

