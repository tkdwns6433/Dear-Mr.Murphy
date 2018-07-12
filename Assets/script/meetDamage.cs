using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class meetDamage : MonoBehaviour {


    private void OnTriggerEnter2D()
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        Invoke("boxColliderOnAgain", 1);
    }

    private void boxColliderOnAgain()
    {
        this.GetComponent<BoxCollider2D>().enabled = true;
    }


}
