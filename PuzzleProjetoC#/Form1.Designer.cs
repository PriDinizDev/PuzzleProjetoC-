namespace PuzzleProjetoC_
{
    partial class FrmMain
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
            pnlPuzzle = new Panel();
            cmbdifficulty = new ComboBox();
            btnloadImagem = new Button();
            btnIniciar = new Button();
            btnReiniciar = new Button();
            lblTempo = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pnlPuzzle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlPuzzle
            // 
            pnlPuzzle.Controls.Add(pictureBox1);
            pnlPuzzle.Location = new Point(101, 12);
            pnlPuzzle.Name = "pnlPuzzle";
            pnlPuzzle.Size = new Size(500, 500);
            pnlPuzzle.TabIndex = 0;
            // 
            // cmbdifficulty
            // 
            cmbdifficulty.FormattingEnabled = true;
            cmbdifficulty.Items.AddRange(new object[] { "Fácil", "Médio", "Difícil " });
            cmbdifficulty.Location = new Point(643, 56);
            cmbdifficulty.Name = "cmbdifficulty";
            cmbdifficulty.Size = new Size(151, 28);
            cmbdifficulty.TabIndex = 1;
            // 
            // btnloadImagem
            // 
            btnloadImagem.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnloadImagem.Location = new Point(642, 101);
            btnloadImagem.Name = "btnloadImagem";
            btnloadImagem.Size = new Size(165, 40);
            btnloadImagem.TabIndex = 0;
            btnloadImagem.Text = "Carregar Imagem ";
            btnloadImagem.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(673, 147);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(94, 29);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(673, 193);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(94, 29);
            btnReiniciar.TabIndex = 2;
            btnReiniciar.Text = "Reiniciar ";
            btnReiniciar.UseVisualStyleBackColor = true;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(679, 24);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(88, 20);
            lblTempo.TabIndex = 3;
            lblTempo.Text = "Tempo : 00s";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(819, 517);
            Controls.Add(lblTempo);
            Controls.Add(btnReiniciar);
            Controls.Add(btnIniciar);
            Controls.Add(cmbdifficulty);
            Controls.Add(btnloadImagem);
            Controls.Add(pnlPuzzle);
            Name = "FrmMain";
            Text = "PuzzleGame ";
            pnlPuzzle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPuzzle;
        private ComboBox cmbdifficulty;
        private Button btnloadImagem;
        private Button btnIniciar;
        private Button btnReiniciar;
        private Label lblTempo;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox pictureBox1;
    }
}
