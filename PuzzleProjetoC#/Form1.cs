using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form1 : Form
{
    // Declaração de variáveis e componentes
    private PictureBox picFundo;
    private PictureBox[] pecas;  // Array para as peças do quebra-cabeça
    private Timer gameTimerControl;  // Timer para controle do tempo (renomeado para evitar conflito)
    private Label lblTime;
    private Button btnIniciar, btnReiniciar, btnLoadImagem;
    private ComboBox cmbDifficulty;

    public Form1()
    {
        InitializeComponent();
        CriarComponentes();  // Chama o método para configurar e adicionar os componentes
    }

    // Método para criar e configurar os componentes
    private void CriarComponentes()
    {
        // Instancia o PictureBox
        picFundo = new PictureBox();
        picFundo.Location = new Point(10, 10);  // Defina a posição adequada
        picFundo.Size = new Size(500, 500);  // Defina o tamanho do PictureBox
        this.Controls.Add(picFundo);  // Adiciona o PictureBox ao formulário

        // Configuração do botão "Iniciar Jogo"
        btnIniciar = new Button();
        btnIniciar.Text = "Iniciar Jogo";
        btnIniciar.Location = new Point(520, 50);
        btnIniciar.Click += BtnIniciar_Click;  // Evento de clique para iniciar o jogo
        this.Controls.Add(btnIniciar);

        // Configuração do botão "Reiniciar Jogo"
        btnReiniciar = new Button();
        btnReiniciar.Text = "Reiniciar Jogo";
        btnReiniciar.Location = new Point(520, 100);
        btnReiniciar.Click += BtnReiniciar_Click;
        this.Controls.Add(btnReiniciar);

        // Configuração do botão "Carregar Imagem"
        btnLoadImagem = new Button();
        btnLoadImagem.Text = "Carregar Imagem";
        btnLoadImagem.Location = new Point(520, 150);
        btnLoadImagem.Click += BtnLoadImagem_Click;
        this.Controls.Add(btnLoadImagem);

        // Configuração do ComboBox para selecionar a dificuldade
        cmbDifficulty = new ComboBox();
        cmbDifficulty.Items.AddRange(new string[] { "Fácil", "Médio", "Difícil" });
        cmbDifficulty.Location = new Point(520, 200);
        this.Controls.Add(cmbDifficulty);

        // Configuração do Label para exibir o tempo
        lblTime = new Label();
        lblTime.Text = "Tempo: 00:00";
        lblTime.Location = new Point(520, 250);
        this.Controls.Add(lblTime);

        // Inicialização do Timer para controle de tempo
        gameTimerControl = new Timer();
        gameTimerControl.Interval = 1000;  // 1 segundo
        gameTimerControl.Tick += GameTimer_Tick;  // Evento de contagem de tempo
    }

    // Função para dividir a imagem carregada nas peças do quebra-cabeça
    private void DividirImagem(int numColunas, int numLinhas)
    {
        if (picFundo.Image == null) return;  // Verifica se há imagem carregada

        Image img = picFundo.Image;
        int pecaLargura = img.Width / numColunas;
        int pecaAltura = img.Height / numLinhas;
        pecas = new PictureBox[numColunas * numLinhas];

        for (int i = 0; i < pecas.Length; i++)
        {
            int coluna = i % numColunas;
            int linha = i / numColunas;

            Bitmap pecaImagem = new Bitmap(pecaLargura, pecaAltura);
            Graphics g = Graphics.FromImage(pecaImagem);
            g.DrawImage(img, new Rectangle(0, 0, pecaLargura, pecaAltura),
                        new Rectangle(coluna * pecaLargura, linha * pecaAltura, pecaLargura, pecaAltura),
                        GraphicsUnit.Pixel);

            pecas[i] = new PictureBox();
            pecas[i].Size = new Size(pecaLargura, pecaAltura);
            pecas[i].Location = new Point(coluna * pecaLargura, linha * pecaAltura);
            pecas[i].Image = pecaImagem;
            pecas[i].BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(pecas[i]);
        }
    }

    // Evento de clique para iniciar o jogo
    private void BtnIniciar_Click(object sender, EventArgs e)
    {
        int colunas = 0, linhas = 0;

        // Verifica se o usuário selecionou a dificuldade
        if (cmbDifficulty.SelectedItem == null)
        {
            MessageBox.Show("Selecione um nível de dificuldade.");
            return;
        }

        // Define o número de colunas e linhas com base na dificuldade
        switch (cmbDifficulty.SelectedItem.ToString())
        {
            case "Fácil":
                colunas = 3;
                linhas = 3;
                break;
            case "Médio":
                colunas = 4;
                linhas = 4;
                break;
            case "Difícil":
                colunas = 5;
                linhas = 5;
                break;
        }

        DividirImagem(colunas, linhas);
        gameTimerControl.Start();  // Inicia o timer
    }

    // Evento de clique para reiniciar o jogo
    private void BtnReiniciar_Click(object sender, EventArgs e)
    {
        gameTimerControl.Stop();  // Para o timer
        lblTime.Text = "Tempo: 00:00";  // Reseta o tempo

        // Reinicia o jogo se uma dificuldade for selecionada
        if (cmbDifficulty.SelectedItem != null)
        {
            BtnIniciar_Click(sender, e);  // Reinicia o jogo
        }
    }

    // Evento do Timer para atualizar o tempo
    private void GameTimer_Tick(object sender, EventArgs e)
    {
        var tempoAtual = TimeSpan.Parse(lblTime.Text.Split(':')[1].Trim());
        tempoAtual = tempoAtual.Add(TimeSpan.FromSeconds(1));
        lblTime.Text = $"Tempo: {tempoAtual:mm\\:ss}";  // Atualiza o Label com o tempo
    }

    // Evento para carregar a imagem
    private void BtnLoadImagem_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Imagens|*.jpg;*.png;*.bmp";  // Filtro para tipos de imagem
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            picFundo.Image = Image.FromFile(openFileDialog.FileName);  // Carrega a imagem
        }
    }
}

