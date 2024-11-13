public interface IpizzaRepository
{
    PIZZA AddPizza(PIZZA pizza);
    void DeletePizza(PIZZA pizza);
    PIZZA UpdatePizza(PIZZA pizza);
    List<PIZZA> GetAllPizza();
    PIZZA GetPizza(int Id);
}
   