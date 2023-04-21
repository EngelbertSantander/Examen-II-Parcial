namespace Vista
{
    partial class SoporteForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoporteForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tipotextBox = new System.Windows.Forms.TextBox();
            this.soluciontextBox = new System.Windows.Forms.TextBox();
            this.descripciontextBox = new System.Windows.Forms.TextBox();
            this.preciotextBox = new System.Windows.Forms.TextBox();
            this.soportesdataGridView = new System.Windows.Forms.DataGridView();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.modificarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.soportesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE SOPORTE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCIÓN: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(70, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOLUCIÓN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(95, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "PRECIO:";
            // 
            // tipotextBox
            // 
            this.tipotextBox.Location = new System.Drawing.Point(189, 69);
            this.tipotextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tipotextBox.Name = "tipotextBox";
            this.tipotextBox.Size = new System.Drawing.Size(207, 27);
            this.tipotextBox.TabIndex = 4;
            // 
            // soluciontextBox
            // 
            this.soluciontextBox.Location = new System.Drawing.Point(189, 151);
            this.soluciontextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soluciontextBox.Name = "soluciontextBox";
            this.soluciontextBox.Size = new System.Drawing.Size(420, 27);
            this.soluciontextBox.TabIndex = 5;
            // 
            // descripciontextBox
            // 
            this.descripciontextBox.Location = new System.Drawing.Point(189, 110);
            this.descripciontextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.descripciontextBox.Name = "descripciontextBox";
            this.descripciontextBox.Size = new System.Drawing.Size(420, 27);
            this.descripciontextBox.TabIndex = 6;
            // 
            // preciotextBox
            // 
            this.preciotextBox.Location = new System.Drawing.Point(189, 193);
            this.preciotextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preciotextBox.Name = "preciotextBox";
            this.preciotextBox.Size = new System.Drawing.Size(207, 27);
            this.preciotextBox.TabIndex = 7;
            // 
            // soportesdataGridView
            // 
            this.soportesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soportesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soportesdataGridView.Location = new System.Drawing.Point(34, 305);
            this.soportesdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soportesdataGridView.Name = "soportesdataGridView";
            this.soportesdataGridView.RowHeadersWidth = 51;
            this.soportesdataGridView.RowTemplate.Height = 25;
            this.soportesdataGridView.Size = new System.Drawing.Size(769, 204);
            this.soportesdataGridView.TabIndex = 30;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Location = new System.Drawing.Point(555, 249);
            this.cancelarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(82, 37);
            this.cancelarbutton.TabIndex = 29;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Location = new System.Drawing.Point(465, 249);
            this.eliminarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(82, 37);
            this.eliminarbutton.TabIndex = 28;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Location = new System.Drawing.Point(376, 249);
            this.guardarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(82, 37);
            this.guardarbutton.TabIndex = 27;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // modificarbutton
            // 
            this.modificarbutton.Location = new System.Drawing.Point(287, 249);
            this.modificarbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.modificarbutton.Name = "modificarbutton";
            this.modificarbutton.Size = new System.Drawing.Size(82, 37);
            this.modificarbutton.TabIndex = 26;
            this.modificarbutton.Text = "Modificar";
            this.modificarbutton.UseVisualStyleBackColor = true;
            this.modificarbutton.Click += new System.EventHandler(this.modificarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(198, 249);
            this.nuevobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(82, 37);
            this.nuevobutton.TabIndex = 25;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.soportesdataGridView);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.modificarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.preciotextBox);
            this.Controls.Add(this.descripciontextBox);
            this.Controls.Add(this.soluciontextBox);
            this.Controls.Add(this.tipotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SoporteForm";
            this.Text = "SoporteForm";
            this.Load += new System.EventHandler(this.SoporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soportesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tipotextBox;
        private TextBox soluciontextBox;
        private TextBox descripciontextBox;
        private TextBox preciotextBox;
        private DataGridView soportesdataGridView;
        private Button cancelarbutton;
        private Button eliminarbutton;
        private Button guardarbutton;
        private Button modificarbutton;
        private Button nuevobutton;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
    }
}