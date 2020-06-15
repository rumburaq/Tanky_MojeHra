using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uhelScript : MonoBehaviour
{
  public InputField nameField;

  private string charName;

  int x;

  void Start() {

    Debug.Log("ewfkfkwfkbwf");
  }

    public void OnSubmit()
    {
      charName = nameField.text;
      int.Parse(charName);
      print("napsal si (uhel) " + charName);


      //
      charName = nameField.text;
      int.TryParse(charName, out int x);
      //y = nameField2;
      Debug.Log(x);
    }
}
