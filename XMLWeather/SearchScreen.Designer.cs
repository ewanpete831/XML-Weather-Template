
namespace XMLWeather
{
    partial class SearchScreen
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(168, 38);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(148, 26);
            this.searchBox.TabIndex = 0;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(42, 43);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(60, 20);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Search";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(219, 546);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(112, 35);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(180, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 36);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(-3, 281);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(378, 37);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Please Enter a Valid City!";
            this.errorLabel.Visible = false;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(375, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
