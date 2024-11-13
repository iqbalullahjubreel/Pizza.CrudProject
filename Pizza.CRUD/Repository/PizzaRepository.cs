
public class PizzaRepository : IpizzaRepository
{
    static List<PIZZA> _pizzas = new List<PIZZA>()
    {
        new PIZZA {Id =1,Name = "TOMATOE PIZZA", Description = "SOUR",IsAvailable = true},
        new PIZZA {Id =2,Name = "ONION PIZZA", Description = "BITTER",IsAvailable = true},
        new PIZZA {Id =3,Name = "POTATOE PIZZA", Description = "HARMFUL",IsAvailable = false}
    };
    public PIZZA AddPizza(PIZZA pizza)
    {
        _pizzas.Add(pizza);
        return pizza;
    }

    public void DeletePizza(PIZZA pizza)
    {
          //GetPizza(result.Id);
        _pizzas.Remove(pizza);
    }

    public List<PIZZA> GetAllPizza()
    {
        return _pizzas.ToList();
    }

    public PIZZA GetPizza(int id)
    {
        PIZZA? result = _pizzas.Find(x => x.Id == id);
        return result;
    }

    public PIZZA UpdatePizza(PIZZA pizzas) //object holding 1
    {
        PIZZA piz = GetPizza(pizzas.Id);
        piz.Name = pizzas.Name;
        piz.Description = pizzas.Description;
        piz.IsAvailable = pizzas.IsAvailable;
        return piz;
    }
}