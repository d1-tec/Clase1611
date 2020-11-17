namespace UI
{
    partial class ManageIngredientsUserControl
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
            this.listBoxIngredients = new System.Windows.Forms.ListBox();
            this.textBoxIngredientName = new System.Windows.Forms.TextBox();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(513, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis ingredientes";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonGoBack.FlatAppearance.BorderSize = 3;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(565, 776);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(235, 77);
            this.buttonGoBack.TabIndex = 1;
            this.buttonGoBack.Text = "Volver";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 25;
            this.listBoxIngredients.Location = new System.Drawing.Point(79, 254);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(304, 229);
            this.listBoxIngredients.TabIndex = 2;
            // 
            // textBoxIngredientName
            // 
            this.textBoxIngredientName.Location = new System.Drawing.Point(859, 204);
            this.textBoxIngredientName.Name = "textBoxIngredientName";
            this.textBoxIngredientName.Size = new System.Drawing.Size(266, 31);
            this.textBoxIngredientName.TabIndex = 3;
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddIngredient.FlatAppearance.BorderSize = 3;
            this.buttonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIngredient.Location = new System.Drawing.Point(859, 367);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(235, 77);
            this.buttonAddIngredient.TabIndex = 4;
            this.buttonAddIngredient.Text = "Agregar";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(859, 272);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(271, 33);
            this.comboBoxCountry.TabIndex = 5;
            // 
            // ManageIngredientsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.textBoxIngredientName);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label1);
            this.Name = "ManageIngredientsUserControl";
            this.Size = new System.Drawing.Size(1390, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.TextBox textBoxIngredientName;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
}
