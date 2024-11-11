namespace Dominio.Model
{

    public class Sistema
    {
        public string autenticador { get; set; } = "";
        public string codigo { get; set; } = ""; 
        public string sigla { get; set; } = "";
        public string nome { get; set; } = "";
        public string ativo { get; set; } = "";
    }

    public class user
    {
        public string login { get; set; } = "";
        public string cpf { get; set; } = ""; 
        public string nome { get; set; } = ""; 
        public string ativo { get; set; } = ""; 
    }

    public class recurso
    {
        public string recursoPai { get; set; } = "";
        public string tipo { get; set; } = "";
        public string chave { get; set; } = ""; 
        public string nome { get; set; } = "";
        public string caminho { get; set; } = ""; 
        public string ativo { get; set; } = ""; 
    }
    public class orgaoUsuario
    {
        public string codigo { get; set; } = "";
        public string orgao { get; set; } = ""; 
    }
    public class UsuarioModel
    {
        public string ambiente { get; set; } = "";
        public Sistema sistema { get; set; } = new Sistema();
        public user usuario { get; set; } = new user(); 
        public string dataAcesso { get; set; } = "";
        public IList<String> perfis { get; set; } = new List<String>();
        public IList<recurso> recursos { get; set; } = new List<recurso>();
        public IList<orgaoUsuario> orgaosUsuario { get; set; } = new List<orgaoUsuario>();
    }
}