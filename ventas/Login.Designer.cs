﻿namespace ventas
{
    partial class Login
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
            this.txtusuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcontrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btningresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtusuario.HintText = "";
            this.txtusuario.isPassword = false;
            this.txtusuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtusuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtusuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtusuario.LineThickness = 3;
            this.txtusuario.Location = new System.Drawing.Point(122, 55);
            this.txtusuario.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(206, 55);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontrasena.HintForeColor = System.Drawing.Color.Empty;
            this.txtcontrasena.HintText = "Contrasena";
            this.txtcontrasena.isPassword = false;
            this.txtcontrasena.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcontrasena.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcontrasena.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcontrasena.LineThickness = 3;
            this.txtcontrasena.Location = new System.Drawing.Point(122, 119);
            this.txtcontrasena.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(206, 61);
            this.txtcontrasena.TabIndex = 1;
            this.txtcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontrasena.OnValueChanged += new System.EventHandler(this.txtcontrasena_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 92);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(64, 20);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Usuario";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Transparent;
            this.btningresar.Image = global::ventas.Properties.Resources.login;
            this.btningresar.ImageActive = global::ventas.Properties.Resources.login__1_;
            this.btningresar.Location = new System.Drawing.Point(346, 95);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(70, 71);
            this.btningresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btningresar.TabIndex = 4;
            this.btningresar.TabStop = false;
            this.btningresar.Zoom = 10;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(348, 169);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Acceder";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 206);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcontrasena;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton btningresar;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}