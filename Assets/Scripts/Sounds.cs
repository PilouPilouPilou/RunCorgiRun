using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioClip FallingSound;
    public AudioClip PillSound;
    public AudioClip BeerSound;
    public AudioClip MoonshineSound;
    public AudioClip PoopSound;
    public AudioClip BoneSound;
    
    public AudioSource AudioSource;

    public void PlayFallingSound()
    {
        AudioSource.PlayOneShot(FallingSound);
    }
    
    public void PlayPoopSound()
    {
        AudioSource.PlayOneShot(PoopSound);
    }
    
    public void PlayBoneSound()
    {
        AudioSource.PlayOneShot(BoneSound);
    }
    
    public void PlayPillSound()
    {
        AudioSource.PlayOneShot(PillSound);
    }
    
    public void PlayBeerSound()
    {
        AudioSource.PlayOneShot(BeerSound);
    }
    
    public void PlayMoonshineSound()
    {
        AudioSource.PlayOneShot(MoonshineSound);
    }
    
}
