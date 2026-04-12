namespace NOMINAS
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_usuario = new TextBox();
            txt_clave = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_sesion = new Button();
            SuspendLayout();
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(117, 52);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(220, 27);
            txt_usuario.TabIndex = 0;
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(101, 125);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(220, 27);
            txt_clave.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 3;
            label2.Text = "Clave";
            // 
            // btn_sesion
            // 
            btn_sesion.Location = new Point(141, 179);
            btn_sesion.Name = "btn_sesion";
            btn_sesion.Size = new Size(94, 56);
            btn_sesion.TabIndex = 4;
            btn_sesion.Text = "Iniciar Sesion";
            btn_sesion.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 271);
            Controls.Add(btn_sesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_clave);
            Controls.Add(txt_usuario);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_usuario;
        private TextBox txt_clave;
        private Label label1;
        private Label label2;
        private Button btn_sesion;
    }
}
