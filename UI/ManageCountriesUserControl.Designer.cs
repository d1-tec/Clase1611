namespace UI
{
    partial class ManageCountriesUserControl
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
            this.listBoxCountries = new System.Windows.Forms.ListBox();
            this.textBoxCountryName = new System.Windows.Forms.TextBox();
            this.buttonAddCountry = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(569, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis paises";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonGoBack.FlatAppearance.BorderSize = 3;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGoBack.Location = new System.Drawing.Point(565, 732);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(227, 81);
            this.buttonGoBack.TabIndex = 1;
            this.buttonGoBack.Text = "Volver";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // listBoxCountries
            // 
            this.listBoxCountries.FormattingEnabled = true;
            this.listBoxCountries.ItemHeight = 25;
            this.listBoxCountries.Location = new System.Drawing.Point(135, 194);
            this.listBoxCountries.Name = "listBoxCountries";
            this.listBoxCountries.Size = new System.Drawing.Size(338, 279);
            this.listBoxCountries.TabIndex = 2;
            // 
            // textBoxCountryName
            // 
            this.textBoxCountryName.Location = new System.Drawing.Point(819, 270);
            this.textBoxCountryName.Name = "textBoxCountryName";
            this.textBoxCountryName.Size = new System.Drawing.Size(324, 31);
            this.textBoxCountryName.TabIndex = 3;
            // 
            // buttonAddCountry
            // 
            this.buttonAddCountry.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddCountry.FlatAppearance.BorderSize = 3;
            this.buttonAddCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCountry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddCountry.Location = new System.Drawing.Point(974, 732);
            this.buttonAddCountry.Name = "buttonAddCountry";
            this.buttonAddCountry.Size = new System.Drawing.Size(227, 81);
            this.buttonAddCountry.TabIndex = 4;
            this.buttonAddCountry.Text = "Agregar";
            this.buttonAddCountry.UseVisualStyleBackColor = true;
            this.buttonAddCountry.Click += new System.EventHandler(this.buttonAddCountry_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonModify.FlatAppearance.BorderSize = 3;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModify.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonModify.Location = new System.Drawing.Point(974, 599);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonModify.Size = new System.Drawing.Size(227, 81);
            this.buttonModify.TabIndex = 5;
            this.buttonModify.Text = "Modificar";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonDelete.FlatAppearance.BorderSize = 3;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(974, 465);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonDelete.Size = new System.Drawing.Size(227, 81);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Borrar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // ManageCountriesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAddCountry);
            this.Controls.Add(this.textBoxCountryName);
            this.Controls.Add(this.listBoxCountries);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label1);
            this.Name = "ManageCountriesUserControl";
            this.Size = new System.Drawing.Size(1390, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListBox listBoxCountries;
        private System.Windows.Forms.TextBox textBoxCountryName;
        private System.Windows.Forms.Button buttonAddCountry;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonDelete;
    }
}
