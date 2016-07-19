using UnityEngine;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MixControl : MonoBehaviour {

	public AudioMixer caveMusicMixer;
	public RandomMusicDemo randomMusic;
	public Text frequencyText;

	public void SetMusicVol(float musicVol)
	{
		caveMusicMixer.SetFloat ("CaveMusicVol", musicVol);
	}

	public void SetFrequency(float frequency)
	{
		randomMusic.barsPerTrigger=(int)frequency;
		frequencyText.text=("Every "+frequency+" Bars");
		randomMusic.ChangeTriggerTime();
	}
}
