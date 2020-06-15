using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // důležitá knihovna

public class rychlostScript : MonoBehaviour
{
  public InputField nameField2; //vstupni pole na obrazovce - rychlost

  private string charName2; // string na ulozeni z - rychlost

  int x = 0;

  void Start()
  {
    Debug.Log("ewfkfkwfkbwf");
  }

  public void OnSubmit2() // po kliknuti na tlacitko vysteřel!
  {

    charName2 = nameField2.text; // získej vstup
    int.TryParse(charName2, out int x); // preved ho na int, ulou do x
    //y = nameField2;
    Debug.Log(x);
    //x = x * 2; // to je jen test ze je to int
    //Debug.Log(x); // -||-
  }
}
