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
            PersonasList = new ListView();
            DocumentoCol = new ColumnHeader();
            NombreCol = new ColumnHeader();
            ApellidoCol = new ColumnHeader();
            TelefonoCol = new ColumnHeader();
            EliminarBoton = new Button();
            EditarBoton = new Button();
            NuevoBoton = new Button();
            EdicionText = new GroupBox();
            NumeroText = new TextBox();
            label7 = new Label();
            PaisText = new TextBox();
            label6 = new Label();
            CodPaisText = new TextBox();
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
            EdicionText.SuspendLayout();
            SuspendLayout();
            // 
            // PersonasList
            // 
            PersonasList.Columns.AddRange(new ColumnHeader[] { DocumentoCol, NombreCol, ApellidoCol, TelefonoCol });
            PersonasList.Location = new Point(23, 31);
            PersonasList.Name = "PersonasList";
            PersonasList.Size = new Size(718, 121);
            PersonasList.TabIndex = 0;
            PersonasList.UseCompatibleStateImageBehavior = false;
            PersonasList.View = View.Details;
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
            // 
            // EditarBoton
            // 
            EditarBoton.Location = new Point(546, 158);
            EditarBoton.Name = "EditarBoton";
            EditarBoton.Size = new Size(94, 29);
            EditarBoton.TabIndex = 2;
            EditarBoton.Text = "Editar";
            EditarBoton.UseVisualStyleBackColor = true;
            EditarBoton.Click += this.EditarBoton_Click_3;
            // 
            // NuevoBoton
            // 
            NuevoBoton.Location = new Point(446, 158);
            NuevoBoton.Name = "NuevoBoton";
            NuevoBoton.Size = new Size(94, 29);
            NuevoBoton.TabIndex = 3;
            NuevoBoton.Text = "Nuevo";
            NuevoBoton.UseVisualStyleBackColor = true;
            // 
            // EdicionText
            // 
            EdicionText.Controls.Add(NumeroText);
            EdicionText.Controls.Add(label7);
            EdicionText.Controls.Add(PaisText);
            EdicionText.Controls.Add(label6);
            EdicionText.Controls.Add(CodPaisText);
            EdicionText.Controls.Add(label2);
            EdicionText.Controls.Add(TipoCombo);
            EdicionText.Controls.Add(label5);
            EdicionText.Controls.Add(ApellidoText);
            EdicionText.Controls.Add(label4);
            EdicionText.Controls.Add(NombreText);
            EdicionText.Controls.Add(label3);
            EdicionText.Controls.Add(DocumentoText);
            EdicionText.Controls.Add(label1);
            EdicionText.Location = new Point(23, 206);
            EdicionText.Name = "EdicionText";
            EdicionText.Size = new Size(717, 193);
            EdicionText.TabIndex = 4;
            EdicionText.TabStop = false;
            EdicionText.Text = "EdicionGroup";
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
            // PaisText
            // 
            PaisText.Location = new Point(340, 125);
            PaisText.Name = "PaisText";
            PaisText.Size = new Size(125, 27);
            PaisText.TabIndex = 12;
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
            // CodPaisText
            // 
            CodPaisText.Location = new Point(194, 126);
            CodPaisText.Name = "CodPaisText";
            CodPaisText.Size = new Size(125, 27);
            CodPaisText.TabIndex = 10;
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
            // 
            // CancelarBoton
            // 
            CancelarBoton.Location = new Point(646, 444);
            CancelarBoton.Name = "CancelarBoton";
            CancelarBoton.Size = new Size(94, 29);
            CancelarBoton.TabIndex = 5;
            CancelarBoton.Text = "Cancelar";
            CancelarBoton.UseVisualStyleBackColor = true;
            CancelarBoton.Click += this.CancelarBoton_Click_1;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(AceptarBoton);
            Controls.Add(CancelarBoton);
            Controls.Add(EdicionText);
            Controls.Add(NuevoBoton);
            Controls.Add(EditarBoton);
            Controls.Add(EliminarBoton);
            Controls.Add(PersonasList);
            Name = "PersonasForm";
            Text = "-";
            Load += Form1_Load;
            EdicionText.ResumeLayout(false);
            EdicionText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView PersonasList;
        private ColumnHeader DocumentoCol;
        private ColumnHeader NombreCol;
        private ColumnHeader ApellidoCol;
        private ColumnHeader TelefonoCol;
        private Button EliminarBoton;
        private Button EditarBoton;
        private Button NuevoBoton;
        private GroupBox EdicionText;
        private Label label1;
        private TextBox NumeroText;
        private Label label7;
        private TextBox PaisText;
        private Label label6;
        private TextBox CodPaisText;
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
