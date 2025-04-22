using System.Windows.Forms;
using System;

namespace DistribuidoraExpress
{
    public partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.ContraseñaTextBox = new System.Windows.Forms.TextBox();
            this.AccederButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new FontAwesome.Sharp.IconButton();
            this.BotonMinimizar1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(464, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOGIN";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.EmailTextBox.Location = new System.Drawing.Point(363, 97);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(343, 19);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "EMAIL";
            this.EmailTextBox.TextChanged += new System.EventHandler(this.UsuarioTextBox_TextChanged);
            this.EmailTextBox.Enter += new System.EventHandler(this.EmailTextBox_Enter);
            this.EmailTextBox.Leave += new System.EventHandler(this.EmailTextBox_Leave);
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ContraseñaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContraseñaTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.ContraseñaTextBox.Location = new System.Drawing.Point(363, 143);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(343, 19);
            this.ContraseñaTextBox.TabIndex = 2;
            this.ContraseñaTextBox.Text = "CONTRACEÑA";
            this.ContraseñaTextBox.TextChanged += new System.EventHandler(this.ContraseñaTextBox_TextChanged);
            this.ContraseñaTextBox.Enter += new System.EventHandler(this.ContraseñaTextBox_Enter);
            this.ContraseñaTextBox.Leave += new System.EventHandler(this.ContraseñaTextBox_Leave);
            // 
            // AccederButton
            // 
            this.AccederButton.BackColor = System.Drawing.Color.DimGray;
            this.AccederButton.FlatAppearance.BorderSize = 0;
            this.AccederButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.AccederButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccederButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccederButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccederButton.ForeColor = System.Drawing.Color.White;
            this.AccederButton.Location = new System.Drawing.Point(363, 236);
            this.AccederButton.Name = "AccederButton";
            this.AccederButton.Size = new System.Drawing.Size(343, 40);
            this.AccederButton.TabIndex = 0;
            this.AccederButton.Text = "ACEDER";
            this.AccederButton.UseVisualStyleBackColor = false;
            this.AccederButton.Click += new System.EventHandler(this.EntrarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 300);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::DistribuidoraExpress.Properties.Resources._56zrp5ux__3_;
            this.pictureBox5.Location = new System.Drawing.Point(24, 52);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(200, 200);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::DistribuidoraExpress.Properties.Resources.Opera_Captura_de_pantalla_2025_04_19_212859_www_canva_com;
            this.pictureBox2.Location = new System.Drawing.Point(363, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 22);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DistribuidoraExpress.Properties.Resources.Opera_Captura_de_pantalla_2025_04_19_212859_www_canva_com;
            this.pictureBox1.Location = new System.Drawing.Point(363, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(343, 22);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonCerrar.FlatAppearance.BorderSize = 0;
            this.BotonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            this.BotonCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BotonCerrar.IconColor = System.Drawing.Color.LightGray;
            this.BotonCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BotonCerrar.IconSize = 20;
            this.BotonCerrar.Location = new System.Drawing.Point(733, 10);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(35, 20);
            this.BotonCerrar.TabIndex = 12;
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BotonMinimizar1
            // 
            this.BotonMinimizar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotonMinimizar1.FlatAppearance.BorderSize = 0;
            this.BotonMinimizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonMinimizar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(100)))), ((int)(((byte)(87)))));
            this.BotonMinimizar1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BotonMinimizar1.IconColor = System.Drawing.Color.LightGray;
            this.BotonMinimizar1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BotonMinimizar1.IconSize = 20;
            this.BotonMinimizar1.Location = new System.Drawing.Point(702, 10);
            this.BotonMinimizar1.Name = "BotonMinimizar1";
            this.BotonMinimizar1.Size = new System.Drawing.Size(35, 20);
            this.BotonMinimizar1.TabIndex = 13;
            this.BotonMinimizar1.UseVisualStyleBackColor = true;
            this.BotonMinimizar1.Click += new System.EventHandler(this.BotonMinimizar1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 300);
            this.Controls.Add(this.BotonMinimizar1);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AccederButton);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login - App1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox ContraseñaTextBox;
        private System.Windows.Forms.Button AccederButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private FontAwesome.Sharp.IconButton BotonCerrar;
        private FontAwesome.Sharp.IconButton BotonMinimizar1;
    }
}

