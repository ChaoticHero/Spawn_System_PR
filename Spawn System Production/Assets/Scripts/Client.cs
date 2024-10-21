using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Client : MonoBehaviour
{
    // alchemy
    public GameObject FriedChicken;
    public GameObject Chile;
    public GameObject RegularShowDrink;
    public GameObject IceCream;
    public GameObject Cheese;
    public GameObject Wine;
    public GameObject HotDog;
    public GameObject Steak;
    public GameObject GreenDrink;
    public GameObject Muffin;
    public GameObject WaterMelon;
    public GameObject BlueDrink;

    public SpawnFood spawn;

    public Text TextBox;
    public Dropdown typeDropdown;
    public Dropdown tempDropdown;

    public int typefood;
    public int temperature;
    public bool processed;
    public Toggle EngineToggle;

    public List<GameObject> list = new List<GameObject>();

    void Start()
    {


        MagicRequirements requirements = new MagicRequirements();
        requirements.Type = typeDropdown.value;
        requirements.Temp = tempDropdown.value;
        requirements.processedFood = processed;

        IFood f = GetPlant(requirements);
        TextBox.text = f.ToString();

    }

    public void CreateButton()
    {
        MagicRequirements requirements = new MagicRequirements();
        requirements.Type = typeDropdown.value;
        requirements.Temp = tempDropdown.value;
        requirements.processedFood = processed;

        IFood f = GetPlant(requirements);
        TextBox.text = f.ToString();
        EngineToggle.isOn = processed;
        var curgameobjects = GameObject.FindObjectsOfType<GameObject>();
        foreach (var v in curgameobjects)
        {
            if (v.name.Contains("Clone"))
                Destroy(v.gameObject);
        }

        if (f.ToString() == "FriedChicken") spawn.Food(FriedChicken);
        else if (f.ToString() == "Chile") spawn.Food(Chile);
        else if (f.ToString() == "RegularShowDrink") spawn.Food(RegularShowDrink);
        else if (f.ToString() == "IceCream") spawn.Food(IceCream);
        else if (f.ToString() == "Cheese") spawn.Food(Cheese);
        else if (f.ToString() == "Wine") spawn.Food(Wine);
        else if (f.ToString() == "HotDog") spawn.Food(HotDog);
        else if (f.ToString() == "Steak") spawn.Food(Steak);
        else if (f.ToString() == "GreenDrink") spawn.Food(GreenDrink);
        else if (f.ToString() == "Muffin") spawn.Food(Muffin);
        else if (f.ToString() == "WaterMelon") spawn.Food(WaterMelon);
        else if (f.ToString() == "BlueDrink") spawn.Food(BlueDrink);

    }

    private static IFood GetPlant(MagicRequirements requirements)
    {
        FoodFactory factory = new FoodFactory(requirements);
        return factory.Create();
    }

    public void ToggleChangeprocessed()
    {
        if (EngineToggle.isOn == true)
            processed = true;
        else
            processed = false;
    }

}
