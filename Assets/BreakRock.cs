using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakRock : MonoBehaviour
{
    // Start is called before the first frame update
    public void Damage()
    {
        Destroy(gameObject);
    }
}
