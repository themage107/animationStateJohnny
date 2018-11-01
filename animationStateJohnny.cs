using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateJohnny : MonoBehaviour {

    int animState;
    public Animator jAnim;

    int rndInt;

	// Use this for initialization
	void Start () {
        animState = jAnim.GetInteger("animationStateJohnny");
	}
	
	public void randomAnimation()
    {
        runCheck();
    }

    public void resetAnimation()
    {
        jAnim.SetInteger("animationStateJohnny", 0);
    }

    public void runCheck()
    {
        rndInt = Random.Range(0, 50);
        if(rndInt == 5)
        {
            jAnim.SetInteger("animationStateJohnny", 1);
        }
        if (rndInt == 10)
        {
            jAnim.SetInteger("animationStateJohnny", 2);
        }
        if (rndInt == 15)
        {
            jAnim.SetInteger("animationStateJohnny", 3);
        }        
    }
}
