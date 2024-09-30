namespace agenda_de_contado
{
    partial class Form1
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
            btneditar = new Button();
            btnremove = new Button();
            lista = new ListBox();
            txtnome = new TextBox();
            textemail = new TextBox();
            textnumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnadd = new Button();
            btnlimpar = new Button();
            SuspendLayout();
            // 
            // btneditar
            // 
            btneditar.Location = new Point(299, 165);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(110, 34);
            btneditar.TabIndex = 0;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnremove
            // 
            btnremove.Location = new Point(299, 215);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(110, 34);
            btnremove.TabIndex = 1;
            btnremove.Text = "Remover";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 12);
            lista.Name = "lista";
            lista.Size = new Size(574, 139);
            lista.TabIndex = 2;
            lista.SelectedIndexChanged += lista_SelectedIndexChanged;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(42, 181);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(236, 23);
            txtnome.TabIndex = 3;
            // 
            // textemail
            // 
            textemail.Location = new Point(42, 281);
            textemail.Name = "textemail";
            textemail.Size = new Size(236, 23);
            textemail.TabIndex = 4;
            // 
            // textnumero
            // 
            textnumero.Location = new Point(42, 233);
            textnumero.Name = "textnumero";
            textnumero.Size = new Size(236, 23);
            textnumero.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 163);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 215);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Número:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 263);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(299, 270);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(110, 34);
            btnadd.TabIndex = 9;
            btnadd.Text = "Adicionar";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(429, 165);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(110, 34);
            btnlimpar.TabIndex = 10;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 328);
            Controls.Add(btnlimpar);
            Controls.Add(btnadd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textnumero);
            Controls.Add(textemail);
            Controls.Add(txtnome);
            Controls.Add(lista);
            Controls.Add(btnremove);
            Controls.Add(btneditar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btneditar;
        private Button btnremove;
        private ListBox lista;
        private TextBox txtnome;
        private TextBox textemail;
        private TextBox textnumero;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnadd;
        private Button btnlimpar;
    }
}
