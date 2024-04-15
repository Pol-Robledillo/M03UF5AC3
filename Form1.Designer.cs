namespace M03UF5AC3
{
    partial class InputGroup
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
            groupBox1 = new GroupBox();
            yearLabel = new Label();
            yearSelector = new ComboBox();
            regionLabel = new Label();
            regionSelector = new ComboBox();
            townLabel = new Label();
            townSelector = new ComboBox();
            domNetLabel = new Label();
            domNetInput = new TextBox();
            ecoActivitiesLabel = new Label();
            ecoActivitiesInput = new TextBox();
            domConsLabel = new Label();
            consDomInput = new TextBox();
            totalLabel = new Label();
            textBox1 = new TextBox();
            statsGroup = new GroupBox();
            populationBiggerThanLabel = new Label();
            avgDomConsLabel = new Label();
            highestDomConsLabel = new Label();
            lowestDomConsLabel = new Label();
            saveButton = new Button();
            cleanSelectionButton = new Button();
            groupBox1.SuspendLayout();
            statsGroup.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(totalLabel);
            groupBox1.Controls.Add(consDomInput);
            groupBox1.Controls.Add(domConsLabel);
            groupBox1.Controls.Add(ecoActivitiesInput);
            groupBox1.Controls.Add(ecoActivitiesLabel);
            groupBox1.Controls.Add(domNetInput);
            groupBox1.Controls.Add(domNetLabel);
            groupBox1.Controls.Add(townSelector);
            groupBox1.Controls.Add(townLabel);
            groupBox1.Controls.Add(regionSelector);
            groupBox1.Controls.Add(regionLabel);
            groupBox1.Controls.Add(yearSelector);
            groupBox1.Controls.Add(yearLabel);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de Dades Demogràfiques de Regions";
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
            // yearSelector
            // 
            yearSelector.FormattingEnabled = true;
            yearSelector.Location = new Point(15, 47);
            yearSelector.Name = "yearSelector";
            yearSelector.Size = new Size(115, 23);
            yearSelector.TabIndex = 1;
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
            // regionSelector
            // 
            regionSelector.FormattingEnabled = true;
            regionSelector.Location = new Point(154, 47);
            regionSelector.Name = "regionSelector";
            regionSelector.Size = new Size(126, 23);
            regionSelector.TabIndex = 3;
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
            // townSelector
            // 
            townSelector.FormattingEnabled = true;
            townSelector.Location = new Point(305, 47);
            townSelector.Name = "townSelector";
            townSelector.Size = new Size(124, 23);
            townSelector.TabIndex = 5;
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
            // domNetInput
            // 
            domNetInput.Location = new Point(15, 120);
            domNetInput.Name = "domNetInput";
            domNetInput.Size = new Size(115, 23);
            domNetInput.TabIndex = 7;
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
            // ecoActivitiesInput
            // 
            ecoActivitiesInput.Location = new Point(154, 120);
            ecoActivitiesInput.Name = "ecoActivitiesInput";
            ecoActivitiesInput.Size = new Size(126, 23);
            ecoActivitiesInput.TabIndex = 9;
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
            // consDomInput
            // 
            consDomInput.Location = new Point(305, 120);
            consDomInput.Name = "consDomInput";
            consDomInput.Size = new Size(124, 23);
            consDomInput.TabIndex = 11;
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
            // textBox1
            // 
            textBox1.Location = new Point(455, 120);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(124, 23);
            textBox1.TabIndex = 13;
            // 
            // statsGroup
            // 
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
            // saveButton
            // 
            saveButton.Location = new Point(535, 188);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Guardar";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // cleanSelectionButton
            // 
            cleanSelectionButton.Location = new Point(454, 188);
            cleanSelectionButton.Name = "cleanSelectionButton";
            cleanSelectionButton.Size = new Size(75, 23);
            cleanSelectionButton.TabIndex = 3;
            cleanSelectionButton.Text = "Netejar";
            cleanSelectionButton.UseVisualStyleBackColor = true;
            // 
            // InputGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(cleanSelectionButton);
            Controls.Add(saveButton);
            Controls.Add(statsGroup);
            Controls.Add(groupBox1);
            Name = "InputGroup";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statsGroup.ResumeLayout(false);
            statsGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
        private TextBox textBox1;
        private Label totalLabel;
        private GroupBox statsGroup;
        private Label avgDomConsLabel;
        private Label populationBiggerThanLabel;
        private Label lowestDomConsLabel;
        private Label highestDomConsLabel;
        private Button saveButton;
        private Button cleanSelectionButton;
    }
}
