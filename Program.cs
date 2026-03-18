using System.Linq;


List<int> listaunica = new List<int> 
{
    1, 2, 3, 4, 5, 6
};


var listaComNumeroUnico = listaunica.Where(listaunica => listaunica.Equals(2)).ToList();


foreach (var numero in listaComNumeroUnico) 
{
    Console.WriteLine($"Numero escolhido: {numero}");
}
