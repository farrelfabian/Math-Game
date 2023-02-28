using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string ThemePref = "ThemePref";
    private static readonly string SfxPref = "SfxPref";

    private int firstPlayInt;
    public Slider themeSlider, sfxSlider;
    private float themeFloat, sfxFloat;

    public AudioSource themeAudio;
    public AudioSource[] sfxAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {
            themeFloat = .125f;
            sfxFloat = .125f;
            themeSlider.value = themeFloat;
            sfxSlider.value = sfxFloat;
            PlayerPrefs.SetFloat(ThemePref, themeFloat);
            PlayerPrefs.SetFloat(SfxPref, sfxFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            themeFloat = PlayerPrefs.GetFloat(ThemePref);
            themeSlider.value = themeFloat;
            sfxFloat = PlayerPrefs.GetFloat(SfxPref);
            sfxSlider.value = sfxFloat;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(ThemePref, themeSlider.value);
        PlayerPrefs.SetFloat(SfxPref, sfxSlider.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        if(!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        themeAudio.volume = themeSlider.value;

        for(int i = 0; i < sfxAudio.Length; i++)
        {
            sfxAudio[i].volume = sfxSlider.value;
        }
    }


}
