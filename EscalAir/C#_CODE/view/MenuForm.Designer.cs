namespace PROJETO_INTER
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.carregarVoosButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.voosComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.regulamentacaoButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataNascLabel = new System.Windows.Forms.Label();
            this.empresaLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(310, 383);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.carregarVoosButton);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.voosComboBox);
            this.tabPage1.Controls.Add(this.okButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(302, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calendário";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // carregarVoosButton
            // 
            this.carregarVoosButton.Location = new System.Drawing.Point(103, 258);
            this.carregarVoosButton.Name = "carregarVoosButton";
            this.carregarVoosButton.Size = new System.Drawing.Size(97, 23);
            this.carregarVoosButton.TabIndex = 5;
            this.carregarVoosButton.Text = "Carregar Voos";
            this.carregarVoosButton.UseVisualStyleBackColor = true;
            this.carregarVoosButton.Click += new System.EventHandler(this.carregarVoosButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Voos do dia escolhido";
            // 
            // voosComboBox
            // 
            this.voosComboBox.FormattingEnabled = true;
            this.voosComboBox.Location = new System.Drawing.Point(6, 330);
            this.voosComboBox.Name = "voosComboBox";
            this.voosComboBox.Size = new System.Drawing.Size(209, 21);
            this.voosComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(221, 328);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Escolha uma data para checar \r\ninformações sobre vôo e tripulação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(62, 83);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TodayDate = new System.DateTime(2017, 11, 4, 0, 0, 0, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.regulamentacaoButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(302, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Menu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // regulamentacaoButton
            // 
            this.regulamentacaoButton.Location = new System.Drawing.Point(31, 80);
            this.regulamentacaoButton.Name = "regulamentacaoButton";
            this.regulamentacaoButton.Size = new System.Drawing.Size(230, 39);
            this.regulamentacaoButton.TabIndex = 0;
            this.regulamentacaoButton.Text = "Regulamentação ANAC";
            this.regulamentacaoButton.UseVisualStyleBackColor = true;
            this.regulamentacaoButton.Click += new System.EventHandler(this.regulamentacaoButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dataNascLabel);
            this.tabPage3.Controls.Add(this.empresaLabel);
            this.tabPage3.Controls.Add(this.nomeLabel);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(302, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Perfil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "DETALHES DO USUÁRIO";
            // 
            // dataNascLabel
            // 
            this.dataNascLabel.AutoSize = true;
            this.dataNascLabel.Location = new System.Drawing.Point(181, 158);
            this.dataNascLabel.Name = "dataNascLabel";
            this.dataNascLabel.Size = new System.Drawing.Size(102, 13);
            this.dataNascLabel.TabIndex = 9;
            this.dataNascLabel.Text = "Data de nascimento";
            // 
            // empresaLabel
            // 
            this.empresaLabel.AutoSize = true;
            this.empresaLabel.Location = new System.Drawing.Point(181, 203);
            this.empresaLabel.Name = "empresaLabel";
            this.empresaLabel.Size = new System.Drawing.Size(48, 13);
            this.empresaLabel.TabIndex = 8;
            this.empresaLabel.Text = "Empresa";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(181, 115);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(43, 13);
            this.nomeLabel.TabIndex = 5;
            this.nomeLabel.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 407);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "EscalAir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button regulamentacaoButton;
        private System.Windows.Forms.Label empresaLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dataNascLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox voosComboBox;
        private System.Windows.Forms.Button carregarVoosButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}