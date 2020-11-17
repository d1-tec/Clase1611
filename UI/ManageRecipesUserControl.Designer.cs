namespace UI
{
    partial class ManageRecipesUserControl
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
            this.listBoxIngredientsCurrentRecipe = new System.Windows.Forms.ListBox();
            this.textBoxRecipeName = new System.Windows.Forms.TextBox();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.textBoxRecipeDetails = new System.Windows.Forms.TextBox();
            this.comboBoxRecipeChef = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(596, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mis recetas";
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonGoBack.FlatAppearance.BorderSize = 3;
            this.buttonGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.Location = new System.Drawing.Point(982, 854);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(237, 73);
            this.buttonGoBack.TabIndex = 1;
            this.buttonGoBack.Text = "Volver";
            this.buttonGoBack.UseVisualStyleBackColor = true;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // listBoxIngredients
            // 
            this.listBoxIngredients.FormattingEnabled = true;
            this.listBoxIngredients.ItemHeight = 25;
            this.listBoxIngredients.Location = new System.Drawing.Point(143, 190);
            this.listBoxIngredients.Name = "listBoxIngredients";
            this.listBoxIngredients.Size = new System.Drawing.Size(304, 254);
            this.listBoxIngredients.TabIndex = 2;
            // 
            // listBoxIngredientsCurrentRecipe
            // 
            this.listBoxIngredientsCurrentRecipe.FormattingEnabled = true;
            this.listBoxIngredientsCurrentRecipe.ItemHeight = 25;
            this.listBoxIngredientsCurrentRecipe.Location = new System.Drawing.Point(855, 200);
            this.listBoxIngredientsCurrentRecipe.Name = "listBoxIngredientsCurrentRecipe";
            this.listBoxIngredientsCurrentRecipe.Size = new System.Drawing.Size(364, 229);
            this.listBoxIngredientsCurrentRecipe.TabIndex = 3;
            // 
            // textBoxRecipeName
            // 
            this.textBoxRecipeName.Location = new System.Drawing.Point(855, 500);
            this.textBoxRecipeName.Name = "textBoxRecipeName";
            this.textBoxRecipeName.Size = new System.Drawing.Size(364, 31);
            this.textBoxRecipeName.TabIndex = 4;
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddRecipe.FlatAppearance.BorderSize = 3;
            this.buttonAddRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRecipe.Location = new System.Drawing.Point(982, 726);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(237, 73);
            this.buttonAddRecipe.TabIndex = 5;
            this.buttonAddRecipe.Text = "Agregar";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.buttonAddIngredient.FlatAppearance.BorderSize = 3;
            this.buttonAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddIngredient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddIngredient.Location = new System.Drawing.Point(541, 273);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(237, 73);
            this.buttonAddIngredient.TabIndex = 6;
            this.buttonAddIngredient.Text = ">";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // listBoxRecipes
            // 
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.ItemHeight = 25;
            this.listBoxRecipes.Location = new System.Drawing.Point(143, 491);
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.Size = new System.Drawing.Size(304, 179);
            this.listBoxRecipes.TabIndex = 7;
            this.listBoxRecipes.SelectedValueChanged += new System.EventHandler(this.listBoxRecipes_SelectedValueChanged);
            // 
            // textBoxRecipeDetails
            // 
            this.textBoxRecipeDetails.Location = new System.Drawing.Point(143, 726);
            this.textBoxRecipeDetails.Multiline = true;
            this.textBoxRecipeDetails.Name = "textBoxRecipeDetails";
            this.textBoxRecipeDetails.ReadOnly = true;
            this.textBoxRecipeDetails.Size = new System.Drawing.Size(304, 158);
            this.textBoxRecipeDetails.TabIndex = 8;
            // 
            // comboBoxRecipeChef
            // 
            this.comboBoxRecipeChef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRecipeChef.FormattingEnabled = true;
            this.comboBoxRecipeChef.Location = new System.Drawing.Point(1003, 586);
            this.comboBoxRecipeChef.Name = "comboBoxRecipeChef";
            this.comboBoxRecipeChef.Size = new System.Drawing.Size(216, 33);
            this.comboBoxRecipeChef.TabIndex = 9;
            // 
            // ManageRecipesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxRecipeChef);
            this.Controls.Add(this.textBoxRecipeDetails);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.buttonAddIngredient);
            this.Controls.Add(this.buttonAddRecipe);
            this.Controls.Add(this.textBoxRecipeName);
            this.Controls.Add(this.listBoxIngredientsCurrentRecipe);
            this.Controls.Add(this.listBoxIngredients);
            this.Controls.Add(this.buttonGoBack);
            this.Controls.Add(this.label1);
            this.Name = "ManageRecipesUserControl";
            this.Size = new System.Drawing.Size(1390, 982);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListBox listBoxIngredients;
        private System.Windows.Forms.ListBox listBoxIngredientsCurrentRecipe;
        private System.Windows.Forms.TextBox textBoxRecipeName;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.TextBox textBoxRecipeDetails;
        private System.Windows.Forms.ComboBox comboBoxRecipeChef;
    }
}
