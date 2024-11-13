
public class PizzaService : IPizzaService
{
    private readonly IpizzaRepository _ipizzaRepository;
    public PizzaService(IpizzaRepository repository) 
    {
           _ipizzaRepository = repository;
    }
    public PIZZA AddNewPizza(PizzaRequestModel pizza)
    {
        //if (pizza == null)
        //{
        //    throw new ArgumentNullException();
        //}
        PIZZA pizzas = new PIZZA();
        pizzas.Id = 4;
        pizzas.Name = pizza.Name;
        pizzas.Description = pizza.Description;
        pizzas.IsAvailable = pizza.IsAvailable;
        return _ipizzaRepository.AddPizza(pizzas);
        //return pizzas;
    }

    public void DeleteNewPizza(int Id)
    {
      PIZZA pi =_ipizzaRepository.GetPizza(Id);
        _ipizzaRepository.DeletePizza(pi);
    }

    public List<PIZZA> GetAllPizza()
    {
        return _ipizzaRepository.GetAllPizza();
    }

    public PIZZA GetPizza(int Id)
    {
        PIZZA pizz =_ipizzaRepository.GetPizza(Id);
        return pizz;
    }

    public PIZZA UpdatePizza(PIZZA pizza)
    {
        //PIZZA pp = _ipizzaRepository.GetPizza(pizza.Id);
        _ipizzaRepository.UpdatePizza(pizza);
        return pizza;
    }
}
