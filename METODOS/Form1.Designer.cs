
namespace Semana_09
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
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_menor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_preOrden = new System.Windows.Forms.ListBox();
            this.lst_enOrden = new System.Windows.Forms.ListBox();
            this.lst_postOrden = new System.Windows.Forms.ListBox();
            this.btn_contar = new System.Windows.Forms.Button();
            this.btn_altura = new System.Windows.Forms.Button();
            this.btn_mayor = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_profundidad = new System.Windows.Forms.Button();
            this.btn_cantHojas = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_diferenciaMenMay = new System.Windows.Forms.Button();
            this.lst_descendente = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(282, 58);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(94, 23);
            this.btn_insertar.TabIndex = 0;
            this.btn_insertar.Text = "INSERTAR";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_menor
            // 
            this.btn_menor.Location = new System.Drawing.Point(701, 173);
            this.btn_menor.Name = "btn_menor";
            this.btn_menor.Size = new System.Drawing.Size(94, 23);
            this.btn_menor.TabIndex = 1;
            this.btn_menor.Text = "MENOR";
            this.btn_menor.UseVisualStyleBackColor = true;
            this.btn_menor.Click += new System.EventHandler(this.btn_menor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VALOR:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(137, 60);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 20);
            this.txt_valor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRE ORDEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "EN ORDEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "POST ORDEN";
            // 
            // lst_preOrden
            // 
            this.lst_preOrden.FormattingEnabled = true;
            this.lst_preOrden.Location = new System.Drawing.Point(42, 266);
            this.lst_preOrden.Name = "lst_preOrden";
            this.lst_preOrden.Size = new System.Drawing.Size(121, 134);
            this.lst_preOrden.TabIndex = 8;
            // 
            // lst_enOrden
            // 
            this.lst_enOrden.FormattingEnabled = true;
            this.lst_enOrden.Location = new System.Drawing.Point(193, 266);
            this.lst_enOrden.Name = "lst_enOrden";
            this.lst_enOrden.Size = new System.Drawing.Size(121, 134);
            this.lst_enOrden.TabIndex = 9;
            // 
            // lst_postOrden
            // 
            this.lst_postOrden.FormattingEnabled = true;
            this.lst_postOrden.Location = new System.Drawing.Point(345, 266);
            this.lst_postOrden.Name = "lst_postOrden";
            this.lst_postOrden.Size = new System.Drawing.Size(120, 134);
            this.lst_postOrden.TabIndex = 10;
            // 
            // btn_contar
            // 
            this.btn_contar.Location = new System.Drawing.Point(701, 115);
            this.btn_contar.Name = "btn_contar";
            this.btn_contar.Size = new System.Drawing.Size(94, 23);
            this.btn_contar.TabIndex = 12;
            this.btn_contar.Text = "CONTAR";
            this.btn_contar.UseVisualStyleBackColor = true;
            this.btn_contar.Click += new System.EventHandler(this.btn_contar_Click);
            // 
            // btn_altura
            // 
            this.btn_altura.Location = new System.Drawing.Point(701, 202);
            this.btn_altura.Name = "btn_altura";
            this.btn_altura.Size = new System.Drawing.Size(94, 23);
            this.btn_altura.TabIndex = 13;
            this.btn_altura.Text = "ALTURA";
            this.btn_altura.UseVisualStyleBackColor = true;
            this.btn_altura.Click += new System.EventHandler(this.btn_altura_Click);
            // 
            // btn_mayor
            // 
            this.btn_mayor.Location = new System.Drawing.Point(701, 144);
            this.btn_mayor.Name = "btn_mayor";
            this.btn_mayor.Size = new System.Drawing.Size(94, 23);
            this.btn_mayor.TabIndex = 14;
            this.btn_mayor.Text = "MAYOR";
            this.btn_mayor.UseVisualStyleBackColor = true;
            this.btn_mayor.Click += new System.EventHandler(this.btn_mayor_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(701, 377);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(94, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_profundidad
            // 
            this.btn_profundidad.Location = new System.Drawing.Point(701, 231);
            this.btn_profundidad.Name = "btn_profundidad";
            this.btn_profundidad.Size = new System.Drawing.Size(94, 23);
            this.btn_profundidad.TabIndex = 16;
            this.btn_profundidad.Text = "PROFUNDIDAD";
            this.btn_profundidad.UseVisualStyleBackColor = true;
            this.btn_profundidad.Click += new System.EventHandler(this.btn_profundidad_Click);
            // 
            // btn_cantHojas
            // 
            this.btn_cantHojas.Location = new System.Drawing.Point(701, 260);
            this.btn_cantHojas.Name = "btn_cantHojas";
            this.btn_cantHojas.Size = new System.Drawing.Size(94, 23);
            this.btn_cantHojas.TabIndex = 17;
            this.btn_cantHojas.Text = "HOJAS";
            this.btn_cantHojas.UseVisualStyleBackColor = true;
            this.btn_cantHojas.Click += new System.EventHandler(this.btn_cantHojas_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(701, 289);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(94, 23);
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_diferenciaMenMay
            // 
            this.btn_diferenciaMenMay.Location = new System.Drawing.Point(88, 106);
            this.btn_diferenciaMenMay.Name = "btn_diferenciaMenMay";
            this.btn_diferenciaMenMay.Size = new System.Drawing.Size(149, 23);
            this.btn_diferenciaMenMay.TabIndex = 19;
            this.btn_diferenciaMenMay.Text = "DIFERENCIA";
            this.btn_diferenciaMenMay.UseVisualStyleBackColor = true;
            this.btn_diferenciaMenMay.Click += new System.EventHandler(this.btn_diferenciaMenMay_Click);
            // 
            // lst_descendente
            // 
            this.lst_descendente.FormattingEnabled = true;
            this.lst_descendente.Location = new System.Drawing.Point(495, 266);
            this.lst_descendente.Name = "lst_descendente";
            this.lst_descendente.Size = new System.Drawing.Size(120, 134);
            this.lst_descendente.TabIndex = 21;
            this.lst_descendente.SelectedIndexChanged += new System.EventHandler(this.lst_descendente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ORDEN DESCENDENTE";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(701, 86);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 23);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 442);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_descendente);
            this.Controls.Add(this.btn_diferenciaMenMay);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_cantHojas);
            this.Controls.Add(this.btn_profundidad);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_mayor);
            this.Controls.Add(this.btn_altura);
            this.Controls.Add(this.btn_contar);
            this.Controls.Add(this.lst_postOrden);
            this.Controls.Add(this.lst_enOrden);
            this.Controls.Add(this.lst_preOrden);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_menor);
            this.Controls.Add(this.btn_insertar);
            this.Name = "Form1";
            this.Text = "JD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_menor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_preOrden;
        private System.Windows.Forms.ListBox lst_enOrden;
        private System.Windows.Forms.ListBox lst_postOrden;
        private System.Windows.Forms.Button btn_contar;
        private System.Windows.Forms.Button btn_altura;
        private System.Windows.Forms.Button btn_mayor;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_profundidad;
        private System.Windows.Forms.Button btn_cantHojas;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_diferenciaMenMay;
        private System.Windows.Forms.ListBox lst_descendente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
    }
}

