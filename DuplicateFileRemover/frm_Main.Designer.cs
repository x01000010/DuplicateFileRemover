namespace DuplicateFileRemover
{
    partial class frm_Main
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
            this.tb_Generate = new System.Windows.Forms.Button();
            this.tb_Delete = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.ss_Bottom = new System.Windows.Forms.StatusStrip();
            this.tssl_Bottom_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.ss_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Generate
            // 
            this.tb_Generate.Location = new System.Drawing.Point(93, 12);
            this.tb_Generate.Name = "tb_Generate";
            this.tb_Generate.Size = new System.Drawing.Size(75, 23);
            this.tb_Generate.TabIndex = 0;
            this.tb_Generate.Text = "Generate";
            this.tb_Generate.UseVisualStyleBackColor = true;
            this.tb_Generate.Click += new System.EventHandler(this.tb_Generate_Click);
            // 
            // tb_Delete
            // 
            this.tb_Delete.Enabled = false;
            this.tb_Delete.Location = new System.Drawing.Point(12, 12);
            this.tb_Delete.Name = "tb_Delete";
            this.tb_Delete.Size = new System.Drawing.Size(75, 23);
            this.tb_Delete.TabIndex = 1;
            this.tb_Delete.Text = "Delete";
            this.tb_Delete.UseVisualStyleBackColor = true;
            this.tb_Delete.Click += new System.EventHandler(this.tb_Delete_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.ss_Bottom);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tb_Generate);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tb_Delete);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(181, 22);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(181, 69);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // ss_Bottom
            // 
            this.ss_Bottom.Dock = System.Windows.Forms.DockStyle.None;
            this.ss_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Bottom_Status});
            this.ss_Bottom.Location = new System.Drawing.Point(0, 0);
            this.ss_Bottom.Name = "ss_Bottom";
            this.ss_Bottom.Size = new System.Drawing.Size(181, 22);
            this.ss_Bottom.TabIndex = 0;
            // 
            // tssl_Bottom_Status
            // 
            this.tssl_Bottom_Status.Name = "tssl_Bottom_Status";
            this.tssl_Bottom_Status.Size = new System.Drawing.Size(118, 17);
            this.tssl_Bottom_Status.Text = "toolStripStatusLabel1";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 69);
            this.Controls.Add(this.toolStripContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(197, 107);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(197, 107);
            this.Name = "frm_Main";
            this.Text = "No Dupes";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ss_Bottom.ResumeLayout(false);
            this.ss_Bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tb_Generate;
        private System.Windows.Forms.Button tb_Delete;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip ss_Bottom;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Bottom_Status;
    }
}