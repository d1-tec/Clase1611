namespace UI
{
    partial class MainUserControl
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonManageIngredients = new System.Windows.Forms.Button();
            this.buttonManageRecipes = new System.Windows.Forms.Button();
            this.buttonManageChefs = new System.Windows.Forms.Button();
            this.buttonManageCountries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonExit.FlatAppearance.BorderSize = 3;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(499, 722);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(433, 86);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonManageIngredients
            // 
            this.buttonManageIngredients.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonManageIngredients.FlatAppearance.BorderSize = 3;
            this.buttonManageIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageIngredients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageIngredients.Location = new System.Drawing.Point(499, 76);
            this.buttonManageIngredients.Name = "buttonManageIngredients";
            this.buttonManageIngredients.Size = new System.Drawing.Size(433, 102);
            this.buttonManageIngredients.TabIndex = 1;
            this.buttonManageIngredients.Text = "Administrar Ingredientes";
            this.buttonManageIngredients.UseVisualStyleBackColor = true;
            this.buttonManageIngredients.Click += new System.EventHandler(this.buttonManageIngredients_Click);
            // 
            // buttonManageRecipes
            // 
            this.buttonManageRecipes.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonManageRecipes.FlatAppearance.BorderSize = 3;
            this.buttonManageRecipes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageRecipes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageRecipes.Location = new System.Drawing.Point(499, 236);
            this.buttonManageRecipes.Name = "buttonManageRecipes";
            this.buttonManageRecipes.Size = new System.Drawing.Size(433, 102);
            this.buttonManageRecipes.TabIndex = 2;
            this.buttonManageRecipes.Text = "Administrar Recetas";
            this.buttonManageRecipes.UseVisualStyleBackColor = true;
            this.buttonManageRecipes.Click += new System.EventHandler(this.buttonManageRecipes_Click);
            // 
            // buttonManageChefs
            // 
            this.buttonManageChefs.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonManageChefs.FlatAppearance.BorderSize = 3;
            this.buttonManageChefs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageChefs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageChefs.Location = new System.Drawing.Point(499, 394);
            this.buttonManageChefs.Name = "buttonManageChefs";
            this.buttonManageChefs.Size = new System.Drawing.Size(433, 102);
            this.buttonManageChefs.TabIndex = 3;
            this.buttonManageChefs.Text = "Administrar Chefs";
            this.buttonManageChefs.UseVisualStyleBackColor = true;
            this.buttonManageChefs.Click += new System.EventHandler(this.buttonManageChefs_Click);
            // 
            // buttonManageCountries
            // 
            this.buttonManageCountries.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonManageCountries.FlatAppearance.BorderSize = 3;
            this.buttonManageCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManageCountries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManageCountries.Location = new System.Drawing.Point(499, 554);
            this.buttonManageCountries.Name = "buttonManageCountries";
            this.buttonManageCountries.Size = new System.Drawing.Size(433, 102);
            this.buttonManageCountries.TabIndex = 4;
            this.buttonManageCountries.Text = "Administrar Paises";
            this.buttonManageCountries.UseVisualStyleBackColor = true;
            this.buttonManageCountries.Click += new System.EventHandler(this.buttonManageCountries_Click);
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonManageCountries);
            this.Controls.Add(this.buttonManageChefs);
            this.Controls.Add(this.buttonManageRecipes);
            this.Controls.Add(this.buttonManageIngredients);
            this.Controls.Add(this.buttonExit);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(1390, 982);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonManageIngredients;
        private System.Windows.Forms.Button buttonManageRecipes;
        private System.Windows.Forms.Button buttonManageChefs;
        private System.Windows.Forms.Button buttonManageCountries;
    }
}
