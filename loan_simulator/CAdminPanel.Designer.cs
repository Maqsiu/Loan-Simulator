namespace loan_simulator
{
    partial class CAdminPanel
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
            this.lbIntereset = new System.Windows.Forms.Label();
            this.interesetBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_zamiana = new System.Windows.Forms.Button();
            this.btn_wyloguj = new System.Windows.Forms.Button();
            this.editBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbIntereset
            // 
            this.lbIntereset.AutoSize = true;
            this.lbIntereset.Location = new System.Drawing.Point(124, 41);
            this.lbIntereset.Name = "lbIntereset";
            this.lbIntereset.Size = new System.Drawing.Size(51, 13);
            this.lbIntereset.TabIndex = 0;
            this.lbIntereset.Text = "Intereset:";
            // 
            // interesetBox
            // 
            this.interesetBox.Location = new System.Drawing.Point(75, 58);
            this.interesetBox.Name = "interesetBox";
            this.interesetBox.Size = new System.Drawing.Size(140, 20);
            this.interesetBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_zamiana
            // 
            this.btn_zamiana.Location = new System.Drawing.Point(86, 105);
            this.btn_zamiana.Name = "btn_zamiana";
            this.btn_zamiana.Size = new System.Drawing.Size(116, 63);
            this.btn_zamiana.TabIndex = 3;
            this.btn_zamiana.Text = "Change";
            this.btn_zamiana.UseVisualStyleBackColor = true;
            this.btn_zamiana.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_wyloguj
            // 
            this.btn_wyloguj.Location = new System.Drawing.Point(86, 196);
            this.btn_wyloguj.Name = "btn_wyloguj";
            this.btn_wyloguj.Size = new System.Drawing.Size(116, 63);
            this.btn_wyloguj.TabIndex = 4;
            this.btn_wyloguj.Text = "Log out ";
            this.btn_wyloguj.UseVisualStyleBackColor = true;
            this.btn_wyloguj.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // editBox
            // 
            this.editBox.AutoSize = true;
            this.editBox.Location = new System.Drawing.Point(113, 82);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(76, 17);
            this.editBox.TabIndex = 5;
            this.editBox.Text = "Allow edits";
            this.editBox.UseVisualStyleBackColor = true;
            // 
            // CAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 321);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.btn_wyloguj);
            this.Controls.Add(this.btn_zamiana);
            this.Controls.Add(this.interesetBox);
            this.Controls.Add(this.lbIntereset);
            this.Name = "CAdminPanel";
            this.Text = "CAdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIntereset;
        private System.Windows.Forms.TextBox interesetBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_zamiana;
        private System.Windows.Forms.Button btn_wyloguj;
        private System.Windows.Forms.CheckBox editBox;
    }
}