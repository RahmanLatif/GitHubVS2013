namespace ADB_Project
{
    partial class Fluid
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
            this.dgvfluid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfluid
            // 
            this.dgvfluid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfluid.Location = new System.Drawing.Point(12, 13);
            this.dgvfluid.Name = "dgvfluid";
            this.dgvfluid.Size = new System.Drawing.Size(738, 509);
            this.dgvfluid.TabIndex = 1;
            // 
            // Fluid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 534);
            this.Controls.Add(this.dgvfluid);
            this.Name = "Fluid";
            this.Text = "Fluid";
            ((System.ComponentModel.ISupportInitialize)(this.dgvfluid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfluid;

    }
}