using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickable : MonoBehaviour
{
    public UnityEvent GetPickedUp;
    public void GetPicked(Picker picker){
        GetPickedUp.Invoke();
    }
}
