namespace AssistenciaTec.View
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            GroupBoxDadosCliente = new GroupBox();
            TxtEndereco = new TextBox();
            label5 = new Label();
            TxtTelefone = new TextBox();
            label4 = new Label();
            TxtEmail = new TextBox();
            label3 = new Label();
            TxtNome = new TextBox();
            label2 = new Label();
            LabelId = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            toolStrip1 = new ToolStrip();
            toolStripButtonNovo = new ToolStripButton();
            toolStripButtonEditar = new ToolStripButton();
            toolStripButtonExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonCancelar = new ToolStripButton();
            toolStripButtonSalvar = new ToolStripButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            GroupBoxDadosCliente.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxDadosCliente
            // 
            GroupBoxDadosCliente.Controls.Add(TxtEndereco);
            GroupBoxDadosCliente.Controls.Add(label5);
            GroupBoxDadosCliente.Controls.Add(TxtTelefone);
            GroupBoxDadosCliente.Controls.Add(label4);
            GroupBoxDadosCliente.Controls.Add(TxtEmail);
            GroupBoxDadosCliente.Controls.Add(label3);
            GroupBoxDadosCliente.Controls.Add(TxtNome);
            GroupBoxDadosCliente.Controls.Add(label2);
            GroupBoxDadosCliente.Controls.Add(LabelId);
            GroupBoxDadosCliente.Controls.Add(label1);
            GroupBoxDadosCliente.Enabled = false;
            GroupBoxDadosCliente.Location = new Point(12, 55);
            GroupBoxDadosCliente.Name = "GroupBoxDadosCliente";
            GroupBoxDadosCliente.Size = new Size(244, 437);
            GroupBoxDadosCliente.TabIndex = 0;
            GroupBoxDadosCliente.TabStop = false;
            GroupBoxDadosCliente.Text = "Dados do Cliente:";
            // 
            // TxtEndereco
            // 
            TxtEndereco.Location = new Point(11, 301);
            TxtEndereco.Multiline = true;
            TxtEndereco.Name = "TxtEndereco";
            TxtEndereco.Size = new Size(221, 118);
            TxtEndereco.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 278);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 8;
            label5.Text = "Endereço do Cliente:";
            // 
            // TxtTelefone
            // 
            TxtTelefone.Location = new Point(11, 235);
            TxtTelefone.Name = "TxtTelefone";
            TxtTelefone.Size = new Size(155, 26);
            TxtTelefone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 212);
            label4.Name = "label4";
            label4.Size = new Size(155, 20);
            label4.TabIndex = 6;
            label4.Text = "Telefone do Cliente:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(11, 168);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(221, 26);
            TxtEmail.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 145);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 4;
            label3.Text = "E-mail do Cliente:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(11, 103);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(221, 26);
            TxtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 80);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome do Cliente:";
            // 
            // LabelId
            // 
            LabelId.BackColor = Color.FromArgb(34, 36, 48);
            LabelId.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelId.ForeColor = Color.White;
            LabelId.Location = new Point(119, 42);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(46, 22);
            LabelId.TabIndex = 1;
            LabelId.Text = "123";
            LabelId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 44);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "ID do Cliente:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(262, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 437);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Clientes Cadastrados:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(589, 316);
            dataGridView1.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Left;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 50);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = Properties.Resources.search;
            btnBuscar.Location = new Point(322, 52);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(45, 44);
            btnBuscar.TabIndex = 2;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 26);
            textBox1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 39);
            label6.Name = "label6";
            label6.Size = new Size(201, 20);
            label6.TabIndex = 0;
            label6.Text = "Buscar Clientes por Nome:";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(30, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonNovo, toolStripButtonEditar, toolStripButtonExcluir, toolStripSeparator1, toolStripButtonCancelar, toolStripButtonSalvar });
            toolStrip1.Location = new Point(0, 499);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(892, 43);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonNovo
            // 
            toolStripButtonNovo.AutoSize = false;
            toolStripButtonNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonNovo.Image = Properties.Resources.add;
            toolStripButtonNovo.ImageTransparentColor = Color.Magenta;
            toolStripButtonNovo.Name = "toolStripButtonNovo";
            toolStripButtonNovo.Size = new Size(40, 40);
            toolStripButtonNovo.Text = "Cadastrar Novo Cliente";
            toolStripButtonNovo.Click += toolStripButtonNovo_Click;
            // 
            // toolStripButtonEditar
            // 
            toolStripButtonEditar.AutoSize = false;
            toolStripButtonEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditar.Image = Properties.Resources.pen;
            toolStripButtonEditar.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditar.Name = "toolStripButtonEditar";
            toolStripButtonEditar.Size = new Size(40, 40);
            toolStripButtonEditar.Text = "Editar";
            toolStripButtonEditar.Click += toolStripButtonEditar_Click;
            // 
            // toolStripButtonExcluir
            // 
            toolStripButtonExcluir.AutoSize = false;
            toolStripButtonExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonExcluir.Image = Properties.Resources.delete;
            toolStripButtonExcluir.ImageTransparentColor = Color.Magenta;
            toolStripButtonExcluir.Name = "toolStripButtonExcluir";
            toolStripButtonExcluir.Size = new Size(40, 40);
            toolStripButtonExcluir.Text = "Excluir";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 43);
            // 
            // toolStripButtonCancelar
            // 
            toolStripButtonCancelar.AutoSize = false;
            toolStripButtonCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonCancelar.Image = Properties.Resources.cancel;
            toolStripButtonCancelar.ImageTransparentColor = Color.Magenta;
            toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            toolStripButtonCancelar.Size = new Size(40, 40);
            toolStripButtonCancelar.Text = "Cancelar";
            toolStripButtonCancelar.Click += toolStripButtonCancelar_Click;
            // 
            // toolStripButtonSalvar
            // 
            toolStripButtonSalvar.AutoSize = false;
            toolStripButtonSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonSalvar.Image = Properties.Resources.save;
            toolStripButtonSalvar.ImageTransparentColor = Color.Magenta;
            toolStripButtonSalvar.Name = "toolStripButtonSalvar";
            toolStripButtonSalvar.Size = new Size(40, 40);
            toolStripButtonSalvar.Text = "Salvar";
            toolStripButtonSalvar.Click += toolStripButtonSalvar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 44);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.Image = Properties.Resources.pessoas;
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(34, 36, 48);
            label7.Location = new Point(75, 8);
            label7.Name = "label7";
            label7.Size = new Size(224, 25);
            label7.TabIndex = 0;
            label7.Text = "Cadastro de Clientes";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 542);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Controls.Add(GroupBoxDadosCliente);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário Clientes";
            GroupBoxDadosCliente.ResumeLayout(false);
            GroupBoxDadosCliente.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxDadosCliente;
        private Label LabelId;
        private Label label1;
        private TextBox TxtEndereco;
        private Label label5;
        private TextBox TxtTelefone;
        private Label label4;
        private TextBox TxtEmail;
        private Label label3;
        private TextBox TxtNome;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label6;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonNovo;
        private ToolStripButton toolStripButtonEditar;
        private ToolStripButton toolStripButtonExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonCancelar;
        private ToolStripButton toolStripButtonSalvar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label7;
    }
}