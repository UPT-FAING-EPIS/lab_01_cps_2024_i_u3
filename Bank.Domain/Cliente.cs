namespace Bank.Domain
{
    public class Cliente
    {
        public int IdCliente { get; private set; }
        public string NombreCliente { get; private set; }
        public static Cliente Registrar(string _nombre)
        {
            return new Cliente(){
                NombreCliente = _nombre
            };
        }   
    }
}