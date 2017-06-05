using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HowToPlay : MonoBehaviour {

    public Texture Tut1;
    public Texture Tut2;
    public Texture Tut3;
    private IEnumerator coroutine;
    RawImage imageToChange;

	// Use this for initialization
	void Start ()
    {
        imageToChange = gameObject.GetComponent<RawImage>();
        coroutine = TutorialScreens(5);
        StartCoroutine(coroutine);
    }
    

    IEnumerator TutorialScreens(float delay)
    {
        imageToChange.texture = Tut1;
        yield return new WaitForSeconds(delay);
        imageToChange.texture = Tut2;
        yield return new WaitForSeconds(delay);
        imageToChange.texture = Tut3;
    }

    void StopCoroutine()
    {
        StopCoroutine(coroutine);
    }
}
