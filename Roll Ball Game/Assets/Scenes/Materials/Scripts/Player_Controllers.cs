using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{


public override void OnInspectorGUI()
     {
         serializedObject.Update();
  
         itemImagesProperty.arraySize = Inventory.numItemSlots;
         itemsProperty.arraySize = Inventory.numItemSlots;
  
         for (int i= 0; i < Inventory.numItemSlots; i++)
     }

 private Rigidbody rb;

 void Start ()
{
    rb = GetComponent<Rigidbody>();
}

  // where physics calc code go
  void FixedUpdate ()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    
    Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
    rb.AddForce (movement);
  }


}
