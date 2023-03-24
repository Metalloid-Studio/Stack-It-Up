using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    private void Pick(Pickable pickable){
        pickable.GetPicked(this);
    }

    void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Pickable")){
            Pick(col.gameObject.GetComponent<Pickable>());
        }
    }
}   
