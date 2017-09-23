using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkin : MonoBehaviour {
    Transform trans1;
    Transform trans2;
    Transform trans3;

    void Start () {
        if (coin.bluecheck == true)
        {
            trans1 = transform.FindChild("Basic");
            trans1.gameObject.SetActive(false);
            trans2 = transform.FindChild("Black");
            trans2.gameObject.SetActive(false);
            trans3 = transform.FindChild("Yellow");
            trans3.gameObject.SetActive(false);
        }
        else if (coin.blackcheck == true)
        {
            trans1 = transform.FindChild("Basic");
            trans1.gameObject.SetActive(false);
            trans2 = transform.FindChild("Blue");
            trans2.gameObject.SetActive(false);
            trans3 = transform.FindChild("Yellow");
            trans3.gameObject.SetActive(false);
        }
        else if (coin.yellowcheck == true)
        {
            trans1 = transform.FindChild("Basic");
            trans1.gameObject.SetActive(false);
            trans2 = transform.FindChild("Black");
            trans2.gameObject.SetActive(false);
            trans3 = transform.FindChild("Blue");
            trans3.gameObject.SetActive(false);
        }
        else
        {
            trans1 = transform.FindChild("Blue");
            trans1.gameObject.SetActive(false);
            trans2 = transform.FindChild("Black");
            trans2.gameObject.SetActive(false);
            trans3 = transform.FindChild("Yellow");
            trans3.gameObject.SetActive(false);
        }
    }
}
