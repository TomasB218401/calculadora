
namespace Calculadora_tb
{
    partial class Form1
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
            this.txb_datos = new System.Windows.Forms.TextBox();
            this.pnl_deco_backTxbox_datos = new System.Windows.Forms.Panel();
            this.pnl_back_calcu = new System.Windows.Forms.Panel();
            this.btn_coma = new System.Windows.Forms.Button();
            this.btn_simbolo_eliminar = new System.Windows.Forms.Button();
            this.btn_simbolo_igual = new System.Windows.Forms.Button();
            this.btn_simbolo_CEborrar = new System.Windows.Forms.Button();
            this.btn_simbolo_multiplicar = new System.Windows.Forms.Button();
            this.btn_simbolo_dividir = new System.Windows.Forms.Button();
            this.btn_simbolo_resta = new System.Windows.Forms.Button();
            this.btn_simbolo_suma = new System.Windows.Forms.Button();
            this.btn_num_0 = new System.Windows.Forms.Button();
            this.btn_num_9 = new System.Windows.Forms.Button();
            this.btn_num_8 = new System.Windows.Forms.Button();
            this.btn_num_7 = new System.Windows.Forms.Button();
            this.btn_num_6 = new System.Windows.Forms.Button();
            this.btn_num_5 = new System.Windows.Forms.Button();
            this.btn_num_4 = new System.Windows.Forms.Button();
            this.btn_num_3 = new System.Windows.Forms.Button();
            this.btn_num_2 = new System.Windows.Forms.Button();
            this.btn_num_1 = new System.Windows.Forms.Button();
            this.pnl_deco_backTxbox_datos.SuspendLayout();
            this.pnl_back_calcu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_datos
            // 
            this.txb_datos.Enabled = false;
            this.txb_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_datos.Location = new System.Drawing.Point(14, 13);
            this.txb_datos.Name = "txb_datos";
            this.txb_datos.Size = new System.Drawing.Size(371, 44);
            this.txb_datos.TabIndex = 0;
            this.txb_datos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnl_deco_backTxbox_datos
            // 
            this.pnl_deco_backTxbox_datos.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnl_deco_backTxbox_datos.Controls.Add(this.txb_datos);
            this.pnl_deco_backTxbox_datos.Location = new System.Drawing.Point(13, 13);
            this.pnl_deco_backTxbox_datos.Name = "pnl_deco_backTxbox_datos";
            this.pnl_deco_backTxbox_datos.Size = new System.Drawing.Size(397, 70);
            this.pnl_deco_backTxbox_datos.TabIndex = 1;
            // 
            // pnl_back_calcu
            // 
            this.pnl_back_calcu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnl_back_calcu.Controls.Add(this.btn_coma);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_eliminar);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_igual);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_CEborrar);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_multiplicar);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_dividir);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_resta);
            this.pnl_back_calcu.Controls.Add(this.btn_simbolo_suma);
            this.pnl_back_calcu.Controls.Add(this.btn_num_0);
            this.pnl_back_calcu.Controls.Add(this.btn_num_9);
            this.pnl_back_calcu.Controls.Add(this.btn_num_8);
            this.pnl_back_calcu.Controls.Add(this.btn_num_7);
            this.pnl_back_calcu.Controls.Add(this.btn_num_6);
            this.pnl_back_calcu.Controls.Add(this.btn_num_5);
            this.pnl_back_calcu.Controls.Add(this.btn_num_4);
            this.pnl_back_calcu.Controls.Add(this.btn_num_3);
            this.pnl_back_calcu.Controls.Add(this.btn_num_2);
            this.pnl_back_calcu.Controls.Add(this.btn_num_1);
            this.pnl_back_calcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_back_calcu.Location = new System.Drawing.Point(13, 100);
            this.pnl_back_calcu.Name = "pnl_back_calcu";
            this.pnl_back_calcu.Size = new System.Drawing.Size(397, 409);
            this.pnl_back_calcu.TabIndex = 2;
            // 
            // btn_coma
            // 
            this.btn_coma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_coma.Location = new System.Drawing.Point(195, 334);
            this.btn_coma.Name = "btn_coma";
            this.btn_coma.Size = new System.Drawing.Size(75, 62);
            this.btn_coma.TabIndex = 17;
            this.btn_coma.Text = ",";
            this.btn_coma.UseVisualStyleBackColor = false;
            this.btn_coma.Click += new System.EventHandler(this.btn_operaciones_Click);
            this.btn_coma.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_coma.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_eliminar
            // 
            this.btn_simbolo_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_eliminar.Location = new System.Drawing.Point(195, 17);
            this.btn_simbolo_eliminar.Name = "btn_simbolo_eliminar";
            this.btn_simbolo_eliminar.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_eliminar.TabIndex = 16;
            this.btn_simbolo_eliminar.Text = "<----";
            this.btn_simbolo_eliminar.UseVisualStyleBackColor = false;
            this.btn_simbolo_eliminar.Click += new System.EventHandler(this.btn_simbolo_eliminar_Click);
            this.btn_simbolo_eliminar.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_eliminar.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_igual
            // 
            this.btn_simbolo_igual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_igual.Location = new System.Drawing.Point(288, 257);
            this.btn_simbolo_igual.Name = "btn_simbolo_igual";
            this.btn_simbolo_igual.Size = new System.Drawing.Size(75, 139);
            this.btn_simbolo_igual.TabIndex = 15;
            this.btn_simbolo_igual.Text = "=";
            this.btn_simbolo_igual.UseVisualStyleBackColor = false;
            this.btn_simbolo_igual.Click += new System.EventHandler(this.btn_simbolo_igual_Click);
            this.btn_simbolo_igual.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_igual.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_CEborrar
            // 
            this.btn_simbolo_CEborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_CEborrar.Location = new System.Drawing.Point(288, 17);
            this.btn_simbolo_CEborrar.Name = "btn_simbolo_CEborrar";
            this.btn_simbolo_CEborrar.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_CEborrar.TabIndex = 14;
            this.btn_simbolo_CEborrar.Text = "CE";
            this.btn_simbolo_CEborrar.UseVisualStyleBackColor = false;
            this.btn_simbolo_CEborrar.Click += new System.EventHandler(this.btn_simbolo_CEborrar_Click);
            this.btn_simbolo_CEborrar.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_CEborrar.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_multiplicar
            // 
            this.btn_simbolo_multiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_multiplicar.Location = new System.Drawing.Point(114, 17);
            this.btn_simbolo_multiplicar.Name = "btn_simbolo_multiplicar";
            this.btn_simbolo_multiplicar.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_multiplicar.TabIndex = 13;
            this.btn_simbolo_multiplicar.Tag = "M";
            this.btn_simbolo_multiplicar.Text = "X";
            this.btn_simbolo_multiplicar.UseVisualStyleBackColor = false;
            this.btn_simbolo_multiplicar.Click += new System.EventHandler(this.btn_operaciones_Click);
            this.btn_simbolo_multiplicar.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_multiplicar.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_dividir
            // 
            this.btn_simbolo_dividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simbolo_dividir.Location = new System.Drawing.Point(33, 17);
            this.btn_simbolo_dividir.Name = "btn_simbolo_dividir";
            this.btn_simbolo_dividir.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_dividir.TabIndex = 12;
            this.btn_simbolo_dividir.Tag = "D";
            this.btn_simbolo_dividir.Text = "÷";
            this.btn_simbolo_dividir.UseVisualStyleBackColor = false;
            this.btn_simbolo_dividir.Click += new System.EventHandler(this.btn_operaciones_Click);
            this.btn_simbolo_dividir.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_dividir.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_resta
            // 
            this.btn_simbolo_resta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simbolo_resta.Location = new System.Drawing.Point(288, 99);
            this.btn_simbolo_resta.Name = "btn_simbolo_resta";
            this.btn_simbolo_resta.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_resta.TabIndex = 11;
            this.btn_simbolo_resta.Tag = "R";
            this.btn_simbolo_resta.Text = "-";
            this.btn_simbolo_resta.UseVisualStyleBackColor = false;
            this.btn_simbolo_resta.Click += new System.EventHandler(this.btn_operaciones_Click);
            this.btn_simbolo_resta.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_resta.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_simbolo_suma
            // 
            this.btn_simbolo_suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_simbolo_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simbolo_suma.Location = new System.Drawing.Point(288, 178);
            this.btn_simbolo_suma.Name = "btn_simbolo_suma";
            this.btn_simbolo_suma.Size = new System.Drawing.Size(75, 62);
            this.btn_simbolo_suma.TabIndex = 10;
            this.btn_simbolo_suma.Tag = "S";
            this.btn_simbolo_suma.Text = "+";
            this.btn_simbolo_suma.UseVisualStyleBackColor = false;
            this.btn_simbolo_suma.Click += new System.EventHandler(this.btn_operaciones_Click);
            this.btn_simbolo_suma.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_simbolo_suma.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_0
            // 
            this.btn_num_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_0.Location = new System.Drawing.Point(33, 334);
            this.btn_num_0.Name = "btn_num_0";
            this.btn_num_0.Size = new System.Drawing.Size(156, 62);
            this.btn_num_0.TabIndex = 9;
            this.btn_num_0.Text = "0";
            this.btn_num_0.UseVisualStyleBackColor = false;
            this.btn_num_0.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_0.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_0.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_9
            // 
            this.btn_num_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_9.Location = new System.Drawing.Point(195, 257);
            this.btn_num_9.Name = "btn_num_9";
            this.btn_num_9.Size = new System.Drawing.Size(75, 62);
            this.btn_num_9.TabIndex = 8;
            this.btn_num_9.Text = "9";
            this.btn_num_9.UseVisualStyleBackColor = false;
            this.btn_num_9.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_9.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_9.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_8
            // 
            this.btn_num_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_8.Location = new System.Drawing.Point(114, 257);
            this.btn_num_8.Name = "btn_num_8";
            this.btn_num_8.Size = new System.Drawing.Size(75, 62);
            this.btn_num_8.TabIndex = 7;
            this.btn_num_8.Text = "8";
            this.btn_num_8.UseVisualStyleBackColor = false;
            this.btn_num_8.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_8.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_8.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_7
            // 
            this.btn_num_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_7.Location = new System.Drawing.Point(33, 257);
            this.btn_num_7.Name = "btn_num_7";
            this.btn_num_7.Size = new System.Drawing.Size(75, 62);
            this.btn_num_7.TabIndex = 6;
            this.btn_num_7.Text = "7";
            this.btn_num_7.UseVisualStyleBackColor = false;
            this.btn_num_7.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_7.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_7.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_6
            // 
            this.btn_num_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_6.Location = new System.Drawing.Point(195, 178);
            this.btn_num_6.Name = "btn_num_6";
            this.btn_num_6.Size = new System.Drawing.Size(75, 62);
            this.btn_num_6.TabIndex = 5;
            this.btn_num_6.Text = "6";
            this.btn_num_6.UseVisualStyleBackColor = false;
            this.btn_num_6.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_6.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_6.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_5
            // 
            this.btn_num_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_5.Location = new System.Drawing.Point(114, 178);
            this.btn_num_5.Name = "btn_num_5";
            this.btn_num_5.Size = new System.Drawing.Size(75, 62);
            this.btn_num_5.TabIndex = 4;
            this.btn_num_5.Text = "5";
            this.btn_num_5.UseVisualStyleBackColor = false;
            this.btn_num_5.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_5.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_5.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_4
            // 
            this.btn_num_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_4.Location = new System.Drawing.Point(33, 178);
            this.btn_num_4.Name = "btn_num_4";
            this.btn_num_4.Size = new System.Drawing.Size(75, 62);
            this.btn_num_4.TabIndex = 3;
            this.btn_num_4.Text = "4";
            this.btn_num_4.UseVisualStyleBackColor = false;
            this.btn_num_4.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_4.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_4.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_3
            // 
            this.btn_num_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_3.Location = new System.Drawing.Point(195, 99);
            this.btn_num_3.Name = "btn_num_3";
            this.btn_num_3.Size = new System.Drawing.Size(75, 62);
            this.btn_num_3.TabIndex = 2;
            this.btn_num_3.Text = "3";
            this.btn_num_3.UseVisualStyleBackColor = false;
            this.btn_num_3.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_3.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_3.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_2
            // 
            this.btn_num_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_2.Location = new System.Drawing.Point(114, 99);
            this.btn_num_2.Name = "btn_num_2";
            this.btn_num_2.Size = new System.Drawing.Size(75, 62);
            this.btn_num_2.TabIndex = 1;
            this.btn_num_2.Text = "2";
            this.btn_num_2.UseVisualStyleBackColor = false;
            this.btn_num_2.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_2.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_2.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // btn_num_1
            // 
            this.btn_num_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.btn_num_1.Location = new System.Drawing.Point(33, 99);
            this.btn_num_1.Name = "btn_num_1";
            this.btn_num_1.Size = new System.Drawing.Size(75, 62);
            this.btn_num_1.TabIndex = 0;
            this.btn_num_1.Text = "1";
            this.btn_num_1.UseVisualStyleBackColor = false;
            this.btn_num_1.Click += new System.EventHandler(this.btn_numerico_Click);
            this.btn_num_1.MouseLeave += new System.EventHandler(this.btn_color_leave);
            this.btn_num_1.MouseHover += new System.EventHandler(this.btn_colores_hover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(450, 521);
            this.Controls.Add(this.pnl_back_calcu);
            this.Controls.Add(this.pnl_deco_backTxbox_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_deco_backTxbox_datos.ResumeLayout(false);
            this.pnl_deco_backTxbox_datos.PerformLayout();
            this.pnl_back_calcu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txb_datos;
        private System.Windows.Forms.Panel pnl_deco_backTxbox_datos;
        private System.Windows.Forms.Panel pnl_back_calcu;
        private System.Windows.Forms.Button btn_num_9;
        private System.Windows.Forms.Button btn_num_8;
        private System.Windows.Forms.Button btn_num_7;
        private System.Windows.Forms.Button btn_num_6;
        private System.Windows.Forms.Button btn_num_5;
        private System.Windows.Forms.Button btn_num_4;
        private System.Windows.Forms.Button btn_num_3;
        private System.Windows.Forms.Button btn_num_2;
        private System.Windows.Forms.Button btn_num_1;
        private System.Windows.Forms.Button btn_simbolo_igual;
        private System.Windows.Forms.Button btn_simbolo_CEborrar;
        private System.Windows.Forms.Button btn_simbolo_multiplicar;
        private System.Windows.Forms.Button btn_simbolo_dividir;
        private System.Windows.Forms.Button btn_simbolo_resta;
        private System.Windows.Forms.Button btn_simbolo_suma;
        private System.Windows.Forms.Button btn_num_0;
        private System.Windows.Forms.Button btn_simbolo_eliminar;
        private System.Windows.Forms.Button btn_coma;
    }
}

