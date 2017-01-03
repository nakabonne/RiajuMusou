using UnityEngine;
using System.Collections;

public class MorphUI : MonoBehaviour {

	public SkinnedMeshRenderer MorphMesh;
	public Color ColorPress;
	public int BlendShapeIndex;
	private Color ColorNormal;
	private bool press;


	// Use this for initialization
	void Start () {

		ColorNormal = gameObject.GetComponent<GUITexture>().color;
	
	}
	
	// Update is called once per frame
	void OnMouseUp () {

		if (!press)
				{
						gameObject.GetComponent<GUITexture>().color = ColorPress;
						MorphMesh.SetBlendShapeWeight(BlendShapeIndex,100);
						press=true;
				}
		else {
						gameObject.GetComponent<GUITexture>().color = ColorNormal;
						MorphMesh.SetBlendShapeWeight(BlendShapeIndex,0);
						press=false;
		}
		
				
	}
}
