﻿namespace TienditaLapeque
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.btnAplicar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aGREGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODIFICARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegresartoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.btnAplicar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(650, 340);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 40);
            this.btnAplicar.TabIndex = 33;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 306);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 32;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Cantidad: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Precio: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(107)))));
            this.dataGridView1.Location = new System.Drawing.Point(335, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 155);
            this.dataGridView1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 51);
            this.label1.TabIndex = 25;
            this.label1.Text = "Agregar Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(107)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 16);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem,
            this.mODIFICARToolStripMenuItem,
            this.bORRARToolStripMenuItem,
            this.vERToolStripMenuItem,
            this.RegresartoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 92);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 36);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aGREGARToolStripMenuItem
            // 
            this.aGREGARToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.aGREGARToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGREGARToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            this.aGREGARToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 1, 0);
            this.aGREGARToolStripMenuItem.Size = new System.Drawing.Size(145, 32);
            this.aGREGARToolStripMenuItem.Text = "AGREGAR";
            // 
            // mODIFICARToolStripMenuItem
            // 
            this.mODIFICARToolStripMenuItem.Name = "mODIFICARToolStripMenuItem";
            this.mODIFICARToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.mODIFICARToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.mODIFICARToolStripMenuItem.Text = "MODIFICAR";
            this.mODIFICARToolStripMenuItem.Click += new System.EventHandler(this.mODIFICARToolStripMenuItem_Click);
            // 
            // bORRARToolStripMenuItem
            // 
            this.bORRARToolStripMenuItem.Name = "bORRARToolStripMenuItem";
            this.bORRARToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.bORRARToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.bORRARToolStripMenuItem.Text = "BORRAR";
            this.bORRARToolStripMenuItem.Click += new System.EventHandler(this.bORRARToolStripMenuItem_Click);
            // 
            // vERToolStripMenuItem
            // 
            this.vERToolStripMenuItem.Name = "vERToolStripMenuItem";
            this.vERToolStripMenuItem.Padding = new System.Windows.Forms.Padding(30, 0, 4, 0);
            this.vERToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.vERToolStripMenuItem.Text = "VER";
            this.vERToolStripMenuItem.Click += new System.EventHandler(this.vERToolStripMenuItem_Click);
            // 
            // RegresartoolStripMenuItem1
            // 
            this.RegresartoolStripMenuItem1.Name = "RegresartoolStripMenuItem1";
            this.RegresartoolStripMenuItem1.Size = new System.Drawing.Size(133, 32);
            this.RegresartoolStripMenuItem1.Text = "REGRESAR";
            this.RegresartoolStripMenuItem1.Click += new System.EventHandler(this.RegresartoolStripMenuItem1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(701, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 45);
            this.button2.TabIndex = 35;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(51)))));
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(487, 133);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(29, 31);
            this.btnbuscar.TabIndex = 46;
            this.btnbuscar.Text = "🔎";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(202, 140);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(282, 20);
            this.txtbuscador.TabIndex = 45;
            this.txtbuscador.TextChanged += new System.EventHandler(this.txtbuscador_TextChanged);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(756, 400);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscador);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODIFICARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegresartoolStripMenuItem1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbuscador;
    }
}