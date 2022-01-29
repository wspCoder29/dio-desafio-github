namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    //T tipo genérico que deve ser passado por toda classe que implementar essa interface
    {
        List<T>Lista();
        T RetornaPorId(int id);
        void Insere(Serie entidade);
        void Exclui(int id);
        void Atualiza(int id, Serie objeto);
        int ProximoId();

    
    }
}