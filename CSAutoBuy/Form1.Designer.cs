
namespace CSAutoBuy
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaminhao = new System.Windows.Forms.TextBox();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.btnPorcurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtF3 = new System.Windows.Forms.RadioButton();
            this.rbtF4 = new System.Windows.Forms.RadioButton();
            this.rbtF6 = new System.Windows.Forms.RadioButton();
            this.rbtF7 = new System.Windows.Forms.RadioButton();
            this.rbtF8 = new System.Windows.Forms.RadioButton();
            this.rbtF9 = new System.Windows.Forms.RadioButton();
            this.rbtF11 = new System.Windows.Forms.RadioButton();
            this.rbtF12 = new System.Windows.Forms.RadioButton();
            this.rbtOutra = new System.Windows.Forms.RadioButton();
            this.txtTecla = new System.Windows.Forms.TextBox();
            this.txtArquivoLido = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listEquipamentos = new System.Windows.Forms.ListBox();
            this.listEquipaatua = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.chbCopia = new System.Windows.Forms.CheckBox();
            this.imgEquip = new System.Windows.Forms.PictureBox();
            this.pnlEditor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo .cfg";
            // 
            // txtCaminhao
            // 
            this.txtCaminhao.Location = new System.Drawing.Point(77, 7);
            this.txtCaminhao.Name = "txtCaminhao";
            this.txtCaminhao.ReadOnly = true;
            this.txtCaminhao.Size = new System.Drawing.Size(277, 20);
            this.txtCaminhao.TabIndex = 1;
            // 
            // pnlEditor
            // 
            this.pnlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditor.Controls.Add(this.imgEquip);
            this.pnlEditor.Controls.Add(this.btnRemove);
            this.pnlEditor.Controls.Add(this.btnAdd);
            this.pnlEditor.Controls.Add(this.listEquipaatua);
            this.pnlEditor.Controls.Add(this.listEquipamentos);
            this.pnlEditor.Controls.Add(this.label3);
            this.pnlEditor.Controls.Add(this.txtNome);
            this.pnlEditor.Controls.Add(this.label2);
            this.pnlEditor.Controls.Add(this.panel1);
            this.pnlEditor.Controls.Add(this.txtArquivoLido);
            this.pnlEditor.Controls.Add(this.groupBox1);
            this.pnlEditor.Location = new System.Drawing.Point(15, 32);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(852, 473);
            this.pnlEditor.TabIndex = 2;
            // 
            // btnPorcurar
            // 
            this.btnPorcurar.Location = new System.Drawing.Point(360, 5);
            this.btnPorcurar.Name = "btnPorcurar";
            this.btnPorcurar.Size = new System.Drawing.Size(75, 23);
            this.btnPorcurar.TabIndex = 3;
            this.btnPorcurar.Text = "Procurar";
            this.btnPorcurar.UseVisualStyleBackColor = true;
            this.btnPorcurar.Click += new System.EventHandler(this.btnPorcurar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTecla);
            this.groupBox1.Controls.Add(this.rbtOutra);
            this.groupBox1.Controls.Add(this.rbtF12);
            this.groupBox1.Controls.Add(this.rbtF11);
            this.groupBox1.Controls.Add(this.rbtF9);
            this.groupBox1.Controls.Add(this.rbtF8);
            this.groupBox1.Controls.Add(this.rbtF7);
            this.groupBox1.Controls.Add(this.rbtF6);
            this.groupBox1.Controls.Add(this.rbtF4);
            this.groupBox1.Controls.Add(this.rbtF3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teclas";
            // 
            // rbtF3
            // 
            this.rbtF3.AutoSize = true;
            this.rbtF3.Location = new System.Drawing.Point(6, 19);
            this.rbtF3.Name = "rbtF3";
            this.rbtF3.Size = new System.Drawing.Size(37, 17);
            this.rbtF3.TabIndex = 0;
            this.rbtF3.TabStop = true;
            this.rbtF3.Text = "F3";
            this.rbtF3.UseVisualStyleBackColor = true;
            this.rbtF3.CheckedChanged += new System.EventHandler(this.rbtF3_CheckedChanged);
            // 
            // rbtF4
            // 
            this.rbtF4.AutoSize = true;
            this.rbtF4.Location = new System.Drawing.Point(6, 42);
            this.rbtF4.Name = "rbtF4";
            this.rbtF4.Size = new System.Drawing.Size(37, 17);
            this.rbtF4.TabIndex = 1;
            this.rbtF4.TabStop = true;
            this.rbtF4.Text = "F4";
            this.rbtF4.UseVisualStyleBackColor = true;
            this.rbtF4.CheckedChanged += new System.EventHandler(this.rbtF4_CheckedChanged);
            // 
            // rbtF6
            // 
            this.rbtF6.AutoSize = true;
            this.rbtF6.Location = new System.Drawing.Point(6, 65);
            this.rbtF6.Name = "rbtF6";
            this.rbtF6.Size = new System.Drawing.Size(37, 17);
            this.rbtF6.TabIndex = 2;
            this.rbtF6.TabStop = true;
            this.rbtF6.Text = "F6";
            this.rbtF6.UseVisualStyleBackColor = true;
            this.rbtF6.CheckedChanged += new System.EventHandler(this.rbtF6_CheckedChanged);
            // 
            // rbtF7
            // 
            this.rbtF7.AutoSize = true;
            this.rbtF7.Location = new System.Drawing.Point(6, 88);
            this.rbtF7.Name = "rbtF7";
            this.rbtF7.Size = new System.Drawing.Size(37, 17);
            this.rbtF7.TabIndex = 3;
            this.rbtF7.TabStop = true;
            this.rbtF7.Text = "F7";
            this.rbtF7.UseVisualStyleBackColor = true;
            this.rbtF7.CheckedChanged += new System.EventHandler(this.rbtF7_CheckedChanged);
            // 
            // rbtF8
            // 
            this.rbtF8.AutoSize = true;
            this.rbtF8.Location = new System.Drawing.Point(6, 111);
            this.rbtF8.Name = "rbtF8";
            this.rbtF8.Size = new System.Drawing.Size(37, 17);
            this.rbtF8.TabIndex = 4;
            this.rbtF8.TabStop = true;
            this.rbtF8.Text = "F8";
            this.rbtF8.UseVisualStyleBackColor = true;
            this.rbtF8.CheckedChanged += new System.EventHandler(this.rbtF8_CheckedChanged);
            // 
            // rbtF9
            // 
            this.rbtF9.AutoSize = true;
            this.rbtF9.Location = new System.Drawing.Point(6, 134);
            this.rbtF9.Name = "rbtF9";
            this.rbtF9.Size = new System.Drawing.Size(37, 17);
            this.rbtF9.TabIndex = 5;
            this.rbtF9.TabStop = true;
            this.rbtF9.Text = "F9";
            this.rbtF9.UseVisualStyleBackColor = true;
            this.rbtF9.CheckedChanged += new System.EventHandler(this.rbtF9_CheckedChanged);
            // 
            // rbtF11
            // 
            this.rbtF11.AutoSize = true;
            this.rbtF11.Location = new System.Drawing.Point(6, 157);
            this.rbtF11.Name = "rbtF11";
            this.rbtF11.Size = new System.Drawing.Size(43, 17);
            this.rbtF11.TabIndex = 6;
            this.rbtF11.TabStop = true;
            this.rbtF11.Text = "F11";
            this.rbtF11.UseVisualStyleBackColor = true;
            this.rbtF11.CheckedChanged += new System.EventHandler(this.rbtF11_CheckedChanged);
            // 
            // rbtF12
            // 
            this.rbtF12.AutoSize = true;
            this.rbtF12.Location = new System.Drawing.Point(6, 180);
            this.rbtF12.Name = "rbtF12";
            this.rbtF12.Size = new System.Drawing.Size(43, 17);
            this.rbtF12.TabIndex = 1;
            this.rbtF12.TabStop = true;
            this.rbtF12.Text = "F12";
            this.rbtF12.UseVisualStyleBackColor = true;
            this.rbtF12.CheckedChanged += new System.EventHandler(this.rbtF12_CheckedChanged);
            // 
            // rbtOutra
            // 
            this.rbtOutra.AutoSize = true;
            this.rbtOutra.Location = new System.Drawing.Point(6, 203);
            this.rbtOutra.Name = "rbtOutra";
            this.rbtOutra.Size = new System.Drawing.Size(51, 17);
            this.rbtOutra.TabIndex = 7;
            this.rbtOutra.TabStop = true;
            this.rbtOutra.Text = "Outra";
            this.rbtOutra.UseVisualStyleBackColor = true;
            this.rbtOutra.CheckedChanged += new System.EventHandler(this.rbtOutra_CheckedChanged);
            // 
            // txtTecla
            // 
            this.txtTecla.Location = new System.Drawing.Point(63, 203);
            this.txtTecla.Name = "txtTecla";
            this.txtTecla.Size = new System.Drawing.Size(45, 20);
            this.txtTecla.TabIndex = 8;
            this.txtTecla.TextChanged += new System.EventHandler(this.txtTecla_TextChanged);
            // 
            // txtArquivoLido
            // 
            this.txtArquivoLido.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtArquivoLido.Location = new System.Drawing.Point(115, 0);
            this.txtArquivoLido.Name = "txtArquivoLido";
            this.txtArquivoLido.ReadOnly = true;
            this.txtArquivoLido.Size = new System.Drawing.Size(288, 473);
            this.txtArquivoLido.TabIndex = 1;
            this.txtArquivoLido.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbCopia);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(403, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 37);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(450, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(391, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Equipamentos";
            // 
            // listEquipamentos
            // 
            this.listEquipamentos.FormattingEnabled = true;
            this.listEquipamentos.Location = new System.Drawing.Point(412, 65);
            this.listEquipamentos.Name = "listEquipamentos";
            this.listEquipamentos.Size = new System.Drawing.Size(164, 355);
            this.listEquipamentos.TabIndex = 6;
            this.listEquipamentos.SelectedIndexChanged += new System.EventHandler(this.listEquipamentos_SelectedIndexChanged);
            // 
            // listEquipaatua
            // 
            this.listEquipaatua.FormattingEnabled = true;
            this.listEquipaatua.Location = new System.Drawing.Point(677, 65);
            this.listEquipaatua.Name = "listEquipaatua";
            this.listEquipaatua.Size = new System.Drawing.Size(164, 355);
            this.listEquipaatua.TabIndex = 7;
            this.listEquipaatua.SelectedIndexChanged += new System.EventHandler(this.listEquipaatua_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(589, 180);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(589, 209);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(363, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // chbCopia
            // 
            this.chbCopia.AutoSize = true;
            this.chbCopia.Checked = true;
            this.chbCopia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbCopia.Location = new System.Drawing.Point(183, 7);
            this.chbCopia.Name = "chbCopia";
            this.chbCopia.Size = new System.Drawing.Size(174, 17);
            this.chbCopia.TabIndex = 5;
            this.chbCopia.Text = "Criar Cópia das Configurações?";
            this.chbCopia.UseVisualStyleBackColor = true;
            // 
            // imgEquip
            // 
            this.imgEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEquip.Location = new System.Drawing.Point(586, 65);
            this.imgEquip.Name = "imgEquip";
            this.imgEquip.Size = new System.Drawing.Size(85, 109);
            this.imgEquip.TabIndex = 10;
            this.imgEquip.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 517);
            this.Controls.Add(this.btnPorcurar);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.txtCaminhao);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C.S 1.6 Auto Buy Config v1.0.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhao;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Button btnPorcurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtOutra;
        private System.Windows.Forms.RadioButton rbtF12;
        private System.Windows.Forms.RadioButton rbtF11;
        private System.Windows.Forms.RadioButton rbtF9;
        private System.Windows.Forms.RadioButton rbtF8;
        private System.Windows.Forms.RadioButton rbtF7;
        private System.Windows.Forms.RadioButton rbtF6;
        private System.Windows.Forms.RadioButton rbtF4;
        private System.Windows.Forms.RadioButton rbtF3;
        private System.Windows.Forms.TextBox txtTecla;
        private System.Windows.Forms.RichTextBox txtArquivoLido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listEquipaatua;
        private System.Windows.Forms.ListBox listEquipamentos;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.CheckBox chbCopia;
        private System.Windows.Forms.PictureBox imgEquip;
    }
}

