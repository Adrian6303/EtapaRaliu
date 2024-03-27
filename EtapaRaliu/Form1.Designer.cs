namespace EtapaRaliu
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
            RefreshButton = new Button();
            MasinaGridView = new DataGridView();
            CategorieGridView = new DataGridView();
            labelMasini = new Label();
            labelCategori = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            CapacitateMotorLabel = new Label();
            MarcaLabel = new Label();
            ModelLabel = new Label();
            AddButton = new Button();
            UpdateButton = new Button();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MasinaGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CategorieGridView).BeginInit();
            SuspendLayout();
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(53, 547);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 0;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MasinaGridView
            // 
            MasinaGridView.BackgroundColor = SystemColors.ActiveCaption;
            MasinaGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MasinaGridView.Location = new Point(342, 82);
            MasinaGridView.Name = "MasinaGridView";
            MasinaGridView.RowHeadersWidth = 51;
            MasinaGridView.RowTemplate.Height = 29;
            MasinaGridView.Size = new Size(685, 280);
            MasinaGridView.TabIndex = 1;
            MasinaGridView.RowHeaderMouseClick += MasinaGridView_RowHeaderMouseClick;
            // 
            // CategorieGridView
            // 
            CategorieGridView.BackgroundColor = SystemColors.ActiveCaption;
            CategorieGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategorieGridView.Location = new Point(12, 82);
            CategorieGridView.Name = "CategorieGridView";
            CategorieGridView.RowHeadersWidth = 51;
            CategorieGridView.RowTemplate.Height = 29;
            CategorieGridView.Size = new Size(324, 280);
            CategorieGridView.TabIndex = 2;
            CategorieGridView.RowHeaderMouseClick += CategorieGridView_RowHeaderMouseClick;
            // 
            // labelMasini
            // 
            labelMasini.AutoSize = true;
            labelMasini.Location = new Point(686, 40);
            labelMasini.Name = "labelMasini";
            labelMasini.Size = new Size(52, 20);
            labelMasini.TabIndex = 3;
            labelMasini.Text = "Masini";
            // 
            // labelCategori
            // 
            labelCategori.AutoSize = true;
            labelCategori.Location = new Point(172, 40);
            labelCategori.Name = "labelCategori";
            labelCategori.Size = new Size(66, 20);
            labelCategori.TabIndex = 4;
            labelCategori.Text = "Categori";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(811, 412);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(811, 456);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(811, 502);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // CapacitateMotorLabel
            // 
            CapacitateMotorLabel.AutoSize = true;
            CapacitateMotorLabel.Location = new Point(680, 415);
            CapacitateMotorLabel.Name = "CapacitateMotorLabel";
            CapacitateMotorLabel.Size = new Size(125, 20);
            CapacitateMotorLabel.TabIndex = 8;
            CapacitateMotorLabel.Text = "Capacitate Motor";
            // 
            // MarcaLabel
            // 
            MarcaLabel.AccessibleName = "";
            MarcaLabel.AutoSize = true;
            MarcaLabel.Location = new Point(722, 459);
            MarcaLabel.Name = "MarcaLabel";
            MarcaLabel.Size = new Size(50, 20);
            MarcaLabel.TabIndex = 9;
            MarcaLabel.Text = "Marca";
            // 
            // ModelLabel
            // 
            ModelLabel.AccessibleName = "";
            ModelLabel.AutoSize = true;
            ModelLabel.Location = new Point(730, 504);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(52, 20);
            ModelLabel.TabIndex = 10;
            ModelLabel.Text = "Model";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(680, 558);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 11;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(794, 558);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(94, 29);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(914, 558);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 599);
            Controls.Add(DeleteButton);
            Controls.Add(UpdateButton);
            Controls.Add(AddButton);
            Controls.Add(ModelLabel);
            Controls.Add(MarcaLabel);
            Controls.Add(CapacitateMotorLabel);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelCategori);
            Controls.Add(labelMasini);
            Controls.Add(CategorieGridView);
            Controls.Add(MasinaGridView);
            Controls.Add(RefreshButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MasinaGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CategorieGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RefreshButton;
        private DataGridView MasinaGridView;
        private DataGridView CategorieGridView;
        private Label labelMasini;
        private Label labelCategori;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label CapacitateMotorLabel;
        private Label MarcaLabel;
        private Label ModelLabel;
        private Button AddButton;
        private Button UpdateButton;
        private Button DeleteButton;
    }
}