namespace MarilinGEjercicio4
{
    partial class PersonasForm
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
            Lista = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            EliminarBoton = new Button();
            EditarBoton = new Button();
            NuevoBoton = new Button();
            EdicionGroup = new GroupBox();
            NumeroText = new TextBox();
            label7 = new Label();
            CodAreaText = new TextBox();
            label6 = new Label();
            CodPais = new TextBox();
            label2 = new Label();
            TipoCombo = new ComboBox();
            label5 = new Label();
            ApellidoText = new TextBox();
            label4 = new Label();
            NombreText = new TextBox();
            label3 = new Label();
            DocumentoText = new TextBox();
            label1 = new Label();
            AceptarBoton = new Button();
            CancelarBoton = new Button();
            EdicionGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Lista
            // 
            Lista.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            Lista.Location = new Point(23, 31);
            Lista.MultiSelect = false;
            Lista.Name = "Lista";
            Lista.Size = new Size(718, 121);
            Lista.TabIndex = 0;
            Lista.UseCompatibleStateImageBehavior = false;
            Lista.View = View.Details;
            // 
            // DocumentoCol
            // 
            DocumentoCol.Text = "Documento";
            DocumentoCol.Width = 90;
            // 
            // NombreCol
            // 
            NombreCol.Text = "Nombre";
            NombreCol.Width = 180;
            // 
            // ApellidoCol
            // 
            ApellidoCol.Text = "Apellido";
            ApellidoCol.Width = 180;
            // 
            // TelefonoCol
            // 
            TelefonoCol.Text = "Telefono";
            TelefonoCol.Width = 180;
            // 
            // EliminarBoton
            // 
            EliminarBoton.Location = new Point(646, 158);
            EliminarBoton.Name = "EliminarBoton";
            EliminarBoton.Size = new Size(94, 29);
            EliminarBoton.TabIndex = 1;
            EliminarBoton.Text = "Eliminar";
            EliminarBoton.UseVisualStyleBackColor = true;
            EliminarBoton.Click += EliminarBoton_Click;
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(546, 158);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(94, 29);
            EditarBoton.TabIndex = 2;
            EditarBoton.Text = "Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            EditarBoton.Click += EditarBoton_Click;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(446, 158);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(94, 29);
            NuevoBoton.TabIndex = 3;
            NuevoBoton.Text = "Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            NuevoBoton.Click += NuevoBoton_Click;
            // 
            // EdicionGroup
            // 
            EdicionGroup.Controls.Add(NumeroText);
            EdicionGroup.Controls.Add(label7);
            EdicionGroup.Controls.Add(CodAreaText);
            EdicionGroup.Controls.Add(label6);
            EdicionGroup.Controls.Add(CodPais);
            EdicionGroup.Controls.Add(label2);
            EdicionGroup.Controls.Add(TipoCombo);
            EdicionGroup.Controls.Add(label5);
            EdicionGroup.Controls.Add(ApellidoText);
            EdicionGroup.Controls.Add(label4);
            EdicionGroup.Controls.Add(NombreText);
            EdicionGroup.Controls.Add(label3);
            EdicionGroup.Controls.Add(DocumentoText);
            EdicionGroup.Controls.Add(label1);
            EdicionGroup.Location = new Point(23, 206);
            EdicionGroup.Name = "EdicionGroup";
            EdicionGroup.Size = new Size(717, 193);
            EdicionGroup.TabIndex = 4;
            EdicionGroup.TabStop = false;
            EdicionGroup.Text = "EdicionGroup";
            // 
            // NumeroText
            // 
            NumeroText.Location = new Point(482, 126);
            NumeroText.Name = "NumeroText";
            NumeroText.Size = new Size(125, 27);
            NumeroText.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(482, 103);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 13;
            label7.Text = "Numero";
            // 
            // CodAreaText
            // 
            CodAreaText.Location = new Point(340, 125);
            CodAreaText.Name = "CodAreaText";
            CodAreaText.Size = new Size(125, 27);
            CodAreaText.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 101);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 11;
            label6.Text = "Codigo Area";
            // 
            // CodPais
            // 
            CodPais.Location = new Point(194, 126);
            CodPais.Name = "CodPais";
            CodPais.Size = new Size(125, 27);
            CodPais.TabIndex = 10;
            CodPais.TextChanged += CodPais_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 102);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 9;
            label2.Text = "Codigo Pais";
            // 
            // TipoCombo
            // 
            TipoCombo.FormattingEnabled = true;
            TipoCombo.Location = new Point(24, 125);
            TipoCombo.Name = "TipoCombo";
            TipoCombo.Size = new Size(151, 28);
            TipoCombo.TabIndex = 8;
            TipoCombo.SelectedIndexChanged += TipoCombo_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 102);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 7;
            label5.Text = "Tipo";
            // 
            // ApellidoText
            // 
            ApellidoText.Location = new Point(319, 56);
            ApellidoText.Name = "ApellidoText";
            ApellidoText.Size = new Size(125, 27);
            ApellidoText.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 31);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 5;
            label4.Text = "Apellido";
            // 
            // NombreText
            // 
            NombreText.Location = new Point(170, 56);
            NombreText.Name = "NombreText";
            NombreText.Size = new Size(125, 27);
            NombreText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 31);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // DocumentoText
            // 
            DocumentoText.Location = new Point(24, 56);
            DocumentoText.Name = "DocumentoText";
            DocumentoText.Size = new Size(125, 27);
            DocumentoText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Documento";
            // 
            // AceptarBoton
            // 
            AceptarBoton.Location = new Point(546, 444);
            AceptarBoton.Name = "AceptarBoton";
            AceptarBoton.Size = new Size(94, 29);
            AceptarBoton.TabIndex = 6;
            AceptarBoton.Text = "Aceptar";
            AceptarBoton.UseVisualStyleBackColor = true;
            AceptarBoton.Click += AceptarBoton_Click;
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(646, 444);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 29);
            CancelarBoton.TabIndex = 5;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += CancelarBoton_Click;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(AceptarBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(EdicionGroup);
            Controls.Add(NuevoBoton);
            Controls.Add(EditarBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(Lista);
            Name = "PersonasForm";
            Text = "-";
            Load += Form1_Load;
            EdicionGroup.ResumeLayout(false);
            EdicionGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView Lista;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
        private Button EliminarBoton;
        private Button EditarBoton;
        private Button NuevoBoton;
        private GroupBox EdicionGroup;
        private Label label1;
        private TextBox NumeroText;
        private Label label7;
        private TextBox CodAreaText;
        private Label label6;
        private TextBox CodPais;
        private Label label2;
        private ComboBox TipoCombo;
        private Label label5;
        private TextBox ApellidoText;
        private Label label4;
        private TextBox NombreText;
        private Label label3;
        private TextBox DocumentoText;
        private Button AceptarBoton;
        private Button CancelarBoton;
    }
}
