using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void setVolume (float volumeVal)
    {
        audioMixer.SetFloat("Volume", volumeVal);
    }
}
