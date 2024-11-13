namespace Disaheim;

public class Controller
{
    
    public ValuableRepository ValuableRepository = new ValuableRepository();
    
    public Controller()
    {
        
    }
    public void AddTolist(IValuable valuable)
    {
        ValuableRepository.AddValuable(valuable);
    }
}