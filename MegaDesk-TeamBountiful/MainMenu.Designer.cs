
namespace MegaDesk_TeamBountiful
{
    partial class MainMenu
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
            this.buttonAddQuote = new System.Windows.Forms.Button();
            this.buttonSearchQuotes = new System.Windows.Forms.Button();
            this.buttonViewQuotes = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddQuote
            // 
            this.buttonAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddQuote.Location = new System.Drawing.Point(11, 12);
            this.buttonAddQuote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddQuote.Name = "buttonAddQuote";
            this.buttonAddQuote.Size = new System.Drawing.Size(368, 112);
            this.buttonAddQuote.TabIndex = 0;
            this.buttonAddQuote.Text = "&Add Quote";
            this.buttonAddQuote.UseVisualStyleBackColor = true;
            this.buttonAddQuote.Click += new System.EventHandler(this.ButtonAddQuote_Click);
            // 
            // buttonSearchQuotes
            // 
            this.buttonSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchQuotes.Location = new System.Drawing.Point(11, 131);
            this.buttonSearchQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchQuotes.Name = "buttonSearchQuotes";
            this.buttonSearchQuotes.Size = new System.Drawing.Size(368, 112);
            this.buttonSearchQuotes.TabIndex = 1;
            this.buttonSearchQuotes.Text = "&Search Quotes";
            this.buttonSearchQuotes.UseVisualStyleBackColor = true;
            this.buttonSearchQuotes.Click += new System.EventHandler(this.ButtonSearchQuotes_Click);
            // 
            // buttonViewQuotes
            // 
            this.buttonViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewQuotes.Location = new System.Drawing.Point(11, 250);
            this.buttonViewQuotes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewQuotes.Name = "buttonViewQuotes";
            this.buttonViewQuotes.Size = new System.Drawing.Size(368, 112);
            this.buttonViewQuotes.TabIndex = 2;
            this.buttonViewQuotes.Text = "&View All Quotes";
            this.buttonViewQuotes.UseVisualStyleBackColor = true;
            this.buttonViewQuotes.Click += new System.EventHandler(this.ButtonViewQuotes_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkSalmon;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(11, 370);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(368, 112);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MegaDesk_TeamBountiful.Properties.Resources.desktop_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(1344, 861);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonViewQuotes);
            this.Controls.Add(this.buttonSearchQuotes);
            this.Controls.Add(this.buttonAddQuote);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddQuote;
        private System.Windows.Forms.Button buttonSearchQuotes;
        private System.Windows.Forms.Button buttonViewQuotes;
        private System.Windows.Forms.Button buttonExit;
    }
}

