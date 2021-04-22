
namespace Demo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.hashstring_button = new System.Windows.Forms.Button();
            this.string_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salt_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.output_textBox = new System.Windows.Forms.TextBox();
            this.generatepassword_button = new System.Windows.Forms.Button();
            this.generatesalt_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hashstring_button
            // 
            this.hashstring_button.Location = new System.Drawing.Point(15, 138);
            this.hashstring_button.Name = "hashstring_button";
            this.hashstring_button.Size = new System.Drawing.Size(132, 23);
            this.hashstring_button.TabIndex = 0;
            this.hashstring_button.Text = "hash string";
            this.hashstring_button.UseVisualStyleBackColor = true;
            this.hashstring_button.Click += new System.EventHandler(this.hashstring_button_Click);
            // 
            // string_textBox
            // 
            this.string_textBox.Location = new System.Drawing.Point(15, 25);
            this.string_textBox.Name = "string_textBox";
            this.string_textBox.Size = new System.Drawing.Size(429, 20);
            this.string_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salt";
            // 
            // salt_textBox
            // 
            this.salt_textBox.Location = new System.Drawing.Point(15, 64);
            this.salt_textBox.Name = "salt_textBox";
            this.salt_textBox.Size = new System.Drawing.Size(429, 20);
            this.salt_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output";
            // 
            // output_textBox
            // 
            this.output_textBox.Location = new System.Drawing.Point(15, 112);
            this.output_textBox.Name = "output_textBox";
            this.output_textBox.Size = new System.Drawing.Size(429, 20);
            this.output_textBox.TabIndex = 5;
            // 
            // generatepassword_button
            // 
            this.generatepassword_button.Location = new System.Drawing.Point(163, 138);
            this.generatepassword_button.Name = "generatepassword_button";
            this.generatepassword_button.Size = new System.Drawing.Size(132, 23);
            this.generatepassword_button.TabIndex = 7;
            this.generatepassword_button.Text = "generate password";
            this.generatepassword_button.UseVisualStyleBackColor = true;
            this.generatepassword_button.Click += new System.EventHandler(this.generatepassword_button_Click);
            // 
            // generatesalt_button
            // 
            this.generatesalt_button.Location = new System.Drawing.Point(312, 138);
            this.generatesalt_button.Name = "generatesalt_button";
            this.generatesalt_button.Size = new System.Drawing.Size(132, 23);
            this.generatesalt_button.TabIndex = 8;
            this.generatesalt_button.Text = "generate salt";
            this.generatesalt_button.UseVisualStyleBackColor = true;
            this.generatesalt_button.Click += new System.EventHandler(this.generatesalt_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 168);
            this.Controls.Add(this.generatesalt_button);
            this.Controls.Add(this.generatepassword_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.output_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salt_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.string_textBox);
            this.Controls.Add(this.hashstring_button);
            this.Name = "Form1";
            this.Text = "SimplePBKDF2 Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hashstring_button;
        private System.Windows.Forms.TextBox string_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salt_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox output_textBox;
        private System.Windows.Forms.Button generatepassword_button;
        private System.Windows.Forms.Button generatesalt_button;
    }
}

