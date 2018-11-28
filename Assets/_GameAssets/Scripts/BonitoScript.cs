using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonitoScript : MonoBehaviour {
    public int valor;

	public void Mueve() {
        GetComponent<Animator>().enabled = false;
        // HYA QUE LLAMAR AL iNVOKE PARA QUE DE TIEMPO A TERMINAR EL ANIMATION
        Invoke("Muevete", 0.1f);
        
    }


    public void Muevete() {
       this.transform.Translate(Vector3.forward * 2);
       
    }
}
