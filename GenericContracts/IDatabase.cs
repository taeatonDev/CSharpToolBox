namespace GenericContracts;

public interface IDatabase<out T>
{
    T GetConnectionDetails();
}