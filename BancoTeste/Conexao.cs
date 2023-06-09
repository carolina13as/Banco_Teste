using MySql.Data.MySqlClient;

public static class Conexao
{
    static private MySqlConnection ConexaoBd;
    public static MySqlConnection Conectar()
    {       
        try
        {
            //teste do github
            string conexao = "server=localhost;uid=root;pwd=Triplo9!;database=BancoTeste";
            ConexaoBd = new MySqlConnection(conexao);
            ConexaoBd.Open();

            Console.WriteLine("Conexão realizada com sucesso");
            
        }        
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao conectar ao banco de dados" + ex.Message);
        }
        return ConexaoBd;
    }

    public static void Desconectar()
    {
        ConexaoBd.Close();
    }
}

