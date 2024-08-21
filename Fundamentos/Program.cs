using Fundamentos;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo de comentário em uma linha

        /*
         Comentários de bloco

        Livro livro1 = new Livro();
        livro1.Titulo = "Diário de Santa Faustina";
        livro1.Editora = "Apostolado da Divina Misericórdia";
        livro1.Autor = "Faustina Kowalska";
        livro1.AnoLancamento = 1981;

        Livro livro2 = new Livro();
        livro2.Titulo = "Tratado da verdadeira devoção à Santíssima Virgem";
        livro2.Editora = "Paulus Editora";
        livro2.Autor = "Luís Maria Grignion de Montfort";
        livro2.AnoLancamento = 1843;

        Livro livro3 = new Livro();
        livro3.Titulo = "História de uma Alma";
        livro3.Editora = "Minha Biblioteca Católica";
        livro3.Autor = "Teresa de Lisieux";
        livro3.AnoLancamento = 1898;
         */

        ////Instanciar um Objeto do Tipo Aluno
        //ALuno aluno1 = new ALuno();
        //ALuno aluno2 = new ALuno();
        //ALuno aluno3 = new ALuno();

        ////Preencher os atributos do objeto
        //aluno1.Nome = "Gabriela";
        //aluno1.RM = "4449TI";
        //aluno1.Email = "gabriela.caputti@aluno.senai.br";
        //aluno1.Nascimento = new DateOnly(2008, 03, 16);

        //aluno2.Nome = "Livia";
        //aluno2.RM = "3776TI";
        //aluno2.Email = "lormeleze@gmail.com";
        //aluno2.Nascimento = new DateOnly(2007, 11, 27);

        //aluno3.Nome = "Ana Clara Lopes";
        //aluno3.RM = "3489TI";
        //aluno3.Email = "anchiaramonte@gmail.com";
        //aluno3.Nascimento = new DateOnly(2007, 05, 20);

        ////Imprimir na tela
        //Console.WriteLine("Aluno 1");
        //Console.WriteLine("Nome: " + aluno1.Nome);
        //Console.WriteLine("RM: " + aluno1.RM);
        //Console.WriteLine("E-mail: " + aluno1.Email);
        //Console.WriteLine("Data de nascimento: " + aluno1.Nascimento);
        //Console.WriteLine("==========================================");

        //Console.WriteLine("Aluno 2");
        //Console.WriteLine("Nome: " + aluno2.Nome);
        //Console.WriteLine("RM: " + aluno2.RM);
        //Console.WriteLine("E-mail: " + aluno2.Email);
        //Console.WriteLine("Data de nascimento: " + aluno2.Nascimento);
        //Console.WriteLine("==========================================");

        //Console.WriteLine("Aluno 3");
        //Console.WriteLine("Nome: " + aluno3.Nome);
        //Console.WriteLine("RM: " + aluno3.RM);
        //Console.WriteLine("E-mail: " + aluno3.Email);
        //Console.WriteLine("Data de nascimento: " + aluno3.Nascimento);
        //Console.WriteLine("==========================================");


        ////Instanciar um objeto do tipo Produto
        //Produto p1 = new Produto();
        //p1.Codigo = 123456;
        //p1.Nome = "Coca-Cola 2 Litros";
        //p1.Preco = 12.99;
        //p1.Estoque = 96;
        ////Chamar o metodo QuantidadedeEstoque 
        //p1.QuantidadeEstoque();
        //p1.Estoque = 85;
        ////Chamar o metodo QuantidadedeEstoque 
        //p1.QuantidadeEstoque();

        //Console.WriteLine("==========================================");
        //Console.WriteLine();

        ////Instanciar um objeto do tipo Carro 
        //Carro carro1 = new Carro();

        //carro1.Marca = "Ferrari";
        //carro1.Modelo = "488";
        //carro1.Velocidade = 80;

        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Acelerar();
        //carro1.Desacelerar();

        //Console.WriteLine("================================================");
        //Console.WriteLine();

        //Pessoa pessoa1 = new Pessoa();
        //pessoa1.Nome = "José";
        //pessoa1.Idade = 18;

        //pessoa1.Envelhecer(5);
        //pessoa1.Envelhecer(2);

        //Console.WriteLine("================================================");
        //Console.WriteLine();

        //Funcionario func1 = new Funcionario();
        //func1.Nome = "Luis Santos";
        //func1.Idade = 20;
        //func1.Cargo = "Aprendiz";
        //func1.Salario = 1400.00;
        //func1.ApresentarSe();

        //Console.WriteLine("================================================");
        //Console.WriteLine();

        ////// Instanciar um objeto:
        ////Animal animal1 = new Animal();

        //////Inserindo dados no stributo:
        ////animal1.Especie = "Cachorro";

        //////Chamando o Metodo do Objeto
        ////animal1.emitirSom();

        //////Imprimindo a informação na tela
        ////Console.WriteLine("O Animal" + animal1.Especie + " emitiu um som.");

        //Gato gato = new Gato();
        //gato.Nome = "Amorim";
        //Console.WriteLine(gato.Nome + " faz:");
        //gato.emitirSom();

        //Console.WriteLine();

        //Porco porco = new Porco();
        //porco.Nome = "Rabicó";
        //Console.WriteLine(porco.Nome + " faz:");
        //porco.emitirSom();

        //Console.WriteLine();

        //Galinha galinha = new Galinha();
        //galinha.Nome = "Chuck Bass";
        //Console.WriteLine(galinha.Nome + " faz:");
        //galinha.emitirSom();

        Console.WriteLine("================================================");
        Console.WriteLine();

        Mago mago1 = new Mago();
        mago1.Nome = "Luiz";
        mago1.Vida = 100;
        mago1.Inteligencia = 87;
        mago1.Agilidade = 55;
        mago1.Forca = 62;
        mago1.Nivel = 1;

        Elfo elfo1 = new Elfo();
        elfo1.Nome = "Luna";
        elfo1.Vida = 100;
        elfo1.Inteligencia = 83;
        elfo1.Forca = 56;
        elfo1.Agilidade = 0;
        elfo1.Nivel = 1;

        mago1.apresentarSe();
        elfo1.apresentarSe();

        Console.WriteLine("================================================");
        Console.WriteLine();
        mago1.batalhar(elfo1);
    }
}