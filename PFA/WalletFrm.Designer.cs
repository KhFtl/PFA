namespace PFA
{
    partial class WalletFrm
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
            dgrv_wallet = new DataGridView();
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            btn_del = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrv_wallet).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgrv_wallet
            // 
            dgrv_wallet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrv_wallet.Dock = DockStyle.Fill;
            dgrv_wallet.Location = new Point(3, 28);
            dgrv_wallet.Name = "dgrv_wallet";
            dgrv_wallet.Size = new Size(578, 339);
            dgrv_wallet.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_del);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 325);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Введення аних";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(6, 264);
            button1.Name = "button1";
            button1.Size = new Size(186, 55);
            button1.TabIndex = 6;
            button1.Text = "Додати гаманець";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(320, 33);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 32);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(319, 32);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 144);
            label3.Name = "label3";
            label3.Size = new Size(153, 25);
            label3.TabIndex = 2;
            label3.Text = "Валюта гаманця";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 94);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 1;
            label2.Text = "Баланс гаманця";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 55);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Ім'я гаманця";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(dgrv_wallet);
            groupBox2.Location = new Point(12, 343);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 370);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Гаманці";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Location = new Point(602, 343);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(578, 367);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Транзакції";
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn_del.Location = new Point(346, 264);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(218, 55);
            btn_del.TabIndex = 7;
            btn_del.Text = "Видалення гаманця";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // WalletFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 725);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "WalletFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гаманці";
            ((System.ComponentModel.ISupportInitialize)dgrv_wallet).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrv_wallet;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private Button btn_del;
    }
}