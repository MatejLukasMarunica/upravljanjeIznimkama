namespace upravljanjeIznikama
{
    partial class Form1
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
            this.txtunos = new System.Windows.Forms.TextBox();
            this.unos = new System.Windows.Forms.Button();
            this.txtunos1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtunos
            // 
            this.txtunos.Location = new System.Drawing.Point(38, 73);
            this.txtunos.Multiline = true;
            this.txtunos.Name = "txtunos";
            this.txtunos.Size = new System.Drawing.Size(242, 38);
            this.txtunos.TabIndex = 0;
            // 
            // unos
            // 
            this.unos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unos.Location = new System.Drawing.Point(345, 73);
            this.unos.Name = "unos";
            this.unos.Size = new System.Drawing.Size(203, 157);
            this.unos.TabIndex = 1;
            this.unos.Text = "Unos";
            this.unos.UseVisualStyleBackColor = true;
            this.unos.Click += new System.EventHandler(this.unos_Click);
            // 
            // txtunos1
            // 
            this.txtunos1.Location = new System.Drawing.Point(38, 192);
            this.txtunos1.Multiline = true;
            this.txtunos1.Name = "txtunos1";
            this.txtunos1.Size = new System.Drawing.Size(242, 38);
            this.txtunos1.TabIndex = 2;
            this.txtunos1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesi svoju godinu rođenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rođen si:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtunos1);
            this.Controls.Add(this.unos);
            this.Controls.Add(this.txtunos);
            this.Name = "Form1";
            this.Text = "Upravljanje Iznikama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtunos;
        private System.Windows.Forms.Button unos;
        private System.Windows.Forms.TextBox txtunos1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

