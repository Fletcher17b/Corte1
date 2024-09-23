namespace Corte1
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
            this.label1 = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_lastname = new System.Windows.Forms.TextBox();
            this.dtp_fnac = new System.Windows.Forms.DateTimePicker();
            this.cmb_ciudad = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nombre:";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Location = new System.Drawing.Point(58, 71);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(43, 13);
            this.apellido.TabIndex = 1;
            this.apellido.Text = "apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "fecha nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ciudad";
            // 
            // txb_name
            // 
            this.txb_name.Location = new System.Drawing.Point(132, 40);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(100, 20);
            this.txb_name.TabIndex = 4;
            // 
            // txb_lastname
            // 
            this.txb_lastname.Location = new System.Drawing.Point(132, 71);
            this.txb_lastname.Name = "txb_lastname";
            this.txb_lastname.Size = new System.Drawing.Size(100, 20);
            this.txb_lastname.TabIndex = 5;
            // 
            // dtp_fnac
            // 
            this.dtp_fnac.Location = new System.Drawing.Point(132, 109);
            this.dtp_fnac.Name = "dtp_fnac";
            this.dtp_fnac.Size = new System.Drawing.Size(200, 20);
            this.dtp_fnac.TabIndex = 6;
            // 
            // cmb_ciudad
            // 
            this.cmb_ciudad.FormattingEnabled = true;
            this.cmb_ciudad.Location = new System.Drawing.Point(132, 142);
            this.cmb_ciudad.Name = "cmb_ciudad";
            this.cmb_ciudad.Size = new System.Drawing.Size(121, 21);
            this.cmb_ciudad.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(224, 242);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_ciudad);
            this.Controls.Add(this.dtp_fnac);
            this.Controls.Add(this.txb_lastname);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.TextBox txb_lastname;
        private System.Windows.Forms.DateTimePicker dtp_fnac;
        private System.Windows.Forms.ComboBox cmb_ciudad;
        private System.Windows.Forms.Button btn_add;
    }
}

