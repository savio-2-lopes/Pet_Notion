namespace Pet_Care___Login.AllUserControls
{
    partial class UC_AddPets
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddPets));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRaca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVacina = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPeso = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioNao = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSim = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton9 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(40, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Vermifugação ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtData
            // 
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.DefaultText = "";
            this.txtData.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtData.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtData.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.DisabledState.Parent = this.txtData;
            this.txtData.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtData.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.FocusedState.Parent = this.txtData;
            this.txtData.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtData.ForeColor = System.Drawing.Color.Black;
            this.txtData.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtData.HoverState.Parent = this.txtData;
            this.txtData.Location = new System.Drawing.Point(44, 347);
            this.txtData.Margin = new System.Windows.Forms.Padding(4);
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.PlaceholderText = "Data de Vermifugação";
            this.txtData.SelectedText = "";
            this.txtData.ShadowDecoration.Parent = this.txtData;
            this.txtData.Size = new System.Drawing.Size(290, 36);
            this.txtData.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtData.TabIndex = 6;
            // 
            // txtRaca
            // 
            this.txtRaca.BackColor = System.Drawing.Color.Transparent;
            this.txtRaca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtRaca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtRaca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaca.FocusedState.Parent = this.txtRaca;
            this.txtRaca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.ForeColor = System.Drawing.Color.Black;
            this.txtRaca.HoverState.Parent = this.txtRaca;
            this.txtRaca.ItemHeight = 30;
            this.txtRaca.Items.AddRange(new object[] {
            "Animal 1",
            "Animal 2",
            "Animal 3",
            "Animal 4",
            "Animal 5",
            "Animal 6",
            "Animal 7",
            "Animal 8",
            "Animal 9",
            "Animal 10"});
            this.txtRaca.ItemsAppearance.Parent = this.txtRaca;
            this.txtRaca.Location = new System.Drawing.Point(44, 237);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.ShadowDecoration.Parent = this.txtRaca;
            this.txtRaca.Size = new System.Drawing.Size(289, 36);
            this.txtRaca.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRaca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raça";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtVacina
            // 
            this.txtVacina.BackColor = System.Drawing.Color.Transparent;
            this.txtVacina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtVacina.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtVacina.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVacina.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVacina.FocusedState.Parent = this.txtVacina;
            this.txtVacina.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVacina.ForeColor = System.Drawing.Color.Black;
            this.txtVacina.HoverState.Parent = this.txtVacina;
            this.txtVacina.ItemHeight = 30;
            this.txtVacina.Items.AddRange(new object[] {
            "Vacina 1",
            "Vacina 2",
            "Vacina 3",
            "Vacina 4",
            "Vacina 5",
            "Vacina 6",
            "Vacina 7",
            "Vacina 8",
            "Vacina 9",
            "Vacina 10"});
            this.txtVacina.ItemsAppearance.Parent = this.txtVacina;
            this.txtVacina.Location = new System.Drawing.Point(434, 62);
            this.txtVacina.Name = "txtVacina";
            this.txtVacina.ShadowDecoration.Parent = this.txtVacina;
            this.txtVacina.Size = new System.Drawing.Size(291, 36);
            this.txtVacina.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtVacina.TabIndex = 11;
            this.txtVacina.SelectedIndexChanged += new System.EventHandler(this.txtVacina_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(431, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vacinas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeso.DefaultText = "";
            this.txtPeso.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPeso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPeso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeso.DisabledState.Parent = this.txtPeso;
            this.txtPeso.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtPeso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeso.FocusedState.Parent = this.txtPeso;
            this.txtPeso.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPeso.ForeColor = System.Drawing.Color.Black;
            this.txtPeso.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeso.HoverState.Parent = this.txtPeso;
            this.txtPeso.Location = new System.Drawing.Point(434, 156);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.PlaceholderText = "Peso";
            this.txtPeso.SelectedText = "";
            this.txtPeso.ShadowDecoration.Parent = this.txtPeso;
            this.txtPeso.Size = new System.Drawing.Size(132, 36);
            this.txtPeso.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPeso.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(431, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Peso";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.Parent = this.txtQuantidade;
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.FocusedState.Parent = this.txtQuantidade;
            this.txtQuantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.HoverState.Parent = this.txtQuantidade;
            this.txtQuantidade.Location = new System.Drawing.Point(434, 249);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderText = "Quantidade de refeições";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.ShadowDecoration.Parent = this.txtQuantidade;
            this.txtQuantidade.Size = new System.Drawing.Size(291, 36);
            this.txtQuantidade.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtQuantidade.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(431, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantidade de refeições ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // radioNao
            // 
            this.radioNao.AutoSize = true;
            this.radioNao.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioNao.CheckedState.BorderThickness = 0;
            this.radioNao.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioNao.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioNao.CheckedState.InnerOffset = -4;
            this.radioNao.Location = new System.Drawing.Point(533, 366);
            this.radioNao.Name = "radioNao";
            this.radioNao.Size = new System.Drawing.Size(45, 17);
            this.radioNao.TabIndex = 20;
            this.radioNao.Text = "Não";
            this.radioNao.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioNao.UncheckedState.BorderThickness = 2;
            this.radioNao.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioNao.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioSim
            // 
            this.radioSim.AutoSize = true;
            this.radioSim.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSim.CheckedState.BorderThickness = 0;
            this.radioSim.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSim.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioSim.CheckedState.InnerOffset = -4;
            this.radioSim.Location = new System.Drawing.Point(454, 366);
            this.radioSim.Name = "radioSim";
            this.radioSim.Size = new System.Drawing.Size(42, 17);
            this.radioSim.TabIndex = 19;
            this.radioSim.Text = "Sim";
            this.radioSim.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioSim.UncheckedState.BorderThickness = 2;
            this.radioSim.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioSim.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(443, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Receber Notificações?";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.Parent = this.txtNome;
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedState.Parent = this.txtNome;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.HoverState.Parent = this.txtNome;
            this.txtNome.Location = new System.Drawing.Point(42, 62);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.SelectedText = "";
            this.txtNome.ShadowDecoration.Parent = this.txtNome;
            this.txtNome.Size = new System.Drawing.Size(291, 36);
            this.txtNome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNome.TabIndex = 22;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(40, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Nome do Pet";
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.Color.Transparent;
            this.txtSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtSexo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.txtSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSexo.FocusedState.Parent = this.txtSexo;
            this.txtSexo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSexo.ForeColor = System.Drawing.Color.Black;
            this.txtSexo.HoverState.Parent = this.txtSexo;
            this.txtSexo.ItemHeight = 30;
            this.txtSexo.Items.AddRange(new object[] {
            "Fêmea",
            "Macho"});
            this.txtSexo.ItemsAppearance.Parent = this.txtSexo;
            this.txtSexo.Location = new System.Drawing.Point(42, 156);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ShadowDecoration.Parent = this.txtSexo;
            this.txtSexo.Size = new System.Drawing.Size(163, 36);
            this.txtSexo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSexo.TabIndex = 23;
            // 
            // guna2ImageButton9
            // 
            this.guna2ImageButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2ImageButton9.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton9.CheckedState.Parent = this.guna2ImageButton9;
            this.guna2ImageButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton9.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton9.HoverState.Parent = this.guna2ImageButton9;
            this.guna2ImageButton9.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton9.Image")));
            this.guna2ImageButton9.ImageRotate = 0F;
            this.guna2ImageButton9.ImageSize = new System.Drawing.Size(54, 54);
            this.guna2ImageButton9.Location = new System.Drawing.Point(626, 326);
            this.guna2ImageButton9.Name = "guna2ImageButton9";
            this.guna2ImageButton9.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.guna2ImageButton9.PressedState.Parent = this.guna2ImageButton9;
            this.guna2ImageButton9.Size = new System.Drawing.Size(99, 57);
            this.guna2ImageButton9.TabIndex = 82;
            this.guna2ImageButton9.Click += new System.EventHandler(this.guna2ImageButton9_Click);
            // 
            // UC_AddPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.guna2ImageButton9);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.radioNao);
            this.Controls.Add(this.radioSim);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVacina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "UC_AddPets";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_AddPets_Load);
            this.Leave += new System.EventHandler(this.UC_AddPets_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtData;
        private Guna.UI2.WinForms.Guna2ComboBox txtRaca;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox txtVacina;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtPeso;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2RadioButton radioNao;
        private Guna.UI2.WinForms.Guna2RadioButton radioSim;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox txtSexo;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton9;
    }
}
