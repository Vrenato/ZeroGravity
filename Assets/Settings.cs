using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public float volumevalue;
    private const string QualityKey = "QualityLevel";


    private void Start()
    {
        
        volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        

    }

    private void Update()
    {
        audioMixer.SetFloat("volume", volumevalue);
        PlayerPrefs.SetFloat("Volume", volumevalue);
    }
    //beállítja a hangerõt a megadott értékre
    public void SetVolume(float volume)
    {

        volumevalue = volume;
    }

    //beállítja a grafikát a megadott beállításra, és elmenti azt
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        PlayerPrefs.SetInt(QualityKey, qualityIndex);
        PlayerPrefs.Save();
    }
    //betölti a grafikai beállítást
    public void LoadQuality()
    {
        if (PlayerPrefs.HasKey(QualityKey))
        {
            int qualityIndex = PlayerPrefs.GetInt(QualityKey);
            QualitySettings.SetQualityLevel(qualityIndex);
        }
    }



}
