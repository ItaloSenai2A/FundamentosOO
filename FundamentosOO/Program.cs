using FundamentosOO;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        // Instanciar um objeto do tipo Aluno
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno();
        Aluno aluno3 = new Aluno();
        Aluno aluno4 = new Aluno();


        //Preencher os atributos do objeto 
        aluno1.Nome = "Cristiano de Paula";
        aluno1.RM = "1234TI";
        aluno1.Email = "Cristiano.paula@sp.senai.br";
        aluno1.Nascimento = new DateOnly(1981, 07, 16);

        //Imprimir na tela 
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome: " + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("Email:" + aluno1.Email);
        Console.WriteLine("Nascimento:" + aluno1.Nascimento);
        Console.WriteLine("============================================");

        aluno2.Nome = "Rayssa Nanclares da Silveira";
        aluno2.RM = "1234TI";
        aluno2.Email = "rayssa.silveira@aluno.senai.br";
        aluno2.Nascimento = new DateOnly(2007, 12, 19);


        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome: " + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("Email:" + aluno2.Email);
        Console.WriteLine("Nascimento:" + aluno2.Nascimento);
        Console.WriteLine("============================================");

        aluno3.Nome = "Emanuelly Vitoria dos Santos Lima";
        aluno3.RM = "1234TI";
        aluno3.Email = "manulimato@aluno.senai.br";
        aluno3.Nascimento = new DateOnly(2008, 01, 25);

        //Imprimir na tela 
        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome: " + aluno3.Nome);
        Console.WriteLine("RM: " + aluno3.RM);
        Console.WriteLine("Email:" + aluno3.Email);
        Console.WriteLine("Nascimento:" + aluno3.Nascimento);
        Console.WriteLine("============================================");


        aluno4.Nome = "Ítalo Francesco";
        aluno4.RM = "1234TI";
        aluno4.Email = "italo.francesco@aluno.senai.br";
        aluno4.Nascimento = new DateOnly(2008, 03, 28);

        //Imprimir na tela 
        Console.WriteLine("Aluno 4");
        Console.WriteLine("Nome: " + aluno4.Nome);
        Console.WriteLine("RM: " + aluno4.RM);
        Console.WriteLine("Email:" + aluno4.Email);
        Console.WriteLine("Nascimento:" + aluno4.Nascimento);
        Console.WriteLine("============================================");

        // Instanciar um objeto do Tipo Produto
        Produto p1 = new Produto();
        p1.Codigo = 123456;
        p1.Nome = "Coca-cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();

        p1.Estoque = 85;
        // Chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();

        Console.WriteLine("============================================");
        Console.WriteLine();

        //Instanciar um objeto do tipo Carro
        Carro carro1 = new Carro();

        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 80;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();

        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Ítalo Francesco";
        pessoa1.Idade = 16;

        pessoa1.Anos();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Luis Santos";
        func1.Idade = 20;
        func1.Salario = 1400.00;
        func1.Cargo = "Aprendiz";

        func1.ApresentarSe();
        
        // Instanciar um Objto
        Animal animal1 = new Animal();

        // Inserindo Dados no Atributo
        animal1.Especie = "Cachorro";

        //Chamando o Método do Objeto
        animal1.emitirSom();

        // Imprimindo a informação na tela 
        Console.WriteLine("O animal " + animal1.Especie + "emitiu um som.");
        */

        /*
        Gato gato = new Gato();
        gato.Nome = "Frajola";
        Console.WriteLine(gato.Nome + " faz: ");
        gato.emitirSom();

        Cachorro cachorro = new Cachorro();
        cachorro.Nome = "Bob";
        Console.WriteLine(cachorro.Nome + " faz: ");
        cachorro.emitirSom();

        Galinha galinha = new Galinha();
        galinha.Nome = "Lola";
        Console.WriteLine(galinha.Nome + " faz: ");
        galinha.emitirSom();
        */

        Mago merlin = new Mago();
        merlin.Nome = " Mago Merlin";
        merlin.Vida = 100;
        merlin.Inteligencia = 87;
        merlin.Agilidade = 55;
        merlin.Forca = 62;
        merlin.Nivel = 1;

        Elfo elfo = new Elfo();
        elfo.Nome = "Julius";
        elfo.Vida = 100;
        elfo.Inteligencia = 83;
        elfo.Forca = 56;
        elfo.Agilidade = 60;
        elfo.Nivel = 1;

        merlin.apresentarSe();
        elfo.apresentarSe();

        merlin.batalhar(elfo);
    }
}




