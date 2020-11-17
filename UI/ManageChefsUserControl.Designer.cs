namespace UI
{
    partial class ManageChefsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.listBoxChefs = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(589, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis chefs";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonGoBack.FlatAppearance.BorderSize = 3;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(567, 774);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(245, 83);
            this.buttonGoBack.TabIndex = 1;
            this.buttonGoBack.Text = "Volver";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // listBoxChefs
            // 
            this.listBoxChefs.FormattingEnabled = true;
            this.listBoxChefs.ItemHeight = 25;
            this.listBoxChefs.Location = new System.Drawing.Point(159, 222);
            this.listBoxChefs.Name = "listBoxChefs";
            this.listBoxChefs.Size = new System.Drawing.Size(254, 329);
            this.listBoxChefs.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(877, 222);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(332, 31);
            this.textBoxName.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAgregar.FlatAppearance.BorderSize = 3;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(964, 294);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(245, 83);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // ManageChefsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxChefs);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label1);
            this.Name = "ManageChefsUserControl";
            this.Size = new System.Drawing.Size(1390, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListBox listBoxChefs;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAgregar;
    }
}
