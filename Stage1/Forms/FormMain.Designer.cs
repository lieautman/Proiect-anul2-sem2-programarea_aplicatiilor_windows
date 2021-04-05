
namespace AbonatiTelefonici
{
    partial class FormMain
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
            this.btnClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbonament = new System.Windows.Forms.Button();
            this.btnExtraOptiuni = new System.Windows.Forms.Button();
            this.btnTipAbonament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(331, 133);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(239, 94);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Formular Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dati click pe butonul cu formularul ce trebuie completat!";
            // 
            // btnAbonament
            // 
            this.btnAbonament.Location = new System.Drawing.Point(636, 133);
            this.btnAbonament.Name = "btnAbonament";
            this.btnAbonament.Size = new System.Drawing.Size(239, 94);
            this.btnAbonament.TabIndex = 2;
            this.btnAbonament.Text = "Formular Abonament";
            this.btnAbonament.UseVisualStyleBackColor = true;
            this.btnAbonament.Click += new System.EventHandler(this.btnAbonament_Click);
            // 
            // btnExtraOptiuni
            // 
            this.btnExtraOptiuni.Location = new System.Drawing.Point(939, 133);
            this.btnExtraOptiuni.Name = "btnExtraOptiuni";
            this.btnExtraOptiuni.Size = new System.Drawing.Size(239, 94);
            this.btnExtraOptiuni.TabIndex = 4;
            this.btnExtraOptiuni.Text = "Formular ExtraOptiuni";
            this.btnExtraOptiuni.UseVisualStyleBackColor = true;
            this.btnExtraOptiuni.Click += new System.EventHandler(this.btnExtraOptiuni_Click);
            // 
            // btnTipAbonament
            // 
            this.btnTipAbonament.Location = new System.Drawing.Point(142, 310);
            this.btnTipAbonament.Name = "btnTipAbonament";
            this.btnTipAbonament.Size = new System.Drawing.Size(239, 94);
            this.btnTipAbonament.TabIndex = 5;
            this.btnTipAbonament.Text = "Formular Tip Abonament";
            this.btnTipAbonament.UseVisualStyleBackColor = true;
            this.btnTipAbonament.Click += new System.EventHandler(this.btnTipAbonament_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1495, 584);
            this.Controls.Add(this.btnTipAbonament);
            this.Controls.Add(this.btnExtraOptiuni);
            this.Controls.Add(this.btnAbonament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClient);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAbonament;
        private System.Windows.Forms.Button btnExtraOptiuni;
        private System.Windows.Forms.Button btnTipAbonament;
    }
}