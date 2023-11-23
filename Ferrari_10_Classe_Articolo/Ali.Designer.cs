namespace Ferrari_10_Classe_Articolo
{
    partial class Ali
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
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(218, 87);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(325, 20);
            this.textBoxInfo.TabIndex = 21;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(218, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(325, 20);
            this.textBoxID.TabIndex = 20;
            // 
            // labelInfo
            // 
            this.labelInfo.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInfo.Location = new System.Drawing.Point(12, 76);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(200, 50);
            this.labelInfo.TabIndex = 17;
            this.labelInfo.Text = "Descrizione";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelID.Location = new System.Drawing.Point(12, 26);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(200, 50);
            this.labelID.TabIndex = 16;
            this.labelID.Text = "ID prodotto";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Crimson;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSubmit.Location = new System.Drawing.Point(199, 298);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 60);
            this.buttonSubmit.TabIndex = 15;
            this.buttonSubmit.TabStop = false;
            this.buttonSubmit.Text = "Inserisci";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            // 
            // Ali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(555, 384);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonSubmit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Ali";
            this.Text = "Ali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSubmit;
    }
}