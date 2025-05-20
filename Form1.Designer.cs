namespace ListasSimplementeEnlazadas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_change_xy = new System.Windows.Forms.Button();
            this.btn_remove_n = new System.Windows.Forms.Button();
            this.btn_remove_final = new System.Windows.Forms.Button();
            this.btn_remove_inicio = new System.Windows.Forms.Button();
            this.btn_add_n = new System.Windows.Forms.Button();
            this.btn_add_final = new System.Windows.Forms.Button();
            this.btn_add_inicio = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.input_pos1 = new System.Windows.Forms.TextBox();
            this.input_pos2 = new System.Windows.Forms.TextBox();
            this.btn_borrartodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 329);
            this.listBox1.TabIndex = 0;
            // 
            // btn_change_xy
            // 
            this.btn_change_xy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_xy.Location = new System.Drawing.Point(335, 328);
            this.btn_change_xy.Name = "btn_change_xy";
            this.btn_change_xy.Size = new System.Drawing.Size(168, 52);
            this.btn_change_xy.TabIndex = 21;
            this.btn_change_xy.Text = "INTERCAMBIAR POSICIONES";
            this.btn_change_xy.UseVisualStyleBackColor = true;
            this.btn_change_xy.Click += new System.EventHandler(this.btn_change_xy_Click);
            // 
            // btn_remove_n
            // 
            this.btn_remove_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_n.Location = new System.Drawing.Point(335, 270);
            this.btn_remove_n.Name = "btn_remove_n";
            this.btn_remove_n.Size = new System.Drawing.Size(168, 52);
            this.btn_remove_n.TabIndex = 20;
            this.btn_remove_n.Text = "QUITA POSICION n";
            this.btn_remove_n.UseVisualStyleBackColor = true;
            this.btn_remove_n.Click += new System.EventHandler(this.btn_remove_n_Click);
            // 
            // btn_remove_final
            // 
            this.btn_remove_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_final.Location = new System.Drawing.Point(335, 212);
            this.btn_remove_final.Name = "btn_remove_final";
            this.btn_remove_final.Size = new System.Drawing.Size(168, 52);
            this.btn_remove_final.TabIndex = 19;
            this.btn_remove_final.Text = "QUITA AL FINAL";
            this.btn_remove_final.UseVisualStyleBackColor = true;
            this.btn_remove_final.Click += new System.EventHandler(this.btn_remove_final_Click);
            // 
            // btn_remove_inicio
            // 
            this.btn_remove_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove_inicio.Location = new System.Drawing.Point(335, 154);
            this.btn_remove_inicio.Name = "btn_remove_inicio";
            this.btn_remove_inicio.Size = new System.Drawing.Size(168, 52);
            this.btn_remove_inicio.TabIndex = 18;
            this.btn_remove_inicio.Text = "QUITA AL INICIO";
            this.btn_remove_inicio.UseVisualStyleBackColor = true;
            this.btn_remove_inicio.Click += new System.EventHandler(this.btn_remove_inicio_Click);
            // 
            // btn_add_n
            // 
            this.btn_add_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_n.Location = new System.Drawing.Point(519, 270);
            this.btn_add_n.Name = "btn_add_n";
            this.btn_add_n.Size = new System.Drawing.Size(168, 52);
            this.btn_add_n.TabIndex = 17;
            this.btn_add_n.Text = "AGREGA POSICION n";
            this.btn_add_n.UseVisualStyleBackColor = true;
            this.btn_add_n.Click += new System.EventHandler(this.btn_add_n_Click);
            // 
            // btn_add_final
            // 
            this.btn_add_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_final.Location = new System.Drawing.Point(519, 212);
            this.btn_add_final.Name = "btn_add_final";
            this.btn_add_final.Size = new System.Drawing.Size(168, 52);
            this.btn_add_final.TabIndex = 16;
            this.btn_add_final.Text = "AGREGA AL FINAL";
            this.btn_add_final.UseVisualStyleBackColor = true;
            this.btn_add_final.Click += new System.EventHandler(this.btn_add_final_Click);
            // 
            // btn_add_inicio
            // 
            this.btn_add_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_inicio.Location = new System.Drawing.Point(519, 154);
            this.btn_add_inicio.Name = "btn_add_inicio";
            this.btn_add_inicio.Size = new System.Drawing.Size(168, 52);
            this.btn_add_inicio.TabIndex = 15;
            this.btn_add_inicio.Text = "AGREGA AL INICIO";
            this.btn_add_inicio.UseVisualStyleBackColor = true;
            this.btn_add_inicio.Click += new System.EventHandler(this.btn_add_inicio_Click);
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(335, 49);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(352, 29);
            this.input1.TabIndex = 14;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(19, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(292, 412);
            this.listBox.TabIndex = 12;
            // 
            // input_pos1
            // 
            this.input_pos1.Location = new System.Drawing.Point(374, 103);
            this.input_pos1.Name = "input_pos1";
            this.input_pos1.Size = new System.Drawing.Size(100, 20);
            this.input_pos1.TabIndex = 22;
            // 
            // input_pos2
            // 
            this.input_pos2.Location = new System.Drawing.Point(544, 103);
            this.input_pos2.Name = "input_pos2";
            this.input_pos2.Size = new System.Drawing.Size(100, 20);
            this.input_pos2.TabIndex = 23;
            // 
            // btn_borrartodo
            // 
            this.btn_borrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrartodo.Location = new System.Drawing.Point(519, 328);
            this.btn_borrartodo.Name = "btn_borrartodo";
            this.btn_borrartodo.Size = new System.Drawing.Size(168, 52);
            this.btn_borrartodo.TabIndex = 24;
            this.btn_borrartodo.Text = "BORRAR TODO";
            this.btn_borrartodo.UseVisualStyleBackColor = true;
            this.btn_borrartodo.Click += new System.EventHandler(this.btn_borrartodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_borrartodo);
            this.Controls.Add(this.input_pos2);
            this.Controls.Add(this.input_pos1);
            this.Controls.Add(this.btn_change_xy);
            this.Controls.Add(this.btn_remove_n);
            this.Controls.Add(this.btn_remove_final);
            this.Controls.Add(this.btn_remove_inicio);
            this.Controls.Add(this.btn_add_n);
            this.Controls.Add(this.btn_add_final);
            this.Controls.Add(this.btn_add_inicio);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_change_xy;
        private System.Windows.Forms.Button btn_remove_n;
        private System.Windows.Forms.Button btn_remove_final;
        private System.Windows.Forms.Button btn_remove_inicio;
        private System.Windows.Forms.Button btn_add_n;
        private System.Windows.Forms.Button btn_add_final;
        private System.Windows.Forms.Button btn_add_inicio;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox input_pos1;
        private System.Windows.Forms.TextBox input_pos2;
        private System.Windows.Forms.Button btn_borrartodo;
    }
}

