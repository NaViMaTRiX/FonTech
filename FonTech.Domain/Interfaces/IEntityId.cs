namespace FonTech.Domain.Interfaces;

public interface IEntity<T> where T : struct
{
    public T Id { get; set; }
}