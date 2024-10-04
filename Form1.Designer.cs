namespace ConversorMoeda
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
            btnConverter = new Button();
            comboBoxDestino = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxOrigem = new ComboBox();
            txtValor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(190, 263);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(162, 50);
            btnConverter.TabIndex = 0;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Items.AddRange(new object[] { "USD", "EUR", "BRL", "GBP", "JPY", "CHF", "CAD", "AUD", "CNY", "INR" });
            comboBoxDestino.Location = new Point(12, 181);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(198, 33);
            comboBoxDestino.TabIndex = 1;
            comboBoxDestino.SelectedIndexChanged += comboBoxDestino_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 2;
            label1.Text = "Moeda Destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 4;
            label2.Text = "Moeda Origem";
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Items.AddRange(new object[] { "USD", "EUR", "BRL", "GBP", "JPY", "CHF", "CAD", "AUD", "CNY", "INR" });
            comboBoxOrigem.Location = new Point(12, 71);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(198, 33);
            comboBoxOrigem.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(300, 73);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(213, 31);
            txtValor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 24);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 6;
            label3.Text = "Valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 134);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 8;
            label4.Text = "Rsultado";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(300, 183);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(213, 31);
            txtResultado.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(label4);
            Controls.Add(txtResultado);
            Controls.Add(label3);
            Controls.Add(txtValor);
            Controls.Add(label2);
            Controls.Add(comboBoxOrigem);
            Controls.Add(label1);
            Controls.Add(comboBoxDestino);
            Controls.Add(btnConverter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConverter;
        private ComboBox comboBoxDestino;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxOrigem;
        private TextBox txtValor;
        private Label label3;
        private Label label4;
        private TextBox txtResultado;
    }
}
