using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank1_movement : MonoBehaviour
{

  public Rigidbody2D rb;

    void Start()
    {
      Debug.Log("tank1 se hlásí do služby!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//Movement();
        {
          rb.velocity = new Vector2(-5, rb.velocity.y);
          transform.localScale = new Vector2(-0.0181386f, 0.02003867f);
        }
      else if (Input.GetKey(KeyCode.D))//Movement();
        {
          rb.velocity = new Vector2(5, rb.velocity.y);
          transform.localScale = new Vector2(0.0181386f, 0.02003867f);
        }
    }
/*
    int dostrel = 0;
    dostrel = VypocetD(u, r);
    Debug.Log(dostrel);

    int VypocetD(int u, int r)
    {
      int d;
      int x;

      r = pow(r, 2);
      d = (r / 9.81) * (sin(2 * u));
      printf("%d", d);
      return d;
    }


    */
}
