using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFood { }

// Processed Hot Food 
public class FriedChicken : IFood { }
public class Chile : IFood { }
public class RegularShowDrink : IFood { }

// Processed Cold Food
public class IceCream : IFood { }
public class Cheese : IFood { }
public class Wine : IFood { }

// Non Process Hot Food
public class HotDog : IFood { } //fastfood
public class Steak : IFood { }  //healthy
public class GreenDrink : IFood { }  //drinks

// Non Process Cold Food
public class Muffin : IFood { }
public class WaterMelon : IFood { }
public class BlueDrink : IFood { }

