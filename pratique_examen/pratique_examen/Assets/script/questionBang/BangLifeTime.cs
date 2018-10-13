using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// gameObject = dans l'objet ou se trouve script / et l'autre GameObject= type

public class BangLifeTime : MonoBehaviour {
    [SerializeField] float Temps = 2;
    [SerializeField] Text TextBang;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Temps <= 0)
        {
            Destroy(gameObject);
        }
        else if(Temps > 0)
        {
            Temps -= Time.deltaTime;
            changerCouleur();
        }

	}

    void changerCouleur()
    {
        TextBang.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
