using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class VideoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MovieTexture movie = GetComponent<Renderer>().material.mainTexture as MovieTexture;
        GetComponent<AudioSource>().Play();
        movie.Play();
	}
	
}
