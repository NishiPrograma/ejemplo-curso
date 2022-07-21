
namespace ejemplo1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChoco = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbtagua = new System.Windows.Forms.RadioButton();
            this.rbtFuego = new System.Windows.Forms.RadioButton();
            this.rbtHierba = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.numNumeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(181, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(311, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(71, 309);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(620, 105);
            this.lwElementos.TabIndex = 2;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.Location = new System.Drawing.Point(49, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(109, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(43, 105);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(122, 15);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(181, 105);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(411, 22);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // ckbChoco
            // 
            this.ckbChoco.AutoSize = true;
            this.ckbChoco.Location = new System.Drawing.Point(181, 132);
            this.ckbChoco.Name = "ckbChoco";
            this.ckbChoco.Size = new System.Drawing.Size(176, 19);
            this.ckbChoco.TabIndex = 7;
            this.ckbChoco.Text = "Te gusta el chocolate?";
            this.ckbChoco.UseVisualStyleBackColor = true;
            this.ckbChoco.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 34);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Perfil Persona";
            // 
            // rbtagua
            // 
            this.rbtagua.AutoSize = true;
            this.rbtagua.Location = new System.Drawing.Point(4, 36);
            this.rbtagua.Name = "rbtagua";
            this.rbtagua.Size = new System.Drawing.Size(59, 19);
            this.rbtagua.TabIndex = 9;
            this.rbtagua.TabStop = true;
            this.rbtagua.Text = "Agua";
            this.rbtagua.UseVisualStyleBackColor = true;
            // 
            // rbtFuego
            // 
            this.rbtFuego.AutoSize = true;
            this.rbtFuego.Location = new System.Drawing.Point(139, 36);
            this.rbtFuego.Name = "rbtFuego";
            this.rbtFuego.Size = new System.Drawing.Size(67, 19);
            this.rbtFuego.TabIndex = 10;
            this.rbtFuego.TabStop = true;
            this.rbtFuego.Text = "Fuego";
            this.rbtFuego.UseVisualStyleBackColor = true;
            this.rbtFuego.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtHierba
            // 
            this.rbtHierba.AutoSize = true;
            this.rbtHierba.Location = new System.Drawing.Point(277, 36);
            this.rbtHierba.Name = "rbtHierba";
            this.rbtHierba.Size = new System.Drawing.Size(68, 19);
            this.rbtHierba.TabIndex = 11;
            this.rbtHierba.TabStop = true;
            this.rbtHierba.Text = "Hierba";
            this.rbtHierba.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTipo.Controls.Add(this.rbtFuego);
            this.gbxTipo.Controls.Add(this.rbtHierba);
            this.gbxTipo.Controls.Add(this.rbtagua);
            this.gbxTipo.Location = new System.Drawing.Point(99, 150);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(559, 70);
            this.gbxTipo.TabIndex = 12;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(68, 227);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(97, 15);
            this.lblColor.TabIndex = 13;
            this.lblColor.Text = "Color Favorito";
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(166, 224);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(332, 23);
            this.cbColor.TabIndex = 14;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // numNumeroFavorito
            // 
            this.numNumeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFavorito.Location = new System.Drawing.Point(166, 254);
            this.numNumeroFavorito.Name = "numNumeroFavorito";
            this.numNumeroFavorito.Size = new System.Drawing.Size(331, 22);
            this.numNumeroFavorito.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(52, 256);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(113, 15);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero Favorito";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(55, 280);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 17;
            this.btnPerfil.Text = "Ver perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 449);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.numNumeroFavorito);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.ckbChoco);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox ckbChoco;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbtagua;
        private System.Windows.Forms.RadioButton rbtHierba;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.RadioButton rbtFuego;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.NumericUpDown numNumeroFavorito;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnPerfil;
    }
}

