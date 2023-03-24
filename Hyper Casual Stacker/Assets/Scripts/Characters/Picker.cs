using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picker : MonoBehaviour
{
    [SerializeField]
    private List<Pickable> inventory;

    void Start(){
        inventory = new List<Pickable>();
    }

    private void Pick(Pickable newObject){
        newObject.GetPicked(this);
        inventory.Add(newObject);
    }

    private void Throw(Pickable objectToRemove){
        
        inventory.Remove(objectToRemove);
    }

    public void ThrowAll(){

        inventory.Clear();
    }

    void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Pickable")){
            Pick(col.gameObject.GetComponent<Pickable>());
        }
    }
}   
