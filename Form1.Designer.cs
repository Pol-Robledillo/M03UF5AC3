namespace M03UF5AC3
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
            components = new System.ComponentModel.Container();
            insertDataGroup = new GroupBox();
            populationInput = new TextBox();
            totalInput = new TextBox();
            totalLabel = new Label();
            consDomInput = new TextBox();
            domConsLabel = new Label();
            ecoActivitiesInput = new TextBox();
            ecoActivitiesLabel = new Label();
            domNetInput = new TextBox();
            domNetLabel = new Label();
            townLabel = new Label();
            regionSelector = new ComboBox();
            regionLabel = new Label();
            yearSelector = new ComboBox();
            yearLabel = new Label();
            statsGroup = new GroupBox();
            lowestDomConsInfo = new Label();
            highestDomConsInfo = new Label();
            avgDomConsInfo = new Label();
            populationBiggerThanInfo = new Label();
            lowestDomConsLabel = new Label();
            populationBiggerThanLabel = new Label();
            avgDomConsLabel = new Label();
            highestDomConsLabel = new Label();
            saveButton = new Button();
            cleanSelectionButton = new Button();
            infoComarcas = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            insertDataGroup.SuspendLayout();
            statsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)infoComarcas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // insertDataGroup
            // 
            insertDataGroup.Controls.Add(populationInput);
            insertDataGroup.Controls.Add(totalInput);
            insertDataGroup.Controls.Add(totalLabel);
            insertDataGroup.Controls.Add(consDomInput);
            insertDataGroup.Controls.Add(domConsLabel);
            insertDataGroup.Controls.Add(ecoActivitiesInput);
            insertDataGroup.Controls.Add(ecoActivitiesLabel);
            insertDataGroup.Controls.Add(domNetInput);
            insertDataGroup.Controls.Add(domNetLabel);
            insertDataGroup.Controls.Add(townLabel);
            insertDataGroup.Controls.Add(regionSelector);
            insertDataGroup.Controls.Add(regionLabel);
            insertDataGroup.Controls.Add(yearSelector);
            insertDataGroup.Controls.Add(yearLabel);
            insertDataGroup.Location = new Point(12, 12);
            insertDataGroup.Name = "insertDataGroup";
            insertDataGroup.Size = new Size(598, 170);
            insertDataGroup.TabIndex = 0;
            insertDataGroup.TabStop = false;
            insertDataGroup.Text = "Gestió de Dades Demogràfiques de Regions";
            // 
            // populationInput
            // 
            populationInput.Location = new Point(305, 47);
            populationInput.Name = "populationInput";
            populationInput.Size = new Size(100, 23);
            populationInput.TabIndex = 14;
            // 
            // totalInput
            // 
            totalInput.Location = new Point(455, 120);
            totalInput.Name = "totalInput";
            totalInput.Size = new Size(124, 23);
            totalInput.TabIndex = 13;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            totalLabel.Location = new Point(455, 102);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(34, 15);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total";
            // 
            // consDomInput
            // 
            consDomInput.Location = new Point(305, 120);
            consDomInput.Name = "consDomInput";
            consDomInput.Size = new Size(124, 23);
            consDomInput.TabIndex = 11;
            // 
            // domConsLabel
            // 
            domConsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            domConsLabel.Location = new Point(305, 84);
            domConsLabel.Name = "domConsLabel";
            domConsLabel.Size = new Size(124, 33);
            domConsLabel.TabIndex = 10;
            domConsLabel.Text = "Consum Domèstic per Càpita";
            // 
            // ecoActivitiesInput
            // 
            ecoActivitiesInput.Location = new Point(154, 120);
            ecoActivitiesInput.Name = "ecoActivitiesInput";
            ecoActivitiesInput.Size = new Size(126, 23);
            ecoActivitiesInput.TabIndex = 9;
            // 
            // ecoActivitiesLabel
            // 
            ecoActivitiesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ecoActivitiesLabel.Location = new Point(152, 84);
            ecoActivitiesLabel.Name = "ecoActivitiesLabel";
            ecoActivitiesLabel.Size = new Size(147, 37);
            ecoActivitiesLabel.TabIndex = 8;
            ecoActivitiesLabel.Text = "Activitats Econòmiques i Fonts Pròpies";
            // 
            // domNetInput
            // 
            domNetInput.Location = new Point(15, 120);
            domNetInput.Name = "domNetInput";
            domNetInput.Size = new Size(115, 23);
            domNetInput.TabIndex = 7;
            // 
            // domNetLabel
            // 
            domNetLabel.AutoSize = true;
            domNetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            domNetLabel.Location = new Point(15, 102);
            domNetLabel.Name = "domNetLabel";
            domNetLabel.Size = new Size(95, 15);
            domNetLabel.TabIndex = 6;
            domNetLabel.Text = "Domèstic Xarxa";
            // 
            // townLabel
            // 
            townLabel.AutoSize = true;
            townLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            townLabel.Location = new Point(305, 29);
            townLabel.Name = "townLabel";
            townLabel.Size = new Size(53, 15);
            townLabel.TabIndex = 4;
            townLabel.Text = "Població";
            // 
            // regionSelector
            // 
            regionSelector.FormattingEnabled = true;
            regionSelector.Location = new Point(154, 47);
            regionSelector.Name = "regionSelector";
            regionSelector.Size = new Size(126, 23);
            regionSelector.TabIndex = 3;
            // 
            // regionLabel
            // 
            regionLabel.AutoSize = true;
            regionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            regionLabel.Location = new Point(154, 29);
            regionLabel.Name = "regionLabel";
            regionLabel.Size = new Size(55, 15);
            regionLabel.TabIndex = 2;
            regionLabel.Text = "Comarca";
            // 
            // yearSelector
            // 
            yearSelector.FormattingEnabled = true;
            yearSelector.Location = new Point(15, 47);
            yearSelector.Name = "yearSelector";
            yearSelector.Size = new Size(115, 23);
            yearSelector.TabIndex = 1;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            yearLabel.Location = new Point(15, 29);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(28, 15);
            yearLabel.TabIndex = 0;
            yearLabel.Text = "Any";
            // 
            // statsGroup
            // 
            statsGroup.Controls.Add(lowestDomConsInfo);
            statsGroup.Controls.Add(highestDomConsInfo);
            statsGroup.Controls.Add(avgDomConsInfo);
            statsGroup.Controls.Add(populationBiggerThanInfo);
            statsGroup.Controls.Add(lowestDomConsLabel);
            statsGroup.Controls.Add(populationBiggerThanLabel);
            statsGroup.Controls.Add(avgDomConsLabel);
            statsGroup.Controls.Add(highestDomConsLabel);
            statsGroup.Location = new Point(633, 12);
            statsGroup.Name = "statsGroup";
            statsGroup.Size = new Size(269, 170);
            statsGroup.TabIndex = 1;
            statsGroup.TabStop = false;
            statsGroup.Text = "Estadístiques";
            // 
            // lowestDomConsInfo
            // 
            lowestDomConsInfo.AutoSize = true;
            lowestDomConsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lowestDomConsInfo.ForeColor = Color.Blue;
            lowestDomConsInfo.Location = new Point(235, 133);
            lowestDomConsInfo.Name = "lowestDomConsInfo";
            lowestDomConsInfo.Size = new Size(12, 15);
            lowestDomConsInfo.TabIndex = 7;
            lowestDomConsInfo.Text = "?";
            lowestDomConsInfo.Visible = false;
            // 
            // highestDomConsInfo
            // 
            highestDomConsInfo.AutoSize = true;
            highestDomConsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            highestDomConsInfo.ForeColor = Color.Blue;
            highestDomConsInfo.Location = new Point(235, 97);
            highestDomConsInfo.Name = "highestDomConsInfo";
            highestDomConsInfo.Size = new Size(12, 15);
            highestDomConsInfo.TabIndex = 6;
            highestDomConsInfo.Text = "?";
            highestDomConsInfo.Visible = false;
            // 
            // avgDomConsInfo
            // 
            avgDomConsInfo.AutoSize = true;
            avgDomConsInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            avgDomConsInfo.ForeColor = Color.Blue;
            avgDomConsInfo.Location = new Point(162, 63);
            avgDomConsInfo.Name = "avgDomConsInfo";
            avgDomConsInfo.Size = new Size(12, 15);
            avgDomConsInfo.TabIndex = 5;
            avgDomConsInfo.Text = "?";
            avgDomConsInfo.Visible = false;
            // 
            // populationBiggerThanInfo
            // 
            populationBiggerThanInfo.AutoSize = true;
            populationBiggerThanInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            populationBiggerThanInfo.ForeColor = Color.Blue;
            populationBiggerThanInfo.Location = new Point(154, 29);
            populationBiggerThanInfo.Name = "populationBiggerThanInfo";
            populationBiggerThanInfo.Size = new Size(12, 15);
            populationBiggerThanInfo.TabIndex = 4;
            populationBiggerThanInfo.Text = "?";
            populationBiggerThanInfo.Visible = false;
            // 
            // lowestDomConsLabel
            // 
            lowestDomConsLabel.AutoSize = true;
            lowestDomConsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lowestDomConsLabel.Location = new Point(15, 133);
            lowestDomConsLabel.Name = "lowestDomConsLabel";
            lowestDomConsLabel.Size = new Size(214, 15);
            lowestDomConsLabel.TabIndex = 3;
            lowestDomConsLabel.Text = "Consum Domèstic per Càpita Més Alt:";
            // 
            // populationBiggerThanLabel
            // 
            populationBiggerThanLabel.AutoSize = true;
            populationBiggerThanLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            populationBiggerThanLabel.Location = new Point(15, 29);
            populationBiggerThanLabel.Name = "populationBiggerThanLabel";
            populationBiggerThanLabel.Size = new Size(133, 15);
            populationBiggerThanLabel.TabIndex = 0;
            populationBiggerThanLabel.Text = "Població > 20000 Hab.:";
            // 
            // avgDomConsLabel
            // 
            avgDomConsLabel.AutoSize = true;
            avgDomConsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            avgDomConsLabel.Location = new Point(15, 63);
            avgDomConsLabel.Name = "avgDomConsLabel";
            avgDomConsLabel.Size = new Size(141, 15);
            avgDomConsLabel.TabIndex = 1;
            avgDomConsLabel.Text = "Consum Domèstic Mitjà:";
            // 
            // highestDomConsLabel
            // 
            highestDomConsLabel.AutoSize = true;
            highestDomConsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            highestDomConsLabel.Location = new Point(15, 97);
            highestDomConsLabel.Name = "highestDomConsLabel";
            highestDomConsLabel.Size = new Size(214, 15);
            highestDomConsLabel.TabIndex = 2;
            highestDomConsLabel.Text = "Consum Domèstic per Càpita Més Alt:";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(535, 188);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cleanSelectionButton
            // 
            cleanSelectionButton.Location = new Point(454, 188);
            cleanSelectionButton.Name = "cleanSelectionButton";
            cleanSelectionButton.Size = new Size(75, 23);
            cleanSelectionButton.TabIndex = 3;
            cleanSelectionButton.Text = "Netejar";
            cleanSelectionButton.UseVisualStyleBackColor = true;
            cleanSelectionButton.Click += cleanSelectionButton_Click;
            // 
            // infoComarcas
            // 
            infoComarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            infoComarcas.Location = new Point(12, 249);
            infoComarcas.Name = "infoComarcas";
            infoComarcas.Size = new Size(890, 189);
            infoComarcas.TabIndex = 4;
            infoComarcas.CellContentClick += infoComarcas_CellContentClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(infoComarcas);
            Controls.Add(cleanSelectionButton);
            Controls.Add(saveButton);
            Controls.Add(statsGroup);
            Controls.Add(insertDataGroup);
            Name = "Form1";
            Text = "Gestió de Dades Demogràfiques de Regions";
            Load += Form1_Load;
            insertDataGroup.ResumeLayout(false);
            insertDataGroup.PerformLayout();
            statsGroup.ResumeLayout(false);
            statsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)infoComarcas).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox insertDataGroup;
        private Label yearLabel;
        private ComboBox yearSelector;
        private ComboBox townSelector;
        private Label townLabel;
        private ComboBox regionSelector;
        private Label regionLabel;
        private Label domNetLabel;
        private TextBox domNetInput;
        private Label ecoActivitiesLabel;
        private TextBox consDomInput;
        private Label domConsLabel;
        private TextBox ecoActivitiesInput;
        private TextBox totalInput;
        private Label totalLabel;
        private GroupBox statsGroup;
        private Label avgDomConsLabel;
        private Label populationBiggerThanLabel;
        private Label lowestDomConsLabel;
        private Label highestDomConsLabel;
        private Button saveButton;
        private Button cleanSelectionButton;
        private Label lowestDomConsInfo;
        private Label highestDomConsInfo;
        private Label avgDomConsInfo;
        private Label populationBiggerThanInfo;
        private DataGridView infoComarcas;
        private TextBox populationInput;
        private ErrorProvider errorProvider1;
    }
}
