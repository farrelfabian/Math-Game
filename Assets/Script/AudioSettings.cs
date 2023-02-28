using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    private static readonly string ThemePref = "ThemePref";
    private static readonly string SfxPref = "SfxPref";
    private float themeFloat, sfxFloat;
    public AudioSource themeAudio;
    public AudioSource[] sfxAudio;

    void Awake()
    {
        ContinueSettings();
    }

    private void ContinueSettings()
    {
        themeFloat = PlayerPrefs.GetFloat(ThemePref);
        sfxFloat = PlayerPrefs.GetFloat(SfxPref);

        themeAudio.volume = themeFloat;

        for(int i = 0; i < sfxAudio.Length; i++)
        {
            sfxAudio[i].volume = sfxFloat;
        }
    }
}
