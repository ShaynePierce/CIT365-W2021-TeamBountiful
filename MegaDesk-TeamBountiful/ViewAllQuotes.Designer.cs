
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
            this.components = new System.ComponentModel.Container();
            this.ButtonMainMenu = new System.Windows.Forms.Button();
            this.QuotesDataGridView = new System.Windows.Forms.DataGridView();
            this.filerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QuotesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(475, 374);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Size = new System.Drawing.Size(184, 58);
            this.ButtonMainMenu.TabIndex = 5;
            this.ButtonMainMenu.Text = "&Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // QuotesDataGridView
            // 
            this.QuotesDataGridView.AllowUserToAddRows = false;
            this.QuotesDataGridView.AllowUserToDeleteRows = false;
            this.QuotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuotesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.QuotesDataGridView.Name = "QuotesDataGridView";
            this.QuotesDataGridView.ReadOnly = true;
            this.QuotesDataGridView.RowHeadersWidth = 50;
            this.QuotesDataGridView.RowTemplate.Height = 24;
            this.QuotesDataGridView.Size = new System.Drawing.Size(647, 358);
            this.QuotesDataGridView.TabIndex = 6;
            // 
            // filerBindingSource
            // 
            this.filerBindingSource.DataSource = typeof(MegaDesk_TeamBountiful.Filer);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaDesk_TeamBountiful.Properties.Resources.desktop_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(672, 444);
            this.ControlBox = false;
            this.Controls.Add(this.QuotesDataGridView);
            this.Controls.Add(this.ButtonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.QuotesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonMainMenu;
        private System.Windows.Forms.DataGridView QuotesDataGridView;
        private System.Windows.Forms.BindingSource filerBindingSource;
    }
}