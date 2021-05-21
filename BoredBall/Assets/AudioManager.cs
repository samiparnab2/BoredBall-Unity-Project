using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

	public static AudioManager instance;
	public static bool isSet=false;
	public float musicvol,sfxvol;
	public bool isMute=false;
	public AudioMixerGroup mixerGroup;

	public Sound[] sounds;
void Awake()
{
	if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}	
}
	public void SetAll()
	{
		if(!isSet){

		

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;
			if(s.type=="music")
			{
				s.volume=musicvol;
			}
			else if(s.type=="sfx")
			{
				s.volume=sfxvol;
			}
			s.source.volume=s.volume;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
		isSet=true;
		}
	}
	
	public void Play(string sound)
	{
		Sound s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume ;
		s.source.pitch = s.pitch ;

		s.source.Play();
	}
	public void Mute()
	{

		isMute=true;
		foreach(Sound s in sounds)
		{
			s.volume=0;
			s.source.volume=s.volume;
		}
	}

	public void NotMute()
	{
		isMute=false;
		float msc,sfx;
		msc=musicvol;
		sfx=sfxvol;
		foreach(Sound s in sounds)
		{
			if(s.type=="music")
			{
			s.volume=msc;
			s.source.volume=s.volume;
			}
			else if(s.type=="sfx")
			{
				s.volume=sfx;
				s.source.volume=s.volume;
			}
		}
	}

}
