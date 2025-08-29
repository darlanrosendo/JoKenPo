namespace JoKenPo
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
            labelTitulo = new Label();
            pictureBox2 = new PictureBox();
            picResulado = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            labelResultado = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picResulado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(12, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(778, 94);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(295, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // picResulado
            // 
            picResulado.BackgroundImageLayout = ImageLayout.Stretch;
            picResulado.Location = new Point(567, 73);
            picResulado.Name = "picResulado";
            picResulado.Size = new Size(200, 200);
            picResulado.TabIndex = 3;
            picResulado.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(73, 162);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 4;
            label1.Text = "você";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(373, 162);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 5;
            label2.Text = "PC";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResultado.ForeColor = SystemColors.Highlight;
            labelResultado.Location = new Point(666, 162);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(25, 25);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(240, 162);
            label4.Name = "label4";
            label4.Size = new Size(36, 25);
            label4.TabIndex = 7;
            label4.Text = "vs";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(524, 162);
            label5.Name = "label5";
            label5.Size = new Size(25, 25);
            label5.TabIndex = 8;
            label5.Text = "=";
            // 
            // btnPedra
            // 
            btnPedra.BackgroundImage = (Image)resources.GetObject("btnPedra.BackgroundImage");
            btnPedra.BackgroundImageLayout = ImageLayout.Stretch;
            btnPedra.Location = new Point(23, 288);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(200, 200);
            btnPedra.TabIndex = 9;
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.BackgroundImage = Properties.Resources.Papel;
            btnPapel.BackgroundImageLayout = ImageLayout.Stretch;
            btnPapel.Location = new Point(295, 288);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(200, 200);
            btnPapel.TabIndex = 10;
            btnPapel.UseVisualStyleBackColor = true;
            // 
            // btnTesoura
            // 
            btnTesoura.BackgroundImage = Properties.Resources.Tesoura;
            btnTesoura.BackgroundImageLayout = ImageLayout.Stretch;
            btnTesoura.Location = new Point(567, 288);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(200, 200);
            btnTesoura.TabIndex = 11;
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(23, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 510);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picResulado);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picResulado).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBox2;
        private PictureBox picResulado;
        private Label label1;
        private Label label2;
        private Label labelResultado;
        private Label label4;
        private Label label5;
        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
        private PictureBox pictureBox1;
    }
}
