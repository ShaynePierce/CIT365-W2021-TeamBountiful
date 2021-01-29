
namespace MegaDesk_TeamBountiful
{
    partial class ViewAllQuotes
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
            this.ButtonMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(534, 468);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Size = new System.Drawing.Size(207, 72);
            this.ButtonMainMenu.TabIndex = 5;
            this.ButtonMainMenu.Text = "&Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_TeamBountiful.Properties.Resources.desktop_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(756, 555);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonMainMenu;
    }
}