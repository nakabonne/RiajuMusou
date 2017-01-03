using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	public GameObject TargetChar;
	public AnimationClip Attack01Anim;
	public AnimationClip Attack02Anim;
	public AnimationClip GetHit01Anim;
	public AnimationClip GetHit02Anim;
	public AnimationClip DieAnim;
	public AnimationClip Die2Anim;
	public AnimationClip RiseUpAnim;
	public GameObject Weapon;
	
	//private MonoBehaviour CharControl;


	// Use this for initialization
	void Start () {

	//	CharControl = TargetChar.GetComponent<ThirdPersonController>();

	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.T))
		//(CharControl as MonoBehaviour).enabled = false;
		TargetChar.GetComponent<Animation>().Play (Attack01Anim.name);

		if (Input.GetKey (KeyCode.Y))
			TargetChar.GetComponent<Animation>().Play (Attack02Anim.name);

		if (Input.GetKey (KeyCode.I))
			TargetChar.GetComponent<Animation>().Play (GetHit01Anim.name);

		if (Input.GetKey (KeyCode.O))
			TargetChar.GetComponent<Animation>().Play (GetHit02Anim.name);

		if (Input.GetKey (KeyCode.G))
			TargetChar.GetComponent<Animation>().Play (Die2Anim.name);

		if (Input.GetKey (KeyCode.H))
			TargetChar.GetComponent<Animation>().Play (DieAnim.name);

		if (Input.GetKey (KeyCode.J))
			TargetChar.GetComponent<Animation>().Play (RiseUpAnim.name);

		if ((Input.GetKeyDown (KeyCode.P)) && Weapon.activeInHierarchy)
						Weapon.SetActive (false);
				else {
						if ((Input.GetKeyDown (KeyCode.P)) && !Weapon.activeInHierarchy)
								Weapon.SetActive (true);

				}
		
	}
}
