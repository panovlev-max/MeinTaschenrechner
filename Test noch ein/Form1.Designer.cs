namespace Test_noch_ein
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnCalculate = new Button();
            label1 = new Label();
            txtName = new TextBox();
            txtOrt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtZahl1 = new TextBox();
            label5 = new Label();
            txtZahl2 = new TextBox();
            label6 = new Label();
            txtResult = new TextBox();
            label7 = new Label();
            txtOperator = new TextBox();
            btnRegister = new Button();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            btnListClear = new Button();
            btnSeve = new Button();
            btnUseSave = new Button();
            btnDeleteHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalculate.BackgroundImage = Properties.Resources.Herunterladen;
            btnCalculate.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalculate.Font = new Font("Alef", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.FromArgb(192, 0, 0);
            btnCalculate.Location = new Point(799, 247);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(137, 80);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "für zahlen ";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            btnCalculate.KeyDown += btnCalculate_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 1;
            label1.Text = "                                     ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.Location = new Point(307, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(419, 23);
            txtName.TabIndex = 2;
            txtName.KeyDown += AlleBoxen_KeyDown;
            // 
            // txtOrt
            // 
            txtOrt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOrt.Location = new Point(307, 74);
            txtOrt.Name = "txtOrt";
            txtOrt.Size = new Size(419, 23);
            txtOrt.TabIndex = 3;
            txtOrt.KeyDown += AlleBoxen_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(18, 74);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 5;
            label3.Text = "wo lebt ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(18, 134);
            label4.Name = "label4";
            label4.Size = new Size(249, 25);
            label4.TabIndex = 6;
            label4.Text = "Schreiben sie die Erste zahl";
            // 
            // txtZahl1
            // 
            txtZahl1.AccessibleName = "Zahlen angabe ";
            txtZahl1.AccessibleRole = AccessibleRole.None;
            txtZahl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtZahl1.Location = new Point(307, 134);
            txtZahl1.Name = "txtZahl1";
            txtZahl1.Size = new Size(419, 23);
            txtZahl1.TabIndex = 7;
            txtZahl1.TextChanged += KeineSimwohle_TextChange;
            txtZahl1.KeyDown += AlleBoxen_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(18, 199);
            label5.Name = "label5";
            label5.Size = new Size(263, 25);
            label5.TabIndex = 8;
            label5.Text = "Schreiben sie die zweite zahl";
            // 
            // txtZahl2
            // 
            txtZahl2.AccessibleName = "Zahlen angabe ";
            txtZahl2.AccessibleRole = AccessibleRole.None;
            txtZahl2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtZahl2.Location = new Point(307, 199);
            txtZahl2.Name = "txtZahl2";
            txtZahl2.Size = new Size(419, 23);
            txtZahl2.TabIndex = 9;
            txtZahl2.TextChanged += KeineSimwohle_TextChange;
            txtZahl2.KeyDown += AlleBoxen_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(18, 360);
            label6.Name = "label6";
            label6.Size = new Size(122, 25);
            label6.TabIndex = 10;
            label6.Text = "das Ergebnis";
            // 
            // txtResult
            // 
            txtResult.AccessibleRole = AccessibleRole.None;
            txtResult.Anchor = AnchorStyles.None;
            txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtResult.Location = new Point(307, 341);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(419, 50);
            txtResult.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(18, 272);
            label7.Name = "label7";
            label7.Size = new Size(212, 25);
            label7.TabIndex = 12;
            label7.Text = "was wollt ihr * ,+,/,-,+,";
            // 
            // txtOperator
            // 
            txtOperator.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOperator.Location = new Point(307, 272);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(419, 23);
            txtOperator.TabIndex = 13;
            txtOperator.KeyDown += AlleBoxen_KeyDown;
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRegister.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegister.Cursor = Cursors.Cross;
            btnRegister.DialogResult = DialogResult.OK;
            btnRegister.ForeColor = SystemColors.Desktop;
            btnRegister.Location = new Point(799, 59);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 38);
            btnRegister.TabIndex = 14;
            btnRegister.Tag = resources.GetString("btnRegister.Tag");
            btnRegister.Text = "Für die regestrirung\r\n";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            btnRegister.KeyDown += btnRegister_KeyDown;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.ForeColor = SystemColors.ControlText;
            btnClear.Location = new Point(799, 417);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 51);
            btnClear.TabIndex = 15;
            btnClear.Text = "objtehit";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Prson_für_Programm;
            pictureBox1.Location = new Point(821, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.anderer_Zurück;
            pictureBox2.Location = new Point(799, 384);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(137, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(20, 434);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 139);
            listBox1.TabIndex = 18;
            // 
            // btnListClear
            // 
            btnListClear.AccessibleRole = AccessibleRole.OutlineButton;
            btnListClear.Anchor = AnchorStyles.None;
            btnListClear.Location = new Point(307, 550);
            btnListClear.Name = "btnListClear";
            btnListClear.Size = new Size(126, 23);
            btnListClear.TabIndex = 19;
            btnListClear.Text = "wen zufiel";
            btnListClear.UseVisualStyleBackColor = true;
            btnListClear.Click += btnListClear_Click;
            // 
            // btnSeve
            // 
            btnSeve.AccessibleName = "";
            btnSeve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSeve.Location = new Point(954, 539);
            btnSeve.Name = "btnSeve";
            btnSeve.Size = new Size(75, 45);
            btnSeve.TabIndex = 20;
            btnSeve.Text = "seve";
            btnSeve.UseVisualStyleBackColor = true;
            btnSeve.Click += speichernButten_Click;
            // 
            // btnUseSave
            // 
            btnUseSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUseSave.Location = new Point(0, 0);
            btnUseSave.Name = "btnUseSave";
            btnUseSave.Size = new Size(140, 23);
            btnUseSave.TabIndex = 21;
            btnUseSave.Text = "seve ferwenden";
            btnUseSave.UseVisualStyleBackColor = true;
            btnUseSave.Click += seveverwendenButon_Click;
            // 
            // btnDeleteHistory
            // 
            btnDeleteHistory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteHistory.Location = new Point(954, 0);
            btnDeleteHistory.Name = "btnDeleteHistory";
            btnDeleteHistory.Size = new Size(75, 83);
            btnDeleteHistory.TabIndex = 22;
            btnDeleteHistory.Text = "die geschicht löschen";
            btnDeleteHistory.UseVisualStyleBackColor = true;
            btnDeleteHistory.Click += hystorydelit_Click;
            // 
            // Form1
            // 
            AccessibleName = "Zahlen angabe ";
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1029, 585);
            Controls.Add(btnDeleteHistory);
            Controls.Add(btnUseSave);
            Controls.Add(btnSeve);
            Controls.Add(btnListClear);
            Controls.Add(listBox1);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(txtOperator);
            Controls.Add(label7);
            Controls.Add(txtResult);
            Controls.Add(label6);
            Controls.Add(txtZahl2);
            Controls.Add(label5);
            Controls.Add(txtZahl1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtOrt);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnCalculate);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private Label label1;
        private TextBox txtName;
        private TextBox txtOrt;
        private Label label3;
        private Label label4;
        private TextBox txtZahl1;
        private Label label5;
        private TextBox txtZahl2;
        private Label label6;
        private TextBox txtResult;
        private Label label7;
        private TextBox txtOperator;
        private Button btnRegister;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox listBox1;
        private Button btnListClear;
        private Button btnSeve;
        private Button btnUseSave;
        private Button btnDeleteHistory;
    }
}
