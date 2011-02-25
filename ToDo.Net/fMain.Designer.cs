namespace ToDo.Net
{
    partial class fMain
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
            this.lStatus = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListView();
            this.colPriority = new System.Windows.Forms.ColumnHeader();
            this.colItemData = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.Location = new System.Drawing.Point(100, 310);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(35, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstItems
            // 
            this.lstItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPriority,
            this.colItemData});
            this.lstItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstItems.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FullRowSelect = true;
            this.lstItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstItems.Location = new System.Drawing.Point(0, 0);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(284, 97);
            this.lstItems.TabIndex = 4;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstItems_KeyPress);
            // 
            // colPriority
            // 
            this.colPriority.Text = "";
            this.colPriority.Width = 40;
            // 
            // colItemData
            // 
            this.colItemData.Text = "";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 409);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lStatus);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fMain";
            this.Text = "ToDo.Net";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fMain_KeyPress);
            this.Resize += new System.EventHandler(this.fMain_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader colPriority;
        private System.Windows.Forms.ColumnHeader colItemData;
    }
}

