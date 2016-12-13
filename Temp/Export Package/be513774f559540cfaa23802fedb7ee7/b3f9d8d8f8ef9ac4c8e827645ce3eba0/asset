using UnityEngine;
using System.Collections;

public class Anim : MonoBehaviour {

	private float 	time;
	private int 	cpt=0;
	
	Animator anim;
    int run	 = Animator.StringToHash("HumanoidRun");
    int walk = Animator.StringToHash("HumanoidWalk");


    void Start (){
        anim = GetComponent<Animator>();
        time =Time.deltaTime;
    }


    void Update (){
		transform.Rotate(0, -1, 0, Space.World);
    }
}
