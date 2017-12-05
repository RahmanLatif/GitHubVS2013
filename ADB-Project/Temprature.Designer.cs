namespace ADB_Project
{
    partial class Temprature
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
            this.dgvTemprature = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemprature)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTemprature
            // 
            this.dgvTemprature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemprature.Location = new System.Drawing.Point(12, 12);
            this.dgvTemprature.Name = "dgvTemprature";
            this.dgvTemprature.Size = new System.Drawing.Size(740, 512);
            this.dgvTemprature.TabIndex = 1;
            // 
            // Temprature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 536);
            this.Controls.Add(this.dgvTemprature);
            this.Name = "Temprature";
            this.Text = "Temprature";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemprature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTemprature;

    }
}