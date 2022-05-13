using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBallCollision : MonoBehaviour
{
    //public Animator animator;
    // Start is called before the first frame update
    public Sound[] sounds;
    void Awake()
    {
        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

        }
    }
   
    public void OnTriggerEnter(Collider other){
       
        RandomSoundEffect(sounds);

    }
    public void RandomSoundEffect(params Sound[] clips)
	{
		int randomIndex = Random.Range(0, clips.Length);
		
		clips[randomIndex].source.Play();
	}
}
