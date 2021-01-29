
namespace MegaDesk_TeamBountiful
{
    partial class AddQuote
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
            this.ButtonDisplayQuote = new System.Windows.Forms.Button();
            this.ButtonMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCustomerName = new System.Windows.Forms.TextBox();
            this.TextBoxDeskWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxDeskDepth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxNumberOfDrawers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxDesktopMaterial = new System.Windows.Forms.ComboBox();
            this.ComboBoxRushOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDisplayQuote
            // 
            this.ButtonDisplayQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisplayQuote.Location = new System.Drawing.Point(954, 585);
            this.ButtonDisplayQuote.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDisplayQuote.Name = "ButtonDisplayQuote";
            this.ButtonDisplayQuote.Size = new System.Drawing.Size(368, 112);
            this.ButtonDisplayQuote.TabIndex = 1;
            this.ButtonDisplayQuote.Text = "Display &Quote";
            this.ButtonDisplayQuote.UseVisualStyleBackColor = true;
            this.ButtonDisplayQuote.Click += new System.EventHandler(this.ButtonDisplayQuote_Click);
            // 
            // ButtonMainMenu
            // 
            this.ButtonMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMainMenu.Location = new System.Drawing.Point(954, 721);
            this.ButtonMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMainMenu.Name = "ButtonMainMenu";
            this.ButtonMainMenu.Size = new System.Drawing.Size(368, 112);
            this.ButtonMainMenu.TabIndex = 2;
            this.ButtonMainMenu.Text = "&Main Menu";
            this.ButtonMainMenu.UseVisualStyleBackColor = true;
            this.ButtonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // TextBoxCustomerName
            // 
            this.TextBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCustomerName.Location = new System.Drawing.Point(52, 80);
            this.TextBoxCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxCustomerName.Name = "TextBoxCustomerName";
            this.TextBoxCustomerName.Size = new System.Drawing.Size(709, 45);
            this.TextBoxCustomerName.TabIndex = 4;
            this.TextBoxCustomerName.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxCustomerName_Validating);
            // 
            // TextBoxDeskWidth
            // 
            this.TextBoxDeskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDeskWidth.Location = new System.Drawing.Point(52, 183);
            this.TextBoxDeskWidth.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDeskWidth.Name = "TextBoxDeskWidth";
            this.TextBoxDeskWidth.Size = new System.Drawing.Size(391, 45);
            this.TextBoxDeskWidth.TabIndex = 6;
            this.TextBoxDeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDeskWidth_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desk Width (inches)";
            // 
            // TextBoxDeskDepth
            // 
            this.TextBoxDeskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDeskDepth.Location = new System.Drawing.Point(52, 295);
            this.TextBoxDeskDepth.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxDeskDepth.Name = "TextBoxDeskDepth";
            this.TextBoxDeskDepth.Size = new System.Drawing.Size(391, 45);
            this.TextBoxDeskDepth.TabIndex = 8;
            this.TextBoxDeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDeskDepth_KeyPress);
            this.TextBoxDeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxDeskDepth_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desk Depth (inches)";
            // 
            // TextBoxNumberOfDrawers
            // 
            this.TextBoxNumberOfDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNumberOfDrawers.Location = new System.Drawing.Point(52, 408);
            this.TextBoxNumberOfDrawers.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxNumberOfDrawers.Name = "TextBoxNumberOfDrawers";
            this.TextBoxNumberOfDrawers.Size = new System.Drawing.Size(391, 45);
            this.TextBoxNumberOfDrawers.TabIndex = 10;
            this.TextBoxNumberOfDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumberOfDrawers_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Desktop Material";
            // 
            // ComboBoxDesktopMaterial
            // 
            this.ComboBoxDesktopMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDesktopMaterial.FormattingEnabled = true;
            this.ComboBoxDesktopMaterial.Location = new System.Drawing.Point(52, 518);
            this.ComboBoxDesktopMaterial.Margin = new System.Windows.Forms.Padding(8);
            this.ComboBoxDesktopMaterial.Name = "ComboBoxDesktopMaterial";
            this.ComboBoxDesktopMaterial.Size = new System.Drawing.Size(391, 46);
            this.ComboBoxDesktopMaterial.TabIndex = 12;
            this.ComboBoxDesktopMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxDesktopMaterial_Validating);
            // 
            // ComboBoxRushOrder
            // 
            this.ComboBoxRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRushOrder.FormattingEnabled = true;
            this.ComboBoxRushOrder.Location = new System.Drawing.Point(52, 630);
            this.ComboBoxRushOrder.Margin = new System.Windows.Forms.Padding(8);
            this.ComboBoxRushOrder.Name = "ComboBoxRushOrder";
            this.ComboBoxRushOrder.Size = new System.Drawing.Size(391, 46);
            this.ComboBoxRushOrder.TabIndex = 14;
            this.ComboBoxRushOrder.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxRushOrder_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 582);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rush Order";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 690);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Order Date";
            // 
            // DateTimePickerOrderDate
            // 
            this.DateTimePickerOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerOrderDate.Location = new System.Drawing.Point(52, 738);
            this.DateTimePickerOrderDate.Margin = new System.Windows.Forms.Padding(8);
            this.DateTimePickerOrderDate.Name = "DateTimePickerOrderDate";
            this.DateTimePickerOrderDate.Size = new System.Drawing.Size(391, 45);
            this.DateTimePickerOrderDate.TabIndex = 16;
            this.DateTimePickerOrderDate.Validating += new System.ComponentModel.CancelEventHandler(this.DateTimePickerOrderDate_Validating);
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DateTimePickerOrderDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ComboBoxRushOrder);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ComboBoxDesktopMaterial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBoxNumberOfDrawers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxDeskDepth);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxDeskWidth);
            this.panel1.Controls.Add(this.TextBoxCustomerName);
            this.panel1.Location = new System.Drawing.Point(16, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 819);
            this.panel1.TabIndex = 17;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::MegaDesk_TeamBountiful.Properties.Resources.desktop_resized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.ButtonMainMenu;
            this.ClientSize = new System.Drawing.Size(1336, 852);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonMainMenu);
            this.Controls.Add(this.ButtonDisplayQuote);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonDisplayQuote;
        private System.Windows.Forms.Button ButtonMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCustomerName;
        private System.Windows.Forms.TextBox TextBoxDeskWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxDeskDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxNumberOfDrawers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxDesktopMaterial;
        private System.Windows.Forms.ComboBox ComboBoxRushOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateTimePickerOrderDate;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.Panel panel1;
    }
}