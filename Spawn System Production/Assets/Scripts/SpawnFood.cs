using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public void Food(GameObject food)
    {
        Instantiate(food);
    }
}
