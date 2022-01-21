using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioMixer masterMixer;

    public GameObject currentAudio;

    public Text currentSong;

    public List<GameObject> musicClips;

    public void Awake()
    {
        currentAudio.SetActive(true);
        currentSong.text = currentAudio.name;
    }

    public void SetSound(float soundLevel)
    {
        masterMixer.SetFloat("musicVol", soundLevel);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeAudio()
    {
        currentAudio.SetActive(false);

    }

    public void Sound1()
    {
        currentAudio.SetActive(false);
        musicClips[0].SetActive(true);
        currentAudio = musicClips[0];
        currentSong.text = currentAudio.name;
    }
    public void Sound2()
    {
        currentAudio.SetActive(false);
        musicClips[1].SetActive(true);
        currentAudio = musicClips[1];
        currentSong.text = currentAudio.name;
    }
    public void Sound3()
    {
        currentAudio.SetActive(false);
        musicClips[2].SetActive(true);
        currentAudio = musicClips[2];
        currentSong.text = currentAudio.name;
    }
    public void Sound4()
    {
        currentAudio.SetActive(false);
        musicClips[3].SetActive(true);
        currentAudio = musicClips[3];
        currentSong.text = currentAudio.name;
    }
    public void Sound5()
    {
        currentAudio.SetActive(false);
        musicClips[4].SetActive(true);
        currentAudio = musicClips[4];
        currentSong.text = currentAudio.name;
    }
    public void Sound6()
    {
        currentAudio.SetActive(false);
        musicClips[5].SetActive(true);
        currentAudio = musicClips[5];
        currentSong.text = currentAudio.name;
    }
    public void Sound7()
    {
        currentAudio.SetActive(false);
        musicClips[6].SetActive(true);
        currentAudio = musicClips[6];
        currentSong.text = currentAudio.name;
    }
    public void Sound8()
    {
        currentAudio.SetActive(false);
        musicClips[7].SetActive(true);
        currentAudio = musicClips[7];
        currentSong.text = currentAudio.name;
    }
}
